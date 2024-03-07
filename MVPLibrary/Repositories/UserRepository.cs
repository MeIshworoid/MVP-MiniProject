using MVPLibrary.DAO;
using MVPLibrary.Models;
using MVPLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPLibrary.Repositories
{
    public class UserRepository : IUserRepository<DataTable>
    {
        public int CreateUser(UserViewModel user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName",user.FirstName),
                new SqlParameter("@LastName",user.LastName),
                new SqlParameter("@EmailAddress",user.EmailAddress),
                new SqlParameter("@Password",user.Password)
            };

            return UserDAO.IDU(UserSQL.createUser, CommandType.Text, sqlParameters);
        }

        public int DeleteUser(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id",id)
            };

            return UserDAO.IDU(UserSQL.deleteUser, CommandType.Text, sqlParameters);
        }

        public DataTable GetUserByName(string userName)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName",userName)
            };

            return UserDAO.GetDataTable(UserSQL.getUserByName, CommandType.Text, sqlParameters);
        }

        public DataTable GetUser()
        {
            return UserDAO.GetDataTable(UserSQL.getUsers, CommandType.Text);
        }

        public List<DataTable> GetUsers()
        {
            return new List<DataTable>();
        }

        public int UpdateUser(UserViewModel user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id",user.Id),
                new SqlParameter("@FirstName",user.FirstName),
                new SqlParameter("@LastName",user.LastName),
                new SqlParameter("@EmailAddress",user.EmailAddress),
                new SqlParameter("@Password",user.Password)
            };

            return UserDAO.IDU(UserSQL.updateUser, CommandType.Text, sqlParameters);
        }
    }
}
