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
        public static int IDU(string sqlStatement,CommandType cmdType, SqlParameter[] sqlParameters)
        {
            using(SqlConnection sqlConnection = DbConnectionHelper.GetSqlConnection())
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
            using (SqlConnection sqlConnection = DbConnectionHelper.GetSqlConnection())
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
