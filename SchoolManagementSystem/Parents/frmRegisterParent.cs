using System;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Parents
{
    public partial class frmRegisterParent : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _ParentID = -1;
        private clsParent _Parent;

        public int ParentID => _ParentID;

        public frmRegisterParent(int parentID = -1)
        {
            InitializeComponent();
            _ParentID = parentID;
            _Mode = (_ParentID == -1) ? enMode.AddNew : enMode.Update;

            this.Text = _Mode == enMode.AddNew ? "تسجيل ولي أمر جديد" : "تعديل بيانات ولي الأمر";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "تسجيل بيانات ولي أمر جديد" : "تعديل بيانات ولي الأمر";

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            LoadData();
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Parent = new clsParent();
                lblID.Text = "تلقائي";
                return;
            }

            _Parent = clsParent.Find(_ParentID);
            if (_Parent == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل ولي الأمر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _Parent.ParentID.ToString();
            txtFirstName.Text = _Parent.FirstName;
            txtLastName.Text = _Parent.LastName;
            txtPhoneNumber.Text = _Parent.PhoneNumber;
            txtEmail.Text = _Parent.Email;
            txtAddress.Text = _Parent.Address;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "الاسم الأول مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "اسم العائلة / اللقب مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "رقم الهاتف مطلوب.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "يرجى إدخال بريد إلكتروني صحيح.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _Parent.FirstName = txtFirstName.Text.Trim();
            _Parent.LastName = txtLastName.Text.Trim();
            _Parent.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Parent.Email = txtEmail.Text.Trim();
            _Parent.Address = txtAddress.Text.Trim();
            _Parent.RelationshipType = "Parent";

            try
            {
                if (_Parent.Save())
                {
                    _ParentID = _Parent.ParentID;
                    _Mode = enMode.Update;
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات ولي الأمر بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات ولي الأمر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق من البيانات:\n" + ex.Message, "قيد النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
