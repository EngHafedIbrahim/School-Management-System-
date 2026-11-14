namespace SchoolManagementSystem.Students
{
    partial class frmLinkParentToStudent
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
            cbParents = new ComboBox();
            lblParent = new Label();
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
            pnlHeader.Size = new Size(500, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(454, 49);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "ربط ولي أمر بالطالب";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(chkIsPrimary);
            pnlCard.Controls.Add(cbRelationship);
            pnlCard.Controls.Add(lblRel);
            pnlCard.Controls.Add(cbParents);
            pnlCard.Controls.Add(lblParent);
            pnlCard.Location = new Point(23, 90);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(17, 20, 17, 20);
            pnlCard.Size = new Size(454, 240);
            pnlCard.TabIndex = 1;
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblParent.ForeColor = Color.FromArgb(33, 37, 41);
            lblParent.Location = new Point(310, 20);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(125, 21);
            lblParent.TabIndex = 0;
            lblParent.Text = "اختر ولي الأمر: *";
            // 
            // cbParents
            // 
            cbParents.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParents.Font = new Font("Segoe UI", 9.5F);
            cbParents.FormattingEnabled = true;
            cbParents.Location = new Point(20, 50);
            cbParents.Margin = new Padding(3, 4, 3, 4);
            cbParents.Name = "cbParents";
            cbParents.Size = new Size(410, 29);
            cbParents.TabIndex = 1;
            // 
            // lblRel
            // 
            lblRel.AutoSize = true;
            lblRel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRel.ForeColor = Color.FromArgb(33, 37, 41);
            lblRel.Location = new Point(335, 100);
            lblRel.Name = "lblRel";
            lblRel.Size = new Size(100, 21);
            lblRel.TabIndex = 2;
            lblRel.Text = "صلة القرابة: *";
            // 
            // cbRelationship
            // 
            cbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRelationship.Font = new Font("Segoe UI", 9.5F);
            cbRelationship.FormattingEnabled = true;
            cbRelationship.Items.AddRange(new object[] { "أب", "أم", "ولي أمر قانوني", "عم", "عمة", "خال", "خالة", "أخ", "أخت", "أخرى" });
            cbRelationship.Location = new Point(20, 130);
            cbRelationship.Margin = new Padding(3, 4, 3, 4);
            cbRelationship.Name = "cbRelationship";
            cbRelationship.Size = new Size(410, 29);
            cbRelationship.TabIndex = 3;
            // 
            // chkIsPrimary
            // 
            chkIsPrimary.AutoSize = true;
            chkIsPrimary.Font = new Font("Segoe UI", 9.5F);
            chkIsPrimary.ForeColor = Color.FromArgb(33, 37, 41);
            chkIsPrimary.Location = new Point(70, 180);
            chkIsPrimary.Margin = new Padding(3, 4, 3, 4);
            chkIsPrimary.Name = "chkIsPrimary";
            chkIsPrimary.Size = new Size(360, 25);
            chkIsPrimary.TabIndex = 4;
            chkIsPrimary.Text = "تعيين كجهة اتصال أساسية لحالات الطوارئ والإشعارات";
            chkIsPrimary.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(145, 345);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 42);
            btnSave.TabIndex = 2;
            btnSave.Text = "🔗 ربط الآن";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.Location = new Point(23, 345);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // frmLinkParentToStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(500, 405);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLinkParentToStudent";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ربط ولي أمر بالطالب";
            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox cbParents;
        private System.Windows.Forms.Label lblRel;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.CheckBox chkIsPrimary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
