using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmInvoicesList : Form
    {
        private DataTable _dtInvoices;
        private DataView _dvFilteredInvoices;

        private static readonly Dictionary<string, string> _statusMapToEng = new Dictionary<string, string>
        {
            { "مدفوعة", "Paid" },
            { "مدفوعة جزئياً", "Partially Paid" },
            { "غير مدفوعة", "Unpaid" },
            { "متأخرة", "Overdue" },
            { "ملغاة", "Cancelled" }
        };

        public frmInvoicesList()
        {
            InitializeComponent();
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            clsUITheme.StyleDataGridView(dgvInvoices);
            clsUITheme.StylePrimaryButton(btnPay);
            clsUITheme.StylePrimaryButton(btnCreateInvoice);
            clsUITheme.StyleSuccessButton(btnViewDetails);
            clsUITheme.StyleSecondaryButton(btnRefresh);
            clsUITheme.StyleSecondaryButton(btnClose);
            clsUITheme.StyleDangerButton(btnCancelInvoice);

            dgvInvoices.DataError += (s, args) => { args.ThrowException = false; };
        }

        private void FrmInvoicesList_Load(object sender, EventArgs e)
        {
            cbStatusFilter.SelectedIndex = 0; // All Statuses
            LoadInvoicesData();
        }

        public void LoadInvoicesData()
        {
            _dtInvoices = clsInvoice.GetAllInvoicesDetailed();

            if (_dtInvoices != null)
            {
                _dvFilteredInvoices = _dtInvoices.DefaultView;
                _BuildGrid();
                _CalculateKPIs();
                ApplyFilter();
            }
        }

        private void _BuildGrid()
        {
            dgvInvoices.DataSource = null;
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.Columns.Clear();

            // Hidden IDs
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceID",
                Name = "InvoiceID",
                Visible = false
            });

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentID",
                Name = "StudentID",
                Visible = false
            });

            if (_dtInvoices != null && _dtInvoices.Columns.Contains("AcademicYearID"))
            {
                dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "AcademicYearID",
                    Name = "AcademicYearID",
                    Visible = false
                });
            }

            // Invoice Number
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceNumber",
                HeaderText = "رقم الفاتورة",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.PrimaryColor
                }
            });

            // Student Name
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentName",
                HeaderText = "اسم الطالب",
                Width = 200
            });

            // Academic Year
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AcademicYear",
                HeaderText = "السنة الدراسية",
                Width = 130
            });

            // Total Amount
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "الإجمالي ($)",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Font = clsUITheme.BoldFont
                }
            });

            // Paid Amount
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaidAmount",
                HeaderText = "المدفوع ($)",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    ForeColor = clsUITheme.SuccessColor
                }
            });

            // Remaining Amount
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RemainingAmount",
                HeaderText = "المتبقي ($)",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.DangerColor
                }
            });

            // Status
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                Name = "colStatus",
                HeaderText = "حالة الفاتورة",
                Width = 130
            });

            // Issue Date
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IssueDate",
                HeaderText = "تاريخ الإصدار",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // Due Date
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DueDate",
                HeaderText = "تاريخ الاستحقاق",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvInvoices.DataSource = _dvFilteredInvoices;
        }

        private void _CalculateKPIs()
        {
            decimal totalInvoiced = 0;
            decimal totalCollected = 0;
            decimal totalRemaining = 0;

            if (_dtInvoices != null)
            {
                foreach (DataRow row in _dtInvoices.Rows)
                {
                    if (row["TotalAmount"] != DBNull.Value)
                        totalInvoiced += Convert.ToDecimal(row["TotalAmount"]);
                    if (row["PaidAmount"] != DBNull.Value)
                        totalCollected += Convert.ToDecimal(row["PaidAmount"]);
                    if (row["RemainingAmount"] != DBNull.Value)
                        totalRemaining += Convert.ToDecimal(row["RemainingAmount"]);
                }

                lblInvoicedVal.Text = $"${totalInvoiced:N2}";
                lblCollectedVal.Text = $"${totalCollected:N2}";
                lblRemainingVal.Text = $"${totalRemaining:N2}";
                lblCountVal.Text = _dtInvoices.Rows.Count.ToString();
            }
        }

        private void ApplyFilter()
        {
            if (_dvFilteredInvoices == null) return;

            string filter = "1=1";

            // Search filter
            string search = txtSearch.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(search))
            {
                filter += $" AND (StudentName LIKE '%{search}%' OR InvoiceNumber LIKE '%{search}%' OR AcademicYear LIKE '%{search}%')";
            }

            // Status filter
            if (cbStatusFilter.SelectedIndex > 0)
            {
                string selectedText = cbStatusFilter.Text;
                string dbStatus = _statusMapToEng.TryGetValue(selectedText, out string eng) ? eng : selectedText;
                filter += $" AND Status = '{dbStatus.Replace("'", "''")}'";
            }

            _dvFilteredInvoices.RowFilter = filter;
            lblSummary.Text = $"عرض {_dvFilteredInvoices.Count} من إجمالي {_dtInvoices.Rows.Count} فاتورة";
        }

        private void DgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvInvoices.Rows.Count) return;

            if (dgvInvoices.Columns[e.ColumnIndex].Name == "colStatus")
            {
                string status = e.Value?.ToString() ?? "";
                switch (status)
                {
                    case "Paid":
                    case "مدفوعة":
                        e.Value = "مدفوعة";
                        e.CellStyle.ForeColor = clsUITheme.SuccessColor;
                        e.CellStyle.Font = clsUITheme.BoldFont;
                        e.FormattingApplied = true;
                        break;
                    case "Partially Paid":
                    case "مدفوعة جزئياً":
                        e.Value = "مدفوعة جزئياً";
                        e.CellStyle.ForeColor = clsUITheme.WarningColor;
                        e.CellStyle.Font = clsUITheme.BoldFont;
                        e.FormattingApplied = true;
                        break;
                    case "Unpaid":
                    case "غير مدفوعة":
                        e.Value = "غير مدفوعة";
                        e.CellStyle.ForeColor = clsUITheme.DangerColor;
                        e.CellStyle.Font = clsUITheme.BoldFont;
                        e.FormattingApplied = true;
                        break;
                    case "Cancelled":
                    case "ملغاة":
                        e.Value = "ملغاة";
                        e.CellStyle.ForeColor = Color.Gray;
                        e.CellStyle.Font = new Font(clsUITheme.BoldFont, FontStyle.Strikeout);
                        e.FormattingApplied = true;
                        break;
                    case "Overdue":
                    case "متأخرة":
                        e.Value = "متأخرة";
                        e.CellStyle.ForeColor = Color.FromArgb(190, 24, 93);
                        e.CellStyle.Font = clsUITheme.BoldFont;
                        e.FormattingApplied = true;
                        break;
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void FilterChanged(object sender, EventArgs e) => ApplyFilter();
        private void BtnRefresh_Click(object sender, EventArgs e) => LoadInvoicesData();

        private void DgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnViewDetails_Click(null, null);
            }
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            frmCreateInvoice frm = new frmCreateInvoice();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadInvoicesData();
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد فاتورة من القائمة أولاً لتسجيل دفعة.", "تحديد مطلوب",
                    MessageBoxIcon.Information);
                return;
            }

            int invoiceID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value);
            string status = dgvInvoices.CurrentRow.Cells["colStatus"].Value?.ToString() ?? "";

            if (status == "Cancelled" || status == "ملغاة")
            {
                clsUITheme.ShowArabicMessage("لا يمكن تسجيل دفعات مالية لفاتورة ملغاة.", "فاتورة ملغاة",
                    MessageBoxIcon.Warning);
                return;
            }

            decimal remaining = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["RemainingAmount"].Value);

            if (remaining <= 0)
            {
                clsUITheme.ShowArabicMessage("هذه الفاتورة تم سدادها بالكامل مسبقاً.", "فاتورة مسددة",
                    MessageBoxIcon.Information);
                return;
            }

            frmRecordPayment frm = new frmRecordPayment(invoiceID);
            frm.ShowDialog();
            LoadInvoicesData();
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد فاتورة من القائمة لعرض تفاصيلها.", "تحديد مطلوب",
                    MessageBoxIcon.Information);
                return;
            }

            int invoiceID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value);
            frmInvoiceDetails frm = new frmInvoiceDetails(invoiceID);
            frm.ShowDialog();
            LoadInvoicesData();
        }

        private void BtnCancelInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد فاتورة من القائمة لإلغائها.", "تحديد مطلوب",
                    MessageBoxIcon.Information);
                return;
            }

            int invoiceID = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["InvoiceID"].Value);
            string invoiceNumber = dgvInvoices.CurrentRow.Cells["InvoiceNumber"].Value?.ToString() ?? "";
            string status = dgvInvoices.CurrentRow.Cells["colStatus"].Value?.ToString() ?? "";

            if (status == "Paid" || status == "مدفوعة")
            {
                clsUITheme.ShowArabicMessage("لا يمكن إلغاء فاتورة مسددة بالكامل.", "إجراء غير متاح",
                    MessageBoxIcon.Warning);
                return;
            }

            if (status == "Cancelled" || status == "ملغاة")
            {
                clsUITheme.ShowArabicMessage("هذه الفاتورة ملغاة بالفعل.", "فاتورة ملغاة",
                    MessageBoxIcon.Information);
                return;
            }

            if (clsInvoice.HasPayments(invoiceID))
            {
                clsUITheme.ShowArabicMessage(
                    "لا يمكن إلغاء هذه الفاتورة نظراً لوجود سندات قبض ومدفوعات مسجلة عليها بالفعل.\n\n" +
                    "لإلغاء الفاتورة، يجب أولاً إلغاء أو حذف المدفوعات المرتبطة بها.",
                    "توجد مدفوعات مسجلة", MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"هل أنت متأكد من رغبتك في إلغاء الفاتورة [{invoiceNumber}]؟\n\n" +
                "سيتم تحويل حالة الفاتورة إلى 'ملغاة' ولا يمكن التراجع عن هذا الإجراء.",
                "تأكيد إلغاء الفاتورة", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (confirm == DialogResult.Yes)
            {
                if (clsInvoice.UpdateInvoiceStatus(invoiceID, "Cancelled"))
                {
                    clsUITheme.ShowArabicMessage($"تم إلغاء الفاتورة [{invoiceNumber}] بنجاح.",
                        "تم الإلغاء", MessageBoxIcon.Information);
                    LoadInvoicesData();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل إلغاء الفاتورة.", "خطأ",
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
