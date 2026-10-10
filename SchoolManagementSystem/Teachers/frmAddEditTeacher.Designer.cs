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
            pnlHeader.Size = new Size(782, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(268, 16);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(255, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Teacher Registration";
            // 
            // pnlCard
            // 
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
            pnlCard.Location = new Point(23, 113);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(736, 573);
            pnlCard.TabIndex = 1;
            // 
            // txtAbout
            // 
            txtAbout.Font = new Font("Segoe UI", 9.5F);
            txtAbout.Location = new Point(23, 467);
            txtAbout.Margin = new Padding(3, 4, 3, 4);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(685, 65);
            txtAbout.TabIndex = 21;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAbout.ForeColor = Color.FromArgb(33, 37, 41);
            lblAbout.Location = new Point(23, 440);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(159, 21);
            lblAbout.TabIndex = 20;
            lblAbout.Text = "Brief Bio / Remarks:";
            // 
            // cbEmploymentStatus
            // 
            cbEmploymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmploymentStatus.Font = new Font("Segoe UI", 9.5F);
            cbEmploymentStatus.FormattingEnabled = true;
            cbEmploymentStatus.Items.AddRange(new object[] { "Active", "On Leave", "Probation", "Suspended", "Resigned" });
            cbEmploymentStatus.Location = new Point(389, 380);
            cbEmploymentStatus.Margin = new Padding(3, 4, 3, 4);
            cbEmploymentStatus.Name = "cbEmploymentStatus";
            cbEmploymentStatus.Size = new Size(319, 29);
            cbEmploymentStatus.TabIndex = 19;
            // 
            // lblEmploymentStatus
            // 
            lblEmploymentStatus.AutoSize = true;
            lblEmploymentStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmploymentStatus.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmploymentStatus.Location = new Point(389, 353);
            lblEmploymentStatus.Name = "lblEmploymentStatus";
            lblEmploymentStatus.Size = new Size(171, 21);
            lblEmploymentStatus.TabIndex = 18;
            lblEmploymentStatus.Text = "Employment Status  :";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Segoe UI", 9.5F);
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Location = new Point(23, 380);
            dtpHireDate.Margin = new Padding(3, 4, 3, 4);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(319, 29);
            dtpHireDate.TabIndex = 17;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHireDate.ForeColor = Color.FromArgb(33, 37, 41);
            lblHireDate.Location = new Point(23, 353);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(94, 21);
            lblHireDate.TabIndex = 16;
            lblHireDate.Text = "Hire Date  :";
            // 
            // txtQualification
            // 
            txtQualification.Font = new Font("Segoe UI", 9.5F);
            txtQualification.Location = new Point(389, 300);
            txtQualification.Margin = new Padding(3, 4, 3, 4);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(319, 29);
            txtQualification.TabIndex = 15;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQualification.ForeColor = Color.FromArgb(33, 37, 41);
            lblQualification.Location = new Point(389, 273);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(185, 21);
            lblQualification.TabIndex = 14;
            lblQualification.Text = "Highest Qualification  :";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Segoe UI", 9.5F);
            txtSpecialization.Location = new Point(23, 300);
            txtSpecialization.Margin = new Padding(3, 4, 3, 4);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(319, 29);
            txtSpecialization.TabIndex = 13;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSpecialization.ForeColor = Color.FromArgb(33, 37, 41);
            lblSpecialization.Location = new Point(23, 273);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(192, 21);
            lblSpecialization.TabIndex = 12;
            lblSpecialization.Text = "Academic Subject/Area:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.5F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Femal" });
            cbGender.Location = new Point(389, 213);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(319, 29);
            cbGender.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(33, 37, 41);
            lblGender.Location = new Point(389, 187);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(77, 21);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender  :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(23, 213);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(319, 29);
            txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(33, 37, 41);
            lblAddress.Location = new Point(23, 187);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 21);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(389, 127);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmail.Location = new Point(389, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email Address :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new Point(23, 127);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(319, 29);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(33, 37, 41);
            lblPhoneNumber.Location = new Point(23, 100);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(138, 21);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone Number  :";
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
            lblLastName.ForeColor = Color.FromArgb(33, 37, 41);
            lblLastName.Location = new Point(389, 27);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(23, 53);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(319, 29);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(33, 37, 41);
            lblFirstName.Location = new Point(23, 27);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(486, 707);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 48);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Teacher";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(646, 707);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 48);
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
            // frmAddEditTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(782, 773);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditTeacher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Teacher Management";
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
