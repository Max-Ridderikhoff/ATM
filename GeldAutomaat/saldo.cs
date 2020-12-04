using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Providers.Entities;
using System.Windows.Forms;

namespace GeldAutomaat
{
    public partial class saldo : Form
    {
        mainUser mainUser = new mainUser();

        public saldo()
        {
            InitializeComponent();
            string money = mainUser.showSaldo(globalClasses.globalUserId).ToString();
            saldoLbl.Text = money;

        }

        private void TakeMeHomeCountryRoads_Click(object sender, EventArgs e)
        {
            var Home = new userDashboard();
            Home.Show();
            this.Hide();
        }
    }
}
