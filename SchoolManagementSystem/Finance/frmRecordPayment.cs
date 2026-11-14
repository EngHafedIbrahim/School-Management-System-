using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmRecordPayment : Form
    {
        private readonly int _invoiceID;
        private decimal _totalAmount = 0;
        private decimal _paidAmount = 0;
        private decimal _remainingAmount = 0;

        public bool PaymentRecordedSuccessfully { get; private set; } = false;

        public frmRecordPayment(int invoiceID)
        {
            _invoiceID = invoiceID;
            InitializeComponent();

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);
        }

        private void FrmRecordPayment_Load(object sender, EventArgs e)
        {
            LoadPaymentTypes();
            LoadInvoiceDetails();
        }

        private void LoadPaymentTypes()
        {
            DataTable dtTypes = clsPaymentType.GetAllPaymentTypes();
            cbPaymentType.DataSource = dtTypes;
            cbPaymentType.DisplayMember = "Name";
            cbPaymentType.ValueMember = "PaymentTypeID";
        }

        private void LoadInvoiceDetails()
        {
            DataTable dt = clsInvoice.GetInvoiceDetailed(_invoiceID);
            if (dt == null || dt.Rows.Count == 0)
            {
                clsUITheme.ShowArabicMessage("تعذر تحميل تفاصيل الفاتورة المطلوبة.", "خطأ في التحميل", MessageBoxIcon.Error);
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];
            lblInvoiceNoVal.Text = row["InvoiceNumber"].ToString();
            lblStudentNameVal.Text = row["StudentName"].ToString();

            _totalAmount = Convert.ToDecimal(row["TotalAmount"]);
            _paidAmount = Convert.ToDecimal(row["PaidAmount"]);
            _remainingAmount = Convert.ToDecimal(row["RemainingAmount"]);

            lblTotalVal.Text = $"{_totalAmount:N2} د.أ";
            lblPaidVal.Text = $"{_paidAmount:N2} د.أ";
            lblRemainingVal.Text = $"{_remainingAmount:N2} د.أ";

            if (_remainingAmount <= 0)
            {
                clsUITheme.ShowArabicMessage("تم سداد كامل قيمة هذه الفاتورة مسبقاً، ولا يمكن تسجيل دفعات إضافية عليها.", "فاتورة مسددة", MessageBoxIcon.Information);
                btnSave.Enabled = false;
                numAmount.Enabled = false;
                return;
            }

            // Set default amount to remaining balance
            numAmount.Maximum = _remainingAmount;
            numAmount.Value = _remainingAmount;
            dtpPaymentDate.Value = DateTime.Today;

            // Generate sequential receipt number (concurrency-safe)
            txtReceiptNo.Text = clsPayment.GetNextReceiptNumber();
        }

        private bool ValidatePayment()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (numAmount.Value <= 0)
            {
                errorProvider1.SetError(numAmount, "يجب أن تكون قيمة الدفعة أكبر من صفر.");
                isValid = false;
            }
            else if (numAmount.Value > _remainingAmount)
            {
                errorProvider1.SetError(numAmount, $"لا يمكن أن يتجاوز المبلغ الرصيد المتبقي ({_remainingAmount:N2} د.أ).");
                isValid = false;
            }

            if (cbPaymentType.SelectedValue == null)
            {
                errorProvider1.SetError(cbPaymentType, "يرجى تحديد طريقة الدفع.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReceiptNo.Text))
            {
                errorProvider1.SetError(txtReceiptNo, "رقم إيصال القبض مطلوب.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePayment())
                return;

            decimal amount = numAmount.Value;
            DateTime paymentDate = dtpPaymentDate.Value;
            int paymentTypeID = (int)cbPaymentType.SelectedValue;
            string paymentMethod = cbPaymentType.Text;
            string receiptNumber = txtReceiptNo.Text.Trim();
            string notes = txtNotes.Text.Trim();
            int currentUserID = clsGloble.UserID;

            // FIX: Separate TransactionID from ReceiptNumber
            // TransactionID is for bank/card transactions; empty for cash payments
            string transactionID = "";
            if (paymentMethod != "Cash" && paymentMethod != "نقداً")
            {
                transactionID = receiptNumber;
            }

            // Execute Transaction in DAL: Payment Insert + Invoice Recalculation & Status Update
            int paymentID = clsPayment.RecordPaymentWithTransaction(
                _invoiceID, paymentDate, amount, paymentMethod, paymentTypeID,
                transactionID, receiptNumber, notes, currentUserID, out string errorMessage);

            if (paymentID > 0)
            {
                PaymentRecordedSuccessfully = true;
                clsUITheme.ShowArabicMessage(
                    $"تم تسجيل دفعة مالية بقيمة {amount:N2} د.أ بنجاح!\n\nرقم الإيصال: {receiptNumber}\nرقم السند: {paymentID}",
                    "تم تسجيل الدفعة بنجاح", 
                    MessageBoxIcon.Information);
                    
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                clsUITheme.ShowArabicMessage($"تعذر تسجيل الدفعة:\n{errorMessage}", "فشل تسجيل الدفعة", MessageBoxIcon.Error);
                // Refresh remaining in case it was a concurrency issue
                LoadInvoiceDetails();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
