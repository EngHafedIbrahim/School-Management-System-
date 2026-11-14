using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Attendance
{
    public partial class frmAttendanceManagement : Form
    {
        private DataTable _dtAttendance;

        public frmAttendanceManagement()
        {
            InitializeComponent();
            _ApplyTheme();
        }

        private void _ApplyTheme()
        {
            clsUITheme.StyleDataGridView(dgvAttendance);
            // Override ReadOnly — attendance grid needs editable Status and Note columns
            dgvAttendance.ReadOnly = false;

            clsUITheme.StylePrimaryButton(btnLoad);
            clsUITheme.StyleSuccessButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnMarkAllPresent);
            clsUITheme.StyleSecondaryButton(btnMarkAllAbsent);
            clsUITheme.StyleSecondaryButton(btnMarkAllLate);
            clsUITheme.StyleSecondaryButton(btnMarkAllExcused);
            clsUITheme.StyleSecondaryButton(btnClose);

            // Prevent DataError crash from ComboBox mismatches
            dgvAttendance.DataError += (s, args) => { args.ThrowException = false; };
        }

        private void FrmAttendanceManagement_Load(object sender, EventArgs e)
        {
            _LoadClasses();
            cbSession.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
            btnSave.Enabled = false;
        }

        private void _LoadClasses()
        {
            DataTable dtClasses = clsClass.GetAllClasss();
            cbClass.DataSource = dtClasses;
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ClassID";
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (cbClass.SelectedValue == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد الشعبة الدراسية.", "تحديد مطلوب",
                    MessageBoxIcon.Information);
                return;
            }

            int classID = Convert.ToInt32(cbClass.SelectedValue);
            int sessionID = cbSession.SelectedIndex + 1; // 1-7
            DateTime date = dtpDate.Value.Date;

            // Validate: no future dates
            if (date > DateTime.Today)
            {
                clsUITheme.ShowArabicMessage("لا يمكن تسجيل الحضور لتاريخ مستقبلي.", "تنبيه التحقق",
                    MessageBoxIcon.Warning);
                return;
            }

            _dtAttendance = clsAttendance.GetClassAttendanceByDateAndSession(classID, date, sessionID);

            if (_dtAttendance == null || _dtAttendance.Rows.Count == 0)
            {
                dgvAttendance.DataSource = null;
                lblStats.Text = "لا يوجد طلاب مقيدون ونشطون في هذه الشعبة الدراسية.";
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
            _BuildAttendanceGrid();
            _RecalculateStats();
        }

        private void _BuildAttendanceGrid()
        {
            dgvAttendance.Columns.Clear();
            dgvAttendance.AutoGenerateColumns = false;

            // ── Hidden Columns ──
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentID",
                Name = "StudentID",
                Visible = false
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AttendanceID",
                Name = "AttendanceID",
                Visible = false
            });

            // ── Row Number ──
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RowNum",
                HeaderText = "#",
                Width = 50,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(120, 130, 140)
                }
            });

            // ── Admission No ──
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AdmissionNo",
                HeaderText = "رقم القبول",
                Width = 130,
                ReadOnly = true
            });

            // ── Student Name ──
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentName",
                HeaderText = "اسم الطالب",
                Width = 250,
                ReadOnly = true
            });

            // ── Status (ComboBox) ──
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Value", typeof(string));
            dtStatus.Columns.Add("Display", typeof(string));
            dtStatus.Rows.Add("Present", "حاضر");
            dtStatus.Rows.Add("Absent", "غائب");
            dtStatus.Rows.Add("Late", "متأخر");
            dtStatus.Rows.Add("Excused", "معذور");

            DataGridViewComboBoxColumn colStatus = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "حالة الحضور",
                Name = "colStatus",
                Width = 140,
                DataSource = dtStatus,
                ValueMember = "Value",
                DisplayMember = "Display",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                FlatStyle = FlatStyle.Flat
            };
            dgvAttendance.Columns.Add(colStatus);

            // ── Notes ──
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Note",
                HeaderText = "الملاحظات / سبب الغياب",
                Name = "colNote",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAttendance.DataSource = _dtAttendance;

            // Fill row numbers
            for (int i = 0; i < dgvAttendance.Rows.Count; i++)
            {
                dgvAttendance.Rows[i].Cells["RowNum"].Value = (i + 1).ToString();
            }
        }

        private void _RecalculateStats()
        {
            if (_dtAttendance == null) return;

            int total = _dtAttendance.Rows.Count;
            int present = 0, absent = 0, late = 0, excused = 0;

            foreach (DataRow row in _dtAttendance.Rows)
            {
                string status = row["Status"]?.ToString() ?? "Present";
                switch (status)
                {
                    case "Present": present++; break;
                    case "Absent": absent++; break;
                    case "Late": late++; break;
                    case "Excused": excused++; break;
                }
            }

            lblStats.Text = $"الإجمالي: {total}  |  حضور: {present}  |  غياب: {absent}  |  تأخر: {late}  |  بعذر: {excused}";
        }

        // ── ComboBox immediate commit fix ──
        private void DgvAttendance_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAttendance.IsCurrentCellDirty)
            {
                dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvAttendance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string colName = dgvAttendance.Columns[e.ColumnIndex].Name;
                if (colName == "colStatus")
                {
                    _RecalculateStats();
                }
            }
        }

        // ── Row color coding based on attendance status ──
        private void DgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvAttendance.Rows.Count) return;

            DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];
            string status = "";

            var statusCell = row.Cells["colStatus"];
            if (statusCell?.Value != null)
                status = statusCell.Value.ToString();

            Color backColor;
            switch (status)
            {
                case "Present":
                    backColor = Color.FromArgb(240, 253, 244); // light green
                    break;
                case "Absent":
                    backColor = Color.FromArgb(254, 242, 242); // light red
                    break;
                case "Late":
                    backColor = Color.FromArgb(255, 251, 235); // light amber
                    break;
                case "Excused":
                    backColor = Color.FromArgb(239, 246, 255); // light blue
                    break;
                default:
                    backColor = Color.White;
                    break;
            }

            e.CellStyle.BackColor = backColor;
        }

        // ── Quick Mark Buttons ──
        private void _SetAllStatus(string status)
        {
            if (_dtAttendance == null) return;

            foreach (DataRow row in _dtAttendance.Rows)
            {
                row["Status"] = status;
            }

            dgvAttendance.Refresh();
            _RecalculateStats();
        }

        private void BtnMarkAllPresent_Click(object sender, EventArgs e) => _SetAllStatus("Present");
        private void BtnMarkAllAbsent_Click(object sender, EventArgs e) => _SetAllStatus("Absent");
        private void BtnMarkAllLate_Click(object sender, EventArgs e) => _SetAllStatus("Late");
        private void BtnMarkAllExcused_Click(object sender, EventArgs e) => _SetAllStatus("Excused");

        // ── Save with confirmation ──
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_dtAttendance == null || _dtAttendance.Rows.Count == 0)
            {
                clsUITheme.ShowArabicMessage("لا توجد سجلات حضور وغياب لحفظها.", "تنبيه",
                    MessageBoxIcon.Information);
                return;
            }

            dgvAttendance.EndEdit();

            // Confirmation dialog
            string className = cbClass.Text;
            string sessionName = cbSession.Text;
            string date = dtpDate.Value.ToString("dd/MM/yyyy");

            DialogResult confirm = MessageBox.Show(
                $"تأكيد حفظ سجلات الحضور والغياب للبيانات التالية:\n\n" +
                $"الشعبة / الفصل: {className}\n" +
                $"التاريخ: {date}\n" +
                $"الحصة / الجلسة: {sessionName}\n\n" +
                $"إجمالي الطلاب: {_dtAttendance.Rows.Count}",
                "تأكيد الحفظ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (confirm != DialogResult.Yes)
                return;

            int classID = Convert.ToInt32(cbClass.SelectedValue);
            int sessionID = cbSession.SelectedIndex + 1;
            DateTime dateValue = dtpDate.Value.Date;
            int currentUserID = clsGloble.UserID;

            // Build records DataTable for bulk save
            DataTable dtToSave = new DataTable();
            dtToSave.Columns.Add("AttendanceID", typeof(int));
            dtToSave.Columns.Add("StudentID", typeof(int));
            dtToSave.Columns.Add("ClassID", typeof(int));
            dtToSave.Columns.Add("SessionID", typeof(int));
            dtToSave.Columns.Add("Date", typeof(DateTime));
            dtToSave.Columns.Add("Status", typeof(string));
            dtToSave.Columns.Add("Note", typeof(string));

            foreach (DataRow row in _dtAttendance.Rows)
            {
                DataRow r = dtToSave.NewRow();
                r["AttendanceID"] = Convert.ToInt32(row["AttendanceID"]);
                r["StudentID"] = Convert.ToInt32(row["StudentID"]);
                r["ClassID"] = classID;
                r["SessionID"] = sessionID;
                r["Date"] = dateValue;
                r["Status"] = row["Status"]?.ToString() ?? "Present";
                r["Note"] = row["Note"]?.ToString() ?? "";
                dtToSave.Rows.Add(r);
            }

            if (clsAttendance.SaveBulkAttendance(dtToSave, currentUserID))
            {
                clsUITheme.ShowArabicMessage("تم حفظ سجلات الحضور والغياب بنجاح!",
                    "تم الحفظ", MessageBoxIcon.Information);
                // Reload to refresh AttendanceIDs
                BtnLoad_Click(null, null);
            }
            else
            {
                clsUITheme.ShowArabicMessage("فشل حفظ سجلات الحضور والغياب. يرجى المحاولة مرة أخرى.",
                    "خطأ", MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
