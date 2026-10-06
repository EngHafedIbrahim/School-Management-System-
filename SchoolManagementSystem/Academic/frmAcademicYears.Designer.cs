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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(987, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(309, 26);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(337, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Academic Years Calendar";
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
            pnlEditor.Location = new Point(0, 93);
            pnlEditor.Margin = new Padding(3, 4, 3, 4);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(23, 20, 23, 20);
            pnlEditor.Size = new Size(987, 173);
            pnlEditor.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 9.5F);
            btnCancelEdit.Location = new Point(811, 125);
            btnCancelEdit.Margin = new Padding(3, 4, 3, 4);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(149, 37);
            btnCancelEdit.TabIndex = 9;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(811, 77);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Year";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // chkIsCurrent
            // 
            chkIsCurrent.AutoSize = true;
            chkIsCurrent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkIsCurrent.ForeColor = Color.FromArgb(33, 37, 41);
            chkIsCurrent.Location = new Point(617, 85);
            chkIsCurrent.Margin = new Padding(3, 4, 3, 4);
            chkIsCurrent.Name = "chkIsCurrent";
            chkIsCurrent.Size = new Size(176, 25);
            chkIsCurrent.TabIndex = 7;
            chkIsCurrent.Text = "Set As Current Year";
            chkIsCurrent.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 9.5F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(434, 83);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(159, 29);
            dtpEndDate.TabIndex = 6;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEnd.ForeColor = Color.FromArgb(33, 37, 41);
            lblEnd.Location = new Point(434, 53);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(94, 21);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "End Date *:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.5F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(251, 83);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(159, 29);
            dtpStartDate.TabIndex = 4;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStart.ForeColor = Color.FromArgb(33, 37, 41);
            lblStart.Location = new Point(251, 53);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(101, 21);
            lblStart.TabIndex = 3;
            lblStart.Text = "Start Date *:";
            // 
            // txtYearName
            // 
            txtYearName.Font = new Font("Segoe UI", 9.5F);
            txtYearName.Location = new Point(23, 83);
            txtYearName.Margin = new Padding(3, 4, 3, 4);
            txtYearName.Name = "txtYearName";
            txtYearName.Size = new Size(205, 29);
            txtYearName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(33, 37, 41);
            lblName.Location = new Point(23, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(108, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Year Name *:";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(23, 13);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(243, 28);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add New Academic Year";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnSetCurrent);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 266);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(23, 11, 23, 11);
            pnlToolbar.Size = new Size(987, 67);
            pnlToolbar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(491, 11);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(377, 11);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(229, 11);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 43);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Selected";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnSetCurrent
            // 
            btnSetCurrent.BackColor = Color.FromArgb(39, 174, 96);
            btnSetCurrent.Cursor = Cursors.Hand;
            btnSetCurrent.FlatAppearance.BorderSize = 0;
            btnSetCurrent.FlatStyle = FlatStyle.Flat;
            btnSetCurrent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSetCurrent.ForeColor = Color.White;
            btnSetCurrent.Location = new Point(23, 11);
            btnSetCurrent.Margin = new Padding(3, 4, 3, 4);
            btnSetCurrent.Name = "btnSetCurrent";
            btnSetCurrent.Size = new Size(194, 43);
            btnSetCurrent.TabIndex = 0;
            btnSetCurrent.Text = "★ Make Current Year";
            btnSetCurrent.UseVisualStyleBackColor = false;
            btnSetCurrent.Click += BtnSetCurrent_Click;
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvYears);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 333);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(987, 415);
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
            dgvYears.ColumnHeadersHeight = 29;
            dgvYears.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvYears.Dock = DockStyle.Fill;
            dgvYears.Location = new Point(23, 27);
            dgvYears.Margin = new Padding(3, 4, 3, 4);
            dgvYears.MultiSelect = false;
            dgvYears.Name = "dgvYears";
            dgvYears.ReadOnly = true;
            dgvYears.RowHeadersVisible = false;
            dgvYears.RowHeadersWidth = 51;
            dgvYears.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYears.Size = new Size(941, 361);
            dgvYears.TabIndex = 0;
            // 
            // frmAcademicYears
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(987, 748);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAcademicYears";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Academic Years Management";
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
