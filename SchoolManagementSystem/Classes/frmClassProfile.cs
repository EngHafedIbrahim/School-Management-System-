using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Classes
{
    public partial class frmClassProfile : Form
    {
        private int _ClassID;
        private clsClass _Class;

        public frmClassProfile(int classID)
        {
            InitializeComponent();
            _ClassID = classID;

            clsUITheme.StyleDataGridView(dgvStudents);
            clsUITheme.StyleDataGridView(dgvCourses);
            clsUITheme.StyleDataGridView(dgvTimetable);
            clsUITheme.StyleDataGridView(dgvAttendance);
            clsUITheme.StyleDataGridView(dgvGrades);

            clsUITheme.StylePrimaryButton(btnEditClass);
            clsUITheme.StyleSecondaryButton(btnClose);

            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            LoadClassData();
        }

        private void LoadClassData()
        {
            _Class = clsClass.Find(_ClassID);
            if (_Class == null)
            {
                MessageBox.Show("Class record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValClassName.Text = _Class.Name;
            lblValGradeLevel.Text = _Class.GradeLevelInfo?.Name ?? "N/A";
            lblValDetails.Text = string.IsNullOrEmpty(_Class.Details) ? "None specified." : _Class.Details;

            DataTable dtStudents = clsStudentEnrollment.GetStudentsByClassID(_ClassID);
            lblValTotalStudents.Text = dtStudents.Rows.Count.ToString();
            dgvStudents.DataSource = dtStudents;

            DataTable dtCourses = clsClassCourse.GetCoursesByClassID(_ClassID);
            lblValTotalCourses.Text = dtCourses.Rows.Count.ToString();
            dgvCourses.DataSource = dtCourses;

            // Load currently active tab
            LoadTabContent(tabControl.SelectedIndex);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabContent(tabControl.SelectedIndex);
        }

        private void LoadTabContent(int tabIndex)
        {
            switch (tabIndex)
            {
                case 1: // Students
                    dgvStudents.DataSource = clsStudentEnrollment.GetStudentsByClassID(_ClassID);
                    break;
                case 2: // Courses
                    dgvCourses.DataSource = clsClassCourse.GetCoursesByClassID(_ClassID);
                    break;
                case 3: // Timetable
                    dgvTimetable.DataSource = clsSchedule.GetSchedulesByClassID(_ClassID);
                    break;
                case 4: // Attendance
                    dgvAttendance.DataSource = clsAttendance.GetAttendanceByClassID(_ClassID);
                    break;
                case 5: // Grades
                    dgvGrades.DataSource = clsGrade.GetGradesByClassID(_ClassID);
                    break;
            }
        }

        private void BtnEditClass_Click(object sender, EventArgs e)
        {
            frmAddEditClass frm = new frmAddEditClass(_ClassID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadClassData();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
