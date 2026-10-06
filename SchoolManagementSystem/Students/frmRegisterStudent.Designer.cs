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
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            pnlCard = new Panel();
            pictureBox1 = new PictureBox();
            cbHealthStatus = new ComboBox();
            lblHealthStatus = new Label();
            dtpAdmissionDate = new DateTimePicker();
            lblAdmissionDate = new Label();
            txtPreviousSchool = new TextBox();
            lblPreviousSchool = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            cbBloodType = new ComboBox();
            lblBloodType = new Label();
            txtNationality = new TextBox();
            lblNationality = new Label();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            cbGender = new ComboBox();
            lblGender = new Label();
            txtNationalID = new TextBox();
            lblNationalID = new Label();
            txtAdmissionNo = new TextBox();
            lblAdmissionNo = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1054, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 10F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblHeaderSubtitle.Location = new Point(286, 54);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(452, 23);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Enter and verify student identity and demographic details.";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(376, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(282, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Student Registration";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(pictureBox1);
            pnlCard.Controls.Add(cbHealthStatus);
            pnlCard.Controls.Add(lblHealthStatus);
            pnlCard.Controls.Add(dtpAdmissionDate);
            pnlCard.Controls.Add(lblAdmissionDate);
            pnlCard.Controls.Add(txtPreviousSchool);
            pnlCard.Controls.Add(lblPreviousSchool);
            pnlCard.Controls.Add(txtAddress);
            pnlCard.Controls.Add(lblAddress);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtPhoneNumber);
            pnlCard.Controls.Add(lblPhoneNumber);
            pnlCard.Controls.Add(cbBloodType);
            pnlCard.Controls.Add(lblBloodType);
            pnlCard.Controls.Add(txtNationality);
            pnlCard.Controls.Add(lblNationality);
            pnlCard.Controls.Add(dtpDOB);
            pnlCard.Controls.Add(lblDOB);
            pnlCard.Controls.Add(cbGender);
            pnlCard.Controls.Add(lblGender);
            pnlCard.Controls.Add(txtNationalID);
            pnlCard.Controls.Add(lblNationalID);
            pnlCard.Controls.Add(txtAdmissionNo);
            pnlCard.Controls.Add(lblAdmissionNo);
            pnlCard.Controls.Add(txtLastName);
            pnlCard.Controls.Add(lblLastName);
            pnlCard.Controls.Add(txtFirstName);
            pnlCard.Controls.Add(lblFirstName);
            pnlCard.Location = new Point(29, 113);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(998, 653);
            pnlCard.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_student_male_1000;
            pictureBox1.Location = new Point(748, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // cbHealthStatus
            // 
            cbHealthStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHealthStatus.Font = new Font("Segoe UI", 9.5F);
            cbHealthStatus.FormattingEnabled = true;
            cbHealthStatus.Items.AddRange(new object[] { "Healthy", "Chronic Condition", "Requires Special Care", "Other" });
            cbHealthStatus.Location = new Point(389, 560);
            cbHealthStatus.Margin = new Padding(3, 4, 3, 4);
            cbHealthStatus.Name = "cbHealthStatus";
            cbHealthStatus.Size = new Size(319, 29);
            cbHealthStatus.TabIndex = 27;
            // 
            // lblHealthStatus
            // 
            lblHealthStatus.AutoSize = true;
            lblHealthStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHealthStatus.Location = new Point(389, 533);
            lblHealthStatus.Name = "lblHealthStatus";
            lblHealthStatus.Size = new Size(116, 21);
            lblHealthStatus.TabIndex = 26;
            lblHealthStatus.Text = "Health Status:";
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Font = new Font("Segoe UI", 9.5F);
            dtpAdmissionDate.Format = DateTimePickerFormat.Short;
            dtpAdmissionDate.Location = new Point(29, 560);
            dtpAdmissionDate.Margin = new Padding(3, 4, 3, 4);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(319, 29);
            dtpAdmissionDate.TabIndex = 25;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.AutoSize = true;
            lblAdmissionDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAdmissionDate.Location = new Point(29, 533);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(145, 21);
            lblAdmissionDate.TabIndex = 24;
            lblAdmissionDate.Text = "Admission Date *:";
            // 
            // txtPreviousSchool
            // 
            txtPreviousSchool.Font = new Font("Segoe UI", 9.5F);
            txtPreviousSchool.Location = new Point(389, 473);
            txtPreviousSchool.Margin = new Padding(3, 4, 3, 4);
            txtPreviousSchool.Name = "txtPreviousSchool";
            txtPreviousSchool.Size = new Size(319, 29);
            txtPreviousSchool.TabIndex = 23;
            // 
            // lblPreviousSchool
            // 
            lblPreviousSchool.AutoSize = true;
            lblPreviousSchool.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPreviousSchool.Location = new Point(389, 447);
            lblPreviousSchool.Name = "lblPreviousSchool";
            lblPreviousSchool.Size = new Size(136, 21);
            lblPreviousSchool.TabIndex = 22;
            lblPreviousSchool.Text = "Previous School:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(29, 473);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(319, 29);
            txtAddress.TabIndex = 21;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddress.Location = new Point(29, 447);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 21);
            lblAddress.TabIndex = 20;
            lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(389, 387);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 29);
            txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.Location = new Point(389, 360);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(121, 21);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email Address:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new Point(29, 387);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(319, 29);
            txtPhoneNumber.TabIndex = 17;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(29, 360);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(131, 21);
            lblPhoneNumber.TabIndex = 16;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // cbBloodType
            // 
            cbBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBloodType.Font = new Font("Segoe UI", 9.5F);
            cbBloodType.FormattingEnabled = true;
            cbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "Unknown" });
            cbBloodType.Location = new Point(389, 300);
            cbBloodType.Margin = new Padding(3, 4, 3, 4);
            cbBloodType.Name = "cbBloodType";
            cbBloodType.Size = new Size(319, 29);
            cbBloodType.TabIndex = 15;
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBloodType.Location = new Point(389, 273);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(99, 21);
            lblBloodType.TabIndex = 14;
            lblBloodType.Text = "Blood Type:";
            // 
            // txtNationality
            // 
            txtNationality.Font = new Font("Segoe UI", 9.5F);
            txtNationality.Location = new Point(29, 300);
            txtNationality.Margin = new Padding(3, 4, 3, 4);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(319, 29);
            txtNationality.TabIndex = 13;
            txtNationality.Text = "Yemeni";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNationality.Location = new Point(29, 273);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(112, 21);
            lblNationality.TabIndex = 12;
            lblNationality.Text = "Nationality *:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 9.5F);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(389, 213);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(319, 29);
            dtpDOB.TabIndex = 11;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDOB.Location = new Point(389, 187);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(122, 21);
            lblDOB.TabIndex = 10;
            lblDOB.Text = "Date of Birth *:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.5F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(29, 213);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(319, 29);
            cbGender.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGender.Location = new Point(29, 187);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 21);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender *:";
            // 
            // txtNationalID
            // 
            txtNationalID.Font = new Font("Segoe UI", 9.5F);
            txtNationalID.Location = new Point(389, 127);
            txtNationalID.Margin = new Padding(3, 4, 3, 4);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(319, 29);
            txtNationalID.TabIndex = 7;
            // 
            // lblNationalID
            // 
            lblNationalID.AutoSize = true;
            lblNationalID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNationalID.Location = new Point(389, 100);
            lblNationalID.Name = "lblNationalID";
            lblNationalID.Size = new Size(113, 21);
            lblNationalID.TabIndex = 6;
            lblNationalID.Text = "National ID *:";
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Font = new Font("Segoe UI", 9.5F);
            txtAdmissionNo.Location = new Point(29, 127);
            txtAdmissionNo.Margin = new Padding(3, 4, 3, 4);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(319, 29);
            txtAdmissionNo.TabIndex = 5;
            // 
            // lblAdmissionNo
            // 
            lblAdmissionNo.AutoSize = true;
            lblAdmissionNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAdmissionNo.Location = new Point(29, 100);
            lblAdmissionNo.Name = "lblAdmissionNo";
            lblAdmissionNo.Size = new Size(132, 21);
            lblAdmissionNo.TabIndex = 4;
            lblAdmissionNo.Text = "Admission No *:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(389, 53);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(319, 29);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLastName.Location = new Point(389, 27);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(105, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name *:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(29, 53);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(319, 29);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFirstName.Location = new Point(29, 27);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name *:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(733, 774);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 48);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Student";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(893, 774);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1054, 855);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegisterStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Register Student";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
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
        private PictureBox pictureBox1;
    }
}
