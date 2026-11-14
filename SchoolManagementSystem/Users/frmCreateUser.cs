using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using UtilityLib;

namespace SchoolManagementSystem.Users
{
    public partial class frmCreateUser : Form
    {
        private readonly int _userID;
        private clsUser _user;

        public frmCreateUser(int userID = -1)
        {
            _userID = userID;
            InitializeComponent();

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);
        }

        private void FrmCreateUser_Load(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = 0; // Active
            cbUserType.SelectedIndex = 0; // Admin

            if (_userID != -1)
            {
                lblTitle.Text = $"تعديل حساب المستخدم [رقم: {_userID}]";
                btnSave.Text = "💾 تحديث البيانات";
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                txtPassword.Text = "********";
                txtConfirmPassword.Text = "********";
                LoadUserData();
            }
        }

        private void LoadUserData()
        {
            _user = clsUser.Find(_userID);
            if (_user == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على حساب المستخدم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtUsername.Text = _user.Username;
            txtEmail.Text = _user.Email;
            cbUserType.SelectedItem = _user.UserType;
            cbStatus.SelectedItem = _user.IsActive;

            CbUserType_SelectedIndexChanged(null, null);

            if (_user.ReferenceID.HasValue && cbLinkedEntity.Visible)
            {
                cbLinkedEntity.SelectedValue = _user.ReferenceID.Value;
            }
        }

        private void CbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbUserType.SelectedItem?.ToString() ?? "Admin";

            switch (selectedType)
            {
                case "Teacher":
                    gbLinkedEntity.Visible = true;
                    lblLinkedEntity.Text = "اختر المعلم المرتبط: *";
                    LoadTeachers();
                    break;

                case "Parent":
                    gbLinkedEntity.Visible = true;
                    lblLinkedEntity.Text = "اختر ولي الأمر المرتبط: *";
                    LoadParents();
                    break;

                case "Student":
                    gbLinkedEntity.Visible = true;
                    lblLinkedEntity.Text = "اختر الطالب المرتبط: *";
                    LoadStudents();
                    break;

                case "Admin":
                default:
                    gbLinkedEntity.Visible = false;
                    cbLinkedEntity.DataSource = null;
                    break;
            }
        }

        private void LoadTeachers()
        {
            DataTable dt = clsTeacher.GetAllTeachers();
            if (!dt.Columns.Contains("DisplayName"))
                dt.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + Specialization + ')'");

            cbLinkedEntity.DataSource = dt;
            cbLinkedEntity.DisplayMember = "DisplayName";
            cbLinkedEntity.ValueMember = "TeacherID";
        }

        private void LoadParents()
        {
            DataTable dt = clsParent.GetAllParents();
            if (!dt.Columns.Contains("DisplayName"))
                dt.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + Phone + ')'");

            cbLinkedEntity.DataSource = dt;
            cbLinkedEntity.DisplayMember = "DisplayName";
            cbLinkedEntity.ValueMember = "ParentID";
        }

        private void LoadStudents()
        {
            DataTable dt = clsStudent.GetAllStudents();
            if (!dt.Columns.Contains("DisplayName"))
                dt.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (رقم القبول: ' + AdmissionNumber + ')'");

            cbLinkedEntity.DataSource = dt;
            cbLinkedEntity.DisplayMember = "DisplayName";
            cbLinkedEntity.ValueMember = "StudentID";
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Username validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "اسم المستخدم مطلوب.");
                isValid = false;
            }
            else if (clsUser.IsUsernameExist(txtUsername.Text.Trim(), _userID))
            {
                errorProvider1.SetError(txtUsername, "اسم المستخدم مسجل مسبقاً لمستخدم آخر.");
                isValid = false;
            }

            // Password validation (Only for New Users)
            if (_userID == -1)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "كلمة المرور مطلوبة.");
                    isValid = false;
                }
                else if (txtPassword.Text.Length < 6)
                {
                    errorProvider1.SetError(txtPassword, "يجب أن تكون كلمة المرور 6 أحرف/أرقام على الأقل.");
                    isValid = false;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة المرور غير متطابق.");
                    isValid = false;
                }
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "البريد الإلكتروني مطلوب.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "صيغة البريد الإلكتروني غير صحيحة.");
                isValid = false;
            }
            else if (clsUser.IsEmailExist(txtEmail.Text.Trim(), _userID))
            {
                errorProvider1.SetError(txtEmail, "البريد الإلكتروني مسجل مسبقاً لمستخدم آخر.");
                isValid = false;
            }

            // Linked Entity check
            string userType = cbUserType.SelectedItem.ToString();
            if (userType != "Admin")
            {
                if (cbLinkedEntity.SelectedValue == null)
                {
                    errorProvider1.SetError(cbLinkedEntity, $"يرجى اختيار {userType} المرتبط بالحساب.");
                    isValid = false;
                }
                else
                {
                    int refID = Convert.ToInt32(cbLinkedEntity.SelectedValue);
                    if (clsUser.IsReferenceAlreadyLinked(userType, refID, _userID))
                    {
                        errorProvider1.SetError(cbLinkedEntity, $"يوجد بالفعل حساب مستخدم مرتبط بهذا الـ {userType}.");
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string userType = cbUserType.SelectedItem.ToString();
            int? referenceID = null;
            if (userType != "Admin" && cbLinkedEntity.SelectedValue != null)
            {
                referenceID = Convert.ToInt32(cbLinkedEntity.SelectedValue);
            }

            if (_userID == -1)
            {
                _user = new clsUser();
                _user.PasswordHash = clsSecurity.ComputeHash(txtPassword.Text);
            }

            _user.Username = txtUsername.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.UserType = userType;
            _user.IsActive = true;//cbStatus.SelectedItem.ToString();
            _user.ReferenceID = referenceID;

            try
            {
                if (_user.Save())
                {
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات المستخدم بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات المستخدم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("حدث خطأ أثناء حفظ المستخدم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
