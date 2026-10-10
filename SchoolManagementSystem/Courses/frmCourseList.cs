using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Courses
{
    public partial class frmCourseList : Form
    {
        private DataTable _dtCourses;
        private DataView _dvCourses;

        public frmCourseList()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvCourses);
            clsUITheme.StyleSuccessButton(btnAddCourse);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            // LoadCourses();
        }

        private void LoadCourses()
        {
            _dtCourses = clsCourse.GetAllCourses();
            _dvCourses = _dtCourses.DefaultView;
            dgvCourses.DataSource = _dvCourses;

            if (dgvCourses.Rows.Count > 0)
            {
                dgvCourses.Columns["CourseID"].HeaderText = "ID";
                dgvCourses.Columns["CourseID"].Width = 100;

                dgvCourses.Columns["Name"].HeaderText = "Subject Name";
                dgvCourses.Columns["Name"].Width = 240;

                dgvCourses.Columns["CreditHours"].HeaderText = "Credit Hours";
                dgvCourses.Columns["CreditHours"].Width = 160;

                dgvCourses.Columns["Description"].HeaderText = "Description";
                dgvCourses.Columns["Description"].Width = 300;
            }
            if (dgvCourses.Columns.Contains("CreatedBy")) dgvCourses.Columns["CreatedBy"].Visible = false;
            if (dgvCourses.Columns.Contains("UpdatedBy")) dgvCourses.Columns["UpdatedBy"].Visible = false;
            if (dgvCourses.Columns.Contains("CreatedAt")) dgvCourses.Columns["CreatedAt"].Visible = false;
            if (dgvCourses.Columns.Contains("UpdatedAt")) dgvCourses.Columns["UpdatedAt"].Visible = false;
            if (dgvCourses.Columns.Contains("IsDeleted")) dgvCourses.Columns["IsDeleted"].Visible = false;

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (dgvCourses.DataSource == null) return;

            try
            {
                string search = txtSearch.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(search))
                {
                    _dvCourses.RowFilter = "";
                }
                else
                {
                    _dvCourses.RowFilter = $"Name LIKE '%{search}%' OR Description LIKE '%{search}%'";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Courses: {_dvCourses?.Count ?? 0}";
        }

        private int GetSelectedCourseID()
        {
            if (dgvCourses.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvCourses.CurrentRow.Cells["CourseID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddEditCourse frm = new frmAddEditCourse();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int courseID = GetSelectedCourseID();
            if (courseID == -1)
            {
                MessageBox.Show("Please select a course to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditCourse frm = new frmAddEditCourse(courseID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void DgvCourses_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int courseID = GetSelectedCourseID();
            if (courseID == -1)
            {
                MessageBox.Show("Please select a course to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string courseName = dgvCourses.CurrentRow.Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete course '{courseName}' (ID: {courseID})?\nThis action verifies that no assigned classes or grades depend on it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsCourse.DeleteCourse(courseID))
                    {
                        MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete course. Active class-course assignments or grade records are attached to this course.", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
    }
}
