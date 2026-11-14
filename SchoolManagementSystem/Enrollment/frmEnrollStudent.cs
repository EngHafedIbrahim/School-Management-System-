using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;

namespace SchoolManagementSystem.Enrollment
{
    public partial class frmEnrollStudent : Form
    {
        public enum enMode { Add = 1, Update, ChangeStatus }

        public enMode eMode = enMode.Add;
        private readonly int _studentEnrollmentID;
        private clsStudentEnrollment _enrollment;
        private int _preSelectedStudentID = -1;
        
        frmRegisterStudent _frmStudent;

        public void PreSelectStudent(int studentID)
        {
            _preSelectedStudentID = studentID;
        }
        public void PreSelectStudent(int studentID, frmRegisterStudent frmStudent)
        {
            _preSelectedStudentID = studentID;
            _frmStudent = frmStudent;
        }

        private string SelectedStatus => cbStatus.SelectedIndex switch
        {
            0 => "Active",
            1 => "Transferred",
            2 => "Graduated",
            3 => "Withdrawn",
            _ => "Active"
        };

        private void SetStatusSelection(string status)
        {
            cbStatus.SelectedIndex = status switch
            {
                "Active" => 0,
                "Transferred" => 1,
                "Graduated" => 2,
                "Withdrawn" => 3,
                _ => 0
            };
        }

        public frmEnrollStudent(int studentEnrollmentID = -1)
        {
            InitializeComponent();

            _studentEnrollmentID = studentEnrollmentID;

            if (studentEnrollmentID != -1)
            {
                eMode = enMode.Update;
            }

            clsUITheme.AddHeaderBottomLine(pnlHeader);
            clsUITheme.AddHoverEffect(btnSave);
            clsUITheme.AddHoverEffectOutline(btnCancel);
            clsUITheme.StyleFormControls(this);
        }

        public frmEnrollStudent(int studentEnrollmentID, enMode Mode = enMode.ChangeStatus)
        {
            InitializeComponent();

            _studentEnrollmentID = studentEnrollmentID;

            if (studentEnrollmentID > 0)
            {
                eMode = Mode;
            }

            clsUITheme.AddHeaderBottomLine(pnlHeader);
            clsUITheme.AddHoverEffect(btnSave);
            clsUITheme.AddHoverEffectOutline(btnCancel);
            clsUITheme.StyleFormControls(this);
        }

        private void FrmEnrollStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadAcademicYears();
            LoadGradeLevels();
            cbStatus.SelectedIndex = 0; // نشط
            dtpEnrollmentDate.Value = DateTime.Today;

            if (_preSelectedStudentID > 0)
            {
                cbStudent.SelectedValue = _preSelectedStudentID;
                cbStudent.Enabled = false;
            }

            if (eMode == enMode.ChangeStatus)
            {
                lblTitle.Text = $"تغيير حالة القيد [رقم القيد: {_studentEnrollmentID}]";
                btnSave.Text = "تحديث الحالة";
                cbStudent.Enabled = false;
                cbGradeLevel.Enabled = false;
                cbAcademicYear.Enabled = false;
                cbClass.Enabled = false;
                dtpEnrollmentDate.Enabled = false;

                LoadEnrollmentData();
                return;
            }

            if (eMode == enMode.Update)
            {
                lblTitle.Text = $"تعديل قيد الطالب [رقم القيد: {_studentEnrollmentID}]";
                btnSave.Text = "تحديث القيد";
                cbStudent.Enabled = false;
                LoadEnrollmentData();
            }
        }

        private void LoadStudents()
        {
            DataTable dt = clsStudent.GetStudentsForComboBox();

            cbStudent.DataSource = dt;
            cbStudent.DisplayMember = "DisplayName";
            cbStudent.ValueMember = "StudentID";

            cbStudent.DropDownStyle = ComboBoxStyle.DropDown;
            cbStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbStudent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadAcademicYears()
        {
            DataTable dt = clsAcademicYear.GetCurrentAcademicYear();
            cbAcademicYear.DataSource = dt;
            cbAcademicYear.DisplayMember = "YearName";
            cbAcademicYear.ValueMember = "AcademicYearID";
        }

        private void LoadGradeLevels()
        {
            DataTable dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
            cbGradeLevel.DataSource = dtGradeLevels;
            cbGradeLevel.DisplayMember = "Name";
            cbGradeLevel.ValueMember = "GradeLevelID";
        }

        private void LoadEnrollmentData()
        {
            try
            {
                if (eMode != enMode.Update && eMode != enMode.ChangeStatus)
                {
                    clsUITheme.ShowArabicMessage("النمط الحالي هو إضافة ويجب أن يكون تعديلاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _enrollment = clsStudentEnrollment.Find(_studentEnrollmentID);
                if (_enrollment == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على سجل القيد المطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                cbStudent.SelectedValue = _enrollment.StudentID;
                cbAcademicYear.SelectedValue = _enrollment.AcademicYearID;
                cbGradeLevel.SelectedValue = _enrollment.GradeLevelID;

                LoadClasses(_enrollment.GradeLevelID, _enrollment.ClassID);

                dtpEnrollmentDate.Value = _enrollment.EnrollmentDate;
                SetStatusSelection(_enrollment.Status);

                if (_enrollment.WithdrawalDate.HasValue)
                {
                    dtpWithdrawalDate.Visible = true;
                    lblWithdrawalDate.Visible = true;
                    dtpWithdrawalDate.Value = _enrollment.WithdrawalDate.Value;
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isWithdrawn = SelectedStatus == "Withdrawn";
            lblWithdrawalDate.Visible = isWithdrawn;
            dtpWithdrawalDate.Visible = isWithdrawn;
            if (isWithdrawn && _studentEnrollmentID == -1)
            {
                dtpWithdrawalDate.Value = DateTime.Today;
            }
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (cbStudent.SelectedValue == null)
            {
                errorProvider1.SetError(cbStudent, "يرجى اختيار الطالب.");
                isValid = false;
            }

            if (cbAcademicYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbAcademicYear, "يرجى اختيار السنة الدراسية.");
                isValid = false;
            }

            if (cbGradeLevel.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevel, "يرجى اختيار المرحلة / الصف الدراسي.");
                isValid = false;
            }

            if (cbClass.SelectedValue == null)
            {
                errorProvider1.SetError(cbClass, "يرجى اختيار الشعبة / الفصل.");
                isValid = false;
            }

            if (!isValid) return false;

            int studentID = Convert.ToInt32(cbStudent.SelectedValue);
            int yearID = Convert.ToInt32(cbAcademicYear.SelectedValue);
            string status = SelectedStatus;

            // Business Rule (UC-003): A student cannot have another active enrollment in the same academic year
            if (status != "Withdrawn" && clsStudentEnrollment.IsStudentEnrolledInYear(studentID, yearID, _studentEnrollmentID))
            {
                errorProvider1.SetError(cbStudent, "هذا الطالب مسجل بالفعل في شعبة دراسية نشطة لنفس السنة الأكاديمية (مخالفة قاعدة UC-003).");
                clsUITheme.ShowArabicMessage(
                    "مخالفة لقاعدة التسجيل الأكاديمي:\nلا يمكن قيد الطالب في صفين/شعبتين دراسيتين بنفس السنة الدراسية.\nيرجى تعديل القيد السابق أو تسجيل انسحاب الطالب أولاً.",
                    "تكرار القيد الأكاديمي",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        public void ChangeStatus()
        {
            string status = SelectedStatus;
            DateTime? withdrawalDate = (status == "Withdrawn") ? (DateTime?)dtpWithdrawalDate.Value : null;

            if (clsStudentEnrollment.UpdateEnrollmentStatus(_studentEnrollmentID, status, withdrawalDate))
            {
                clsUITheme.ShowArabicMessage($"تم تحديث حالة القيد بنجاح إلى '{cbStatus.SelectedItem}'.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                clsUITheme.ShowArabicMessage("فشل تحديث حالة القيد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (eMode == enMode.ChangeStatus)
            {
                ChangeStatus();
                return;
            }

            if (!ValidateInputs())
                return;

            int studentID = Convert.ToInt32(cbStudent.SelectedValue);
            int yearID = Convert.ToInt32(cbAcademicYear.SelectedValue);
            int classID = Convert.ToInt32(cbClass.SelectedValue);
            int gradeLevel = Convert.ToInt32(cbGradeLevel.SelectedValue);
            DateTime enrollmentDate = dtpEnrollmentDate.Value;
            string status = SelectedStatus;
            DateTime? withdrawalDate = (status == "Withdrawn") ? (DateTime?)dtpWithdrawalDate.Value : null;

            if (_studentEnrollmentID == -1)
            {
                _enrollment = new clsStudentEnrollment();
            }

            _enrollment.StudentID = studentID;
            _enrollment.AcademicYearID = yearID;
            _enrollment.ClassID = classID;
            _enrollment.GradeLevelID = gradeLevel;
            _enrollment.EnrollmentDate = enrollmentDate;
            _enrollment.Status = status;
            _enrollment.WithdrawalDate = withdrawalDate;

            try
            {
                if (_enrollment.Save())
                {
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات قيد الطالب بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    if (_frmStudent != null)
                        _frmStudent.Show();
                    return;

                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ بيانات القيد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ أثناء حفظ القيد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadClasses(int gradeLevelID, int classID = -1)
        {
           try{
                
                DataTable dtClasses = clsClass.GetAllClasss(gradeLevelID).DefaultView.ToTable(false, "Name", "ClassID");

                cbClass.DataSource = dtClasses;
                cbClass.DisplayMember = "Name";
                cbClass.ValueMember = "ClassID";

                if (eMode == enMode.ChangeStatus)
                {
                    cbClass.SelectedValue = classID;
                    return;
                }

                if (dtClasses.Rows.Count > 0 && eMode == enMode.Update && classID != -1)
                {
                    cbClass.SelectedValue = classID;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbGradeLevel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                if (cbGradeLevel.SelectedValue != null && int.TryParse(cbGradeLevel.SelectedValue.ToString(), out int levelID))
                {
                    LoadClasses(levelID);
                }
            
            
        }
    }
}
