using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Reports
{
    public partial class frmStudentPerformance : Form
    {
        private readonly int? _preselectedStudentID;

        public frmStudentPerformance(int? preselectedStudentID = null)
        {
            _preselectedStudentID = preselectedStudentID;
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvGrades);
            clsUITheme.StyleDataGridView(dgvEnrollments);
            clsUITheme.StylePrimaryButton(btnGenerate);
            clsUITheme.StyleSecondaryButton(btnPrint);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmStudentPerformance_Load(object sender, EventArgs e)
        {
            LoadAcademicYears();
            LoadStudents();

            if (_preselectedStudentID.HasValue)
            {
                cbStudent.SelectedValue = _preselectedStudentID.Value;
                BtnGenerate_Click(null, null);
            }
        }

        private void LoadAcademicYears()
        {
            DataTable dtYears = clsAcademicYear.GetAllAcademicYears();
            cbYear.DataSource = dtYears;
            cbYear.DisplayMember = "YearName";
            cbYear.ValueMember = "AcademicYearID";
        }

        private void LoadStudents()
        {
            DataTable dtStudents;

            // Authorization: If current user is Parent, ONLY show their children
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserType == "Parent" && clsGloble.CurrentUser.ReferenceID.HasValue)
            {
                int parentID = clsGloble.CurrentUser.ReferenceID.Value;
                dtStudents = clsStudentParent.GetStudentsByParentID(parentID);
            }
            else
            {
                // Admin can view all students
                dtStudents = clsStudent.GetAllStudents();
            }

            if (!dtStudents.Columns.Contains("DisplayName"))
            {
                dtStudents.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + AdmissionNo + ')'");
            }

            cbStudent.DataSource = dtStudents;
            cbStudent.DisplayMember = "DisplayName";
            cbStudent.ValueMember = "StudentID";
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (cbStudent.SelectedValue == null || cbYear.SelectedValue == null)
            {
                MessageBox.Show("Please select both a student and an academic year.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentID = Convert.ToInt32(cbStudent.SelectedValue);
            int yearID = Convert.ToInt32(cbYear.SelectedValue);

            // Authorization Enforcement in Business Layer: Parent can only access their child
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserType == "Parent" && clsGloble.CurrentUser.ReferenceID.HasValue)
            {
                int parentID = clsGloble.CurrentUser.ReferenceID.Value;
                if (!clsStudentParent.IsParentOfStudent(parentID, studentID))
                {
                    MessageBox.Show("Access Denied: You are not authorized to view this student's performance report.", "Authorization Violation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            clsStudent student = clsStudent.Find(studentID);
            if (student == null)
            {
                MessageBox.Show("Student record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Populate Student Summary Card
            lblStudentNameVal.Text = $"{student.FirstName} {student.LastName}";
            lblAdmissionNoVal.Text = student.AdmissionNo;
            lblAcademicYearVal.Text = cbYear.Text;

            // Section 1: Load Enrollment History
            LoadEnrollmentSection(studentID);

            // Section 2: Load Academic Grades for the Selected Year
            LoadGradesSection(studentID, yearID);

            // Section 3: Load Attendance Metrics for the Selected Year
            LoadAttendanceSection(studentID, yearID);
        }

        private void LoadEnrollmentSection(int studentID)
        {
            DataTable dtEnrollments = clsStudentEnrollment.GetEnrollmentsByStudentID(studentID);
            dgvEnrollments.DataSource = dtEnrollments;

            if (dgvEnrollments.Columns.Contains("EnrollmentID"))
            {
                dgvEnrollments.Columns["EnrollmentID"].HeaderText = "ID";
                dgvEnrollments.Columns["EnrollmentID"].Width = 60;
            }
            if (dgvEnrollments.Columns.Contains("AcademicYear"))
            {
                dgvEnrollments.Columns["AcademicYear"].HeaderText = "Academic Year";
                dgvEnrollments.Columns["AcademicYear"].Width = 150;
            }
            if (dgvEnrollments.Columns.Contains("ClassName"))
            {
                dgvEnrollments.Columns["ClassName"].HeaderText = "Class";
                dgvEnrollments.Columns["ClassName"].Width = 150;
            }
            if (dgvEnrollments.Columns.Contains("EnrollmentDate"))
            {
                dgvEnrollments.Columns["EnrollmentDate"].HeaderText = "Enrollment Date";
                dgvEnrollments.Columns["EnrollmentDate"].Width = 130;
            }
            if (dgvEnrollments.Columns.Contains("Status"))
            {
                dgvEnrollments.Columns["Status"].HeaderText = "Status";
                dgvEnrollments.Columns["Status"].Width = 110;
            }

            // Update Class in summary header with current/latest class
            if (dtEnrollments.Rows.Count > 0)
            {
                lblClassVal.Text = dtEnrollments.Rows[0]["ClassName"].ToString();
            }
            else
            {
                lblClassVal.Text = "Not Enrolled";
            }
        }

        private void LoadGradesSection(int studentID, int yearID)
        {
            DataTable dtGrades = clsGrade.GetGradesByStudentAndYear(studentID, yearID);
            dgvGrades.DataSource = dtGrades;

            if (dgvGrades.Columns.Contains("GradeID"))
            {
                dgvGrades.Columns["GradeID"].HeaderText = "ID";
                dgvGrades.Columns["GradeID"].Width = 60;
            }
            if (dgvGrades.Columns.Contains("CourseName"))
            {
                dgvGrades.Columns["CourseName"].HeaderText = "Subject / Course";
                dgvGrades.Columns["CourseName"].Width = 200;
            }
            if (dgvGrades.Columns.Contains("ExamType"))
            {
                dgvGrades.Columns["ExamType"].HeaderText = "Exam Type";
                dgvGrades.Columns["ExamType"].Width = 150;
            }
            if (dgvGrades.Columns.Contains("GradeValue"))
            {
                dgvGrades.Columns["GradeValue"].HeaderText = "Score";
                dgvGrades.Columns["GradeValue"].Width = 100;
            }
            if (dgvGrades.Columns.Contains("OutOfValue"))
            {
                dgvGrades.Columns["OutOfValue"].HeaderText = "Out Of";
                dgvGrades.Columns["OutOfValue"].Width = 100;
            }
            if (dgvGrades.Columns.Contains("Percentage"))
            {
                dgvGrades.Columns["Percentage"].HeaderText = "Percentage (%)";
                dgvGrades.Columns["Percentage"].Width = 120;
                dgvGrades.Columns["Percentage"].DefaultCellStyle.Format = "0.0'%'";
            }
        }

        private void LoadAttendanceSection(int studentID, int yearID)
        {
            DataTable dtAttendance = clsAttendance.GetAttendanceSummaryByStudent(studentID, yearID);
            if (dtAttendance != null && dtAttendance.Rows.Count > 0)
            {
                DataRow r = dtAttendance.Rows[0];
                lblTotalSessionsVal.Text = r["TotalSessions"] != DBNull.Value ? r["TotalSessions"].ToString() : "0";
                lblPresentVal.Text = r["PresentCount"] != DBNull.Value ? r["PresentCount"].ToString() : "0";
                lblAbsentVal.Text = r["AbsentCount"] != DBNull.Value ? r["AbsentCount"].ToString() : "0";
                lblLateVal.Text = r["LateCount"] != DBNull.Value ? r["LateCount"].ToString() : "0";

                double rate = r["AttendancePercentage"] != DBNull.Value ? Convert.ToDouble(r["AttendancePercentage"]) : 0.0;
                lblAttendanceRateVal.Text = $"{rate:0.0} %";
            }
            else
            {
                lblTotalSessionsVal.Text = "0";
                lblPresentVal.Text = "0";
                lblAbsentVal.Text = "0";
                lblLateVal.Text = "0";
                lblAttendanceRateVal.Text = "0.0 %";
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblStudentNameVal.Text) || lblStudentNameVal.Text == "---")
            {
                MessageBox.Show("Please load a student performance report first before printing.", "Report Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"[Student Performance Statement]\n\nStudent: {lblStudentNameVal.Text} (Adm: {lblAdmissionNoVal.Text})\nAcademic Year: {lblAcademicYearVal.Text}\nClass: {lblClassVal.Text}\nAttendance Rate: {lblAttendanceRateVal.Text}\nTotal Exam Records: {dgvGrades.Rows.Count}\n\nThe complete academic performance statement is compiled and ready for printing.", "Performance Report Print Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
