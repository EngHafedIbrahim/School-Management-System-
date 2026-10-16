using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;
using SchoolManagementSystem.Parents;
using SchoolManagementSystem.Academic;
using SchoolManagementSystem.Classes;
using SchoolManagementSystem.Teachers;
using SchoolManagementSystem.Courses;
using SchoolManagementSystem.Finance;
using SchoolManagementSystem.Users;
using SchoolManagementSystem.Reports;

namespace SchoolManagementSystem.Dashboard
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadDashboardStats();
        }

        public void LoadDashboardStats()
        {
            var stats = clsDashboard.GetDashboardStats();
            lblTotalStudents.Text = stats.TotalStudents.ToString();
            lblTotalTeachers.Text = stats.TotalTeachers.ToString();
            lblTotalClasses.Text = stats.TotalClasses.ToString();
            lblTotalParents.Text = stats.TotalParents.ToString();
            lblAcademicYear.Text = stats.CurrentAcademicYear;
        }

        private void BtnNavStudents_Click(object sender, EventArgs e)
        {
            frmStudentList frm = new frmStudentList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavParents_Click(object sender, EventArgs e)
        {
            frmParentList frm = new frmParentList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavAcademic_Click(object sender, EventArgs e)
        {
            frmClassList frm = new frmClassList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavTeachers_Click(object sender, EventArgs e)
        {
            frmTeacherList frm = new frmTeacherList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavCourses_Click(object sender, EventArgs e)
        {
            frmCourseList frm = new frmCourseList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavTimetable_Click(object sender, EventArgs e)
        {
            frmTimetableManagement frm = new frmTimetableManagement();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendance management will be implemented in Phase 4.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavGrades_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grades management will be implemented in Phase 4.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavFinance_Click(object sender, EventArgs e)
        {
            frmPaymentTypes frm = new frmPaymentTypes();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavUsers_Click(object sender, EventArgs e)
        {
            frmUserList frm = new frmUserList();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavReports_Click(object sender, EventArgs e)
        {
            frmStudentPerformance frm = new frmStudentPerformance();
            frm.ShowDialog();
            LoadDashboardStats();
        }
    }
}
