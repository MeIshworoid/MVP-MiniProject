using InternProject.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternProject.View
{
    public interface IUserLogin
    {
        string EmailAddress { get; set; }
        string Password { get; set; }

        UserLoginPresenter Presenter { get; set; }
    }
}
