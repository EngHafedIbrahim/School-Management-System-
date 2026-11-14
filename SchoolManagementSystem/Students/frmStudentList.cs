using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Enrollment;

namespace SchoolManagementSystem.Students
{
    public partial class frmStudentList : Form
    {
        private DataTable _dtStudents;
        private DataView _dvStudents;
        private bool _showingUnEnrolled = false;

        public frmStudentList()
        {
            InitializeComponent();
            clsUITheme.StyleDataGridView(dgvStudents);
            clsUITheme.AddHeaderBottomLine(pnlHeader);

            clsUITheme.AddHoverEffect(btnAddStudent);
            clsUITheme.AddHoverEffect(btnViewProfile);
            clsUITheme.AddHoverEffect(btnDelete);
            clsUITheme.AddHoverEffectOutline(btnEdit);
            clsUITheme.AddHoverEffectOutline(btnRefresh);
            clsUITheme.AddHoverEffectOutline(btnShowUnEnrolled);

            clsUITheme.StyleTextBox(txtSearch);

            cbFilterGender.SelectedIndex = 0;

            this.KeyPreview = true;
            this.KeyDown += FrmStudentList_KeyDown;
            this.Resize += (s, e) => { if (_dtStudents != null) UpdateStatCards(); };
        }

        private void LoadStudentsList()
        {
            _dtStudents = clsStudent.GetAllStudents();
            _dvStudents = _dtStudents.DefaultView;
            dgvStudents.DataSource = _dvStudents;

            if (dgvStudents.Rows.Count > 0)
            {
                if (dgvStudents.Columns.Contains("StudentID"))
                {
                    dgvStudents.Columns["StudentID"].HeaderText = "رقم الطالب";
                    dgvStudents.Columns["StudentID"].Width = 110;
                }
                if (dgvStudents.Columns.Contains("FullName"))
                {
                    dgvStudents.Columns["FullName"].HeaderText = "الاسم الكامل";
                    dgvStudents.Columns["FullName"].Width = 210;
                }
                if (dgvStudents.Columns.Contains("NationalID"))
                {
                    dgvStudents.Columns["NationalID"].HeaderText = "الرقم الوطني";
                    dgvStudents.Columns["NationalID"].Width = 130;
                }
                if (dgvStudents.Columns.Contains("DateOfBirth"))
                {
                    dgvStudents.Columns["DateOfBirth"].HeaderText = "تاريخ الميلاد";
                    dgvStudents.Columns["DateOfBirth"].Width = 120;
                    dgvStudents.Columns["DateOfBirth"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                if (dgvStudents.Columns.Contains("GenderID"))
                {
                    dgvStudents.Columns["GenderID"].HeaderText = "الجنس";
                    dgvStudents.Columns["GenderID"].Width = 80;
                }
                if (dgvStudents.Columns.Contains("Gender"))
                {
                    dgvStudents.Columns["Gender"].HeaderText = "الجنس";
                    dgvStudents.Columns["Gender"].Width = 80;
                }
                if (dgvStudents.Columns.Contains("Nationality"))
                {
                    dgvStudents.Columns["Nationality"].HeaderText = "الجنسية";
                    dgvStudents.Columns["Nationality"].Width = 120;
                }
                if (dgvStudents.Columns.Contains("BloodType"))
                {
                    dgvStudents.Columns["BloodType"].HeaderText = "فصيلة الدم";
                    dgvStudents.Columns["BloodType"].Width = 110;
                }
                if (dgvStudents.Columns.Contains("Address"))
                {
                    dgvStudents.Columns["Address"].HeaderText = "العنوان";
                    dgvStudents.Columns["Address"].Width = 180;
                }
                if (dgvStudents.Columns.Contains("PhoneNumber"))
                {
                    dgvStudents.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                    dgvStudents.Columns["PhoneNumber"].Width = 130;
                }
                if (dgvStudents.Columns.Contains("Email"))
                {
                    dgvStudents.Columns["Email"].HeaderText = "البريد الإلكتروني";
                    dgvStudents.Columns["Email"].Width = 180;
                }
                if (dgvStudents.Columns.Contains("AdmissionNo"))
                {
                    dgvStudents.Columns["AdmissionNo"].HeaderText = "رقم القبول";
                    dgvStudents.Columns["AdmissionNo"].Width = 130;
                }
                if (dgvStudents.Columns.Contains("AdmissionDate"))
                {
                    dgvStudents.Columns["AdmissionDate"].HeaderText = "تاريخ القبول";
                    dgvStudents.Columns["AdmissionDate"].Width = 130;
                    dgvStudents.Columns["AdmissionDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                if (dgvStudents.Columns.Contains("PreviousSchool"))
                {
                    dgvStudents.Columns["PreviousSchool"].HeaderText = "المدرسة السابقة";
                    dgvStudents.Columns["PreviousSchool"].Width = 160;
                }
                if (dgvStudents.Columns.Contains("HealthStatus"))
                {
                    dgvStudents.Columns["HealthStatus"].HeaderText = "الحالة الصحية";
                    dgvStudents.Columns["HealthStatus"].Width = 140;
                }
                if (dgvStudents.Columns.Contains("ProfileImageURL"))
                {
                    dgvStudents.Columns["ProfileImageURL"].HeaderText = "رابط الصورة";
                    dgvStudents.Columns["ProfileImageURL"].Visible = false;
                }
                if (dgvStudents.Columns.Contains("CreatedBy"))
                {
                    dgvStudents.Columns["CreatedBy"].HeaderText = "أنشئ بواسطة";
                    dgvStudents.Columns["CreatedBy"].Width = 100;
                }
                if (dgvStudents.Columns.Contains("CreatedAt"))
                {
                    dgvStudents.Columns["CreatedAt"].HeaderText = "تاريخ الإضافة";
                    dgvStudents.Columns["CreatedAt"].Width = 130;
                }
            }

            UpdateCount();
            UpdateStatCards();
        }

        private void ApplyFilter()
        {
            if (_dvStudents == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string gender = cbFilterGender.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(FullName LIKE '%{search}%' OR AdmissionNo LIKE '%{search}%' OR NationalID LIKE '%{search}%')";
            }

            if (!string.IsNullOrEmpty(gender) && gender != "الكل" && gender != "All")
            {
                string genderVal = gender == "ذكر" ? "Male" : (gender == "أنثى" ? "Female" : gender);
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"(Gender = '{genderVal}' OR Gender = '{gender}')";
            }

            _dvStudents.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي الطلاب المعروضين: {_dvStudents?.Count ?? 0}";
            clsUITheme.ShowEmptyState(dgvStudents, "لا يوجد طلاب مسجلون بعد.\nاضغط 'تسجيل طالب جديد' للبدء.");
        }

        private int GetSelectedStudentID()
        {
            if (dgvStudents.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbFilterGender.SelectedIndex = 0;
            LoadStudentsList();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frm = new frmRegisterStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentsList();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmStudentProfile frm = new frmStudentProfile(studentID);
            frm.ShowDialog();
            LoadStudentsList();
        }

        private void DgvStudents_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب من القائمة لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmRegisterStudent frm = new frmRegisterStudent(studentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentsList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب من القائمة للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string studentName = dgvStudents.CurrentRow.Cells["FullName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من رغبتك في حذف الطالب '{studentName}' (رقم المعرف: {studentID})?\nسيقوم النظام بالتحقق من عدم وجود أي سجلات مرتبطة به (تسجيل، فواتير، درجات).", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsStudent.DeleteStudent(studentID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف سجل الطالب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentsList();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("لا يمكن حذف الطالب لوجود سجلات أكاديمية أو مالية مرتبطة به (تسجيل، فواتير، درجات أو أولياء أمور).", "قيد النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف الطالب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            LoadStudentsList();
        }

        private void UpdateStatCards()
        {
            if (pnlStats == null) return;
            pnlStats.Controls.Clear();

            int total = _dtStudents?.Rows.Count ?? 0;
            int males = 0, females = 0;

            if (_dtStudents != null && _dtStudents.Columns.Contains("Gender"))
            {
                foreach (DataRow row in _dtStudents.Rows)
                {
                    string g = row["Gender"]?.ToString() ?? "";
                    if (g == "Male" || g == "ذكر") males++;
                    else if (g == "Female" || g == "أنثى") females++;
                }
            }

            var cardTotal = clsUITheme.CreateStatCard("إجمالي الطلاب", total.ToString(), clsUITheme.PrimaryColor);
            var cardMale = clsUITheme.CreateStatCard("ذكور", males.ToString(), clsUITheme.AccentColor);
            var cardFemale = clsUITheme.CreateStatCard("إناث", females.ToString(), Color.FromArgb(124, 58, 120));
            var cardUnEnrolled = clsUITheme.CreateStatCard("غير مقيدين", "...", clsUITheme.WarningColor);

            try
            {
                int unEnrolled = clsStudent.GetUnEnrolledStudents().Rows.Count;
                cardUnEnrolled.Controls[0].Text = unEnrolled.ToString();
            }
            catch { cardUnEnrolled.Controls[0].Text = "–"; }

            int xPos = pnlStats.Width - 220;
            foreach (var card in new[] { cardTotal, cardMale, cardFemale, cardUnEnrolled })
            {
                card.Location = new Point(xPos, 8);
                pnlStats.Controls.Add(card);
                xPos -= 216;
            }
        }

        private void BtnShowUnEnrolled_Click(object sender, EventArgs e)
        {
            _showingUnEnrolled = !_showingUnEnrolled;

            if (_showingUnEnrolled)
            {
                _dtStudents = clsStudent.GetUnEnrolledStudents();
                _dvStudents = _dtStudents.DefaultView;
                dgvStudents.DataSource = _dvStudents;
                btnShowUnEnrolled.Text = "عرض الكل";
                btnShowUnEnrolled.ForeColor = clsUITheme.SuccessColor;
                lblHeaderTitle.Text = "الطلاب غير المقيدين في السنة الحالية";
            }
            else
            {
                LoadStudentsList();
                btnShowUnEnrolled.Text = "غير المقيدين";
                btnShowUnEnrolled.ForeColor = clsUITheme.DangerColor;
                lblHeaderTitle.Text = "سجل وبيانات الطلاب";
            }

            UpdateCount();
            UpdateStatCards();
        }

        private void CmsEnrollStudent_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmEnrollStudent frm = new frmEnrollStudent();
            frm.PreSelectStudent(studentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentsList();
            }
        }

        private void FrmStudentList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    BtnRefresh_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Delete:
                    BtnDelete_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    BtnViewProfile_Click(sender, e);
                    e.Handled = true;
                    break;
                case Keys.N:
                    if (e.Control)
                    {
                        BtnAddStudent_Click(sender, e);
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
