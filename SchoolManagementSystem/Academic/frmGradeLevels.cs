using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmGradeLevels : Form
    {
        private DataTable _dtGradeLevels;
        private DataView _dvGradeLevels;
        private int _EditingGradeLevelID = -1;

        public frmGradeLevels()
        {
            InitializeComponent();

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);


        }

        private void LoadGradeLevels()
        {
            try
            {
                _dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
                _dvGradeLevels = _dtGradeLevels.DefaultView;
                _dvGradeLevels.Sort = "OrderNo ASC";
                dgvGradeLevels.DataSource = _dvGradeLevels;

                if (dgvGradeLevels.Rows.Count > 0)
                {
                    dgvGradeLevels.Columns["GradeLevelID"].HeaderText = "ID";
                    dgvGradeLevels.Columns["GradeLevelID"].Width = 80;
                
                
                    dgvGradeLevels.Columns["Name"].HeaderText = "Grade Level Name";
                    dgvGradeLevels.Columns["Name"].Width = 200;
                
                    dgvGradeLevels.Columns["OrderNo"].HeaderText = "Order No";
                    dgvGradeLevels.Columns["OrderNo"].Width = 100;
               
                    dgvGradeLevels.Columns["Description"].HeaderText = "Description";
                    dgvGradeLevels.Columns["Description"].Width = 200;
                }


            }
            catch (Exception ex)
            {

            }
            
            UpdateCount();
        
        
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Grade Levels: {_dvGradeLevels?.Count ?? 0}";
        }

        private void ApplyFilter()
        {
            if (_dvGradeLevels == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(search))
            {
                _dvGradeLevels.RowFilter = "";
            }
            else
            {
                _dvGradeLevels.RowFilter = $"Name LIKE '%{search}%' OR Description LIKE '%{search}%'";
            }
            UpdateCount();
        }

        private void ResetEditor()
        {
            _EditingGradeLevelID = -1;
            lblFormTitle.Text = "Add New Grade Level";
            txtName.Text = "";
            numOrderNo.Value = (_dtGradeLevels != null && _dtGradeLevels.Rows.Count > 0) ? _dtGradeLevels.Rows.Count + 1 : 1;
            txtDescription.Text = "";
            btnCancelEdit.Visible = false;
            btnSave.Text = "Save Level";
            errorProvider1.Clear();
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Grade level name is required.");
                isValid = false;
            }

            if (numOrderNo.Value <= 0)
            {
                errorProvider1.SetError(numOrderNo, "Order number must be greater than zero.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            clsGradeLevel gradeLevel;
            
            if (_EditingGradeLevelID == -1)
            {
                gradeLevel = new clsGradeLevel();
            }
            else
            {
                gradeLevel = clsGradeLevel.Find(_EditingGradeLevelID);
                if (gradeLevel == null)
                {
                    MessageBox.Show("Grade level not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            gradeLevel.Name = txtName.Text.Trim();
            gradeLevel.OrderNo = (int)numOrderNo.Value;
            gradeLevel.Description = txtDescription.Text.Trim();

            try
            {
                if (gradeLevel.Save())
                {
                    MessageBox.Show("Grade level saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadGradeLevels();
                }
                else
                {
                    MessageBox.Show("Failed to save grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Error:\n" + ex.Message, "Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetEditor();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGradeLevels.CurrentRow == null)
            {
                MessageBox.Show("Please select a grade level to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingGradeLevelID = GetCurrentGradeLevelID();
            
            clsGradeLevel gradeLevel = clsGradeLevel.Find(_EditingGradeLevelID);
            if (gradeLevel != null)
            {
                lblFormTitle.Text = $"Edit Grade Level [ID: {_EditingGradeLevelID}]";
                txtName.Text = gradeLevel.Name;
                numOrderNo.Value = gradeLevel.OrderNo > 0 ? gradeLevel.OrderNo : 1;
                txtDescription.Text = gradeLevel.Description;
                btnCancelEdit.Visible = true;
                btnSave.Text = "Update Level";
            }
        }

        private int GetCurrentGradeLevelID()
        {
            return Convert.ToInt32(dgvGradeLevels.CurrentRow.Cells["GradeLevelID"].Value);
        }
        private void DgvGradeLevels_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGradeLevels.CurrentRow == null)
            {
                MessageBox.Show("Please select a grade level to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int gradeLevelID = GetCurrentGradeLevelID();
            string name = dgvGradeLevels.CurrentRow.Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete Grade Level '{name}' (ID: {gradeLevelID})?\nThis action will verify that no classes or fee structures depend on it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsGradeLevel.DeleteGradeLevel(gradeLevelID))
                    {
                        MessageBox.Show("Grade level deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_EditingGradeLevelID == gradeLevelID)
                        ResetEditor();
                        LoadGradeLevels();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete grade level. Classes or Fee Structures are linked to this grade level.", "Referential Integrity Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting grade level: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGradeLevels();
        }

        private void FrmGradeLevels_Load(object sender, EventArgs e)
        {
            LoadGradeLevels();
            ResetEditor();
        }




    }
}
