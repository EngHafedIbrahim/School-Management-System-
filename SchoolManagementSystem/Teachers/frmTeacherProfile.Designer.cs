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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.lblValAbout = new System.Windows.Forms.Label();
            this.lblTAbout = new System.Windows.Forms.Label();
            this.lblValStatus = new System.Windows.Forms.Label();
            this.lblTStatus = new System.Windows.Forms.Label();
            this.lblValHireDate = new System.Windows.Forms.Label();
            this.lblTHireDate = new System.Windows.Forms.Label();
            this.lblValQualification = new System.Windows.Forms.Label();
            this.lblTQualification = new System.Windows.Forms.Label();
            this.lblValSpecialization = new System.Windows.Forms.Label();
            this.lblTSpecialization = new System.Windows.Forms.Label();
            this.lblValGender = new System.Windows.Forms.Label();
            this.lblTGender = new System.Windows.Forms.Label();
            this.lblValAddress = new System.Windows.Forms.Label();
            this.lblTAddress = new System.Windows.Forms.Label();
            this.lblValEmail = new System.Windows.Forms.Label();
            this.lblTEmail = new System.Windows.Forms.Label();
            this.lblValPhone = new System.Windows.Forms.Label();
            this.lblTPhone = new System.Windows.Forms.Label();
            this.lblValFullName = new System.Windows.Forms.Label();
            this.lblTFullName = new System.Windows.Forms.Label();
            this.tabAssignments = new System.Windows.Forms.TabPage();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.tabUserAccount = new System.Windows.Forms.TabPage();
            this.pnlUserAccount = new System.Windows.Forms.Panel();
            this.btnCreateUserAccount = new System.Windows.Forms.Button();
            this.lblValUserStatus = new System.Windows.Forms.Label();
            this.lblTUserStatus = new System.Windows.Forms.Label();
            this.lblValUsername = new System.Windows.Forms.Label();
            this.lblTUsername = new System.Windows.Forms.Label();
            this.lblUserAccountTitle = new System.Windows.Forms.Label();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.tabAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.tabTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.tabUserAccount.SuspendLayout();
            this.pnlUserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(900, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(519, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Instructor profile, assigned courses, weekly schedule, and authentication credentials.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(288, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Faculty Member Profile";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOverview);
            this.tabControl.Controls.Add(this.tabAssignments);
            this.tabControl.Controls.Add(this.tabTimetable);
            this.tabControl.Controls.Add(this.tabUserAccount);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(20, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 460);
            this.tabControl.TabIndex = 1;
            // 
            // tabOverview
            // 
            this.tabOverview.BackColor = System.Drawing.Color.White;
            this.tabOverview.Controls.Add(this.pnlOverview);
            this.tabOverview.Location = new System.Drawing.Point(4, 26);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(852, 430);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.lblValAbout);
            this.pnlOverview.Controls.Add(this.lblTAbout);
            this.pnlOverview.Controls.Add(this.lblValStatus);
            this.pnlOverview.Controls.Add(this.lblTStatus);
            this.pnlOverview.Controls.Add(this.lblValHireDate);
            this.pnlOverview.Controls.Add(this.lblTHireDate);
            this.pnlOverview.Controls.Add(this.lblValQualification);
            this.pnlOverview.Controls.Add(this.lblTQualification);
            this.pnlOverview.Controls.Add(this.lblValSpecialization);
            this.pnlOverview.Controls.Add(this.lblTSpecialization);
            this.pnlOverview.Controls.Add(this.lblValGender);
            this.pnlOverview.Controls.Add(this.lblTGender);
            this.pnlOverview.Controls.Add(this.lblValAddress);
            this.pnlOverview.Controls.Add(this.lblTAddress);
            this.pnlOverview.Controls.Add(this.lblValEmail);
            this.pnlOverview.Controls.Add(this.lblTEmail);
            this.pnlOverview.Controls.Add(this.lblValPhone);
            this.pnlOverview.Controls.Add(this.lblTPhone);
            this.pnlOverview.Controls.Add(this.lblValFullName);
            this.pnlOverview.Controls.Add(this.lblTFullName);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(3, 3);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Padding = new System.Windows.Forms.Padding(25);
            this.pnlOverview.Size = new System.Drawing.Size(846, 424);
            this.pnlOverview.TabIndex = 0;
            // 
            // lblValAbout
            // 
            this.lblValAbout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValAbout.Location = new System.Drawing.Point(220, 340);
            this.lblValAbout.Name = "lblValAbout";
            this.lblValAbout.Size = new System.Drawing.Size(580, 45);
            this.lblValAbout.TabIndex = 19;
            this.lblValAbout.Text = "---";
            // 
            // lblTAbout
            // 
            this.lblTAbout.AutoSize = true;
            this.lblTAbout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTAbout.Location = new System.Drawing.Point(25, 340);
            this.lblTAbout.Name = "lblTAbout";
            this.lblTAbout.Size = new System.Drawing.Size(65, 17);
            this.lblTAbout.TabIndex = 18;
            this.lblTAbout.Text = "Remarks:";
            // 
            // lblValStatus
            // 
            this.lblValStatus.AutoSize = true;
            this.lblValStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblValStatus.Location = new System.Drawing.Point(220, 305);
            this.lblValStatus.Name = "lblValStatus";
            this.lblValStatus.Size = new System.Drawing.Size(23, 17);
            this.lblValStatus.TabIndex = 17;
            this.lblValStatus.Text = "---";
            // 
            // lblTStatus
            // 
            this.lblTStatus.AutoSize = true;
            this.lblTStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTStatus.Location = new System.Drawing.Point(25, 305);
            this.lblTStatus.Name = "lblTStatus";
            this.lblTStatus.Size = new System.Drawing.Size(132, 17);
            this.lblTStatus.TabIndex = 16;
            this.lblTStatus.Text = "Employment Status:";
            // 
            // lblValHireDate
            // 
            this.lblValHireDate.AutoSize = true;
            this.lblValHireDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValHireDate.Location = new System.Drawing.Point(220, 270);
            this.lblValHireDate.Name = "lblValHireDate";
            this.lblValHireDate.Size = new System.Drawing.Size(23, 17);
            this.lblValHireDate.TabIndex = 15;
            this.lblValHireDate.Text = "---";
            // 
            // lblTHireDate
            // 
            this.lblTHireDate.AutoSize = true;
            this.lblTHireDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTHireDate.Location = new System.Drawing.Point(25, 270);
            this.lblTHireDate.Name = "lblTHireDate";
            this.lblTHireDate.Size = new System.Drawing.Size(72, 17);
            this.lblTHireDate.TabIndex = 14;
            this.lblTHireDate.Text = "Hire Date:";
            // 
            // lblValQualification
            // 
            this.lblValQualification.AutoSize = true;
            this.lblValQualification.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValQualification.Location = new System.Drawing.Point(220, 235);
            this.lblValQualification.Name = "lblValQualification";
            this.lblValQualification.Size = new System.Drawing.Size(23, 17);
            this.lblValQualification.TabIndex = 13;
            this.lblValQualification.Text = "---";
            // 
            // lblTQualification
            // 
            this.lblTQualification.AutoSize = true;
            this.lblTQualification.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTQualification.Location = new System.Drawing.Point(25, 235);
            this.lblTQualification.Name = "lblTQualification";
            this.lblTQualification.Size = new System.Drawing.Size(92, 17);
            this.lblTQualification.TabIndex = 12;
            this.lblTQualification.Text = "Qualification:";
            // 
            // lblValSpecialization
            // 
            this.lblValSpecialization.AutoSize = true;
            this.lblValSpecialization.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValSpecialization.Location = new System.Drawing.Point(220, 200);
            this.lblValSpecialization.Name = "lblValSpecialization";
            this.lblValSpecialization.Size = new System.Drawing.Size(23, 17);
            this.lblValSpecialization.TabIndex = 11;
            this.lblValSpecialization.Text = "---";
            // 
            // lblTSpecialization
            // 
            this.lblTSpecialization.AutoSize = true;
            this.lblTSpecialization.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTSpecialization.Location = new System.Drawing.Point(25, 200);
            this.lblTSpecialization.Name = "lblTSpecialization";
            this.lblTSpecialization.Size = new System.Drawing.Size(98, 17);
            this.lblTSpecialization.TabIndex = 10;
            this.lblTSpecialization.Text = "Specialization:";
            // 
            // lblValGender
            // 
            this.lblValGender.AutoSize = true;
            this.lblValGender.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValGender.Location = new System.Drawing.Point(220, 165);
            this.lblValGender.Name = "lblValGender";
            this.lblValGender.Size = new System.Drawing.Size(23, 17);
            this.lblValGender.TabIndex = 9;
            this.lblValGender.Text = "---";
            // 
            // lblTGender
            // 
            this.lblTGender.AutoSize = true;
            this.lblTGender.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTGender.Location = new System.Drawing.Point(25, 165);
            this.lblTGender.Name = "lblTGender";
            this.lblTGender.Size = new System.Drawing.Size(58, 17);
            this.lblTGender.TabIndex = 8;
            this.lblTGender.Text = "Gender:";
            // 
            // lblValAddress
            // 
            this.lblValAddress.AutoSize = true;
            this.lblValAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValAddress.Location = new System.Drawing.Point(220, 130);
            this.lblValAddress.Name = "lblValAddress";
            this.lblValAddress.Size = new System.Drawing.Size(23, 17);
            this.lblValAddress.TabIndex = 7;
            this.lblValAddress.Text = "---";
            // 
            // lblTAddress
            // 
            this.lblTAddress.AutoSize = true;
            this.lblTAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTAddress.Location = new System.Drawing.Point(25, 130);
            this.lblTAddress.Name = "lblTAddress";
            this.lblTAddress.Size = new System.Drawing.Size(61, 17);
            this.lblTAddress.TabIndex = 6;
            this.lblTAddress.Text = "Address:";
            // 
            // lblValEmail
            // 
            this.lblValEmail.AutoSize = true;
            this.lblValEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValEmail.Location = new System.Drawing.Point(220, 95);
            this.lblValEmail.Name = "lblValEmail";
            this.lblValEmail.Size = new System.Drawing.Size(23, 17);
            this.lblValEmail.TabIndex = 5;
            this.lblValEmail.Text = "---";
            // 
            // lblTEmail
            // 
            this.lblTEmail.AutoSize = true;
            this.lblTEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTEmail.Location = new System.Drawing.Point(25, 95);
            this.lblTEmail.Name = "lblTEmail";
            this.lblTEmail.Size = new System.Drawing.Size(101, 17);
            this.lblTEmail.TabIndex = 4;
            this.lblTEmail.Text = "Email Address:";
            // 
            // lblValPhone
            // 
            this.lblValPhone.AutoSize = true;
            this.lblValPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValPhone.Location = new System.Drawing.Point(220, 60);
            this.lblValPhone.Name = "lblValPhone";
            this.lblValPhone.Size = new System.Drawing.Size(23, 17);
            this.lblValPhone.TabIndex = 3;
            this.lblValPhone.Text = "---";
            // 
            // lblTPhone
            // 
            this.lblTPhone.AutoSize = true;
            this.lblTPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTPhone.Location = new System.Drawing.Point(25, 60);
            this.lblTPhone.Name = "lblTPhone";
            this.lblTPhone.Size = new System.Drawing.Size(105, 17);
            this.lblTPhone.TabIndex = 2;
            this.lblTPhone.Text = "Phone Number:";
            // 
            // lblValFullName
            // 
            this.lblValFullName.AutoSize = true;
            this.lblValFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblValFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblValFullName.Location = new System.Drawing.Point(220, 25);
            this.lblValFullName.Name = "lblValFullName";
            this.lblValFullName.Size = new System.Drawing.Size(28, 21);
            this.lblValFullName.TabIndex = 1;
            this.lblValFullName.Text = "---";
            // 
            // lblTFullName
            // 
            this.lblTFullName.AutoSize = true;
            this.lblTFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTFullName.Location = new System.Drawing.Point(25, 27);
            this.lblTFullName.Name = "lblTFullName";
            this.lblTFullName.Size = new System.Drawing.Size(75, 17);
            this.lblTFullName.TabIndex = 0;
            this.lblTFullName.Text = "Full Name:";
            // 
            // tabAssignments
            // 
            this.tabAssignments.BackColor = System.Drawing.Color.White;
            this.tabAssignments.Controls.Add(this.dgvAssignments);
            this.tabAssignments.Location = new System.Drawing.Point(4, 26);
            this.tabAssignments.Name = "tabAssignments";
            this.tabAssignments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignments.Size = new System.Drawing.Size(852, 430);
            this.tabAssignments.TabIndex = 1;
            this.tabAssignments.Text = "Teaching Assignments";
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignments.Location = new System.Drawing.Point(3, 3);
            this.dgvAssignments.MultiSelect = false;
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.RowHeadersVisible = false;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(846, 424);
            this.dgvAssignments.TabIndex = 0;
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.Color.White;
            this.tabTimetable.Controls.Add(this.dgvTimetable);
            this.tabTimetable.Location = new System.Drawing.Point(4, 26);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(852, 430);
            this.tabTimetable.TabIndex = 2;
            this.tabTimetable.Text = "Weekly Schedule";
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToDeleteRows = false;
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTimetable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimetable.Location = new System.Drawing.Point(3, 3);
            this.dgvTimetable.MultiSelect = false;
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersVisible = false;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(846, 424);
            this.dgvTimetable.TabIndex = 0;
            // 
            // tabUserAccount
            // 
            this.tabUserAccount.BackColor = System.Drawing.Color.White;
            this.tabUserAccount.Controls.Add(this.pnlUserAccount);
            this.tabUserAccount.Location = new System.Drawing.Point(4, 26);
            this.tabUserAccount.Name = "tabUserAccount";
            this.tabUserAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserAccount.Size = new System.Drawing.Size(852, 430);
            this.tabUserAccount.TabIndex = 3;
            this.tabUserAccount.Text = "User Credentials";
            // 
            // pnlUserAccount
            // 
            this.pnlUserAccount.Controls.Add(this.btnCreateUserAccount);
            this.pnlUserAccount.Controls.Add(this.lblValUserStatus);
            this.pnlUserAccount.Controls.Add(this.lblTUserStatus);
            this.pnlUserAccount.Controls.Add(this.lblValUsername);
            this.pnlUserAccount.Controls.Add(this.lblTUsername);
            this.pnlUserAccount.Controls.Add(this.lblUserAccountTitle);
            this.pnlUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserAccount.Location = new System.Drawing.Point(3, 3);
            this.pnlUserAccount.Name = "pnlUserAccount";
            this.pnlUserAccount.Padding = new System.Windows.Forms.Padding(30);
            this.pnlUserAccount.Size = new System.Drawing.Size(846, 424);
            this.pnlUserAccount.TabIndex = 0;
            // 
            // btnCreateUserAccount
            // 
            this.btnCreateUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateUserAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUserAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUserAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserAccount.Location = new System.Drawing.Point(30, 160);
            this.btnCreateUserAccount.Name = "btnCreateUserAccount";
            this.btnCreateUserAccount.Size = new System.Drawing.Size(220, 36);
            this.btnCreateUserAccount.TabIndex = 5;
            this.btnCreateUserAccount.Text = "Generate Teacher Login Account";
            this.btnCreateUserAccount.UseVisualStyleBackColor = false;
            this.btnCreateUserAccount.Click += new System.EventHandler(this.BtnCreateUserAccount_Click);
            // 
            // lblValUserStatus
            // 
            this.lblValUserStatus.AutoSize = true;
            this.lblValUserStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblValUserStatus.Location = new System.Drawing.Point(180, 110);
            this.lblValUserStatus.Name = "lblValUserStatus";
            this.lblValUserStatus.Size = new System.Drawing.Size(23, 17);
            this.lblValUserStatus.TabIndex = 4;
            this.lblValUserStatus.Text = "---";
            // 
            // lblTUserStatus
            // 
            this.lblTUserStatus.AutoSize = true;
            this.lblTUserStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTUserStatus.Location = new System.Drawing.Point(30, 110);
            this.lblTUserStatus.Name = "lblTUserStatus";
            this.lblTUserStatus.Size = new System.Drawing.Size(107, 17);
            this.lblTUserStatus.TabIndex = 3;
            this.lblTUserStatus.Text = "Account Status:";
            // 
            // lblValUsername
            // 
            this.lblValUsername.AutoSize = true;
            this.lblValUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblValUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblValUsername.Location = new System.Drawing.Point(180, 75);
            this.lblValUsername.Name = "lblValUsername";
            this.lblValUsername.Size = new System.Drawing.Size(23, 17);
            this.lblValUsername.TabIndex = 2;
            this.lblValUsername.Text = "---";
            // 
            // lblTUsername
            // 
            this.lblTUsername.AutoSize = true;
            this.lblTUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblTUsername.Location = new System.Drawing.Point(30, 75);
            this.lblTUsername.Name = "lblTUsername";
            this.lblTUsername.Size = new System.Drawing.Size(73, 17);
            this.lblTUsername.TabIndex = 1;
            this.lblTUsername.Text = "Username:";
            // 
            // lblUserAccountTitle
            // 
            this.lblUserAccountTitle.AutoSize = true;
            this.lblUserAccountTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserAccountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUserAccountTitle.Location = new System.Drawing.Point(30, 30);
            this.lblUserAccountTitle.Name = "lblUserAccountTitle";
            this.lblUserAccountTitle.Size = new System.Drawing.Size(262, 21);
            this.lblUserAccountTitle.TabIndex = 0;
            this.lblUserAccountTitle.Text = "Teacher System Access Account";
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTeacher.FlatAppearance.BorderSize = 0;
            this.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditTeacher.ForeColor = System.Drawing.Color.White;
            this.btnEditTeacher.Location = new System.Drawing.Point(615, 555);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(145, 36);
            this.btnEditTeacher.TabIndex = 2;
            this.btnEditTeacher.Text = "Edit Teacher Info";
            this.btnEditTeacher.UseVisualStyleBackColor = false;
            this.btnEditTeacher.Click += new System.EventHandler(this.BtnEditTeacher_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.Location = new System.Drawing.Point(770, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 605);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeacherProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teacher Profile";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.tabAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.tabTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.tabUserAccount.ResumeLayout(false);
            this.pnlUserAccount.ResumeLayout(false);
            this.pnlUserAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
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
