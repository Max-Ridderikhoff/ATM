using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminpanel
{
    public partial class Toevoegen : Form
    {
        AdminActions AdminActions = new AdminActions();

        public Toevoegen()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int role;

            if (roleBox.Checked == true)
            {
                role = 2;
            }
            else
            {
                role = 1;
            }

            string fullname = fullName.Text;
            string accountNumber = Rekeningnmr.Text;
            string email = Email.Text;
            string pin = Pin.Text;
            string pin2 = Pin2.Text;
            string hashedPin;

            if (pin == pin2)
            {
                if (AdminActions.UserExistsCheck(email) == true)
                {

                    hashedPin = AdminActions.hashPin(pin);

                    AdminActions.AddUser(accountNumber, email, hashedPin, role, fullname);
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

            var countryRoadsTakeMeHome = new adminDashboard();
            countryRoadsTakeMeHome.Show();
            this.Hide();

        }

        private void countryRoadsTakeMeHome_Click(object sender, EventArgs e)
        {
            var countryRoadsTakeMeHome = new adminDashboard();
            countryRoadsTakeMeHome.Show();
            this.Hide();
        }
    }
}
