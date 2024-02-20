using InternProject.Presenter;
using MVPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternProject.View
{
    public interface IUserRegister
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string Password { get; set; }

        UserRegisterPresenter Presenter { get; set; }
    }
}
