namespace SchoolManagementSystem.Courses
{
    partial class frmAddEditCourse
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
            txtDescription = new TextBox();
            lblDescription = new Label();
            numCreditHours = new NumericUpDown();
            lblCreditHours = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCreditHours).BeginInit();
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
            lblHeaderTitle.Location = new Point(160, 20);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(232, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "بيانات المادة الدراسية";
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtDescription);
            pnlCard.Controls.Add(lblDescription);
            pnlCard.Controls.Add(numCreditHours);
            pnlCard.Controls.Add(lblCreditHours);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Location = new Point(25, 95);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(20);
            pnlCard.Size = new Size(490, 310);
            pnlCard.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(25, 198);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(440, 80);
            txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(30, 41, 59);
            lblDescription.Location = new Point(310, 170);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(177, 21);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "وصف المقرر والملاحظات:";
            // 
            // numCreditHours
            // 
            numCreditHours.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numCreditHours.Font = new Font("Segoe UI", 9.5F);
            numCreditHours.Location = new Point(315, 123);
            numCreditHours.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numCreditHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCreditHours.Name = "numCreditHours";
            numCreditHours.Size = new Size(150, 29);
            numCreditHours.TabIndex = 3;
            numCreditHours.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblCreditHours
            // 
            lblCreditHours.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCreditHours.AutoSize = true;
            lblCreditHours.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCreditHours.ForeColor = Color.FromArgb(30, 41, 59);
            lblCreditHours.Location = new Point(265, 95);
            lblCreditHours.Name = "lblCreditHours";
            lblCreditHours.Size = new Size(198, 21);
            lblCreditHours.TabIndex = 2;
            lblCreditHours.Text = "الساعات الأسبوعية المعتمدة :";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(25, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(440, 29);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 41, 59);
            lblName.Location = new Point(320, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 21);
            lblName.TabIndex = 0;
            lblName.Text = "اسم المادة / المقرر :";
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
            btnSave.Text = "حفظ المادة";
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
            // frmAddEditCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "frmAddEditCourse";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "بيانات المادة الدراسية";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCreditHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.NumericUpDown numCreditHours;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
