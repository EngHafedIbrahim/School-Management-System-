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

            clsUITheme.ApplyRTL(this);
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
                clsUITheme.ShowArabicMessage("لم يتم العثور على بيانات الشعبة المطلوبة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValClassName.Text = _Class.Name;
            lblValGradeLevel.Text = _Class.GradeLevelInfo?.Name ?? "غير محدد";
            lblValDetails.Text = string.IsNullOrEmpty(_Class.Details) ? "لا توجد ملاحظات مسجلة." : _Class.Details;

            DataTable dtStudents = clsStudentEnrollment.GetStudentsByClassID(_ClassID);
            lblValTotalStudents.Text = dtStudents.Rows.Count.ToString();
            dgvStudents.DataSource = dtStudents;
            FormatStudentsGrid();

            DataTable dtCourses = clsClassCourse.GetCoursesByClassID(_ClassID);
            lblValTotalCourses.Text = dtCourses.Rows.Count.ToString();
            dgvCourses.DataSource = dtCourses;
            FormatCoursesGrid();
        }

        private void FormatStudentsGrid()
        {
            if (dgvStudents.Columns.Contains("StudentID"))
                dgvStudents.Columns["StudentID"].HeaderText = "رقم الطالب";
            if (dgvStudents.Columns.Contains("StudentName"))
                dgvStudents.Columns["StudentName"].HeaderText = "اسم الطالب";
            if (dgvStudents.Columns.Contains("AdmissionNo"))
                dgvStudents.Columns["AdmissionNo"].HeaderText = "رقم القبول";
            if (dgvStudents.Columns.Contains("EnrollmentDate"))
                dgvStudents.Columns["EnrollmentDate"].HeaderText = "تاريخ التسجيل";
            if (dgvStudents.Columns.Contains("Status"))
                dgvStudents.Columns["Status"].HeaderText = "الحالة";
        }

        private void FormatCoursesGrid()
        {
            if (dgvCourses.Columns.Contains("CourseID"))
                dgvCourses.Columns["CourseID"].HeaderText = "رقم المقرر";
            if (dgvCourses.Columns.Contains("CourseName"))
                dgvCourses.Columns["CourseName"].HeaderText = "اسم المقرر";
            if (dgvCourses.Columns.Contains("CourseCode"))
                dgvCourses.Columns["CourseCode"].HeaderText = "رمز المقرر";
            if (dgvCourses.Columns.Contains("TeacherName"))
                dgvCourses.Columns["TeacherName"].HeaderText = "المعلم المكلف";
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
                    FormatStudentsGrid();
                    break;
                case 2: // Courses
                    dgvCourses.DataSource = clsClassCourse.GetCoursesByClassID(_ClassID);
                    FormatCoursesGrid();
                    break;
                case 3: // Timetable
                    dgvTimetable.DataSource = clsSchedule.GetSchedulesByClassID(_ClassID);
                    if (dgvTimetable.Columns.Contains("ScheduleID"))
                        dgvTimetable.Columns["ScheduleID"].HeaderText = "الرقم";
                    if (dgvTimetable.Columns.Contains("DayOfWeek"))
                        dgvTimetable.Columns["DayOfWeek"].HeaderText = "اليوم";
                    if (dgvTimetable.Columns.Contains("PeriodNumber"))
                        dgvTimetable.Columns["PeriodNumber"].HeaderText = "الحصة";
                    if (dgvTimetable.Columns.Contains("CourseName"))
                        dgvTimetable.Columns["CourseName"].HeaderText = "المادة الدراسية";
                    if (dgvTimetable.Columns.Contains("TeacherName"))
                        dgvTimetable.Columns["TeacherName"].HeaderText = "المعلم";
                    break;
                case 4: // Attendance
                    dgvAttendance.DataSource = clsAttendance.GetAttendanceByClassID(_ClassID);
                    if (dgvAttendance.Columns.Contains("AttendanceDate"))
                        dgvAttendance.Columns["AttendanceDate"].HeaderText = "التاريخ";
                    if (dgvAttendance.Columns.Contains("StudentName"))
                        dgvAttendance.Columns["StudentName"].HeaderText = "اسم الطالب";
                    if (dgvAttendance.Columns.Contains("Status"))
                        dgvAttendance.Columns["Status"].HeaderText = "حالة الحضور";
                    break;
                case 5: // Grades
                    dgvGrades.DataSource = clsGrade.GetGradesByClassID(_ClassID);
                    if (dgvGrades.Columns.Contains("GradeID"))
                        dgvGrades.Columns["GradeID"].HeaderText = "الرقم";
                    if (dgvGrades.Columns.Contains("StudentName"))
                        dgvGrades.Columns["StudentName"].HeaderText = "اسم الطالب";
                    if (dgvGrades.Columns.Contains("CourseName"))
                        dgvGrades.Columns["CourseName"].HeaderText = "المادة";
                    if (dgvGrades.Columns.Contains("Score"))
                        dgvGrades.Columns["Score"].HeaderText = "الدرجة";
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
