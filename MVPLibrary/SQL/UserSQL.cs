using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPLibrary.SQL
{
    public static class UserSQL
    {
        public const string getUsers = @"select Id, FirstName, LastName, EmailAddress, Password from Users";
        public const string getUserByName = @"select Id, FirstName, LastName, EmailAddress, Password from Users where FirstName=@FirstName";
        public const string createUser = @"insert into Users(FirstName,LastName,EmailAddress,Password)
                                           values(@FirstName,@LastName,@EmailAddress,@Password)";
        public const string updateUser = @"update Users set FirstName=@FirstName,LastName=@LastName,EmailAddress=@EmailAddress,Password=@Password where Id=@Id";
        public const string deleteUser = @"delete from Users where Id=@Id";
    }
}
