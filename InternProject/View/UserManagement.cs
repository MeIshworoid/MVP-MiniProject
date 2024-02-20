using InternProject.Presenter;
using InternProject.Utility;
using MVPLibrary.Models;
using MVPLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternProject.View
{
    public partial class UserManagement : Form, IUserManagement
    {
        public UserManagement()
        {
            InitializeComponent();

            loginInfoLabel.Text = $"Id: {SessionHelper.Id} Username: {SessionHelper.UserName}";

            Presenter = new UserManagementPresenter(this, new UserRepository());

            GetUserNameList();
        }

        public int SelectedUser { get; set; }
        public string FirstName { get => this.firstNameText.Text; set => this.firstNameText.Text = value; }
        public string LastName { get => this.lastNameText.Text; set => this.lastNameText.Text = value; }
        public string EmailAddress { get => this.emailText.Text; set => this.emailText.Text = value; }
        public string Password { get => this.passwordText.Text; set => this.passwordText.Text = value; }
        public UserViewModel User { get; set; }
        public List<string> UserName { get => (List<string>)this.userLists.DataSource; set => this.userLists.DataSource = value; }
        public UserManagementPresenter Presenter { get; set; }

        private void GetUserNameList()
        {
            Presenter.LoadUserName();
        }

        private void userLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userName = userLists.SelectedItem.ToString();
            Presenter.GetUserDetail(userName);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            (int row, bool isDataChanged) = Presenter.UpdateUser(User);

            if (row > 0 && isDataChanged == true)
            {
                MessageBox.Show("User updated successfully.");

                GetUserNameList();
            }
            else
            {
                MessageBox.Show("Failed to update.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int row = Presenter.DeleteUser(SelectedUser);

            if (row > 0)
            {
                MessageBox.Show("User deleted successfully.");

                GetUserNameList();
            }
            else
            {
                MessageBox.Show("Failed to delete.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstNameText.Clear();
            lastNameText.Clear();
            emailText.Clear();
            passwordText.Clear();
        }
    }
}
