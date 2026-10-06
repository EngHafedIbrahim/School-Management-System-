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

           // LoadParentsList();
        }

        private void LoadParentsList()
        {
            _dtParents = clsParent.GetAllParentsWithChildrenCount();
            _dvParents = _dtParents.DefaultView;

            dgvParents.DataSource = _dvParents;

            if (dgvParents.ColumnCount > 0)
            {
                // ParentID
                dgvParents.Columns[0].HeaderText = "ParentID";
                dgvParents.Columns[0].Width = 120;

                // FirstName
                dgvParents.Columns[1].HeaderText = "Full Name";
                dgvParents.Columns[1].Width = 150;

                // PhoneNumber
                dgvParents.Columns[2].HeaderText = "PhoneNumber";
                dgvParents.Columns[2].Width = 150;

                // Email
                dgvParents.Columns[3].HeaderText = "Email";
                dgvParents.Columns[3].Width = 220;

                // Address
                dgvParents.Columns[4].HeaderText = "Address";
                dgvParents.Columns[4].Width = 250;

                // RelationshipType
                dgvParents.Columns[5].HeaderText = "StudentsCount";
                dgvParents.Columns[5].Width = 160;

                //// CreatedAt
                //dgvParents.Columns[6].HeaderText = "CreatedAt";
                //dgvParents.Columns[6].Width = 140;


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
            lblTotalCount.Text = $"Total Displayed Parents: {_dvParents?.Count ?? 0}";
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
                MessageBox.Show("Please select a parent from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a parent to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a parent to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string parentName = dgvParents.CurrentRow.Cells["FullName"].Value.ToString();
            int childrenCount = Convert.ToInt32(dgvParents.CurrentRow.Cells["NumberOfChildren"].Value);

            if (childrenCount > 0)
            {
                MessageBox.Show($"Cannot delete parent '{parentName}' because they have {childrenCount} linked student(s).\nPlease unlink all students first.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete parent '{parentName}' (ID: {parentID})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsParent.DeleteParent(parentID))
                    {
                        MessageBox.Show("Parent deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParentsList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete parent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting parent: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmParentList_Load(object sender, EventArgs e)
        {
            LoadParentsList();
        }
    }
}
