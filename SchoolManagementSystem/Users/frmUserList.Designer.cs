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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cbFilterUserType = new System.Windows.Forms.ComboBox();
            this.lblFilterUserType = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsToggleStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnToggleStatus = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Users Management";
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.btnRefresh);
            this.gbFilter.Controls.Add(this.cbFilterStatus);
            this.gbFilter.Controls.Add(this.lblFilterStatus);
            this.gbFilter.Controls.Add(this.cbFilterUserType);
            this.gbFilter.Controls.Add(this.lblFilterUserType);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.lblSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbFilter.Location = new System.Drawing.Point(29, 65);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(940, 75);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Search & Filter";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(835, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "All Statuses",
            "Active",
            "Inactive"});
            this.cbFilterStatus.Location = new System.Drawing.Point(620, 32);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(150, 24);
            this.cbFilterStatus.TabIndex = 5;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFilterStatus.Location = new System.Drawing.Point(565, 35);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(46, 17);
            this.lblFilterStatus.TabIndex = 4;
            this.lblFilterStatus.Text = "Status:";
            // 
            // cbFilterUserType
            // 
            this.cbFilterUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUserType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterUserType.FormattingEnabled = true;
            this.cbFilterUserType.Items.AddRange(new object[] {
            "All Types",
            "Admin",
            "Teacher",
            "Parent",
            "Student"});
            this.cbFilterUserType.Location = new System.Drawing.Point(395, 32);
            this.cbFilterUserType.Name = "cbFilterUserType";
            this.cbFilterUserType.Size = new System.Drawing.Size(150, 24);
            this.cbFilterUserType.TabIndex = 3;
            this.cbFilterUserType.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblFilterUserType
            // 
            this.lblFilterUserType.AutoSize = true;
            this.lblFilterUserType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFilterUserType.Location = new System.Drawing.Point(315, 35);
            this.lblFilterUserType.Name = "lblFilterUserType";
            this.lblFilterUserType.Size = new System.Drawing.Size(68, 17);
            this.lblFilterUserType.TabIndex = 2;
            this.lblFilterUserType.Text = "User Type:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(85, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSearch.Location = new System.Drawing.Point(20, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(29, 155);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(940, 340);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.DoubleClick += new System.EventHandler(this.DgvUsers_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsToggleStatus,
            this.cmsResetPassword,
            this.toolStripSeparator1,
            this.cmsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 98);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(184, 22);
            this.cmsEdit.Text = "Edit User Account";
            this.cmsEdit.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // cmsToggleStatus
            // 
            this.cmsToggleStatus.Name = "cmsToggleStatus";
            this.cmsToggleStatus.Size = new System.Drawing.Size(184, 22);
            this.cmsToggleStatus.Text = "Activate / Deactivate";
            this.cmsToggleStatus.Click += new System.EventHandler(this.BtnToggleStatus_Click);
            // 
            // cmsResetPassword
            // 
            this.cmsResetPassword.Name = "cmsResetPassword";
            this.cmsResetPassword.Size = new System.Drawing.Size(184, 22);
            this.cmsResetPassword.Text = "Reset Password";
            this.cmsResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(184, 22);
            this.cmsDelete.Text = "Delete User";
            this.cmsDelete.Click += new System.EventHandler(this.CmsDelete_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalCount.Location = new System.Drawing.Point(29, 515);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(80, 15);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "Total Users: 0";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateUser.Location = new System.Drawing.Point(440, 508);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(120, 32);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "+ Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditUser.Location = new System.Drawing.Point(570, 508);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(90, 32);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // btnToggleStatus
            // 
            this.btnToggleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggleStatus.Location = new System.Drawing.Point(670, 508);
            this.btnToggleStatus.Name = "btnToggleStatus";
            this.btnToggleStatus.Size = new System.Drawing.Size(120, 32);
            this.btnToggleStatus.TabIndex = 6;
            this.btnToggleStatus.Text = "Toggle Status";
            this.btnToggleStatus.UseVisualStyleBackColor = true;
            this.btnToggleStatus.Click += new System.EventHandler(this.BtnToggleStatus_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPassword.Location = new System.Drawing.Point(800, 508);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(110, 32);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(920, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(999, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnToggleStatus);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
