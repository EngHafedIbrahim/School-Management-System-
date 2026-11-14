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
            pnlHeader.Size = new Size(1029, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(390, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(250, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "الملف التعريفي للمعلم";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabOverview);
            tabControl.Controls.Add(tabAssignments);
            tabControl.Controls.Add(tabTimetable);
            tabControl.Controls.Add(tabUserAccount);
            tabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabControl.Location = new Point(23, 95);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(983, 625);
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
            tabOverview.Size = new Size(975, 591);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "نظرة عامة";
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
            pnlOverview.Size = new Size(969, 583);
            pnlOverview.TabIndex = 0;
            // 
            // lblTFullName
            // 
            lblTFullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTFullName.AutoSize = true;
            lblTFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTFullName.ForeColor = Color.FromArgb(100, 116, 139);
            lblTFullName.Location = new Point(830, 35);
            lblTFullName.Name = "lblTFullName";
            lblTFullName.Size = new Size(94, 23);
            lblTFullName.TabIndex = 0;
            lblTFullName.Text = "اسم المعلم:";
            // 
            // lblValFullName
            // 
            lblValFullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValFullName.AutoSize = true;
            lblValFullName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblValFullName.ForeColor = Color.FromArgb(30, 41, 59);
            lblValFullName.Location = new Point(550, 31);
            lblValFullName.Name = "lblValFullName";
            lblValFullName.Size = new Size(40, 30);
            lblValFullName.TabIndex = 1;
            lblValFullName.Text = "---";
            // 
            // lblTPhone
            // 
            lblTPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTPhone.AutoSize = true;
            lblTPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTPhone.ForeColor = Color.FromArgb(100, 116, 139);
            lblTPhone.Location = new Point(830, 85);
            lblTPhone.Name = "lblTPhone";
            lblTPhone.Size = new Size(93, 23);
            lblTPhone.TabIndex = 2;
            lblTPhone.Text = "رقم الهاتف:";
            // 
            // lblValPhone
            // 
            lblValPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValPhone.AutoSize = true;
            lblValPhone.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValPhone.ForeColor = Color.FromArgb(30, 41, 59);
            lblValPhone.Location = new Point(550, 84);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(32, 25);
            lblValPhone.TabIndex = 3;
            lblValPhone.Text = "---";
            // 
            // lblTEmail
            // 
            lblTEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTEmail.AutoSize = true;
            lblTEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTEmail.ForeColor = Color.FromArgb(100, 116, 139);
            lblTEmail.Location = new Point(793, 135);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(131, 23);
            lblTEmail.TabIndex = 4;
            lblTEmail.Text = "البريد الإلكتروني:";
            // 
            // lblValEmail
            // 
            lblValEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValEmail.AutoSize = true;
            lblValEmail.Font = new Font("Segoe UI", 10F);
            lblValEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblValEmail.Location = new Point(480, 135);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(31, 23);
            lblValEmail.TabIndex = 5;
            lblValEmail.Text = "---";
            // 
            // lblTAddress
            // 
            lblTAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTAddress.AutoSize = true;
            lblTAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTAddress.ForeColor = Color.FromArgb(100, 116, 139);
            lblTAddress.Location = new Point(828, 185);
            lblTAddress.Name = "lblTAddress";
            lblTAddress.Size = new Size(96, 23);
            lblTAddress.TabIndex = 6;
            lblTAddress.Text = "عنوان السكن:";
            // 
            // lblValAddress
            // 
            lblValAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValAddress.AutoSize = true;
            lblValAddress.Font = new Font("Segoe UI", 10F);
            lblValAddress.ForeColor = Color.FromArgb(30, 41, 59);
            lblValAddress.Location = new Point(480, 185);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(31, 23);
            lblValAddress.TabIndex = 7;
            lblValAddress.Text = "---";
            // 
            // lblTGender
            // 
            lblTGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTGender.AutoSize = true;
            lblTGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTGender.ForeColor = Color.FromArgb(100, 116, 139);
            lblTGender.Location = new Point(863, 235);
            lblTGender.Name = "lblTGender";
            lblTGender.Size = new Size(61, 23);
            lblTGender.TabIndex = 8;
            lblTGender.Text = "الجنس:";
            // 
            // lblValGender
            // 
            lblValGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValGender.AutoSize = true;
            lblValGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValGender.ForeColor = Color.FromArgb(30, 41, 59);
            lblValGender.Location = new Point(550, 235);
            lblValGender.Name = "lblValGender";
            lblValGender.Size = new Size(29, 23);
            lblValGender.TabIndex = 9;
            lblValGender.Text = "---";
            // 
            // lblTSpecialization
            // 
            lblTSpecialization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTSpecialization.AutoSize = true;
            lblTSpecialization.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTSpecialization.ForeColor = Color.FromArgb(100, 116, 139);
            lblTSpecialization.Location = new Point(788, 285);
            lblTSpecialization.Name = "lblTSpecialization";
            lblTSpecialization.Size = new Size(136, 23);
            lblTSpecialization.TabIndex = 10;
            lblTSpecialization.Text = "المادة / التخصص:";
            // 
            // lblValSpecialization
            // 
            lblValSpecialization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValSpecialization.AutoSize = true;
            lblValSpecialization.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValSpecialization.ForeColor = Color.FromArgb(37, 99, 235);
            lblValSpecialization.Location = new Point(500, 284);
            lblValSpecialization.Name = "lblValSpecialization";
            lblValSpecialization.Size = new Size(32, 25);
            lblValSpecialization.TabIndex = 11;
            lblValSpecialization.Text = "---";
            // 
            // lblTQualification
            // 
            lblTQualification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTQualification.AutoSize = true;
            lblTQualification.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTQualification.ForeColor = Color.FromArgb(100, 116, 139);
            lblTQualification.Location = new Point(814, 335);
            lblTQualification.Name = "lblTQualification";
            lblTQualification.Size = new Size(110, 23);
            lblTQualification.TabIndex = 12;
            lblTQualification.Text = "المؤهل العلمي:";
            // 
            // lblValQualification
            // 
            lblValQualification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValQualification.AutoSize = true;
            lblValQualification.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValQualification.ForeColor = Color.FromArgb(30, 41, 59);
            lblValQualification.Location = new Point(500, 335);
            lblValQualification.Name = "lblValQualification";
            lblValQualification.Size = new Size(29, 23);
            lblValQualification.TabIndex = 13;
            lblValQualification.Text = "---";
            // 
            // lblTHireDate
            // 
            lblTHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTHireDate.AutoSize = true;
            lblTHireDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTHireDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblTHireDate.Location = new Point(823, 385);
            lblTHireDate.Name = "lblTHireDate";
            lblTHireDate.Size = new Size(101, 23);
            lblTHireDate.TabIndex = 14;
            lblTHireDate.Text = "تاريخ التعيين:";
            // 
            // lblValHireDate
            // 
            lblValHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValHireDate.AutoSize = true;
            lblValHireDate.Font = new Font("Segoe UI", 10F);
            lblValHireDate.ForeColor = Color.FromArgb(30, 41, 59);
            lblValHireDate.Location = new Point(500, 385);
            lblValHireDate.Name = "lblValHireDate";
            lblValHireDate.Size = new Size(31, 23);
            lblValHireDate.TabIndex = 15;
            lblValHireDate.Text = "---";
            // 
            // lblTStatus
            // 
            lblTStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTStatus.AutoSize = true;
            lblTStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblTStatus.Location = new Point(804, 435);
            lblTStatus.Name = "lblTStatus";
            lblTStatus.Size = new Size(120, 23);
            lblTStatus.TabIndex = 16;
            lblTStatus.Text = "الحالة الوظيفية:";
            // 
            // lblValStatus
            // 
            lblValStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValStatus.AutoSize = true;
            lblValStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValStatus.ForeColor = Color.FromArgb(16, 185, 129);
            lblValStatus.Location = new Point(500, 434);
            lblValStatus.Name = "lblValStatus";
            lblValStatus.Size = new Size(32, 25);
            lblValStatus.TabIndex = 17;
            lblValStatus.Text = "---";
            // 
            // lblTAbout
            // 
            lblTAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTAbout.AutoSize = true;
            lblTAbout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTAbout.ForeColor = Color.FromArgb(100, 116, 139);
            lblTAbout.Location = new Point(765, 485);
            lblTAbout.Name = "lblTAbout";
            lblTAbout.Size = new Size(159, 23);
            lblTAbout.TabIndex = 18;
            lblTAbout.Text = "نبذة تعريفية وملاحظات:";
            // 
            // lblValAbout
            // 
            lblValAbout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblValAbout.Font = new Font("Segoe UI", 9.5F);
            lblValAbout.ForeColor = Color.FromArgb(30, 41, 59);
            lblValAbout.Location = new Point(30, 485);
            lblValAbout.Name = "lblValAbout";
            lblValAbout.Size = new Size(720, 80);
            lblValAbout.TabIndex = 19;
            lblValAbout.Text = "---";
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.White;
            tabAssignments.Controls.Add(dgvAssignments);
            tabAssignments.Location = new Point(4, 30);
            tabAssignments.Margin = new Padding(3, 4, 3, 4);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Padding = new Padding(10);
            tabAssignments.Size = new Size(975, 591);
            tabAssignments.TabIndex = 1;
            tabAssignments.Text = "المواد والشعب المسندة";
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Dock = DockStyle.Fill;
            dgvAssignments.Location = new Point(10, 10);
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(955, 571);
            dgvAssignments.TabIndex = 0;
            // 
            // tabTimetable
            // 
            tabTimetable.BackColor = Color.White;
            tabTimetable.Controls.Add(dgvTimetable);
            tabTimetable.Location = new Point(4, 30);
            tabTimetable.Margin = new Padding(3, 4, 3, 4);
            tabTimetable.Name = "tabTimetable";
            tabTimetable.Padding = new Padding(10);
            tabTimetable.Size = new Size(975, 591);
            tabTimetable.TabIndex = 2;
            tabTimetable.Text = "الجدول والحصص الأسبوعية";
            // 
            // dgvTimetable
            // 
            dgvTimetable.AllowUserToAddRows = false;
            dgvTimetable.AllowUserToDeleteRows = false;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimetable.BackgroundColor = Color.White;
            dgvTimetable.BorderStyle = BorderStyle.None;
            dgvTimetable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimetable.Dock = DockStyle.Fill;
            dgvTimetable.Location = new Point(10, 10);
            dgvTimetable.MultiSelect = false;
            dgvTimetable.Name = "dgvTimetable";
            dgvTimetable.ReadOnly = true;
            dgvTimetable.RowHeadersVisible = false;
            dgvTimetable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTimetable.Size = new Size(955, 571);
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
            tabUserAccount.Size = new Size(975, 591);
            tabUserAccount.TabIndex = 3;
            tabUserAccount.Text = "حساب الدخول للنظام";
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
            pnlUserAccount.Size = new Size(969, 583);
            pnlUserAccount.TabIndex = 0;
            // 
            // lblUserAccountTitle
            // 
            lblUserAccountTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserAccountTitle.AutoSize = true;
            lblUserAccountTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserAccountTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblUserAccountTitle.Location = new Point(660, 40);
            lblUserAccountTitle.Name = "lblUserAccountTitle";
            lblUserAccountTitle.Size = new Size(275, 28);
            lblUserAccountTitle.TabIndex = 0;
            lblUserAccountTitle.Text = "بيانات حساب دخول المعلم للنظام";
            // 
            // lblTUsername
            // 
            lblTUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTUsername.AutoSize = true;
            lblTUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTUsername.ForeColor = Color.FromArgb(100, 116, 139);
            lblTUsername.Location = new Point(830, 105);
            lblTUsername.Name = "lblTUsername";
            lblTUsername.Size = new Size(105, 23);
            lblTUsername.TabIndex = 1;
            lblTUsername.Text = "اسم المستخدم:";
            // 
            // lblValUsername
            // 
            lblValUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValUsername.AutoSize = true;
            lblValUsername.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValUsername.ForeColor = Color.FromArgb(37, 99, 235);
            lblValUsername.Location = new Point(600, 104);
            lblValUsername.Name = "lblValUsername";
            lblValUsername.Size = new Size(32, 25);
            lblValUsername.TabIndex = 2;
            lblValUsername.Text = "---";
            // 
            // lblTUserStatus
            // 
            lblTUserStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTUserStatus.AutoSize = true;
            lblTUserStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTUserStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblTUserStatus.Location = new Point(835, 160);
            lblTUserStatus.Name = "lblTUserStatus";
            lblTUserStatus.Size = new Size(100, 23);
            lblTUserStatus.TabIndex = 3;
            lblTUserStatus.Text = "حالة الحساب:";
            // 
            // lblValUserStatus
            // 
            lblValUserStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValUserStatus.AutoSize = true;
            lblValUserStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValUserStatus.ForeColor = Color.FromArgb(30, 41, 59);
            lblValUserStatus.Location = new Point(600, 160);
            lblValUserStatus.Name = "lblValUserStatus";
            lblValUserStatus.Size = new Size(29, 23);
            lblValUserStatus.TabIndex = 4;
            lblValUserStatus.Text = "---";
            // 
            // btnCreateUserAccount
            // 
            btnCreateUserAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateUserAccount.BackColor = Color.FromArgb(37, 99, 235);
            btnCreateUserAccount.Cursor = Cursors.Hand;
            btnCreateUserAccount.FlatAppearance.BorderSize = 0;
            btnCreateUserAccount.FlatStyle = FlatStyle.Flat;
            btnCreateUserAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCreateUserAccount.ForeColor = Color.White;
            btnCreateUserAccount.Location = new Point(695, 230);
            btnCreateUserAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateUserAccount.Name = "btnCreateUserAccount";
            btnCreateUserAccount.Size = new Size(240, 46);
            btnCreateUserAccount.TabIndex = 5;
            btnCreateUserAccount.Text = "إنشاء حساب دخول للمعلم";
            btnCreateUserAccount.UseVisualStyleBackColor = false;
            btnCreateUserAccount.Click += BtnCreateUserAccount_Click;
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditTeacher.BackColor = Color.FromArgb(37, 99, 235);
            btnEditTeacher.Cursor = Cursors.Hand;
            btnEditTeacher.FlatAppearance.BorderSize = 0;
            btnEditTeacher.FlatStyle = FlatStyle.Flat;
            btnEditTeacher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditTeacher.ForeColor = Color.White;
            btnEditTeacher.Location = new Point(145, 740);
            btnEditTeacher.Margin = new Padding(3, 4, 3, 4);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(150, 45);
            btnEditTeacher.TabIndex = 2;
            btnEditTeacher.Text = "تعديل بيانات المعلم";
            btnEditTeacher.UseVisualStyleBackColor = false;
            btnEditTeacher.Click += BtnEditTeacher_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(25, 740);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 45);
            btnClose.TabIndex = 3;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1029, 807);
            Controls.Add(btnClose);
            Controls.Add(btnEditTeacher);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTeacherProfile";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "الملف التعريفي للمعلم";
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
