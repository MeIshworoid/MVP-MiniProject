using MVPLibrary;
using MVPLibrary.Models;
using MVPLibrary.Repositories;
using MVPLibrary.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDapperLibrary.Repositories
{
    public class DapUserRepository : IUserRepository<UserViewModel>
    {
        private readonly DAO _db = new DAO();

        public int CreateUser(UserViewModel user)
        {
            return _db.SaveData(UserSQL.createUser,
                                new { user.FirstName, user.LastName, user.EmailAddress, user.Password },
                                DbConnectionHelper.GetConnectionString());
        }

        public int DeleteUser(int id)
        {
            return _db.SaveData(UserSQL.deleteUser, new {Id = id}, DbConnectionHelper.GetConnectionString());
        }

        public UserViewModel GetUserByName(string userName)
        {
            return _db.LoadData<UserViewModel, dynamic>(UserSQL.getUserByName,
                                                        new { FirstName = userName },
                                                        DbConnectionHelper.GetConnectionString()).First();
        }

        public UserViewModel GetUser()
        {
            return _db.LoadData<UserViewModel, dynamic>(UserSQL.getUsers,
                                                        new { },
                                                        DbConnectionHelper.GetConnectionString()).FirstOrDefault();
        }

        public List<UserViewModel> GetUsers()
        {
            return _db.LoadData<UserViewModel, dynamic>(UserSQL.getUsers,
                                                        new { },
                                                        DbConnectionHelper.GetConnectionString());
        }

        public int UpdateUser(UserViewModel user)
        {
            return _db.SaveData(UserSQL.updateUser,
                                new { user.Id, user.FirstName, user.LastName, user.EmailAddress, user.Password },
                                DbConnectionHelper.GetConnectionString());
        }
    }
}
