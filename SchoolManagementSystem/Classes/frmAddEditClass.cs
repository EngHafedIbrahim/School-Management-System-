using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Classes
{
    public partial class frmAddEditClass : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _ClassID = -1;
        private clsClass _Class;

        public int ClassID => _ClassID;

        public frmAddEditClass(int classID = -1)
        {
            InitializeComponent();
            _ClassID = classID;
            _Mode = (_ClassID == -1) ? enMode.AddNew : enMode.Update;

            clsUITheme.ApplyRTL(this);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            this.Text = _Mode == enMode.AddNew ? "إضافة شعبة دراسية جديدة" : "تعديل بيانات الشعبة الدراسية";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "إضافة شعبة دراسية جديدة" : $"تعديل بيانات الشعبة [رقم: {_ClassID}]";
            btnSave.Text = _Mode == enMode.AddNew ? "حفظ البيانات" : "تحديث البيانات";
        }

        private void LoadData()
        {
            DataTable dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
            cbGradeLevels.DataSource = dtGradeLevels;
            cbGradeLevels.DisplayMember = "Name";
            cbGradeLevels.ValueMember = "GradeLevelID";

            if (_Mode == enMode.AddNew)
            {
                cbGradeLevels.SelectedIndex = -1;
                _Class = new clsClass();
                return;
            }

            _Class = clsClass.Find(_ClassID);
            if (_Class == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الشعبة المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = _Class.Name;
            cbGradeLevels.SelectedValue = _Class.GradeLevelID;
            txtDetails.Text = _Class.Details;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم الشعبة / الفصل مطلوب.");
                isValid = false;
            }

            if (cbGradeLevels.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevels, "يرجى تحديد المرحلة / الصف الدراسي.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _Class.Name = txtName.Text.Trim();
            _Class.GradeLevelID = (int)cbGradeLevels.SelectedValue;
            _Class.Details = txtDetails.Text.Trim();
            _Class.CreatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            _Class.UpdatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            _Class.IsDeleted = false;

            try
            {
                if (_Class.Save())
                {
                    _ClassID = _Class.ClassID;
                    _Mode = enMode.Update;
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات الشعبة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات الشعبة الدراسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق من البيانات:\n" + ex.Message, "مخالفة قواعد النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditClass_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
