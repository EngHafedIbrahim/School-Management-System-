namespace SchoolManagementSystem.Students
{
    partial class frmRegisterStudent
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            pnlCard = new Panel();
            llblSetImage = new LinkLabel();
            pbxStudentImage = new PictureBox();
            gbPersonal = new GroupBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblAdmissionNo = new Label();
            txtAdmissionNo = new TextBox();
            lblNationalID = new Label();
            txtNationalID = new TextBox();
            gbDemographic = new GroupBox();
            lblGender = new Label();
            cbGender = new ComboBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            gbContact = new GroupBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            gbAcademic = new GroupBox();
            lblNationality = new Label();
            txtNationality = new TextBox();
            lblBloodType = new Label();
            cbBloodType = new ComboBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPreviousSchool = new Label();
            txtPreviousSchool = new TextBox();
            lblAdmissionDate = new Label();
            dtpAdmissionDate = new DateTimePicker();
            lblHealthStatus = new Label();
            cbHealthStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            opfImage = new OpenFileDialog();
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxStudentImage).BeginInit();
            gbPersonal.SuspendLayout();
            gbDemographic.SuspendLayout();
            gbContact.SuspendLayout();
            gbAcademic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            pnlHeader.Size = new Size(1054, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(38, 42, 51);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(1008, 54);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "تسجيل وقيد طالب جديد";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(llblSetImage);
            pnlCard.Controls.Add(pbxStudentImage);
            pnlCard.Controls.Add(gbPersonal);
            pnlCard.Controls.Add(gbDemographic);
            pnlCard.Controls.Add(gbContact);
            pnlCard.Controls.Add(gbAcademic);
            pnlCard.Location = new Point(29, 95);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(20);
            pnlCard.Size = new Size(998, 655);
            pnlCard.TabIndex = 1;
            // 
            // llblSetImage
            // 
            llblSetImage.ActiveLinkColor = Color.FromArgb(72, 92, 165);
            llblSetImage.AutoSize = true;
            llblSetImage.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            llblSetImage.LinkColor = Color.FromArgb(55, 71, 133);
            llblSetImage.Location = new Point(100, 234);
            llblSetImage.Name = "llblSetImage";
            llblSetImage.Size = new Size(74, 21);
            llblSetImage.TabIndex = 5;
            llblSetImage.TabStop = true;
            llblSetImage.Text = "تغيير الصورة";
            llblSetImage.LinkClicked += LlblSetImage_LinkClicked;
            // 
            // pbxStudentImage
            // 
            pbxStudentImage.BackColor = Color.FromArgb(243, 244, 246);
            pbxStudentImage.BorderStyle = BorderStyle.FixedSingle;
            pbxStudentImage.Image = Properties.Resources.icons8_student_male_1000;
            pbxStudentImage.Location = new Point(30, 25);
            pbxStudentImage.Name = "pbxStudentImage";
            pbxStudentImage.Size = new Size(220, 195);
            pbxStudentImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxStudentImage.TabIndex = 28;
            pbxStudentImage.TabStop = false;
            // 
            // gbPersonal
            // 
            gbPersonal.Controls.Add(lblFirstName);
            gbPersonal.Controls.Add(txtFirstName);
            gbPersonal.Controls.Add(lblLastName);
            gbPersonal.Controls.Add(txtLastName);
            gbPersonal.Controls.Add(lblAdmissionNo);
            gbPersonal.Controls.Add(txtAdmissionNo);
            gbPersonal.Controls.Add(lblNationalID);
            gbPersonal.Controls.Add(txtNationalID);
            gbPersonal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbPersonal.ForeColor = Color.FromArgb(55, 71, 133);
            gbPersonal.Location = new Point(270, 15);
            gbPersonal.Name = "gbPersonal";
            gbPersonal.RightToLeft = RightToLeft.Yes;
            gbPersonal.Size = new Size(705, 155);
            gbPersonal.TabIndex = 0;
            gbPersonal.TabStop = false;
            gbPersonal.Text = "البيانات الشخصية والتعريفية";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(107, 114, 128);
            lblFirstName.Location = new Point(595, 27);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(82, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "الاسم الأول:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(370, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(310, 29);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(107, 114, 128);
            lblLastName.Location = new Point(230, 27);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(123, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "اسم العائلة / اللقب:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(20, 50);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(330, 29);
            txtLastName.TabIndex = 3;
            txtLastName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAdmissionNo
            // 
            lblAdmissionNo.AutoSize = true;
            lblAdmissionNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdmissionNo.ForeColor = Color.FromArgb(107, 114, 128);
            lblAdmissionNo.Location = new Point(600, 88);
            lblAdmissionNo.Name = "lblAdmissionNo";
            lblAdmissionNo.Size = new Size(77, 20);
            lblAdmissionNo.TabIndex = 4;
            lblAdmissionNo.Text = "رقم القبول:";
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Font = new Font("Segoe UI", 9.5F);
            txtAdmissionNo.Location = new Point(370, 111);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(310, 29);
            txtAdmissionNo.TabIndex = 5;
            txtAdmissionNo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNationalID
            // 
            lblNationalID.AutoSize = true;
            lblNationalID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNationalID.ForeColor = Color.FromArgb(107, 114, 128);
            lblNationalID.Location = new Point(260, 88);
            lblNationalID.Name = "lblNationalID";
            lblNationalID.Size = new Size(93, 20);
            lblNationalID.TabIndex = 6;
            lblNationalID.Text = "الرقم الوطني:";
            // 
            // txtNationalID
            // 
            txtNationalID.Font = new Font("Segoe UI", 9.5F);
            txtNationalID.Location = new Point(20, 111);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(330, 29);
            txtNationalID.TabIndex = 7;
            txtNationalID.TextAlign = HorizontalAlignment.Right;
            // 
            // gbDemographic
            // 
            gbDemographic.Controls.Add(lblGender);
            gbDemographic.Controls.Add(cbGender);
            gbDemographic.Controls.Add(lblDOB);
            gbDemographic.Controls.Add(dtpDOB);
            gbDemographic.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbDemographic.ForeColor = Color.FromArgb(55, 71, 133);
            gbDemographic.Location = new Point(270, 175);
            gbDemographic.Name = "gbDemographic";
            gbDemographic.RightToLeft = RightToLeft.Yes;
            gbDemographic.Size = new Size(705, 90);
            gbDemographic.TabIndex = 1;
            gbDemographic.TabStop = false;
            gbDemographic.Text = "الجنس وتاريخ الميلاد";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(107, 114, 128);
            lblGender.Location = new Point(625, 23);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(52, 20);
            lblGender.TabIndex = 0;
            lblGender.Text = "الجنس:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.5F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cbGender.Location = new Point(370, 48);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(310, 29);
            cbGender.TabIndex = 1;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDOB.ForeColor = Color.FromArgb(107, 114, 128);
            lblDOB.Location = new Point(265, 23);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(88, 20);
            lblDOB.TabIndex = 2;
            lblDOB.Text = "تاريخ الميلاد:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 9.5F);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(20, 48);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(330, 29);
            dtpDOB.TabIndex = 3;
            // 
            // gbContact
            // 
            gbContact.Controls.Add(lblPhoneNumber);
            gbContact.Controls.Add(txtPhoneNumber);
            gbContact.Controls.Add(lblEmail);
            gbContact.Controls.Add(txtEmail);
            gbContact.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbContact.ForeColor = Color.FromArgb(55, 71, 133);
            gbContact.Location = new Point(15, 275);
            gbContact.Name = "gbContact";
            gbContact.RightToLeft = RightToLeft.Yes;
            gbContact.Size = new Size(960, 95);
            gbContact.TabIndex = 2;
            gbContact.TabStop = false;
            gbContact.Text = "بيانات الاتصال والتواصل";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhoneNumber.Location = new Point(860, 24);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(79, 20);
            lblPhoneNumber.TabIndex = 0;
            lblPhoneNumber.Text = "رقم الهاتف:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new Point(500, 48);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(440, 29);
            txtPhoneNumber.TabIndex = 1;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(107, 114, 128);
            lblEmail.Location = new Point(345, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(111, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "البريد الإلكتروني:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(20, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 29);
            txtEmail.TabIndex = 3;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // gbAcademic
            // 
            gbAcademic.Controls.Add(lblNationality);
            gbAcademic.Controls.Add(txtNationality);
            gbAcademic.Controls.Add(lblBloodType);
            gbAcademic.Controls.Add(cbBloodType);
            gbAcademic.Controls.Add(lblAddress);
            gbAcademic.Controls.Add(txtAddress);
            gbAcademic.Controls.Add(lblPreviousSchool);
            gbAcademic.Controls.Add(txtPreviousSchool);
            gbAcademic.Controls.Add(lblAdmissionDate);
            gbAcademic.Controls.Add(dtpAdmissionDate);
            gbAcademic.Controls.Add(lblHealthStatus);
            gbAcademic.Controls.Add(cbHealthStatus);
            gbAcademic.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbAcademic.ForeColor = Color.FromArgb(55, 71, 133);
            gbAcademic.Location = new Point(15, 380);
            gbAcademic.Name = "gbAcademic";
            gbAcademic.RightToLeft = RightToLeft.Yes;
            gbAcademic.Size = new Size(960, 255);
            gbAcademic.TabIndex = 3;
            gbAcademic.TabStop = false;
            gbAcademic.Text = "البيانات الأكاديمية والصحية الإضافية";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNationality.ForeColor = Color.FromArgb(107, 114, 128);
            lblNationality.Location = new Point(880, 24);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(62, 20);
            lblNationality.TabIndex = 0;
            lblNationality.Text = "الجنسية:";
            // 
            // txtNationality
            // 
            txtNationality.Font = new Font("Segoe UI", 9.5F);
            txtNationality.Location = new Point(500, 48);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(440, 29);
            txtNationality.TabIndex = 1;
            txtNationality.Text = "يمني";
            txtNationality.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBloodType.ForeColor = Color.FromArgb(107, 114, 128);
            lblBloodType.Location = new Point(375, 24);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(81, 20);
            lblBloodType.TabIndex = 2;
            lblBloodType.Text = "فصيلة الدم:";
            // 
            // cbBloodType
            // 
            cbBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBloodType.Font = new Font("Segoe UI", 9.5F);
            cbBloodType.FormattingEnabled = true;
            cbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "غير محدد" });
            cbBloodType.Location = new Point(20, 48);
            cbBloodType.Name = "cbBloodType";
            cbBloodType.Size = new Size(440, 29);
            cbBloodType.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(107, 114, 128);
            lblAddress.Location = new Point(885, 95);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "العنوان:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(500, 118);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(440, 29);
            txtAddress.TabIndex = 5;
            txtAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPreviousSchool
            // 
            lblPreviousSchool.AutoSize = true;
            lblPreviousSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPreviousSchool.ForeColor = Color.FromArgb(107, 114, 128);
            lblPreviousSchool.Location = new Point(345, 95);
            lblPreviousSchool.Name = "lblPreviousSchool";
            lblPreviousSchool.Size = new Size(111, 20);
            lblPreviousSchool.TabIndex = 6;
            lblPreviousSchool.Text = "المدرسة السابقة:";
            // 
            // txtPreviousSchool
            // 
            txtPreviousSchool.Font = new Font("Segoe UI", 9.5F);
            txtPreviousSchool.Location = new Point(20, 118);
            txtPreviousSchool.Name = "txtPreviousSchool";
            txtPreviousSchool.Size = new Size(440, 29);
            txtPreviousSchool.TabIndex = 7;
            txtPreviousSchool.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.AutoSize = true;
            lblAdmissionDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdmissionDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblAdmissionDate.Location = new Point(860, 165);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(84, 20);
            lblAdmissionDate.TabIndex = 8;
            lblAdmissionDate.Text = "تاريخ القبول:";
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Font = new Font("Segoe UI", 9.5F);
            dtpAdmissionDate.Format = DateTimePickerFormat.Short;
            dtpAdmissionDate.Location = new Point(500, 188);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(440, 29);
            dtpAdmissionDate.TabIndex = 9;
            // 
            // lblHealthStatus
            // 
            lblHealthStatus.AutoSize = true;
            lblHealthStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHealthStatus.ForeColor = Color.FromArgb(107, 114, 128);
            lblHealthStatus.Location = new Point(360, 165);
            lblHealthStatus.Name = "lblHealthStatus";
            lblHealthStatus.Size = new Size(95, 20);
            lblHealthStatus.TabIndex = 10;
            lblHealthStatus.Text = "الحالة الصحية:";
            // 
            // cbHealthStatus
            // 
            cbHealthStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHealthStatus.Font = new Font("Segoe UI", 9.5F);
            cbHealthStatus.FormattingEnabled = true;
            cbHealthStatus.Items.AddRange(new object[] { "سليم / لائق صحياً", "حالة مزمنة", "يحتاج رعاية خاصة", "أخرى" });
            cbHealthStatus.Location = new Point(20, 188);
            cbHealthStatus.Name = "cbHealthStatus";
            cbHealthStatus.Size = new Size(440, 29);
            cbHealthStatus.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(55, 71, 133);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(29, 765);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 46);
            btnSave.TabIndex = 2;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(31, 41, 55);
            btnCancel.Location = new Point(195, 765);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // opfImage
            // 
            opfImage.FileName = "openFileDialog1";
            // 
            // frmRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1054, 830);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegisterStudent";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تسجيل وقيد طالب";
            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxStudentImage).EndInit();
            gbPersonal.ResumeLayout(false);
            gbPersonal.PerformLayout();
            gbDemographic.ResumeLayout(false);
            gbDemographic.PerformLayout();
            gbContact.ResumeLayout(false);
            gbContact.PerformLayout();
            gbAcademic.ResumeLayout(false);
            gbAcademic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.GroupBox gbDemographic;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbAcademic;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPreviousSchool;
        private System.Windows.Forms.TextBox txtPreviousSchool;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.ComboBox cbHealthStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PictureBox pbxStudentImage;
        private LinkLabel llblSetImage;
        private OpenFileDialog opfImage;
    }
}
