using InternProject.View;
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
        private readonly UserRepository _userRepository;

        public UserLoginPresenter(IUserLogin userLoginView,UserRepository userRepository)
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
            foreach (DataRow userRow in users.Rows)
            {
                id = (int)userRow["Id"];
                userName = userRow["FirstName"].ToString();
                string email = userRow["EmailAddress"].ToString();
                string password = userRow["Password"].ToString();

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
