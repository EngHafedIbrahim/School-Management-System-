namespace SchoolManagementSystem.Finance
{
    partial class frmRecordPayment
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.lblRemainingVal = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblPaidVal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStudentNameVal = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblInvoiceNoVal = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.gbPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.lblReceiptNo = new System.Windows.Forms.Label();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInvoiceInfo.SuspendLayout();
            this.gbPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Record Student Payment";
            // 
            // gbInvoiceInfo
            // 
            this.gbInvoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoiceInfo.Controls.Add(this.lblRemainingVal);
            this.gbInvoiceInfo.Controls.Add(this.lblRemaining);
            this.gbInvoiceInfo.Controls.Add(this.lblPaidVal);
            this.gbInvoiceInfo.Controls.Add(this.lblPaid);
            this.gbInvoiceInfo.Controls.Add(this.lblTotalVal);
            this.gbInvoiceInfo.Controls.Add(this.lblTotal);
            this.gbInvoiceInfo.Controls.Add(this.lblStudentNameVal);
            this.gbInvoiceInfo.Controls.Add(this.lblStudentName);
            this.gbInvoiceInfo.Controls.Add(this.lblInvoiceNoVal);
            this.gbInvoiceInfo.Controls.Add(this.lblInvoiceNo);
            this.gbInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbInvoiceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbInvoiceInfo.Location = new System.Drawing.Point(29, 65);
            this.gbInvoiceInfo.Name = "gbInvoiceInfo";
            this.gbInvoiceInfo.Size = new System.Drawing.Size(560, 140);
            this.gbInvoiceInfo.TabIndex = 1;
            this.gbInvoiceInfo.TabStop = false;
            this.gbInvoiceInfo.Text = "Invoice Information";
            // 
            // lblRemainingVal
            // 
            this.lblRemainingVal.AutoSize = true;
            this.lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRemainingVal.Location = new System.Drawing.Point(390, 95);
            this.lblRemainingVal.Name = "lblRemainingVal";
            this.lblRemainingVal.Size = new System.Drawing.Size(49, 20);
            this.lblRemainingVal.TabIndex = 9;
            this.lblRemainingVal.Text = "$ 0.00";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRemaining.Location = new System.Drawing.Point(390, 72);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(123, 17);
            this.lblRemaining.TabIndex = 8;
            this.lblRemaining.Text = "Remaining Balance:";
            // 
            // lblPaidVal
            // 
            this.lblPaidVal.AutoSize = true;
            this.lblPaidVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaidVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblPaidVal.Location = new System.Drawing.Point(210, 96);
            this.lblPaidVal.Name = "lblPaidVal";
            this.lblPaidVal.Size = new System.Drawing.Size(45, 19);
            this.lblPaidVal.TabIndex = 7;
            this.lblPaidVal.Text = "$ 0.00";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPaid.Location = new System.Drawing.Point(210, 72);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(86, 17);
            this.lblPaid.TabIndex = 6;
            this.lblPaid.Text = "Total Paid:";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalVal.Location = new System.Drawing.Point(25, 96);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(45, 19);
            this.lblTotalVal.TabIndex = 5;
            this.lblTotalVal.Text = "$ 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotal.Location = new System.Drawing.Point(25, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Invoice Total:";
            // 
            // lblStudentNameVal
            // 
            this.lblStudentNameVal.AutoSize = true;
            this.lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStudentNameVal.Location = new System.Drawing.Point(280, 35);
            this.lblStudentNameVal.Name = "lblStudentNameVal";
            this.lblStudentNameVal.Size = new System.Drawing.Size(24, 19);
            this.lblStudentNameVal.TabIndex = 3;
            this.lblStudentNameVal.Text = "---";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStudentName.Location = new System.Drawing.Point(210, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(56, 17);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student:";
            // 
            // lblInvoiceNoVal
            // 
            this.lblInvoiceNoVal.AutoSize = true;
            this.lblInvoiceNoVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblInvoiceNoVal.Location = new System.Drawing.Point(95, 35);
            this.lblInvoiceNoVal.Name = "lblInvoiceNoVal";
            this.lblInvoiceNoVal.Size = new System.Drawing.Size(24, 19);
            this.lblInvoiceNoVal.TabIndex = 1;
            this.lblInvoiceNoVal.Text = "---";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(25, 35);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(65, 17);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice #:";
            // 
            // gbPaymentDetails
            // 
            this.gbPaymentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaymentDetails.Controls.Add(this.txtNotes);
            this.gbPaymentDetails.Controls.Add(this.lblNotes);
            this.gbPaymentDetails.Controls.Add(this.txtReceiptNo);
            this.gbPaymentDetails.Controls.Add(this.lblReceiptNo);
            this.gbPaymentDetails.Controls.Add(this.cbPaymentType);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentType);
            this.gbPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.gbPaymentDetails.Controls.Add(this.numAmount);
            this.gbPaymentDetails.Controls.Add(this.lblAmount);
            this.gbPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbPaymentDetails.Location = new System.Drawing.Point(29, 215);
            this.gbPaymentDetails.Name = "gbPaymentDetails";
            this.gbPaymentDetails.Size = new System.Drawing.Size(560, 240);
            this.gbPaymentDetails.TabIndex = 2;
            this.gbPaymentDetails.TabStop = false;
            this.gbPaymentDetails.Text = "Payment Details";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNotes.Location = new System.Drawing.Point(145, 175);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(380, 50);
            this.txtNotes.TabIndex = 9;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNotes.Location = new System.Drawing.Point(25, 178);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 17);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes:";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiptNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtReceiptNo.Location = new System.Drawing.Point(145, 140);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(380, 24);
            this.txtReceiptNo.TabIndex = 7;
            // 
            // lblReceiptNo
            // 
            this.lblReceiptNo.AutoSize = true;
            this.lblReceiptNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReceiptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblReceiptNo.Location = new System.Drawing.Point(25, 143);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(73, 17);
            this.lblReceiptNo.TabIndex = 6;
            this.lblReceiptNo.Text = "Receipt No:";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(145, 103);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(380, 24);
            this.cbPaymentType.TabIndex = 5;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPaymentType.Location = new System.Drawing.Point(25, 106);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(92, 17);
            this.lblPaymentType.TabIndex = 4;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(145, 68);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(380, 24);
            this.dtpPaymentDate.TabIndex = 3;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPaymentDate.Location = new System.Drawing.Point(25, 71);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(91, 17);
            this.lblPaymentDate.TabIndex = 2;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // numAmount
            // 
            this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numAmount.Location = new System.Drawing.Point(145, 33);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(380, 25);
            this.numAmount.TabIndex = 1;
            this.numAmount.ThousandsSeparator = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblAmount.Location = new System.Drawing.Point(25, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 17);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount ($): *";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(340, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Payment";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(480, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(619, 520);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPaymentDetails);
            this.Controls.Add(this.gbInvoiceInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecordPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Record Payment";
            this.Load += new System.EventHandler(this.FrmRecordPayment_Load);
            this.gbInvoiceInfo.ResumeLayout(false);
            this.gbInvoiceInfo.PerformLayout();
            this.gbPaymentDetails.ResumeLayout(false);
            this.gbPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNoVal;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNameVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPaidVal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRemainingVal;
        private System.Windows.Forms.GroupBox gbPaymentDetails;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label lblReceiptNo;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
