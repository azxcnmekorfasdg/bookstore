using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookStore
{
    public static class DatabaseHelper
    {
        public static SqlConnection CreateConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["BookStoreDB"].ConnectionString;
            return new SqlConnection(cs);
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }
}