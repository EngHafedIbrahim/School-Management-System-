using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmPaymentTypes : Form
    {
        private DataTable _dtPaymentTypes;
        private int _editingPaymentTypeID = -1;

        public frmPaymentTypes()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvPaymentTypes);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmPaymentTypes_Load(object sender, EventArgs e)
        {
            LoadPaymentTypes();
            ResetForm();
        }

        private void LoadPaymentTypes()
        {
            _dtPaymentTypes = clsPaymentType.GetAllPaymentTypes();
            dgvPaymentTypes.DataSource = _dtPaymentTypes;

            if (dgvPaymentTypes.Columns.Contains("PaymentTypeID"))
            {
                dgvPaymentTypes.Columns["PaymentTypeID"].HeaderText = "المعرف";
                dgvPaymentTypes.Columns["PaymentTypeID"].Width = 70;
            }
            if (dgvPaymentTypes.Columns.Contains("Name"))
            {
                dgvPaymentTypes.Columns["Name"].HeaderText = "طريقة / نوع الدفع";
                dgvPaymentTypes.Columns["Name"].Width = 160;
            }
            if (dgvPaymentTypes.Columns.Contains("Description"))
            {
                dgvPaymentTypes.Columns["Description"].HeaderText = "الوصف / البيان";
            }

            lblTotalCount.Text = $"إجمالي الأنواع: {dgvPaymentTypes.Rows.Count}";
        }

        private void ResetForm()
        {
            _editingPaymentTypeID = -1;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            gbPaymentType.Text = "إضافة طريقة دفع جديدة";
            btnSave.Text = "حفظ نوع الدفع";
            btnCancelEdit.Visible = false;
            errorProvider1.Clear();
            txtName.Focus();
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم نوع الدفع مطلوب.");
                isValid = false;
            }
            else
            {
                // Uniqueness check
                string name = txtName.Text.Trim();
                if (_dtPaymentTypes != null)
                {
                    foreach (DataRow row in _dtPaymentTypes.Rows)
                    {
                        int id = Convert.ToInt32(row["PaymentTypeID"]);
                        if (id != _editingPaymentTypeID && row["Name"].ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            errorProvider1.SetError(txtName, "يوجد نوع دفع آخر مسجل بهذا الاسم مسبقاً.");
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            clsPaymentType paymentType;
            if (_editingPaymentTypeID == -1)
            {
                paymentType = new clsPaymentType();
            }
            else
            {
                paymentType = clsPaymentType.Find(_editingPaymentTypeID);
                if (paymentType == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على سجل نوع الدفع المطلوب.", "خطأ", MessageBoxIcon.Error);
                    ResetForm();
                    return;
                }
            }

            paymentType.Name = txtName.Text.Trim();
            paymentType.Description = txtDescription.Text.Trim();

            try
            {
                if (paymentType.Save())
                {
                    clsUITheme.ShowArabicMessage("تم حفظ نوع الدفع بنجاح.", "تم الحفظ", MessageBoxIcon.Information);
                    ResetForm();
                    LoadPaymentTypes();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ نوع الدفع.", "خطأ", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("حدث خطأ أثناء حفظ نوع الدفع: " + ex.Message, "خطأ", MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTypes.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد نوع دفع من القائمة أولاً.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvPaymentTypes.CurrentRow.Cells["PaymentTypeID"].Value);
            clsPaymentType pt = clsPaymentType.Find(id);
            if (pt != null)
            {
                _editingPaymentTypeID = pt.PaymentTypeID;
                txtName.Text = pt.Name;
                txtDescription.Text = pt.Description;
                gbPaymentType.Text = $"تعديل نوع الدفع [رقم: {pt.PaymentTypeID}]";
                btnSave.Text = "تحديث نوع الدفع";
                btnCancelEdit.Visible = true;
                errorProvider1.Clear();
                txtName.Focus();
            }
        }

        private void DgvPaymentTypes_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTypes.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد نوع دفع من القائمة أولاً.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvPaymentTypes.CurrentRow.Cells["PaymentTypeID"].Value);
            string name = dgvPaymentTypes.CurrentRow.Cells["Name"].Value.ToString();

            // Business Rule: Check if PaymentType is used in Payments
            if (clsPaymentType.IsPaymentTypeUsed(id))
            {
                clsUITheme.ShowArabicMessage($"لا يمكن حذف نوع الدفع '{name}' لأنه مرتبط بسجلات مدفوعات وسندات مالية موجودة للطلاب.\nللحفاظ على سلامة التدقيق المالي، تم منع الحذف.",
                    "قيد التكامل المرجعي", MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show($"هل أنت متأكد من رغبتك في حذف نوع الدفع '{name}' (رقم: {id})؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                if (clsPaymentType.DeletePaymentType(id))
                {
                    clsUITheme.ShowArabicMessage("تم حذف نوع الدفع بنجاح.", "تم الحذف", MessageBoxIcon.Information);
                    if (_editingPaymentTypeID == id)
                        ResetForm();
                    LoadPaymentTypes();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حذف نوع الدفع.", "خطأ", MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadPaymentTypes();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
