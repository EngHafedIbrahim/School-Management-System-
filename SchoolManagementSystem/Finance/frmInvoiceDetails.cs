using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmInvoiceDetails : Form
    {
        private readonly int _invoiceID;
        private int _studentID = -1;
        private decimal _remainingAmount = 0;

        public frmInvoiceDetails(int invoiceID)
        {
            _invoiceID = invoiceID;
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvPayments);
            clsUITheme.StylePrimaryButton(btnRecordPayment);
            clsUITheme.StyleSecondaryButton(btnPrint);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmInvoiceDetails_Load(object sender, EventArgs e)
        {
            if (!CheckAuthorization())
            {
                MessageBox.Show("Access Denied: You do not have permission to view this invoice.", "Authorization Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            LoadInvoiceData();
        }

        private bool CheckAuthorization()
        {
            // First fetch the student linked to this invoice
            DataTable dt = clsInvoice.GetInvoiceDetailed(_invoiceID);
            if (dt == null || dt.Rows.Count == 0)
                return false;

            _studentID = Convert.ToInt32(dt.Rows[0]["StudentID"]);

            // If current user is Parent, enforce StudentParent relationship check
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserType == "Parent")
            {
                int? parentID = clsGloble.CurrentUser.ReferenceID;
                if (!parentID.HasValue || !clsStudentParent.IsParentOfStudent(parentID.Value, _studentID))
                {
                    return false;
                }

                // Parents cannot record payments directly in MVP
                btnRecordPayment.Visible = false;
            }

            return true;
        }

        public void LoadInvoiceData()
        {
            DataTable dt = clsInvoice.GetInvoiceDetailed(_invoiceID);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Invoice record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];

            lblInvoiceNoVal.Text = row["InvoiceNumber"].ToString();
            lblStudentNameVal.Text = row["StudentName"].ToString();
            lblAdmissionNoVal.Text = row["AdmissionNumber"].ToString();
            lblAcademicYearVal.Text = row["AcademicYear"].ToString();
            lblIssueDateVal.Text = Convert.ToDateTime(row["IssueDate"]).ToString("yyyy-MM-dd");
            lblDueDateVal.Text = Convert.ToDateTime(row["DueDate"]).ToString("yyyy-MM-dd");

            decimal subtotal = Convert.ToDecimal(row["Subtotal"]);
            decimal discount = Convert.ToDecimal(row["DiscountAmount"]);
            decimal tax = Convert.ToDecimal(row["TaxAmount"]);
            decimal total = Convert.ToDecimal(row["TotalAmount"]);
            decimal paid = Convert.ToDecimal(row["PaidAmount"]);
            _remainingAmount = Convert.ToDecimal(row["RemainingAmount"]);
            string status = row["Status"].ToString();

            lblSubtotalVal.Text = $"$ {subtotal:N2}";
            lblDiscountVal.Text = $"$ {discount:N2}";
            lblTaxVal.Text = $"$ {tax:N2}";
            lblTotalVal.Text = $"$ {total:N2}";
            lblPaidVal.Text = $"$ {paid:N2}";
            lblRemainingVal.Text = $"$ {_remainingAmount:N2}";

            UpdateStatusBadge(status, _remainingAmount);

            // Load Payments Grid
            LoadPaymentsGrid();

            // Disable Record Payment button if fully settled
            if (_remainingAmount <= 0)
            {
                btnRecordPayment.Enabled = false;
                btnRecordPayment.Text = "Invoice Settled";
            }
            else
            {
                btnRecordPayment.Enabled = true;
                btnRecordPayment.Text = "Record Payment";
            }
        }

        private void UpdateStatusBadge(string status, decimal remaining)
        {
            lblStatusBadge.Text = status.ToUpper();

            if (status.Equals("Paid", StringComparison.OrdinalIgnoreCase) || remaining <= 0)
            {
                lblStatusBadge.Text = "PAID";
                lblStatusBadge.BackColor = Color.FromArgb(220, 252, 231);
                lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52);
            }
            else if (status.Equals("Partially Paid", StringComparison.OrdinalIgnoreCase))
            {
                lblStatusBadge.BackColor = Color.FromArgb(254, 243, 199);
                lblStatusBadge.ForeColor = Color.FromArgb(180, 83, 9);
            }
            else
            {
                lblStatusBadge.BackColor = Color.FromArgb(254, 226, 226);
                lblStatusBadge.ForeColor = Color.FromArgb(185, 28, 28);
            }
        }

        private void LoadPaymentsGrid()
        {
            DataTable dtPayments = clsPayment.GetPaymentsByInvoiceID(_invoiceID);
            dgvPayments.DataSource = dtPayments;

            if (dgvPayments.Columns.Contains("PaymentID"))
            {
                dgvPayments.Columns["PaymentID"].HeaderText = "ID";
                dgvPayments.Columns["PaymentID"].Width = 60;
            }
            if (dgvPayments.Columns.Contains("ReceiptNumber"))
            {
                dgvPayments.Columns["ReceiptNumber"].HeaderText = "Receipt #";
                dgvPayments.Columns["ReceiptNumber"].Width = 140;
            }
            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"].HeaderText = "Date";
                dgvPayments.Columns["PaymentDate"].Width = 110;
            }
            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"].HeaderText = "Amount Paid";
                dgvPayments.Columns["Amount"].Width = 120;
                dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "C2";
            }
            if (dgvPayments.Columns.Contains("PaymentTypeName"))
            {
                dgvPayments.Columns["PaymentTypeName"].HeaderText = "Type";
                dgvPayments.Columns["PaymentTypeName"].Width = 120;
            }
            if (dgvPayments.Columns.Contains("RecordedBy"))
            {
                dgvPayments.Columns["RecordedBy"].HeaderText = "Recorded By";
                dgvPayments.Columns["RecordedBy"].Width = 120;
            }
            if (dgvPayments.Columns.Contains("Notes"))
            {
                dgvPayments.Columns["Notes"].HeaderText = "Notes";
            }
        }

        private void BtnRecordPayment_Click(object sender, EventArgs e)
        {
            if (_remainingAmount <= 0)
            {
                MessageBox.Show("This invoice has already been fully paid.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmRecordPayment frm = new frmRecordPayment(_invoiceID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Refresh invoice details and recalculate balances
                LoadInvoiceData();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"[Invoice Print View]\n\nInvoice Number: {lblInvoiceNoVal.Text}\nStudent: {lblStudentNameVal.Text}\nTotal: {lblTotalVal.Text}\nPaid: {lblPaidVal.Text}\nRemaining: {lblRemainingVal.Text}\nStatus: {lblStatusBadge.Text}\n\nInvoice statement is ready for printing.", "Print Statement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
