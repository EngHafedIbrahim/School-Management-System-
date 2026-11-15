using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Enrollment;
using SchoolManagementSystem.Properties;

namespace SchoolManagementSystem.Students
{
    public partial class frmStudentProfile : Form
    {
        private int _StudentID;
        private clsStudent _Student;

        public frmStudentProfile(int studentID)
        {
            InitializeComponent();
            _StudentID = studentID;

            clsUITheme.AddHeaderBottomLine(pnlHeader);

            clsUITheme.StyleDataGridView(dgvParents);
            clsUITheme.StyleDataGridView(dgvEnrollment);
            dgvEnrollment.CellFormatting += DgvEnrollment_CellFormatting;
            clsUITheme.StyleDataGridView(dgvAttendance);
            clsUITheme.StyleDataGridView(dgvGrades);
            clsUITheme.StyleDataGridView(dgvFinancial);

            clsUITheme.AddHoverEffect(btnLinkParent);
            clsUITheme.AddHoverEffect(btnUnlinkParent);
            clsUITheme.AddHoverEffect(btnEnrollStudent);
            clsUITheme.AddHoverEffect(btnEditProfile);
            clsUITheme.AddHoverEffectOutline(btnClose);

            LoadStudentData();
        }

        public void LoadStudentData()
        {
            _Student = clsStudent.Find(_StudentID);
            if (_Student == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الطالب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValFullName.Text = $"{_Student.FirstName} {_Student.LastName}";
            lblValAdmNo.Text = _Student.AdmissionNo;
            lblValNationalID.Text = _Student.NationalID;
            lblValDOB.Text = _Student.DateOfBirth.ToString("yyyy-MM-dd");
            lblValGender.Text = (_Student.GenderID == 1) ? "ذكر" : "أنثى";
            lblValNationality.Text = string.IsNullOrEmpty(_Student.Nationality) ? "يمني" : _Student.Nationality;
            lblValBlood.Text = string.IsNullOrEmpty(_Student.BloodType) ? "غير محدد" : _Student.BloodType;
            lblValPhone.Text = string.IsNullOrEmpty(_Student.PhoneNumber) ? "غير متوفر" : _Student.PhoneNumber;
            lblValEmail.Text = string.IsNullOrEmpty(_Student.Email) ? "غير متوفر" : _Student.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Student.Address) ? "غير متوفر" : _Student.Address;
            lblValAdmDate.Text = _Student.AdmissionDate.ToString("yyyy-MM-dd");
            lblValPrevSchool.Text = string.IsNullOrEmpty(_Student.PreviousSchool) ? "لا توجد" : _Student.PreviousSchool;
            lblValHealth.Text = string.IsNullOrEmpty(_Student.HealthStatus) ? "سليم / لائق صحياً" : _Student.HealthStatus;

            try
            {
                if (!string.IsNullOrEmpty(_Student.ProfileImageURL) && File.Exists(_Student.ProfileImageURL))
                    pbxStudentImage.Image = Image.FromFile(_Student.ProfileImageURL);
                else
                    pbxStudentImage.Image = Resources.icons8_student_male_1000;
            }
            catch (Exception)
            {
                pbxStudentImage.Image = null;
            }

            RefreshParents();
            RefreshEnrollment();
            RefreshAttendance();
            RefreshGrades();
            RefreshFinancial();
        }

        private void RefreshParents()
        {
            dgvParents.DataSource = clsStudentParent.GetParentsByStudentID(_StudentID);
            if (dgvParents.Columns.Contains("StudentParentID"))
                dgvParents.Columns["StudentParentID"].Visible = false;
            if (dgvParents.Columns.Contains("ParentID"))
                dgvParents.Columns["ParentID"].HeaderText = "رقم ولي الأمر";
            if (dgvParents.Columns.Contains("ParentName"))
                dgvParents.Columns["ParentName"].HeaderText = "اسم ولي الأمر";
            if (dgvParents.Columns.Contains("RelationshipType"))
                dgvParents.Columns["RelationshipType"].HeaderText = "صلة القرابة";
            if (dgvParents.Columns.Contains("Phone"))
                dgvParents.Columns["Phone"].HeaderText = "رقم الهاتف";
            if (dgvParents.Columns.Contains("IsEmergencyContact"))
                dgvParents.Columns["IsEmergencyContact"].HeaderText = "جهة اتصال طوارئ";
        }

        private void RefreshEnrollment()
        {
            dgvEnrollment.DataSource = clsStudentEnrollment.GetEnrollmentHistoryByStudentID(_StudentID);
            if (dgvEnrollment.Columns.Contains("EnrollmentID"))
                dgvEnrollment.Columns["EnrollmentID"].HeaderText = "رقم القيد";
            if (dgvEnrollment.Columns.Contains("AcademicYear"))
                dgvEnrollment.Columns["AcademicYear"].HeaderText = "السنة الأكاديمية";
            if (dgvEnrollment.Columns.Contains("GradeLevelName"))
                dgvEnrollment.Columns["GradeLevelName"].HeaderText = "المرحلة / الصف";
            if (dgvEnrollment.Columns.Contains("ClassName"))
                dgvEnrollment.Columns["ClassName"].HeaderText = "الشعبة / الفصل";
            if (dgvEnrollment.Columns.Contains("EnrollmentDate"))
                dgvEnrollment.Columns["EnrollmentDate"].HeaderText = "تاريخ القيد";
            if (dgvEnrollment.Columns.Contains("Status"))
                dgvEnrollment.Columns["Status"].HeaderText = "حالة القيد";
        }

        private void RefreshAttendance()
        {
            DataTable dt = clsAttendance.GetAttendanceByStudentID(_StudentID);
            if (dt != null)
            {
                dgvAttendance.DataSource = dt;
                if (dgvAttendance.Columns.Contains("AttendanceID"))
                    dgvAttendance.Columns["AttendanceID"].Visible = false;
                if (dgvAttendance.Columns.Contains("AttendanceDate"))
                    dgvAttendance.Columns["AttendanceDate"].HeaderText = "التاريخ";
                if (dgvAttendance.Columns.Contains("Status"))
                    dgvAttendance.Columns["Status"].HeaderText = "حالة الحضور";
                if (dgvAttendance.Columns.Contains("Remarks"))
                    dgvAttendance.Columns["Remarks"].HeaderText = "ملاحظات";
            }
        }

        private void RefreshGrades()
        {
            dgvGrades.DataSource = clsGrade.GetGradesByStudentID(_StudentID);
            if (dgvGrades.Columns.Contains("GradeID"))
                dgvGrades.Columns["GradeID"].Visible = false;
            if (dgvGrades.Columns.Contains("CourseName"))
                dgvGrades.Columns["CourseName"].HeaderText = "المادة / المقرر";
            if (dgvGrades.Columns.Contains("ExamType"))
                dgvGrades.Columns["ExamType"].HeaderText = "نوع الاختبار";
            if (dgvGrades.Columns.Contains("Score"))
                dgvGrades.Columns["Score"].HeaderText = "الدرجة المستحقة";
            if (dgvGrades.Columns.Contains("MaxScore"))
                dgvGrades.Columns["MaxScore"].HeaderText = "الدرجة العظمى";
            if (dgvGrades.Columns.Contains("GradeLetter"))
                dgvGrades.Columns["GradeLetter"].HeaderText = "التقدير";
        }

        private void RefreshFinancial()
        {
            dgvFinancial.DataSource = clsInvoice.GetInvoicesByStudentID(_StudentID);
            if (dgvFinancial.Columns.Contains("InvoiceID"))
                dgvFinancial.Columns["InvoiceID"].Visible = false;
            if (dgvFinancial.Columns.Contains("InvoiceNumber"))
                dgvFinancial.Columns["InvoiceNumber"].HeaderText = "كود الفاتورة";
            if (dgvFinancial.Columns.Contains("AcademicYear"))
                dgvFinancial.Columns["AcademicYear"].HeaderText = "السنة الدراسية";
            if (dgvFinancial.Columns.Contains("TotalAmount"))
                dgvFinancial.Columns["TotalAmount"].HeaderText = "المبلغ الإجمالي";
            if (dgvFinancial.Columns.Contains("PaidAmount"))
                dgvFinancial.Columns["PaidAmount"].HeaderText = "المدفوع";
            if (dgvFinancial.Columns.Contains("RemainingAmount"))
                dgvFinancial.Columns["RemainingAmount"].HeaderText = "المتبقي";
            if (dgvFinancial.Columns.Contains("Status"))
                dgvFinancial.Columns["Status"].HeaderText = "حالة السداد";
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frm = new frmRegisterStudent(_StudentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentData();
            }
        }

        private void BtnLinkParent_Click(object sender, EventArgs e)
        {
            frmLinkParentToStudent frm = new frmLinkParentToStudent(_StudentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshParents();
            }
        }

        private void BtnUnlinkParent_Click(object sender, EventArgs e)
        {
            if (dgvParents.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد ولي أمر لفك ارتباطه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentParentID = Convert.ToInt32(dgvParents.CurrentRow.Cells["StudentParentID"].Value);
            string parentName = dgvParents.CurrentRow.Cells["ParentName"].Value?.ToString() ?? "";

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من فك ارتباط الطالب بولي الأمر '{parentName}'؟", "تأكيد فك الارتباط", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsStudentParent.DeleteStudentParent(studentParentID))
                {
                    clsUITheme.ShowArabicMessage("تم فك ارتباط ولي الأمر بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshParents();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل فك ارتباط ولي الأمر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEnrollStudent_Click(object sender, EventArgs e)
        {
            frmEnrollStudent frm = new frmEnrollStudent();
            frm.PreSelectStudent(_StudentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshEnrollment();
            }
        }

        private void DgvEnrollment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEnrollment.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                switch (status)
                {
                    case "Active":
                        e.Value = "نشط";
                        e.CellStyle.BackColor = Color.FromArgb(209, 250, 229);
                        e.CellStyle.ForeColor = Color.FromArgb(6, 95, 70);
                        break;
                    case "Withdrawn":
                        e.Value = "منسحب";
                        e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                        e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                        break;
                    case "Graduated":
                        e.Value = "متخرج";
                        e.CellStyle.BackColor = Color.FromArgb(219, 234, 254);
                        e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);
                        break;
                    case "Transferred":
                        e.Value = "منقول";
                        e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);
                        e.CellStyle.ForeColor = Color.FromArgb(146, 64, 14);
                        break;
                }
                e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.FormattingApplied = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStudentProfile_Load(object sender, EventArgs e)
        {
        }
    }
}
