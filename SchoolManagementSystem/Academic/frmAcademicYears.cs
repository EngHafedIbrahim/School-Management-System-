using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmAcademicYears : Form
    {
        private int _EditingYearID = -1;

        public frmAcademicYears()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvYears);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSuccessButton(btnSetCurrent);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            LoadYears();
        }

        private void LoadYears()
        {
            DataTable dt = clsAcademicYear.GetAllAcademicYears();
            dgvYears.DataSource = dt;

            if (dgvYears.Columns.Contains("AcademicYearID"))
                dgvYears.Columns["AcademicYearID"].Width = 90;
            if (dgvYears.Columns.Contains("StartDate"))
                dgvYears.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            if (dgvYears.Columns.Contains("EndDate"))
                dgvYears.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            if (dgvYears.Columns.Contains("CreatedAt"))
                dgvYears.Columns["CreatedAt"].Visible = false;
            if (dgvYears.Columns.Contains("UpdatedAt"))
                dgvYears.Columns["UpdatedAt"].Visible = false;
        }

        private void ResetEditor()
        {
            _EditingYearID = -1;
            lblFormTitle.Text = "Add New Academic Year";
            txtYearName.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(9);
            chkIsCurrent.Checked = false;
            btnCancelEdit.Visible = false;
            btnSave.Text = "Save Year";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYearName.Text))
            {
                MessageBox.Show("Year Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Start date must be before end date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsAcademicYear year;
            if (_EditingYearID == -1)
            {
                year = new clsAcademicYear();
            }
            else
            {
                year = clsAcademicYear.Find(_EditingYearID);
                if (year == null)
                {
                    MessageBox.Show("Academic year not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            year.YearName = txtYearName.Text.Trim();
            year.StartDate = dtpStartDate.Value;
            year.EndDate = dtpEndDate.Value;
            year.IsCurrent = chkIsCurrent.Checked;

            try
            {
                if (year.Save())
                {
                    if (chkIsCurrent.Checked)
                    {
                        clsAcademicYear.SetCurrentAcademicYear(year.AcademicYearID);
                    }

                    MessageBox.Show("Academic Year saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadYears();
                }
                else
                {
                    MessageBox.Show("Failed to save Academic Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvYears.CurrentRow == null)
            {
                MessageBox.Show("Please select an academic year to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingYearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            clsAcademicYear year = clsAcademicYear.Find(_EditingYearID);
            if (year != null)
            {
                lblFormTitle.Text = $"Edit Academic Year [ID: {_EditingYearID}]";
                txtYearName.Text = year.YearName;
                dtpStartDate.Value = year.StartDate;
                dtpEndDate.Value = year.EndDate;
                chkIsCurrent.Checked = year.IsCurrent;
                btnCancelEdit.Visible = true;
                btnSave.Text = "Update Year";
            }
        }

        private void BtnSetCurrent_Click(object sender, EventArgs e)
        {
            if (dgvYears.CurrentRow == null)
            {
                MessageBox.Show("Please select an academic year.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int yearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            string yearName = dgvYears.CurrentRow.Cells["YearName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to designate '{yearName}' as the Current Academic Year?\nAll other years will be set to inactive.", "Atomic Transaction Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (clsAcademicYear.SetCurrentAcademicYear(yearID))
                    {
                        MessageBox.Show($"Academic Year '{yearName}' is now set as the Current active session.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadYears();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Transaction failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvYears.CurrentRow == null)
            {
                MessageBox.Show("Please select an academic year to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int yearID = Convert.ToInt32(dgvYears.CurrentRow.Cells["AcademicYearID"].Value);
            string yearName = dgvYears.CurrentRow.Cells["YearName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete academic year '{yearName}' (ID: {yearID})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsAcademicYear.DeleteAcademicYear(yearID))
                    {
                        MessageBox.Show("Academic year deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadYears();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete this academic year because it is linked to enrollments, schedules, grades, or fee structures.", "Referential Integrity Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting academic year: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadYears();
        }
    }
}
