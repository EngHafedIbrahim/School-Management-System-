using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{
    public class clsPayment
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentTypeID { get; set; }
        public string TransactionID { get; set; }
        public string ReceiptNumber { get; set; }
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsInvoice InvoiceInfo => clsInvoice.Find(this.InvoiceID);
        public clsPaymentType PaymentTypeInfo => clsPaymentType.Find(this.PaymentTypeID);

        public clsPayment()
        {
            this.PaymentID = -1;
            this.InvoiceID = -1;
            this.PaymentDate = DateTime.Now;
            this.Amount = -1;
            this.PaymentMethod = "";
            this.PaymentTypeID = -1;
            this.TransactionID = "";
            this.ReceiptNumber = "";
            this.Notes = "";
            this.CreatedBy = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }

        private clsPayment(int PaymentID, int InvoiceID, DateTime PaymentDate, decimal Amount, string PaymentMethod, int PaymentTypeID, string TransactionID, string ReceiptNumber, string Notes, int CreatedBy, DateTime CreatedAt)
        {
            this.PaymentID = PaymentID;
            this.InvoiceID = InvoiceID;
            this.PaymentDate = PaymentDate;
            this.Amount = Amount;
            this.PaymentMethod = PaymentMethod;
            this.PaymentTypeID = PaymentTypeID;
            this.TransactionID = TransactionID;
            this.ReceiptNumber = ReceiptNumber;
            this.Notes = Notes;
            this.CreatedBy = CreatedBy;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }

        public static clsPayment Find(int PaymentID)
        {
            int InvoiceID = -1;
            DateTime PaymentDate = DateTime.Now;
            decimal Amount = -1;
            string PaymentMethod = "";
            int PaymentTypeID = -1;
            string TransactionID = "";
            string ReceiptNumber = "";
            string Notes = "";
            int CreatedBy = -1;
            DateTime CreatedAt = DateTime.Now;
            if (clsDAPayment.Find(PaymentID, ref InvoiceID, ref PaymentDate, ref Amount, ref PaymentMethod, ref PaymentTypeID, ref TransactionID, ref ReceiptNumber, ref Notes, ref CreatedBy, ref CreatedAt))
                return new clsPayment(PaymentID, InvoiceID, PaymentDate, Amount, PaymentMethod, PaymentTypeID, TransactionID, ReceiptNumber, Notes, CreatedBy, CreatedAt);
            return null;
        }

        private bool _AddNewPayment()
        {
            this.PaymentID = clsDAPayment.AddNewPayment(this.InvoiceID, this.PaymentDate, this.Amount, this.PaymentMethod, this.PaymentTypeID, this.TransactionID, this.ReceiptNumber, this.Notes, this.CreatedBy, this.CreatedAt);
            return (this.PaymentID != -1);
        }

        private bool _UpdatePayment()
        {
            return clsDAPayment.UpdatePayment(this.PaymentID, this.InvoiceID, this.PaymentDate, this.Amount, this.PaymentMethod, this.PaymentTypeID, this.TransactionID, this.ReceiptNumber, this.Notes, this.CreatedBy, this.CreatedAt);
        }

        public bool Validate(out string errorMessage)
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
                DataTable payments = GetAllPayments();
                foreach (DataRow row in payments.Rows)
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
        }

        public bool Save()
        {
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage);
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }

        public static DataTable GetAllPayments() => clsDAPayment.GetAllPayments();
        public static bool IsPaymentExist(int PaymentID) => clsDAPayment.IsPaymentExist(PaymentID);
        public static bool DeletePayment(int PaymentID) => clsDAPayment.DeletePayment(PaymentID);
    
        public static DataTable GetPaymentsByInvoiceID(int invoiceID) => clsDAPayment.GetPaymentsByInvoiceID(invoiceID);
        public static DataTable GetAllPaymentsDetailed() => clsDAPayment.GetAllPaymentsDetailed();
        public static bool GetPaymentStatistics(ref decimal totalCollected, ref decimal todayCollected, ref decimal monthCollected, ref int paymentCount)
            => clsDAPayment.GetPaymentStatistics(ref totalCollected, ref todayCollected, ref monthCollected, ref paymentCount);
        public static DataTable GetPaymentReceiptDetails(int paymentID) => clsDAPayment.GetPaymentReceiptDetails(paymentID);
        
        public static int RecordPaymentWithTransaction(int invoiceID, DateTime paymentDate, decimal amount,
            string paymentMethod, int paymentTypeID, string transactionID, string receiptNumber,
            string notes, int createdBy, out string errorMessage)
        {
            return clsDAPayment.RecordPaymentWithTransaction(invoiceID, paymentDate, amount,
                paymentMethod, paymentTypeID, transactionID, receiptNumber, notes, createdBy, out errorMessage);
        }

        // New: Sequential receipt number generation
        public static string GetNextReceiptNumber() => clsDAPayment.GetNextReceiptNumber();
    }
}
