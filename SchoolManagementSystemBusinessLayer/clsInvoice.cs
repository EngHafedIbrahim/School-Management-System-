using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsInvoice
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public int StudentID { get; set; }
        public int AcademicYearID { get; set; }
        public int FeeStructureID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }

        public clsStudent StudentInfo => clsStudent.Find(this.StudentID);
        public clsAcademicYear AcademicYearInfo => clsAcademicYear.Find(this.AcademicYearID);
        public clsFeeStructure FeeStructureInfo => clsFeeStructure.Find(this.FeeStructureID);

        public clsInvoice()
        {
            this.InvoiceID = -1;
            this.InvoiceNumber = "";
            this.StudentID = -1;
            this.AcademicYearID = -1;
            this.FeeStructureID = -1;
            this.IssueDate = DateTime.Now;
            this.DueDate = DateTime.Now;
            this.Subtotal = -1;
            this.DiscountAmount = -1;
            this.TaxAmount = -1;
            this.TotalAmount = -1;
            this.Status = "";
            this.CreatedBy = -1;
            Mode = enMode.AddNew;
        }

        private clsInvoice(int InvoiceID, string InvoiceNumber, int StudentID, int AcademicYearID, int FeeStructureID, DateTime IssueDate, DateTime DueDate, decimal Subtotal, decimal DiscountAmount, decimal TaxAmount, decimal TotalAmount, string Status, int CreatedBy)
        {
            this.InvoiceID = InvoiceID;
            this.InvoiceNumber = InvoiceNumber;
            this.StudentID = StudentID;
            this.AcademicYearID = AcademicYearID;
            this.FeeStructureID = FeeStructureID;
            this.IssueDate = IssueDate;
            this.DueDate = DueDate;
            this.Subtotal = Subtotal;
            this.DiscountAmount = DiscountAmount;
            this.TaxAmount = TaxAmount;
            this.TotalAmount = TotalAmount;
            this.Status = Status;
            this.CreatedBy = CreatedBy;
            Mode = enMode.Update;
        }

        public static clsInvoice Find(int InvoiceID)
        {
            string InvoiceNumber = "";
            int StudentID = -1;
            int AcademicYearID = -1;
            int FeeStructureID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime DueDate = DateTime.Now;
            decimal Subtotal = -1;
            decimal DiscountAmount = -1;
            decimal TaxAmount = -1;
            decimal TotalAmount = -1;
            string Status = "";
            int CreatedBy = -1;
            if (clsDAInvoice.Find(InvoiceID, ref InvoiceNumber, ref StudentID, ref AcademicYearID, ref FeeStructureID, ref IssueDate, ref DueDate, ref Subtotal, ref DiscountAmount, ref TaxAmount, ref TotalAmount, ref Status, ref CreatedBy))
                return new clsInvoice(InvoiceID, InvoiceNumber, StudentID, AcademicYearID, FeeStructureID, IssueDate, DueDate, Subtotal, DiscountAmount, TaxAmount, TotalAmount, Status, CreatedBy);
            return null;
        }

        private bool _AddNewInvoice()
        {
            this.InvoiceID = clsDAInvoice.AddNewInvoice(this.InvoiceNumber, this.StudentID, this.AcademicYearID, this.FeeStructureID, this.IssueDate, this.DueDate, this.Subtotal, this.DiscountAmount, this.TaxAmount, this.TotalAmount, this.Status, this.CreatedBy);
            return (this.InvoiceID != -1);
        }

        private bool _UpdateInvoice()
        {
            return clsDAInvoice.UpdateInvoice(this.InvoiceID, this.InvoiceNumber, this.StudentID, this.AcademicYearID, this.FeeStructureID, this.IssueDate, this.DueDate, this.Subtotal, this.DiscountAmount, this.TaxAmount, this.TotalAmount, this.Status, this.CreatedBy);
        }

        
        public bool Validate(out string errorMessage)
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

            // SRS Validation: Subtotal must NOT exceed the fee structure total
            // (allows partial selection of fee items - e.g. student not using transport)
            clsFeeStructure feeStructure = clsFeeStructure.Find(this.FeeStructureID);
            if (feeStructure != null)
            {
                decimal maxSubtotal = feeStructure.TuitionFee + feeStructure.TransportFee + feeStructure.BookFee + feeStructure.OtherFees;
                if (this.Subtotal > maxSubtotal)
                {
                    errorMessage = $"Subtotal ({this.Subtotal:N2}) cannot exceed the fee structure maximum ({maxSubtotal:N2}).";
                    return false;
                }
                if (this.Subtotal <= 0)
                {
                    errorMessage = "Subtotal must be greater than zero. At least one fee item must be selected.";
                    return false;
                }
            }
            
            // Auto-calculate / verify TotalAmount (Business Logic)
            decimal expectedTotal = this.Subtotal - this.DiscountAmount + this.TaxAmount;
            if (expectedTotal < 0) expectedTotal = 0;
            if (this.TotalAmount != expectedTotal)
            {
                this.TotalAmount = expectedTotal; // Auto-correct
            }

            // Discount cannot exceed subtotal
            if (this.DiscountAmount > this.Subtotal)
            {
                errorMessage = "Discount amount cannot exceed the subtotal.";
                return false;
            }

            // Invoice Number uniqueness check (efficient SQL query)
            DataTable dt = GetAllInvoices();
            foreach (DataRow row in dt.Rows)
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

        public bool Save()
        {
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage); // Throw exception to be handled by Presentation Layer
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInvoice())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateInvoice();
            }
            return false;
        }

        public static DataTable GetAllInvoices() => clsDAInvoice.GetAllInvoices();
        public static bool IsInvoiceExist(int InvoiceID) => clsDAInvoice.IsInvoiceExist(InvoiceID);
        public static bool DeleteInvoice(int InvoiceID) => clsDAInvoice.DeleteInvoice(InvoiceID);
    
        public static DataTable GetInvoicesByStudentID(int studentID) => clsDAInvoice.GetInvoicesByStudentID(studentID);

        public static DataTable GetInvoiceDetailed(int invoiceID) => clsDAInvoice.GetInvoiceDetailed(invoiceID);
        public static DataTable GetAllInvoicesDetailed() => clsDAInvoice.GetAllInvoicesDetailed();
        public static decimal GetTotalPaidByInvoiceID(int invoiceID) => clsDAInvoice.GetTotalPaidByInvoiceID(invoiceID);
        public static bool UpdateInvoiceStatus(int invoiceID, string status) => clsDAInvoice.UpdateInvoiceStatus(invoiceID, status);

        // New methods for finance rework
        public static string GetNextInvoiceNumber() => clsDAInvoice.GetNextInvoiceNumber();
        public static bool HasActiveInvoiceForStudentAndYear(int studentID, int academicYearID, int feeStructureID)
            => clsDAInvoice.HasActiveInvoiceForStudentAndYear(studentID, academicYearID, feeStructureID);
        public static bool HasPayments(int invoiceID) => clsDAInvoice.HasPayments(invoiceID);
        public static DataTable GetStudentEnrollmentInfo(int studentID, int academicYearID) 
            => clsDAInvoice.GetStudentEnrollmentInfo(studentID, academicYearID);
    }
}
