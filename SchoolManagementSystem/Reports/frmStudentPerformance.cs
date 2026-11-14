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

            dgvEnrollments.CellFormatting += DgvEnrollments_CellFormatting;
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
                clsUITheme.ShowArabicMessage("يرجى اختيار كل من الطالب والعام الدراسي أولاً.", "تحديد مطلوب", MessageBoxIcon.Information);
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
                    clsUITheme.ShowArabicMessage("تم رفض الوصول: غير مصرح لك باستعراض التقرير الأكاديمي لهذا الطالب.", "انتهاك صلاحيات الوصول", MessageBoxIcon.Stop);
                    return;
                }
            }

            clsStudent student = clsStudent.Find(studentID);
            if (student == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الطالب المحدد في النظام.", "خطأ", MessageBoxIcon.Error);
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
                dgvEnrollments.Columns["EnrollmentID"].HeaderText = "المعرف";
                dgvEnrollments.Columns["EnrollmentID"].Width = 70;
            }
            if (dgvEnrollments.Columns.Contains("AcademicYear"))
            {
                dgvEnrollments.Columns["AcademicYear"].HeaderText = "العام الدراسي";
                dgvEnrollments.Columns["AcademicYear"].Width = 160;
            }
            if (dgvEnrollments.Columns.Contains("ClassName"))
            {
                dgvEnrollments.Columns["ClassName"].HeaderText = "الصف والشعبة";
                dgvEnrollments.Columns["ClassName"].Width = 160;
            }
            if (dgvEnrollments.Columns.Contains("EnrollmentDate"))
            {
                dgvEnrollments.Columns["EnrollmentDate"].HeaderText = "تاريخ القيد";
                dgvEnrollments.Columns["EnrollmentDate"].Width = 130;
                dgvEnrollments.Columns["EnrollmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvEnrollments.Columns.Contains("Status"))
            {
                dgvEnrollments.Columns["Status"].HeaderText = "حالة القيد";
                dgvEnrollments.Columns["Status"].Width = 120;
            }

            // Update Class in summary header with current/latest class
            if (dtEnrollments.Rows.Count > 0)
            {
                lblClassVal.Text = dtEnrollments.Rows[0]["ClassName"].ToString();
            }
            else
            {
                lblClassVal.Text = "غير مسجل حالياً";
            }
        }

        private void DgvEnrollments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvEnrollments.Columns[e.ColumnIndex].DataPropertyName;
            if (colName == "Status")
            {
                string status = e.Value.ToString();
                switch (status.ToLowerInvariant())
                {
                    case "active":
                        e.Value = "نشط";
                        break;
                    case "completed":
                        e.Value = "مكتمل";
                        break;
                    case "withdrawn":
                        e.Value = "منسحب";
                        break;
                    case "transferred":
                        e.Value = "منقول";
                        break;
                }
            }
        }

        private void LoadGradesSection(int studentID, int yearID)
        {
            DataTable dtGrades = clsGrade.GetGradesByStudentAndYear(studentID, yearID);
            dgvGrades.DataSource = dtGrades;

            if (dgvGrades.Columns.Contains("GradeID"))
            {
                dgvGrades.Columns["GradeID"].HeaderText = "المعرف";
                dgvGrades.Columns["GradeID"].Width = 70;
            }
            if (dgvGrades.Columns.Contains("CourseName"))
            {
                dgvGrades.Columns["CourseName"].HeaderText = "المادة / المقرر";
                dgvGrades.Columns["CourseName"].Width = 200;
            }
            if (dgvGrades.Columns.Contains("ExamType"))
            {
                dgvGrades.Columns["ExamType"].HeaderText = "نوع الامتحان / التقييم";
                dgvGrades.Columns["ExamType"].Width = 160;
            }
            if (dgvGrades.Columns.Contains("GradeValue"))
            {
                dgvGrades.Columns["GradeValue"].HeaderText = "الدرجة المحرزة";
                dgvGrades.Columns["GradeValue"].Width = 110;
            }
            if (dgvGrades.Columns.Contains("OutOfValue"))
            {
                dgvGrades.Columns["OutOfValue"].HeaderText = "الدرجة العظمى";
                dgvGrades.Columns["OutOfValue"].Width = 110;
            }
            if (dgvGrades.Columns.Contains("Percentage"))
            {
                dgvGrades.Columns["Percentage"].HeaderText = "النسبة المئوية (%)";
                dgvGrades.Columns["Percentage"].Width = 130;
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
                clsUITheme.ShowArabicMessage("يرجى تحميل تقرير الطالب أولاً قبل إجراء الطباعة.", "تنبيه", MessageBoxIcon.Information);
                return;
            }

            clsUITheme.ShowArabicMessage(
                $"[كشف الأداء الأكاديمي الشامل]\n\n" +
                $"الطالب: {lblStudentNameVal.Text} (رقم القبول: {lblAdmissionNoVal.Text})\n" +
                $"العام الدراسي: {lblAcademicYearVal.Text}\n" +
                $"الصف: {lblClassVal.Text}\n" +
                $"نسبة الالتزام بالحضور: {lblAttendanceRateVal.Text}\n" +
                $"إجمالي سجلات التقييم: {dgvGrades.Rows.Count}\n\n" +
                $"تم إعداد كشف الأداء بنجاح وجاهز لأمر الطباعة.",
                "معاينة طباعة التقرير الأكاديمي",
                MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
