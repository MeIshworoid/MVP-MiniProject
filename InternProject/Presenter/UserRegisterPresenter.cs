using InternProject.View;
using MVPLibrary.Models;
using MVPLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternProject.Presenter
{
    public class UserRegisterPresenter
    {
        private readonly IUserRegister _userRegisterView;
        private readonly IUserRepository _userRepository;

        public UserRegisterPresenter(IUserRegister userRegisterView, IUserRepository userRepository)
        {
            _userRegisterView = userRegisterView;
            userRegisterView.Presenter = this;
            _userRepository = userRepository;
        }

        public int SaveUser()
        {
            UserViewModel user = new UserViewModel
            {
                FirstName = _userRegisterView.FirstName,
                LastName = _userRegisterView.LastName,
                EmailAddress = _userRegisterView.EmailAddress,
                Password = _userRegisterView.Password
            };

            return _userRepository.CreateUser(user);
        }
    }
}
