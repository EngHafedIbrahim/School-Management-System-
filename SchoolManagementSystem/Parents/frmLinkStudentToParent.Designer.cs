namespace SchoolManagementSystem.Parents
{
    partial class frmLinkStudentToParent
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
            pnlCard = new Panel();
            chkIsPrimary = new CheckBox();
            cbRelationship = new ComboBox();
            lblRel = new Label();
            cbStudents = new ComboBox();
            lblStudent = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
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
            pnlHeader.Size = new Size(496, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(150, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(217, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Link Child / Student";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(chkIsPrimary);
            pnlCard.Controls.Add(cbRelationship);
            pnlCard.Controls.Add(lblRel);
            pnlCard.Controls.Add(cbStudents);
            pnlCard.Controls.Add(lblStudent);
            pnlCard.Location = new Point(23, 100);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(17, 20, 17, 20);
            pnlCard.Size = new Size(451, 239);
            pnlCard.TabIndex = 1;
            // 
            // chkIsPrimary
            // 
            chkIsPrimary.AutoSize = true;
            chkIsPrimary.Font = new Font("Segoe UI", 9.5F);
            chkIsPrimary.ForeColor = Color.FromArgb(33, 37, 41);
            chkIsPrimary.Location = new Point(17, 184);
            chkIsPrimary.Margin = new Padding(3, 4, 3, 4);
            chkIsPrimary.Name = "chkIsPrimary";
            chkIsPrimary.Size = new Size(243, 25);
            chkIsPrimary.TabIndex = 4;
            chkIsPrimary.Text = "Is Primary Contact For Student";
            chkIsPrimary.UseVisualStyleBackColor = true;
            // 
            // cbRelationship
            // 
            cbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRelationship.Font = new Font("Segoe UI", 9.5F);
            cbRelationship.FormattingEnabled = true;
            cbRelationship.Items.AddRange(new object[] { "Father", "Mother", "Guardian", "Uncle", "Aunt", "Brother", "Sister", "Other" });
            cbRelationship.Location = new Point(17, 131);
            cbRelationship.Margin = new Padding(3, 4, 3, 4);
            cbRelationship.Name = "cbRelationship";
            cbRelationship.Size = new Size(411, 29);
            cbRelationship.TabIndex = 3;
            // 
            // lblRel
            // 
            lblRel.AutoSize = true;
            lblRel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRel.ForeColor = Color.FromArgb(33, 37, 41);
            lblRel.Location = new Point(17, 100);
            lblRel.Name = "lblRel";
            lblRel.Size = new Size(121, 21);
            lblRel.TabIndex = 2;
            lblRel.Text = "Relationship *:";
            // 
            // cbStudents
            // 
            cbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudents.Font = new Font("Segoe UI", 9.5F);
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new Point(17, 51);
            cbStudents.Margin = new Padding(3, 4, 3, 4);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new Size(411, 29);
            cbStudents.TabIndex = 1;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(33, 37, 41);
            lblStudent.Location = new Point(17, 20);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(135, 21);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Select Student *:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(223, 353);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Link Student";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(360, 353);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // frmLinkStudentToParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(496, 415);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLinkStudentToParent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Link Student to Parent";
            Load += FrmLinkStudentToParent_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Label lblRel;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.CheckBox chkIsPrimary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
