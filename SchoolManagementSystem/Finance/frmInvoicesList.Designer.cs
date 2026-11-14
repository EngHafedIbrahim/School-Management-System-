namespace SchoolManagementSystem.Finance
{
    partial class frmInvoicesList
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
            pnlCardInvoiced = new Panel();
            lblInvoicedVal = new Label();
            lblInvoicedTitle = new Label();
            pnlCardCollected = new Panel();
            lblCollectedVal = new Label();
            lblCollectedTitle = new Label();
            pnlCardRemaining = new Panel();
            lblRemainingVal = new Label();
            lblRemainingTitle = new Label();
            pnlCardCount = new Panel();
            lblCountVal = new Label();
            lblCountTitle = new Label();
            gbFilter = new GroupBox();
            btnRefresh = new Button();
            cbStatusFilter = new ComboBox();
            lblStatusFilter = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvInvoices = new DataGridView();
            pnlActions = new Panel();
            lblSummary = new Label();
            btnCancelInvoice = new Button();
            btnCreateInvoice = new Button();
            btnViewDetails = new Button();
            btnPay = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlKpiCards.SuspendLayout();
            pnlCardInvoiced.SuspendLayout();
            pnlCardCollected.SuspendLayout();
            pnlCardRemaining.SuspendLayout();
            pnlCardCount.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
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
            lblTitle.Location = new Point(431, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة وسجل الفواتير الدراسية";
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
            pnlKpiCards.Controls.Add(pnlCardInvoiced);
            pnlKpiCards.Controls.Add(pnlCardCollected);
            pnlKpiCards.Controls.Add(pnlCardRemaining);
            pnlKpiCards.Controls.Add(pnlCardCount);
            pnlKpiCards.Location = new Point(24, 85);
            pnlKpiCards.Name = "pnlKpiCards";
            pnlKpiCards.Size = new Size(1136, 75);
            pnlKpiCards.TabIndex = 1;
            // 
            // pnlCardInvoiced
            // 
            pnlCardInvoiced.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCardInvoiced.BackColor = Color.White;
            pnlCardInvoiced.BorderStyle = BorderStyle.FixedSingle;
            pnlCardInvoiced.Controls.Add(lblInvoicedVal);
            pnlCardInvoiced.Controls.Add(lblInvoicedTitle);
            pnlCardInvoiced.Location = new Point(855, 3);
            pnlCardInvoiced.Name = "pnlCardInvoiced";
            pnlCardInvoiced.Size = new Size(278, 68);
            pnlCardInvoiced.TabIndex = 0;
            // 
            // lblInvoicedVal
            // 
            lblInvoicedVal.AutoSize = true;
            lblInvoicedVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInvoicedVal.ForeColor = Color.FromArgb(44, 62, 80);
            lblInvoicedVal.Location = new Point(14, 28);
            lblInvoicedVal.Name = "lblInvoicedVal";
            lblInvoicedVal.Size = new Size(77, 32);
            lblInvoicedVal.TabIndex = 1;
            lblInvoicedVal.Text = "$0.00";
            // 
            // lblInvoicedTitle
            // 
            lblInvoicedTitle.AutoSize = true;
            lblInvoicedTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInvoicedTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblInvoicedTitle.Location = new Point(14, 8);
            lblInvoicedTitle.Name = "lblInvoicedTitle";
            lblInvoicedTitle.Size = new Size(120, 20);
            lblInvoicedTitle.TabIndex = 0;
            lblInvoicedTitle.Text = "إجمالي المطالبات";
            // 
            // pnlCardCollected
            // 
            pnlCardCollected.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCardCollected.BackColor = Color.White;
            pnlCardCollected.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCollected.Controls.Add(lblCollectedVal);
            pnlCardCollected.Controls.Add(lblCollectedTitle);
            pnlCardCollected.Location = new Point(570, 3);
            pnlCardCollected.Name = "pnlCardCollected";
            pnlCardCollected.Size = new Size(278, 68);
            pnlCardCollected.TabIndex = 1;
            // 
            // lblCollectedVal
            // 
            lblCollectedVal.AutoSize = true;
            lblCollectedVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCollectedVal.ForeColor = Color.FromArgb(39, 174, 96);
            lblCollectedVal.Location = new Point(14, 28);
            lblCollectedVal.Name = "lblCollectedVal";
            lblCollectedVal.Size = new Size(77, 32);
            lblCollectedVal.TabIndex = 1;
            lblCollectedVal.Text = "$0.00";
            // 
            // lblCollectedTitle
            // 
            lblCollectedTitle.AutoSize = true;
            lblCollectedTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCollectedTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblCollectedTitle.Location = new Point(14, 8);
            lblCollectedTitle.Name = "lblCollectedTitle";
            lblCollectedTitle.Size = new Size(109, 20);
            lblCollectedTitle.TabIndex = 0;
            lblCollectedTitle.Text = "إجمالي المحصل";
            // 
            // pnlCardRemaining
            // 
            pnlCardRemaining.BackColor = Color.White;
            pnlCardRemaining.BorderStyle = BorderStyle.FixedSingle;
            pnlCardRemaining.Controls.Add(lblRemainingVal);
            pnlCardRemaining.Controls.Add(lblRemainingTitle);
            pnlCardRemaining.Location = new Point(285, 3);
            pnlCardRemaining.Name = "pnlCardRemaining";
            pnlCardRemaining.Size = new Size(278, 68);
            pnlCardRemaining.TabIndex = 2;
            // 
            // lblRemainingVal
            // 
            lblRemainingVal.AutoSize = true;
            lblRemainingVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRemainingVal.ForeColor = Color.FromArgb(192, 57, 43);
            lblRemainingVal.Location = new Point(14, 28);
            lblRemainingVal.Name = "lblRemainingVal";
            lblRemainingVal.Size = new Size(77, 32);
            lblRemainingVal.TabIndex = 1;
            lblRemainingVal.Text = "$0.00";
            // 
            // lblRemainingTitle
            // 
            lblRemainingTitle.AutoSize = true;
            lblRemainingTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRemainingTitle.ForeColor = Color.FromArgb(120, 130, 140);
            lblRemainingTitle.Location = new Point(14, 8);
            lblRemainingTitle.Name = "lblRemainingTitle";
            lblRemainingTitle.Size = new Size(104, 20);
            lblRemainingTitle.TabIndex = 0;
            lblRemainingTitle.Text = "الرصيد المتبقي";
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
            lblCountTitle.Size = new Size(83, 20);
            lblCountTitle.TabIndex = 0;
            lblCountTitle.Text = "عدد الفواتير";
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFilter.Controls.Add(btnRefresh);
            gbFilter.Controls.Add(cbStatusFilter);
            gbFilter.Controls.Add(lblStatusFilter);
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
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // cbStatusFilter
            // 
            cbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cbStatusFilter.FormattingEnabled = true;
            cbStatusFilter.Items.AddRange(new object[] { "كل الحالات", "مدفوعة", "مدفوعة جزئياً", "غير مدفوعة", "متأخرة", "ملغاة" });
            cbStatusFilter.Location = new Point(340, 35);
            cbStatusFilter.Name = "cbStatusFilter";
            cbStatusFilter.Size = new Size(200, 29);
            cbStatusFilter.TabIndex = 3;
            cbStatusFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 9.5F);
            lblStatusFilter.Location = new Point(545, 39);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(91, 21);
            lblStatusFilter.TabIndex = 2;
            lblStatusFilter.Text = "حالة الفاتورة:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(660, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "اسم الطالب، رقم الفاتورة، السنة الأكاديمية...";
            txtSearch.Size = new Size(380, 29);
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
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoices.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.Location = new Point(24, 260);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(1136, 425);
            dgvInvoices.TabIndex = 3;
            dgvInvoices.CellDoubleClick += DgvInvoices_CellDoubleClick;
            dgvInvoices.CellFormatting += DgvInvoices_CellFormatting;
            // 
            // pnlActions
            // 
            pnlActions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlActions.BackColor = Color.FromArgb(245, 247, 250);
            pnlActions.Controls.Add(lblSummary);
            pnlActions.Controls.Add(btnCancelInvoice);
            pnlActions.Controls.Add(btnCreateInvoice);
            pnlActions.Controls.Add(btnViewDetails);
            pnlActions.Controls.Add(btnPay);
            pnlActions.Controls.Add(btnClose);
            pnlActions.Location = new Point(24, 695);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1136, 55);
            pnlActions.TabIndex = 4;
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(71, 85, 105);
            lblSummary.Location = new Point(915, 16);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(190, 21);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "إجمالي الفواتير المعروضة: 0";
            // 
            // btnCancelInvoice
            // 
            btnCancelInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelInvoice.Cursor = Cursors.Hand;
            btnCancelInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelInvoice.Location = new Point(540, 8);
            btnCancelInvoice.Name = "btnCancelInvoice";
            btnCancelInvoice.Size = new Size(140, 40);
            btnCancelInvoice.TabIndex = 5;
            btnCancelInvoice.Text = "🚫 إلغاء الفاتورة";
            btnCancelInvoice.UseVisualStyleBackColor = true;
            btnCancelInvoice.Click += BtnCancelInvoice_Click;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateInvoice.Cursor = Cursors.Hand;
            btnCreateInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCreateInvoice.Location = new Point(385, 8);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(150, 40);
            btnCreateInvoice.TabIndex = 1;
            btnCreateInvoice.Text = "➕ إصدار فاتورة";
            btnCreateInvoice.UseVisualStyleBackColor = true;
            btnCreateInvoice.Click += BtnCreateInvoice_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.Font = new Font("Segoe UI", 9.5F);
            btnViewDetails.Location = new Point(245, 8);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(135, 40);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "🔍 تفاصيل الفاتورة";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += BtnViewDetails_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.Cursor = Cursors.Hand;
            btnPay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPay.Location = new Point(125, 8);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(115, 40);
            btnPay.TabIndex = 2;
            btnPay.Text = "💳 سداد";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += BtnPay_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.Location = new Point(15, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "إغلاق";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // frmInvoicesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1184, 760);
            Controls.Add(pnlActions);
            Controls.Add(dgvInvoices);
            Controls.Add(gbFilter);
            Controls.Add(pnlKpiCards);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1050, 650);
            Name = "frmInvoicesList";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سجل وإدارة الفواتير الدراسية";
            Load += FrmInvoicesList_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKpiCards.ResumeLayout(false);
            pnlCardInvoiced.ResumeLayout(false);
            pnlCardInvoiced.PerformLayout();
            pnlCardCollected.ResumeLayout(false);
            pnlCardCollected.PerformLayout();
            pnlCardRemaining.ResumeLayout(false);
            pnlCardRemaining.PerformLayout();
            pnlCardCount.ResumeLayout(false);
            pnlCardCount.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlKpiCards;
        private System.Windows.Forms.Panel pnlCardInvoiced;
        private System.Windows.Forms.Label lblInvoicedVal;
        private System.Windows.Forms.Label lblInvoicedTitle;
        private System.Windows.Forms.Panel pnlCardCollected;
        private System.Windows.Forms.Label lblCollectedVal;
        private System.Windows.Forms.Label lblCollectedTitle;
        private System.Windows.Forms.Panel pnlCardRemaining;
        private System.Windows.Forms.Label lblRemainingVal;
        private System.Windows.Forms.Label lblRemainingTitle;
        private System.Windows.Forms.Panel pnlCardCount;
        private System.Windows.Forms.Label lblCountVal;
        private System.Windows.Forms.Label lblCountTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Button btnCancelInvoice;
    }
}
