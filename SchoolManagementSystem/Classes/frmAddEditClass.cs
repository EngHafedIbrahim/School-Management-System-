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

            this.Text = _Mode == enMode.AddNew ? "Create New Class" : "Edit Class Information";
            lblHeaderTitle.Text = _Mode == enMode.AddNew ? "Create New Class" : "Edit Class Details";

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            LoadData();
        }

        private void LoadData()
        {
            DataTable dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
            cbGradeLevels.DataSource = dtGradeLevels;
            cbGradeLevels.DisplayMember = "Name";
            cbGradeLevels.ValueMember = "GradeLevelID";

            if (_Mode == enMode.AddNew)
            {
                _Class = new clsClass();
                return;
            }

            _Class = clsClass.Find(_ClassID);
            if (_Class == null)
            {
                MessageBox.Show("Class record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errorProvider1.SetError(txtName, "Class name is required.");
                isValid = false;
            }

            if (cbGradeLevels.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevels, "Please select a grade level.");
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
                    MessageBox.Show("Class saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
