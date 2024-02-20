using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVPLibrary.DAO
{
    public static class UserDAO
    {
        private static string GetConnectionString(string connectionString = "Default")
        {
            string output = "";

            //var assemblyLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            output = configuration.GetConnectionString(connectionString);

            return output;
        }

        private static SqlConnection GetSqlConnection()
        {
            string connectionString = GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        public static int IDU(string sqlStatement,CommandType cmdType, SqlParameter[] sqlParameters)
        {
            using(SqlConnection sqlConnection = GetSqlConnection())
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sqlStatement;
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = cmdType;
                    if(sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetDataTable(string sqlStatement,CommandType cmdType, SqlParameter[] sqlParameters = null)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sqlStatement;
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = cmdType;
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
