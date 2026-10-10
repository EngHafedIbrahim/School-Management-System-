using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Teachers
{
    public partial class frmTeacherProfile : Form
    {
        private int _TeacherID;
        private clsTeacher _Teacher;

        public frmTeacherProfile(int teacherID)
        {
            InitializeComponent();
            _TeacherID = teacherID;

            clsUITheme.StyleDataGridView(dgvAssignments);
            clsUITheme.StyleDataGridView(dgvTimetable);
            clsUITheme.StylePrimaryButton(btnCreateUserAccount);
            clsUITheme.StylePrimaryButton(btnEditTeacher);
            clsUITheme.StyleSecondaryButton(btnClose);

            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            _Teacher = clsTeacher.Find(_TeacherID);
            if (_Teacher == null)
            {
                MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblValFullName.Text = $"{_Teacher.FirstName} {_Teacher.LastName}";
            lblValPhone.Text = _Teacher.PhoneNumber;
            lblValEmail.Text = _Teacher.Email;
            lblValAddress.Text = string.IsNullOrEmpty(_Teacher.Address) ? "N/A" : _Teacher.Address;
            lblValGender.Text = _Teacher.GenderInfo?.Name ?? "N/A";
            lblValSpecialization.Text = string.IsNullOrEmpty(_Teacher.Specialization) ? "General" : _Teacher.Specialization;
            lblValQualification.Text = string.IsNullOrEmpty(_Teacher.Qualification) ? "N/A" : _Teacher.Qualification;
            lblValHireDate.Text = _Teacher.HireDate.ToString("yyyy-MM-dd");
            lblValStatus.Text = string.IsNullOrEmpty(_Teacher.EmploymentStatus) ? "Active" : _Teacher.EmploymentStatus;
            lblValAbout.Text = string.IsNullOrEmpty(_Teacher.About) ? "None." : _Teacher.About;

            // Load Assignments
            dgvAssignments.DataSource = clsClassCourse.GetAssignmentsByTeacherID(_TeacherID);

            // Load Timetable
            dgvTimetable.DataSource = clsSchedule.GetSchedulesByTeacherID(_TeacherID);

            // Check linked User Account
            //CheckLinkedUserAccount();
        }

        private void CheckLinkedUserAccount()
        {
            //now , user table doesn't exist. later i will add as a version 2
            DataTable dtUsers = clsUser.GetAllUsers();

            if (dtUsers == null)
            {
                return;
            }
            DataRow[] found = dtUsers.Select($"ReferenceID = {_TeacherID} AND UserType = 'Teacher'");

            if (found.Length > 0)
            {
                lblValUsername.Text = found[0]["Username"].ToString();
                string status = found[0]["Status"].ToString();
                lblValUserStatus.Text = status;
                lblValUserStatus.ForeColor = status.Equals("Active", StringComparison.OrdinalIgnoreCase) ? System.Drawing.Color.FromArgb(39, 174, 96) : System.Drawing.Color.FromArgb(192, 57, 43);
                btnCreateUserAccount.Enabled = false;
                btnCreateUserAccount.Text = "Account Already Exists";
            }
            else
            {
                lblValUsername.Text = "No system account linked";
                lblValUserStatus.Text = "Not Provisioned";
                lblValUserStatus.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
                btnCreateUserAccount.Enabled = true;
                btnCreateUserAccount.Text = "Generate Teacher Login Account";
            }
        }

        private void BtnCreateUserAccount_Click(object sender, EventArgs e)
        {
            string username = _Teacher.Email.Split('@')[0].ToLower();
            string tempPass = "Teacher@123";

            if (MessageBox.Show($"Create system user account for {_Teacher.FirstName} {_Teacher.LastName}?\n\nUsername: {username}\nInitial Password: {tempPass}", "Provision Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    clsUser user = new clsUser();
                    user.Username = username;
                    user.PasswordHash = UtilityLib.clsSecurity.ComputeHash(tempPass);
                    user.UserType = "Teacher";
                    user.ReferenceID = _TeacherID;
                    user.Email = _Teacher.Email;
                    user.Status = "Active";

                    if (user.Save())
                    {
                        MessageBox.Show("Teacher user account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CheckLinkedUserAccount();
                    }
                    else
                    {
                        MessageBox.Show(/*"Failed to create user account."*/"now , user table doesn't exist. later i will add as a version 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditTeacher_Click(object sender, EventArgs e)
        {
            frmAddEditTeacher frm = new frmAddEditTeacher(_TeacherID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherData();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
