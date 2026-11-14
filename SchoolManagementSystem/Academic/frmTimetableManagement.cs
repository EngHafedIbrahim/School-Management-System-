using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Globle_Classes;

namespace SchoolManagementSystem.Academic
{
    public partial class frmTimetableManagement : Form
    {
        private DataTable _dtSchedules;
        private DataView _dvSchedules;
        private int _EditingScheduleID = -1;

        private class DayItem
        {
            public string EnglishName { get; set; }
            public string ArabicName { get; set; }
            public override string ToString() => ArabicName;
        }

        private static readonly List<DayItem> _daysList = new List<DayItem>
        {
            new DayItem { EnglishName = "Sunday", ArabicName = "الأحد" },
            new DayItem { EnglishName = "Monday", ArabicName = "الإثنين" },
            new DayItem { EnglishName = "Tuesday", ArabicName = "الثلاثاء" },
            new DayItem { EnglishName = "Wednesday", ArabicName = "الأربعاء" },
            new DayItem { EnglishName = "Thursday", ArabicName = "الخميس" },
            new DayItem { EnglishName = "Saturday", ArabicName = "السبت" }
        };

        private static readonly Dictionary<string, string> _engToArabicDays = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Sunday", "الأحد" },
            { "Monday", "الإثنين" },
            { "Tuesday", "الثلاثاء" },
            { "Wednesday", "الأربعاء" },
            { "Thursday", "الخميس" },
            { "Friday", "الجمعة" },
            { "Saturday", "السبت" }
        };

        public frmTimetableManagement()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvSchedules);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            _PopulateDaysDropdown();

            dtpStartTime.Value = DateTime.Today.AddHours(8).AddMinutes(0);
            dtpEndTime.Value = DateTime.Today.AddHours(8).AddMinutes(45);

            dgvSchedules.CellFormatting += DgvSchedules_CellFormatting;
        }

        private void _PopulateDaysDropdown()
        {
            cbDay.DataSource = new List<DayItem>(_daysList);
            cbDay.DisplayMember = "ArabicName";
            cbDay.ValueMember = "EnglishName";
            if (cbDay.Items.Count > 0)
                cbDay.SelectedIndex = 0;
        }

        private void LoadDropdowns()
        {
            // Academic Years
            DataTable dtYears = clsAcademicYear.GetAllAcademicYears();
            cbYear.DataSource = dtYears;
            cbYear.DisplayMember = "YearName";
            cbYear.ValueMember = "AcademicYearID";

            // Rooms
            DataTable dtRooms = clsRoom.GetAllRooms();
            if (!dtRooms.Columns.Contains("DisplayName"))
            {
                dtRooms.Columns.Add("DisplayName", typeof(string), "Name + ' (السعة: ' + Capacity + ')'");
            }
            cbRoom.DataSource = dtRooms;
            cbRoom.DisplayMember = "DisplayName";
            cbRoom.ValueMember = "RoomID";

            // ClassCourses
            LoadClassCoursesDropdown();

            // Filter Dropdowns
            cbFilterYear.Items.Clear();
            cbFilterYear.Items.Add("كل السنوات");
            foreach (DataRow r in dtYears.Rows)
            {
                cbFilterYear.Items.Add(r["YearName"].ToString());
            }
            cbFilterYear.SelectedIndex = 0;

            DataTable dtClasses = clsClass.GetAllClasss();
            cbFilterClass.Items.Clear();
            cbFilterClass.Items.Add("كل الشعب");
            foreach (DataRow r in dtClasses.Rows)
            {
                cbFilterClass.Items.Add(r["Name"].ToString());
            }
            cbFilterClass.SelectedIndex = 0;

            cbFilterDay.Items.Clear();
            cbFilterDay.Items.Add("كل الأيام");
            foreach (var day in _daysList)
            {
                cbFilterDay.Items.Add(day.ArabicName);
            }
            cbFilterDay.SelectedIndex = 0;
        }

        private void LoadClassCoursesDropdown()
        {
            DataTable dtClassCourses = clsClassCourse.GetAllClassCoursesDetailed();
            if (!dtClassCourses.Columns.Contains("DisplayName"))
            {
                dtClassCourses.Columns.Add("DisplayName", typeof(string), "ClassName + ' | ' + CourseName + ' (' + TeacherName + ')'");
            }

            if (cbYear.SelectedValue != null && int.TryParse(cbYear.SelectedValue.ToString(), out int yearID))
            {
                DataView dv = dtClassCourses.DefaultView;
                dv.RowFilter = $"AcademicYearID = {yearID}";
                cbClassCourse.DataSource = dv;
            }
            else
            {
                cbClassCourse.DataSource = dtClassCourses;
            }

            cbClassCourse.DisplayMember = "DisplayName";
            cbClassCourse.ValueMember = "ClassCourseID";
        }

        private void LoadSchedules()
        {
            _dtSchedules = clsSchedule.GetAllSchedulesDetailed();
            _dvSchedules = _dtSchedules.DefaultView;
            dgvSchedules.DataSource = _dvSchedules;

            if (dgvSchedules.Columns.Contains("ScheduleID"))
            {
                dgvSchedules.Columns["ScheduleID"].HeaderText = "المعرف";
                dgvSchedules.Columns["ScheduleID"].Width = 65;
            }
            if (dgvSchedules.Columns.Contains("DayOfWeek"))
            {
                dgvSchedules.Columns["DayOfWeek"].HeaderText = "اليوم";
                dgvSchedules.Columns["DayOfWeek"].Width = 100;
            }
            if (dgvSchedules.Columns.Contains("StartTime"))
            {
                dgvSchedules.Columns["StartTime"].HeaderText = "بداية الحصة";
                dgvSchedules.Columns["StartTime"].Width = 120;
            }
            if (dgvSchedules.Columns.Contains("EndTime"))
            {
                dgvSchedules.Columns["EndTime"].HeaderText = "نهاية الحصة";
                dgvSchedules.Columns["EndTime"].Width = 120;
            }
            if (dgvSchedules.Columns.Contains("ClassName"))
            {
                dgvSchedules.Columns["ClassName"].HeaderText = "الشعبة / الفصل";
                dgvSchedules.Columns["ClassName"].Width = 150;
            }
            if (dgvSchedules.Columns.Contains("CourseName"))
            {
                dgvSchedules.Columns["CourseName"].HeaderText = "المادة الدراسية";
                dgvSchedules.Columns["CourseName"].Width = 170;
            }
            if (dgvSchedules.Columns.Contains("TeacherName"))
            {
                dgvSchedules.Columns["TeacherName"].HeaderText = "المعلم";
                dgvSchedules.Columns["TeacherName"].Width = 180;
            }
            if (dgvSchedules.Columns.Contains("RoomName"))
            {
                dgvSchedules.Columns["RoomName"].HeaderText = "القاعة";
                dgvSchedules.Columns["RoomName"].Width = 140;
            }
            if (dgvSchedules.Columns.Contains("AcademicYear"))
            {
                dgvSchedules.Columns["AcademicYear"].HeaderText = "السنة الدراسية";
                dgvSchedules.Columns["AcademicYear"].Width = 150;
            }

            if (dgvSchedules.Columns.Contains("ClassCourseID")) dgvSchedules.Columns["ClassCourseID"].Visible = false;
            if (dgvSchedules.Columns.Contains("ClassID")) dgvSchedules.Columns["ClassID"].Visible = false;
            if (dgvSchedules.Columns.Contains("CourseID")) dgvSchedules.Columns["CourseID"].Visible = false;
            if (dgvSchedules.Columns.Contains("TeacherID")) dgvSchedules.Columns["TeacherID"].Visible = false;
            if (dgvSchedules.Columns.Contains("RoomID")) dgvSchedules.Columns["RoomID"].Visible = false;
            if (dgvSchedules.Columns.Contains("AcademicYearID")) dgvSchedules.Columns["AcademicYearID"].Visible = false;

            UpdateCount();
        }

        private void DgvSchedules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dgvSchedules.Columns[e.ColumnIndex].Name;
            if (colName == "DayOfWeek" && e.Value != null)
            {
                string rawDay = e.Value.ToString();
                if (_engToArabicDays.TryGetValue(rawDay, out string arabicDay))
                {
                    e.Value = arabicDay;
                    e.FormattingApplied = true;
                }
            }
        }

        private void ApplyFilter()
        {
            if (_dvSchedules == null) return;

            string selectedYear = cbFilterYear.SelectedItem?.ToString();
            string selectedClass = cbFilterClass.SelectedItem?.ToString();
            string selectedDay = cbFilterDay.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(selectedYear) && selectedYear != "كل السنوات")
            {
                filter = $"AcademicYear = '{selectedYear.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedClass) && selectedClass != "كل الشعب")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"ClassName = '{selectedClass.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedDay) && selectedDay != "كل الأيام")
            {
                // Translate Arabic filter back to English day name for DB view matching
                string engDay = _daysList.Find(d => d.ArabicName == selectedDay)?.EnglishName ?? selectedDay;
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"DayOfWeek = '{engDay.Replace("'", "''")}'";
            }

            _dvSchedules.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"إجمالي الحصص المجدولة: {_dvSchedules?.Count ?? 0}";
        }

        private void ResetEditor()
        {
            _EditingScheduleID = -1;
            lblFormTitle.Text = "جدولة حصة دراسية جديدة";
            btnCancelEdit.Visible = false;
            btnSave.Text = "حفظ الحصة";
            errorProvider1.Clear();
        }

        private bool ValidateSlot(out TimeSpan start, out TimeSpan end)
        {
            start = dtpStartTime.Value.TimeOfDay;
            end = dtpEndTime.Value.TimeOfDay;
            errorProvider1.Clear();
            bool isValid = true;

            if (cbClassCourse.SelectedValue == null)
            {
                errorProvider1.SetError(cbClassCourse, "الدرس والشعبة مطلوبان.");
                isValid = false;
            }
            if (cbRoom.SelectedValue == null)
            {
                errorProvider1.SetError(cbRoom, "القاعة الدراسية مطلوبة.");
                isValid = false;
            }
            if (cbYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbYear, "السنة الدراسية مطلوبة.");
                isValid = false;
            }

            if (start >= end)
            {
                errorProvider1.SetError(dtpEndTime, "يجب أن يكون وقت نهاية الحصة بعد وقت البدء.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSlot(out TimeSpan startTime, out TimeSpan endTime))
                return;

            int classCourseID = (int)cbClassCourse.SelectedValue;
            int roomID = (int)cbRoom.SelectedValue;
            int yearID = (int)cbYear.SelectedValue;
            string day = cbDay.SelectedValue?.ToString() ?? "Sunday";
            int? currentScheduleID = _EditingScheduleID == -1 ? (int?)null : _EditingScheduleID;

            // Strict conflict check (Teacher, Class, and Room overlap)
            if (clsSchedule.CheckScheduleConflict(currentScheduleID, yearID, day, startTime, endTime, roomID, classCourseID, out string conflictReason))
            {
                clsUITheme.ShowArabicMessage("تم اكتشاف تعارض في جدول الحصص الأسبوعي:\n\n" + conflictReason, "تعارض في الجدول", MessageBoxIcon.Warning);
                return;
            }

            clsSchedule schedule;
            if (_EditingScheduleID == -1)
            {
                schedule = new clsSchedule();
            }
            else
            {
                schedule = clsSchedule.Find(_EditingScheduleID);
                if (schedule == null)
                {
                    clsUITheme.ShowArabicMessage("لم يتم العثور على سجل الحصة المحددة.", "خطأ", MessageBoxIcon.Error);
                    ResetEditor();
                    return;
                }
            }

            schedule.ClassCourseID = classCourseID;
            schedule.DayOfWeek = day;
            schedule.StartTime = startTime;
            schedule.EndTime = endTime;
            schedule.RoomID = roomID;
            schedule.AcademicYearID = yearID;

            try
            {
                if (schedule.Save())
                {
                    clsUITheme.ShowArabicMessage("تم حفظ الحصة الدراسية في الجدول بنجاح.", "تم الحفظ", MessageBoxIcon.Information);
                    ResetEditor();
                    LoadSchedules();
                }
                else
                {
                    clsUITheme.ShowArabicMessage("فشل حفظ الحصة الدراسية في الجدول.", "خطأ", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                clsUITheme.ShowArabicMessage("حدث خطأ أثناء حفظ الحصة: " + ex.Message, "خطأ", MessageBoxIcon.Error);
            }
        }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            ResetEditor();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد حصة دراسية من الجدول لتعديلها.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            _EditingScheduleID = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["ScheduleID"].Value);
            clsSchedule s = clsSchedule.Find(_EditingScheduleID);
            if (s != null)
            {
                lblFormTitle.Text = $"تعديل الحصة الدراسية [رقم: {_EditingScheduleID}]";
                cbYear.SelectedValue = s.AcademicYearID;
                LoadClassCoursesDropdown();
                cbClassCourse.SelectedValue = s.ClassCourseID;
                cbRoom.SelectedValue = s.RoomID;
                cbDay.SelectedValue = s.DayOfWeek;
                dtpStartTime.Value = DateTime.Today.Add(s.StartTime);
                dtpEndTime.Value = DateTime.Today.Add(s.EndTime);

                btnCancelEdit.Visible = true;
                btnSave.Text = "تحديث الحصة";
            }
        }

        private void DgvSchedules_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow == null)
            {
                clsUITheme.ShowArabicMessage("يرجى تحديد حصة دراسية من الجدول لحذفها.", "تحديد مطلوب", MessageBoxIcon.Information);
                return;
            }

            int scheduleID = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["ScheduleID"].Value);
            string rawDay = dgvSchedules.CurrentRow.Cells["DayOfWeek"].Value.ToString();
            string day = _engToArabicDays.TryGetValue(rawDay, out string d) ? d : rawDay;
            string cls = dgvSchedules.CurrentRow.Cells["ClassName"].Value.ToString();
            string crs = dgvSchedules.CurrentRow.Cells["CourseName"].Value.ToString();

            if (MessageBox.Show($"هل أنت متأكد من رغبتك في حذف الحصة المجدولة لـ '{cls}' - مادة '{crs}' يوم ({day})؟\n\nتأكيد الحذف يتحقق من عدم وجود سجلات حضور مرتبطة بهذه الجلسة.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                try
                {
                    if (clsSchedule.DeleteSchedule(scheduleID))
                    {
                        clsUITheme.ShowArabicMessage("تم حذف الحصة الدراسية بنجاح.", "تم الحذف", MessageBoxIcon.Information);
                        if (_EditingScheduleID == scheduleID)
                            ResetEditor();
                        LoadSchedules();
                    }
                    else
                    {
                        clsUITheme.ShowArabicMessage("لا يمكن حذف الحصة. توجد سجلات حضور طلاب مسجلة بالفعل لهذه الحصة الدراسية.", "قيد مرتبط", MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsUITheme.ShowArabicMessage("حدث خطأ أثناء حذف الحصة: " + ex.Message, "خطأ", MessageBoxIcon.Error);
                }
            }
        }

        private void CbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassCoursesDropdown();
        }

        private void CbFilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CbFilterDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadSchedules();
        }

        private void FrmTimetableManagement_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadSchedules();
        }
    }
}
