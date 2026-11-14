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
            lblHeaderTitle = new Label();
            pnlEditor = new Panel();
            cbGradeLevels = new ComboBox();
            label1 = new Label();
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
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1119, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(340, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(440, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "إسناد وتوزيع المواد على الفصول والمعلمين";
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.White;
            pnlEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlEditor.Controls.Add(cbGradeLevels);
            pnlEditor.Controls.Add(label1);
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
            pnlEditor.Location = new Point(0, 75);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(20);
            pnlEditor.Size = new Size(1119, 215);
            pnlEditor.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblFormTitle.Location = new Point(870, 10);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(220, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "إسناد مادة دراسية لفصل جديد";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(940, 48);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 1;
            label1.Text = "المرحلة / الصف الدراسي:";
            // 
            // cbGradeLevels
            // 
            cbGradeLevels.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevels.Font = new Font("Segoe UI", 9.5F);
            cbGradeLevels.FormattingEnabled = true;
            cbGradeLevels.Location = new Point(855, 75);
            cbGradeLevels.Name = "cbGradeLevels";
            cbGradeLevels.Size = new Size(235, 29);
            cbGradeLevels.TabIndex = 2;
            cbGradeLevels.Validating += CbGradeLevels_Validating;
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClass.ForeColor = Color.FromArgb(30, 41, 59);
            lblClass.Location = new Point(720, 48);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(107, 21);
            lblClass.TabIndex = 3;
            lblClass.Text = "الشعبة / الفصل:";
            // 
            // cbClass
            // 
            cbClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 9.5F);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(590, 75);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(237, 29);
            cbClass.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(30, 41, 59);
            lblYear.Location = new Point(460, 48);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(106, 21);
            lblYear.TabIndex = 5;
            lblYear.Text = "السنة الدراسية:";
            // 
            // cbYear
            // 
            cbYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.Font = new Font("Segoe UI", 9.5F);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(345, 75);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(220, 29);
            cbYear.TabIndex = 6;
            // 
            // lblCourse
            // 
            lblCourse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCourse.ForeColor = Color.FromArgb(30, 41, 59);
            lblCourse.Location = new Point(980, 122);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(110, 21);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "المادة / المقرر:";
            // 
            // cbCourse
            // 
            cbCourse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourse.Font = new Font("Segoe UI", 9.5F);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(780, 150);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(310, 29);
            cbCourse.TabIndex = 8;
            // 
            // lblTeacher
            // 
            lblTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTeacher.ForeColor = Color.FromArgb(30, 41, 59);
            lblTeacher.Location = new Point(640, 122);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(100, 21);
            lblTeacher.TabIndex = 9;
            lblTeacher.Text = "المعلم المكلف:";
            // 
            // cbTeacher
            // 
            cbTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeacher.Font = new Font("Segoe UI", 9.5F);
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new Point(345, 150);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(395, 29);
            cbTeacher.TabIndex = 10;
            // 
            // btnAssign
            // 
            btnAssign.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAssign.BackColor = Color.FromArgb(37, 99, 235);
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(30, 68);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(150, 42);
            btnAssign.TabIndex = 11;
            btnAssign.Text = "إسناد المقرر";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += BtnAssign_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.Font = new Font("Segoe UI", 9F);
            btnCancelEdit.Location = new Point(30, 116);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(150, 38);
            btnCancelEdit.TabIndex = 12;
            btnCancelEdit.Text = "إلغاء التعديل";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;
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
            pnlToolbar.Location = new Point(0, 290);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlToolbar.Size = new Size(1119, 70);
            pnlToolbar.TabIndex = 2;
            // 
            // lblFilterYear
            // 
            lblFilterYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterYear.AutoSize = true;
            lblFilterYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterYear.ForeColor = Color.FromArgb(30, 41, 59);
            lblFilterYear.Location = new Point(995, 23);
            lblFilterYear.Name = "lblFilterYear";
            lblFilterYear.Size = new Size(106, 21);
            lblFilterYear.TabIndex = 0;
            lblFilterYear.Text = "السنة الدراسية:";
            // 
            // cbFilterYear
            // 
            cbFilterYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterYear.Font = new Font("Segoe UI", 9.5F);
            cbFilterYear.FormattingEnabled = true;
            cbFilterYear.Location = new Point(810, 20);
            cbFilterYear.Name = "cbFilterYear";
            cbFilterYear.Size = new Size(180, 29);
            cbFilterYear.TabIndex = 1;
            cbFilterYear.SelectedIndexChanged += CbFilterYear_SelectedIndexChanged;
            // 
            // lblFilterClass
            // 
            lblFilterClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterClass.AutoSize = true;
            lblFilterClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterClass.ForeColor = Color.FromArgb(30, 41, 59);
            lblFilterClass.Location = new Point(680, 23);
            lblFilterClass.Name = "lblFilterClass";
            lblFilterClass.Size = new Size(113, 21);
            lblFilterClass.TabIndex = 2;
            lblFilterClass.Text = "المرحلة / الصف:";
            // 
            // cbFilterClass
            // 
            cbFilterClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterClass.Font = new Font("Segoe UI", 9.5F);
            cbFilterClass.FormattingEnabled = true;
            cbFilterClass.Location = new Point(480, 20);
            cbFilterClass.Name = "cbFilterClass";
            cbFilterClass.Size = new Size(195, 29);
            cbFilterClass.TabIndex = 3;
            cbFilterClass.SelectedIndexChanged += CbFilterClass_SelectedIndexChanged;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.Location = new Point(220, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "تعديل المحدد";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRemove.BackColor = Color.FromArgb(220, 38, 38);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(105, 15);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(105, 40);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "إلغاء الإسناد";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(20, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 843);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(20, 12, 20, 12);
            pnlBottom.Size = new Size(1119, 46);
            pnlBottom.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalCount.Location = new Point(880, 12);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(215, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي التكليفات والإسنادات: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvAssignments);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 360);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(20);
            pnlGridWrapper.Size = new Size(1119, 483);
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
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Dock = DockStyle.Fill;
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(1079, 443);
            dgvAssignments.TabIndex = 0;
            dgvAssignments.DoubleClick += DgvAssignments_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmCourseAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1119, 889);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "frmCourseAssignment";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "توزيع وإسناد المواد الدراسية";
            Load += FrmCourseAssignment_Load;
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
        private System.Windows.Forms.Panel pnlEditor;
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
        private ComboBox cbGradeLevels;
        private Label label1;
        private Label lblFormTitle;
    }
}
