using InternProject.Presenter;
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
    public partial class UserRegistration : Form,IUserRegister
    {
        public UserRegistration()
        {
            InitializeComponent();

            Presenter = new UserRegisterPresenter(this, new UserRepository());
        }

        //TO-DO Implement this later
        public string FirstName { get => this.firstNameText.Text; set => this.firstNameText.Text = value; }
        public string LastName { get => this.lastNameText.Text; set => this.lastNameText.Text=value; }
        public string EmailAddress { get => this.emailText.Text; set => this.emailText.Text=value; }
        public string Password { get => this.passwordText.Text; set => this.passwordText.Text=value; }
        public UserRegisterPresenter Presenter { get; set; }
        

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = Presenter.SaveUser();

                if (row>0)
                {
                    MessageBox.Show("User registered successfully.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
