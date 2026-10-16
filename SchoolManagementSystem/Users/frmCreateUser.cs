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
                lblTitle.Text = $"Edit User Account [ID: {_userID}]";
                btnSave.Text = "Update User";
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
                MessageBox.Show("User account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtUsername.Text = _user.Username;
            txtEmail.Text = _user.Email;
            cbUserType.SelectedItem = _user.UserType;
            cbStatus.SelectedItem = _user.Status;

            // Trigger dynamic dropdown loading
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
                    lblLinkedEntity.Text = "Select Teacher: *";
                    LoadTeachers();
                    break;

                case "Parent":
                    gbLinkedEntity.Visible = true;
                    lblLinkedEntity.Text = "Select Parent: *";
                    LoadParents();
                    break;

                case "Student":
                    gbLinkedEntity.Visible = true;
                    lblLinkedEntity.Text = "Select Student: *";
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
                dt.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (Adm: ' + AdmissionNumber + ')'");

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
                errorProvider1.SetError(txtUsername, "Username is required.");
                isValid = false;
            }
            else if (clsUser.IsUsernameExist(txtUsername.Text.Trim(), _userID))
            {
                errorProvider1.SetError(txtUsername, "Username is already taken by another user.");
                isValid = false;
            }

            // Password validation (Only for New Users)
            if (_userID == -1)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password is required.");
                    isValid = false;
                }
                else if (txtPassword.Text.Length < 6)
                {
                    errorProvider1.SetError(txtPassword, "Password must be at least 6 characters long.");
                    isValid = false;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    errorProvider1.SetError(txtConfirmPassword, "Password confirmation does not match.");
                    isValid = false;
                }
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email address is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "Please enter a valid email address format.");
                isValid = false;
            }
            else if (clsUser.IsEmailExist(txtEmail.Text.Trim(), _userID))
            {
                errorProvider1.SetError(txtEmail, "Email address is already in use by another user.");
                isValid = false;
            }

            // Linked Entity check
            string userType = cbUserType.SelectedItem.ToString();
            if (userType != "Admin")
            {
                if (cbLinkedEntity.SelectedValue == null)
                {
                    errorProvider1.SetError(cbLinkedEntity, $"Please select a linked {userType}.");
                    isValid = false;
                }
                else
                {
                    int refID = Convert.ToInt32(cbLinkedEntity.SelectedValue);
                    // Business rule: Each Teacher/Parent/Student can only have ONE user account
                    if (clsUser.IsReferenceAlreadyLinked(userType, refID, _userID))
                    {
                        errorProvider1.SetError(cbLinkedEntity, $"A user account already exists for this {userType}.");
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
            _user.Status = cbStatus.SelectedItem.ToString();
            _user.ReferenceID = referenceID;

            try
            {
                if (_user.Save())
                {
                    MessageBox.Show("User account saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
