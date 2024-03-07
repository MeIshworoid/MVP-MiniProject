using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPLibrary
{
    public static class DbConnectionHelper
    {
        public static string GetConnectionString(string connectionString = "Default")
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

        public static SqlConnection GetSqlConnection()
        {
            string connectionString = GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
