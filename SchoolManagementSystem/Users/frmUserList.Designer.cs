namespace SchoolManagementSystem.Users
{
    partial class frmUserList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            gbFilter = new GroupBox();
            btnRefresh = new Button();
            cbFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            cbFilterUserType = new ComboBox();
            lblFilterUserType = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmsEdit = new ToolStripMenuItem();
            cmsToggleStatus = new ToolStripMenuItem();
            cmsResetPassword = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cmsDelete = new ToolStripMenuItem();
            lblTotalCount = new Label();
            btnCreateUser = new Button();
            btnEditUser = new Button();
            btnToggleStatus = new Button();
            btnResetPassword = new Button();
            btnClose = new Button();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(446, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة المستخدمين";
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFilter.Controls.Add(btnRefresh);
            gbFilter.Controls.Add(cbFilterStatus);
            gbFilter.Controls.Add(lblFilterStatus);
            gbFilter.Controls.Add(cbFilterUserType);
            gbFilter.Controls.Add(lblFilterUserType);
            gbFilter.Controls.Add(txtSearch);
            gbFilter.Controls.Add(lblSearch);
            gbFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(30, 41, 59);
            gbFilter.Location = new Point(33, 75);
            gbFilter.Margin = new Padding(3, 4, 3, 4);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(3, 4, 3, 4);
            gbFilter.Size = new Size(1071, 100);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "البحث والتصفية";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.Location = new Point(20, 36);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 38);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "🔄 تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterStatus.Font = new Font("Segoe UI", 9.5F);
            cbFilterStatus.FormattingEnabled = true;
            cbFilterStatus.Items.AddRange(new object[] { "جميع الحالات", "نشط", "غير نشط" });
            cbFilterStatus.Location = new Point(160, 41);
            cbFilterStatus.Margin = new Padding(3, 4, 3, 4);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(180, 29);
            cbFilterStatus.TabIndex = 5;
            cbFilterStatus.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9.5F);
            lblFilterStatus.Location = new Point(345, 45);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(48, 21);
            lblFilterStatus.TabIndex = 4;
            lblFilterStatus.Text = "الحالة:";
            // 
            // cbFilterUserType
            // 
            cbFilterUserType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterUserType.Font = new Font("Segoe UI", 9.5F);
            cbFilterUserType.FormattingEnabled = true;
            cbFilterUserType.Items.AddRange(new object[] { "جميع الأنواع", "Admin", "Teacher", "Parent", "Student" });
            cbFilterUserType.Location = new Point(415, 41);
            cbFilterUserType.Margin = new Padding(3, 4, 3, 4);
            cbFilterUserType.Name = "cbFilterUserType";
            cbFilterUserType.Size = new Size(180, 29);
            cbFilterUserType.TabIndex = 3;
            cbFilterUserType.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFilterUserType
            // 
            lblFilterUserType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterUserType.AutoSize = true;
            lblFilterUserType.Font = new Font("Segoe UI", 9.5F);
            lblFilterUserType.Location = new Point(600, 45);
            lblFilterUserType.Name = "lblFilterUserType";
            lblFilterUserType.Size = new Size(89, 21);
            lblFilterUserType.TabIndex = 2;
            lblFilterUserType.Text = "نوع الحساب:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(720, 41);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextAlign = HorizontalAlignment.Right;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.Location = new Point(975, 45);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث سريع:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Location = new Point(33, 195);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1071, 465);
            dgvUsers.TabIndex = 2;
            dgvUsers.DoubleClick += DgvUsers_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmsEdit, cmsToggleStatus, cmsResetPassword, toolStripSeparator1, cmsDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RightToLeft = RightToLeft.Yes;
            contextMenuStrip1.Size = new Size(250, 106);
            // 
            // cmsEdit
            // 
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(249, 24);
            cmsEdit.Text = "✏️ تعديل بيانات المستخدم";
            cmsEdit.Click += BtnEditUser_Click;
            // 
            // cmsToggleStatus
            // 
            cmsToggleStatus.Name = "cmsToggleStatus";
            cmsToggleStatus.Size = new Size(249, 24);
            cmsToggleStatus.Text = "🔄 تفعيل / تعطيل الحساب";
            cmsToggleStatus.Click += BtnToggleStatus_Click;
            // 
            // cmsResetPassword
            // 
            cmsResetPassword.Name = "cmsResetPassword";
            cmsResetPassword.Size = new Size(249, 24);
            cmsResetPassword.Text = "🔑 إعادة تعيين كلمة المرور";
            cmsResetPassword.Click += BtnResetPassword_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(246, 6);
            // 
            // cmsDelete
            // 
            cmsDelete.Name = "cmsDelete";
            cmsDelete.Size = new Size(249, 24);
            cmsDelete.Text = "🗑️ حذف الحساب";
            cmsDelete.Click += CmsDelete_Click;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(33, 687);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(153, 21);
            lblTotalCount.TabIndex = 3;
            lblTotalCount.Text = "إجمالي المستخدمين: 0";
            // 
            // btnCreateUser
            // 
            btnCreateUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCreateUser.Location = new Point(368, 677);
            btnCreateUser.Margin = new Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(160, 43);
            btnCreateUser.TabIndex = 4;
            btnCreateUser.Text = "➕ إضافة مستخدم";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += BtnCreateUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditUser.Font = new Font("Segoe UI", 9.5F);
            btnEditUser.Location = new Point(538, 677);
            btnEditUser.Margin = new Padding(3, 4, 3, 4);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(120, 43);
            btnEditUser.TabIndex = 5;
            btnEditUser.Text = "تعديل";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += BtnEditUser_Click;
            // 
            // btnToggleStatus
            // 
            btnToggleStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnToggleStatus.Font = new Font("Segoe UI", 9.5F);
            btnToggleStatus.Location = new Point(668, 677);
            btnToggleStatus.Margin = new Padding(3, 4, 3, 4);
            btnToggleStatus.Name = "btnToggleStatus";
            btnToggleStatus.Size = new Size(140, 43);
            btnToggleStatus.TabIndex = 6;
            btnToggleStatus.Text = "تغيير الحالة";
            btnToggleStatus.UseVisualStyleBackColor = true;
            btnToggleStatus.Click += BtnToggleStatus_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetPassword.Font = new Font("Segoe UI", 9.5F);
            btnResetPassword.Location = new Point(818, 677);
            btnResetPassword.Margin = new Padding(3, 4, 3, 4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(160, 43);
            btnResetPassword.TabIndex = 7;
            btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += BtnResetPassword_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(1014, 674);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 43);
            btnClose.TabIndex = 8;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmUserList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1139, 740);
            Controls.Add(btnClose);
            Controls.Add(btnResetPassword);
            Controls.Add(btnToggleStatus);
            Controls.Add(btnEditUser);
            Controls.Add(btnCreateUser);
            Controls.Add(lblTotalCount);
            Controls.Add(dgvUsers);
            Controls.Add(gbFilter);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.5F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 651);
            Name = "frmUserList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة المستخدمين والصلاحيات";
            Load += FrmUserList_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterUserType;
        private System.Windows.Forms.ComboBox cbFilterUserType;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnToggleStatus;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsToggleStatus;
        private System.Windows.Forms.ToolStripMenuItem cmsResetPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
    }
}
