using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Classes
{
    public partial class frmClassList : Form
    {
        private DataTable _dtClasses;
        private DataView _dvClasses;

        public frmClassList()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StyleDataGridView(dgvClasses);
            clsUITheme.StyleSuccessButton(btnAddClass);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
        }

        private void LoadGradeLevelsFilter()
        {
            DataTable dtGrades = clsGradeLevel.GetAllGradeLevels();
            cbFilterGrade.Items.Clear();
            cbFilterGrade.Items.Add("الكل");

            foreach (DataRow row in dtGrades.Rows)
            {
                cbFilterGrade.Items.Add(row["Name"].ToString());
            }
            cbFilterGrade.SelectedIndex = 0;
        }

        private void LoadClasses()
        {
            _dtClasses = clsClass.GetClassesDetailed();
            _dvClasses = _dtClasses.DefaultView;
            dgvClasses.DataSource = _dvClasses;

            if (dgvClasses.Columns.Contains("ClassID"))
            {
                dgvClasses.Columns["ClassID"].HeaderText = "رقم الشعبة";
                dgvClasses.Columns["ClassID"].Width = 90;
            }
            if (dgvClasses.Columns.Contains("ClassName"))
            {
                dgvClasses.Columns["ClassName"].HeaderText = "اسم الشعبة / الفصل";
                dgvClasses.Columns["ClassName"].Width = 200;
            }
            if (dgvClasses.Columns.Contains("GradeLevelName"))
            {
                dgvClasses.Columns["GradeLevelName"].HeaderText = "المستوى / الصف الدراسي";
                dgvClasses.Columns["GradeLevelName"].Width = 200;
            }
            if (dgvClasses.Columns.Contains("GradeLevelID"))
            {
                dgvClasses.Columns["GradeLevelID"].Visible = false;
            }
            if (dgvClasses.Columns.Contains("IsDeleted"))
            {
                dgvClasses.Columns["IsDeleted"].Visible = false;
            }
            if (dgvClasses.Columns.Contains("Details"))
            {
                dgvClasses.Columns["Details"].HeaderText = "ملاحظات";
                dgvClasses.Columns["Details"].Width = 220;
            }

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvClasses == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string selectedGrade = cbFilterGrade.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"ClassName LIKE '%{search}%'";
            }

            if (!string.IsNullOrEmpty(selectedGrade) && selectedGrade != "الكل")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"GradeLevelName = '{selectedGrade.Replace("'", "''")}'";
            }

            _dvClasses.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي الشُعب المعروضة: {_dvClasses?.Count ?? 0}";
        }

        private int GetSelectedClassID()
        {
            if (dgvClasses.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadGradeLevelsFilter();
            LoadClasses();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            frmAddEditClass frm = new frmAddEditClass();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadClasses();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int classID = GetSelectedClassID();
            if (classID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد شعبة دراسية للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditClass frm = new frmAddEditClass(classID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadClasses();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int classID = GetSelectedClassID();
            if (classID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد شعبة دراسية من القائمة لعرض ملفها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmClassProfile frm = new frmClassProfile(classID);
            frm.ShowDialog();
            LoadClasses();
        }

        private void DgvClasses_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int classID = GetSelectedClassID();
            if (classID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد شعبة دراسية للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string className = dgvClasses.CurrentRow.Cells["ClassName"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في حذف الشعبة الدراسية '{className}' (رقم: {classID})؟\nسيتم التحقق من عدم وجود طلاب مقيدين أو مقررات مجدولة مرتبطة بها.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsClass.DeleteClass(classID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف الشعبة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("تعذر حذف الشعبة الدراسية، نظراً لوجود طلاب مقيدين بها أو مقررات وجداول دراسية مرتبطة بها.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف الشعبة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmClassList_Load(object sender, EventArgs e)
        {
            LoadGradeLevelsFilter();
            LoadClasses();
        }
    }
}
