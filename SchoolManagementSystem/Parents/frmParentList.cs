using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Parents
{
    public partial class frmParentList : Form
    {
        private DataTable _dtParents;
        private DataView _dvParents;

        public frmParentList()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvParents);
            clsUITheme.StyleSuccessButton(btnAddParent);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
        }

        private void LoadParentsList()
        {
            _dtParents = clsParent.GetAllParentsWithChildrenCount();
            _dvParents = _dtParents.DefaultView;

            dgvParents.DataSource = _dvParents;

            if (dgvParents.ColumnCount > 0)
            {
                if (dgvParents.Columns.Contains("ParentID"))
                {
                    dgvParents.Columns["ParentID"].HeaderText = "رقم المعرف";
                    dgvParents.Columns["ParentID"].Width = 100;
                }
                if (dgvParents.Columns.Contains("FullName"))
                {
                    dgvParents.Columns["FullName"].HeaderText = "الاسم الكامل";
                    dgvParents.Columns["FullName"].Width = 200;
                }
                if (dgvParents.Columns.Contains("PhoneNumber"))
                {
                    dgvParents.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                    dgvParents.Columns["PhoneNumber"].Width = 150;
                }
                if (dgvParents.Columns.Contains("Email"))
                {
                    dgvParents.Columns["Email"].HeaderText = "البريد الإلكتروني";
                    dgvParents.Columns["Email"].Width = 220;
                }
                if (dgvParents.Columns.Contains("Address"))
                {
                    dgvParents.Columns["Address"].HeaderText = "العنوان";
                    dgvParents.Columns["Address"].Width = 220;
                }
                if (dgvParents.Columns.Contains("NumberOfChildren"))
                {
                    dgvParents.Columns["NumberOfChildren"].HeaderText = "عدد الأبناء المسجلين";
                    dgvParents.Columns["NumberOfChildren"].Width = 160;
                }
            }

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvParents == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(search))
            {
                _dvParents.RowFilter = "";
            }
            else
            {
                _dvParents.RowFilter = $"(FullName LIKE '%{search}%' OR PhoneNumber LIKE '%{search}%' OR Email LIKE '%{search}%')";
            }

            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي أولياء الأمور المعروضين: {_dvParents?.Count ?? 0}";
        }

        private int GetSelectedParentID()
        {
            if (dgvParents.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvParents.CurrentRow.Cells["ParentID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadParentsList();
        }

        private void BtnAddParent_Click(object sender, EventArgs e)
        {
            frmRegisterParent frm = new frmRegisterParent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadParentsList();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int parentID = GetSelectedParentID();
            if (parentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد ولي أمر من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmParentProfile frm = new frmParentProfile(parentID);
            frm.ShowDialog();
            LoadParentsList();
        }

        private void DgvParents_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int parentID = GetSelectedParentID();
            if (parentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد ولي أمر من القائمة لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmRegisterParent frm = new frmRegisterParent(parentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadParentsList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int parentID = GetSelectedParentID();
            if (parentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد ولي أمر من القائمة للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string parentName = dgvParents.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";
            int childrenCount = 0;
            if (dgvParents.Columns.Contains("NumberOfChildren"))
            {
                childrenCount = Convert.ToInt32(dgvParents.CurrentRow.Cells["NumberOfChildren"].Value);
            }

            if (childrenCount > 0)
            {
                clsUITheme.ShowArabicMessage($"لا يمكن حذف ولي الأمر '{parentName}' لأن لديه ({childrenCount}) طالب/طلاب مرتبطين به.\nيرجى فك ارتباط الأبناء أولاً.", "إجراء غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من رغبتك في حذف ولي الأمر '{parentName}' (رقم المعرف: {parentID})؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsParent.DeleteParent(parentID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف سجل ولي الأمر بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParentsList();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("فشل حذف ولي الأمر لوجود سجلات مرتبطة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف ولي الأمر: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmParentList_Load(object sender, EventArgs e)
        {
            LoadParentsList();
        }
    }
}
