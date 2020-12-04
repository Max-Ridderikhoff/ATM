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
    public partial class Register : Form
    {
        mainUser mainUser = new mainUser();

        public Register()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string accountNumber = accountNumberInput.Text;
            string pin = pinInput.Text;
            string pin2 = pinInput2.Text;
            string hashedPin;

            if (pin == pin2)
            {
                if (mainUser.UserExistsCheck(email) == false)
                {
                    userExistsLabel.Visible = false;

                    hashedPin = mainUser.hashPin(pin);

                    mainUser.register(email, hashedPin, accountNumber);
                }
                else
                {
                    userExistsLabel.Visible = true;
                }
            }
            else
            {
                Console.WriteLine("PASS ERROR");
            }
            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}

