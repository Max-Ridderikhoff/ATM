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
    public partial class userDashboard : Form
    {
        mainUser mainUser = new mainUser();

        public userDashboard()
        {
            InitializeComponent();
        }

        private void trans_Click_1(object sender, EventArgs e)
        {
            var transForm = new transfer();
            transForm.Show();
            this.Hide();
        }

        private void storten_Click_1(object sender, EventArgs e)
        {
            var stortenForm = new storten();
            stortenForm.Show();
            this.Hide();
        }

        private void saldo_Click_1(object sender, EventArgs e)
        {
            var saldoForm = new saldo();
            saldoForm.Show();
            this.Hide();
        }

        private void laatste3_Click_1(object sender, EventArgs e)
        {
            var laatste3Form = new laatste3();
            laatste3Form.Show();
            this.Hide();

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            mainUser.Logout();
        }
    }
}
