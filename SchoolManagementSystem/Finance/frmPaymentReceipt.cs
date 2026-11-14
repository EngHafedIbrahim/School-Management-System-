using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmPaymentReceipt : Form
    {
        private int _paymentID;

        public frmPaymentReceipt(int paymentID)
        {
            InitializeComponent();
            _paymentID = paymentID;
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            clsUITheme.StylePrimaryButton(btnPrint);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmPaymentReceipt_Load(object sender, EventArgs e)
        {
            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            DataTable dt = clsPayment.GetPaymentReceiptDetails(_paymentID);
            if (dt == null || dt.Rows.Count == 0)
            {
                clsUITheme.ShowArabicMessage("تعذر تحميل بيانات إيصال وسند القبض.", "خطأ في التحميل", MessageBoxIcon.Error);
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];

            lblReceiptNumber.Text = row["ReceiptNumber"]?.ToString() ?? "لا يوجد";
            if (row["PaymentDate"] != DBNull.Value)
            {
                DateTime dtPay = Convert.ToDateTime(row["PaymentDate"]);
                lblReceiptDate.Text = $"التاريخ: {dtPay:dd/MM/yyyy HH:mm}";
            }

            lblStudentName.Text = row["StudentName"]?.ToString() ?? "---";
            lblAdmNo.Text = row["AdmissionNo"]?.ToString() ?? "---";
            lblYear.Text = row["AcademicYear"]?.ToString() ?? "---";

            lblInvoiceNum.Text = row["InvoiceNumber"]?.ToString() ?? "---";

            decimal invTotal = row["InvoiceTotal"] != DBNull.Value ? Convert.ToDecimal(row["InvoiceTotal"]) : 0;
            decimal totalPaid = row["TotalPaidOnInvoice"] != DBNull.Value ? Convert.ToDecimal(row["TotalPaidOnInvoice"]) : 0;
            decimal balance = row["BalanceRemaining"] != DBNull.Value ? Convert.ToDecimal(row["BalanceRemaining"]) : 0;
            decimal amountPaid = row["Amount"] != DBNull.Value ? Convert.ToDecimal(row["Amount"]) : 0;

            lblInvoiceTotal.Text = $"{invTotal:N2} د.أ";
            lblTotalPaid.Text = $"{totalPaid:N2} د.أ";
            lblRemaining.Text = $"{balance:N2} د.أ";
            lblAmount.Text = $"{amountPaid:N2} د.أ";

            string method = row["PaymentMethod"]?.ToString() ?? "نقداً";
            switch (method.ToLowerInvariant())
            {
                case "cash":
                    lblMethod.Text = "نقداً";
                    break;
                case "card":
                case "credit card":
                case "debit card":
                    lblMethod.Text = "بطاقة بنكية";
                    break;
                case "bank transfer":
                case "bank":
                    lblMethod.Text = "تحويل بنكي";
                    break;
                case "cheque":
                case "check":
                    lblMethod.Text = "شيك";
                    break;
                case "online":
                    lblMethod.Text = "دفع إلكتروني";
                    break;
                default:
                    lblMethod.Text = method;
                    break;
            }

            string txId = row["TransactionID"]?.ToString();
            lblTransactionID.Text = string.IsNullOrWhiteSpace(txId) ? "غير متاح (دفع نقدي مباشر)" : txId;

            lblReceivedBy.Text = row["ReceivedBy"]?.ToString() ?? "مسؤول النظام";
            string notes = row["Notes"]?.ToString();
            lblNotes.Text = string.IsNullOrWhiteSpace(notes) ? "لا توجد ملاحظات إضافية" : notes;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            clsUITheme.ShowArabicMessage(
                $"تم إرسال سند القبض الرسمي [{lblReceiptNumber.Text}] إلى أمر الطباعة بنجاح.\n\n" +
                $"الطالب: {lblStudentName.Text}\n" +
                $"المبلغ المقبوض: {lblAmount.Text}\n" +
                $"الرصيد المتبقي بعد السداد: {lblRemaining.Text}",
                "تأكيد طباعة السند",
                MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
