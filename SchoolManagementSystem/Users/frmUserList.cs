using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;
using UtilityLib;

namespace SchoolManagementSystem.Users
{
    public partial class frmUserList : Form
    {
        private DataTable _dtUsers;
        private DataView _dvUsers;

        public frmUserList()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvUsers);
            clsUITheme.StylePrimaryButton(btnCreateUser);
            clsUITheme.StyleSecondaryButton(btnEditUser);
            clsUITheme.StyleSecondaryButton(btnToggleStatus);
            clsUITheme.StyleSecondaryButton(btnResetPassword);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            clsUITheme.StyleSecondaryButton(btnClose);
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            cbFilterUserType.SelectedIndex = 0; // All Types
            cbFilterStatus.SelectedIndex = 0;   // All Statuses
            LoadUsers();
        }

        private void LoadUsers()
        {
            _dtUsers = clsUser.GetAllUsersDetailed();
            _dvUsers = _dtUsers.DefaultView;
            dgvUsers.DataSource = _dvUsers;

            if (dgvUsers.Columns.Contains("UserID"))
            {
                dgvUsers.Columns["UserID"].HeaderText = "ID";
                dgvUsers.Columns["UserID"].Width = 60;
            }
            if (dgvUsers.Columns.Contains("Username"))
            {
                dgvUsers.Columns["Username"].HeaderText = "Username";
                dgvUsers.Columns["Username"].Width = 140;
            }
            if (dgvUsers.Columns.Contains("Email"))
            {
                dgvUsers.Columns["Email"].HeaderText = "Email";
                dgvUsers.Columns["Email"].Width = 180;
            }
            if (dgvUsers.Columns.Contains("UserType"))
            {
                dgvUsers.Columns["UserType"].HeaderText = "Type";
                dgvUsers.Columns["UserType"].Width = 100;
            }
            if (dgvUsers.Columns.Contains("LinkedEntityName"))
            {
                dgvUsers.Columns["LinkedEntityName"].HeaderText = "Linked Profile";
                dgvUsers.Columns["LinkedEntityName"].Width = 180;
            }
            if (dgvUsers.Columns.Contains("Status"))
            {
                dgvUsers.Columns["Status"].HeaderText = "Status";
                dgvUsers.Columns["Status"].Width = 90;
            }
            if (dgvUsers.Columns.Contains("CreatedAt"))
            {
                dgvUsers.Columns["CreatedAt"].HeaderText = "Created At";
                dgvUsers.Columns["CreatedAt"].Width = 130;
            }

            if (dgvUsers.Columns.Contains("ReferenceID"))
                dgvUsers.Columns["ReferenceID"].Visible = false;

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_dvUsers == null) return;

            string filter = "";
            string search = txtSearch.Text.Trim().Replace("'", "''");
            string userType = cbFilterUserType.SelectedItem?.ToString() ?? "All Types";
            string status = cbFilterStatus.SelectedItem?.ToString() ?? "All Statuses";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(Username LIKE '%{search}%' OR Email LIKE '%{search}%' OR LinkedEntityName LIKE '%{search}%')";
            }

            if (userType != "All Types")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"UserType = '{userType}'";
            }

            if (status != "All Statuses")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Status = '{status}'";
            }

            _dvUsers.RowFilter = filter;
            lblTotalCount.Text = $"Total Users: {_dvUsers.Count}";
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cbFilterUserType.SelectedIndex = 0;
            cbFilterStatus.SelectedIndex = 0;
            LoadUsers();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateUser frm = new frmCreateUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmCreateUser frm = new frmCreateUser(userID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void DgvUsers_DoubleClick(object sender, EventArgs e)
        {
            BtnEditUser_Click(sender, e);
        }

        private void BtnToggleStatus_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            string currentStatus = dgvUsers.CurrentRow.Cells["Status"].Value.ToString();
            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            // Prevent deactivating own account
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserID == userID)
            {
                MessageBox.Show("You cannot change the status of your currently logged-in account.", "Operation Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = currentStatus == "Active" ? "Inactive" : "Active";
            string actionText = newStatus == "Active" ? "activate" : "deactivate";

            if (MessageBox.Show($"Are you sure you want to {actionText} user account '{username}'?", "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.UpdateUserStatus(userID, newStatus))
                {
                    MessageBox.Show($"User '{username}' is now {newStatus}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to update user status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to reset password.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            // Simple input dialog for new password
            string newPassword = PromptForPassword(username);
            if (string.IsNullOrEmpty(newPassword))
                return;

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = clsSecurity.ComputeHash(newPassword);
            if (clsUser.ResetPassword(userID, hash))
            {
                MessageBox.Show($"Password for '{username}' has been reset successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PromptForPassword(string username)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = $"Reset Password for [{username}]",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Enter New Password (min 6 characters):", AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 45, Width = 340, PasswordChar = '●' };
            Button confirmation = new Button() { Text = "Save", Left = 190, Width = 80, Top = 85, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 280, Width = 80, Top = 85, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text.Trim() : null;
        }

        private void CmsDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserID == userID)
            {
                MessageBox.Show("You cannot delete your own currently logged-in account.", "Operation Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to permanently delete user account '{username}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(userID))
                {
                    MessageBox.Show("User account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to delete user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
