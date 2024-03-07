using InternProject.Presenter;
using InternProject.Utility;
using InternProject.View;
using MVPDapperLibrary.Repositories;
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

namespace InternProject
{
    public partial class LoginForm : Form,IUserLogin
    {
        public string EmailAddress { get => this.emailText.Text; set => this.emailText.Text = value; }
        public string Password { get => this.passwordText.Text; set => this.passwordText.Text = value; }
        public UserLoginPresenter Presenter { get; set; }

        public LoginForm()
        {
            InitializeComponent();

            Presenter = new UserLoginPresenter(this, new DapUserRepository());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            (bool isValidUser, int id, string userName) = Presenter.Login();

            if(isValidUser == true)
            {
                SessionHelper.Id = id;
                SessionHelper.UserName = userName;

                MessageBox.Show($"{userName} User successfully logged in.");
                
                UserManagement userManagement = new UserManagement();
                userManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to log in. Please provide the valid credential!");
            }
        }
    }
}
