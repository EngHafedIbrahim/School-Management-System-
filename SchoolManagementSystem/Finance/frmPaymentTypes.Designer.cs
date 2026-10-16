namespace SchoolManagementSystem.Finance
{
    partial class frmPaymentTypes
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
            this.dgvPaymentTypes = new System.Windows.Forms.DataGridView();
            this.gbPaymentType = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentTypes)).BeginInit();
            this.gbPaymentType.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(262, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Types Management";
            // 
            // dgvPaymentTypes
            // 
            this.dgvPaymentTypes.AllowUserToAddRows = false;
            this.dgvPaymentTypes.AllowUserToDeleteRows = false;
            this.dgvPaymentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentTypes.Location = new System.Drawing.Point(29, 70);
            this.dgvPaymentTypes.MultiSelect = false;
            this.dgvPaymentTypes.Name = "dgvPaymentTypes";
            this.dgvPaymentTypes.ReadOnly = true;
            this.dgvPaymentTypes.RowHeadersWidth = 51;
            this.dgvPaymentTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentTypes.Size = new System.Drawing.Size(480, 360);
            this.dgvPaymentTypes.TabIndex = 1;
            this.dgvPaymentTypes.DoubleClick += new System.EventHandler(this.DgvPaymentTypes_DoubleClick);
            // 
            // gbPaymentType
            // 
            this.gbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaymentType.Controls.Add(this.btnCancelEdit);
            this.gbPaymentType.Controls.Add(this.btnSave);
            this.gbPaymentType.Controls.Add(this.txtDescription);
            this.gbPaymentType.Controls.Add(this.lblDescription);
            this.gbPaymentType.Controls.Add(this.txtName);
            this.gbPaymentType.Controls.Add(this.lblName);
            this.gbPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.gbPaymentType.Location = new System.Drawing.Point(525, 62);
            this.gbPaymentType.Name = "gbPaymentType";
            this.gbPaymentType.Size = new System.Drawing.Size(320, 368);
            this.gbPaymentType.TabIndex = 2;
            this.gbPaymentType.TabStop = false;
            this.gbPaymentType.Text = "Add / Edit Payment Type";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelEdit.Location = new System.Drawing.Point(20, 310);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(130, 36);
            this.btnCancelEdit.TabIndex = 5;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(165, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Type";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.Location = new System.Drawing.Point(20, 130);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(280, 150);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.Location = new System.Drawing.Point(17, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Location = new System.Drawing.Point(20, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 24);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(17, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Payment Type Name:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalCount.Location = new System.Drawing.Point(29, 442);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(81, 15);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "Total Types: 0";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.Location = new System.Drawing.Point(495, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.Location = new System.Drawing.Point(605, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(730, 448);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Location = new System.Drawing.Point(825, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPaymentTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(924, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.gbPaymentType);
            this.Controls.Add(this.dgvPaymentTypes);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "frmPaymentTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Types Management";
            this.Load += new System.EventHandler(this.FrmPaymentTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentTypes)).EndInit();
            this.gbPaymentType.ResumeLayout(false);
            this.gbPaymentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPaymentTypes;
        private System.Windows.Forms.GroupBox gbPaymentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
