using InternProject.Presenter;
using MVPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternProject.View
{
    public interface IUserManagement
    {
        int SelectedUser { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string Password { get; set; }
        UserViewModel User { get; set; }
        List<string> UserName { get; set; }

       UserManagementPresenter Presenter { get; set; }
    }
}
