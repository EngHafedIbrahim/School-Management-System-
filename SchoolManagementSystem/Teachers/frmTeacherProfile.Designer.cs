namespace SchoolManagementSystem.Teachers
{
    partial class frmTeacherProfile
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            tabControl = new TabControl();
            tabOverview = new TabPage();
            pnlOverview = new Panel();
            lblValAbout = new Label();
            lblTAbout = new Label();
            lblValStatus = new Label();
            lblTStatus = new Label();
            lblValHireDate = new Label();
            lblTHireDate = new Label();
            lblValQualification = new Label();
            lblTQualification = new Label();
            lblValSpecialization = new Label();
            lblTSpecialization = new Label();
            lblValGender = new Label();
            lblTGender = new Label();
            lblValAddress = new Label();
            lblTAddress = new Label();
            lblValEmail = new Label();
            lblTEmail = new Label();
            lblValPhone = new Label();
            lblTPhone = new Label();
            lblValFullName = new Label();
            lblTFullName = new Label();
            tabAssignments = new TabPage();
            dgvAssignments = new DataGridView();
            tabTimetable = new TabPage();
            dgvTimetable = new DataGridView();
            tabUserAccount = new TabPage();
            pnlUserAccount = new Panel();
            btnCreateUserAccount = new Button();
            lblValUserStatus = new Label();
            lblTUserStatus = new Label();
            lblValUsername = new Label();
            lblTUsername = new Label();
            lblUserAccountTitle = new Label();
            btnEditTeacher = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabOverview.SuspendLayout();
            pnlOverview.SuspendLayout();
            tabAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            tabTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).BeginInit();
            tabUserAccount.SuspendLayout();
            pnlUserAccount.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1029, 71);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(406, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(209, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Teacher Profile";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOverview);
            tabControl.Controls.Add(tabAssignments);
            tabControl.Controls.Add(tabTimetable);
            tabControl.Controls.Add(tabUserAccount);
            tabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl.Location = new Point(23, 107);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(983, 613);
            tabControl.TabIndex = 1;
            // 
            // tabOverview
            // 
            tabOverview.BackColor = Color.White;
            tabOverview.Controls.Add(pnlOverview);
            tabOverview.Location = new Point(4, 30);
            tabOverview.Margin = new Padding(3, 4, 3, 4);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3, 4, 3, 4);
            tabOverview.Size = new Size(975, 579);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "Overview";
            // 
            // pnlOverview
            // 
            pnlOverview.Controls.Add(lblValAbout);
            pnlOverview.Controls.Add(lblTAbout);
            pnlOverview.Controls.Add(lblValStatus);
            pnlOverview.Controls.Add(lblTStatus);
            pnlOverview.Controls.Add(lblValHireDate);
            pnlOverview.Controls.Add(lblTHireDate);
            pnlOverview.Controls.Add(lblValQualification);
            pnlOverview.Controls.Add(lblTQualification);
            pnlOverview.Controls.Add(lblValSpecialization);
            pnlOverview.Controls.Add(lblTSpecialization);
            pnlOverview.Controls.Add(lblValGender);
            pnlOverview.Controls.Add(lblTGender);
            pnlOverview.Controls.Add(lblValAddress);
            pnlOverview.Controls.Add(lblTAddress);
            pnlOverview.Controls.Add(lblValEmail);
            pnlOverview.Controls.Add(lblTEmail);
            pnlOverview.Controls.Add(lblValPhone);
            pnlOverview.Controls.Add(lblTPhone);
            pnlOverview.Controls.Add(lblValFullName);
            pnlOverview.Controls.Add(lblTFullName);
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.Location = new Point(3, 4);
            pnlOverview.Margin = new Padding(3, 4, 3, 4);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Padding = new Padding(29, 33, 29, 33);
            pnlOverview.Size = new Size(969, 571);
            pnlOverview.TabIndex = 0;
            // 
            // lblValAbout
            // 
            lblValAbout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValAbout.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAbout.Location = new Point(251, 453);
            lblValAbout.Name = "lblValAbout";
            lblValAbout.Size = new Size(663, 60);
            lblValAbout.TabIndex = 19;
            lblValAbout.Text = "---";
            // 
            // lblTAbout
            // 
            lblTAbout.AutoSize = true;
            lblTAbout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAbout.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAbout.Location = new Point(29, 453);
            lblTAbout.Name = "lblTAbout";
            lblTAbout.Size = new Size(79, 21);
            lblTAbout.TabIndex = 18;
            lblTAbout.Text = "Remarks:";
            // 
            // lblValStatus
            // 
            lblValStatus.AutoSize = true;
            lblValStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValStatus.ForeColor = Color.FromArgb(39, 174, 96);
            lblValStatus.Location = new Point(251, 407);
            lblValStatus.Name = "lblValStatus";
            lblValStatus.Size = new Size(28, 21);
            lblValStatus.TabIndex = 17;
            lblValStatus.Text = "---";
            // 
            // lblTStatus
            // 
            lblTStatus.AutoSize = true;
            lblTStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTStatus.ForeColor = Color.FromArgb(120, 130, 140);
            lblTStatus.Location = new Point(29, 407);
            lblTStatus.Name = "lblTStatus";
            lblTStatus.Size = new Size(163, 21);
            lblTStatus.TabIndex = 16;
            lblTStatus.Text = "Employment Status:";
            // 
            // lblValHireDate
            // 
            lblValHireDate.AutoSize = true;
            lblValHireDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValHireDate.ForeColor = Color.FromArgb(33, 37, 41);
            lblValHireDate.Location = new Point(251, 360);
            lblValHireDate.Name = "lblValHireDate";
            lblValHireDate.Size = new Size(28, 21);
            lblValHireDate.TabIndex = 15;
            lblValHireDate.Text = "---";
            // 
            // lblTHireDate
            // 
            lblTHireDate.AutoSize = true;
            lblTHireDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTHireDate.ForeColor = Color.FromArgb(120, 130, 140);
            lblTHireDate.Location = new Point(29, 360);
            lblTHireDate.Name = "lblTHireDate";
            lblTHireDate.Size = new Size(86, 21);
            lblTHireDate.TabIndex = 14;
            lblTHireDate.Text = "Hire Date:";
            // 
            // lblValQualification
            // 
            lblValQualification.AutoSize = true;
            lblValQualification.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValQualification.ForeColor = Color.FromArgb(33, 37, 41);
            lblValQualification.Location = new Point(251, 313);
            lblValQualification.Name = "lblValQualification";
            lblValQualification.Size = new Size(28, 21);
            lblValQualification.TabIndex = 13;
            lblValQualification.Text = "---";
            // 
            // lblTQualification
            // 
            lblTQualification.AutoSize = true;
            lblTQualification.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTQualification.ForeColor = Color.FromArgb(120, 130, 140);
            lblTQualification.Location = new Point(29, 313);
            lblTQualification.Name = "lblTQualification";
            lblTQualification.Size = new Size(114, 21);
            lblTQualification.TabIndex = 12;
            lblTQualification.Text = "Qualification:";
            // 
            // lblValSpecialization
            // 
            lblValSpecialization.AutoSize = true;
            lblValSpecialization.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValSpecialization.ForeColor = Color.FromArgb(33, 37, 41);
            lblValSpecialization.Location = new Point(251, 267);
            lblValSpecialization.Name = "lblValSpecialization";
            lblValSpecialization.Size = new Size(28, 21);
            lblValSpecialization.TabIndex = 11;
            lblValSpecialization.Text = "---";
            // 
            // lblTSpecialization
            // 
            lblTSpecialization.AutoSize = true;
            lblTSpecialization.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTSpecialization.ForeColor = Color.FromArgb(120, 130, 140);
            lblTSpecialization.Location = new Point(29, 267);
            lblTSpecialization.Name = "lblTSpecialization";
            lblTSpecialization.Size = new Size(122, 21);
            lblTSpecialization.TabIndex = 10;
            lblTSpecialization.Text = "Specialization:";
            // 
            // lblValGender
            // 
            lblValGender.AutoSize = true;
            lblValGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValGender.ForeColor = Color.FromArgb(33, 37, 41);
            lblValGender.Location = new Point(251, 220);
            lblValGender.Name = "lblValGender";
            lblValGender.Size = new Size(28, 21);
            lblValGender.TabIndex = 9;
            lblValGender.Text = "---";
            // 
            // lblTGender
            // 
            lblTGender.AutoSize = true;
            lblTGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTGender.ForeColor = Color.FromArgb(120, 130, 140);
            lblTGender.Location = new Point(29, 220);
            lblTGender.Name = "lblTGender";
            lblTGender.Size = new Size(70, 21);
            lblTGender.TabIndex = 8;
            lblTGender.Text = "Gender:";
            // 
            // lblValAddress
            // 
            lblValAddress.AutoSize = true;
            lblValAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValAddress.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAddress.Location = new Point(251, 173);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(28, 21);
            lblValAddress.TabIndex = 7;
            lblValAddress.Text = "---";
            // 
            // lblTAddress
            // 
            lblTAddress.AutoSize = true;
            lblTAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAddress.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAddress.Location = new Point(29, 173);
            lblTAddress.Name = "lblTAddress";
            lblTAddress.Size = new Size(74, 21);
            lblTAddress.TabIndex = 6;
            lblTAddress.Text = "Address:";
            // 
            // lblValEmail
            // 
            lblValEmail.AutoSize = true;
            lblValEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblValEmail.Location = new Point(251, 127);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(28, 21);
            lblValEmail.TabIndex = 5;
            lblValEmail.Text = "---";
            // 
            // lblTEmail
            // 
            lblTEmail.AutoSize = true;
            lblTEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTEmail.ForeColor = Color.FromArgb(120, 130, 140);
            lblTEmail.Location = new Point(29, 127);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(121, 21);
            lblTEmail.TabIndex = 4;
            lblTEmail.Text = "Email Address:";
            // 
            // lblValPhone
            // 
            lblValPhone.AutoSize = true;
            lblValPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValPhone.ForeColor = Color.FromArgb(33, 37, 41);
            lblValPhone.Location = new Point(251, 80);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(28, 21);
            lblValPhone.TabIndex = 3;
            lblValPhone.Text = "---";
            // 
            // lblTPhone
            // 
            lblTPhone.AutoSize = true;
            lblTPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPhone.ForeColor = Color.FromArgb(120, 130, 140);
            lblTPhone.Location = new Point(29, 80);
            lblTPhone.Name = "lblTPhone";
            lblTPhone.Size = new Size(131, 21);
            lblTPhone.TabIndex = 2;
            lblTPhone.Text = "Phone Number:";
            // 
            // lblValFullName
            // 
            lblValFullName.AutoSize = true;
            lblValFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValFullName.ForeColor = Color.FromArgb(44, 62, 80);
            lblValFullName.Location = new Point(251, 33);
            lblValFullName.Name = "lblValFullName";
            lblValFullName.Size = new Size(36, 28);
            lblValFullName.TabIndex = 1;
            lblValFullName.Text = "---";
            // 
            // lblTFullName
            // 
            lblTFullName.AutoSize = true;
            lblTFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTFullName.ForeColor = Color.FromArgb(120, 130, 140);
            lblTFullName.Location = new Point(29, 36);
            lblTFullName.Name = "lblTFullName";
            lblTFullName.Size = new Size(92, 21);
            lblTFullName.TabIndex = 0;
            lblTFullName.Text = "Full Name:";
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.White;
            tabAssignments.Controls.Add(dgvAssignments);
            tabAssignments.Location = new Point(4, 30);
            tabAssignments.Margin = new Padding(3, 4, 3, 4);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Padding = new Padding(3, 4, 3, 4);
            tabAssignments.Size = new Size(975, 579);
            tabAssignments.TabIndex = 1;
            tabAssignments.Text = "Teaching Assignments";
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignments.ColumnHeadersHeight = 29;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAssignments.Dock = DockStyle.Fill;
            dgvAssignments.Location = new Point(3, 4);
            dgvAssignments.Margin = new Padding(3, 4, 3, 4);
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 51;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(969, 571);
            dgvAssignments.TabIndex = 0;
            // 
            // tabTimetable
            // 
            tabTimetable.BackColor = Color.White;
            tabTimetable.Controls.Add(dgvTimetable);
            tabTimetable.Location = new Point(4, 30);
            tabTimetable.Margin = new Padding(3, 4, 3, 4);
            tabTimetable.Name = "tabTimetable";
            tabTimetable.Padding = new Padding(3, 4, 3, 4);
            tabTimetable.Size = new Size(975, 579);
            tabTimetable.TabIndex = 2;
            tabTimetable.Text = "Weekly Schedule";
            // 
            // dgvTimetable
            // 
            dgvTimetable.AllowUserToAddRows = false;
            dgvTimetable.AllowUserToDeleteRows = false;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimetable.BackgroundColor = Color.White;
            dgvTimetable.BorderStyle = BorderStyle.None;
            dgvTimetable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTimetable.ColumnHeadersHeight = 29;
            dgvTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTimetable.Dock = DockStyle.Fill;
            dgvTimetable.Location = new Point(3, 4);
            dgvTimetable.Margin = new Padding(3, 4, 3, 4);
            dgvTimetable.MultiSelect = false;
            dgvTimetable.Name = "dgvTimetable";
            dgvTimetable.ReadOnly = true;
            dgvTimetable.RowHeadersVisible = false;
            dgvTimetable.RowHeadersWidth = 51;
            dgvTimetable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimetable.Size = new Size(969, 571);
            dgvTimetable.TabIndex = 0;
            // 
            // tabUserAccount
            // 
            tabUserAccount.BackColor = Color.White;
            tabUserAccount.Controls.Add(pnlUserAccount);
            tabUserAccount.Location = new Point(4, 30);
            tabUserAccount.Margin = new Padding(3, 4, 3, 4);
            tabUserAccount.Name = "tabUserAccount";
            tabUserAccount.Padding = new Padding(3, 4, 3, 4);
            tabUserAccount.Size = new Size(975, 579);
            tabUserAccount.TabIndex = 3;
            tabUserAccount.Text = "User Credentials";
            // 
            // pnlUserAccount
            // 
            pnlUserAccount.Controls.Add(btnCreateUserAccount);
            pnlUserAccount.Controls.Add(lblValUserStatus);
            pnlUserAccount.Controls.Add(lblTUserStatus);
            pnlUserAccount.Controls.Add(lblValUsername);
            pnlUserAccount.Controls.Add(lblTUsername);
            pnlUserAccount.Controls.Add(lblUserAccountTitle);
            pnlUserAccount.Dock = DockStyle.Fill;
            pnlUserAccount.Location = new Point(3, 4);
            pnlUserAccount.Margin = new Padding(3, 4, 3, 4);
            pnlUserAccount.Name = "pnlUserAccount";
            pnlUserAccount.Padding = new Padding(34, 40, 34, 40);
            pnlUserAccount.Size = new Size(969, 571);
            pnlUserAccount.TabIndex = 0;
            // 
            // btnCreateUserAccount
            // 
            btnCreateUserAccount.BackColor = Color.FromArgb(41, 128, 185);
            btnCreateUserAccount.Cursor = Cursors.Hand;
            btnCreateUserAccount.FlatAppearance.BorderSize = 0;
            btnCreateUserAccount.FlatStyle = FlatStyle.Popup;
            btnCreateUserAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCreateUserAccount.ForeColor = Color.White;
            btnCreateUserAccount.Location = new Point(266, 286);
            btnCreateUserAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateUserAccount.Name = "btnCreateUserAccount";
            btnCreateUserAccount.Size = new Size(293, 49);
            btnCreateUserAccount.TabIndex = 5;
            btnCreateUserAccount.Text = "Generate Teacher Login Account";
            btnCreateUserAccount.UseVisualStyleBackColor = false;
            btnCreateUserAccount.Click += BtnCreateUserAccount_Click;
            // 
            // lblValUserStatus
            // 
            lblValUserStatus.AutoSize = true;
            lblValUserStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValUserStatus.ForeColor = Color.FromArgb(33, 37, 41);
            lblValUserStatus.Location = new Point(206, 147);
            lblValUserStatus.Name = "lblValUserStatus";
            lblValUserStatus.Size = new Size(28, 21);
            lblValUserStatus.TabIndex = 4;
            lblValUserStatus.Text = "---";
            // 
            // lblTUserStatus
            // 
            lblTUserStatus.AutoSize = true;
            lblTUserStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTUserStatus.ForeColor = Color.FromArgb(120, 130, 140);
            lblTUserStatus.Location = new Point(34, 147);
            lblTUserStatus.Name = "lblTUserStatus";
            lblTUserStatus.Size = new Size(128, 21);
            lblTUserStatus.TabIndex = 3;
            lblTUserStatus.Text = "Account Status:";
            // 
            // lblValUsername
            // 
            lblValUsername.AutoSize = true;
            lblValUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValUsername.ForeColor = Color.FromArgb(41, 128, 185);
            lblValUsername.Location = new Point(206, 100);
            lblValUsername.Name = "lblValUsername";
            lblValUsername.Size = new Size(28, 21);
            lblValUsername.TabIndex = 2;
            lblValUsername.Text = "---";
            // 
            // lblTUsername
            // 
            lblTUsername.AutoSize = true;
            lblTUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTUsername.ForeColor = Color.FromArgb(120, 130, 140);
            lblTUsername.Location = new Point(34, 100);
            lblTUsername.Name = "lblTUsername";
            lblTUsername.Size = new Size(91, 21);
            lblTUsername.TabIndex = 1;
            lblTUsername.Text = "Username:";
            // 
            // lblUserAccountTitle
            // 
            lblUserAccountTitle.AutoSize = true;
            lblUserAccountTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserAccountTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblUserAccountTitle.Location = new Point(34, 40);
            lblUserAccountTitle.Name = "lblUserAccountTitle";
            lblUserAccountTitle.Size = new Size(312, 28);
            lblUserAccountTitle.TabIndex = 0;
            lblUserAccountTitle.Text = "Teacher System Access Account";
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.BackColor = Color.FromArgb(41, 128, 185);
            btnEditTeacher.Cursor = Cursors.Hand;
            btnEditTeacher.FlatAppearance.BorderSize = 0;
            btnEditTeacher.FlatStyle = FlatStyle.Flat;
            btnEditTeacher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditTeacher.ForeColor = Color.White;
            btnEditTeacher.Location = new Point(703, 740);
            btnEditTeacher.Margin = new Padding(3, 4, 3, 4);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(166, 48);
            btnEditTeacher.TabIndex = 2;
            btnEditTeacher.Text = "Edit Teacher Info";
            btnEditTeacher.UseVisualStyleBackColor = false;
            btnEditTeacher.Click += BtnEditTeacher_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(880, 740);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 48);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1029, 807);
            Controls.Add(btnClose);
            Controls.Add(btnEditTeacher);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTeacherProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Teacher Profile";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControl.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            pnlOverview.ResumeLayout(false);
            pnlOverview.PerformLayout();
            tabAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            tabTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).EndInit();
            tabUserAccount.ResumeLayout(false);
            pnlUserAccount.ResumeLayout(false);
            pnlUserAccount.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Label lblTFullName;
        private System.Windows.Forms.Label lblValFullName;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblValPhone;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.Label lblValAddress;
        private System.Windows.Forms.Label lblTGender;
        private System.Windows.Forms.Label lblValGender;
        private System.Windows.Forms.Label lblTSpecialization;
        private System.Windows.Forms.Label lblValSpecialization;
        private System.Windows.Forms.Label lblTQualification;
        private System.Windows.Forms.Label lblValQualification;
        private System.Windows.Forms.Label lblTHireDate;
        private System.Windows.Forms.Label lblValHireDate;
        private System.Windows.Forms.Label lblTStatus;
        private System.Windows.Forms.Label lblValStatus;
        private System.Windows.Forms.Label lblTAbout;
        private System.Windows.Forms.Label lblValAbout;
        private System.Windows.Forms.TabPage tabAssignments;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.TabPage tabUserAccount;
        private System.Windows.Forms.Panel pnlUserAccount;
        private System.Windows.Forms.Label lblUserAccountTitle;
        private System.Windows.Forms.Label lblTUsername;
        private System.Windows.Forms.Label lblValUsername;
        private System.Windows.Forms.Label lblTUserStatus;
        private System.Windows.Forms.Label lblValUserStatus;
        private System.Windows.Forms.Button btnCreateUserAccount;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnClose;
    }
}
