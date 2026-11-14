using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystemBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem.Parents
{
    public partial class frmLinkStudentToParent : Form
    {
        private int _ParentID;

        public frmLinkStudentToParent(int parentID)
        {
            InitializeComponent();
            _ParentID = parentID;

            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancel);
        }

        private void LoadData()
        {
            DataTable dtStudents = clsStudent.GetAllStudents();
           
            if (!dtStudents.Columns.Contains("FullName"))
            {
                dtStudents.Columns.Add("DisplayName", typeof(string), "FirstName + ' ' + LastName + ' (' + AdmissionNo + ')'");
            }
            cbStudents.DataSource = dtStudents;
            cbStudents.DisplayMember = "FullName";
            cbStudents.ValueMember = "StudentID";
            cbRelationship.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cbStudents.SelectedValue == null)
            {
                clsUITheme.ShowArabicMessage("يرجى اختيار الطالب من القائمة.", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = (int)cbStudents.SelectedValue;
            string relationship = cbRelationship.Text;
            bool isPrimary = chkIsPrimary.Checked;

            clsStudentParent sp = new clsStudentParent();
            sp.StudentID = studentID;
            sp.ParentID = _ParentID;
            sp.Relationship = relationship;
            sp.IsPrimaryContact = isPrimary;

            try
            {
                if (sp.IsThisStudentAlreadyLinkedToThisParent())
                {
                    clsUITheme.ShowArabicMessage("تنبيه: هذا الطالب مرتبط بالفعل بولي الأمر هذا مسبقاً.", "ارتباط مكرر", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (sp.Save())
                {
                    clsUITheme.ShowArabicMessage("تم ربط الطالب بولي الأمر بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل ربط الطالب بولي الأمر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("خطأ في التحقق من صحة الربط: " + ex.Message, "قيد النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLinkStudentToParent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
