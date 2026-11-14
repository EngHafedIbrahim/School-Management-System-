namespace SchoolManagementSystem.Enrollment
{
    partial class frmEnrollStudent
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
            lblTitle = new Label();
            pnlCard = new Panel();
            gbEnrollmentInfo = new GroupBox();
            cbGradeLevel = new ComboBox();
            lblGradeLevel = new Label();
            dtpWithdrawalDate = new DateTimePicker();
            lblWithdrawalDate = new Label();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            dtpEnrollmentDate = new DateTimePicker();
            lblEnrollmentDate = new Label();
            cbClass = new ComboBox();
            lblClass = new Label();
            cbAcademicYear = new ComboBox();
            lblAcademicYear = new Label();
            cbStudent = new ComboBox();
            lblStudent = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            gbEnrollmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(725, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(38, 42, 51);
            lblTitle.Location = new Point(23, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(679, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تسجيل قيد طالب في صف";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(gbEnrollmentInfo);
            pnlCard.Controls.Add(btnSave);
            pnlCard.Controls.Add(btnCancel);
            pnlCard.Location = new Point(30, 85);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(15);
            pnlCard.Size = new Size(665, 530);
            pnlCard.TabIndex = 1;
            // 
            // gbEnrollmentInfo
            // 
            gbEnrollmentInfo.Controls.Add(cbGradeLevel);
            gbEnrollmentInfo.Controls.Add(lblGradeLevel);
            gbEnrollmentInfo.Controls.Add(dtpWithdrawalDate);
            gbEnrollmentInfo.Controls.Add(lblWithdrawalDate);
            gbEnrollmentInfo.Controls.Add(cbStatus);
            gbEnrollmentInfo.Controls.Add(lblStatus);
            gbEnrollmentInfo.Controls.Add(dtpEnrollmentDate);
            gbEnrollmentInfo.Controls.Add(lblEnrollmentDate);
            gbEnrollmentInfo.Controls.Add(cbClass);
            gbEnrollmentInfo.Controls.Add(lblClass);
            gbEnrollmentInfo.Controls.Add(cbAcademicYear);
            gbEnrollmentInfo.Controls.Add(lblAcademicYear);
            gbEnrollmentInfo.Controls.Add(cbStudent);
            gbEnrollmentInfo.Controls.Add(lblStudent);
            gbEnrollmentInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbEnrollmentInfo.ForeColor = Color.FromArgb(55, 71, 133);
            gbEnrollmentInfo.Location = new Point(18, 15);
            gbEnrollmentInfo.Name = "gbEnrollmentInfo";
            gbEnrollmentInfo.Padding = new Padding(12);
            gbEnrollmentInfo.Size = new Size(625, 440);
            gbEnrollmentInfo.TabIndex = 0;
            gbEnrollmentInfo.TabStop = false;
            gbEnrollmentInfo.Text = "بيانات القيد والتسجيل";
            // 
            // cbGradeLevel
            // 
            cbGradeLevel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevel.Font = new Font("Segoe UI", 9.5F);
            cbGradeLevel.FormattingEnabled = true;
            cbGradeLevel.Location = new Point(20, 184);
            cbGradeLevel.Name = "cbGradeLevel";
            cbGradeLevel.Size = new Size(585, 29);
            cbGradeLevel.TabIndex = 5;
            cbGradeLevel.SelectionChangeCommitted += CbGradeLevel_SelectionChangeCommitted;
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGradeLevel.ForeColor = Color.FromArgb(107, 114, 128);
            lblGradeLevel.Location = new Point(549, 161);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(56, 20);
            lblGradeLevel.TabIndex = 4;
            lblGradeLevel.Text = " الصف:";
            // 
            // dtpWithdrawalDate
            // 
            dtpWithdrawalDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpWithdrawalDate.Font = new Font("Segoe UI", 9.5F);
            dtpWithdrawalDate.Format = DateTimePickerFormat.Short;
            dtpWithdrawalDate.Location = new Point(20, 406);
            dtpWithdrawalDate.Name = "dtpWithdrawalDate";
            dtpWithdrawalDate.Size = new Size(390, 29);
            dtpWithdrawalDate.TabIndex = 13;
            dtpWithdrawalDate.Visible = false;
            // 
            // lblWithdrawalDate
            // 
            lblWithdrawalDate.AutoSize = true;
            lblWithdrawalDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWithdrawalDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblWithdrawalDate.Location = new Point(420, 406);
            lblWithdrawalDate.Name = "lblWithdrawalDate";
            lblWithdrawalDate.Size = new Size(165, 20);
            lblWithdrawalDate.TabIndex = 12;
            lblWithdrawalDate.Text = "تاريخ الانسحاب / الانتقال:";
            lblWithdrawalDate.Visible = false;
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 9.5F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "نشط", "منقول", "متخرج", "منسحب" });
            cbStatus.Location = new Point(20, 370);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(585, 29);
            cbStatus.TabIndex = 11;
            cbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(107, 114, 128);
            lblStatus.Location = new Point(540, 348);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "الحالة:";
            // 
            // dtpEnrollmentDate
            // 
            dtpEnrollmentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpEnrollmentDate.Font = new Font("Segoe UI", 9.5F);
            dtpEnrollmentDate.Format = DateTimePickerFormat.Short;
            dtpEnrollmentDate.Location = new Point(20, 308);
            dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            dtpEnrollmentDate.Size = new Size(585, 29);
            dtpEnrollmentDate.TabIndex = 9;
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnrollmentDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblEnrollmentDate.Location = new Point(504, 285);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(98, 20);
            lblEnrollmentDate.TabIndex = 8;
            lblEnrollmentDate.Text = "تاريخ التسجيل:";
            // 
            // cbClass
            // 
            cbClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 9.5F);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(20, 246);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(585, 29);
            cbClass.TabIndex = 7;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClass.ForeColor = Color.FromArgb(107, 114, 128);
            lblClass.Location = new Point(544, 223);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(61, 20);
            lblClass.TabIndex = 6;
            lblClass.Text = "الشعبة :";
            // 
            // cbAcademicYear
            // 
            cbAcademicYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cbAcademicYear.FormattingEnabled = true;
            cbAcademicYear.Location = new Point(20, 122);
            cbAcademicYear.Name = "cbAcademicYear";
            cbAcademicYear.Size = new Size(585, 29);
            cbAcademicYear.TabIndex = 3;
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAcademicYear.ForeColor = Color.FromArgb(107, 114, 128);
            lblAcademicYear.Location = new Point(501, 99);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(104, 20);
            lblAcademicYear.TabIndex = 2;
            lblAcademicYear.Text = "السنة الدراسية:";
            // 
            // cbStudent
            // 
            cbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.Font = new Font("Segoe UI", 9.5F);
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(20, 60);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(585, 29);
            cbStudent.TabIndex = 1;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(107, 114, 128);
            lblStudent.Location = new Point(547, 37);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(58, 20);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "الطالب:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(55, 71, 133);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(18, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 44);
            btnSave.TabIndex = 1;
            btnSave.Text = "حفظ القيد";
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
            btnCancel.Location = new Point(183, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 44);
            btnCancel.TabIndex = 2;
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
            // frmEnrollStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(725, 645);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEnrollStudent";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "نموذج قيد وتسجيل طالب";
            Load += FrmEnrollStudent_Load;
            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            gbEnrollmentInfo.ResumeLayout(false);
            gbEnrollmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.GroupBox gbEnrollmentInfo;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cbAcademicYear;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblEnrollmentDate;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblWithdrawalDate;
        private System.Windows.Forms.DateTimePicker dtpWithdrawalDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ComboBox cbGradeLevel;
        private Label lblGradeLevel;
    }
}
