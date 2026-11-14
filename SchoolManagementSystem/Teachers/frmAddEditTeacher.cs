using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Teachers
{
    public partial class frmAddEditTeacher : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _TeacherID = -1;
        private clsTeacher _Teacher;

        public int TeacherID => _TeacherID;

        public frmAddEditTeacher(int teacherID = -1)
        {
            InitializeComponent();
            _TeacherID = teacherID;
            _Mode = (_TeacherID == -1) ? enMode.AddNew : enMode.Update;

            clsUITheme.ApplyRTL(this);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            this.Text = _Mode == enMode.AddNew ? "تسجيل معلم جديد" : "تعديل بيانات المعلم";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "تسجيل معلم جديد" : $"تعديل بيانات المعلم [رقم: {_TeacherID}]";
            btnSave.Text = _Mode == enMode.AddNew ? "حفظ البيانات" : "تحديث البيانات";

            LoadData();
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Teacher = new clsTeacher();
                cbEmploymentStatus.SelectedIndex = 0;
                cbGender.SelectedIndex = 0;
                dtpHireDate.Value = DateTime.Now;
                return;
            }

            _Teacher = clsTeacher.Find(_TeacherID);
            if (_Teacher == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل المعلم المطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFirstName.Text = _Teacher.FirstName;
            txtLastName.Text = _Teacher.LastName;
            txtPhoneNumber.Text = _Teacher.PhoneNumber;
            txtEmail.Text = _Teacher.Email;
            txtAddress.Text = _Teacher.Address;

            cbGender.SelectedIndex = (_Teacher.GenderID == 1) ? 0 : 1;

            txtSpecialization.Text = _Teacher.Specialization;
            txtQualification.Text = _Teacher.Qualification;
            dtpHireDate.Value = _Teacher.HireDate;

            cbEmploymentStatus.SelectedIndex = _Teacher.EmploymentStatus switch
            {
                "Active" or "نشط" => 0,
                "On Leave" or "في إجازة" => 1,
                "Probation" or "تحت التجربة" => 2,
                "Suspended" or "موقوف" => 3,
                "Resigned" or "مستقيل" => 4,
                _ => 0
            };

            txtAbout.Text = _Teacher.About;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "الاسم الأول للمعلم مطلوب.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "اسم العائلة / اللقب مطلوب.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "يرجى إدخال بريد إلكتروني صحيح ومعتمد.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "رقم الهاتف مطلوب.");
                isValid = false;
            }

            if (cbGender.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbGender, "يرجى تحديد الجنس.");
                isValid = false;
            }

            if (dtpHireDate.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpHireDate, "تاريخ التعيين لا يمكن أن يكون تاريخاً مستقبلياً.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _Teacher.FirstName = txtFirstName.Text.Trim();
            _Teacher.LastName = txtLastName.Text.Trim();
            _Teacher.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Teacher.Email = txtEmail.Text.Trim();
            _Teacher.Address = txtAddress.Text.Trim();
            _Teacher.GenderID = (cbGender.SelectedIndex == 0) ? 1 : 2;
            _Teacher.Specialization = txtSpecialization.Text.Trim();
            _Teacher.Qualification = txtQualification.Text.Trim();
            _Teacher.HireDate = dtpHireDate.Value;

            string empStatus = cbEmploymentStatus.SelectedIndex switch
            {
                0 => "Active",
                1 => "On Leave",
                2 => "Probation",
                3 => "Suspended",
                4 => "Resigned",
                _ => "Active"
            };
            _Teacher.EmploymentStatus = empStatus;

            _Teacher.About = txtAbout.Text.Trim();
            _Teacher.CreatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            _Teacher.UpdatedBy = clsGloble.CurrentUser?.UserID ?? 1;

            try
            {
                if (_Teacher.Save())
                {
                    _TeacherID = _Teacher.TeacherID;
                    _Mode = enMode.Update;
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات المعلم بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات المعلم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
