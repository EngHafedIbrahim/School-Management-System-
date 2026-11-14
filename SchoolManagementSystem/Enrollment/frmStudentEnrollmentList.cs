using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;

namespace SchoolManagementSystem.Enrollment
{
    public partial class frmStudentEnrollmentList : Form
    {
        private DataTable _dtEnrollments;
        private DataView _dvEnrollments;

        public frmStudentEnrollmentList()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvEnrollments);
            clsUITheme.AddHoverEffect(btnEnrollStudent);
            clsUITheme.AddHoverEffectOutline(btnEditEnrollment);
            clsUITheme.AddHoverEffectOutline(btnChangeStatus);
            clsUITheme.AddHoverEffect(btnViewProfile);
            clsUITheme.AddHoverEffectOutline(btnRefresh);
            clsUITheme.AddHoverEffectOutline(btnClose);
            clsUITheme.StyleFormControls(this);

            dgvEnrollments.CellFormatting += DgvEnrollments_CellFormatting;
            this.KeyPreview = true;
            this.KeyDown += FrmStudentEnrollmentList_KeyDown;
        }

        private void FrmStudentEnrollmentList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadYearsFilter();
                LoadClassesFilter();
                cbFilterStatus.SelectedIndex = 0; // الكل
                LoadEnrollments();
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadYearsFilter()
        {
            try
            {
                DataTable dt = clsAcademicYear.GetAllAcademicYears();
               // DataTable dtFilter = dt.Clone();

                DataTable dtFilter = dt.DefaultView.ToTable(false, "AcademicYearID", "YearName");

                // 2. إنشاء صف "جميع السنوات" وإضافته في الصدارة
                DataRow allRow = dtFilter.NewRow();
                allRow["AcademicYearID"] = -1;
                allRow["YearName"] = "جميع السنوات";
                dtFilter.Rows.InsertAt(allRow, 0);

                // 3. ربط الجدول الجديد بالـ ComboBox
                cbFilterYear.DataSource = dtFilter;
                cbFilterYear.DisplayMember = "YearName";
                cbFilterYear.ValueMember = "AcademicYearID";
                cbFilterYear.SelectedIndex = 0;


                

            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClassesFilter()
        {
            try
            {
                DataTable dtClasses = clsClass.GetAllClasss();
                DataTable dtFilter = dtClasses.DefaultView.ToTable(false, "ClassID", "Name");

                DataRow allRow = dtFilter.NewRow();
                allRow["ClassID"] = -1;
                allRow["Name"] = "جميع الشعب";

                

                dtFilter.Rows.InsertAt(allRow, 0);
                

                cbFilterClass.DataSource = dtFilter;
                cbFilterClass.DisplayMember = "Name";
                cbFilterClass.ValueMember = "ClassID";
                cbFilterClass.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEnrollments()
        {
            _dtEnrollments = clsStudentEnrollment.GetAllEnrollmentsDetailed();
            _dvEnrollments = _dtEnrollments.DefaultView;
            dgvEnrollments.DataSource = _dvEnrollments;

            if (dgvEnrollments.Columns.Contains("StudentEnrollmentID"))
            {
                dgvEnrollments.Columns["StudentEnrollmentID"].HeaderText = "رقم القيد";
                dgvEnrollments.Columns["StudentEnrollmentID"].Width = 90;
            }
            if (dgvEnrollments.Columns.Contains("AdmissionNo"))
            {
                dgvEnrollments.Columns["AdmissionNo"].HeaderText = "رقم القبول";
                dgvEnrollments.Columns["AdmissionNo"].Width = 120;
            }
            if (dgvEnrollments.Columns.Contains("StudentName"))
            {
                dgvEnrollments.Columns["StudentName"].HeaderText = "اسم الطالب";
                dgvEnrollments.Columns["StudentName"].Width = 180;
            }
            if (dgvEnrollments.Columns.Contains("AcademicYear"))
            {
                dgvEnrollments.Columns["AcademicYear"].HeaderText = "السنة الدراسية";
                dgvEnrollments.Columns["AcademicYear"].Width = 130;
            }
            if (dgvEnrollments.Columns.Contains("LevelName"))
            {
                dgvEnrollments.Columns["LevelName"].HeaderText = "الصف";
                dgvEnrollments.Columns["LevelName"].Width = 130;
            }
            if (dgvEnrollments.Columns.Contains("ClassName"))
            {
                dgvEnrollments.Columns["ClassName"].HeaderText = "الشعبة";
                dgvEnrollments.Columns["ClassName"].Width = 130;
            }
            if (dgvEnrollments.Columns.Contains("EnrollmentDate"))
            {
                dgvEnrollments.Columns["EnrollmentDate"].HeaderText = "تاريخ التسجيل";
                dgvEnrollments.Columns["EnrollmentDate"].Width = 110;
            }
            if (dgvEnrollments.Columns.Contains("WithdrawalDate"))
            {
                dgvEnrollments.Columns["WithdrawalDate"].HeaderText = "تاريخ الانسحاب";
                dgvEnrollments.Columns["WithdrawalDate"].Width = 140;
            }
            if (dgvEnrollments.Columns.Contains("Status"))
            {
                dgvEnrollments.Columns["Status"].HeaderText = "الحالة";
                dgvEnrollments.Columns["Status"].Width = 100;
            }

            // Hide raw ID columns
            if (dgvEnrollments.Columns.Contains("StudentID"))
                dgvEnrollments.Columns["StudentID"].Visible = false;
            if (dgvEnrollments.Columns.Contains("AcademicYearID"))
                dgvEnrollments.Columns["AcademicYearID"].Visible = false;
            if (dgvEnrollments.Columns.Contains("ClassID"))
                dgvEnrollments.Columns["ClassID"].Visible = false;

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_dvEnrollments == null) return;

            string filter = "";
            string search = txtSearch.Text.Trim().Replace("'", "''");
            int yearID = cbFilterYear.SelectedValue is int yVal ? yVal : -1;
            int classID = cbFilterClass.SelectedValue is int cVal ? cVal : -1;

            string status = cbFilterStatus.SelectedIndex switch
            {
                1 => "Active",
                2 => "Transferred",
                3 => "Graduated",
                4 => "Withdrawn",
                _ => "All"
            };

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(StudentName LIKE '%{search}%' OR AdmissionNo LIKE '%{search}%')";
            }

            if (yearID > 0)
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"AcademicYearID = {yearID}";
            }

            if (classID > 0)
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"ClassID = {classID}";
            }

            if (status != "All")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Status = '{status}'";
            }

            _dvEnrollments.RowFilter = filter;
            lblTotalCount.Text = $"إجمالي القيود: {_dvEnrollments.Count}";
            clsUITheme.ShowEmptyState(dgvEnrollments, "لا توجد قيودات أكاديمية مطابقة للبحث.\nاضغط 'تسجيل قيد طالب' لقيد طالب في صف دراسي.");
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            if (cbFilterYear.Items.Count > 0) cbFilterYear.SelectedIndex = 0;
            if (cbFilterClass.Items.Count > 0) cbFilterClass.SelectedIndex = 0;
            cbFilterStatus.SelectedIndex = 0;
            LoadEnrollments();
        }

        private void BtnEnrollStudent_Click(object sender, EventArgs e)
        {
            frmEnrollStudent frm = new frmEnrollStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadEnrollments();
            }
        }

        private void BtnEditEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سجل قيد للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int enrollmentID = Convert.ToInt32(dgvEnrollments.CurrentRow.Cells["StudentEnrollmentID"].Value);
            frmEnrollStudent frm = new frmEnrollStudent(enrollmentID, frmEnrollStudent.enMode.Update);
            frm.ShowDialog();
            LoadEnrollments();
        }

        private void DgvEnrollments_DoubleClick(object sender, EventArgs e)
        {
            BtnEditEnrollment_Click(sender, e);
        }

        private void BtnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سجل قيد لتغيير حالته أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int enrollmentID = Convert.ToInt32(dgvEnrollments.CurrentRow.Cells["StudentEnrollmentID"].Value);
            frmEnrollStudent en = new frmEnrollStudent(enrollmentID, frmEnrollStudent.enMode.ChangeStatus);
            en.ShowDialog();
            LoadEnrollments();
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد سجل قيد لعرض الملف الشخصي للطالب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentID = Convert.ToInt32(dgvEnrollments.CurrentRow.Cells["StudentID"].Value);
            frmStudentProfile frm = new frmStudentProfile(studentID);
            frm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvEnrollments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEnrollments.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                string displayText = status;
                Color bgColor = Color.White;
                Color fgColor = Color.Black;

                switch (status)
                {
                    case "Active":
                        displayText = "نشط";
                        bgColor = Color.FromArgb(209, 250, 229);
                        fgColor = Color.FromArgb(6, 95, 70);
                        break;
                    case "Withdrawn":
                        displayText = "منسحب";
                        bgColor = Color.FromArgb(254, 226, 226);
                        fgColor = Color.FromArgb(153, 27, 27);
                        break;
                    case "Graduated":
                        displayText = "متخرج";
                        bgColor = Color.FromArgb(219, 234, 254);
                        fgColor = Color.FromArgb(30, 64, 175);
                        break;
                    case "Transferred":
                        displayText = "منقول";
                        bgColor = Color.FromArgb(254, 243, 199);
                        fgColor = Color.FromArgb(146, 64, 14);
                        break;
                }

                e.Value = displayText;
                e.CellStyle.BackColor = bgColor;
                e.CellStyle.ForeColor = fgColor;
                e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.FormattingApplied = true;
            }
        }

        private void FrmStudentEnrollmentList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    BtnRefresh_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    BtnEditEnrollment_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.N:
                    if (e.Control)
                    {
                        BtnEnrollStudent_Click(sender, e);
                        e.Handled = true;
                    }
                    break;
                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
    }
}
