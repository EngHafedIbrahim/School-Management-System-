using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Students
{
    public partial class frmRegisterStudent : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _StudentID = -1;
        private clsStudent _Student;

        public int StudentID => _StudentID;

        public frmRegisterStudent(int studentID = -1)
        {
            InitializeComponent();

            _StudentID = studentID;
            _Mode = (_StudentID == -1) ? enMode.AddNew : enMode.Update;

            this.Text = _Mode == enMode.AddNew ? "Register New Student" : "Update Student Info";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "Student Registration" : "Edit Student Information";

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);
            cbGender.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            //DataTable dtGenders = clsGender.GetAllGenders();
            //cbGender.DataSource = dtGenders;
            //cbGender.DisplayMember = "Name";
            //cbGender.ValueMember = "GenderID";

            if (_Mode == enMode.AddNew)
            {
                _Student = new clsStudent();
                dtpDOB.Value = DateTime.Now.AddYears(-6);

                txtAdmissionNo.Text = "STU-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                cbBloodType.SelectedIndex = 0;
                cbHealthStatus.SelectedIndex = 0;
                return;
            }

            _Student = clsStudent.Find(_StudentID);
            if (_Student == null)
            {
                MessageBox.Show($"Student with ID {_StudentID} was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFirstName.Text = _Student.FirstName;
            txtLastName.Text = _Student.LastName;
            txtNationalID.Text = _Student.NationalID;
            txtAdmissionNo.Text = _Student.AdmissionNo;
            dtpDOB.Value = _Student.DateOfBirth;
            cbGender.SelectedValue = _Student.GenderID;
            txtNationality.Text = _Student.Nationality;
            cbBloodType.Text = _Student.BloodType;
            txtAddress.Text = _Student.Address;
            txtPhoneNumber.Text = _Student.PhoneNumber;
            txtEmail.Text = _Student.Email;
            dtpAdmissionDate.Value = _Student.AdmissionDate;
            txtPreviousSchool.Text = _Student.PreviousSchool;
            cbHealthStatus.Text = string.IsNullOrEmpty(_Student.HealthStatus) ? "Healthy" : _Student.HealthStatus;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtAdmissionNo.Text))
            {
                errorProvider1.SetError(txtAdmissionNo, "Admission number is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                errorProvider1.SetError(txtNationalID, "National ID is required.");
                isValid = false;
            }
            if (cbGender.Text == null)
            {
                errorProvider1.SetError(cbGender, "Please select a gender.");
                isValid = false;
            }
            if (dtpDOB.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpDOB, "Date of birth cannot be in the future.");
                isValid = false;
            }

            return isValid;
        }

        async private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateForm())
                return;

            _Student.FirstName = txtFirstName.Text.Trim();
            _Student.LastName = txtLastName.Text.Trim();
            _Student.NationalID = txtNationalID.Text.Trim();
            _Student.AdmissionNo = txtAdmissionNo.Text.Trim();
            _Student.DateOfBirth = dtpDOB.Value;
            _Student.GenderID = (cbGender.Text == "Male")? 1 : 2 ;
            _Student.Nationality = txtNationality.Text.Trim();
            _Student.BloodType = cbBloodType.Text;
            _Student.Address = txtAddress.Text.Trim();
            _Student.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Student.Email = txtEmail.Text.Trim();
            _Student.AdmissionDate = dtpAdmissionDate.Value;
            _Student.PreviousSchool = txtPreviousSchool.Text.Trim();
            _Student.HealthStatus = cbHealthStatus.Text;
            _Student.ProfileImageURL = "";
            
            _Student.CreatedBy = clsGloble.UserID ;
            _Student.UpdatedBy = clsGloble.UserID ;

            try
            {
                bool IsSaved = await _Student.Save();
                if (IsSaved)
                {
                    _StudentID = _Student.StudentID;
                    _Mode = enMode.Update;
                    MessageBox.Show("Student information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Business Validation Error:\n" + ex.Message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
