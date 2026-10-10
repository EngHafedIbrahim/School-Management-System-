using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Teachers
{
    public partial class frmTeacherList : Form
    {
        private DataTable _dtTeachers;
        private DataView _dvTeachers;

        public frmTeacherList()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvTeachers);
            clsUITheme.StyleSuccessButton(btnAddTeacher);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            cbFilterGender.SelectedIndex = 0;
            cbFilterStatus.SelectedIndex = 0;

            LoadTeachers();
        }

        private void LoadTeachers()
        {
            _dtTeachers = clsTeacher.GetTeachersDetailed();
            _dvTeachers = _dtTeachers.DefaultView;
            dgvTeachers.DataSource = _dvTeachers;

            if (dgvTeachers.Columns.Contains("TeacherID"))
            {
                dgvTeachers.Columns["TeacherID"].HeaderText = "ID";
                dgvTeachers.Columns["TeacherID"].Width = 70;
            }
            if (dgvTeachers.Columns.Contains("FullName"))
            {
                dgvTeachers.Columns["FullName"].HeaderText = "Teacher Name";
                dgvTeachers.Columns["FullName"].Width = 180;
            }
            if (dgvTeachers.Columns.Contains("PhoneNumber"))
            {
                dgvTeachers.Columns["PhoneNumber"].HeaderText = "Phone";
                dgvTeachers.Columns["PhoneNumber"].Width = 120;
            }
            if (dgvTeachers.Columns.Contains("Email"))
            {
                dgvTeachers.Columns["Email"].HeaderText = "Email Address";
                dgvTeachers.Columns["Email"].Width = 180;
            }
            if (dgvTeachers.Columns.Contains("Specialization"))
            {
                dgvTeachers.Columns["Specialization"].HeaderText = "Subject/Specialty";
                dgvTeachers.Columns["Specialization"].Width = 140;
            }
            if (dgvTeachers.Columns.Contains("Qualification"))
            {
                dgvTeachers.Columns["Qualification"].HeaderText = "Qualification";
                dgvTeachers.Columns["Qualification"].Width = 130;
            }
            if (dgvTeachers.Columns.Contains("HireDate"))
            {
                dgvTeachers.Columns["HireDate"].HeaderText = "Hire Date";
                dgvTeachers.Columns["HireDate"].Width = 100;
                dgvTeachers.Columns["HireDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            if (dgvTeachers.Columns.Contains("EmploymentStatus"))
            {
                dgvTeachers.Columns["EmploymentStatus"].HeaderText = "Status";
                dgvTeachers.Columns["EmploymentStatus"].Width = 90;
            }
            if (dgvTeachers.Columns.Contains("Gender"))
            {
                dgvTeachers.Columns["Gender"].HeaderText = "Gender";
                dgvTeachers.Columns["Gender"].Width = 80;
            }
            if (dgvTeachers.Columns.Contains("FirstName")) dgvTeachers.Columns["FirstName"].Visible = false;
            if (dgvTeachers.Columns.Contains("LastName")) dgvTeachers.Columns["LastName"].Visible = false;
            if (dgvTeachers.Columns.Contains("GenderID")) dgvTeachers.Columns["GenderID"].Visible = false;
            if (dgvTeachers.Columns.Contains("Address")) dgvTeachers.Columns["Address"].Visible = false;
            if (dgvTeachers.Columns.Contains("About")) dgvTeachers.Columns["About"].Visible = false;

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvTeachers == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string gender = cbFilterGender.SelectedItem?.ToString();
            string status = cbFilterStatus.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(FullName LIKE '%{search}%' OR Email LIKE '%{search}%' OR Specialization LIKE '%{search}%' OR PhoneNumber LIKE '%{search}%')";
            }

            if (!string.IsNullOrEmpty(gender) && gender != "All")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Gender = '{gender}'";
            }

            if (!string.IsNullOrEmpty(status) && status != "All")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"EmploymentStatus = '{status}'";
            }

            _dvTeachers.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Displayed Teachers: {_dvTeachers?.Count ?? 0}";
        }

        private int GetSelectedTeacherID()
        {
            if (dgvTeachers.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvTeachers.CurrentRow.Cells["TeacherID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frm = new frmAddEditTeacher();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeachers();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                MessageBox.Show("Please select a teacher to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditTeacher frm = new frmAddEditTeacher(teacherID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeachers();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                MessageBox.Show("Please select a teacher to view profile.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmTeacherProfile frm = new frmTeacherProfile(teacherID);
            frm.ShowDialog();
            LoadTeachers();
        }

        private void DgvTeachers_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                MessageBox.Show("Please select a teacher to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string teacherName = dgvTeachers.CurrentRow.Cells["FullName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete teacher '{teacherName}' (ID: {teacherID})?\nThis action verifies that no course assignments or schedules are assigned to this teacher.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsTeacher.DeleteTeacher(teacherID))
                    {
                        MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeachers();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete teacher. Active course assignments, schedules, or user accounts are linked to this teacher.", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
