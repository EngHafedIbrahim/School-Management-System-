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

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvAssignments);
            clsUITheme.StylePrimaryButton(btnAssign);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnRemove);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            cbGradeLevels.SelectedIndexChanged += CbGradeLevels_SelectedIndexChanged;
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
            cbFilterYear.Items.Add("جميع السنوات");
            foreach (DataRow r in dtYears.Rows)
            {
                cbFilterYear.Items.Add(r["YearName"].ToString());
            }
            cbFilterYear.SelectedIndex = 0;

            cbFilterClass.Items.Clear();
            cbFilterClass.Items.Add("جميع المراحل");
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
                dgvAssignments.Columns["ClassCourseID"].HeaderText = "الرقم";
                dgvAssignments.Columns["ClassCourseID"].Width = 70;
            }
            if (dgvAssignments.Columns.Contains("GradeLevel"))
            {
                dgvAssignments.Columns["GradeLevel"].HeaderText = "المرحلة / الصف";
                dgvAssignments.Columns["GradeLevel"].Width = 180;
            }
            if (dgvAssignments.Columns.Contains("ClassName"))
            {
                dgvAssignments.Columns["ClassName"].HeaderText = "الشعبة / الفصل";
                dgvAssignments.Columns["ClassName"].Width = 160;
            }
            if (dgvAssignments.Columns.Contains("CourseName"))
            {
                dgvAssignments.Columns["CourseName"].HeaderText = "المادة الدراسية";
                dgvAssignments.Columns["CourseName"].Width = 200;
            }
            if (dgvAssignments.Columns.Contains("TeacherName"))
            {
                dgvAssignments.Columns["TeacherName"].HeaderText = "المعلم المكلف";
                dgvAssignments.Columns["TeacherName"].Width = 220;
            }
            if (dgvAssignments.Columns.Contains("AcademicYear"))
            {
                dgvAssignments.Columns["AcademicYear"].HeaderText = "السنة الدراسية";
                dgvAssignments.Columns["AcademicYear"].Width = 140;
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

            if (!string.IsNullOrEmpty(selectedYear) && selectedYear != "جميع السنوات")
            {
                filter = $"AcademicYear = '{selectedYear.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedClass) && selectedClass != "جميع المراحل")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"GradeLevel = '{selectedClass.Replace("'", "''")}'";
            }

            _dvAssignments.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي التكليفات والإسنادات: {_dvAssignments?.Count ?? 0}";
        }

        private void ResetEditor()
        {
            _EditingClassCourseID = -1;
            lblFormTitle.Text = "إسناد مادة دراسية لفصل جديد";
            btnCancelEdit.Visible = false;
            btnAssign.Text = "إسناد المقرر";
            errorProvider1.Clear();
        }

        private bool ValidateAssignment()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (cbGradeLevels.SelectedValue == null)
            {
                errorProvider1.SetError(cbGradeLevels, "يرجى تحديد المرحلة / الصف الدراسي أولاً.");
                isValid = false;
            }
            if (cbClass.SelectedValue == null)
            {
                errorProvider1.SetError(cbClass, "يرجى تحديد الشعبة / الفصل الدراسي.");
                isValid = false;
            }
            if (cbCourse.SelectedValue == null)
            {
                errorProvider1.SetError(cbCourse, "يرجى اختيار المادة / المقرر الدراسي.");
                isValid = false;
            }
            if (cbTeacher.SelectedValue == null)
            {
                errorProvider1.SetError(cbTeacher, "يرجى تحديد المعلم المكلف.");
                isValid = false;
            }
            if (cbYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbYear, "يرجى تحديد السنة الأكاديمية.");
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
                    clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الإسناد المطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    clsUITheme.ShowArabicMessage("تم حفظ وتوزيع إسناد المقرر بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadAssignments();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ إسناد المقرر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق من البيانات:\n" + ex.Message, "مخالفة قواعد النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                clsUITheme.ShowArabicMessage("يرجى تحديد تكليف دراسي للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingClassCourseID = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["ClassCourseID"].Value);
            clsClassCourse cc = clsClassCourse.Find(_EditingClassCourseID);
            if (cc != null)
            {
                lblFormTitle.Text = $"تعديل إسناد المادة [رقم: {_EditingClassCourseID}]";
                cbGradeLevels.SelectedValue = cc.GradeLevelID;
                LoadClassesForGrade(cc.GradeLevelID);
                cbClass.SelectedValue = cc.ClassID;
                cbCourse.SelectedValue = cc.CourseID;
                cbTeacher.SelectedValue = cc.TeacherID;
                cbYear.SelectedValue = cc.AcademicYearID;
                btnCancelEdit.Visible = true;
                btnAssign.Text = "تحديث الإسناد";
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
                clsUITheme.ShowArabicMessage("يرجى تحديد تكليف دراسي لإلغائه أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int classCourseID = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["ClassCourseID"].Value);
            string clsName = dgvAssignments.CurrentRow.Cells["ClassName"].Value.ToString();
            string crsName = dgvAssignments.CurrentRow.Cells["CourseName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في إلغاء إسناد مادة '{crsName}' لفصل '{clsName}' (رقم: {classCourseID})؟\nسيتم التحقق من عدم وجود جداول حصص أو جلسات حضور تعتمد عليه.",
                "تأكيد الإلغاء",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsClassCourse.DeleteClassCourse(classCourseID))
                    {
                        clsUITheme.ShowArabicMessage("تم إلغاء إسناد المقرر بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_EditingClassCourseID == classCourseID)
                            ResetEditor();
                        LoadAssignments();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("تعذر إلغاء الإسناد لوجود جداول حصص أسبوعية أو جلسات حضور مسجلة تعتمد على هذا التكليف.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء إلغاء الإسناد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClassesForGrade(int gradeLevelID)
        {
            DataTable dtClasses = clsClass.GetAllClasss(gradeLevelID);
            cbClass.DataSource = dtClasses;
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ClassID";
        }

        private void CbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGradeLevels.SelectedValue != null && int.TryParse(cbGradeLevels.SelectedValue.ToString(), out int levelID))
            {
                LoadClassesForGrade(levelID);
            }
        }

        private void CbGradeLevels_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbGradeLevels.SelectedValue != null && int.TryParse(cbGradeLevels.SelectedValue.ToString(), out int levelID))
            {
                LoadClassesForGrade(levelID);
            }
        }
    }
}
