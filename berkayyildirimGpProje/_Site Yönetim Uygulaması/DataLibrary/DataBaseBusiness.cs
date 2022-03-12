using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DatabaseBusiness
    {
        SqlConnection connection = new SqlConnection(@"server=BERKAY\SQLEXPRESS; database=Siteyönetim; Trusted_Connection=true;");
        public void ExecuteCommand(string cmdText, SqlParameter[] parameters)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }


        public DataTable ExecuteAdapter(string cmdText)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ExecuteAdapter(string cmdText, SqlParameter[] parameters)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connection);
            adapter.SelectCommand.Parameters.AddRange(parameters);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
