using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Students
{
    public partial class frmStudentProfile : Form
    {
        private int _StudentID;
        private clsStudent _Student;

        public frmStudentProfile(int studentID)
        {
            InitializeComponent();
            _StudentID = studentID;

            clsUITheme.StyleDataGridView(dgvParents);
            clsUITheme.StyleDataGridView(dgvEnrollment);
            clsUITheme.StyleDataGridView(dgvAttendance);
            clsUITheme.StyleDataGridView(dgvGrades);
            clsUITheme.StyleDataGridView(dgvFinancial);

            clsUITheme.StylePrimaryButton(btnLinkParent);
            clsUITheme.StyleDangerButton(btnUnlinkParent);
            clsUITheme.StylePrimaryButton(btnEditProfile);
            clsUITheme.StyleSecondaryButton(btnClose);

            LoadStudentData();
        }

        public void LoadStudentData()
        {
            _Student = clsStudent.Find(_StudentID);
            if (_Student == null)
            {
                MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValFullName.Text = $"{_Student.FirstName} {_Student.LastName}";
            lblValAdmNo.Text = _Student.AdmissionNo;
            lblValNationalID.Text = _Student.NationalID;
            lblValDOB.Text = _Student.DateOfBirth.ToString("yyyy-MM-dd");
            lblValGender.Text = _Student.GenderInfo?.Name ?? "N/A";
            lblValNationality.Text = _Student.Nationality;
            lblValBlood.Text = string.IsNullOrEmpty(_Student.BloodType) ? "N/A" : _Student.BloodType;
            lblValPhone.Text = string.IsNullOrEmpty(_Student.PhoneNumber) ? "N/A" : _Student.PhoneNumber;
            lblValEmail.Text = string.IsNullOrEmpty(_Student.Email) ? "N/A" : _Student.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Student.Address) ? "N/A" : _Student.Address;
            lblValAdmDate.Text = _Student.AdmissionDate.ToString("yyyy-MM-dd");
            lblValPrevSchool.Text = string.IsNullOrEmpty(_Student.PreviousSchool) ? "N/A" : _Student.PreviousSchool;
            lblValHealth.Text = string.IsNullOrEmpty(_Student.HealthStatus) ? "Healthy" : _Student.HealthStatus;



            RefreshParents();
            RefreshEnrollment();
            RefreshAttendance();
            RefreshGrades();
            RefreshFinancial();

        }

        private void RefreshParents()
        {
            dgvParents.DataSource = clsStudentParent.GetParentsByStudentID(_StudentID);
        }

        private void RefreshEnrollment()
        {
            dgvEnrollment.DataSource = clsStudentEnrollment.GetEnrollmentHistoryByStudentID(_StudentID);
        }

        private void RefreshAttendance()
        {
            if ((dgvAttendance.DataSource = clsAttendance.GetAttendanceByStudentID(_StudentID)) == null)
            {
                return;
            }
        }

        private void RefreshGrades()
        {
            dgvGrades.DataSource = clsGrade.GetGradesByStudentID(_StudentID);
        }

        private void RefreshFinancial()
        {
            dgvFinancial.DataSource = clsInvoice.GetInvoicesByStudentID(_StudentID);
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frm = new frmRegisterStudent(_StudentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentData();
            }
        }

        private void BtnLinkParent_Click(object sender, EventArgs e)
        {
            frmLinkParentToStudent frm = new frmLinkParentToStudent(_StudentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshParents();
            }
        }

        private void BtnUnlinkParent_Click(object sender, EventArgs e)
        {
            if (dgvParents.CurrentRow == null)
            {
                MessageBox.Show("Please select a parent link to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentParentID = Convert.ToInt32(dgvParents.CurrentRow.Cells["StudentParentID"].Value);
            string parentName = dgvParents.CurrentRow.Cells["ParentName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to remove the link with parent '{parentName}'?", "Confirm Unlink", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsStudentParent.DeleteStudentParent(studentParentID))
                {
                    MessageBox.Show("Parent link removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshParents();
                }
                else
                {
                    MessageBox.Show("Failed to remove parent link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (tabControl.TabIndex)
            //{
            //    case 1:
            //        {
            //            RefreshParents();
                        
            //            break;
            //        }
            //    case 2:
            //        {
            //            RefreshEnrollment();
                        

            //            break;
            //        }
            //    case 3:
            //        {
            //            RefreshAttendance();
                        

            //            break;
            //        }
            //    case 4:
            //        {
            //            RefreshGrades();
                        
            //            break;
            //        }
            //    case 5:
            //        {
            //            RefreshFinancial();
            //            break;
            //        }
            //}

        }



    }
}
