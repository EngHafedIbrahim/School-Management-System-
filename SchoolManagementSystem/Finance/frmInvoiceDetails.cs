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
                clsUITheme.ShowArabicMessage("تم رفض الوصول: ليس لديك الصلاحية لعرض هذه الفاتورة.", "فشل في المصادقة", MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            LoadInvoiceData();
        }

        private bool CheckAuthorization()
        {
            clsInvoice invoice = clsInvoice.Find(_invoiceID);
            if (invoice == null)
                return false;

            _studentID = Convert.ToInt32(invoice.StudentID);

            // If current user is Parent, enforce StudentParent relationship check
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserType == "Parent")
            {
                int? parentID = clsGloble.CurrentUser.ReferenceID;
                if (!parentID.HasValue || !clsStudentParent.IsParentOfStudent(parentID.Value, _studentID))
                {
                    return false;
                }

                btnRecordPayment.Visible = false;
            }

            return true;
        }

        public void LoadInvoiceData()
        {
            DataTable dt = clsInvoice.GetInvoiceDetailed(_invoiceID);
            if (dt == null || dt.Rows.Count == 0)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الفاتورة المطلوب.", "خطأ", MessageBoxIcon.Error);
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

            // Disable Record Payment button if fully settled or cancelled
            if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                btnRecordPayment.Enabled = false;
                btnRecordPayment.Text = "الفاتورة ملغاة";
            }
            else if (_remainingAmount <= 0)
            {
                btnRecordPayment.Enabled = false;
                btnRecordPayment.Text = "تم السداد بالكامل";
            }
            else
            {
                btnRecordPayment.Enabled = true;
                btnRecordPayment.Text = "تسجيل دفعة";
            }
        }

        private void UpdateStatusBadge(string status, decimal remaining)
        {
            if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                lblStatusBadge.Text = "ملغاة";
                lblStatusBadge.BackColor = Color.FromArgb(241, 245, 249);
                lblStatusBadge.ForeColor = Color.FromArgb(100, 116, 139);
            }
            else if (status.Equals("Paid", StringComparison.OrdinalIgnoreCase) || remaining <= 0)
            {
                lblStatusBadge.Text = "مدفوعة";
                lblStatusBadge.BackColor = Color.FromArgb(220, 252, 231);
                lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52);
            }
            else if (status.Equals("Partially Paid", StringComparison.OrdinalIgnoreCase))
            {
                lblStatusBadge.Text = "مدفوعة جزئياً";
                lblStatusBadge.BackColor = Color.FromArgb(254, 243, 199);
                lblStatusBadge.ForeColor = Color.FromArgb(180, 83, 9);
            }
            else if (status.Equals("Overdue", StringComparison.OrdinalIgnoreCase))
            {
                lblStatusBadge.Text = "متأخرة";
                lblStatusBadge.BackColor = Color.FromArgb(254, 226, 226);
                lblStatusBadge.ForeColor = Color.FromArgb(190, 24, 93);
            }
            else
            {
                lblStatusBadge.Text = "غير مدفوعة";
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
                dgvPayments.Columns["PaymentID"].HeaderText = "المعرف";
                dgvPayments.Columns["PaymentID"].Width = 65;
            }
            if (dgvPayments.Columns.Contains("ReceiptNumber"))
            {
                dgvPayments.Columns["ReceiptNumber"].HeaderText = "رقم السند / الإيصال";
                dgvPayments.Columns["ReceiptNumber"].Width = 140;
            }
            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"].HeaderText = "تاريخ الدفع";
                dgvPayments.Columns["PaymentDate"].Width = 110;
                dgvPayments.Columns["PaymentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"].HeaderText = "المبلغ المدفوع";
                dgvPayments.Columns["Amount"].Width = 120;
                dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "C2";
            }
            if (dgvPayments.Columns.Contains("PaymentTypeName"))
            {
                dgvPayments.Columns["PaymentTypeName"].HeaderText = "طريقة الدفع";
                dgvPayments.Columns["PaymentTypeName"].Width = 130;
            }
            if (dgvPayments.Columns.Contains("RecordedBy"))
            {
                dgvPayments.Columns["RecordedBy"].HeaderText = "المسؤول عن التسجيل";
                dgvPayments.Columns["RecordedBy"].Width = 140;
            }
            if (dgvPayments.Columns.Contains("Notes"))
            {
                dgvPayments.Columns["Notes"].HeaderText = "ملاحظات / بيان";
            }
        }

        private void BtnRecordPayment_Click(object sender, EventArgs e)
        {
            if (_remainingAmount <= 0)
            {
                clsUITheme.ShowArabicMessage("تم سداد هذه الفاتورة بالكامل مسبقاً.", "تنبيه", MessageBoxIcon.Information);
                return;
            }

            frmRecordPayment frm = new frmRecordPayment(_invoiceID);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadInvoiceData();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            clsUITheme.ShowArabicMessage($"[بيانات الفاتورة للطباعة والتصدير]\n\nرقم الفاتورة: {lblInvoiceNoVal.Text}\nاسم الطالب: {lblStudentNameVal.Text}\nالإجمالي: {lblTotalVal.Text}\nالمدفوع: {lblPaidVal.Text}\nالمتبقي: {lblRemainingVal.Text}\nالحالة: {lblStatusBadge.Text}\n\nبيانات الفاتورة جاهزة للطباعة والتصدير.", "عرض الطباعة", MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
