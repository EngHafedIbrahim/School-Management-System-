using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;
using SchoolManagementSystem.Parents;
using SchoolManagementSystem.Academic;

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
            frmAcademicYears frm = new frmAcademicYears();
            frm.ShowDialog();
            LoadDashboardStats();
        }

        private void BtnNavTeachers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teachers management will be implemented in Phase 3.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Courses management will be implemented in Phase 3.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavTimetable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timetable management will be implemented in Phase 3.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Finance management will be implemented in Phase 5.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Users management will be implemented in Phase 6.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNavReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporting will be implemented in Phase 6.", "Module Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
