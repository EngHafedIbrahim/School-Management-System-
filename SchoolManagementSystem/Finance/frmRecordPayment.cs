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
                MessageBox.Show("Invoice details could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];
            lblInvoiceNoVal.Text = row["InvoiceNumber"].ToString();
            lblStudentNameVal.Text = row["StudentName"].ToString();

            _totalAmount = Convert.ToDecimal(row["TotalAmount"]);
            _paidAmount = Convert.ToDecimal(row["PaidAmount"]);
            _remainingAmount = Convert.ToDecimal(row["RemainingAmount"]);

            lblTotalVal.Text = $"$ {_totalAmount:N2}";
            lblPaidVal.Text = $"$ {_paidAmount:N2}";
            lblRemainingVal.Text = $"$ {_remainingAmount:N2}";

            if (_remainingAmount <= 0)
            {
                MessageBox.Show("This invoice is already fully paid. No further payments can be recorded.", "Invoice Settled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                numAmount.Enabled = false;
                return;
            }

            // Set default amount to remaining balance
            numAmount.Maximum = _remainingAmount;
            numAmount.Value = _remainingAmount;
            dtpPaymentDate.Value = DateTime.Today;

            // Generate receipt number suggestion
            txtReceiptNo.Text = $"REC-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
        }

        private bool ValidatePayment()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (numAmount.Value <= 0)
            {
                errorProvider1.SetError(numAmount, "Payment amount must be greater than zero.");
                isValid = false;
            }
            else if (numAmount.Value > _remainingAmount)
            {
                errorProvider1.SetError(numAmount, $"Amount cannot exceed remaining balance (${_remainingAmount:N2}).");
                isValid = false;
            }

            if (cbPaymentType.SelectedValue == null)
            {
                errorProvider1.SetError(cbPaymentType, "Please select a payment type.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReceiptNo.Text))
            {
                errorProvider1.SetError(txtReceiptNo, "Receipt number is required.");
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
            int currentUserID = clsGloble.CurrentUser?.UserID ?? 1;

            // Execute Transaction in DAL: Payment Insert + Invoice Recalculation & Status Update
            int paymentID = clsPayment.RecordPaymentWithTransaction(
                _invoiceID, paymentDate, amount, paymentMethod, paymentTypeID,
                receiptNumber, receiptNumber, notes, currentUserID, out string errorMessage);

            if (paymentID > 0)
            {
                PaymentRecordedSuccessfully = true;
                MessageBox.Show($"Payment of ${amount:N2} recorded successfully!\nReceipt No: {receiptNumber}\nPayment ID: {paymentID}",
                    "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Failed to record payment:\n{errorMessage}", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
