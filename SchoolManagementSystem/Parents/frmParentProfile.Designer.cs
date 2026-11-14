namespace SchoolManagementSystem.Parents
{
    partial class frmParentProfile
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
            btnEditParent = new Button();
            lblValAddress = new Label();
            lblTAddress = new Label();
            lblValEmail = new Label();
            lblTEmail = new Label();
            lblValPhone = new Label();
            lblTPhone = new Label();
            lblValFullName = new Label();
            lblTFullName = new Label();
            lblValParentID = new Label();
            lblTParentID = new Label();
            pnlChildrenHeader = new Panel();
            btnUnlinkStudent = new Button();
            btnViewStudent = new Button();
            btnLinkStudent = new Button();
            lblChildrenTitle = new Label();
            pnlGridWrapper = new Panel();
            dgvChildren = new DataGridView();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlChildrenHeader.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChildren).BeginInit();
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
            pnlHeader.Size = new Size(987, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(941, 54);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "الملف التعريفي لولي الأمر والأسرة";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(btnEditParent);
            pnlCard.Controls.Add(lblValAddress);
            pnlCard.Controls.Add(lblTAddress);
            pnlCard.Controls.Add(lblValEmail);
            pnlCard.Controls.Add(lblTEmail);
            pnlCard.Controls.Add(lblValPhone);
            pnlCard.Controls.Add(lblTPhone);
            pnlCard.Controls.Add(lblValFullName);
            pnlCard.Controls.Add(lblTFullName);
            pnlCard.Controls.Add(lblValParentID);
            pnlCard.Controls.Add(lblTParentID);
            pnlCard.Location = new Point(23, 95);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(23, 27, 23, 27);
            pnlCard.Size = new Size(943, 185);
            pnlCard.TabIndex = 1;
            // 
            // btnEditParent
            // 
            btnEditParent.Cursor = Cursors.Hand;
            btnEditParent.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEditParent.FlatStyle = FlatStyle.Flat;
            btnEditParent.Font = new Font("Segoe UI", 9.5F);
            btnEditParent.Location = new Point(20, 120);
            btnEditParent.Margin = new Padding(3, 4, 3, 4);
            btnEditParent.Name = "btnEditParent";
            btnEditParent.Size = new Size(160, 42);
            btnEditParent.TabIndex = 10;
            btnEditParent.Text = "✏️ تعديل البيانات";
            btnEditParent.UseVisualStyleBackColor = true;
            btnEditParent.Click += BtnEditParent_Click;
            // 
            // lblValAddress
            // 
            lblValAddress.Font = new Font("Segoe UI", 10F);
            lblValAddress.ForeColor = Color.FromArgb(33, 37, 41);
            lblValAddress.Location = new Point(200, 85);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(200, 25);
            lblValAddress.TabIndex = 9;
            lblValAddress.Text = "---";
            // 
            // lblTAddress
            // 
            lblTAddress.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTAddress.ForeColor = Color.FromArgb(120, 130, 140);
            lblTAddress.Location = new Point(410, 85);
            lblTAddress.Name = "lblTAddress";
            lblTAddress.Size = new Size(110, 25);
            lblTAddress.TabIndex = 8;
            lblTAddress.Text = "العنوان السكني:";
            // 
            // lblValEmail
            // 
            lblValEmail.Font = new Font("Segoe UI", 10F);
            lblValEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblValEmail.Location = new Point(540, 85);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(250, 25);
            lblValEmail.TabIndex = 7;
            lblValEmail.Text = "---";
            // 
            // lblTEmail
            // 
            lblTEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTEmail.ForeColor = Color.FromArgb(120, 130, 140);
            lblTEmail.Location = new Point(800, 85);
            lblTEmail.Name = "lblTEmail";
            lblTEmail.Size = new Size(120, 25);
            lblTEmail.TabIndex = 6;
            lblTEmail.Text = "البريد الإلكتروني:";
            // 
            // lblValPhone
            // 
            lblValPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValPhone.ForeColor = Color.FromArgb(33, 37, 41);
            lblValPhone.Location = new Point(20, 20);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(170, 25);
            lblValPhone.TabIndex = 5;
            lblValPhone.Text = "---";
            // 
            // lblTPhone
            // 
            lblTPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTPhone.ForeColor = Color.FromArgb(120, 130, 140);
            lblTPhone.Location = new Point(200, 20);
            lblTPhone.Name = "lblTPhone";
            lblTPhone.Size = new Size(100, 25);
            lblTPhone.TabIndex = 4;
            lblTPhone.Text = "رقم الهاتف:";
            // 
            // lblValFullName
            // 
            lblValFullName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblValFullName.ForeColor = Color.FromArgb(33, 37, 41);
            lblValFullName.Location = new Point(340, 20);
            lblValFullName.Name = "lblValFullName";
            lblValFullName.Size = new Size(210, 25);
            lblValFullName.TabIndex = 3;
            lblValFullName.Text = "---";
            // 
            // lblTFullName
            // 
            lblTFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTFullName.ForeColor = Color.FromArgb(120, 130, 140);
            lblTFullName.Location = new Point(560, 20);
            lblTFullName.Name = "lblTFullName";
            lblTFullName.Size = new Size(110, 25);
            lblTFullName.TabIndex = 2;
            lblTFullName.Text = "الاسم الكامل:";
            // 
            // lblValParentID
            // 
            lblValParentID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValParentID.ForeColor = Color.FromArgb(41, 128, 185);
            lblValParentID.Location = new Point(700, 20);
            lblValParentID.Name = "lblValParentID";
            lblValParentID.Size = new Size(100, 25);
            lblValParentID.TabIndex = 1;
            lblValParentID.Text = "---";
            // 
            // lblTParentID
            // 
            lblTParentID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTParentID.ForeColor = Color.FromArgb(120, 130, 140);
            lblTParentID.Location = new Point(810, 20);
            lblTParentID.Name = "lblTParentID";
            lblTParentID.Size = new Size(110, 25);
            lblTParentID.TabIndex = 0;
            lblTParentID.Text = "رقم المعرف:";
            // 
            // pnlChildrenHeader
            // 
            pnlChildrenHeader.Controls.Add(btnUnlinkStudent);
            pnlChildrenHeader.Controls.Add(btnViewStudent);
            pnlChildrenHeader.Controls.Add(btnLinkStudent);
            pnlChildrenHeader.Controls.Add(lblChildrenTitle);
            pnlChildrenHeader.Location = new Point(23, 295);
            pnlChildrenHeader.Margin = new Padding(3, 4, 3, 4);
            pnlChildrenHeader.Name = "pnlChildrenHeader";
            pnlChildrenHeader.Size = new Size(943, 55);
            pnlChildrenHeader.TabIndex = 2;
            // 
            // btnUnlinkStudent
            // 
            btnUnlinkStudent.BackColor = Color.FromArgb(192, 57, 43);
            btnUnlinkStudent.Cursor = Cursors.Hand;
            btnUnlinkStudent.FlatAppearance.BorderSize = 0;
            btnUnlinkStudent.FlatStyle = FlatStyle.Flat;
            btnUnlinkStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnUnlinkStudent.ForeColor = Color.White;
            btnUnlinkStudent.Location = new Point(20, 7);
            btnUnlinkStudent.Margin = new Padding(3, 4, 3, 4);
            btnUnlinkStudent.Name = "btnUnlinkStudent";
            btnUnlinkStudent.Size = new Size(135, 40);
            btnUnlinkStudent.TabIndex = 3;
            btnUnlinkStudent.Text = "❌ فك الارتباط";
            btnUnlinkStudent.UseVisualStyleBackColor = false;
            btnUnlinkStudent.Click += BtnUnlinkStudent_Click;
            // 
            // btnViewStudent
            // 
            btnViewStudent.Cursor = Cursors.Hand;
            btnViewStudent.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnViewStudent.FlatStyle = FlatStyle.Flat;
            btnViewStudent.Font = new Font("Segoe UI", 9.5F);
            btnViewStudent.Location = new Point(165, 7);
            btnViewStudent.Margin = new Padding(3, 4, 3, 4);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(160, 40);
            btnViewStudent.TabIndex = 2;
            btnViewStudent.Text = "👁️ عرض ملف الطالب";
            btnViewStudent.UseVisualStyleBackColor = true;
            btnViewStudent.Click += BtnViewStudent_Click;
            // 
            // btnLinkStudent
            // 
            btnLinkStudent.BackColor = Color.FromArgb(41, 128, 185);
            btnLinkStudent.Cursor = Cursors.Hand;
            btnLinkStudent.FlatAppearance.BorderSize = 0;
            btnLinkStudent.FlatStyle = FlatStyle.Flat;
            btnLinkStudent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLinkStudent.ForeColor = Color.White;
            btnLinkStudent.Location = new Point(335, 7);
            btnLinkStudent.Margin = new Padding(3, 4, 3, 4);
            btnLinkStudent.Name = "btnLinkStudent";
            btnLinkStudent.Size = new Size(160, 40);
            btnLinkStudent.TabIndex = 1;
            btnLinkStudent.Text = "🔗 ربط طالب جديد";
            btnLinkStudent.UseVisualStyleBackColor = false;
            btnLinkStudent.Click += BtnLinkStudent_Click;
            // 
            // lblChildrenTitle
            // 
            lblChildrenTitle.AutoSize = true;
            lblChildrenTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChildrenTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblChildrenTitle.Location = new Point(715, 10);
            lblChildrenTitle.Name = "lblChildrenTitle";
            lblChildrenTitle.Size = new Size(221, 28);
            lblChildrenTitle.TabIndex = 0;
            lblChildrenTitle.Text = "الأبناء والطلاب المرتبطون";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.BackColor = Color.White;
            pnlGridWrapper.BorderStyle = BorderStyle.FixedSingle;
            pnlGridWrapper.Controls.Add(dgvChildren);
            pnlGridWrapper.Location = new Point(23, 360);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Size = new Size(943, 340);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvChildren
            // 
            dgvChildren.AllowUserToAddRows = false;
            dgvChildren.AllowUserToDeleteRows = false;
            dgvChildren.AllowUserToOrderColumns = true;
            dgvChildren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChildren.BackgroundColor = Color.White;
            dgvChildren.BorderStyle = BorderStyle.None;
            dgvChildren.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChildren.ColumnHeadersHeight = 29;
            dgvChildren.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChildren.Dock = DockStyle.Fill;
            dgvChildren.Location = new Point(0, 0);
            dgvChildren.Margin = new Padding(3, 4, 3, 4);
            dgvChildren.MultiSelect = false;
            dgvChildren.Name = "dgvChildren";
            dgvChildren.ReadOnly = true;
            dgvChildren.RowHeadersVisible = false;
            dgvChildren.RowHeadersWidth = 51;
            dgvChildren.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChildren.Size = new Size(941, 338);
            dgvChildren.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(23, 715);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 44);
            btnClose.TabIndex = 4;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmParentProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(987, 775);
            Controls.Add(btnClose);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlChildrenHeader);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmParentProfile";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "الملف الشخصي لولي الأمر";
            Load += FrmParentProfile_Load;
            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlChildrenHeader.ResumeLayout(false);
            pnlChildrenHeader.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChildren).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTParentID;
        private System.Windows.Forms.Label lblValParentID;
        private System.Windows.Forms.Label lblTFullName;
        private System.Windows.Forms.Label lblValFullName;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblValPhone;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.Label lblValAddress;
        private System.Windows.Forms.Button btnEditParent;
        private System.Windows.Forms.Panel pnlChildrenHeader;
        private System.Windows.Forms.Label lblChildrenTitle;
        private System.Windows.Forms.Button btnLinkStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnUnlinkStudent;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.Button btnClose;
        private DataGridView dgvChildren;
    }
}
