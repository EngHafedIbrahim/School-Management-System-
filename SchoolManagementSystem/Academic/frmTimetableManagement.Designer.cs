namespace SchoolManagementSystem.Academic
{
    partial class frmTimetableManagement
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
            btnCancelEdit = new Button();
            btnSave = new Button();
            cbRoom = new ComboBox();
            lblRoom = new Label();
            dtpEndTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblStartTime = new Label();
            cbDay = new ComboBox();
            lblDay = new Label();
            cbYear = new ComboBox();
            lblYear = new Label();
            cbClassCourse = new ComboBox();
            lblClassCourse = new Label();
            lblFormTitle = new Label();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            cbFilterDay = new ComboBox();
            lblFilterDay = new Label();
            cbFilterClass = new ComboBox();
            lblFilterClass = new Label();
            cbFilterYear = new ComboBox();
            lblFilterYear = new Label();
            pnlBottom = new Panel();
            lblTotalCount = new Label();
            pnlGridWrapper = new Panel();
            dgvSchedules = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlEditor.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlGridWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
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
            pnlHeader.Size = new Size(1206, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblHeaderTitle.Location = new Point(440, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(330, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "جدول الحصص المدرسي الأسبوعي";
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.White;
            pnlEditor.BorderStyle = BorderStyle.FixedSingle;
            pnlEditor.Controls.Add(btnCancelEdit);
            pnlEditor.Controls.Add(btnSave);
            pnlEditor.Controls.Add(cbRoom);
            pnlEditor.Controls.Add(lblRoom);
            pnlEditor.Controls.Add(dtpEndTime);
            pnlEditor.Controls.Add(lblEndTime);
            pnlEditor.Controls.Add(dtpStartTime);
            pnlEditor.Controls.Add(lblStartTime);
            pnlEditor.Controls.Add(cbDay);
            pnlEditor.Controls.Add(lblDay);
            pnlEditor.Controls.Add(cbYear);
            pnlEditor.Controls.Add(lblYear);
            pnlEditor.Controls.Add(cbClassCourse);
            pnlEditor.Controls.Add(lblClassCourse);
            pnlEditor.Controls.Add(lblFormTitle);
            pnlEditor.Dock = DockStyle.Top;
            pnlEditor.Location = new Point(0, 75);
            pnlEditor.Margin = new Padding(3, 4, 3, 4);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Padding = new Padding(23, 13, 23, 13);
            pnlEditor.Size = new Size(1206, 175);
            pnlEditor.TabIndex = 1;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Cursor = Cursors.Hand;
            btnCancelEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Segoe UI", 9.5F);
            btnCancelEdit.Location = new Point(40, 110);
            btnCancelEdit.Margin = new Padding(3, 4, 3, 4);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(130, 37);
            btnCancelEdit.TabIndex = 14;
            btnCancelEdit.Text = "إلغاء التعديل";
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
            btnSave.Location = new Point(40, 56);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 45);
            btnSave.TabIndex = 13;
            btnSave.Text = "حفظ الحصة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Font = new Font("Segoe UI", 9.5F);
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(200, 64);
            cbRoom.Margin = new Padding(3, 4, 3, 4);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(160, 29);
            cbRoom.TabIndex = 12;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRoom.ForeColor = Color.FromArgb(33, 37, 41);
            lblRoom.Location = new Point(255, 37);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(109, 21);
            lblRoom.TabIndex = 11;
            lblRoom.Text = "القاعة الدراسية:";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Font = new Font("Segoe UI", 9.5F);
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(380, 64);
            dtpEndTime.Margin = new Padding(3, 4, 3, 4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(115, 29);
            dtpEndTime.TabIndex = 10;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEndTime.ForeColor = Color.FromArgb(33, 37, 41);
            lblEndTime.Location = new Point(408, 37);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(91, 21);
            lblEndTime.TabIndex = 9;
            lblEndTime.Text = "نهاية الحصة:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Font = new Font("Segoe UI", 9.5F);
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(515, 64);
            dtpStartTime.Margin = new Padding(3, 4, 3, 4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(115, 29);
            dtpStartTime.TabIndex = 8;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStartTime.ForeColor = Color.FromArgb(33, 37, 41);
            lblStartTime.Location = new Point(545, 37);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(89, 21);
            lblStartTime.TabIndex = 7;
            lblStartTime.Text = "بداية الحصة:";
            // 
            // cbDay
            // 
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDay.Font = new Font("Segoe UI", 9.5F);
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(650, 64);
            cbDay.Margin = new Padding(3, 4, 3, 4);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(140, 29);
            cbDay.TabIndex = 6;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDay.ForeColor = Color.FromArgb(33, 37, 41);
            lblDay.Location = new Point(744, 37);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(50, 21);
            lblDay.TabIndex = 5;
            lblDay.Text = "اليوم:";
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.Font = new Font("Segoe UI", 9.5F);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(940, 118);
            cbYear.Margin = new Padding(3, 4, 3, 4);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(230, 29);
            cbYear.TabIndex = 4;
            cbYear.SelectedIndexChanged += CbYear_SelectedIndexChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(33, 37, 41);
            lblYear.Location = new Point(1065, 96);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(109, 21);
            lblYear.TabIndex = 3;
            lblYear.Text = "السنة الدراسية:";
            // 
            // cbClassCourse
            // 
            cbClassCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClassCourse.Font = new Font("Segoe UI", 9.5F);
            cbClassCourse.FormattingEnabled = true;
            cbClassCourse.Location = new Point(810, 64);
            cbClassCourse.Margin = new Padding(3, 4, 3, 4);
            cbClassCourse.Name = "cbClassCourse";
            cbClassCourse.Size = new Size(360, 29);
            cbClassCourse.TabIndex = 2;
            // 
            // lblClassCourse
            // 
            lblClassCourse.AutoSize = true;
            lblClassCourse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClassCourse.ForeColor = Color.FromArgb(33, 37, 41);
            lblClassCourse.Location = new Point(915, 37);
            lblClassCourse.Name = "lblClassCourse";
            lblClassCourse.Size = new Size(259, 21);
            lblClassCourse.TabIndex = 1;
            lblClassCourse.Text = "الدرس (الشعبة | المادة الدراسية | المعلم):";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(980, 7);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(201, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "جدولة حصة دراسية جديدة";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(cbFilterDay);
            pnlToolbar.Controls.Add(lblFilterDay);
            pnlToolbar.Controls.Add(cbFilterClass);
            pnlToolbar.Controls.Add(lblFilterClass);
            pnlToolbar.Controls.Add(cbFilterYear);
            pnlToolbar.Controls.Add(lblFilterYear);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 250);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(23, 11, 23, 11);
            pnlToolbar.Size = new Size(1206, 67);
            pnlToolbar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(40, 12);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(95, 12);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 43);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.Location = new Point(200, 12);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 43);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "تعديل الحصة";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // cbFilterDay
            // 
            cbFilterDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterDay.Font = new Font("Segoe UI", 9.5F);
            cbFilterDay.FormattingEnabled = true;
            cbFilterDay.Location = new Point(420, 18);
            cbFilterDay.Margin = new Padding(3, 4, 3, 4);
            cbFilterDay.Name = "cbFilterDay";
            cbFilterDay.Size = new Size(140, 29);
            cbFilterDay.TabIndex = 5;
            cbFilterDay.SelectedIndexChanged += CbFilterDay_SelectedIndexChanged;
            // 
            // lblFilterDay
            // 
            lblFilterDay.AutoSize = true;
            lblFilterDay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterDay.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterDay.Location = new Point(565, 22);
            lblFilterDay.Name = "lblFilterDay";
            lblFilterDay.Size = new Size(50, 21);
            lblFilterDay.TabIndex = 4;
            lblFilterDay.Text = "اليوم:";
            // 
            // cbFilterClass
            // 
            cbFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterClass.Font = new Font("Segoe UI", 9.5F);
            cbFilterClass.FormattingEnabled = true;
            cbFilterClass.Location = new Point(640, 18);
            cbFilterClass.Margin = new Padding(3, 4, 3, 4);
            cbFilterClass.Name = "cbFilterClass";
            cbFilterClass.Size = new Size(180, 29);
            cbFilterClass.TabIndex = 3;
            cbFilterClass.SelectedIndexChanged += CbFilterClass_SelectedIndexChanged;
            // 
            // lblFilterClass
            // 
            lblFilterClass.AutoSize = true;
            lblFilterClass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterClass.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterClass.Location = new Point(825, 22);
            lblFilterClass.Name = "lblFilterClass";
            lblFilterClass.Size = new Size(106, 21);
            lblFilterClass.TabIndex = 2;
            lblFilterClass.Text = "الشعبة / الفصل:";
            // 
            // cbFilterYear
            // 
            cbFilterYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterYear.Font = new Font("Segoe UI", 9.5F);
            cbFilterYear.FormattingEnabled = true;
            cbFilterYear.Location = new Point(945, 18);
            cbFilterYear.Margin = new Padding(3, 4, 3, 4);
            cbFilterYear.Name = "cbFilterYear";
            cbFilterYear.Size = new Size(140, 29);
            cbFilterYear.TabIndex = 1;
            cbFilterYear.SelectedIndexChanged += CbFilterYear_SelectedIndexChanged;
            // 
            // lblFilterYear
            // 
            lblFilterYear.AutoSize = true;
            lblFilterYear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFilterYear.ForeColor = Color.FromArgb(33, 37, 41);
            lblFilterYear.Location = new Point(1090, 22);
            lblFilterYear.Name = "lblFilterYear";
            lblFilterYear.Size = new Size(109, 21);
            lblFilterYear.TabIndex = 0;
            lblFilterYear.Text = "السنة الدراسية:";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalCount);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 775);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(23, 13, 23, 13);
            pnlBottom.Size = new Size(1206, 53);
            pnlBottom.TabIndex = 3;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Dock = DockStyle.Right;
            lblTotalCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalCount.Location = new Point(1000, 13);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(183, 21);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "إجمالي الحصص المجدولة: 0";
            // 
            // pnlGridWrapper
            // 
            pnlGridWrapper.Controls.Add(dgvSchedules);
            pnlGridWrapper.Dock = DockStyle.Fill;
            pnlGridWrapper.Location = new Point(0, 317);
            pnlGridWrapper.Margin = new Padding(3, 4, 3, 4);
            pnlGridWrapper.Name = "pnlGridWrapper";
            pnlGridWrapper.Padding = new Padding(23, 20, 23, 20);
            pnlGridWrapper.Size = new Size(1206, 458);
            pnlGridWrapper.TabIndex = 4;
            // 
            // dgvSchedules
            // 
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.AllowUserToDeleteRows = false;
            dgvSchedules.AllowUserToOrderColumns = true;
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.BackgroundColor = Color.White;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSchedules.ColumnHeadersHeight = 35;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedules.Dock = DockStyle.Fill;
            dgvSchedules.Location = new Point(23, 20);
            dgvSchedules.Margin = new Padding(3, 4, 3, 4);
            dgvSchedules.MultiSelect = false;
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(1160, 418);
            dgvSchedules.TabIndex = 0;
            dgvSchedules.DoubleClick += DgvSchedules_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // frmTimetableManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1206, 828);
            Controls.Add(pnlGridWrapper);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlEditor);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTimetableManagement";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة جدول الحصص الأسبوعي المدرسي";
            Load += FrmTimetableManagement_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEditor.ResumeLayout(false);
            pnlEditor.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlGridWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblClassCourse;
        private System.Windows.Forms.ComboBox cbClassCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblFilterYear;
        private System.Windows.Forms.ComboBox cbFilterYear;
        private System.Windows.Forms.Label lblFilterClass;
        private System.Windows.Forms.ComboBox cbFilterClass;
        private System.Windows.Forms.Label lblFilterDay;
        private System.Windows.Forms.ComboBox cbFilterDay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
