namespace SchoolManagementSystem.Finance
{
    partial class frmPaymentsList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlKpiCards = new Panel();
            pnlCardTotal = new Panel();
            lblTotalVal = new Label();
            lblTotalTitle = new Label();
            pnlCardToday = new Panel();
            lblTodayVal = new Label();
            lblTodayTitle = new Label();
            pnlCardMonth = new Panel();
            lblMonthVal = new Label();
            lblMonthTitle = new Label();
            pnlCardCount = new Panel();
            lblCountVal = new Label();
            lblCountTitle = new Label();
            gbFilter = new GroupBox();
            btnRefresh = new Button();
            cbDateFilter = new ComboBox();
            lblDateFilter = new Label();
            cbPaymentMethod = new ComboBox();
            lblPaymentMethod = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvPayments = new DataGridView();
            pnlActions = new Panel();
            lblStatusSummary = new Label();
            btnFeeStructures = new Button();
            btnManageInvoices = new Button();
            btnPaymentTypes = new Button();
            btnViewReceipt = new Button();
            btnViewInvoice = new Button();
            btnNewPayment = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlKpiCards.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            pnlCardToday.SuspendLayout();
            pnlCardMonth.SuspendLayout();
            pnlCardCount.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 12, 24, 0);
            pnlHeader.Size = new Size(1184, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(394, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "مركز وسجل المدفوعات والتحصيل";
            // 
            // pnlHeaderLine
            // 
            pnlHeaderLine.BackColor = Color.FromArgb(220, 224, 230);
            pnlHeaderLine.Dock = DockStyle.Bottom;
            pnlHeaderLine.Location = new Point(24, 74);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(1136, 1);
            pnlHeaderLine.TabIndex = 2;
            // 
            // pnlKpiCards
            // 
            pnlKpiCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlKpiCards.Controls.Add(pnlCardTotal);
            pnlKpiCards.Controls.Add(pnlCardToday);
            pnlKpiCards.Controls.Add(pnlCardMonth);
            pnlKpiCards.Controls.Add(pnlCardCount);
            pnlKpiCards.Location = new Point(24, 85);
            pnlKpiCards.Name = "pnlKpiCards";
            pnlKpiCards.Size = new Size(1136, 75);
            pnlKpiCards.TabIndex = 1;
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCardTotal.BackColor = Color.White;
            pnlCardTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotal.Controls.Add(lblTotalVal);
            pnlCardTotal.Controls.Add(lblTotalTitle);
            pnlCardTotal.Location = new Point(855, 3);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(278, 68);
            pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalVal
            // 
            lblTotalVal.AutoSize = true;
            lblTotalVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalVal.Location = new Point(14, 28);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(77, 32);
            lblTotalVal.TabIndex = 1;
            lblTotalVal.Text = "$0.00";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblTotalTitle.Location = new Point(14, 8);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(110, 20);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "إجمالي التحصيل";
            // 
            // pnlCardToday
            // 
            pnlCardToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCardToday.BackColor = Color.White;
            pnlCardToday.BorderStyle = BorderStyle.FixedSingle;
            pnlCardToday.Controls.Add(lblTodayVal);
            pnlCardToday.Controls.Add(lblTodayTitle);
            pnlCardToday.Location = new Point(570, 3);
            pnlCardToday.Name = "pnlCardToday";
            pnlCardToday.Size = new Size(278, 68);
            pnlCardToday.TabIndex = 1;
            // 
            // lblTodayVal
            // 
            lblTodayVal.AutoSize = true;
            lblTodayVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTodayVal.ForeColor = Color.FromArgb(39, 174, 96);
            lblTodayVal.Location = new Point(14, 28);
            lblTodayVal.Name = "lblTodayVal";
            lblTodayVal.Size = new Size(77, 32);
            lblTodayVal.TabIndex = 1;
            lblTodayVal.Text = "$0.00";
            // 
            // lblTodayTitle
            // 
            lblTodayTitle.AutoSize = true;
            lblTodayTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTodayTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblTodayTitle.Location = new Point(14, 8);
            lblTodayTitle.Name = "lblTodayTitle";
            lblTodayTitle.Size = new Size(101, 20);
            lblTodayTitle.TabIndex = 0;
            lblTodayTitle.Text = "تحصيلات اليوم";
            // 
            // pnlCardMonth
            // 
            pnlCardMonth.BackColor = Color.White;
            pnlCardMonth.BorderStyle = BorderStyle.FixedSingle;
            pnlCardMonth.Controls.Add(lblMonthVal);
            pnlCardMonth.Controls.Add(lblMonthTitle);
            pnlCardMonth.Location = new Point(285, 3);
            pnlCardMonth.Name = "pnlCardMonth";
            pnlCardMonth.Size = new Size(278, 68);
            pnlCardMonth.TabIndex = 2;
            // 
            // lblMonthVal
            // 
            lblMonthVal.AutoSize = true;
            lblMonthVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMonthVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblMonthVal.Location = new Point(14, 28);
            lblMonthVal.Name = "lblMonthVal";
            lblMonthVal.Size = new Size(77, 32);
            lblMonthVal.TabIndex = 1;
            lblMonthVal.Text = "$0.00";
            // 
            // lblMonthTitle
            // 
            lblMonthTitle.AutoSize = true;
            lblMonthTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMonthTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblMonthTitle.Location = new Point(14, 8);
            lblMonthTitle.Name = "lblMonthTitle";
            lblMonthTitle.Size = new Size(132, 20);
            lblMonthTitle.TabIndex = 0;
            lblMonthTitle.Text = "تحصيلات هذا الشهر";
            // 
            // pnlCardCount
            // 
            pnlCardCount.BackColor = Color.White;
            pnlCardCount.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCount.Controls.Add(lblCountVal);
            pnlCardCount.Controls.Add(lblCountTitle);
            pnlCardCount.Location = new Point(0, 3);
            pnlCardCount.Name = "pnlCardCount";
            pnlCardCount.Size = new Size(278, 68);
            pnlCardCount.TabIndex = 3;
            // 
            // lblCountVal
            // 
            lblCountVal.AutoSize = true;
            lblCountVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCountVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblCountVal.Location = new Point(14, 28);
            lblCountVal.Name = "lblCountVal";
            lblCountVal.Size = new Size(28, 32);
            lblCountVal.TabIndex = 1;
            lblCountVal.Text = "0";
            // 
            // lblCountTitle
            // 
            lblCountTitle.AutoSize = true;
            lblCountTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCountTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblCountTitle.Location = new Point(14, 8);
            lblCountTitle.Name = "lblCountTitle";
            lblCountTitle.Size = new Size(106, 20);
            lblCountTitle.TabIndex = 0;
            lblCountTitle.Text = "إجمالي الحركات";
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFilter.Controls.Add(btnRefresh);
            gbFilter.Controls.Add(cbDateFilter);
            gbFilter.Controls.Add(lblDateFilter);
            gbFilter.Controls.Add(cbPaymentMethod);
            gbFilter.Controls.Add(lblPaymentMethod);
            gbFilter.Controls.Add(txtSearch);
            gbFilter.Controls.Add(lblSearch);
            gbFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(44, 62, 80);
            gbFilter.Location = new Point(24, 165);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1136, 85);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "البحث والتصفية";
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.Location = new Point(20, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 36);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // cbDateFilter
            // 
            cbDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDateFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDateFilter.Font = new Font("Segoe UI", 9.5F);
            cbDateFilter.FormattingEnabled = true;
            cbDateFilter.Items.AddRange(new object[] { "كل التواريخ", "اليوم", "هذا الأسبوع", "هذا الشهر", "آخر 30 يوماً" });
            cbDateFilter.Location = new Point(160, 35);
            cbDateFilter.Name = "cbDateFilter";
            cbDateFilter.Size = new Size(180, 29);
            cbDateFilter.TabIndex = 5;
            cbDateFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblDateFilter
            // 
            lblDateFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateFilter.AutoSize = true;
            lblDateFilter.Font = new Font("Segoe UI", 9.5F);
            lblDateFilter.Location = new Point(345, 39);
            lblDateFilter.Name = "lblDateFilter";
            lblDateFilter.Size = new Size(49, 21);
            lblDateFilter.TabIndex = 4;
            lblDateFilter.Text = "الفترة:";
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMethod.Font = new Font("Segoe UI", 9.5F);
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Items.AddRange(new object[] { "كل الطرق", "نقداً", "بطاقة", "تحويل بنكي", "شيك", "دفع إلكتروني" });
            cbPaymentMethod.Location = new Point(420, 35);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(180, 29);
            cbPaymentMethod.TabIndex = 3;
            cbPaymentMethod.SelectedIndexChanged += FilterChanged;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9.5F);
            lblPaymentMethod.Location = new Point(605, 39);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(93, 21);
            lblPaymentMethod.TabIndex = 2;
            lblPaymentMethod.Text = "طريقة الدفع:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(720, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "اسم الطالب، رقم القبول، رقم الإيصال، رقم الفاتورة...";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.Location = new Point(1045, 39);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث:";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayments.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.Location = new Point(24, 260);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1136, 425);
            dgvPayments.TabIndex = 3;
            dgvPayments.CellDoubleClick += DgvPayments_CellDoubleClick;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.FromArgb(245, 247, 250);
            pnlActions.Controls.Add(lblStatusSummary);
            pnlActions.Controls.Add(btnFeeStructures);
            pnlActions.Controls.Add(btnManageInvoices);
            pnlActions.Controls.Add(btnPaymentTypes);
            pnlActions.Controls.Add(btnViewReceipt);
            pnlActions.Controls.Add(btnViewInvoice);
            pnlActions.Controls.Add(btnNewPayment);
            pnlActions.Controls.Add(btnClose);
            pnlActions.Location = new Point(24, 695);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1136, 55);
            pnlActions.TabIndex = 4;
            // 
            // lblStatusSummary
            // 
            lblStatusSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusSummary.AutoSize = true;
            lblStatusSummary.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatusSummary.ForeColor = Color.FromArgb(71, 85, 105);
            lblStatusSummary.Location = new Point(910, 16);
            lblStatusSummary.Name = "lblStatusSummary";
            lblStatusSummary.Size = new Size(187, 21);
            lblStatusSummary.TabIndex = 0;
            lblStatusSummary.Text = "إجمالي السجلات المسجلة: 0";
            // 
            // btnFeeStructures
            // 
            btnFeeStructures.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFeeStructures.Font = new Font("Segoe UI", 9.5F);
            btnFeeStructures.Location = new Point(720, 8);
            btnFeeStructures.Name = "btnFeeStructures";
            btnFeeStructures.Size = new Size(140, 40);
            btnFeeStructures.TabIndex = 7;
            btnFeeStructures.Text = "🏷️ هياكل الرسوم";
            btnFeeStructures.UseVisualStyleBackColor = true;
            btnFeeStructures.Click += BtnFeeStructures_Click;
            // 
            // btnManageInvoices
            // 
            btnManageInvoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnManageInvoices.Font = new Font("Segoe UI", 9.5F);
            btnManageInvoices.Location = new Point(570, 8);
            btnManageInvoices.Name = "btnManageInvoices";
            btnManageInvoices.Size = new Size(140, 40);
            btnManageInvoices.TabIndex = 1;
            btnManageInvoices.Text = "📄 الفواتير";
            btnManageInvoices.UseVisualStyleBackColor = true;
            btnManageInvoices.Click += BtnManageInvoices_Click;
            // 
            // btnPaymentTypes
            // 
            btnPaymentTypes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPaymentTypes.Font = new Font("Segoe UI", 9.5F);
            btnPaymentTypes.Location = new Point(420, 8);
            btnPaymentTypes.Name = "btnPaymentTypes";
            btnPaymentTypes.Size = new Size(140, 40);
            btnPaymentTypes.TabIndex = 2;
            btnPaymentTypes.Text = "⚙ طرق الدفع";
            btnPaymentTypes.UseVisualStyleBackColor = true;
            btnPaymentTypes.Click += BtnPaymentTypes_Click;
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewReceipt.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewReceipt.Location = new Point(275, 8);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(140, 40);
            btnViewReceipt.TabIndex = 3;
            btnViewReceipt.Text = "🖨 عرض السند";
            btnViewReceipt.UseVisualStyleBackColor = true;
            btnViewReceipt.Click += BtnViewReceipt_Click;
            // 
            // btnViewInvoice
            // 
            btnViewInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewInvoice.Font = new Font("Segoe UI", 9.5F);
            btnViewInvoice.Location = new Point(145, 8);
            btnViewInvoice.Name = "btnViewInvoice";
            btnViewInvoice.Size = new Size(125, 40);
            btnViewInvoice.TabIndex = 4;
            btnViewInvoice.Text = "🔍 الفاتورة";
            btnViewInvoice.UseVisualStyleBackColor = true;
            btnViewInvoice.Click += BtnViewInvoice_Click;
            // 
            // btnNewPayment
            // 
            btnNewPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewPayment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewPayment.Location = new Point(15, 8);
            btnNewPayment.Name = "btnNewPayment";
            btnNewPayment.Size = new Size(125, 40);
            btnNewPayment.TabIndex = 5;
            btnNewPayment.Text = "➕ تسجيل دفعة";
            btnNewPayment.UseVisualStyleBackColor = true;
            btnNewPayment.Click += BtnNewPayment_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(0, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(10, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.Visible = false;
            // 
            // frmPaymentsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1184, 760);
            Controls.Add(pnlActions);
            Controls.Add(dgvPayments);
            Controls.Add(gbFilter);
            Controls.Add(pnlKpiCards);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1050, 650);
            Name = "frmPaymentsList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مركز وسجل المدفوعات والتحصيل";
            Load += FrmPaymentsList_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKpiCards.ResumeLayout(false);
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlCardToday.ResumeLayout(false);
            pnlCardToday.PerformLayout();
            pnlCardMonth.ResumeLayout(false);
            pnlCardMonth.PerformLayout();
            pnlCardCount.ResumeLayout(false);
            pnlCardCount.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlKpiCards;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel pnlCardToday;
        private System.Windows.Forms.Label lblTodayVal;
        private System.Windows.Forms.Label lblTodayTitle;
        private System.Windows.Forms.Panel pnlCardMonth;
        private System.Windows.Forms.Label lblMonthVal;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Panel pnlCardCount;
        private System.Windows.Forms.Label lblCountVal;
        private System.Windows.Forms.Label lblCountTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblDateFilter;
        private System.Windows.Forms.ComboBox cbDateFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblStatusSummary;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewPayment;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.Button btnPaymentTypes;
        private System.Windows.Forms.Button btnManageInvoices;
        private System.Windows.Forms.Button btnFeeStructures;
    }
}
