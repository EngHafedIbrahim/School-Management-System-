using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Students
{
    public partial class frmStudentList : Form
    {
        private DataTable _dtStudents;
        private DataView _dvStudents;

        public frmStudentList()
        {
            InitializeComponent();
            clsUITheme.StyleDataGridView(dgvStudents);
            clsUITheme.StyleSuccessButton(btnAddStudent);
            clsUITheme.StylePrimaryButton(btnViewProfile);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            cbFilterGender.SelectedIndex = 0;
           // LoadStudentsList();
        }

        private void LoadStudentsList()
        {
            _dtStudents = clsStudent.GetAllStudents();

            _dvStudents = _dtStudents.DefaultView;

            dgvStudents.DataSource = _dvStudents;

            if (dgvStudents.Rows.Count > 0)
            {
                // dgvStudents.Columns[0]
                dgvStudents.Columns[0].HeaderText = "StudentID";
                dgvStudents.Columns[0].Width = 120;

                // dgvStudents.Columns[1]
                dgvStudents.Columns[1].HeaderText = "FullName";
                dgvStudents.Columns[1].Width = 200;

                // dgvStudents.Columns[2]
                dgvStudents.Columns[2].HeaderText = "NationalID";
                dgvStudents.Columns[2].Width = 120;

                // dgvStudents.Columns[3]
                dgvStudents.Columns[3].HeaderText = "DateOfBirth";
                dgvStudents.Columns[3].Width = 120;

                // dgvStudents.Columns[4]
                dgvStudents.Columns[4].HeaderText = "GenderID";
                dgvStudents.Columns[4].Width = 80;

                // dgvStudents.Columns[5]
                dgvStudents.Columns[5].HeaderText = "Nationality";
                dgvStudents.Columns[5].Width = 120;

                // dgvStudents.Columns[6]
                dgvStudents.Columns[6].HeaderText = "BloodType";
                dgvStudents.Columns[6].Width = 90;

                // dgvStudents.Columns[7]
                dgvStudents.Columns[7].HeaderText = "Address";
                dgvStudents.Columns[7].Width = 200;

                // dgvStudents.Columns[8]
                dgvStudents.Columns[8].HeaderText = "PhoneNumber";
                dgvStudents.Columns[8].Width = 130;

                // dgvStudents.Columns[9]
                dgvStudents.Columns[9].HeaderText = "Email";
                dgvStudents.Columns[9].Width = 200;

                // dgvStudents.Columns[10]
                dgvStudents.Columns[10].HeaderText = "AdmissionNo";
                dgvStudents.Columns[10].Width = 120;

                // dgvStudents.Columns[11]
                dgvStudents.Columns[11].HeaderText = "AdmissionDate";
                dgvStudents.Columns[11].Width = 120;

                // dgvStudents.Columns[12]
                dgvStudents.Columns[12].HeaderText = "PreviousSchool";
                dgvStudents.Columns[12].Width = 160;

                // dgvStudents.Columns[13]
                dgvStudents.Columns[13].HeaderText = "HealthStatus";
                dgvStudents.Columns[13].Width = 140;

                // dgvStudents.Columns[14]
                dgvStudents.Columns[14].HeaderText = "ProfileImageURL";
                dgvStudents.Columns[14].Width = 160;

                // dgvStudents.Columns[15]
                dgvStudents.Columns[15].HeaderText = "CreatedBy";
                dgvStudents.Columns[15].Width = 100;

                // dgvStudents.Columns[16]
                dgvStudents.Columns[16].HeaderText = "CreatedAt";
                dgvStudents.Columns[16].Width = 120;



            }
            //if (dgvStudents.Columns.Contains("StudentID"))
            //    dgvStudents.Columns["StudentID"].Width = 90;
            //if (dgvStudents.Columns.Contains("AdmissionNo"))
            //    dgvStudents.Columns["AdmissionNo"].Width = 140;
            //if (dgvStudents.Columns.Contains("Gender"))
            //    dgvStudents.Columns["Gender"].Width = 90;
            //if (dgvStudents.Columns.Contains("DateOfBirth"))
            //    dgvStudents.Columns["DateOfBirth"].DefaultCellStyle.Format = "yyyy-MM-dd";


            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvStudents == null) return;

            string search = txtSearch.Text.Trim().Replace("'", "''");
            string gender = cbFilterGender.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(FullName LIKE '%{search}%' OR AdmissionNo LIKE '%{search}%')";
            }

            if (gender != null && gender != "All")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Gender = '{gender}'";
            }

            _dvStudents.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Displayed Students: {_dvStudents?.Count ?? 0}";
        }

        private int GetSelectedStudentID()
        {
            if (dgvStudents.CurrentRow == null) return -1;
            return Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentsList();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            frmRegisterStudent frm = new frmRegisterStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //LoadStudentsList();
            }
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                MessageBox.Show("Please select a student from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmStudentProfile frm = new frmStudentProfile(studentID);
            frm.ShowDialog();
            LoadStudentsList();
        }

        private void DgvStudents_DoubleClick(object sender, EventArgs e)
        {
            BtnViewProfile_Click(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                MessageBox.Show("Please select a student to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmRegisterStudent frm = new frmRegisterStudent(studentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadStudentsList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int studentID = GetSelectedStudentID();
            if (studentID == -1)
            {
                MessageBox.Show("Please select a student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string studentName = dgvStudents.CurrentRow.Cells["FullName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete student '{studentName}' (ID: {studentID})?\nThis action will check all linked dependencies.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsStudent.DeleteStudent(studentID))
                    {
                        MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentsList();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete student. The student has active records (Enrollment, Invoices, Grades, or Parent links).", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            LoadStudentsList();
        }
    }
}
