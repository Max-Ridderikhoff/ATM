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
    public partial class adminDashboard : Form
    {
        AdminActions AdminActions = new AdminActions();

        public adminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var addUser = new Toevoegen();
            addUser.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var editUser = new Edit();
            editUser.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminActions.Logout();
        }
    }
}
