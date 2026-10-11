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
            clsUITheme.StyleDataGridView(dgvClasses);
            clsUITheme.StyleSuccessButton(btnAddClass);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            Text = "قائمة ادارة الشُعب الدراسية";
            btnEdit.Text = "تعديل";
            btnViewProfile.Text = "عرض";
            btnDelete.Text = "حذف";
            btnAddClass.Text = "+إضافة شُعبة";


        }

        private void LoadGradeLevelsFilter()
        {
            DataTable dtGrades = clsGradeLevel.GetAllGradeLevels();
            cbFilterGrade.Items.Clear();
            cbFilterGrade.Items.Add("All");

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
                dgvClasses.Columns["ClassID"].HeaderText = "ID";
                dgvClasses.Columns["ClassID"].Width = 80;
            }
            if (dgvClasses.Columns.Contains("ClassName"))
            {
                dgvClasses.Columns["ClassName"].HeaderText = "اسم الشعبة";
                dgvClasses.Columns["ClassName"].Width = 180;
            }
            if (dgvClasses.Columns.Contains("GradeLevelName"))
            {
                dgvClasses.Columns["GradeLevelName"].HeaderText = "المستوى الدراسي";
                dgvClasses.Columns["GradeLevelName"].Width = 180;
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
                dgvClasses.Columns["Details"].HeaderText = "ملاحظة";
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

            if (!string.IsNullOrEmpty(selectedGrade) && selectedGrade != "All")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"GradeLevelName = '{selectedGrade.Replace("'", "''")}'";
            }

            _dvClasses.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Displayed Classes: {_dvClasses?.Count ?? 0}";
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
                MessageBox.Show("Please select a class to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a class from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a class to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string className = dgvClasses.CurrentRow.Cells["ClassName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete class '{className}' (ID: {classID})?\nThis action verifies that no enrolled students or course assignments depend on it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsClass.DeleteClass(classID))
                    {
                        MessageBox.Show("Class deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete class. Enrolled students or active course schedules are assigned to this class.", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting class: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
