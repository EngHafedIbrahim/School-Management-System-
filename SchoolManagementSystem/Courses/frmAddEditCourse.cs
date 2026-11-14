using System;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Courses
{
    public partial class frmAddEditCourse : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _CourseID = -1;
        private clsCourse _Course;

        public int CourseID => _CourseID;

        public frmAddEditCourse(int courseID = -1)
        {
            InitializeComponent();
            _CourseID = courseID;
            _Mode = (_CourseID == -1) ? enMode.AddNew : enMode.Update;

            clsUITheme.ApplyRTL(this);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            this.Text = _Mode == enMode.AddNew ? "إضافة مادة دراسية جديدة" : "تعديل بيانات المادة الدراسية";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "إضافة مادة دراسية جديدة" : $"تعديل بيانات المادة [رقم: {_CourseID}]";
            btnSave.Text = _Mode == enMode.AddNew ? "حفظ المادة" : "تحديث البيانات";

            LoadData();
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Course = new clsCourse();
                numCreditHours.Value = 3;
                return;
            }

            _Course = clsCourse.Find(_CourseID);
            if (_Course == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل المادة الدراسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = _Course.Name;
            numCreditHours.Value = _Course.CreditHours > 0 ? _Course.CreditHours : 1;
            txtDescription.Text = _Course.Description;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم المادة الدراسية مطلوب.");
                isValid = false;
            }

            if (numCreditHours.Value <= 0)
            {
                errorProvider1.SetError(numCreditHours, "عدد الساعات المعتمدة يجب أن يكون أكبر من الصفر.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _Course.Name = txtName.Text.Trim();
            _Course.CreditHours = (int)numCreditHours.Value;
            _Course.Description = txtDescription.Text.Trim();
            _Course.CreatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            _Course.UpdatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            _Course.IsDeleted = false;

            try
            {
                if (_Course.Save())
                {
                    _CourseID = _Course.CourseID;
                    _Mode = enMode.Update;
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات المادة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات المادة الدراسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
