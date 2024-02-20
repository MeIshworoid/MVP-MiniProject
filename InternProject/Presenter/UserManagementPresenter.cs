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
    public class UserManagementPresenter
    {
        private readonly IUserManagement _userManagementView;
        private readonly UserRepository _userRepository;

        public UserManagementPresenter(IUserManagement userManagementView, UserRepository userRepository)
        {
            _userManagementView = userManagementView;
            _userRepository = userRepository;
        }

        public void LoadUserName()
        {
            var users = _userRepository.GetUsers();

            List<string> names = new List<string>();
            string name = "";
            foreach (DataRow row in users.Rows)
            {
                name = row["FirstName"].ToString();
                names.Add(name);
            }

            _userManagementView.UserName = names;
        }

        public void GetUserDetail(string userName)
        {
            var data = _userRepository.GetUserByName(userName);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                UserViewModel user = new UserViewModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    EmailAddress = row["EmailAddress"].ToString(),
                    Password = row["Password"].ToString(),
                };

                _userManagementView.User = user;

                PopulateData(_userManagementView.User);
            }
        }

        private void PopulateData(UserViewModel user)
        {
            _userManagementView.SelectedUser = user.Id;
            _userManagementView.FirstName = user.FirstName;
            _userManagementView.LastName = user.LastName;
            _userManagementView.EmailAddress = user.EmailAddress;
            _userManagementView.Password = user.Password;

        }

        public (int,bool) UpdateUser(UserViewModel user)
        {
            int output = 0;
            bool isChanged = false;

            if(user.FirstName != _userManagementView.FirstName ||
               user.LastName != _userManagementView.LastName ||
               user.EmailAddress != _userManagementView.EmailAddress ||
               user.Password != _userManagementView.Password)
            {
                
                isChanged = true;

                user.FirstName = _userManagementView.FirstName;
                user.LastName = _userManagementView.LastName;
                user.EmailAddress = _userManagementView.EmailAddress;
                user.Password = _userManagementView.Password;

                output = _userRepository.UpdateUser(user);
            }

            return (output,isChanged);
        }

        public int DeleteUser(int userId)
        {
            int output = 0;
            output = _userRepository.DeleteUser(userId);
            return output;
        }
    }
}
