import os
import re

bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

validations = {
    "clsAcademicYear.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (StartDate >= EndDate)
            {
                errorMessage = "Start date must be before end date.";
                return false;
            }

            System.Data.DataTable dt = GetAllAcademicYears();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["AcademicYearID"] != this.AcademicYearID)
                {
                    if (row["YearName"].ToString() == this.YearName)
                    {
                        errorMessage = "Academic Year Name already exists.";
                        return false;
                    }
                    if (this.IsCurrent && (bool)row["IsCurrent"])
                    {
                        errorMessage = "There can only be one Current Academic Year at a time.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsParent.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }

            System.Data.DataTable dt = GetAllParents();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ParentID"] != this.ParentID)
                {
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Parent Email already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsRoom.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            if (Capacity <= 0)
            {
                errorMessage = "Capacity must be a positive number.";
                return false;
            }

            System.Data.DataTable dt = GetAllRooms();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["RoomID"] != this.RoomID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Room Name already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsClass.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            System.Data.DataTable dt = GetAllClasss();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ClassID"] != this.ClassID)
                {
                    if (row["Name"].ToString() == this.Name && (int)row["GradeLevelID"] == this.GradeLevelID)
                    {
                        errorMessage = "Class Name already exists in this Grade Level.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsExamType.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            System.Data.DataTable dt = GetAllExamTypes();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ExamTypeID"] != this.ExamTypeID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Exam Type Name already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
"""
}

# Update clsPayment validation to check remaining balance
payment_fix = """        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (Amount <= 0)
            {
                errorMessage = "Payment amount must be positive.";
                return false;
            }

            // SRS 4.4: Payment amount cannot exceed remaining balance of the invoice
            clsInvoice invoice = clsInvoice.Find(this.InvoiceID);
            if (invoice != null)
            {
                decimal totalPaid = 0;
                System.Data.DataTable payments = GetAllPayments();
                foreach (System.Data.DataRow row in payments.Rows)
                {
                    if ((int)row["InvoiceID"] == this.InvoiceID && (int)row["PaymentID"] != this.PaymentID)
                    {
                        totalPaid += (decimal)row["Amount"];
                    }
                }
                
                decimal remainingBalance = invoice.TotalAmount - totalPaid;
                if (this.Amount > remainingBalance)
                {
                    errorMessage = $"Payment amount ({this.Amount}) exceeds the remaining balance ({remainingBalance}) of the invoice.";
                    return false;
                }
            }
            else
            {
                errorMessage = "Associated invoice not found.";
                return false;
            }
            
            return true;
        }"""

for filename, validation_code in validations.items():
    filepath = os.path.join(bll_dir, filename)
    if not os.path.exists(filepath):
        continue
        
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()

    if "public bool Validate(out string errorMessage)" not in content:
        if "public bool Save()" in content:
            content = content.replace("public bool Save()", validation_code + "\n        public bool Save()")
            
            save_match = re.search(r'public bool Save\(\)\s*\{', content)
            if save_match:
                insert_pos = save_match.end()
                validation_check = """
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage);
            }
"""
                content = content[:insert_pos] + validation_check + content[insert_pos:]
                
            with open(filepath, "w", encoding="utf-8") as f:
                f.write(content)
                print(f"Added business rules to {filename}")

# Fix payment validation
payment_path = os.path.join(bll_dir, "clsPayment.cs")
with open(payment_path, "r", encoding="utf-8") as f:
    payment_content = f.read()
    
# Replace the old Validate method with the new one
payment_content = re.sub(r'public bool Validate\(out string errorMessage\).*?return true;\s*\}', payment_fix, payment_content, flags=re.DOTALL)

with open(payment_path, "w", encoding="utf-8") as f:
    f.write(payment_content)
    print("Fixed clsPayment.cs validation")

