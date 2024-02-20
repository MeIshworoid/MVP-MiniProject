using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDapperLibrary
{
    public class DAO
    {

        public List<T> LoadData<T,U>(string sqlStatement,U parameters,string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement,parameters).ToList();
                return rows;
            }
        }

        // Generics ma parameters lai ni generic banaunu xa vhane method <T> specify garnuparxa
        // same for return type, for both <T,T>
        // class<T> where T : class or new()

        public void SaveData<T>(string sqlStatement,T parameters,string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
