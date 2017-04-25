using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryLoanSystem
{
    static class DBOperations
    {
         
            public static SqlConnection createConnection()
            {
                SqlConnection _connectionStr =
                    new SqlConnection("Server=IREM\\SQLEXPRESS;Database=LibrarySystem; Trusted_Connection=True;");
                return _connectionStr;
            }


            public static int insertUpdateDelete(string sqlCommand)
            {
                using (SqlConnection _conn=createConnection())
                {
                    int _returnvalue = 0;
                    try
                    {

                        SqlCommand command = new SqlCommand(sqlCommand, _conn);
                        _conn.Open();
                        _returnvalue = command.ExecuteNonQuery();/*Returns number of affected records*/
                    }
                    catch(Exception e)
                    {
                        if (e.Message.StartsWith("Violation of PRIMARY KEY"))
                            throw e;
                    }
                    finally
                    {

                        _conn.Close();
                    }

                    return _returnvalue;
                }

            }


            public static DataTable Select(string sqlcommand)/*Pulls the record*/
            {
                DataTable _dt = null;
                using (SqlConnection _conn = createConnection())
                {
                    try
                    {
                        SqlDataAdapter adptr = new SqlDataAdapter(sqlcommand, _conn);
                        _dt = new DataTable();
                        _conn.Open();
                        adptr.Fill(_dt);
                    }
                    catch(Exception e)
                    {

                    }
                    finally
                    {
                        _conn.Close();
                    }
                }
                return _dt;

            }
        
    }
}
