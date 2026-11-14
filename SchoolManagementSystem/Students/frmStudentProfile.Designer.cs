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
            pbxStudentImage = new PictureBox();
            gbStudentIdentity = new GroupBox();
            lblTFullName = new Label();
            lblValFullName = new Label();
            lblTAdmNo = new Label();
            lblValAdmNo = new Label();
            lblTNationalID = new Label();
            lblValNationalID = new Label();
            lblTDOB = new Label();
            lblValDOB = new Label();
            lblTGender = new Label();
            lblValGender = new Label();
            lblTNationality = new Label();
            lblValNationality = new Label();
            lblTBlood = new Label();
            lblValBlood = new Label();
            gbStudentContact = new GroupBox();
            lblTPhone = new Label();
            lblValPhone = new Label();
            lblTEmail = new Label();
            lblValEmail = new Label();
            lblTAddress = new Label();
            lblValAddress = new Label();
            gbStudentHealthAndPrev = new GroupBox();
            lblTAdmDate = new Label();
            lblValAdmDate = new Label();
            lblTPrevSchool = new Label();
            lblValPrevSchool = new Label();
            lblTHealth = new Label();
            lblValHealth = new Label();
            tabParents = new TabPage();
            dgvParents = new DataGridView();
            pnlParentsTop = new Panel();
            btnUnlinkParent = new Button();
            btnLinkParent = new Button();
            tabEnrollment = new TabPage();
            pnlEnrollmentTop = new Panel();
            btnEnrollStudent = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pbxStudentImage).BeginInit();
            gbStudentIdentity.SuspendLayout();
            gbStudentContact.SuspendLayout();
            gbStudentHealthAndPrev.SuspendLayout();
            tabParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParents).BeginInit();
            pnlParentsTop.SuspendLayout();
            tabEnrollment.SuspendLayout();
            pnlEnrollmentTop.SuspendLayout();
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
            pnlHeader.Size = new Size(1223, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(38, 42, 51);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(1177, 54);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "الملف التعريفي الشامل للطالب";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabOverview);
            tabControl.Controls.Add(tabParents);
            tabControl.Controls.Add(tabEnrollment);
            tabControl.Controls.Add(tabAttendance);
            tabControl.Controls.Add(tabGrades);
            tabControl.Controls.Add(tabFinancial);
            tabControl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControl.Location = new Point(23, 95);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1177, 575);
            tabControl.TabIndex = 1;
            // 
            // tabOverview
            // 
            tabOverview.Controls.Add(pnlOverview);
            tabOverview.Location = new Point(4, 32);
            tabOverview.Margin = new Padding(3, 4, 3, 4);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3, 4, 3, 4);
            tabOverview.Size = new Size(1169, 539);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "  البيانات الأساسية  ";
            tabOverview.UseVisualStyleBackColor = true;
            // 
            // pnlOverview
            // 
            pnlOverview.AutoScroll = true;
            pnlOverview.BackColor = Color.White;
            pnlOverview.Controls.Add(pbxStudentImage);
            pnlOverview.Controls.Add(gbStudentIdentity);
            pnlOverview.Controls.Add(gbStudentContact);
            pnlOverview.Controls.Add(gbStudentHealthAndPrev);
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.Location = new Point(3, 4);
            pnlOverview.Margin = new Padding(3, 4, 3, 4);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Padding = new Padding(20);
            pnlOverview.Size = new Size(1163, 531);
            pnlOverview.TabIndex = 0;
            // 
            // pbxStudentImage
            // 
            pbxStudentImage.BorderStyle = BorderStyle.FixedSingle;
            pbxStudentImage.Image = Properties.Resources.icons8_student_male_1000;
            pbxStudentImage.Location = new Point(30, 25);
            pbxStudentImage.Name = "pbxStudentImage";
            pbxStudentImage.Size = new Size(215, 210);
            pbxStudentImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStudentImage.TabIndex = 29;
            pbxStudentImage.TabStop = false;
            // 
            // gbStudentIdentity
            // 
            gbStudentIdentity.Controls.Add(lblTFullName);
            gbStudentIdentity.Controls.Add(lblValFullName);
            gbStudentIdentity.Controls.Add(lblTAdmNo);
            gbStudentIdentity.Controls.Add(lblValAdmNo);
            gbStudentIdentity.Controls.Add(lblTNationalID);
            gbStudentIdentity.Controls.Add(lblValNationalID);
            gbStudentIdentity.Controls.Add(lblTDOB);
            gbStudentIdentity.Controls.Add(lblValDOB);
            gbStudentIdentity.Controls.Add(lblTGender);
            gbStudentIdentity.Controls.Add(lblValGender);
            gbStudentIdentity.Controls.Add(lblTNationality);
            gbStudentIdentity.Controls.Add(lblValNationality);
            gbStudentIdentity.Controls.Add(lblTBlood);
            gbStudentIdentity.Controls.Add(lblValBlood);
            gbStudentIdentity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbStudentIdentity.ForeColor = Color.FromArgb(55, 71, 133);
            gbStudentIdentity.Location = new Point(265, 18);
            gbStudentIdentity.Name = "gbStudentIdentity";
            gbStudentIdentity.RightToLeft = RightToLeft.Yes;
            gbStudentIdentity.Size = new Size(875, 220);
            gbStudentIdentity.TabIndex = 0;
            gbStudentIdentity.TabStop = false;
            gbStudentIdentity.Text = "بيانات الهوية والبيانات الأساسية";
            // 
            // lblTFullName
            // 
            lblTFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTFullName.ForeColor = Color.FromArgb(107, 114, 128);
            lblTFullName.Location = new Point(740, 28);
            lblTFullName.Name = "lblTFullName";
            lblTFullName.Size = new Size(120, 25);
            lblTFullName.TabIndex = 0;
            lblTFullName.Text = "الاسم الكامل:";
            // 
            // lblValFullName
            // 
            lblValFullName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValFullName.ForeColor = Color.FromArgb(31, 41, 55);
            lblValFullName.Location = new Point(470, 28);
            lblValFullName.Name = "lblValFullName";
            lblValFullName.Size = new Size(260, 25);
            lblValFullName.TabIndex = 1;
            lblValFullName.Text = "—";
            // 
            // lblTAdmNo
            // 
            lblTAdmNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAdmNo.ForeColor = Color.FromArgb(107, 114, 128);
            lblTAdmNo.Location = new Point(340, 28);
            lblTAdmNo.Name = "lblTAdmNo";
            lblTAdmNo.Size = new Size(110, 25);
            lblTAdmNo.TabIndex = 2;
            lblTAdmNo.Text = "رقم القبول:";
            // 
            // lblValAdmNo
            // 
            lblValAdmNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValAdmNo.ForeColor = Color.FromArgb(55, 71, 133);
            lblValAdmNo.Location = new Point(20, 28);
            lblValAdmNo.Name = "lblValAdmNo";
            lblValAdmNo.Size = new Size(310, 25);
            lblValAdmNo.TabIndex = 3;
            lblValAdmNo.Text = "—";
            // 
            // lblTNationalID
            // 
            lblTNationalID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTNationalID.ForeColor = Color.FromArgb(107, 114, 128);
            lblTNationalID.Location = new Point(740, 75);
            lblTNationalID.Name = "lblTNationalID";
            lblTNationalID.Size = new Size(120, 25);
            lblTNationalID.TabIndex = 4;
            lblTNationalID.Text = "الرقم الوطني:";
            // 
            // lblValNationalID
            // 
            lblValNationalID.Font = new Font("Segoe UI", 10F);
            lblValNationalID.ForeColor = Color.FromArgb(31, 41, 55);
            lblValNationalID.Location = new Point(470, 75);
            lblValNationalID.Name = "lblValNationalID";
            lblValNationalID.Size = new Size(260, 25);
            lblValNationalID.TabIndex = 5;
            lblValNationalID.Text = "—";
            // 
            // lblTDOB
            // 
            lblTDOB.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTDOB.ForeColor = Color.FromArgb(107, 114, 128);
            lblTDOB.Location = new Point(340, 75);
            lblTDOB.Name = "lblTDOB";
            lblTDOB.Size = new Size(110, 25);
            lblTDOB.TabIndex = 6;
            lblTDOB.Text = "تاريخ الميلاد:";
            // 
            // lblValDOB
            // 
            lblValDOB.Font = new Font("Segoe UI", 10F);
            lblValDOB.ForeColor = Color.FromArgb(31, 41, 55);
            lblValDOB.Location = new Point(20, 75);
            lblValDOB.Name = "lblValDOB";
            lblValDOB.Size = new Size(310, 25);
            lblValDOB.TabIndex = 7;
            lblValDOB.Text = "—";
            // 
            // lblTGender
            // 
            lblTGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTGender.ForeColor = Color.FromArgb(107, 114, 128);
            lblTGender.Location = new Point(740, 122);
            lblTGender.Name = "lblTGender";
            lblTGender.Size = new Size(120, 25);
            lblTGender.TabIndex = 8;
            lblTGender.Text = "الجنس:";
            // 
            // lblValGender
            // 
            lblValGender.Font = new Font("Segoe UI", 10F);
            lblValGender.ForeColor = Color.FromArgb(31, 41, 55);
            lblValGender.Location = new Point(470, 122);
            lblValGender.Name = "lblValGender";
            lblValGender.Size = new Size(260, 25);
            lblValGender.TabIndex = 9;
            lblValGender.Text = "—";
            // 
            // lblTNationality
            // 
            lblTNationality.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTNationality.ForeColor = Color.FromArgb(107, 114, 128);
            lblTNationality.Location = new Point(340, 122);
            lblTNationality.Name = "lblTNationality";
            lblTNationality.Size = new Size(110, 25);
            lblTNationality.TabIndex = 10;
            lblTNationality.Text = "الجنسية:";
            // 
            // lblValNationality
            // 
            lblValNationality.Font = new Font("Segoe UI", 10F);
            lblValNationality.ForeColor = Color.FromArgb(31, 41, 55);
            lblValNationality.Location = new Point(20, 122);
            lblValNationality.Name = "lblValNationality";
            lblValNationality.Size = new Size(310, 25);
            lblValNationality.TabIndex = 11;
            lblValNationality.Text = "—";
            // 
            // lblTBlood
            // 
            lblTBlood.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTBlood.ForeColor = Color.FromArgb(107, 114, 128);
            lblTBlood.Location = new Point(740, 169);
            lblTBlood.Name = "lblTBlood";
            lblTBlood.Size = new Size(120, 25);
            lblTBlood.TabIndex = 12;
            lblTBlood.Text = "فصيلة الدم:";
            // 
            // lblValBlood
            // 
            lblValBlood.Font = new Font("Segoe UI", 10F);
            lblValBlood.ForeColor = Color.FromArgb(31, 41, 55);
            lblValBlood.Location = new Point(470, 169);
            lblValBlood.Name = "lblValBlood";
            lblValBlood.Size = new Size(260, 25);
            lblValBlood.TabIndex = 13;
            lblValBlood.Text = "—";
            // 
            // gbStudentContact
            // 
            gbStudentContact.Controls.Add(lblTPhone);
            gbStudentContact.Controls.Add(lblValPhone);
            gbStudentContact.Controls.Add(lblTEmail);
            gbStudentContact.Controls.Add(lblValEmail);
            gbStudentContact.Controls.Add(lblTAddress);
            gbStudentContact.Controls.Add(lblValAddress);
            gbStudentContact.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbStudentContact.ForeColor = Color.FromArgb(55, 71, 133);
            gbStudentContact.Location = new Point(30, 250);
            gbStudentContact.Name = "gbStudentContact";
            gbStudentContact.RightToLeft = RightToLeft.Yes;
            gbStudentContact.Size = new Size(1110, 120);
            gbStudentContact.TabIndex = 1;
            gbStudentContact.TabStop = false;
            gbStudentContact.Text = "بيانات الاتصال والتواصل";
            // 
            // lblTPhone
            // 
            lblTPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPhone.ForeColor = Color.FromArgb(107, 114, 128);
            lblTPhone.Location = new Point(975, 30);
            lblTPhone.Name = "lblTPhone";
            lblTPhone.Size = new Size(115, 25);
            lblTPhone.TabIndex = 0;
            lblTPhone.Text = "رقم الهاتف:";
            // 
            // lblValPhone
            // 
            lblValPhone.Font = new Font("Segoe UI", 10F);
            lblValPhone.ForeColor = Color.FromArgb(31, 41, 55);
            lblValPhone.Location = new Point(590, 30);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(370, 25);
            lblValPhone.TabIndex = 1;
            lblValPhone.Text = "—";
            // 
            // lblTEmail
            // 
            lblTEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTEmail.ForeColor = Color.FromArgb(107, 114, 128);
            lblTEmail.Location = new Point(440, 30);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(130, 25);
            lblTEmail.TabIndex = 2;
            lblTEmail.Text = "البريد الإلكتروني:";
            // 
            // lblValEmail
            // 
            lblValEmail.Font = new Font("Segoe UI", 10F);
            lblValEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblValEmail.Location = new Point(20, 30);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(410, 25);
            lblValEmail.TabIndex = 3;
            lblValEmail.Text = "—";
            // 
            // lblTAddress
            // 
            lblTAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAddress.ForeColor = Color.FromArgb(107, 114, 128);
            lblTAddress.Location = new Point(975, 75);
            lblTAddress.Name = "lblTAddress";
            lblTAddress.Size = new Size(115, 25);
            lblTAddress.TabIndex = 4;
            lblTAddress.Text = "العنوان السكني:";
            // 
            // lblValAddress
            // 
            lblValAddress.Font = new Font("Segoe UI", 10F);
            lblValAddress.ForeColor = Color.FromArgb(31, 41, 55);
            lblValAddress.Location = new Point(20, 75);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(940, 25);
            lblValAddress.TabIndex = 5;
            lblValAddress.Text = "—";
            // 
            // gbStudentHealthAndPrev
            // 
            gbStudentHealthAndPrev.Controls.Add(lblTAdmDate);
            gbStudentHealthAndPrev.Controls.Add(lblValAdmDate);
            gbStudentHealthAndPrev.Controls.Add(lblTPrevSchool);
            gbStudentHealthAndPrev.Controls.Add(lblValPrevSchool);
            gbStudentHealthAndPrev.Controls.Add(lblTHealth);
            gbStudentHealthAndPrev.Controls.Add(lblValHealth);
            gbStudentHealthAndPrev.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbStudentHealthAndPrev.ForeColor = Color.FromArgb(55, 71, 133);
            gbStudentHealthAndPrev.Location = new Point(30, 385);
            gbStudentHealthAndPrev.Name = "gbStudentHealthAndPrev";
            gbStudentHealthAndPrev.RightToLeft = RightToLeft.Yes;
            gbStudentHealthAndPrev.Size = new Size(1110, 130);
            gbStudentHealthAndPrev.TabIndex = 2;
            gbStudentHealthAndPrev.TabStop = false;
            gbStudentHealthAndPrev.Text = "البيانات الأكاديمية والصحية";
            // 
            // lblTAdmDate
            // 
            lblTAdmDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAdmDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblTAdmDate.Location = new Point(975, 30);
            lblTAdmDate.Name = "lblTAdmDate";
            lblTAdmDate.Size = new Size(115, 25);
            lblTAdmDate.TabIndex = 0;
            lblTAdmDate.Text = "تاريخ القبول:";
            // 
            // lblValAdmDate
            // 
            lblValAdmDate.Font = new Font("Segoe UI", 10F);
            lblValAdmDate.ForeColor = Color.FromArgb(31, 41, 55);
            lblValAdmDate.Location = new Point(590, 30);
            lblValAdmDate.Name = "lblValAdmDate";
            lblValAdmDate.Size = new Size(370, 25);
            lblValAdmDate.TabIndex = 1;
            lblValAdmDate.Text = "—";
            // 
            // lblTPrevSchool
            // 
            lblTPrevSchool.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPrevSchool.ForeColor = Color.FromArgb(107, 114, 128);
            lblTPrevSchool.Location = new Point(440, 30);
            lblTPrevSchool.Name = "lblTPrevSchool";
            lblTPrevSchool.Size = new Size(130, 25);
            lblTPrevSchool.TabIndex = 2;
            lblTPrevSchool.Text = "المدرسة السابقة:";
            // 
            // lblValPrevSchool
            // 
            lblValPrevSchool.Font = new Font("Segoe UI", 10F);
            lblValPrevSchool.ForeColor = Color.FromArgb(31, 41, 55);
            lblValPrevSchool.Location = new Point(20, 30);
            lblValPrevSchool.Name = "lblValPrevSchool";
            lblValPrevSchool.Size = new Size(410, 25);
            lblValPrevSchool.TabIndex = 3;
            lblValPrevSchool.Text = "—";
            // 
            // lblTHealth
            // 
            lblTHealth.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTHealth.ForeColor = Color.FromArgb(107, 114, 128);
            lblTHealth.Location = new Point(975, 78);
            lblTHealth.Name = "lblTHealth";
            lblTHealth.Size = new Size(115, 25);
            lblTHealth.TabIndex = 4;
            lblTHealth.Text = "الحالة الصحية:";
            // 
            // lblValHealth
            // 
            lblValHealth.Font = new Font("Segoe UI", 10F);
            lblValHealth.ForeColor = Color.FromArgb(31, 41, 55);
            lblValHealth.Location = new Point(20, 78);
            lblValHealth.Name = "lblValHealth";
            lblValHealth.Size = new Size(940, 25);
            lblValHealth.TabIndex = 5;
            lblValHealth.Text = "—";
            // 
            // tabParents
            // 
            tabParents.Controls.Add(dgvParents);
            tabParents.Controls.Add(pnlParentsTop);
            tabParents.Location = new Point(4, 32);
            tabParents.Margin = new Padding(3, 4, 3, 4);
            tabParents.Name = "tabParents";
            tabParents.Padding = new Padding(3, 4, 3, 4);
            tabParents.Size = new Size(1169, 539);
            tabParents.TabIndex = 1;
            tabParents.Text = "  أولياء الأمور المرتبطون  ";
            tabParents.UseVisualStyleBackColor = true;
            // 
            // dgvParents
            // 
            dgvParents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParents.Dock = DockStyle.Fill;
            dgvParents.Location = new Point(3, 64);
            dgvParents.Margin = new Padding(3, 4, 3, 4);
            dgvParents.Name = "dgvParents";
            dgvParents.RowHeadersWidth = 51;
            dgvParents.Size = new Size(1163, 471);
            dgvParents.TabIndex = 0;
            // 
            // pnlParentsTop
            // 
            pnlParentsTop.Controls.Add(btnUnlinkParent);
            pnlParentsTop.Controls.Add(btnLinkParent);
            pnlParentsTop.Dock = DockStyle.Top;
            pnlParentsTop.Location = new Point(3, 4);
            pnlParentsTop.Margin = new Padding(3, 4, 3, 4);
            pnlParentsTop.Name = "pnlParentsTop";
            pnlParentsTop.Size = new Size(1163, 60);
            pnlParentsTop.TabIndex = 1;
            // 
            // btnUnlinkParent
            // 
            btnUnlinkParent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUnlinkParent.BackColor = Color.FromArgb(185, 28, 28);
            btnUnlinkParent.Cursor = Cursors.Hand;
            btnUnlinkParent.FlatAppearance.BorderSize = 0;
            btnUnlinkParent.FlatStyle = FlatStyle.Flat;
            btnUnlinkParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUnlinkParent.ForeColor = Color.White;
            btnUnlinkParent.Location = new Point(816, 10);
            btnUnlinkParent.Margin = new Padding(3, 4, 3, 4);
            btnUnlinkParent.Name = "btnUnlinkParent";
            btnUnlinkParent.Size = new Size(150, 40);
            btnUnlinkParent.TabIndex = 1;
            btnUnlinkParent.Text = "فك الارتباط";
            btnUnlinkParent.UseVisualStyleBackColor = false;
            btnUnlinkParent.Click += BtnUnlinkParent_Click;
            // 
            // btnLinkParent
            // 
            btnLinkParent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLinkParent.BackColor = Color.FromArgb(55, 71, 133);
            btnLinkParent.Cursor = Cursors.Hand;
            btnLinkParent.FlatAppearance.BorderSize = 0;
            btnLinkParent.FlatStyle = FlatStyle.Flat;
            btnLinkParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLinkParent.ForeColor = Color.White;
            btnLinkParent.Location = new Point(981, 10);
            btnLinkParent.Margin = new Padding(3, 4, 3, 4);
            btnLinkParent.Name = "btnLinkParent";
            btnLinkParent.Size = new Size(170, 40);
            btnLinkParent.TabIndex = 0;
            btnLinkParent.Text = "ربط ولي أمر";
            btnLinkParent.UseVisualStyleBackColor = false;
            btnLinkParent.Click += BtnLinkParent_Click;
            // 
            // tabEnrollment
            // 
            tabEnrollment.Controls.Add(dgvEnrollment);
            tabEnrollment.Controls.Add(pnlEnrollmentTop);
            tabEnrollment.Location = new Point(4, 32);
            tabEnrollment.Margin = new Padding(3, 4, 3, 4);
            tabEnrollment.Name = "tabEnrollment";
            tabEnrollment.Size = new Size(1169, 539);
            tabEnrollment.TabIndex = 2;
            tabEnrollment.Text = "  سجل القيد والصفوف  ";
            tabEnrollment.UseVisualStyleBackColor = true;
            // 
            // pnlEnrollmentTop
            // 
            pnlEnrollmentTop.Controls.Add(btnEnrollStudent);
            pnlEnrollmentTop.Dock = DockStyle.Top;
            pnlEnrollmentTop.Location = new Point(0, 0);
            pnlEnrollmentTop.Name = "pnlEnrollmentTop";
            pnlEnrollmentTop.Size = new Size(1169, 60);
            pnlEnrollmentTop.TabIndex = 1;
            // 
            // btnEnrollStudent
            // 
            btnEnrollStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnrollStudent.BackColor = Color.FromArgb(16, 122, 87);
            btnEnrollStudent.Cursor = Cursors.Hand;
            btnEnrollStudent.FlatAppearance.BorderSize = 0;
            btnEnrollStudent.FlatStyle = FlatStyle.Flat;
            btnEnrollStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEnrollStudent.ForeColor = Color.White;
            btnEnrollStudent.Location = new Point(981, 10);
            btnEnrollStudent.Margin = new Padding(3, 4, 3, 4);
            btnEnrollStudent.Name = "btnEnrollStudent";
            btnEnrollStudent.Size = new Size(170, 40);
            btnEnrollStudent.TabIndex = 0;
            btnEnrollStudent.Text = "قيد في صف";
            btnEnrollStudent.UseVisualStyleBackColor = false;
            btnEnrollStudent.Click += BtnEnrollStudent_Click;
            // 
            // dgvEnrollment
            // 
            dgvEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollment.Dock = DockStyle.Fill;
            dgvEnrollment.Location = new Point(0, 60);
            dgvEnrollment.Margin = new Padding(3, 4, 3, 4);
            dgvEnrollment.Name = "dgvEnrollment";
            dgvEnrollment.RowHeadersWidth = 51;
            dgvEnrollment.Size = new Size(1169, 479);
            dgvEnrollment.TabIndex = 0;
            // 
            // tabAttendance
            // 
            tabAttendance.Controls.Add(dgvAttendance);
            tabAttendance.Location = new Point(4, 32);
            tabAttendance.Margin = new Padding(3, 4, 3, 4);
            tabAttendance.Name = "tabAttendance";
            tabAttendance.Size = new Size(1169, 539);
            tabAttendance.TabIndex = 3;
            tabAttendance.Text = "  سجل الحضور والغياب  ";
            tabAttendance.UseVisualStyleBackColor = true;
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(0, 0);
            dgvAttendance.Margin = new Padding(3, 4, 3, 4);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(1169, 539);
            dgvAttendance.TabIndex = 0;
            // 
            // tabGrades
            // 
            tabGrades.Controls.Add(dgvGrades);
            tabGrades.Location = new Point(4, 32);
            tabGrades.Margin = new Padding(3, 4, 3, 4);
            tabGrades.Name = "tabGrades";
            tabGrades.Size = new Size(1169, 539);
            tabGrades.TabIndex = 4;
            tabGrades.Text = "  الدرجات والتقييمات  ";
            tabGrades.UseVisualStyleBackColor = true;
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Dock = DockStyle.Fill;
            dgvGrades.Location = new Point(0, 0);
            dgvGrades.Margin = new Padding(3, 4, 3, 4);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.Size = new Size(1169, 539);
            dgvGrades.TabIndex = 0;
            // 
            // tabFinancial
            // 
            tabFinancial.Controls.Add(dgvFinancial);
            tabFinancial.Location = new Point(4, 32);
            tabFinancial.Margin = new Padding(3, 4, 3, 4);
            tabFinancial.Name = "tabFinancial";
            tabFinancial.Size = new Size(1169, 539);
            tabFinancial.TabIndex = 5;
            tabFinancial.Text = "  السجل المالي والفواتير  ";
            tabFinancial.UseVisualStyleBackColor = true;
            // 
            // dgvFinancial
            // 
            dgvFinancial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinancial.Dock = DockStyle.Fill;
            dgvFinancial.Location = new Point(0, 0);
            dgvFinancial.Margin = new Padding(3, 4, 3, 4);
            dgvFinancial.Name = "dgvFinancial";
            dgvFinancial.RowHeadersWidth = 51;
            dgvFinancial.Size = new Size(1169, 539);
            dgvFinancial.TabIndex = 0;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditProfile.BackColor = Color.FromArgb(55, 71, 133);
            btnEditProfile.Cursor = Cursors.Hand;
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(145, 680);
            btnEditProfile.Margin = new Padding(3, 4, 3, 4);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(150, 44);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "تعديل البيانات";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += BtnEditProfile_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.ForeColor = Color.FromArgb(31, 41, 55);
            btnClose.Location = new Point(23, 680);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 44);
            btnClose.TabIndex = 3;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // frmStudentProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1223, 735);
            Controls.Add(btnClose);
            Controls.Add(btnEditProfile);
            Controls.Add(tabControl);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentProfile";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "الملف الشخصي للطالب";
            Load += FrmStudentProfile_Load;
            pnlHeader.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            pnlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxStudentImage).EndInit();
            gbStudentIdentity.ResumeLayout(false);
            gbStudentContact.ResumeLayout(false);
            gbStudentHealthAndPrev.ResumeLayout(false);
            tabParents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParents).EndInit();
            pnlParentsTop.ResumeLayout(false);
            tabEnrollment.ResumeLayout(false);
            pnlEnrollmentTop.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabParents;
        private System.Windows.Forms.TabPage tabEnrollment;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.TabPage tabFinancial;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.GroupBox gbStudentIdentity;
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
        private System.Windows.Forms.GroupBox gbStudentContact;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblValPhone;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.Label lblValAddress;
        private System.Windows.Forms.GroupBox gbStudentHealthAndPrev;
        private System.Windows.Forms.Label lblTAdmDate;
        private System.Windows.Forms.Label lblValAdmDate;
        private System.Windows.Forms.Label lblTPrevSchool;
        private System.Windows.Forms.Label lblValPrevSchool;
        private System.Windows.Forms.Label lblTHealth;
        private System.Windows.Forms.Label lblValHealth;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.Panel pnlParentsTop;
        private System.Windows.Forms.Button btnLinkParent;
        private System.Windows.Forms.Button btnUnlinkParent;
        private System.Windows.Forms.DataGridView dgvEnrollment;
        private System.Windows.Forms.Panel pnlEnrollmentTop;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.DataGridView dgvFinancial;
        private PictureBox pbxStudentImage;
    }
}
