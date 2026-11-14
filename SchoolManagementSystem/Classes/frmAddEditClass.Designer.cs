namespace SchoolManagementSystem.Classes
{
    partial class frmAddEditClass
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
            txtDetails = new TextBox();
            lblDetails = new Label();
            cbGradeLevels = new ComboBox();
            lblGradeLevel = new Label();
            txtName = new TextBox();
            lblName = new Label();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(540, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(170, 20);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(200, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "إضافة شعبة دراسية";
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtDetails);
            pnlCard.Controls.Add(lblDetails);
            pnlCard.Controls.Add(cbGradeLevels);
            pnlCard.Controls.Add(lblGradeLevel);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Location = new Point(25, 95);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(20);
            pnlCard.Size = new Size(490, 310);
            pnlCard.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 41, 59);
            lblName.Location = new Point(310, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 21);
            lblName.TabIndex = 0;
            lblName.Text = "اسم الشعبة / الفصل *:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(25, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(435, 29);
            txtName.TabIndex = 1;
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGradeLevel.ForeColor = Color.FromArgb(30, 41, 59);
            lblGradeLevel.Location = new Point(292, 95);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(171, 21);
            lblGradeLevel.TabIndex = 2;
            lblGradeLevel.Text = "المرحلة / الصف الدراسي *:";
            // 
            // cbGradeLevels
            // 
            cbGradeLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevels.Font = new Font("Segoe UI", 9.5F);
            cbGradeLevels.FormattingEnabled = true;
            cbGradeLevels.Location = new Point(25, 123);
            cbGradeLevels.Name = "cbGradeLevels";
            cbGradeLevels.Size = new Size(435, 29);
            cbGradeLevels.TabIndex = 3;
            // 
            // lblDetails
            // 
            lblDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDetails.ForeColor = Color.FromArgb(30, 41, 59);
            lblDetails.Location = new Point(345, 170);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(118, 21);
            lblDetails.TabIndex = 4;
            lblDetails.Text = "ملاحظات وتفاصيل:";
            // 
            // txtDetails
            // 
            txtDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDetails.Font = new Font("Segoe UI", 9.5F);
            txtDetails.Location = new Point(25, 198);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(435, 80);
            txtDetails.TabIndex = 5;
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
            btnSave.Location = new Point(145, 425);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 42);
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
            btnCancel.Location = new Point(25, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 42);
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
            // frmAddEditClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(540, 485);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditClass";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "بيانات الشعبة الدراسية";
            Load += FrmAddEditClass_Load;
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.ComboBox cbGradeLevels;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
