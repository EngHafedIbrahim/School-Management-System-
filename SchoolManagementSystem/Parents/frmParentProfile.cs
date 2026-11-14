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
        }

        public void LoadParentData()
        {
            _Parent = clsParent.Find(_ParentID);
            if (_Parent == null)
            {
                clsUITheme.ShowArabicMessage("لم يتم العثور على سجل ولي الأمر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValParentID.Text = _Parent.ParentID.ToString();
            lblValFullName.Text = $"{_Parent.FirstName} {_Parent.LastName}";
            lblValPhone.Text = _Parent.PhoneNumber;
            lblValEmail.Text = string.IsNullOrEmpty(_Parent.Email) ? "غير متوفر" : _Parent.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Parent.Address) ? "غير متوفر" : _Parent.Address;

            RefreshChildren();
        }

        private void RefreshChildren()
        {
            dgvChildren.DataSource = clsStudentParent.GetStudentsByParentID(_ParentID);

            if (dgvChildren.Columns.Contains("StudentParentID"))
                dgvChildren.Columns["StudentParentID"].Visible = false;
            if (dgvChildren.Columns.Contains("StudentID"))
            {
                dgvChildren.Columns["StudentID"].HeaderText = "رقم الطالب";
                dgvChildren.Columns["StudentID"].Width = 90;
            }
            if (dgvChildren.Columns.Contains("StudentName"))
            {
                dgvChildren.Columns["StudentName"].HeaderText = "اسم الطالب";
                dgvChildren.Columns["StudentName"].Width = 200;
            }
            if (dgvChildren.Columns.Contains("Relationship"))
            {
                dgvChildren.Columns["Relationship"].HeaderText = "صلة القرابة";
                dgvChildren.Columns["Relationship"].Width = 120;
            }
            if (dgvChildren.Columns.Contains("IsPrimaryContact"))
            {
                dgvChildren.Columns["IsPrimaryContact"].HeaderText = "جهة اتصال رئيسية";
                dgvChildren.Columns["IsPrimaryContact"].Width = 140;
            }
            
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

        private int GetSelectedStudentID()
        {
            if (dgvChildren.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvChildren.CurrentRow.Cells["StudentID"].Value);
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب من القائمة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                clsUITheme.ShowArabicMessage("يرجى تحديد طالب لفك ارتباطه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentParentID = Convert.ToInt32(dgvChildren.CurrentRow.Cells["StudentParentID"].Value);
            string studentName = dgvChildren.CurrentRow.Cells["StudentName"].Value?.ToString() ?? "";

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من فك ارتباط الطالب '{studentName}' بولي الأمر هذا؟", "تأكيد فك الارتباط", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsStudentParent.DeleteStudentParent(studentParentID))
                {
                    clsUITheme.ShowArabicMessage("تم فك ارتباط الطالب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshChildren();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل فك ارتباط الطالب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
