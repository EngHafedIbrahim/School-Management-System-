using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Students
{
    public partial class frmLinkParentToStudent : Form
    {
        private int _StudentID;

        public frmLinkParentToStudent(int studentID)
        {
            InitializeComponent();
            _StudentID = studentID;

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);

            LoadData();
        }

        private void LoadData()
        {
            DataTable dtParents = clsParent.GetAllParents();
            if (!dtParents.Columns.Contains("DisplayName"))
            {
                dtParents.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + PhoneNumber + ')'");
            }
            cbParents.DataSource = dtParents;
            cbParents.DisplayMember = "DisplayName";
            cbParents.ValueMember = "ParentID";
            cbRelationship.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cbParents.SelectedValue == null)
            {
                clsUITheme.ShowArabicMessage("يرجى اختيار ولي أمر من القائمة.", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int parentID = (int)cbParents.SelectedValue;
            string relationship = cbRelationship.Text;
            bool isPrimary = chkIsPrimary.Checked;

            clsStudentParent sp = new clsStudentParent();
            sp.StudentID = _StudentID;
            sp.ParentID = parentID;
            sp.Relationship = relationship;
            sp.IsPrimaryContact = isPrimary;

            try
            {
                if (sp.Save())
                {
                    clsUITheme.ShowArabicMessage("تم ربط ولي الأمر بالطالب بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل ربط ولي الأمر بالطالب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق: " + ex.Message, "قيد مكرر أو غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
