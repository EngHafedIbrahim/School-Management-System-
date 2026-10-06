using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystemBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

            //LoadData();
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
                MessageBox.Show("Please select a student.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            //Ignore this try catch block...
            try
            {
                if (sp.IsThisStudentAlreadyLinkedToThisParent())
                {
                    MessageBox.Show("Validation error: This student is already linked to this parent "," Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (sp.Save())
                {
                    MessageBox.Show("Student linked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to link student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation error: " + ex.Message, "Constraint Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
