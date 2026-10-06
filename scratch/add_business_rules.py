import os
import re

bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

validations = {
    "clsStudent.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(NationalID))
            {
                errorMessage = "National ID is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(AdmissionNo))
            {
                errorMessage = "Admission No is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }
            
            // Check minimum age (e.g. 4 years)
            if (DateTime.Now.Year - DateOfBirth.Year < 4)
            {
                errorMessage = "Student must be at least 4 years old.";
                return false;
            }

            // Uniqueness checks (Using GetAll for simplicity in prototype, ideally use DAL methods)
            System.Data.DataTable dt = GetAllStudents();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["StudentID"] != this.StudentID)
                {
                    if (row["NationalID"].ToString() == this.NationalID)
                    {
                        errorMessage = "National ID already exists.";
                        return false;
                    }
                    if (row["AdmissionNo"].ToString() == this.AdmissionNo)
                    {
                        errorMessage = "Admission No already exists.";
                        return false;
                    }
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Email already exists.";
                        return false;
                    }
                }
            }
            
            return true;
        }
""",
    "clsTeacher.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                errorMessage = "A valid Email is required.";
                return false;
            }
            if (HireDate > DateTime.Now)
            {
                errorMessage = "Hire date cannot be in the future.";
                return false;
            }

            System.Data.DataTable dt = GetAllTeachers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["TeacherID"] != this.TeacherID)
                {
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Email already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsCourse.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (CreditHours <= 0)
            {
                errorMessage = "Credit Hours must be a positive integer.";
                return false;
            }

            System.Data.DataTable dt = GetAllCourses();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["CourseID"] != this.CourseID)
                {
                    if (row["Name"].ToString() == this.Name)
                    {
                        errorMessage = "Course Name already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsAttendance.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (Date > DateTime.Now)
            {
                errorMessage = "Cannot record attendance for a future date.";
                return false;
            }
            if (Status != "Present" && Status != "Absent" && Status != "Late")
            {
                errorMessage = "Status must be Present, Absent, or Late.";
                return false;
            }

            System.Data.DataTable dt = GetAllAttendances();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["AttendanceID"] != this.AttendanceID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["SessionID"] == this.SessionID && ((DateTime)row["Date"]).Date == this.Date.Date)
                    {
                        errorMessage = "Duplicate attendance record for this student on the same session and date.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsGrade.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (GradeValue < 0 || OutOfValue <= 0 || GradeValue > OutOfValue)
            {
                errorMessage = "Grade value must be positive and cannot exceed OutOfValue.";
                return false;
            }

            System.Data.DataTable dt = GetAllGrades();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["GradeID"] != this.GradeID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["CourseID"] == this.CourseID && (int)row["ExamTypeID"] == this.ExamTypeID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "Student already has a grade for this course, exam type, and academic year.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsInvoice.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (IssueDate > DueDate)
            {
                errorMessage = "Issue date cannot be after due date.";
                return false;
            }
            if (DiscountAmount < 0 || TaxAmount < 0)
            {
                errorMessage = "Discount and Tax amounts cannot be negative.";
                return false;
            }

            System.Data.DataTable dt = GetAllInvoices();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["InvoiceID"] != this.InvoiceID)
                {
                    if (row["InvoiceNumber"].ToString() == this.InvoiceNumber)
                    {
                        errorMessage = "Invoice Number already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsPayment.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (Amount <= 0)
            {
                errorMessage = "Payment amount must be positive.";
                return false;
            }

            // Ideally, we'd check against remaining balance of the invoice here.
            
            return true;
        }
""",
    "clsUser.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (UserType != "Admin" && UserType != "Teacher" && UserType != "Parent" && UserType != "Student")
            {
                errorMessage = "UserType must be Admin, Teacher, Parent, or Student.";
                return false;
            }

            System.Data.DataTable dt = GetAllUsers();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["UserID"] != this.UserID)
                {
                    if (row["Username"].ToString() == this.Username)
                    {
                        errorMessage = "Username already exists.";
                        return false;
                    }
                    if (row["Email"].ToString() == this.Email)
                    {
                        errorMessage = "Email already exists.";
                        return false;
                    }
                }
            }
            return true;
        }
"""
}


for filename, validation_code in validations.items():
    filepath = os.path.join(bll_dir, filename)
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()

    # If it already has Validate, skip
    if "public bool Validate(out string errorMessage)" in content:
        continue

    # Insert validation method before "public bool Save()"
    if "public bool Save()" in content:
        content = content.replace("public bool Save()", validation_code + "\n        public bool Save()")
        
        # Now modify the Save() method to call Validate
        # Find the Save method block and insert the check
        save_match = re.search(r'public bool Save\(\)\s*\{', content)
        if save_match:
            insert_pos = save_match.end()
            validation_check = """
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage); // Throw exception to be handled by Presentation Layer
            }
"""
            content = content[:insert_pos] + validation_check + content[insert_pos:]
            
        with open(filepath, "w", encoding="utf-8") as f:
            f.write(content)
            print(f"Added business rules to {filename}")
