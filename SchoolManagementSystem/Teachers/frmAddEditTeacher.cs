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

            this.Text = _Mode == enMode.AddNew ? "Register New Teacher" : "Edit Teacher Information";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "Register Teacher" : "Edit Teacher Details";

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

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
                _Teacher = new clsTeacher();
                cbEmploymentStatus.SelectedIndex = 0;
                cbGender.SelectedIndex = 0;
                dtpHireDate.Value = DateTime.Now;

                return;
            }

            _Teacher = clsTeacher.Find(_TeacherID);
            if (_Teacher == null)
            {
                MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtFirstName.Text = _Teacher.FirstName;
            txtLastName.Text = _Teacher.LastName;
            txtPhoneNumber.Text = _Teacher.PhoneNumber;
            txtEmail.Text = _Teacher.Email;
            txtAddress.Text = _Teacher.Address;
            
            //cbGender.SelectedValue = _Teacher.GenderID;
            cbGender.SelectedIndex = _Teacher.GenderID-1;
            
            txtSpecialization.Text = _Teacher.Specialization;
            txtQualification.Text = _Teacher.Qualification;
            dtpHireDate.Value = _Teacher.HireDate;
            cbEmploymentStatus.Text = string.IsNullOrEmpty(_Teacher.EmploymentStatus) ? "Active" : _Teacher.EmploymentStatus;
            txtAbout.Text = _Teacher.About;
            

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

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Valid unique email is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone number is required.");
                isValid = false;
            }

            if (cbGender.Text == null)
            {
                errorProvider1.SetError(cbGender, "Please select a gender.");
                isValid = false;
            }

            if (dtpHireDate.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpHireDate, "Hire date cannot be in the future.");
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
            _Teacher.GenderID = cbGender.Text == "Male"? 1: 2;
            _Teacher.Specialization = txtSpecialization.Text.Trim();
            _Teacher.Qualification = txtQualification.Text.Trim();
            _Teacher.HireDate = dtpHireDate.Value;
            _Teacher.EmploymentStatus = cbEmploymentStatus.Text;
            _Teacher.About = txtAbout.Text.Trim();
            _Teacher.CreatedBy = clsGloble.CurrentUser?.UserID ?? 1;
            
            _Teacher.UpdatedBy = clsGloble.CurrentUser?.UserID ?? 1;

            try
            {
                if (_Teacher.Save())
                {
                    _TeacherID = _Teacher.TeacherID;
                    _Mode = enMode.Update;
                    MessageBox.Show("Teacher saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Error:\n" + ex.Message, "Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
