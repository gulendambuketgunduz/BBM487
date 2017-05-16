using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryLoanSystem
{
    class Login
    {
        public SqlConnection createConnection()
        {
            SqlConnection connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=LibrarySystem;Trusted_Connection=True");
            return connection;
        }
        public SqlCommand insertUpdateDelete(SqlConnection connection, string sqlCommand)
        {

            SqlCommand command = new SqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
            return command;


        }
        public SqlDataAdapter select(SqlConnection connection, string sqlcommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand, connection);
            return adapter;

        }
    }
}
