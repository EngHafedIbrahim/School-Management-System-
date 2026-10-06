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

            this.Text = _Mode == enMode.AddNew ? "Register New Parent" : "Edit Parent Details";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "Register Parent / Guardian" : "Edit Parent Information";

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            LoadData();
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Parent = new clsParent();
                return;
            }

            _Parent = clsParent.Find(_ParentID);
            if (_Parent == null)
            {
                MessageBox.Show("Parent record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

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
                errorProvider1.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone number is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Valid email address is required.");
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
                    MessageBox.Show("Parent saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save parent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation error:\n" + ex.Message, "Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
