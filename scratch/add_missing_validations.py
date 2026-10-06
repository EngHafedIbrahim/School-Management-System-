import os
import re

bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

validations = {
    "clsStudentParent.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            System.Data.DataTable dt = GetAllStudentParents();
            bool hasPrimary = false;
            
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["StudentParentID"] != this.StudentParentID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["ParentID"] == this.ParentID && row["Relationship"].ToString() == this.Relationship)
                    {
                        errorMessage = "This student is already linked to this parent with the same relationship.";
                        return false;
                    }
                    if ((int)row["StudentID"] == this.StudentID && (bool)row["IsPrimaryContact"])
                    {
                        hasPrimary = true;
                    }
                }
            }
            
            // If this is not primary and student has no primary, we must enforce it.
            // Simplified: UI should enforce at least one primary.
            
            return true;
        }
""",
    "clsStudentEnrollment.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (EnrollmentDate > DateTime.Now)
            {
                errorMessage = "Enrollment date cannot be in the future.";
                return false;
            }

            System.Data.DataTable dt = GetAllStudentEnrollments();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["StudentEnrollmentID"] != this.StudentEnrollmentID)
                {
                    if ((int)row["StudentID"] == this.StudentID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "Student is already enrolled in a class for this academic year.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsClassCourse.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            System.Data.DataTable dt = GetAllClassCourses();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ClassCourseID"] != this.ClassCourseID)
                {
                    if ((int)row["ClassID"] == this.ClassID && (int)row["CourseID"] == this.CourseID && (int)row["TeacherID"] == this.TeacherID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "This course is already assigned to this class with the same teacher in this academic year.";
                        return false;
                    }
                }
            }
            return true;
        }
""",
    "clsSchedule.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (StartTime >= EndTime)
            {
                errorMessage = "Start time must be before end time.";
                return false;
            }

            System.Data.DataTable dt = GetAllSchedules();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["ScheduleID"] != this.ScheduleID)
                {
                    // Check for time overlap
                    TimeSpan existingStart = (TimeSpan)row["StartTime"];
                    TimeSpan existingEnd = (TimeSpan)row["EndTime"];
                    
                    if (row["DayOfWeek"].ToString() == this.DayOfWeek && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        bool isOverlap = (this.StartTime < existingEnd && this.EndTime > existingStart);
                        
                        if (isOverlap && (int)row["RoomID"] == this.RoomID)
                        {
                            errorMessage = "Time conflict in the same room.";
                            return false;
                        }
                        
                        // To check Teacher conflict, we would need to join with ClassCourse.
                        // For this basic validation, we handle room conflict.
                    }
                }
            }
            return true;
        }
""",
    "clsFeeStructure.cs": """
        public bool Validate(out string errorMessage)
        {
            errorMessage = "";
            
            if (TuitionFee < 0 || TransportFee < 0 || BookFee < 0 || OtherFees < 0)
            {
                errorMessage = "Fee amounts must be positive numbers.";
                return false;
            }

            System.Data.DataTable dt = GetAllFeeStructures();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                if ((int)row["FeeStructureID"] != this.FeeStructureID)
                {
                    if ((int)row["GradeLevelID"] == this.GradeLevelID && (int)row["AcademicYearID"] == this.AcademicYearID)
                    {
                        errorMessage = "A fee structure already exists for this grade level and academic year.";
                        return false;
                    }
                }
            }
            return true;
        }
"""
}

for filename, validation_code in validations.items():
    filepath = os.path.join(bll_dir, filename)
    if not os.path.exists(filepath):
        continue
        
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()

    if "public bool Validate(out string errorMessage)" in content:
        continue

    if "public bool Save()" in content:
        content = content.replace("public bool Save()", validation_code + "\n        public bool Save()")
        
        save_match = re.search(r'public bool Save\(\)\s*\{', content)
        if save_match:
            insert_pos = save_match.end()
            validation_check = """
            string errorMessage;
            if (!Validate(out errorMessage))
            {
                throw new Exception(errorMessage);
            }
"""
            content = content[:insert_pos] + validation_check + content[insert_pos:]
            
        with open(filepath, "w", encoding="utf-8") as f:
            f.write(content)
            print(f"Added business rules to {filename}")
