using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Courses
{
    public partial class frmCourseList : Form
    {
        private DataTable _dtCourses;
        private DataView _dvCourses;

        public frmCourseList()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvCourses);
            clsUITheme.StyleSuccessButton(btnAddCourse);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
        }

        private void LoadCourses()
        {
            _dtCourses = clsCourse.GetAllCourses();
            _dvCourses = _dtCourses.DefaultView;
            dgvCourses.DataSource = _dvCourses;

            if (dgvCourses.Rows.Count > 0)
            {
                if (dgvCourses.Columns.Contains("CourseID"))
                {
                    dgvCourses.Columns["CourseID"].HeaderText = "الرقم";
                    dgvCourses.Columns["CourseID"].Width = 90;
                }
                if (dgvCourses.Columns.Contains("Name"))
                {
                    dgvCourses.Columns["Name"].HeaderText = "اسم المادة";
                    dgvCourses.Columns["Name"].Width = 240;
                }
                if (dgvCourses.Columns.Contains("CreditHours"))
                {
                    dgvCourses.Columns["CreditHours"].HeaderText = "الساعات الأسبوعية";
                    dgvCourses.Columns["CreditHours"].Width = 150;
                }
                if (dgvCourses.Columns.Contains("Description"))
                {
                    dgvCourses.Columns["Description"].HeaderText = "الوصف والملاحظات";
                    dgvCourses.Columns["Description"].Width = 300;
                }
            }

            if (dgvCourses.Columns.Contains("CreatedBy")) dgvCourses.Columns["CreatedBy"].Visible = false;
            if (dgvCourses.Columns.Contains("UpdatedBy")) dgvCourses.Columns["UpdatedBy"].Visible = false;
            if (dgvCourses.Columns.Contains("CreatedAt")) dgvCourses.Columns["CreatedAt"].Visible = false;
            if (dgvCourses.Columns.Contains("UpdatedAt")) dgvCourses.Columns["UpdatedAt"].Visible = false;
            if (dgvCourses.Columns.Contains("IsDeleted")) dgvCourses.Columns["IsDeleted"].Visible = false;

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (dgvCourses.DataSource == null) return;

            try
            {
                string search = txtSearch.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(search))
                {
                    _dvCourses.RowFilter = "";
                }
                else
                {
                    _dvCourses.RowFilter = $"Name LIKE '%{search}%' OR Description LIKE '%{search}%'";
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي المواد والمقررات: {_dvCourses?.Count ?? 0}";
        }

        private int GetSelectedCourseID()
        {
            if (dgvCourses.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvCourses.CurrentRow.Cells["CourseID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadCourses();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddEditCourse frm = new frmAddEditCourse();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int courseID = GetSelectedCourseID();
            if (courseID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد مادة دراسية للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditCourse frm = new frmAddEditCourse(courseID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void DgvCourses_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int courseID = GetSelectedCourseID();
            if (courseID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد مادة دراسية للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string courseName = dgvCourses.CurrentRow.Cells["Name"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في حذف المادة الدراسية '{courseName}' (رقم: {courseID})؟\nسيتم التحقق من عدم وجود جداول أو درجات مرتبطة بها.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsCourse.DeleteCourse(courseID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف المادة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("تعذر حذف المادة الدراسية لوجود إسنادات فصول أو جداول أو درجات مسجلة مرتبطة بها.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف المادة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCourseList_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

    }
}
