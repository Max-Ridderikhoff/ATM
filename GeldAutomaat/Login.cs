using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeldAutomaat
{
    public partial class Login : Form
    {
        mainUser userActions = new mainUser();
        public Login()
        {
            InitializeComponent();
        }

        private void directToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Register = new Register();
            Register.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string account_number = accountNumberInput.Text;
            string pin = pinInput.Text;

            int returnValue = userActions.loginUser(account_number, pin);

            if (returnValue == 1)
            {
                Console.WriteLine("WELCOME USER USER");
                var userDashboard = new userDashboard();
                userDashboard.Show();
                this.Hide();
            }else if (returnValue == 2)
            {
                Console.WriteLine("welcome amdin");
                var admin = new adminpanel.adminDashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Email/password incorrect");
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
            this.Hide();
        }


    }
}


/*
  else if (returnValue == 2)
            {
                Console.WriteLine("WELCOME ADMIN");
                var adminDashbaord = new adminDashboard();
                adminDashbaord.Show();
                this.Hide();
            }
*/