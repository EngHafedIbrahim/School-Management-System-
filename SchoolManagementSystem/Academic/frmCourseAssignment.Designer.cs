namespace SchoolManagementSystem.Academic
{
    partial class frmCourseAssignment
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
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            pnlEditor = new Panel();
            btnCancelEdit = new Button();
            btnAssign = new Button();
            cbYear = new ComboBox();
            lblYear = new Label();
            cbTeacher = new ComboBox();
            lblTeacher = new Label();
            cbCourse = new ComboBox();
            lblCourse = new Label();
            cbClass = new ComboBox();
            lblClass = new Label();
            lblFormTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            cbFilterClass = new ComboBox();
            lblFilterClass = new Label();
            cbFilterYear = new ComboBox();
            lblFilterYear = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvAssignments = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(23, 13, 23, 13);
            pnlHeader.Size = new Size(1102, 85);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 10F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblHeaderSubtitle.Location = new Point(25, 53);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(731, 23);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Allocate instructional teaching duties: Class + Subject + Faculty Instructor + Academic Session.";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(328, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(428, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Teaching Assignment Allocation";
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.White;
            pnlEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlEditor.Controls.Add(btnCancelEdit);
            pnlEditor.Controls.Add(btnAssign);
            pnlEditor.Controls.Add(cbYear);
            pnlEditor.Controls.Add(lblYear);
            pnlEditor.Controls.Add(cbTeacher);
            pnlEditor.Controls.Add(lblTeacher);
            pnlEditor.Controls.Add(cbCourse);
            pnlEditor.Controls.Add(lblCourse);
            pnlEditor.Controls.Add(cbClass);
            pnlEditor.Controls.Add(lblClass);
            pnlEditor.Controls.Add(lblFormTitle);
            pnlEditor.Dock = DockStyle.Top;
            pnlEditor.Location = new Point(0, 85);
            pnlEditor.Margin = new Padding(3, 4, 3, 4);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(23, 16, 23, 16);
            pnlEditor.Size = new Size(1102, 153);
            pnlEditor.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 9.5F);
            btnCancelEdit.Location = new Point(943, 100);
            btnCancelEdit.Margin = new Padding(3, 4, 3, 4);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(131, 37);
            btnCancelEdit.TabIndex = 10;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(41, 128, 185);
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(943, 51);
            btnAssign.Margin = new Padding(3, 4, 3, 4);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(131, 43);
            btnAssign.TabIndex = 9;
            btnAssign.Text = "Assign Course";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += BtnAssign_Click;
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.Font = new Font("Segoe UI", 9.5F);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(709, 56);
            cbYear.Margin = new Padding(3, 4, 3, 4);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(211, 29);
            cbYear.TabIndex = 8;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(33, 37, 41);
            lblYear.Location = new Point(709, 29);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(137, 21);
            lblYear.TabIndex = 7;
            lblYear.Text = "Academic Year *:";
            // 
            // cbTeacher
            // 
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeacher.Font = new Font("Segoe UI", 9.5F);
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new Point(480, 56);
            cbTeacher.Margin = new Padding(3, 4, 3, 4);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(211, 29);
            cbTeacher.TabIndex = 6;
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTeacher.ForeColor = Color.FromArgb(33, 37, 41);
            lblTeacher.Location = new Point(480, 29);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(169, 21);
            lblTeacher.TabIndex = 5;
            lblTeacher.Text = "Faculty / Instructor *:";
            // 
            // cbCourse
            // 
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourse.Font = new Font("Segoe UI", 9.5F);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(251, 56);
            cbCourse.Margin = new Padding(3, 4, 3, 4);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(211, 29);
            cbCourse.TabIndex = 4;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(33, 37, 41);
            lblCourse.Location = new Point(251, 29);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(149, 21);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Subject / Course *:";
            // 
            // cbClass
            // 
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 9.5F);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(23, 56);
            cbClass.Margin = new Padding(3, 4, 3, 4);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(211, 29);
            cbClass.TabIndex = 2;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClass.ForeColor = Color.FromArgb(33, 37, 41);
            lblClass.Location = new Point(23, 29);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(175, 21);
            lblClass.TabIndex = 1;
            lblClass.Text = "Target Class / Room *:";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(23, 3);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(201, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Assign Course to Class";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnRemove);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(cbFilterClass);
            pnlToolbar.Controls.Add(lblFilterClass);
            pnlToolbar.Controls.Add(cbFilterYear);
            pnlToolbar.Controls.Add(lblFilterYear);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 238);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(23, 11, 23, 11);
            pnlToolbar.Size = new Size(1102, 67);
            pnlToolbar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(1033, 12);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(192, 57, 43);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(930, 12);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(91, 43);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(805, 12);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 43);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Selected";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // cbFilterClass
            // 
            cbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterClass.Font = new Font("Segoe UI", 9.5F);
            cbFilterClass.FormattingEnabled = true;
            cbFilterClass.Location = new Point(389, 17);
            cbFilterClass.Margin = new Padding(3, 4, 3, 4);
            cbFilterClass.Name = "cbFilterClass";
            cbFilterClass.Size = new Size(205, 29);
            cbFilterClass.TabIndex = 3;
            cbFilterClass.SelectedIndexChanged += CbFilterClass_SelectedIndexChanged;
            // 
            // lblFilterClass
            // 
            lblFilterClass.AutoSize = true;
            lblFilterClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterClass.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterClass.Location = new Point(297, 21);
            lblFilterClass.Name = "lblFilterClass";
            lblFilterClass.Size = new Size(95, 21);
            lblFilterClass.TabIndex = 2;
            lblFilterClass.Text = "Filter Class:";
            // 
            // cbFilterYear
            // 
            cbFilterYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterYear.Font = new Font("Segoe UI", 9.5F);
            cbFilterYear.FormattingEnabled = true;
            cbFilterYear.Location = new Point(118, 17);
            cbFilterYear.Margin = new Padding(3, 4, 3, 4);
            cbFilterYear.Name = "cbFilterYear";
            cbFilterYear.Size = new Size(171, 29);
            cbFilterYear.TabIndex = 1;
            cbFilterYear.SelectedIndexChanged += CbFilterYear_SelectedIndexChanged;
            // 
            // lblFilterYear
            // 
            lblFilterYear.AutoSize = true;
            lblFilterYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterYear.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterYear.Location = new Point(18, 21);
            lblFilterYear.Name = "lblFilterYear";
            lblFilterYear.Size = new Size(91, 21);
            lblFilterYear.TabIndex = 0;
            lblFilterYear.Text = "Filter Year:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 748);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1102, 53);
            pnlBottom.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Left;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Location = new Point(23, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(166, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Assignments: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvAssignments);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 305);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 27, 23, 27);
            pnlGridWrapper.Size = new Size(1102, 443);
            pnlGridWrapper.TabIndex = 4;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.AllowUserToOrderColumns = true;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignments.ColumnHeadersHeight = 29;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAssignments.Dock = DockStyle.Fill;
            dgvAssignments.Location = new Point(23, 27);
            dgvAssignments.Margin = new Padding(3, 4, 3, 4);
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 51;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(1056, 389);
            dgvAssignments.TabIndex = 0;
            dgvAssignments.DoubleClick += DgvAssignments_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmCourseAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1102, 801);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCourseAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Course Assignments";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblFilterYear;
        private System.Windows.Forms.ComboBox cbFilterYear;
        private System.Windows.Forms.Label lblFilterClass;
        private System.Windows.Forms.ComboBox cbFilterClass;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
