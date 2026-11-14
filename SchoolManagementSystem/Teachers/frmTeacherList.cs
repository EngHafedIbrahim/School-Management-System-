using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Teachers
{
    public partial class frmTeacherList : Form
    {
        private DataTable _dtTeachers;
        private DataView _dvTeachers;

        public frmTeacherList()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvTeachers);
            clsUITheme.StyleSuccessButton(btnAddTeacher);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            cbFilterGender.SelectedIndex = 0;
            cbFilterStatus.SelectedIndex = 0;
        }

        private void LoadTeachers()
        {
            _dtTeachers = clsTeacher.GetTeachersDetailed();
            _dvTeachers = _dtTeachers.DefaultView;
            dgvTeachers.DataSource = _dvTeachers;

            if (dgvTeachers.Rows.Count > 0)
            {
                if (dgvTeachers.Columns.Contains("TeacherID"))
                {
                    dgvTeachers.Columns["TeacherID"].HeaderText = "الرقم";
                    dgvTeachers.Columns["TeacherID"].Width = 70;
                }
                if (dgvTeachers.Columns.Contains("FullName"))
                {
                    dgvTeachers.Columns["FullName"].HeaderText = "اسم المعلم";
                    dgvTeachers.Columns["FullName"].Width = 180;
                }
                if (dgvTeachers.Columns.Contains("PhoneNumber"))
                {
                    dgvTeachers.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                    dgvTeachers.Columns["PhoneNumber"].Width = 120;
                }
                if (dgvTeachers.Columns.Contains("Email"))
                {
                    dgvTeachers.Columns["Email"].HeaderText = "البريد الإلكتروني";
                    dgvTeachers.Columns["Email"].Width = 180;
                }
                if (dgvTeachers.Columns.Contains("Specialization"))
                {
                    dgvTeachers.Columns["Specialization"].HeaderText = "المادة / التخصص";
                    dgvTeachers.Columns["Specialization"].Width = 140;
                }
                if (dgvTeachers.Columns.Contains("Qualification"))
                {
                    dgvTeachers.Columns["Qualification"].HeaderText = "المؤهل العلمي";
                    dgvTeachers.Columns["Qualification"].Width = 130;
                }
                if (dgvTeachers.Columns.Contains("HireDate"))
                {
                    dgvTeachers.Columns["HireDate"].HeaderText = "تاريخ التعيين";
                    dgvTeachers.Columns["HireDate"].Width = 100;
                    dgvTeachers.Columns["HireDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                if (dgvTeachers.Columns.Contains("EmploymentStatus"))
                {
                    dgvTeachers.Columns["EmploymentStatus"].HeaderText = "الحالة الوظيفية";
                    dgvTeachers.Columns["EmploymentStatus"].Width = 100;
                }
                if (dgvTeachers.Columns.Contains("Gender"))
                {
                    dgvTeachers.Columns["Gender"].HeaderText = "الجنس";
                    dgvTeachers.Columns["Gender"].Width = 80;
                }
            }

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvTeachers == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string filter = "";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(FullName LIKE '%{search}%' OR Email LIKE '%{search}%' OR Specialization LIKE '%{search}%' OR PhoneNumber LIKE '%{search}%')";
            }

            if (cbFilterGender.SelectedIndex == 1) // ذكر
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += "(Gender = 'Male' OR Gender = 'ذكر')";
            }
            else if (cbFilterGender.SelectedIndex == 2) // أنثى
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += "(Gender = 'Female' OR Gender = 'Femal' OR Gender = 'أنثى')";
            }

            if (cbFilterStatus.SelectedIndex == 1) // نشط
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += "(EmploymentStatus = 'Active' OR EmploymentStatus = 'نشط')";
            }
            else if (cbFilterStatus.SelectedIndex == 2) // في إجازة
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += "(EmploymentStatus = 'On Leave' OR EmploymentStatus = 'في إجازة')";
            }
            else if (cbFilterStatus.SelectedIndex == 3) // مستقيل
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += "(EmploymentStatus = 'Resigned' OR EmploymentStatus = 'مستقيل')";
            }

            _dvTeachers.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي المعلمين: {_dvTeachers?.Count ?? 0}";
        }

        private int GetSelectedTeacherID()
        {
            if (dgvTeachers.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvTeachers.CurrentRow.Cells["TeacherID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cbFilterGender.SelectedIndex = 0;
            cbFilterStatus.SelectedIndex = 0;
            LoadTeachers();
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frm = new frmAddEditTeacher();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeachers();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد معلم للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditTeacher frm = new frmAddEditTeacher(teacherID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeachers();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد معلم لعرض ملفه أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmTeacherProfile frm = new frmTeacherProfile(teacherID);
            frm.ShowDialog();
            LoadTeachers();
        }

        private void DgvTeachers_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int teacherID = GetSelectedTeacherID();
            if (teacherID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد معلم للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string teacherName = dgvTeachers.CurrentRow.Cells["FullName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في حذف المعلم '{teacherName}' (رقم: {teacherID})؟\nسيتم التحقق من عدم وجود جداول أو مقررات مسندة إليه.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsTeacher.DeleteTeacher(teacherID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف بيانات المعلم بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeachers();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("تعذر حذف المعلم لوجود جداول حصص أو إسنادات مقررات دراسية أو حساب مستخدم مرتبط به.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف المعلم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmTeacherList_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }
    }
}
