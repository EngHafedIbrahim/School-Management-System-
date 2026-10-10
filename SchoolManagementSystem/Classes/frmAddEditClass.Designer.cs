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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(553, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(145, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(276, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Add Class Information";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtDetails);
            pnlCard.Controls.Add(lblDetails);
            pnlCard.Controls.Add(cbGradeLevels);
            pnlCard.Controls.Add(lblGradeLevel);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblName);
            pnlCard.Location = new Point(23, 113);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(507, 299);
            pnlCard.TabIndex = 1;
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 9.5F);
            txtDetails.Location = new Point(23, 189);
            txtDetails.Margin = new Padding(3, 4, 3, 4);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(451, 79);
            txtDetails.TabIndex = 5;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDetails.ForeColor = Color.FromArgb(33, 37, 41);
            lblDetails.Location = new Point(23, 163);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(134, 21);
            lblDetails.TabIndex = 4;
            lblDetails.Text = "Notes && Details:";
            // 
            // cbGradeLevels
            // 
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevels.Font = new Font("Segoe UI", 9.5F);
            cbGradeLevels.FormattingEnabled = true;
            cbGradeLevels.Location = new Point(23, 117);
            cbGradeLevels.Margin = new Padding(3, 4, 3, 4);
            cbGradeLevels.Name = "cbGradeLevels";
            cbGradeLevels.Size = new Size(451, 29);
            cbGradeLevels.TabIndex = 3;
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGradeLevel.ForeColor = Color.FromArgb(33, 37, 41);
            lblGradeLevel.Location = new Point(23, 91);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(169, 21);
            lblGradeLevel.TabIndex = 2;
            lblGradeLevel.Text = "Grade Level / Stage  :";
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
            lblName.Size = new Size(182, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Class / Section Name  :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(269, 433);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Class";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(417, 433);
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
            // frmAddEditClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(553, 500);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditClass";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Class";
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
