using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Teachers
{
    public partial class frmTeacherProfile : Form
    {
        private int _TeacherID;
        private clsTeacher _Teacher;

        public frmTeacherProfile(int teacherID)
        {
            InitializeComponent();
            _TeacherID = teacherID;

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvAssignments);
            clsUITheme.StyleDataGridView(dgvTimetable);
            clsUITheme.StylePrimaryButton(btnCreateUserAccount);
            clsUITheme.StylePrimaryButton(btnEditTeacher);
            clsUITheme.StyleSecondaryButton(btnClose);

            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            _Teacher = clsTeacher.Find(_TeacherID);
            if (_Teacher == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل المعلم المطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValFullName.Text = $"{_Teacher.FirstName} {_Teacher.LastName}";
            lblValPhone.Text = _Teacher.PhoneNumber;
            lblValEmail.Text = _Teacher.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Teacher.Address) ? "غير محدد" : _Teacher.Address;
            lblValGender.Text = (_Teacher.GenderID == 1) ? "ذكر" : "أنثى";
            lblValSpecialization.Text = string.IsNullOrEmpty(_Teacher.Specialization) ? "عام" : _Teacher.Specialization;
            lblValQualification.Text = string.IsNullOrEmpty(_Teacher.Qualification) ? "غير محدد" : _Teacher.Qualification;
            lblValHireDate.Text = _Teacher.HireDate.ToString("yyyy-MM-dd");

            lblValStatus.Text = _Teacher.EmploymentStatus switch
            {
                "Active" => "نشط",
                "On Leave" => "في إجازة",
                "Probation" => "تحت التجربة",
                "Suspended" => "موقوف",
                "Resigned" => "مستقيل",
                _ => string.IsNullOrEmpty(_Teacher.EmploymentStatus) ? "نشط" : _Teacher.EmploymentStatus
            };

            lblValAbout.Text = string.IsNullOrEmpty(_Teacher.About) ? "لا توجد ملاحظات مسجلة." : _Teacher.About;

            // Load Assignments
            dgvAssignments.DataSource = clsClassCourse.GetAssignmentsByTeacherID(_TeacherID);
            FormatAssignmentsGrid();

            // Load Timetable
            dgvTimetable.DataSource = clsSchedule.GetSchedulesByTeacherID(_TeacherID);
            FormatTimetableGrid();

            // Check linked User Account
            CheckLinkedUserAccount();
        }

        private void FormatAssignmentsGrid()
        {
            if (dgvAssignments.Columns.Contains("ClassCourseID"))
                dgvAssignments.Columns["ClassCourseID"].HeaderText = "الرقم";
            if (dgvAssignments.Columns.Contains("GradeLevel"))
                dgvAssignments.Columns["GradeLevel"].HeaderText = "المرحلة / الصف";
            if (dgvAssignments.Columns.Contains("ClassName"))
                dgvAssignments.Columns["ClassName"].HeaderText = "الشعبة / الفصل";
            if (dgvAssignments.Columns.Contains("CourseName"))
                dgvAssignments.Columns["CourseName"].HeaderText = "المادة الدراسية";
            if (dgvAssignments.Columns.Contains("AcademicYear"))
                dgvAssignments.Columns["AcademicYear"].HeaderText = "السنة الدراسية";
        }

        private void FormatTimetableGrid()
        {
            if (dgvTimetable.Columns.Contains("ScheduleID"))
                dgvTimetable.Columns["ScheduleID"].HeaderText = "الرقم";
            if (dgvTimetable.Columns.Contains("DayOfWeek"))
                dgvTimetable.Columns["DayOfWeek"].HeaderText = "اليوم";
            if (dgvTimetable.Columns.Contains("PeriodNumber"))
                dgvTimetable.Columns["PeriodNumber"].HeaderText = "الحصة";
            if (dgvTimetable.Columns.Contains("ClassName"))
                dgvTimetable.Columns["ClassName"].HeaderText = "الشعبة / الفصل";
            if (dgvTimetable.Columns.Contains("CourseName"))
                dgvTimetable.Columns["CourseName"].HeaderText = "المادة";
            if (dgvTimetable.Columns.Contains("RoomNumber"))
                dgvTimetable.Columns["RoomNumber"].HeaderText = "القاعة";
        }

        private void CheckLinkedUserAccount()
        {
            try
            {
                DataTable dtUsers = clsUser.GetAllUsers();
                if (dtUsers == null) return;

                DataRow[] found = dtUsers.Select($"ReferenceID = {_TeacherID} AND UserType = 'Teacher'");

                if (found.Length > 0)
                {
                    lblValUsername.Text = found[0]["Username"].ToString();
                    string status = found[0]["Status"].ToString();
                    lblValUserStatus.Text = (status == "Active") ? "نشط" : status;
                    lblValUserStatus.ForeColor = status.Equals("Active", StringComparison.OrdinalIgnoreCase) ? System.Drawing.Color.FromArgb(16, 185, 129) : System.Drawing.Color.FromArgb(220, 38, 38);
                    btnCreateUserAccount.Enabled = false;
                    btnCreateUserAccount.Text = "الحساب موجود بالفعل";
                }
                else
                {
                    lblValUsername.Text = "لا يوجد حساب دخول مرتبط";
                    lblValUserStatus.Text = "غير منشأ";
                    lblValUserStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
                    btnCreateUserAccount.Enabled = true;
                    btnCreateUserAccount.Text = "إنشاء حساب دخول للمعلم";
                }
            }
            catch
            {
                lblValUsername.Text = "غير متوفر";
                lblValUserStatus.Text = "---";
            }
        }

        private void BtnCreateUserAccount_Click(object sender, EventArgs e)
        {
            clsUITheme.ShowArabicMessage("خاصية إنشاء حساب دخول للمعلم ستكون متاحة مع إدارة المستخدمين.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frm = new frmAddEditTeacher(_TeacherID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherData();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
