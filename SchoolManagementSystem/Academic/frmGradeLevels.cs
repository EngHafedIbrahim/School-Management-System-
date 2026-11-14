using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmGradeLevels : Form
    {
        private DataTable _dtGradeLevels;
        private DataView _dvGradeLevels;
        private int _EditingGradeLevelID = -1;

        public frmGradeLevels()
        {
            InitializeComponent();

            clsUITheme.ApplyRTL(this);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            clsUITheme.StyleDataGridView(dgvGradeLevels);
        }

        private void LoadGradeLevels()
        {
            try
            {
                _dtGradeLevels = clsGradeLevel.GetAllGradeLevels();
                _dvGradeLevels = _dtGradeLevels.DefaultView;
                _dvGradeLevels.Sort = "OrderNo ASC";
                dgvGradeLevels.DataSource = _dvGradeLevels;

                if (dgvGradeLevels.Columns.Contains("GradeLevelID"))
                {
                    dgvGradeLevels.Columns["GradeLevelID"].HeaderText = "الرقم";
                    dgvGradeLevels.Columns["GradeLevelID"].Width = 150;
                }
                if (dgvGradeLevels.Columns.Contains("Name"))
                {
                    dgvGradeLevels.Columns["Name"].HeaderText = "اسم المرحلة / الصف الدراسي";
                    dgvGradeLevels.Columns["Name"].Width = 300;
                }
                if (dgvGradeLevels.Columns.Contains("OrderNo"))
                {
                    dgvGradeLevels.Columns["OrderNo"].HeaderText = "ترتيب العرض";
                    dgvGradeLevels.Columns["OrderNo"].Width = 150;
                }
                if (dgvGradeLevels.Columns.Contains("Description"))
                {
                    dgvGradeLevels.Columns["Description"].HeaderText = "الوصف والملاحظات";
                    dgvGradeLevels.Columns["Description"].Width = 350;
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ أثناء تحميل المراحل الدراسية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي الصفوف الدراسية: {_dvGradeLevels?.Count ?? 0}";
        }

        private void ApplyFilter()
        {
            if (_dvGradeLevels == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(search))
            {
                _dvGradeLevels.RowFilter = "";
            }
            else
            {
                _dvGradeLevels.RowFilter = $"Name LIKE '%{search}%' OR Description LIKE '%{search}%'";
            }
            UpdateCount();
        }

        private void ResetEditor()
        {
            _EditingGradeLevelID = -1;
            lblFormTitle.Text = "إضافة مرحلة / صف دراسي جديد";
            txtName.Text = "";
            numOrderNo.Value = (_dtGradeLevels != null && _dtGradeLevels.Rows.Count > 0) ? _dtGradeLevels.Rows.Count + 1 : 1;
            txtDescription.Text = "";
            btnCancelEdit.Visible = false;
            btnSave.Text = "حفظ المرحلة";
            errorProvider1.Clear();
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "اسم المرحلة أو الصف الدراسي مطلوب.");
                isValid = false;
            }

            if (numOrderNo.Value <= 0)
            {
                errorProvider1.SetError(numOrderNo, "رقم الترتيب يجب أن يكون أكبر من الصفر.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            clsGradeLevel gradeLevel;

            if (_EditingGradeLevelID == -1)
            {
                gradeLevel = new clsGradeLevel();
            }
            else
            {
                gradeLevel = clsGradeLevel.Find(_EditingGradeLevelID);
                if (gradeLevel == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على المرحلة الدراسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            gradeLevel.Name = txtName.Text.Trim();
            gradeLevel.OrderNo = (int)numOrderNo.Value;
            gradeLevel.Description = txtDescription.Text.Trim();

            try
            {
                if (gradeLevel.Save())
                {
                    clsUITheme.ShowArabicMessage("تم حفظ بيانات المرحلة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadGradeLevels();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ المرحلة الدراسية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvGradeLevels.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد مرحلة دراسية للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingGradeLevelID = GetCurrentGradeLevelID();

            clsGradeLevel gradeLevel = clsGradeLevel.Find(_EditingGradeLevelID);
            if (gradeLevel != null)
            {
                lblFormTitle.Text = $"تعديل بيانات المرحلة [رقم: {_EditingGradeLevelID}]";
                txtName.Text = gradeLevel.Name;
                numOrderNo.Value = gradeLevel.OrderNo > 0 ? gradeLevel.OrderNo : 1;
                txtDescription.Text = gradeLevel.Description;
                btnCancelEdit.Visible = true;
                btnSave.Text = "تحديث المرحلة";
            }
        }

        private int GetCurrentGradeLevelID()
        {
            return Convert.ToInt32(dgvGradeLevels.CurrentRow.Cells["GradeLevelID"].Value);
        }

        private void DgvGradeLevels_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGradeLevels.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد مرحلة دراسية للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int gradeLevelID = GetCurrentGradeLevelID();
            string name = dgvGradeLevels.CurrentRow.Cells["Name"].Value.ToString();

            if (clsUITheme.ShowArabicMessage(
                $"هل أنت متأكد من رغبتك في حذف المرحلة الدراسية '{name}' (رقم: {gradeLevelID})؟\nسيتم التحقق من عدم وجود شعب دراسية أو هياكل رسوم مرتبطة بها.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsGradeLevel.DeleteGradeLevel(gradeLevelID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف المرحلة الدراسية بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_EditingGradeLevelID == gradeLevelID)
                            ResetEditor();
                        LoadGradeLevels();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("لا يمكن حذف هذه المرحلة الدراسية لوجود شعب دراسية أو هياكل رسوم مرتبطة بها.", "قيد تكامل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف المرحلة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGradeLevels();
        }

        private void FrmGradeLevels_Load(object sender, EventArgs e)
        {
            LoadGradeLevels();
            ResetEditor();
        }
    }
}
