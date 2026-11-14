namespace SchoolManagementSystem.Academic
{
    partial class frmAcademicYears
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
            pnlEditor = new Panel();
            btnCancelEdit = new Button();
            btnSave = new Button();
            chkIsCurrent = new CheckBox();
            dtpEndDate = new DateTimePicker();
            lblEnd = new Label();
            dtpStartDate = new DateTimePicker();
            lblStart = new Label();
            txtYearName = new TextBox();
            lblName = new Label();
            lblFormTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSetCurrent = new Button();
            pnlGridWrapper = new Panel();
            dgvYears = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYears).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(987, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(320, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(350, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "إدارة السنوات الأكاديمية والدراسية";
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.White;
            pnlEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlEditor.Controls.Add(btnCancelEdit);
            pnlEditor.Controls.Add(btnSave);
            pnlEditor.Controls.Add(chkIsCurrent);
            pnlEditor.Controls.Add(dtpEndDate);
            pnlEditor.Controls.Add(lblEnd);
            pnlEditor.Controls.Add(dtpStartDate);
            pnlEditor.Controls.Add(lblStart);
            pnlEditor.Controls.Add(txtYearName);
            pnlEditor.Controls.Add(lblName);
            pnlEditor.Controls.Add(lblFormTitle);
            pnlEditor.Dock = DockStyle.Top;
            pnlEditor.Location = new Point(0, 75);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(20);
            pnlEditor.Size = new Size(987, 175);
            pnlEditor.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblFormTitle.Location = new Point(740, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(220, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "إضافة سنة أكاديمية جديدة";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(30, 41, 59);
            lblName.Location = new Point(800, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 21);
            lblName.TabIndex = 1;
            lblName.Text = "اسم السنة الأكاديمية *:";
            // 
            // txtYearName
            // 
            txtYearName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtYearName.Font = new Font("Segoe UI", 9.5F);
            txtYearName.Location = new Point(750, 78);
            txtYearName.Name = "txtYearName";
            txtYearName.Size = new Size(210, 29);
            txtYearName.TabIndex = 2;
            // 
            // lblStart
            // 
            lblStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStart.ForeColor = Color.FromArgb(30, 41, 59);
            lblStart.Location = new Point(605, 50);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(118, 21);
            lblStart.TabIndex = 3;
            lblStart.Text = "تاريخ البداية *:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpStartDate.Font = new Font("Segoe UI", 9.5F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(560, 78);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(165, 29);
            dtpStartDate.TabIndex = 4;
            // 
            // lblEnd
            // 
            lblEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEnd.ForeColor = Color.FromArgb(30, 41, 59);
            lblEnd.Location = new Point(415, 50);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(122, 21);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "تاريخ الانتهاء *:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpEndDate.Font = new Font("Segoe UI", 9.5F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(370, 78);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(165, 29);
            dtpEndDate.TabIndex = 6;
            // 
            // chkIsCurrent
            // 
            chkIsCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkIsCurrent.AutoSize = true;
            chkIsCurrent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkIsCurrent.ForeColor = Color.FromArgb(30, 41, 59);
            chkIsCurrent.Location = new Point(220, 82);
            chkIsCurrent.Name = "chkIsCurrent";
            chkIsCurrent.Size = new Size(131, 25);
            chkIsCurrent.TabIndex = 7;
            chkIsCurrent.Text = "السنة الحالية النشطة";
            chkIsCurrent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(25, 68);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 42);
            btnSave.TabIndex = 8;
            btnSave.Text = "حفظ السنة الأكاديمية";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.Font = new Font("Segoe UI", 9F);
            btnCancelEdit.Location = new Point(25, 116);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(160, 38);
            btnCancelEdit.TabIndex = 9;
            btnCancelEdit.Text = "إلغاء التعديل";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnSetCurrent);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 250);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlToolbar.Size = new Size(987, 65);
            pnlToolbar.TabIndex = 2;
            // 
            // btnSetCurrent
            // 
            btnSetCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetCurrent.BackColor = Color.FromArgb(16, 185, 129);
            btnSetCurrent.Cursor = Cursors.Hand;
            btnSetCurrent.FlatAppearance.BorderSize = 0;
            btnSetCurrent.FlatStyle = FlatStyle.Flat;
            btnSetCurrent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSetCurrent.ForeColor = Color.White;
            btnSetCurrent.Location = new Point(760, 12);
            btnSetCurrent.Name = "btnSetCurrent";
            btnSetCurrent.Size = new Size(200, 42);
            btnSetCurrent.TabIndex = 0;
            btnSetCurrent.Text = "★ تعيين كسنة حالية";
            btnSetCurrent.UseVisualStyleBackColor = false;
            btnSetCurrent.Click += BtnSetCurrent_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(640, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "تعديل المحدد";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(540, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(460, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(70, 42);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvYears);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 315);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(987, 433);
            pnlGridWrapper.TabIndex = 3;
            // 
            // dgvYears
            // 
            dgvYears.AllowUserToAddRows = false;
            dgvYears.AllowUserToDeleteRows = false;
            dgvYears.AllowUserToOrderColumns = true;
            dgvYears.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYears.BackgroundColor = Color.White;
            dgvYears.BorderStyle = BorderStyle.None;
            dgvYears.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvYears.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYears.Dock = DockStyle.Fill;
            dgvYears.MultiSelect = false;
            dgvYears.Name = "dgvYears";
            dgvYears.ReadOnly = true;
            dgvYears.RowHeadersVisible = false;
            dgvYears.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYears.Size = new Size(947, 393);
            dgvYears.TabIndex = 0;
            // 
            // frmAcademicYears
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(987, 748);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "frmAcademicYears";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة السنوات الأكاديمية";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvYears).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkIsCurrent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnSetCurrent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvYears;
    }
}
