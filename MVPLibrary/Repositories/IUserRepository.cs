using MVPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPLibrary.Repositories
{
    public interface IUserRepository<T>
    {
        int CreateUser(UserViewModel user);
        int UpdateUser(UserViewModel user);
        int DeleteUser(int id);
        T GetUser();
        List<T> GetUsers();
        T GetUserByName(string userName);
    }
}
