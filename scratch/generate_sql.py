import os

tables = {
    "AcademicYear": [("AcademicYearID", "int", True), ("YearName", "string", False), ("StartDate", "DateTime", False), ("EndDate", "DateTime", False), ("IsCurrent", "bool", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "Attendance": [("AttendanceID", "int", True), ("StudentID", "int", False), ("ClassID", "int", False), ("SessionID", "int", False), ("Date", "DateTime", False), ("Status", "string", False), ("Note", "string", False), ("CreatedBy", "int", False), ("CreatedAt", "DateTime", False)],
    "ClassCourse": [("ClassCourseID", "int", True), ("ClassID", "int", False), ("CourseID", "int", False), ("TeacherID", "int", False), ("AcademicYearID", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False), ("IsDeleted", "bool", False)],
    "Class": [("ClassID", "int", True), ("Name", "string", False), ("GradeLevelID", "int", False), ("Details", "string", False), ("CreatedBy", "int", False), ("UpdatedBy", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False), ("IsDeleted", "bool", False)],
    "Course": [("CourseID", "int", True), ("Name", "string", False), ("CreditHours", "int", False), ("Description", "string", False), ("CreatedBy", "int", False), ("UpdatedBy", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False), ("IsDeleted", "bool", False)],
    "ExamType": [("ExamTypeID", "int", True), ("Name", "string", False), ("Description", "string", False)],
    "FeeStructure": [("FeeStructureID", "int", True), ("Name", "string", False), ("GradeLevelID", "int", False), ("AcademicYearID", "int", False), ("TuitionFee", "decimal", False), ("TransportFee", "decimal", False), ("BookFee", "decimal", False), ("OtherFees", "decimal", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "Gender": [("GenderID", "int", True), ("Name", "string", False), ("Description", "string", False)],
    "GradeLevel": [("GradeLevelID", "int", True), ("Name", "string", False), ("OrderNo", "int", False), ("Description", "string", False)],
    "Grade": [("GradeID", "int", True), ("StudentID", "int", False), ("CourseID", "int", False), ("ExamTypeID", "int", False), ("GradeValue", "decimal", False), ("OutOfValue", "decimal", False), ("AcademicYearID", "int", False), ("CreatedBy", "int", False), ("CreatedAt", "DateTime", False)],
    "Invoice": [("InvoiceID", "int", True), ("InvoiceNumber", "string", False), ("StudentID", "int", False), ("AcademicYearID", "int", False), ("FeeStructureID", "int", False), ("IssueDate", "DateTime", False), ("DueDate", "DateTime", False), ("Subtotal", "decimal", False), ("DiscountAmount", "decimal", False), ("TaxAmount", "decimal", False), ("TotalAmount", "decimal", False), ("Status", "string", False), ("CreatedBy", "int", False)],
    "Parent": [("ParentID", "int", True), ("FirstName", "string", False), ("LastName", "string", False), ("PhoneNumber", "string", False), ("Email", "string", False), ("Address", "string", False), ("RelationshipType", "string", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False), ("IsDeleted", "bool", False)],
    "PaymentType": [("PaymentTypeID", "int", True), ("Name", "string", False), ("Description", "string", False)],
    "Payment": [("PaymentID", "int", True), ("InvoiceID", "int", False), ("PaymentDate", "DateTime", False), ("Amount", "decimal", False), ("PaymentMethod", "string", False), ("PaymentTypeID", "int", False), ("TransactionID", "string", False), ("ReceiptNumber", "string", False), ("Notes", "string", False), ("CreatedBy", "int", False), ("CreatedAt", "DateTime", False)],
    "Room": [("RoomID", "int", True), ("Name", "string", False), ("Capacity", "int", False), ("Description", "string", False)],
    "Schedule": [("ScheduleID", "int", True), ("ClassCourseID", "int", False), ("DayOfWeek", "string", False), ("StartTime", "TimeSpan", False), ("EndTime", "TimeSpan", False), ("RoomID", "int", False), ("AcademicYearID", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "StudentEnrollment": [("StudentEnrollmentID", "int", True), ("StudentID", "int", False), ("ClassID", "int", False), ("AcademicYearID", "int", False), ("EnrollmentDate", "DateTime", False), ("WithdrawalDate", "DateTime", True), ("Status", "string", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "StudentParent": [("StudentParentID", "int", True), ("StudentID", "int", False), ("ParentID", "int", False), ("Relationship", "string", False), ("IsPrimaryContact", "bool", False)],
    "Student": [("StudentID", "int", True), ("FirstName", "string", False), ("LastName", "string", False), ("NationalID", "string", False), ("DateOfBirth", "DateTime", False), ("GenderID", "int", False), ("Nationality", "string", False), ("BloodType", "string", False), ("Address", "string", False), ("PhoneNumber", "string", False), ("Email", "string", False), ("AdmissionNo", "string", False), ("AdmissionDate", "DateTime", False), ("PreviousSchool", "string", False), ("HealthStatus", "string", False), ("ProfileImageURL", "string", False), ("CreatedBy", "int", False), ("UpdatedBy", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "Teacher": [("TeacherID", "int", True), ("FirstName", "string", False), ("LastName", "string", False), ("Address", "string", False), ("PhoneNumber", "string", False), ("Email", "string", False), ("Specialization", "string", False), ("Qualification", "string", False), ("HireDate", "DateTime", False), ("EmploymentStatus", "string", False), ("About", "string", False), ("GenderID", "int", False), ("CreatedBy", "int", False), ("UpdatedBy", "int", False), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)],
    "User": [("UserID", "int", True), ("Username", "string", False), ("PasswordHash", "string", False), ("Email", "string", False), ("Status", "string", False), ("UserType", "string", False), ("ReferenceID", "int", True), ("CreatedAt", "DateTime", False), ("UpdatedAt", "DateTime", False)]
}

def get_sql_type(cs_type):
    if cs_type == "int": return "int"
    if cs_type == "string": return "nvarchar(MAX)"
    if cs_type == "DateTime": return "datetime"
    if cs_type == "bool": return "bit"
    if cs_type == "decimal": return "decimal(18,2)"
    if cs_type == "TimeSpan": return "time"
    return "nvarchar(MAX)"

sql_content = "CREATE DATABASE SchoolManagementSystemDB;\nGO\nUSE SchoolManagementSystemDB;\nGO\n\n"

# 1. Generate Tables
for tbl, cols in tables.items():
    sql_content += f"CREATE TABLE {tbl} (\n"
    for i, c in enumerate(cols):
        name, typ, is_null = c
        sql_type = get_sql_type(typ)
        if name == cols[0][0]:
            sql_content += f"    {name} {sql_type} IDENTITY(1,1) PRIMARY KEY"
        else:
            sql_content += f"    {name} {sql_type} {'NULL' if is_null else 'NOT NULL'}"
        
        if i < len(cols) - 1:
            sql_content += ",\n"
        else:
            sql_content += "\n"
    sql_content += ");\nGO\n\n"

# 2. Add Foreign Keys dynamically based on column names (e.g. StudentID -> Student(StudentID))
# Special case mapping to avoid exceptions
fk_mapping = {
    "SessionID": "Schedule",
    "CreatedBy": "User",
    "UpdatedBy": "User"
}

for tbl, cols in tables.items():
    for c in cols[1:]:
        col_name = c[0]
        ref_table = None
        if col_name.endswith("ID"):
            if col_name in fk_mapping:
                ref_table = fk_mapping[col_name]
            else:
                possible_table = col_name[:-2] # Remove "ID"
                if possible_table in tables:
                    ref_table = possible_table
        
        if ref_table:
            # We don't add User FKs for CreatedBy/UpdatedBy right now to avoid circular dependencies in dropping, 
            # but we will add standard structural FKs
            if ref_table != "User":
                sql_content += f"ALTER TABLE {tbl} ADD CONSTRAINT FK_{tbl}_{col_name} FOREIGN KEY ({col_name}) REFERENCES {ref_table}({ref_table}ID);\nGO\n\n"

with open(r"C:\Users\Eng.Hafed\Desktop\School Management System\DatabaseScript.sql", "w", encoding="utf-8") as f:
    f.write(sql_content)

print("SQL script generated successfully with Foreign Keys!")
