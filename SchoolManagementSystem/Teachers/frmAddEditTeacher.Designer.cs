namespace SchoolManagementSystem.Teachers
{
    partial class frmAddEditTeacher
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
            txtAbout = new TextBox();
            lblAbout = new Label();
            cbEmploymentStatus = new ComboBox();
            lblEmploymentStatus = new Label();
            dtpHireDate = new DateTimePicker();
            lblHireDate = new Label();
            txtQualification = new TextBox();
            lblQualification = new Label();
            txtSpecialization = new TextBox();
            lblSpecialization = new Label();
            cbGender = new ComboBox();
            lblGender = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
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
            pnlHeader.Size = new Size(782, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(275, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(230, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "تسجيل بيانات المعلم";
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtAbout);
            pnlCard.Controls.Add(lblAbout);
            pnlCard.Controls.Add(cbEmploymentStatus);
            pnlCard.Controls.Add(lblEmploymentStatus);
            pnlCard.Controls.Add(dtpHireDate);
            pnlCard.Controls.Add(lblHireDate);
            pnlCard.Controls.Add(txtQualification);
            pnlCard.Controls.Add(lblQualification);
            pnlCard.Controls.Add(txtSpecialization);
            pnlCard.Controls.Add(lblSpecialization);
            pnlCard.Controls.Add(cbGender);
            pnlCard.Controls.Add(lblGender);
            pnlCard.Controls.Add(txtAddress);
            pnlCard.Controls.Add(lblAddress);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtPhoneNumber);
            pnlCard.Controls.Add(lblPhoneNumber);
            pnlCard.Controls.Add(txtLastName);
            pnlCard.Controls.Add(lblLastName);
            pnlCard.Controls.Add(txtFirstName);
            pnlCard.Controls.Add(lblFirstName);
            pnlCard.Location = new Point(23, 95);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(736, 575);
            pnlCard.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(30, 41, 59);
            lblFirstName.Location = new Point(610, 25);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(98, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "الاسم الأول *:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(390, 50);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(320, 29);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(30, 41, 59);
            lblLastName.Location = new Point(245, 25);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "اسم العائلة *:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(25, 50);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(320, 29);
            txtLastName.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(30, 41, 59);
            lblPhoneNumber.Location = new Point(610, 95);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(97, 21);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "رقم الهاتف *:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new Point(390, 120);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(320, 29);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmail.Location = new Point(205, 95);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(135, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "البريد الإلكتروني *:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(25, 120);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(30, 41, 59);
            lblGender.Location = new Point(640, 165);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 21);
            lblGender.TabIndex = 8;
            lblGender.Text = "الجنس *:";
            // 
            // cbGender
            // 
            cbGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.5F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cbGender.Location = new Point(390, 190);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(320, 29);
            cbGender.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(30, 41, 59);
            lblAddress.Location = new Point(245, 165);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(96, 21);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "عنوان السكن:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(25, 190);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(320, 29);
            txtAddress.TabIndex = 11;
            // 
            // lblSpecialization
            // 
            lblSpecialization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSpecialization.ForeColor = Color.FromArgb(30, 41, 59);
            lblSpecialization.Location = new Point(540, 235);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(168, 21);
            lblSpecialization.TabIndex = 12;
            lblSpecialization.Text = "التخصص / المادة الدراسية:";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSpecialization.Font = new Font("Segoe UI", 9.5F);
            txtSpecialization.Location = new Point(390, 260);
            txtSpecialization.Margin = new Padding(3, 4, 3, 4);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(320, 29);
            txtSpecialization.TabIndex = 13;
            // 
            // lblQualification
            // 
            lblQualification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQualification.AutoSize = true;
            lblQualification.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQualification.ForeColor = Color.FromArgb(30, 41, 59);
            lblQualification.Location = new Point(230, 235);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(111, 21);
            lblQualification.TabIndex = 14;
            lblQualification.Text = "المؤهل العلمي *:";
            // 
            // txtQualification
            // 
            txtQualification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQualification.Font = new Font("Segoe UI", 9.5F);
            txtQualification.Location = new Point(25, 260);
            txtQualification.Margin = new Padding(3, 4, 3, 4);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(320, 29);
            txtQualification.TabIndex = 15;
            // 
            // lblHireDate
            // 
            lblHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHireDate.ForeColor = Color.FromArgb(30, 41, 59);
            lblHireDate.Location = new Point(605, 310);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(103, 21);
            lblHireDate.TabIndex = 16;
            lblHireDate.Text = "تاريخ التعيين *:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpHireDate.Font = new Font("Segoe UI", 9.5F);
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Location = new Point(390, 335);
            dtpHireDate.Margin = new Padding(3, 4, 3, 4);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(320, 29);
            dtpHireDate.TabIndex = 17;
            // 
            // lblEmploymentStatus
            // 
            lblEmploymentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmploymentStatus.AutoSize = true;
            lblEmploymentStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmploymentStatus.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmploymentStatus.Location = new Point(225, 310);
            lblEmploymentStatus.Name = "lblEmploymentStatus";
            lblEmploymentStatus.Size = new Size(116, 21);
            lblEmploymentStatus.TabIndex = 18;
            lblEmploymentStatus.Text = "الحالة الوظيفية *:";
            // 
            // cbEmploymentStatus
            // 
            cbEmploymentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbEmploymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmploymentStatus.Font = new Font("Segoe UI", 9.5F);
            cbEmploymentStatus.FormattingEnabled = true;
            cbEmploymentStatus.Items.AddRange(new object[] { "نشط", "في إجازة", "تحت التجربة", "موقوف", "مستقيل" });
            cbEmploymentStatus.Location = new Point(25, 335);
            cbEmploymentStatus.Margin = new Padding(3, 4, 3, 4);
            cbEmploymentStatus.Name = "cbEmploymentStatus";
            cbEmploymentStatus.Size = new Size(320, 29);
            cbEmploymentStatus.TabIndex = 19;
            // 
            // lblAbout
            // 
            lblAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAbout.ForeColor = Color.FromArgb(30, 41, 59);
            lblAbout.Location = new Point(540, 395);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(170, 21);
            lblAbout.TabIndex = 20;
            lblAbout.Text = "نبذة تعريفية وملاحظات:";
            // 
            // txtAbout
            // 
            txtAbout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAbout.Font = new Font("Segoe UI", 9.5F);
            txtAbout.Location = new Point(25, 420);
            txtAbout.Margin = new Padding(3, 4, 3, 4);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(685, 115);
            txtAbout.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(145, 695);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "حفظ البيانات";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(25, 695);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmAddEditTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(782, 760);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditTeacher";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة بيانات المعلم";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblEmploymentStatus;
        private System.Windows.Forms.ComboBox cbEmploymentStatus;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
