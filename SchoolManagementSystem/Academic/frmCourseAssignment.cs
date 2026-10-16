using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmCourseAssignment : Form
    {
        private DataTable _dtAssignments;
        private DataView _dvAssignments;
        private int _EditingClassCourseID = -1;

        public frmCourseAssignment()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvAssignments);
            clsUITheme.StylePrimaryButton(btnAssign);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnRemove);
            clsUITheme.StyleSecondaryButton(btnRefresh);


        }

        private void LoadDropdowns()
        {
            DataTable dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
            cbGradeLevels.DataSource = dtGradeLevels;
            cbGradeLevels.DisplayMember = "Name";
            cbGradeLevels.ValueMember = "GradeLevelID";


            // Courses
            DataTable dtCourses = clsCourse.GetAllCourses();
            cbCourse.DataSource = dtCourses;
            cbCourse.DisplayMember = "Name";
            cbCourse.ValueMember = "CourseID";


            // Teachers
            DataTable dtTeachers = clsTeacher.GetAllTeachers();
            if (!dtTeachers.Columns.Contains("DisplayName"))
            {
                dtTeachers.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + Specialization + ')'");
            }
            cbTeacher.DataSource = dtTeachers;
            cbTeacher.DisplayMember = "DisplayName";
            cbTeacher.ValueMember = "TeacherID";

            // Academic Years
            DataTable dtYears = clsAcademicYear.GetAllAcademicYears();
            cbYear.DataSource = dtYears;
            cbYear.DisplayMember = "YearName";
            cbYear.ValueMember = "AcademicYearID";

            // Filter Dropdowns
            cbFilterYear.Items.Clear();
            cbFilterYear.Items.Add("All Years");
            foreach (DataRow r in dtYears.Rows)
            {
                cbFilterYear.Items.Add(r["YearName"].ToString());
            }
            cbFilterYear.SelectedIndex = 0;

            cbFilterClass.Items.Clear();
            cbFilterClass.Items.Add("All Classes");
            foreach (DataRow r in dtGradeLevels.Rows)
            {
                cbFilterClass.Items.Add(r["Name"].ToString());
            }
            cbFilterClass.SelectedIndex = 0;
            cbGradeLevels.SelectedIndex = -1;


        }

        private void LoadAssignments()
        {
            _dtAssignments = clsClassCourse.GetAllClassCoursesDetailed();
            _dvAssignments = _dtAssignments.DefaultView;
            dgvAssignments.DataSource = _dvAssignments;

            if (dgvAssignments.Columns.Contains("ClassCourseID"))
            {
                dgvAssignments.Columns["ClassCourseID"].HeaderText = "ID";
                dgvAssignments.Columns["ClassCourseID"].Width = 70;
            }
            if (dgvAssignments.Columns.Contains("ClassName"))
            {
                dgvAssignments.Columns["ClassName"].HeaderText = "Class";
                dgvAssignments.Columns["ClassName"].Width = 160;
            }
            if (dgvAssignments.Columns.Contains("CourseName"))
            {
                dgvAssignments.Columns["CourseName"].HeaderText = "Subject / Course";
                dgvAssignments.Columns["CourseName"].Width = 200;
            }
            if (dgvAssignments.Columns.Contains("TeacherName"))
            {
                dgvAssignments.Columns["TeacherName"].HeaderText = "Assigned Instructor";
                dgvAssignments.Columns["TeacherName"].Width = 220;
            }
            if (dgvAssignments.Columns.Contains("GradeLevel"))
            {
                dgvAssignments.Columns["GradeLevel"].HeaderText = "Grade Level";
                dgvAssignments.Columns["GradeLevel"].Width = 260;
            }
            if (dgvAssignments.Columns.Contains("AcademicYear"))
            {
                dgvAssignments.Columns["AcademicYear"].HeaderText = "Academic Year";
                dgvAssignments.Columns["AcademicYear"].Width = 160;
            }
            if (dgvAssignments.Columns.Contains("ClassID")) dgvAssignments.Columns["ClassID"].Visible = false;
            if (dgvAssignments.Columns.Contains("CourseID")) dgvAssignments.Columns["CourseID"].Visible = false;
            if (dgvAssignments.Columns.Contains("TeacherID")) dgvAssignments.Columns["TeacherID"].Visible = false;
            if (dgvAssignments.Columns.Contains("AcademicYearID")) dgvAssignments.Columns["AcademicYearID"].Visible = false;

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvAssignments == null) return;

            string selectedYear = cbFilterYear.SelectedItem?.ToString();
            string selectedClass = cbFilterClass.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(selectedYear) && selectedYear != "All Years")
            {
                filter = $"AcademicYear = '{selectedYear.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedClass) && selectedClass != "All Classes")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"GradeLevel = '{selectedClass.Replace("'", "''")}'";
            }

            _dvAssignments.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Displayed Assignments: {_dvAssignments?.Count ?? 0}";
        }

        private void ResetEditor()
        {
            _EditingClassCourseID = -1;
            lblFormTitle.Text = "Assign Course to Class";
            btnCancelEdit.Visible = false;
            btnAssign.Text = "Assign Course";
            errorProvider1.Clear();
        }

        private bool ValidateAssignment()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (cbClass.SelectedValue == null)
            {
                errorProvider1.SetError(cbClass, "Target class is required.");
                isValid = false;
            }
            if (cbCourse.SelectedValue == null)
            {
                errorProvider1.SetError(cbCourse, "Course subject is required.");
                isValid = false;
            }
            if (cbTeacher.SelectedValue == null)
            {
                errorProvider1.SetError(cbTeacher, "Faculty instructor is required.");
                isValid = false;
            }
            if (cbYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbYear, "Academic year is required.");
                isValid = false;
            }
            if (cbGradeLevels.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevels, "Grade Levels year is required.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (!ValidateAssignment())
                return;

            clsClassCourse assignment;
            if (_EditingClassCourseID == -1)
            {
                assignment = new clsClassCourse();
            }
            else
            {
                assignment = clsClassCourse.Find(_EditingClassCourseID);
                if (assignment == null)
                {
                    MessageBox.Show("Assignment record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            assignment.ClassID = (int)cbClass.SelectedValue;
            assignment.CourseID = (int)cbCourse.SelectedValue;
            assignment.TeacherID = (int)cbTeacher.SelectedValue;
            assignment.AcademicYearID = (int)cbYear.SelectedValue;
            assignment.GradeLevelID = (int)cbGradeLevels.SelectedValue;
            assignment.IsDeleted = false;

            try
            {
                if (assignment.Save())
                {
                    MessageBox.Show("Course assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadAssignments();
                }
                else
                {
                    MessageBox.Show("Failed to save assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Error:\n" + ex.Message, "Conflict Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetEditor();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.CurrentRow == null)
            {
                MessageBox.Show("Please select an assignment to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingClassCourseID = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["ClassCourseID"].Value);
            clsClassCourse cc = clsClassCourse.Find(_EditingClassCourseID);
            if (cc != null)
            {
                lblFormTitle.Text = $"Edit Course Assignment [ID: {_EditingClassCourseID}]";
                cbClass.SelectedValue = cc.ClassID;
                cbCourse.SelectedValue = cc.CourseID;
                cbTeacher.SelectedValue = cc.TeacherID;
                cbYear.SelectedValue = cc.AcademicYearID;
                btnCancelEdit.Visible = true;
                btnAssign.Text = "Update Assignment";
            }
        }

        private void DgvAssignments_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.CurrentRow == null)
            {
                MessageBox.Show("Please select an assignment to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int classCourseID = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["ClassCourseID"].Value);
            string clsName = dgvAssignments.CurrentRow.Cells["ClassName"].Value.ToString();
            string crsName = dgvAssignments.CurrentRow.Cells["CourseName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to remove assignment for {clsName} - {crsName} (ID: {classCourseID})?\nThis action verifies that no schedules or student attendance records depend on it.", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsClassCourse.DeleteClassCourse(classCourseID))
                    {
                        MessageBox.Show("Assignment removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_EditingClassCourseID == classCourseID)
                            ResetEditor();
                        LoadAssignments();
                    }
                    else
                    {
                        MessageBox.Show("Cannot remove assignment. Active timetable schedules or attendance sessions are linked to this teaching relationship.", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CbFilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadAssignments();
        }

        private void FrmCourseAssignment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDropdowns();
                LoadAssignments();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
        }



        private void CbGradeLevels_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (cbGradeLevels.Items.Count <= 0)
            {
                return;
            }
            int i = (int)(cbGradeLevels.SelectedValue);
            // Classes
            DataTable dtClasses = clsClass.GetAllClasss(i);
            cbClass.DataSource = dtClasses;
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ClassID";
            
            //cbClass.Refresh();
        }
    }
}
