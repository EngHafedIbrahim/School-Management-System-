namespace SchoolManagementSystem.Students
{
    partial class frmStudentProfile
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
            lblValHealth = new Label();
            lblTHealth = new Label();
            lblValPrevSchool = new Label();
            lblTPrevSchool = new Label();
            lblValAdmDate = new Label();
            lblTAdmDate = new Label();
            lblValAddress = new Label();
            lblTAddress = new Label();
            lblValEmail = new Label();
            lblTEmail = new Label();
            lblValPhone = new Label();
            lblTPhone = new Label();
            lblValBlood = new Label();
            lblTBlood = new Label();
            lblValNationality = new Label();
            lblTNationality = new Label();
            lblValGender = new Label();
            lblTGender = new Label();
            lblValDOB = new Label();
            lblTDOB = new Label();
            lblValNationalID = new Label();
            lblTNationalID = new Label();
            lblValAdmNo = new Label();
            lblTAdmNo = new Label();
            lblValFullName = new Label();
            lblTFullName = new Label();
            tabParents = new TabPage();
            dgvParents = new DataGridView();
            pnlParentsTop = new Panel();
            btnUnlinkParent = new Button();
            btnLinkParent = new Button();
            tabEnrollment = new TabPage();
            dgvEnrollment = new DataGridView();
            tabAttendance = new TabPage();
            dgvAttendance = new DataGridView();
            tabGrades = new TabPage();
            dgvGrades = new DataGridView();
            tabFinancial = new TabPage();
            dgvFinancial = new DataGridView();
            btnEditProfile = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            tabControl.SuspendLayout();
            tabOverview.SuspendLayout();
            pnlOverview.SuspendLayout();
            tabParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParents).BeginInit();
            pnlParentsTop.SuspendLayout();
            tabEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).BeginInit();
            tabAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            tabFinancial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinancial).BeginInit();
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
            pnlHeader.Size = new Size(987, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(392, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(217, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Student  Profile";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOverview);
            tabControl.Controls.Add(tabParents);
            tabControl.Controls.Add(tabEnrollment);
            tabControl.Controls.Add(tabAttendance);
            tabControl.Controls.Add(tabGrades);
            tabControl.Controls.Add(tabFinancial);
            tabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl.Location = new Point(23, 107);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(943, 667);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabOverview
            // 
            tabOverview.BackColor = Color.White;
            tabOverview.Controls.Add(pnlOverview);
            tabOverview.Location = new Point(4, 30);
            tabOverview.Margin = new Padding(3, 4, 3, 4);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3, 4, 3, 4);
            tabOverview.Size = new Size(935, 633);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "Overview";
            // 
            // pnlOverview
            // 
            pnlOverview.AutoScroll = true;
            pnlOverview.Controls.Add(lblValHealth);
            pnlOverview.Controls.Add(lblTHealth);
            pnlOverview.Controls.Add(lblValPrevSchool);
            pnlOverview.Controls.Add(lblTPrevSchool);
            pnlOverview.Controls.Add(lblValAdmDate);
            pnlOverview.Controls.Add(lblTAdmDate);
            pnlOverview.Controls.Add(lblValAddress);
            pnlOverview.Controls.Add(lblTAddress);
            pnlOverview.Controls.Add(lblValEmail);
            pnlOverview.Controls.Add(lblTEmail);
            pnlOverview.Controls.Add(lblValPhone);
            pnlOverview.Controls.Add(lblTPhone);
            pnlOverview.Controls.Add(lblValBlood);
            pnlOverview.Controls.Add(lblTBlood);
            pnlOverview.Controls.Add(lblValNationality);
            pnlOverview.Controls.Add(lblTNationality);
            pnlOverview.Controls.Add(lblValGender);
            pnlOverview.Controls.Add(lblTGender);
            pnlOverview.Controls.Add(lblValDOB);
            pnlOverview.Controls.Add(lblTDOB);
            pnlOverview.Controls.Add(lblValNationalID);
            pnlOverview.Controls.Add(lblTNationalID);
            pnlOverview.Controls.Add(lblValAdmNo);
            pnlOverview.Controls.Add(lblTAdmNo);
            pnlOverview.Controls.Add(lblValFullName);
            pnlOverview.Controls.Add(lblTFullName);
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.Location = new Point(3, 4);
            pnlOverview.Margin = new Padding(3, 4, 3, 4);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Padding = new Padding(29, 33, 29, 33);
            pnlOverview.Size = new Size(929, 625);
            pnlOverview.TabIndex = 0;
            // 
            // lblValHealth
            // 
            lblValHealth.AutoSize = true;
            lblValHealth.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValHealth.ForeColor = Color.FromArgb(33, 37, 41);
            lblValHealth.Location = new Point(251, 539);
            lblValHealth.Name = "lblValHealth";
            lblValHealth.Size = new Size(28, 21);
            lblValHealth.TabIndex = 25;
            lblValHealth.Text = "---";
            // 
            // lblTHealth
            // 
            lblTHealth.AutoSize = true;
            lblTHealth.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTHealth.ForeColor = Color.FromArgb(120, 130, 140);
            lblTHealth.Location = new Point(29, 539);
            lblTHealth.Name = "lblTHealth";
            lblTHealth.Size = new Size(116, 21);
            lblTHealth.TabIndex = 24;
            lblTHealth.Text = "Health Status:";
            // 
            // lblValPrevSchool
            // 
            lblValPrevSchool.AutoSize = true;
            lblValPrevSchool.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValPrevSchool.ForeColor = Color.FromArgb(33, 37, 41);
            lblValPrevSchool.Location = new Point(251, 496);
            lblValPrevSchool.Name = "lblValPrevSchool";
            lblValPrevSchool.Size = new Size(28, 21);
            lblValPrevSchool.TabIndex = 23;
            lblValPrevSchool.Text = "---";
            // 
            // lblTPrevSchool
            // 
            lblTPrevSchool.AutoSize = true;
            lblTPrevSchool.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPrevSchool.ForeColor = Color.FromArgb(120, 130, 140);
            lblTPrevSchool.Location = new Point(29, 496);
            lblTPrevSchool.Name = "lblTPrevSchool";
            lblTPrevSchool.Size = new Size(136, 21);
            lblTPrevSchool.TabIndex = 22;
            lblTPrevSchool.Text = "Previous School:";
            // 
            // lblValAdmDate
            // 
            lblValAdmDate.AutoSize = true;
            lblValAdmDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValAdmDate.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAdmDate.Location = new Point(251, 453);
            lblValAdmDate.Name = "lblValAdmDate";
            lblValAdmDate.Size = new Size(28, 21);
            lblValAdmDate.TabIndex = 21;
            lblValAdmDate.Text = "---";
            // 
            // lblTAdmDate
            // 
            lblTAdmDate.AutoSize = true;
            lblTAdmDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAdmDate.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAdmDate.Location = new Point(29, 453);
            lblTAdmDate.Name = "lblTAdmDate";
            lblTAdmDate.Size = new Size(134, 21);
            lblTAdmDate.TabIndex = 20;
            lblTAdmDate.Text = "Admission Date:";
            // 
            // lblValAddress
            // 
            lblValAddress.AutoSize = true;
            lblValAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValAddress.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAddress.Location = new Point(251, 411);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(28, 21);
            lblValAddress.TabIndex = 19;
            lblValAddress.Text = "---";
            // 
            // lblTAddress
            // 
            lblTAddress.AutoSize = true;
            lblTAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAddress.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAddress.Location = new Point(29, 411);
            lblTAddress.Name = "lblTAddress";
            lblTAddress.Size = new Size(163, 21);
            lblTAddress.TabIndex = 18;
            lblTAddress.Text = "Residential Address:";
            // 
            // lblValEmail
            // 
            lblValEmail.AutoSize = true;
            lblValEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblValEmail.Location = new Point(251, 368);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(28, 21);
            lblValEmail.TabIndex = 17;
            lblValEmail.Text = "---";
            // 
            // lblTEmail
            // 
            lblTEmail.AutoSize = true;
            lblTEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTEmail.ForeColor = Color.FromArgb(120, 130, 140);
            lblTEmail.Location = new Point(29, 368);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(121, 21);
            lblTEmail.TabIndex = 16;
            lblTEmail.Text = "Email Address:";
            // 
            // lblValPhone
            // 
            lblValPhone.AutoSize = true;
            lblValPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValPhone.ForeColor = Color.FromArgb(33, 37, 41);
            lblValPhone.Location = new Point(251, 325);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(28, 21);
            lblValPhone.TabIndex = 15;
            lblValPhone.Text = "---";
            // 
            // lblTPhone
            // 
            lblTPhone.AutoSize = true;
            lblTPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPhone.ForeColor = Color.FromArgb(120, 130, 140);
            lblTPhone.Location = new Point(29, 325);
            lblTPhone.Name = "lblTPhone";
            lblTPhone.Size = new Size(131, 21);
            lblTPhone.TabIndex = 14;
            lblTPhone.Text = "Phone Number:";
            // 
            // lblValBlood
            // 
            lblValBlood.AutoSize = true;
            lblValBlood.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValBlood.ForeColor = Color.FromArgb(33, 37, 41);
            lblValBlood.Location = new Point(251, 283);
            lblValBlood.Name = "lblValBlood";
            lblValBlood.Size = new Size(28, 21);
            lblValBlood.TabIndex = 13;
            lblValBlood.Text = "---";
            // 
            // lblTBlood
            // 
            lblTBlood.AutoSize = true;
            lblTBlood.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTBlood.ForeColor = Color.FromArgb(120, 130, 140);
            lblTBlood.Location = new Point(29, 283);
            lblTBlood.Name = "lblTBlood";
            lblTBlood.Size = new Size(99, 21);
            lblTBlood.TabIndex = 12;
            lblTBlood.Text = "Blood Type:";
            // 
            // lblValNationality
            // 
            lblValNationality.AutoSize = true;
            lblValNationality.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValNationality.ForeColor = Color.FromArgb(33, 37, 41);
            lblValNationality.Location = new Point(251, 240);
            lblValNationality.Name = "lblValNationality";
            lblValNationality.Size = new Size(28, 21);
            lblValNationality.TabIndex = 11;
            lblValNationality.Text = "---";
            // 
            // lblTNationality
            // 
            lblTNationality.AutoSize = true;
            lblTNationality.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTNationality.ForeColor = Color.FromArgb(120, 130, 140);
            lblTNationality.Location = new Point(29, 240);
            lblTNationality.Name = "lblTNationality";
            lblTNationality.Size = new Size(101, 21);
            lblTNationality.TabIndex = 10;
            lblTNationality.Text = "Nationality:";
            // 
            // lblValGender
            // 
            lblValGender.AutoSize = true;
            lblValGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValGender.ForeColor = Color.FromArgb(33, 37, 41);
            lblValGender.Location = new Point(251, 197);
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
            lblTGender.Location = new Point(29, 197);
            lblTGender.Name = "lblTGender";
            lblTGender.Size = new Size(70, 21);
            lblTGender.TabIndex = 8;
            lblTGender.Text = "Gender:";
            // 
            // lblValDOB
            // 
            lblValDOB.AutoSize = true;
            lblValDOB.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValDOB.ForeColor = Color.FromArgb(33, 37, 41);
            lblValDOB.Location = new Point(251, 155);
            lblValDOB.Name = "lblValDOB";
            lblValDOB.Size = new Size(28, 21);
            lblValDOB.TabIndex = 7;
            lblValDOB.Text = "---";
            // 
            // lblTDOB
            // 
            lblTDOB.AutoSize = true;
            lblTDOB.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTDOB.ForeColor = Color.FromArgb(120, 130, 140);
            lblTDOB.Location = new Point(29, 155);
            lblTDOB.Name = "lblTDOB";
            lblTDOB.Size = new Size(111, 21);
            lblTDOB.TabIndex = 6;
            lblTDOB.Text = "Date of Birth:";
            // 
            // lblValNationalID
            // 
            lblValNationalID.AutoSize = true;
            lblValNationalID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValNationalID.ForeColor = Color.FromArgb(33, 37, 41);
            lblValNationalID.Location = new Point(251, 112);
            lblValNationalID.Name = "lblValNationalID";
            lblValNationalID.Size = new Size(28, 21);
            lblValNationalID.TabIndex = 5;
            lblValNationalID.Text = "---";
            // 
            // lblTNationalID
            // 
            lblTNationalID.AutoSize = true;
            lblTNationalID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTNationalID.ForeColor = Color.FromArgb(120, 130, 140);
            lblTNationalID.Location = new Point(29, 112);
            lblTNationalID.Name = "lblTNationalID";
            lblTNationalID.Size = new Size(102, 21);
            lblTNationalID.TabIndex = 4;
            lblTNationalID.Text = "National ID:";
            // 
            // lblValAdmNo
            // 
            lblValAdmNo.AutoSize = true;
            lblValAdmNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValAdmNo.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAdmNo.Location = new Point(251, 69);
            lblValAdmNo.Name = "lblValAdmNo";
            lblValAdmNo.Size = new Size(28, 21);
            lblValAdmNo.TabIndex = 3;
            lblValAdmNo.Text = "---";
            // 
            // lblTAdmNo
            // 
            lblTAdmNo.AutoSize = true;
            lblTAdmNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAdmNo.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAdmNo.Location = new Point(29, 69);
            lblTAdmNo.Name = "lblTAdmNo";
            lblTAdmNo.Size = new Size(162, 21);
            lblTAdmNo.TabIndex = 2;
            lblTAdmNo.Text = "Admission Number:";
            // 
            // lblValFullName
            // 
            lblValFullName.AutoSize = true;
            lblValFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblValFullName.ForeColor = Color.FromArgb(33, 37, 41);
            lblValFullName.Location = new Point(251, 27);
            lblValFullName.Name = "lblValFullName";
            lblValFullName.Size = new Size(28, 21);
            lblValFullName.TabIndex = 1;
            lblValFullName.Text = "---";
            // 
            // lblTFullName
            // 
            lblTFullName.AutoSize = true;
            lblTFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTFullName.ForeColor = Color.FromArgb(120, 130, 140);
            lblTFullName.Location = new Point(29, 27);
            lblTFullName.Name = "lblTFullName";
            lblTFullName.Size = new Size(92, 21);
            lblTFullName.TabIndex = 0;
            lblTFullName.Text = "Full Name:";
            // 
            // tabParents
            // 
            tabParents.BackColor = Color.White;
            tabParents.Controls.Add(dgvParents);
            tabParents.Controls.Add(pnlParentsTop);
            tabParents.Location = new Point(4, 30);
            tabParents.Margin = new Padding(3, 4, 3, 4);
            tabParents.Name = "tabParents";
            tabParents.Padding = new Padding(3, 4, 3, 4);
            tabParents.Size = new Size(935, 633);
            tabParents.TabIndex = 1;
            tabParents.Text = "Parents & Guardians";
            // 
            // dgvParents
            // 
            dgvParents.AllowUserToAddRows = false;
            dgvParents.AllowUserToDeleteRows = false;
            dgvParents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParents.BackgroundColor = Color.White;
            dgvParents.BorderStyle = BorderStyle.None;
            dgvParents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvParents.ColumnHeadersHeight = 29;
            dgvParents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvParents.Dock = DockStyle.Fill;
            dgvParents.Location = new Point(3, 71);
            dgvParents.Margin = new Padding(3, 4, 3, 4);
            dgvParents.MultiSelect = false;
            dgvParents.Name = "dgvParents";
            dgvParents.ReadOnly = true;
            dgvParents.RowHeadersVisible = false;
            dgvParents.RowHeadersWidth = 51;
            dgvParents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParents.Size = new Size(929, 558);
            dgvParents.TabIndex = 1;
            // 
            // pnlParentsTop
            // 
            pnlParentsTop.Controls.Add(btnUnlinkParent);
            pnlParentsTop.Controls.Add(btnLinkParent);
            pnlParentsTop.Dock = DockStyle.Top;
            pnlParentsTop.Location = new Point(3, 4);
            pnlParentsTop.Margin = new Padding(3, 4, 3, 4);
            pnlParentsTop.Name = "pnlParentsTop";
            pnlParentsTop.Padding = new Padding(11, 13, 11, 13);
            pnlParentsTop.Size = new Size(929, 67);
            pnlParentsTop.TabIndex = 0;
            // 
            // btnUnlinkParent
            // 
            btnUnlinkParent.BackColor = Color.FromArgb(192, 57, 43);
            btnUnlinkParent.Cursor = Cursors.Hand;
            btnUnlinkParent.FlatAppearance.BorderSize = 0;
            btnUnlinkParent.FlatStyle = FlatStyle.Flat;
            btnUnlinkParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUnlinkParent.ForeColor = Color.White;
            btnUnlinkParent.Location = new Point(452, 12);
            btnUnlinkParent.Margin = new Padding(3, 4, 3, 4);
            btnUnlinkParent.Name = "btnUnlinkParent";
            btnUnlinkParent.Size = new Size(160, 45);
            btnUnlinkParent.TabIndex = 1;
            btnUnlinkParent.Text = "Unlink Selected";
            btnUnlinkParent.UseVisualStyleBackColor = false;
            btnUnlinkParent.Click += BtnUnlinkParent_Click;
            // 
            // btnLinkParent
            // 
            btnLinkParent.BackColor = Color.FromArgb(41, 128, 185);
            btnLinkParent.Cursor = Cursors.Hand;
            btnLinkParent.FlatAppearance.BorderSize = 0;
            btnLinkParent.FlatStyle = FlatStyle.Flat;
            btnLinkParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLinkParent.ForeColor = Color.White;
            btnLinkParent.Location = new Point(269, 12);
            btnLinkParent.Margin = new Padding(3, 4, 3, 4);
            btnLinkParent.Name = "btnLinkParent";
            btnLinkParent.Size = new Size(171, 45);
            btnLinkParent.TabIndex = 0;
            btnLinkParent.Text = "+ Link New Parent";
            btnLinkParent.UseVisualStyleBackColor = false;
            btnLinkParent.Click += BtnLinkParent_Click;
            // 
            // tabEnrollment
            // 
            tabEnrollment.BackColor = Color.White;
            tabEnrollment.Controls.Add(dgvEnrollment);
            tabEnrollment.Location = new Point(4, 30);
            tabEnrollment.Margin = new Padding(3, 4, 3, 4);
            tabEnrollment.Name = "tabEnrollment";
            tabEnrollment.Padding = new Padding(3, 4, 3, 4);
            tabEnrollment.Size = new Size(935, 633);
            tabEnrollment.TabIndex = 2;
            tabEnrollment.Text = "Enrollment History";
            // 
            // dgvEnrollment
            // 
            dgvEnrollment.AllowUserToAddRows = false;
            dgvEnrollment.AllowUserToDeleteRows = false;
            dgvEnrollment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollment.BackgroundColor = Color.White;
            dgvEnrollment.BorderStyle = BorderStyle.None;
            dgvEnrollment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEnrollment.ColumnHeadersHeight = 29;
            dgvEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEnrollment.Dock = DockStyle.Fill;
            dgvEnrollment.Location = new Point(3, 4);
            dgvEnrollment.Margin = new Padding(3, 4, 3, 4);
            dgvEnrollment.MultiSelect = false;
            dgvEnrollment.Name = "dgvEnrollment";
            dgvEnrollment.ReadOnly = true;
            dgvEnrollment.RowHeadersVisible = false;
            dgvEnrollment.RowHeadersWidth = 51;
            dgvEnrollment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrollment.Size = new Size(929, 625);
            dgvEnrollment.TabIndex = 0;
            
            // 
            // tabAttendance
            // 
            tabAttendance.BackColor = Color.White;
            tabAttendance.Controls.Add(dgvAttendance);
            tabAttendance.Location = new Point(4, 30);
            tabAttendance.Margin = new Padding(3, 4, 3, 4);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Padding = new Padding(3, 4, 3, 4);
            tabAttendance.Size = new Size(935, 633);
            tabAttendance.TabIndex = 3;
            tabAttendance.Text = "Attendance Records";
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersHeight = 29;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(3, 4);
            dgvAttendance.Margin = new Padding(3, 4, 3, 4);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(929, 625);
            dgvAttendance.TabIndex = 0;
            // 
            // tabGrades
            // 
            tabGrades.BackColor = Color.White;
            tabGrades.Controls.Add(dgvGrades);
            tabGrades.Location = new Point(4, 30);
            tabGrades.Margin = new Padding(3, 4, 3, 4);
            tabGrades.Name = "tabGrades";
            tabGrades.Padding = new Padding(3, 4, 3, 4);
            tabGrades.Size = new Size(935, 633);
            tabGrades.TabIndex = 4;
            tabGrades.Text = "Grades & Exams";
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.BackgroundColor = Color.White;
            dgvGrades.BorderStyle = BorderStyle.None;
            dgvGrades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrades.ColumnHeadersHeight = 29;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGrades.Dock = DockStyle.Fill;
            dgvGrades.Location = new Point(3, 4);
            dgvGrades.Margin = new Padding(3, 4, 3, 4);
            dgvGrades.MultiSelect = false;
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersVisible = false;
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(929, 625);
            dgvGrades.TabIndex = 0;
            // 
            // tabFinancial
            // 
            tabFinancial.BackColor = Color.White;
            tabFinancial.Controls.Add(dgvFinancial);
            tabFinancial.Location = new Point(4, 30);
            tabFinancial.Margin = new Padding(3, 4, 3, 4);
            tabFinancial.Name = "tabFinancial";
            tabFinancial.Padding = new Padding(3, 4, 3, 4);
            tabFinancial.Size = new Size(935, 633);
            tabFinancial.TabIndex = 5;
            tabFinancial.Text = "Invoices & Fees";
            // 
            // dgvFinancial
            // 
            dgvFinancial.AllowUserToAddRows = false;
            dgvFinancial.AllowUserToDeleteRows = false;
            dgvFinancial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFinancial.BackgroundColor = Color.White;
            dgvFinancial.BorderStyle = BorderStyle.None;
            dgvFinancial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFinancial.ColumnHeadersHeight = 29;
            dgvFinancial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFinancial.Dock = DockStyle.Fill;
            dgvFinancial.Location = new Point(3, 4);
            dgvFinancial.Margin = new Padding(3, 4, 3, 4);
            dgvFinancial.MultiSelect = false;
            dgvFinancial.Name = "dgvFinancial";
            dgvFinancial.ReadOnly = true;
            dgvFinancial.RowHeadersVisible = false;
            dgvFinancial.RowHeadersWidth = 51;
            dgvFinancial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFinancial.Size = new Size(929, 625);
            dgvFinancial.TabIndex = 0;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(41, 128, 185);
            btnEditProfile.Cursor = Cursors.Hand;
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(651, 793);
            btnEditProfile.Margin = new Padding(3, 4, 3, 4);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(171, 48);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "Edit Student Info";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += BtnEditProfile_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(840, 793);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 48);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmStudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(987, 855);
            Controls.Add(btnClose);
            Controls.Add(btnEditProfile);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Profile";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabControl.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            pnlOverview.ResumeLayout(false);
            pnlOverview.PerformLayout();
            tabParents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParents).EndInit();
            pnlParentsTop.ResumeLayout(false);
            tabEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).EndInit();
            tabAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            tabFinancial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFinancial).EndInit();
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
        private System.Windows.Forms.Label lblTAdmNo;
        private System.Windows.Forms.Label lblValAdmNo;
        private System.Windows.Forms.Label lblTNationalID;
        private System.Windows.Forms.Label lblValNationalID;
        private System.Windows.Forms.Label lblTDOB;
        private System.Windows.Forms.Label lblValDOB;
        private System.Windows.Forms.Label lblTGender;
        private System.Windows.Forms.Label lblValGender;
        private System.Windows.Forms.Label lblTNationality;
        private System.Windows.Forms.Label lblValNationality;
        private System.Windows.Forms.Label lblTBlood;
        private System.Windows.Forms.Label lblValBlood;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblValPhone;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.Label lblValAddress;
        private System.Windows.Forms.Label lblTAdmDate;
        private System.Windows.Forms.Label lblValAdmDate;
        private System.Windows.Forms.Label lblTPrevSchool;
        private System.Windows.Forms.Label lblValPrevSchool;
        private System.Windows.Forms.Label lblTHealth;
        private System.Windows.Forms.Label lblValHealth;
        private System.Windows.Forms.TabPage tabParents;
        private System.Windows.Forms.Panel pnlParentsTop;
        private System.Windows.Forms.Button btnLinkParent;
        private System.Windows.Forms.Button btnUnlinkParent;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.TabPage tabEnrollment;
        private System.Windows.Forms.DataGridView dgvEnrollment;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.TabPage tabFinancial;
        private System.Windows.Forms.DataGridView dgvFinancial;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnClose;
    }
}
