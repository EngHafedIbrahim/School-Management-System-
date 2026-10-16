namespace SchoolManagementSystem.Users
{
    partial class frmCreateUser
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
            this.gbAccountInfo = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbLinkedEntity = new System.Windows.Forms.GroupBox();
            this.cbLinkedEntity = new System.Windows.Forms.ComboBox();
            this.lblLinkedEntity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAccountInfo.SuspendLayout();
            this.gbLinkedEntity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create User Account";
            // 
            // gbAccountInfo
            // 
            this.gbAccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAccountInfo.Controls.Add(this.cbStatus);
            this.gbAccountInfo.Controls.Add(this.lblStatus);
            this.gbAccountInfo.Controls.Add(this.cbUserType);
            this.gbAccountInfo.Controls.Add(this.lblUserType);
            this.gbAccountInfo.Controls.Add(this.txtEmail);
            this.gbAccountInfo.Controls.Add(this.lblEmail);
            this.gbAccountInfo.Controls.Add(this.txtConfirmPassword);
            this.gbAccountInfo.Controls.Add(this.lblConfirmPassword);
            this.gbAccountInfo.Controls.Add(this.txtPassword);
            this.gbAccountInfo.Controls.Add(this.lblPassword);
            this.gbAccountInfo.Controls.Add(this.txtUsername);
            this.gbAccountInfo.Controls.Add(this.lblUsername);
            this.gbAccountInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbAccountInfo.Location = new System.Drawing.Point(29, 65);
            this.gbAccountInfo.Name = "gbAccountInfo";
            this.gbAccountInfo.Size = new System.Drawing.Size(540, 260);
            this.gbAccountInfo.TabIndex = 1;
            this.gbAccountInfo.TabStop = false;
            this.gbAccountInfo.Text = "Account Credentials";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(155, 215);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(350, 24);
            this.cbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.Location = new System.Drawing.Point(25, 218);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // cbUserType
            // 
            this.cbUserType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Parent",
            "Student"});
            this.cbUserType.Location = new System.Drawing.Point(155, 178);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(350, 24);
            this.cbUserType.TabIndex = 9;
            this.cbUserType.SelectedIndexChanged += new System.EventHandler(this.CbUserType_SelectedIndexChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUserType.Location = new System.Drawing.Point(25, 181);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(81, 17);
            this.lblUserType.TabIndex = 8;
            this.lblUserType.Text = "User Type: *";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(155, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(25, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email: *";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(155, 105);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 24);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(25, 108);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(126, 17);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password: *";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(155, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassword.Location = new System.Drawing.Point(25, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password: *";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.Location = new System.Drawing.Point(155, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUsername.Location = new System.Drawing.Point(25, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: *";
            // 
            // gbLinkedEntity
            // 
            this.gbLinkedEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLinkedEntity.Controls.Add(this.cbLinkedEntity);
            this.gbLinkedEntity.Controls.Add(this.lblLinkedEntity);
            this.gbLinkedEntity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbLinkedEntity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbLinkedEntity.Location = new System.Drawing.Point(29, 335);
            this.gbLinkedEntity.Name = "gbLinkedEntity";
            this.gbLinkedEntity.Size = new System.Drawing.Size(540, 85);
            this.gbLinkedEntity.TabIndex = 2;
            this.gbLinkedEntity.TabStop = false;
            this.gbLinkedEntity.Text = "Linked Entity Association";
            this.gbLinkedEntity.Visible = false;
            // 
            // cbLinkedEntity
            // 
            this.cbLinkedEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLinkedEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinkedEntity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLinkedEntity.FormattingEnabled = true;
            this.cbLinkedEntity.Location = new System.Drawing.Point(155, 35);
            this.cbLinkedEntity.Name = "cbLinkedEntity";
            this.cbLinkedEntity.Size = new System.Drawing.Size(350, 24);
            this.cbLinkedEntity.TabIndex = 1;
            // 
            // lblLinkedEntity
            // 
            this.lblLinkedEntity.AutoSize = true;
            this.lblLinkedEntity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLinkedEntity.Location = new System.Drawing.Point(25, 38);
            this.lblLinkedEntity.Name = "lblLinkedEntity";
            this.lblLinkedEntity.Size = new System.Drawing.Size(95, 17);
            this.lblLinkedEntity.TabIndex = 0;
            this.lblLinkedEntity.Text = "Select Teacher:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(320, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Create User";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(455, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(599, 495);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbLinkedEntity);
            this.Controls.Add(this.gbAccountInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create User Account";
            this.Load += new System.EventHandler(this.FrmCreateUser_Load);
            this.gbAccountInfo.ResumeLayout(false);
            this.gbAccountInfo.PerformLayout();
            this.gbLinkedEntity.ResumeLayout(false);
            this.gbLinkedEntity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbAccountInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbLinkedEntity;
        private System.Windows.Forms.Label lblLinkedEntity;
        private System.Windows.Forms.ComboBox cbLinkedEntity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
