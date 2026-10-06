import json
import os

tables = {
    "AcademicYear": [
        ("AcademicYearID", "int", True),
        ("YearName", "string", False),
        ("StartDate", "DateTime", False),
        ("EndDate", "DateTime", False),
        ("IsCurrent", "bool", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "Attendance": [
        ("AttendanceID", "int", True),
        ("StudentID", "int", False),
        ("ClassID", "int", False),
        ("SessionID", "int", False),
        ("Date", "DateTime", False),
        ("Status", "string", False),
        ("Note", "string", False),
        ("CreatedBy", "int", False),
        ("CreatedAt", "DateTime", False)
    ],
    "ClassCourse": [
        ("ClassCourseID", "int", True),
        ("ClassID", "int", False),
        ("CourseID", "int", False),
        ("TeacherID", "int", False),
        ("AcademicYearID", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False),
        ("IsDeleted", "bool", False)
    ],
    "Class": [
        ("ClassID", "int", True),
        ("Name", "string", False),
        ("GradeLevelID", "int", False),
        ("Details", "string", False),
        ("CreatedBy", "int", False),
        ("UpdatedBy", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False),
        ("IsDeleted", "bool", False)
    ],
    "Course": [
        ("CourseID", "int", True),
        ("Name", "string", False),
        ("CreditHours", "int", False),
        ("Description", "string", False),
        ("CreatedBy", "int", False),
        ("UpdatedBy", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False),
        ("IsDeleted", "bool", False)
    ],
    "ExamType": [
        ("ExamTypeID", "int", True),
        ("Name", "string", False),
        ("Description", "string", False)
    ],
    "FeeStructure": [
        ("FeeStructureID", "int", True),
        ("Name", "string", False),
        ("GradeLevelID", "int", False),
        ("AcademicYearID", "int", False),
        ("TuitionFee", "decimal", False),
        ("TransportFee", "decimal", False),
        ("BookFee", "decimal", False),
        ("OtherFees", "decimal", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "Gender": [
        ("GenderID", "int", True),
        ("Name", "string", False),
        ("Description", "string", False)
    ],
    "GradeLevel": [
        ("GradeLevelID", "int", True),
        ("Name", "string", False),
        ("OrderNo", "int", False),
        ("Description", "string", False)
    ],
    "Grade": [
        ("GradeID", "int", True),
        ("StudentID", "int", False),
        ("CourseID", "int", False),
        ("ExamTypeID", "int", False),
        ("GradeValue", "decimal", False),
        ("OutOfValue", "decimal", False),
        ("AcademicYearID", "int", False),
        ("CreatedBy", "int", False),
        ("CreatedAt", "DateTime", False)
    ],
    "Invoice": [
        ("InvoiceID", "int", True),
        ("InvoiceNumber", "string", False),
        ("StudentID", "int", False),
        ("AcademicYearID", "int", False),
        ("FeeStructureID", "int", False),
        ("IssueDate", "DateTime", False),
        ("DueDate", "DateTime", False),
        ("Subtotal", "decimal", False),
        ("DiscountAmount", "decimal", False),
        ("TaxAmount", "decimal", False),
        ("TotalAmount", "decimal", False),
        ("Status", "string", False),
        ("CreatedBy", "int", False)
    ],
    "Parent": [
        ("ParentID", "int", True),
        ("FirstName", "string", False),
        ("LastName", "string", False),
        ("PhoneNumber", "string", False),
        ("Email", "string", False),
        ("Address", "string", False),
        ("RelationshipType", "string", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False),
        ("IsDeleted", "bool", False)
    ],
    "PaymentType": [
        ("PaymentTypeID", "int", True),
        ("Name", "string", False),
        ("Description", "string", False)
    ],
    "Payment": [
        ("PaymentID", "int", True),
        ("InvoiceID", "int", False),
        ("PaymentDate", "DateTime", False),
        ("Amount", "decimal", False),
        ("PaymentMethod", "string", False),
        ("PaymentTypeID", "int", False),
        ("TransactionID", "string", False),
        ("ReceiptNumber", "string", False),
        ("Notes", "string", False),
        ("CreatedBy", "int", False),
        ("CreatedAt", "DateTime", False)
    ],
    "Room": [
        ("RoomID", "int", True),
        ("Name", "string", False),
        ("Capacity", "int", False),
        ("Description", "string", False)
    ],
    "Schedule": [
        ("ScheduleID", "int", True),
        ("ClassCourseID", "int", False),
        ("DayOfWeek", "string", False),
        ("StartTime", "TimeSpan", False),
        ("EndTime", "TimeSpan", False),
        ("RoomID", "int", False),
        ("AcademicYearID", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "StudentEnrollment": [
        ("StudentEnrollmentID", "int", True),
        ("StudentID", "int", False),
        ("ClassID", "int", False),
        ("AcademicYearID", "int", False),
        ("EnrollmentDate", "DateTime", False),
        ("WithdrawalDate", "DateTime", True), # nullable
        ("Status", "string", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "StudentParent": [
        ("StudentParentID", "int", True),
        ("StudentID", "int", False),
        ("ParentID", "int", False),
        ("Relationship", "string", False),
        ("IsPrimaryContact", "bool", False)
    ],
    "Student": [
        ("StudentID", "int", True),
        ("FirstName", "string", False),
        ("LastName", "string", False),
        ("NationalID", "string", False),
        ("DateOfBirth", "DateTime", False),
        ("GenderID", "int", False),
        ("Nationality", "string", False),
        ("BloodType", "string", False),
        ("Address", "string", False),
        ("PhoneNumber", "string", False),
        ("Email", "string", False),
        ("AdmissionNo", "string", False),
        ("AdmissionDate", "DateTime", False),
        ("PreviousSchool", "string", False),
        ("HealthStatus", "string", False),
        ("ProfileImageURL", "string", False),
        ("CreatedBy", "int", False),
        ("UpdatedBy", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "Teacher": [
        ("TeacherID", "int", True),
        ("FirstName", "string", False),
        ("LastName", "string", False),
        ("Address", "string", False),
        ("PhoneNumber", "string", False),
        ("Email", "string", False),
        ("Specialization", "string", False),
        ("Qualification", "string", False),
        ("HireDate", "DateTime", False),
        ("EmploymentStatus", "string", False),
        ("About", "string", False),
        ("GenderID", "int", False),
        ("CreatedBy", "int", False),
        ("UpdatedBy", "int", False),
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ],
    "User": [
        ("UserID", "int", True),
        ("Username", "string", False),
        ("PasswordHash", "string", False),
        ("Email", "string", False),
        ("Status", "string", False),
        ("UserType", "string", False),
        ("ReferenceID", "int", True), # nullable
        ("CreatedAt", "DateTime", False),
        ("UpdatedAt", "DateTime", False)
    ]
}

dal_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemDataAccessLayer"
bll_dir = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer"

def get_sql_type(cs_type):
    if cs_type == "int": return "int"
    if cs_type == "string": return "nvarchar"
    if cs_type == "DateTime": return "datetime"
    if cs_type == "bool": return "bit"
    if cs_type == "decimal": return "decimal"
    if cs_type == "TimeSpan": return "time"
    return "nvarchar"

def get_reader_cast(col, c_type, nullable):
    if c_type == "string":
        return f'reader["{col}"] != DBNull.Value ? (string)reader["{col}"] : ""'
    else:
        if nullable:
            return f'reader["{col}"] != DBNull.Value ? ({c_type}?)reader["{col}"] : null'
        return f'({c_type})reader["{col}"]'

def generate_dal(entity_name, cols):
    pk = cols[0]
    id_name = pk[0]
    
    find_params = []
    find_refs = []
    add_params = []
    add_args = []
    update_params = []
    
    for c in cols:
        name, typ, is_null = c
        if name == id_name:
            is_null = False
            find_params.append(f"{typ} {name}")
            update_params.append(f"{typ} {name}")
        else:
            if is_null and typ != "string":
                typ = typ + "?"
            find_params.append(f"ref {typ} {name}")
            find_refs.append(f"{name} = {get_reader_cast(name, c[1], is_null)};")
            add_params.append(f"{typ} {name}")
            
            # handle DBNull for add
            val = name
            if is_null or typ == "string":
                val = f'(object){name} ?? DBNull.Value'
            
            add_args.append(f'command.Parameters.AddWithValue("@{name}", {val});')
            update_params.append(f"{typ} {name}")

    find_params_str = ", ".join(find_params)
    add_params_str = ", ".join(add_params)
    update_params_str = ", ".join(update_params)
    
    template = f"""using System;
using System.Data;
using System.Data.SqlClient;
using UtilityLib;

namespace SchoolManagementSystemDataAccessLayer
{{
    public static class clsDA{entity_name}
    {{
        public static bool Find({find_params_str})
        {{
            bool isFound = false;
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = "SELECT * FROM {entity_name} WHERE {id_name} = @{id_name}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue("@{id_name}", {id_name});
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if (reader.Read())
                            {{
                                isFound = true;
                                {chr(10).join(['                                ' + r for r in find_refs])}
                            }}
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return isFound;
        }}

        public static {pk[1]} AddNew{entity_name}({add_params_str})
        {{
            {pk[1]} {id_name} = -1;
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = @"INSERT INTO {entity_name} ({', '.join([c[0] for c in cols[1:]])}) 
                                     VALUES ({', '.join(['@' + c[0] for c in cols[1:]])});
                                     SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        {chr(10).join(['                        ' + a for a in add_args])}
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && {pk[1]}.TryParse(result.ToString(), out {pk[1]} insertedID))
                        {{
                            {id_name} = insertedID;
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return {id_name};
        }}

        public static bool Update{entity_name}({update_params_str})
        {{
            int rowsAffected = 0;
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = @"UPDATE [{entity_name}] 
                                     SET {', '.join([c[0] + ' = @' + c[0] for c in cols[1:]])}
                                     WHERE {id_name} = @{id_name}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue("@{id_name}", {id_name});
                        {chr(10).join(['                        ' + a for a in add_args])}
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return (rowsAffected > 0);
        }}

        public static bool Delete{entity_name}({pk[1]} {id_name})
        {{
            int rowsAffected = 0;
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = "DELETE FROM {entity_name} WHERE {id_name} = @{id_name}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue("@{id_name}", {id_name});
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return (rowsAffected > 0);
        }}

        public static DataTable GetAll{entity_name}s()
        {{
            DataTable dt = new DataTable();
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = "SELECT * FROM {entity_name}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if (reader.HasRows)
                                dt.Load(reader);
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return dt;
        }}

        public static bool Is{entity_name}Exist({pk[1]} {id_name})
        {{
            bool isFound = false;
            try
            {{
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {{
                    string query = "SELECT TOP 1 1 FROM {entity_name} WHERE {id_name} = @{id_name}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {{
                        command.Parameters.AddWithValue("@{id_name}", {id_name});
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {{
                            isFound = Convert.ToInt32(result) > 0;
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsLogger.Error(ex.Message);
            }}
            return isFound;
        }}
    }}
}}
"""
    return template

def generate_bll(entity_name, cols):
    pk = cols[0]
    id_name = pk[0]
    
    props = []
    default_assigns = []
    param_args = []
    param_assigns = []
    find_vars = []
    find_refs = []
    find_params = []
    add_args = []
    update_args = []
    
    nav_props = []
    for c in cols:
        name, typ, is_null = c
        if name == id_name:
            is_null = False
        if is_null and typ != "string":
            typ = typ + "?"
            
        props.append(f"public {typ} {name} {{ get; set; }}")
        param_args.append(f"{typ} {name}")
        param_assigns.append(f"this.{name} = {name};")

        if name.endswith("ID") and name != id_name and not name.startswith("Created") and not name.startswith("Updated"):
            rel_name = name[:-2]
            if rel_name in tables:
                if is_null:
                    nav_props.append(f"public cls{rel_name} {rel_name}Info => this.{name}.HasValue ? cls{rel_name}.Find(this.{name}.Value) : null;")
                else:
                    nav_props.append(f"public cls{rel_name} {rel_name}Info => cls{rel_name}.Find(this.{name});")
        
        if name == id_name:
            default_assigns.append(f"this.{name} = -1;")
            find_params.append(f"{name}")
            update_args.append(f"this.{name}")
        else:
            if typ == "string":
                default_assigns.append(f'this.{name} = "";')
                find_vars.append(f'{typ} {name} = "";')
            elif typ == "bool":
                default_assigns.append(f'this.{name} = false;')
                find_vars.append(f'{typ} {name} = false;')
            elif typ == "DateTime":
                default_assigns.append(f'this.{name} = DateTime.Now;')
                find_vars.append(f'{typ} {name} = DateTime.Now;')
            elif typ == "TimeSpan":
                default_assigns.append(f'this.{name} = TimeSpan.Zero;')
                find_vars.append(f'{typ} {name} = TimeSpan.Zero;')
            else:
                if is_null:
                    default_assigns.append(f'this.{name} = null;')
                    find_vars.append(f'{typ} {name} = null;')
                else:
                    default_assigns.append(f'this.{name} = -1;')
                    find_vars.append(f'{typ} {name} = -1;')
            
            find_refs.append(f"ref {name}")
            find_params.append(f"{name}")
            add_args.append(f"this.{name}")
            update_args.append(f"this.{name}")

    props_str = "\n        ".join(props)
    nav_props_str = ("\n        " + "\n        ".join(nav_props)) if nav_props else ""
    default_assigns_str = "\n            ".join(default_assigns)
    param_args_str = ", ".join(param_args)
    param_assigns_str = "\n            ".join(param_assigns)
    find_vars_str = "\n            ".join(find_vars)
    find_refs_str = ", ".join([id_name] + find_refs)
    find_params_str = ", ".join(find_params)
    add_args_str = ", ".join(add_args)
    update_args_str = ", ".join(update_args)
    
    template = f"""using System;
using System.Data;
using SchoolManagementSystemDataAccessLayer;

namespace SchoolManagementSystemBusinessLayer
{{
    public class cls{entity_name}
    {{
        enum enMode {{ AddNew = 0, Update = 1 }}
        enMode Mode = enMode.AddNew;

        {props_str}
{nav_props_str}

        public cls{entity_name}()
        {{
            {default_assigns_str}
            Mode = enMode.AddNew;
        }}

        private cls{entity_name}({param_args_str})
        {{
            {param_assigns_str}
            Mode = enMode.Update;
        }}

        public static cls{entity_name} Find({pk[1]} {id_name})
        {{
            {find_vars_str}
            if (clsDA{entity_name}.Find({find_refs_str}))
                return new cls{entity_name}({find_params_str});
            return null;
        }}

        private bool _AddNew{entity_name}()
        {{
            this.{id_name} = clsDA{entity_name}.AddNew{entity_name}({add_args_str});
            return (this.{id_name} != -1);
        }}

        private bool _Update{entity_name}()
        {{
            return clsDA{entity_name}.Update{entity_name}({update_args_str});
        }}

        public bool Save()
        {{
            switch (Mode)
            {{
                case enMode.AddNew:
                    if (_AddNew{entity_name}())
                    {{
                        Mode = enMode.Update;
                        return true;
                    }}
                    return false;
                case enMode.Update:
                    return _Update{entity_name}();
            }}
            return false;
        }}

        public static DataTable GetAll{entity_name}s() => clsDA{entity_name}.GetAll{entity_name}s();
        public static bool Is{entity_name}Exist({pk[1]} {id_name}) => clsDA{entity_name}.Is{entity_name}Exist({id_name});
        public static bool Delete{entity_name}({pk[1]} {id_name}) => clsDA{entity_name}.Delete{entity_name}({id_name});
    }}
}}
"""
    return template


for tbl, cols in tables.items():
    dal_code = generate_dal(tbl, cols)
    bll_code = generate_bll(tbl, cols)
    
    with open(os.path.join(dal_dir, f"clsDA{tbl}.cs"), "w", encoding="utf-8") as f:
        f.write(dal_code)
        
    with open(os.path.join(bll_dir, f"cls{tbl}.cs"), "w", encoding="utf-8") as f:
        f.write(bll_code)

print("Generated all classes!")
