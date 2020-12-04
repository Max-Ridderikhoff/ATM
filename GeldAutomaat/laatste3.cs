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
    public partial class laatste3 : Form
    {
        mainUser mainUser = new mainUser();

        public laatste3()
        {
            InitializeComponent();
            mainUser.transfers(dataGridTransacties);

        }

        private void TakeMeHomeCountryRoads_Click(object sender, EventArgs e)
        {
            var Home = new userDashboard();
            Home.Show();
            this.Hide();
        }
    }
}
