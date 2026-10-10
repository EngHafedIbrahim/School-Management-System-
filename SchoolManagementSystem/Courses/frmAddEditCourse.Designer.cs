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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(553, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(148, 19);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(251, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Subject Information";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtDescription);
            pnlCard.Controls.Add(lblDescription);
            pnlCard.Controls.Add(numCreditHours);
            pnlCard.Controls.Add(lblCreditHours);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Location = new Point(23, 113);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(507, 306);
            pnlCard.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(23, 189);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(451, 85);
            txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescription.Location = new Point(23, 163);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(195, 21);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Curriculum Description :";
            // 
            // numCreditHours
            // 
            numCreditHours.Font = new Font("Segoe UI", 9.5F);
            numCreditHours.Location = new Point(23, 117);
            numCreditHours.Margin = new Padding(3, 4, 3, 4);
            numCreditHours.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numCreditHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCreditHours.Name = "numCreditHours";
            numCreditHours.Size = new Size(154, 29);
            numCreditHours.TabIndex = 3;
            numCreditHours.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblCreditHours
            // 
            lblCreditHours.AutoSize = true;
            lblCreditHours.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCreditHours.ForeColor = Color.FromArgb(33, 37, 41);
            lblCreditHours.Location = new Point(23, 91);
            lblCreditHours.Name = "lblCreditHours";
            lblCreditHours.Size = new Size(178, 21);
            lblCreditHours.TabIndex = 2;
            lblCreditHours.Text = "Weekly Credit Hours  :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(23, 48);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(451, 29);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(33, 37, 41);
            lblName.Location = new Point(23, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Subject Name  :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(269, 440);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Course";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(417, 440);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 47);
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
            // frmAddEditCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(553, 507);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditCourse";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Course Management";
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
