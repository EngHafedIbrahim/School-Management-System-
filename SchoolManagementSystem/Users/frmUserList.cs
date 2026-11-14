using System;
using System.Data;
using System.Drawing;
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
            cbFilterUserType.SelectedIndex = 0; // جميع الأنواع
            cbFilterStatus.SelectedIndex = 0;   // جميع الحالات
            LoadUsers();
        }

        private void LoadUsers()
        {
            _dtUsers = clsUser.GetAllUsersDetailed();
            _dvUsers = _dtUsers.DefaultView;
            dgvUsers.DataSource = _dvUsers;

            if (dgvUsers.Columns.Contains("UserID"))
            {
                dgvUsers.Columns["UserID"].HeaderText = "رقم المعرف";
                dgvUsers.Columns["UserID"].Width = 90;
            }
            if (dgvUsers.Columns.Contains("Username"))
            {
                dgvUsers.Columns["Username"].HeaderText = "اسم المستخدم";
                dgvUsers.Columns["Username"].Width = 140;
            }
            if (dgvUsers.Columns.Contains("Email"))
            {
                dgvUsers.Columns["Email"].HeaderText = "البريد الإلكتروني";
                dgvUsers.Columns["Email"].Width = 180;
            }
            if (dgvUsers.Columns.Contains("UserType"))
            {
                dgvUsers.Columns["UserType"].HeaderText = "نوع الحساب";
                dgvUsers.Columns["UserType"].Width = 110;
            }
            if (dgvUsers.Columns.Contains("LinkedEntityName"))
            {
                dgvUsers.Columns["LinkedEntityName"].HeaderText = "الملف الشخصي المرتبط";
                dgvUsers.Columns["LinkedEntityName"].Width = 200;
            }
            if (dgvUsers.Columns.Contains("Status"))
            {
                dgvUsers.Columns["IsActive"].HeaderText = "الحالة";
                dgvUsers.Columns["IsActive"].Width = 90;
            }
            if (dgvUsers.Columns.Contains("CreatedAt"))
            {
                dgvUsers.Columns["CreatedAt"].HeaderText = "تاريخ الإنشاء";
                dgvUsers.Columns["CreatedAt"].Width = 140;
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
            string userType = cbFilterUserType.SelectedItem?.ToString() ?? "جميع الأنواع";
            string status = cbFilterStatus.SelectedItem?.ToString() ?? "جميع الحالات";

            if (!string.IsNullOrEmpty(search))
            {
                filter = $"(Username LIKE '%{search}%' OR Email LIKE '%{search}%' OR LinkedEntityName LIKE '%{search}%')";
            }

            if (userType != "جميع الأنواع" && userType != "All Types")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"UserType = '{userType}'";
            }

            if (status != "جميع الحالات" && status != "All Statuses")
            {
                string statusValue = status == "نشط" ? "Active" : (status == "غير نشط" ? "Inactive" : status);
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"Status = '{statusValue}'";
            }

            _dvUsers.RowFilter = filter;
            lblTotalCount.Text = $"إجمالي المستخدمين: {_dvUsers.Count}";
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
                clsUITheme.ShowArabicMessage("يرجى تحديد مستخدم من القائمة للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clsUITheme.ShowArabicMessage("يرجى تحديد مستخدم من القائمة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            bool currentStatus = Convert.ToBoolean( dgvUsers.CurrentRow.Cells["IsActive"].Value);
            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            // Prevent deactivating own account
            if (clsGloble.CurrentUser != null && clsGloble.CurrentUser.UserID == userID)
            {
                clsUITheme.ShowArabicMessage("لا يمكنك تغيير حالة الحساب المسجل به حالياً.", "إجراء غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool newStatus = currentStatus  ? true : false;
            string actionText = newStatus ? "تفعيل" : "تعطيل";

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من رغبتك في {actionText} حساب المستخدم '{username}'؟", "تأكيد تغيير الحالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.UpdateUserStatus(userID, newStatus))
                {
                    bool statusAr = newStatus ? true: false;
                    clsUITheme.ShowArabicMessage($"أصبح حساب المستخدم '{username}' {statusAr} الآن.", "تم التحديث بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل تحديث حالة المستخدم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد مستخدم لإعادة تعيين كلمة المرور.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            string newPassword = PromptForPassword(username);
            if (string.IsNullOrEmpty(newPassword))
                return;

            if (newPassword.Length < 6)
            {
                clsUITheme.ShowArabicMessage("يجب أن تتكون كلمة المرور من 6 أحرف أو أرقام على الأقل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = clsSecurity.ComputeHash(newPassword);
            if (clsUser.ResetPassword(userID, hash))
            {
                clsUITheme.ShowArabicMessage($"تمت إعادة تعيين كلمة المرور للمستخدم '{username}' بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsUITheme.ShowArabicMessage("فشلت عملية إعادة تعيين كلمة المرور.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PromptForPassword(string username)
        {
            Form prompt = new Form()
            {
                Width = 420,
                Height = 190,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = $"إعادة تعيين كلمة المرور لـ [{username}]",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
                Font = clsUITheme.ArabicRegularFont
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "أدخل كلمة المرور الجديدة (6 أحرف على الأقل):", AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 360, PasswordChar = '●', TextAlign = HorizontalAlignment.Right };
            Button confirmation = new Button() { Text = "حفظ 💾", Left = 130, Width = 100, Top = 95, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "إلغاء", Left = 240, Width = 100, Top = 95, DialogResult = DialogResult.Cancel };

            clsUITheme.StylePrimaryButton(confirmation);
            clsUITheme.StyleSecondaryButton(cancel);

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
                clsUITheme.ShowArabicMessage("لا يمكنك حذف الحساب المسجل به حالياً في النظام.", "إجراء مقيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsUITheme.ShowArabicMessage($"هل أنت متأكد من رغبتك في حذف حساب المستخدم '{username}' نهائياً؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(userID))
                {
                    clsUITheme.ShowArabicMessage("تم حذف حساب المستخدم بنجاح.", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حذف حساب المستخدم لوجود ارتباطات في النظام.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
