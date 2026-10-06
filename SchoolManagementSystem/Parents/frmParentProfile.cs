using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;

namespace SchoolManagementSystem.Parents
{
    public partial class frmParentProfile : Form
    {
        private int _ParentID;
        private clsParent _Parent;

        public frmParentProfile(int parentID)
        {
            InitializeComponent();
            _ParentID = parentID;

            clsUITheme.StyleDataGridView(dgvChildren);
            clsUITheme.StyleSecondaryButton(btnEditParent);
            clsUITheme.StylePrimaryButton(btnLinkStudent);
            clsUITheme.StyleSecondaryButton(btnViewStudent);
            clsUITheme.StyleDangerButton(btnUnlinkStudent);
            clsUITheme.StyleSecondaryButton(btnClose);

            //LoadParentData();
        }

        public void LoadParentData()
        {
            _Parent = clsParent.Find(_ParentID);
            if (_Parent == null)
            {
                MessageBox.Show("Parent record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValParentID.Text = _Parent.ParentID.ToString();
            lblValFullName.Text = $"{_Parent.FirstName} {_Parent.LastName}";
            lblValPhone.Text = _Parent.PhoneNumber;
            lblValEmail.Text = _Parent.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Parent.Address) ? "N/A" : _Parent.Address;

            RefreshChildren();
        }

        private void RefreshChildren()
        {

            dgvChildren.DataSource = clsStudentParent.GetStudentsByParentID(_ParentID);


            if (dgvChildren.Columns.Contains("StudentParentID"))
                dgvChildren.Columns["StudentParentID"].Visible = true;
            if (dgvChildren.Columns.Contains("StudentID"))
                dgvChildren.Columns["StudentID"].Width = 80;
            
            if (dgvChildren.Rows.Count > 0)
                dgvChildren.Rows[0].Selected = true;
        }

        private void BtnEditParent_Click(object sender, EventArgs e)
        {
            frmRegisterParent frm = new frmRegisterParent(_ParentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadParentData();
            }
        }

        private void BtnLinkStudent_Click(object sender, EventArgs e)
        {
            frmLinkStudentToParent frm = new frmLinkStudentToParent(_ParentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshChildren();
            }
        }

        private int GetSelectedParentID()
        {
            if (dgvChildren.CurrentRow == null) return -1;

            return Convert.ToInt32(dgvChildren.CurrentRow.Cells["StudentID"].Value);
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            int StudentID = GetSelectedParentID();
            if (StudentID == -1)
            {
                MessageBox.Show("Please select a student to view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentID = Convert.ToInt32(dgvChildren.CurrentRow.Cells["StudentID"].Value);
            frmStudentProfile frm = new frmStudentProfile(studentID);
            frm.ShowDialog();
            RefreshChildren();

        }

        private void DgvChildren_DoubleClick(object sender, EventArgs e)
        {
            BtnViewStudent_Click(sender, e);
        }

        private void BtnUnlinkStudent_Click(object sender, EventArgs e)
        {
            if (dgvChildren.CurrentRow == null)
            {
                MessageBox.Show("Please select a student link to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentParentID = Convert.ToInt32(dgvChildren.CurrentRow.Cells["StudentParentID"].Value);
            string studentName = dgvChildren.CurrentRow.Cells["StudentName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to remove the link between this parent and student '{studentName}'?", "Confirm Unlink", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsStudentParent.DeleteStudentParent(studentParentID))
                {
                    MessageBox.Show("Student link removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshChildren();
                }
                else
                {
                    MessageBox.Show("Failed to remove link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmParentProfile_Load(object sender, EventArgs e)
        {
            LoadParentData();
        }
    }
}
