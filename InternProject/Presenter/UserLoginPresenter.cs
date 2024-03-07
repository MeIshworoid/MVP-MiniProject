using InternProject.View;
using MVPLibrary.Models;
using MVPLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternProject.Presenter
{
    public class UserLoginPresenter
    {
        private readonly IUserLogin _userLoginView;
        private readonly IUserRepository<UserViewModel> _userRepository;

        public UserLoginPresenter(IUserLogin userLoginView, IUserRepository<UserViewModel> userRepository)
        {
            _userLoginView = userLoginView;
            userLoginView.Presenter = this;
            _userRepository = userRepository;
        }

        public (bool, int, string) Login()
        {
            var users = _userRepository.GetUsers();
            bool isAuthenticated = false;
            int id = 0;
            string userName = "";
            foreach (UserViewModel user in users)
            {
                id = user.Id;
                userName = user.FirstName;
                string email = user.EmailAddress;
                string password = user.Password;

                isAuthenticated = AuthenticateUser(email, password);
                if (isAuthenticated == true)
                {
                    break;
                }
            }

            return (isAuthenticated, id, userName);
        }

        private bool AuthenticateUser(string email, string password)
        {
            if (email == _userLoginView.EmailAddress && password == _userLoginView.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
