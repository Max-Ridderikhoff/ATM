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
    public partial class storten : Form
    {
        mainUser mainUser = new mainUser();

        public storten()
        {
            InitializeComponent();
        }

        private void TakeMeHomeCountryRoads_Click(object sender, EventArgs e)
        {
            var Home = new userDashboard();
            Home.Show();
            this.Hide();
        }

        private void hoerin_Click(object sender, EventArgs e)
        {
            var voerin = new Invoer();
            voerin.Show();
            this.Hide();
        }

        private void storten_Load(object sender, EventArgs e)
        {

        }
    }
}
