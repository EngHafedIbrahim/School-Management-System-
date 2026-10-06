# Data Access Layer (DAL) — Code Templates & Patterns

This reference document provides the complete, copy-paste-ready code templates
for the Data Access Layer. Every DAL class MUST follow these exact patterns.

---

## Connection Settings Class

```csharp
using System;

namespace <ProjectName>_DataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString =
            "Server=.;Database=<DatabaseName>;User Id=sa;Password=<Password>;";
    }
}
```

---

## Complete DAL Class Template

Below is the full template for a DAL class. Replace `<Entity>`, `<Entities>`,
and field names with your actual entity.

```csharp
using System;
using System.Data;
using System.Data.SqlClient;

namespace <ProjectName>_DataAccessLayer
{
    public class clsDA<Entity>
    {
        // ─────────────────── FIND BY ID ───────────────────
        public static bool Find(int <Entity>ID,
            ref string Field1, ref int Field2, ref DateTime Field3,
            ref string NullableField)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Find<Entity>By<Entity>ID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@<Entity>ID", <Entity>ID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;

                            // Required fields — direct cast
                            Field1 = (string)reader["Field1"];
                            Field2 = (int)reader["Field2"];
                            Field3 = (DateTime)reader["Field3"];

                            // Nullable fields — check DBNull
                            NullableField = (reader["NullableField"] != DBNull.Value)
                                ? (string)reader["NullableField"]
                                : "";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }

        // ─────────────── FIND BY UNIQUE FIELD ─────────────
        // (overload for alternative lookup, e.g., by NationalNO, Username)
        public static bool Find(string UniqueField,
            ref int <Entity>ID, ref string Field1, ref int Field2)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Find<Entity>By<UniqueField>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@<UniqueField>", UniqueField);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            IsFound = true;
                            <Entity>ID = (int)reader["<Entity>ID"];
                            Field1 = (string)reader["Field1"];
                            Field2 = (int)reader["Field2"];
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }

        // ─────────────────── ADD NEW ──────────────────────
        public static int AddNew<Entity>(string Field1, int Field2,
            DateTime Field3, string NullableField)
        {
            int NewID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_AddNew<Entity>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Required parameters
                    command.Parameters.AddWithValue("@Field1", Field1);
                    command.Parameters.AddWithValue("@Field2", Field2);
                    command.Parameters.AddWithValue("@Field3", Field3);

                    // Nullable parameters — use DBNull.Value if empty
                    if (!string.IsNullOrEmpty(NullableField))
                        command.Parameters.AddWithValue("@NullableField", NullableField);
                    else
                        command.Parameters.AddWithValue("@NullableField", DBNull.Value);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int insertedID))
                        {
                            NewID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return NewID;
        }

        // ─────────────────── UPDATE ───────────────────────
        public static bool Update<Entity>(int <Entity>ID, string Field1,
            int Field2, DateTime Field3, string NullableField)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Update<Entity>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@<Entity>ID", <Entity>ID);
                    command.Parameters.AddWithValue("@Field1", Field1);
                    command.Parameters.AddWithValue("@Field2", Field2);
                    command.Parameters.AddWithValue("@Field3", Field3);

                    if (!string.IsNullOrEmpty(NullableField))
                        command.Parameters.AddWithValue("@NullableField", NullableField);
                    else
                        command.Parameters.AddWithValue("@NullableField", DBNull.Value);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return RowsAffected > 0;
        }

        // ─────────────────── DELETE ───────────────────────
        public static bool Delete<Entity>(int <Entity>ID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Delete<Entity>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@<Entity>ID", <Entity>ID);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return RowsAffected > 0;
        }

        // ──────────────────── GET ALL ─────────────────────
        public static DataTable GetAll<Entities>()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAll<Entities>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return dt;
        }

        // ─────────────────── IS EXIST ─────────────────────
        public static bool Is<Entity>Exist(int <Entity>ID)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Is<Entity>Exist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@<Entity>ID", <Entity>ID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        IsFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }

        // ────────── IS EXIST BY UNIQUE FIELD ──────────────
        public static bool Is<Entity>Exist(string UniqueField)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Is<Entity>ExistBy<UniqueField>", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@<UniqueField>", UniqueField);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        IsFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.LogEvent(ex.Message,
                            System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return IsFound;
        }
    }
}
```

---

## Data Type Mapping Reference

| C# Type      | SQL Type           | Read Cast                          | DBNull Handling                                 |
| ------------ | ------------------ | ---------------------------------- | ----------------------------------------------- |
| `int`        | `INT`              | `(int)reader["Col"]`               | N/A (usually NOT NULL)                          |
| `string`     | `NVARCHAR`         | `(string)reader["Col"]`            | `(reader["Col"] != DBNull.Value) ? ... : ""`    |
| `DateTime`   | `DATETIME`         | `(DateTime)reader["Col"]`          | `(reader["Col"] != DBNull.Value) ? ... : DateTime.MinValue` |
| `bool`       | `BIT`              | `(bool)reader["Col"]`              | N/A                                             |
| `short`      | `SMALLINT`         | `(short)(int)reader["Col"]`        | N/A                                             |
| `decimal`    | `DECIMAL/FLOAT`    | `Convert.ToDecimal(reader["Col"])` | Check DBNull                                    |

---

## Stored Procedure Templates

### SP_Find<Entity>By<Entity>ID
```sql
CREATE PROCEDURE SP_Find<Entity>By<Entity>ID
    @<Entity>ID INT
AS
BEGIN
    SELECT * FROM <Table>
    WHERE <Entity>ID = @<Entity>ID;
END
```

### SP_AddNew<Entity>
```sql
CREATE PROCEDURE SP_AddNew<Entity>
    @Field1 NVARCHAR(50),
    @Field2 INT,
    @NullableField NVARCHAR(100) = NULL
AS
BEGIN
    INSERT INTO <Table> (Field1, Field2, NullableField)
    VALUES (@Field1, @Field2, @NullableField);

    SELECT SCOPE_IDENTITY();
END
```

### SP_Update<Entity>
```sql
CREATE PROCEDURE SP_Update<Entity>
    @<Entity>ID INT,
    @Field1 NVARCHAR(50),
    @Field2 INT,
    @NullableField NVARCHAR(100) = NULL
AS
BEGIN
    UPDATE <Table>
    SET Field1 = @Field1,
        Field2 = @Field2,
        NullableField = @NullableField
    WHERE <Entity>ID = @<Entity>ID;
END
```

### SP_Delete<Entity>
```sql
CREATE PROCEDURE SP_Delete<Entity>
    @<Entity>ID INT
AS
BEGIN
    DELETE FROM <Table>
    WHERE <Entity>ID = @<Entity>ID;
END
```

### SP_GetAll<Entities>
```sql
CREATE PROCEDURE SP_GetAll<Entities>
AS
BEGIN
    SELECT * FROM <Table>
    ORDER BY <Entity>ID DESC;
END
```

### SP_Is<Entity>Exist
```sql
CREATE PROCEDURE SP_Is<Entity>Exist
    @<Entity>ID INT
AS
BEGIN
    SELECT Found = 1 FROM <Table>
    WHERE <Entity>ID = @<Entity>ID;
END
```
