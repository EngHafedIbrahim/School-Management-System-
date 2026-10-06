import os
import re

bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"
invoice_path = os.path.join(bll_dir, "clsInvoice.cs")

invoice_fix = """        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (IssueDate > DueDate)
            {
                errorMessage = "Issue date cannot be after due date.";
                return false;
            }
            if (DiscountAmount < 0 || TaxAmount < 0 || Subtotal < 0)
            {
                errorMessage = "Amounts cannot be negative.";
                return false;
            }

            // SRS Validation: Subtotal must match the applied fee structure
            clsFeeStructure feeStructure = clsFeeStructure.Find(this.FeeStructureID);
            if (feeStructure != null)
            {
                decimal expectedSubtotal = feeStructure.TuitionFee + feeStructure.TransportFee + feeStructure.BookFee + feeStructure.OtherFees;
                if (this.Subtotal != expectedSubtotal)
                {
                    errorMessage = $"Subtotal ({this.Subtotal}) does not match the applied fee structure total ({expectedSubtotal}).";
                    return false;
                }
            }
            
            // Auto-calculate / verify TotalAmount (Business Logic)
            decimal expectedTotal = this.Subtotal - this.DiscountAmount + this.TaxAmount;
            if (this.TotalAmount != expectedTotal)
            {
                this.TotalAmount = expectedTotal; // Auto-correct
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
        }"""

with open(invoice_path, "r", encoding="utf-8") as f:
    content = f.read()

content = re.sub(r'public bool Validate\(out string errorMessage\).*?return true;\s*\}', invoice_fix, content, flags=re.DOTALL)

with open(invoice_path, "w", encoding="utf-8") as f:
    f.write(content)
    print("Fixed clsInvoice.cs validation")
