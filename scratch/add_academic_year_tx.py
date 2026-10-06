import os

dal_file = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemDataAccessLayer\clsDAAcademicYear.cs"
bll_file = r"C:\Users\Eng.Hafed\Desktop\School Management System\SchoolManagementSystemBusinessLayer\clsAcademicYear.cs"

def append_to_class(filepath, code):
    with open(filepath, "r", encoding="utf-8") as f:
        content = f.read()
    idx = content.rfind("}")
    idx2 = content.rfind("}", 0, idx)
    if idx2 != -1:
        content = content[:idx2] + code + "\n" + content[idx2:]
        with open(filepath, "w", encoding="utf-8") as f:
            f.write(content)
        print("Updated " + os.path.basename(filepath))

dal_code = """
        public static bool SetCurrentAcademicYear(int academicYearID)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string queryReset = "UPDATE AcademicYear SET IsCurrent = 0";
                            using (SqlCommand cmdReset = new SqlCommand(queryReset, connection, transaction))
                            {
                                cmdReset.ExecuteNonQuery();
                            }

                            string querySet = "UPDATE AcademicYear SET IsCurrent = 1, UpdatedAt = @UpdatedAt WHERE AcademicYearID = @AcademicYearID";
                            using (SqlCommand cmdSet = new SqlCommand(querySet, connection, transaction))
                            {
                                cmdSet.Parameters.AddWithValue("@AcademicYearID", academicYearID);
                                cmdSet.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                                cmdSet.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            isSuccess = true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            clsLogger.Error(ex.Message);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.Error(ex.Message);
                throw;
            }
            return isSuccess;
        }
"""

bll_code = """
        public static bool SetCurrentAcademicYear(int academicYearID) => clsDAAcademicYear.SetCurrentAcademicYear(academicYearID);
"""

append_to_class(dal_file, dal_code)
append_to_class(bll_file, bll_code)
