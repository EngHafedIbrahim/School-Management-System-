using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Finance
{
    public partial class frmPaymentsList : Form
    {
        private DataTable _dtAllPayments;
        private DataView _dvFilteredPayments;

        public frmPaymentsList()
        {
            InitializeComponent();
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            clsUITheme.StyleDataGridView(dgvPayments);
            clsUITheme.StylePrimaryButton(btnNewPayment);
            clsUITheme.StyleSuccessButton(btnViewReceipt);
            clsUITheme.StyleSecondaryButton(btnViewInvoice);
            clsUITheme.StyleSecondaryButton(btnManageInvoices);
            clsUITheme.StyleSecondaryButton(btnPaymentTypes);
            clsUITheme.StyleSecondaryButton(btnFeeStructures);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            dgvPayments.DataError += (s, args) => { args.ThrowException = false; };
            dgvPayments.CellFormatting += DgvPayments_CellFormatting;
        }

        private void FrmPaymentsList_Load(object sender, EventArgs e)
        {
            if (cbPaymentMethod.Items.Count > 0)
                cbPaymentMethod.SelectedIndex = 0; // كل الطرق
            if (cbDateFilter.Items.Count > 0)
                cbDateFilter.SelectedIndex = 0;    // كل التواريخ
            LoadPaymentsData();
        }

        public void LoadPaymentsData()
        {
            // Load KPI Metrics
            decimal total = 0, today = 0, month = 0;
            int count = 0;
            if (clsPayment.GetPaymentStatistics(ref total, ref today, ref month, ref count))
            {
                lblTotalVal.Text = $"{total:N2} د.أ";
                lblTodayVal.Text = $"{today:N2} د.أ";
                lblMonthVal.Text = $"{month:N2} د.أ";
                lblCountVal.Text = count.ToString("N0");
            }

            // Load Detailed Payments
            _dtAllPayments = clsPayment.GetAllPaymentsDetailed();

            if (_dtAllPayments != null)
            {
                _dvFilteredPayments = _dtAllPayments.DefaultView;
                _BuildGrid();
                ApplyFilter();
            }
        }

        private void _BuildGrid()
        {
            dgvPayments.DataSource = null;
            dgvPayments.Columns.Clear();
            dgvPayments.AutoGenerateColumns = false;

            // Hidden IDs
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentID",
                Name = "PaymentID",
                Visible = false
            });

            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceID",
                Name = "InvoiceID",
                Visible = false
            });

            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentID",
                Name = "StudentID",
                Visible = false
            });

            // Receipt Number
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ReceiptNumber",
                HeaderText = "رقم الإيصال",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.PrimaryColor,
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Date
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentDate",
                HeaderText = "تاريخ الدفع",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle 
                { 
                    Format = "dd/MM/yyyy HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Student Name
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentName",
                HeaderText = "اسم الطالب",
                Width = 200
            });

            // Admission No
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AdmissionNo",
                HeaderText = "رقم القبول",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Invoice Number
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceNumber",
                HeaderText = "رقم الفاتورة",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Amount
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "المبلغ المدفوع",
                Width = 125,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Font = clsUITheme.BoldFont,
                    ForeColor = clsUITheme.SuccessColor
                }
            });

            // Method
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "طريقة الدفع",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Transaction ID
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionID",
                HeaderText = "رقم المعاملة / التحويل",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Notes
            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "ملاحظات",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPayments.DataSource = _dvFilteredPayments;
        }

        private void DgvPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvPayments.Columns[e.ColumnIndex].DataPropertyName;
            if (colName == "PaymentMethod")
            {
                string method = e.Value.ToString();
                switch (method.ToLowerInvariant())
                {
                    case "cash":
                        e.Value = "نقداً";
                        break;
                    case "card":
                    case "credit card":
                    case "debit card":
                        e.Value = "بطاقة بنكية";
                        break;
                    case "bank transfer":
                    case "bank":
                        e.Value = "تحويل بنكي";
                        break;
                    case "cheque":
                    case "check":
                        e.Value = "شيك";
                        break;
                    case "online":
                        e.Value = "دفع إلكتروني";
                        break;
                }
            }
            else if (colName == "Amount" && e.Value is decimal val)
            {
                e.Value = $"{val:N2} د.أ";
            }
        }

        private void ApplyFilter()
        {
            if (_dvFilteredPayments == null) return;

            string filter = "1=1";

            // Search filter
            string search = txtSearch.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(search))
            {
                filter += $" AND (StudentName LIKE '%{search}%' OR AdmissionNo LIKE '%{search}%' OR ReceiptNumber LIKE '%{search}%' OR InvoiceNumber LIKE '%{search}%' OR TransactionID LIKE '%{search}%')";
            }

            // Method filter
            if (cbPaymentMethod.SelectedIndex > 0)
            {
                string selected = cbPaymentMethod.Text;
                string methodFilter;
                if (selected == "نقداً")
                    methodFilter = "(PaymentMethod LIKE '%Cash%' OR PaymentMethod LIKE '%نقد%')";
                else if (selected == "بطاقة")
                    methodFilter = "(PaymentMethod LIKE '%Card%' OR PaymentMethod LIKE '%Credit%' OR PaymentMethod LIKE '%بطاق%')";
                else if (selected == "تحويل بنكي")
                    methodFilter = "(PaymentMethod LIKE '%Bank%' OR PaymentMethod LIKE '%Transfer%' OR PaymentMethod LIKE '%تحويل%')";
                else if (selected == "شيك")
                    methodFilter = "(PaymentMethod LIKE '%Cheque%' OR PaymentMethod LIKE '%Check%' OR PaymentMethod LIKE '%شيك%')";
                else if (selected == "دفع إلكتروني")
                    methodFilter = "(PaymentMethod LIKE '%Online%' OR PaymentMethod LIKE '%إلكترون%')";
                else
                    methodFilter = $"PaymentMethod LIKE '%{selected.Replace("'", "''")}%'";

                filter += $" AND {methodFilter}";
            }

            // Date filter
            DateTime today = DateTime.Today;
            switch (cbDateFilter.SelectedIndex)
            {
                case 1: // اليوم
                    filter += $" AND PaymentDate >= #{today:yyyy-MM-dd}# AND PaymentDate < #{today.AddDays(1):yyyy-MM-dd}#";
                    break;
                case 2: // هذا الأسبوع
                    DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
                    filter += $" AND PaymentDate >= #{startOfWeek:yyyy-MM-dd}#";
                    break;
                case 3: // هذا الشهر
                    DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                    filter += $" AND PaymentDate >= #{startOfMonth:yyyy-MM-dd}#";
                    break;
                case 4: // آخر 30 يوماً
                    DateTime last30 = today.AddDays(-30);
                    filter += $" AND PaymentDate >= #{last30:yyyy-MM-dd}#";
                    break;
            }

            _dvFilteredPayments.RowFilter = filter;
            lblStatusSummary.Text = $"عرض {_dvFilteredPayments.Count} من أصل {(_dtAllPayments?.Rows.Count ?? 0)} حركة دفع مسجلة";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void FilterChanged(object sender, EventArgs e) => ApplyFilter();
        private void BtnRefresh_Click(object sender, EventArgs e) => LoadPaymentsData();

        private void DgvPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnViewReceipt_Click(null, null);
            }
        }

        private void BtnViewReceipt_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد حركة دفع من القائمة لعرض إيصال القبض.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.CurrentRow.Cells["PaymentID"].Value);
            using (frmPaymentReceipt frm = new frmPaymentReceipt(paymentID))
            {
                frm.ShowDialog();
            }
        }

        private void BtnViewInvoice_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد حركة دفع لعرض تفاصيل فاتورتها.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int invoiceID = Convert.ToInt32(dgvPayments.CurrentRow.Cells["InvoiceID"].Value);
            using (frmInvoiceDetails frm = new frmInvoiceDetails(invoiceID))
            {
                frm.ShowDialog();
            }
            LoadPaymentsData();
        }

        private void BtnNewPayment_Click(object sender, EventArgs e)
        {
            // Open Invoices list so user can choose which invoice to pay
            using (frmInvoicesList frm = new frmInvoicesList())
            {
                frm.ShowDialog();
            }
            LoadPaymentsData();
        }

        private void BtnFeeStructures_Click(object sender, EventArgs e)
        {
            using (frmFeeStructures frm = new frmFeeStructures())
            {
                frm.ShowDialog();
            }
        }

        private void BtnPaymentTypes_Click(object sender, EventArgs e)
        {
            using (frmPaymentTypes frm = new frmPaymentTypes())
            {
                frm.ShowDialog();
            }
        }

        private void BtnManageInvoices_Click(object sender, EventArgs e)
        {
            using (frmInvoicesList frm = new frmInvoicesList())
            {
                frm.ShowDialog();
            }
            LoadPaymentsData();
        }
    }
}
