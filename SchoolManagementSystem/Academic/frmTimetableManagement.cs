using System;
using System.Data;
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

        public frmTimetableManagement()
        {
            InitializeComponent();

            clsUITheme.StyleDataGridView(dgvSchedules);
            clsUITheme.StylePrimaryButton(btnSave);
            clsUITheme.StyleSecondaryButton(btnCancelEdit);
            clsUITheme.StyleSecondaryButton(btnEdit);
            clsUITheme.StyleDangerButton(btnDelete);
            clsUITheme.StyleSecondaryButton(btnRefresh);

            cbDay.SelectedIndex = 0;
            cbFilterDay.SelectedIndex = 0;

            dtpStartTime.Value = DateTime.Today.AddHours(8).AddMinutes(0);
            dtpEndTime.Value = DateTime.Today.AddHours(8).AddMinutes(45);

            LoadDropdowns();
            LoadSchedules();
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
                dtRooms.Columns.Add("DisplayName", typeof(string), "Name + ' (Cap: ' + Capacity + ')'");
            }
            cbRoom.DataSource = dtRooms;
            cbRoom.DisplayMember = "DisplayName";
            cbRoom.ValueMember = "RoomID";

            // ClassCourses
            LoadClassCoursesDropdown();

            // Filter Dropdowns
            cbFilterYear.Items.Clear();
            cbFilterYear.Items.Add("All Years");
            foreach (DataRow r in dtYears.Rows)
            {
                cbFilterYear.Items.Add(r["YearName"].ToString());
            }
            cbFilterYear.SelectedIndex = 0;

            DataTable dtClasses = clsClass.GetAllClasss();
            cbFilterClass.Items.Clear();
            cbFilterClass.Items.Add("All Classes");
            foreach (DataRow r in dtClasses.Rows)
            {
                cbFilterClass.Items.Add(r["Name"].ToString());
            }
            cbFilterClass.SelectedIndex = 0;
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
                dgvSchedules.Columns["ScheduleID"].HeaderText = "ID";
                dgvSchedules.Columns["ScheduleID"].Width = 60;
            }
            if (dgvSchedules.Columns.Contains("DayOfWeek"))
            {
                dgvSchedules.Columns["DayOfWeek"].HeaderText = "Day";
                dgvSchedules.Columns["DayOfWeek"].Width = 100;
            }
            if (dgvSchedules.Columns.Contains("StartTime"))
            {
                dgvSchedules.Columns["StartTime"].HeaderText = "Start Time";
                dgvSchedules.Columns["StartTime"].Width = 90;
            }
            if (dgvSchedules.Columns.Contains("EndTime"))
            {
                dgvSchedules.Columns["EndTime"].HeaderText = "End Time";
                dgvSchedules.Columns["EndTime"].Width = 90;
            }
            if (dgvSchedules.Columns.Contains("ClassName"))
            {
                dgvSchedules.Columns["ClassName"].HeaderText = "Class";
                dgvSchedules.Columns["ClassName"].Width = 130;
            }
            if (dgvSchedules.Columns.Contains("CourseName"))
            {
                dgvSchedules.Columns["CourseName"].HeaderText = "Course / Subject";
                dgvSchedules.Columns["CourseName"].Width = 180;
            }
            if (dgvSchedules.Columns.Contains("TeacherName"))
            {
                dgvSchedules.Columns["TeacherName"].HeaderText = "Instructor";
                dgvSchedules.Columns["TeacherName"].Width = 180;
            }
            if (dgvSchedules.Columns.Contains("RoomName"))
            {
                dgvSchedules.Columns["RoomName"].HeaderText = "Room / Hall";
                dgvSchedules.Columns["RoomName"].Width = 120;
            }
            if (dgvSchedules.Columns.Contains("AcademicYear"))
            {
                dgvSchedules.Columns["AcademicYear"].HeaderText = "Academic Year";
                dgvSchedules.Columns["AcademicYear"].Width = 120;
            }

            if (dgvSchedules.Columns.Contains("ClassCourseID")) dgvSchedules.Columns["ClassCourseID"].Visible = false;
            if (dgvSchedules.Columns.Contains("ClassID")) dgvSchedules.Columns["ClassID"].Visible = false;
            if (dgvSchedules.Columns.Contains("CourseID")) dgvSchedules.Columns["CourseID"].Visible = false;
            if (dgvSchedules.Columns.Contains("TeacherID")) dgvSchedules.Columns["TeacherID"].Visible = false;
            if (dgvSchedules.Columns.Contains("RoomID")) dgvSchedules.Columns["RoomID"].Visible = false;
            if (dgvSchedules.Columns.Contains("AcademicYearID")) dgvSchedules.Columns["AcademicYearID"].Visible = false;

            UpdateCount();
        }

        private void ApplyFilter()
        {
            if (_dvSchedules == null) return;

            string selectedYear = cbFilterYear.SelectedItem?.ToString();
            string selectedClass = cbFilterClass.SelectedItem?.ToString();
            string selectedDay = cbFilterDay.SelectedItem?.ToString();

            string filter = "";

            if (!string.IsNullOrEmpty(selectedYear) && selectedYear != "All Years")
            {
                filter = $"AcademicYear = '{selectedYear.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedClass) && selectedClass != "All Classes")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"ClassName = '{selectedClass.Replace("'", "''")}'";
            }

            if (!string.IsNullOrEmpty(selectedDay) && selectedDay != "All Days")
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"DayOfWeek = '{selectedDay.Replace("'", "''")}'";
            }

            _dvSchedules.RowFilter = filter;
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblTotalCount.Text = $"Total Scheduled Slots: {_dvSchedules?.Count ?? 0}";
        }

        private void ResetEditor()
        {
            _EditingScheduleID = -1;
            lblFormTitle.Text = "Schedule Class Time Slot";
            btnCancelEdit.Visible = false;
            btnSave.Text = "Save Slot";
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
                errorProvider1.SetError(cbClassCourse, "Class lesson is required.");
                isValid = false;
            }
            if (cbRoom.SelectedValue == null)
            {
                errorProvider1.SetError(cbRoom, "Class room is required.");
                isValid = false;
            }
            if (cbYear.SelectedValue == null)
            {
                errorProvider1.SetError(cbYear, "Academic year is required.");
                isValid = false;
            }

            if (start >= end)
            {
                errorProvider1.SetError(dtpEndTime, "End time must be strictly after start time.");
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
            string day = cbDay.Text;
            int? currentScheduleID = _EditingScheduleID == -1 ? (int?)null : _EditingScheduleID;

            // Strict conflict check (Teacher, Class, and Room overlap)
            if (clsSchedule.CheckScheduleConflict(currentScheduleID, yearID, day, startTime, endTime, roomID, classCourseID, out string conflictReason))
            {
                MessageBox.Show("Timetable Schedule Conflict Detected:\n\n" + conflictReason, "Scheduling Conflict Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Schedule record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Schedule slot saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetEditor();
                    LoadSchedules();
                }
                else
                {
                    MessageBox.Show("Failed to save schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a schedule slot to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _EditingScheduleID = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["ScheduleID"].Value);
            clsSchedule s = clsSchedule.Find(_EditingScheduleID);
            if (s != null)
            {
                lblFormTitle.Text = $"Edit Scheduled Slot [ID: {_EditingScheduleID}]";
                cbYear.SelectedValue = s.AcademicYearID;
                LoadClassCoursesDropdown();
                cbClassCourse.SelectedValue = s.ClassCourseID;
                cbRoom.SelectedValue = s.RoomID;
                cbDay.Text = s.DayOfWeek;
                dtpStartTime.Value = DateTime.Today.Add(s.StartTime);
                dtpEndTime.Value = DateTime.Today.Add(s.EndTime);

                btnCancelEdit.Visible = true;
                btnSave.Text = "Update Slot";
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
                MessageBox.Show("Please select a schedule slot to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int scheduleID = Convert.ToInt32(dgvSchedules.CurrentRow.Cells["ScheduleID"].Value);
            string day = dgvSchedules.CurrentRow.Cells["DayOfWeek"].Value.ToString();
            string cls = dgvSchedules.CurrentRow.Cells["ClassName"].Value.ToString();
            string crs = dgvSchedules.CurrentRow.Cells["CourseName"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete scheduled slot for {cls} - {crs} on {day} (ID: {scheduleID})?\nThis action verifies that no student attendance records depend on this session.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (clsSchedule.DeleteSchedule(scheduleID))
                    {
                        MessageBox.Show("Schedule deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_EditingScheduleID == scheduleID)
                            ResetEditor();
                        LoadSchedules();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete schedule. Student attendance sessions have already been logged for this schedule slot.", "Constraint Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
