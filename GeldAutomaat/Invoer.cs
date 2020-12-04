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
    public partial class Invoer : Form
    {
        mainUser mainUser = new mainUser();

        public Invoer()
        {
            InitializeComponent();
        }
        Control ActiveControl;

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtInvoer.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtInvoer.Text);
            var storten = new storten();
            storten.Show();
            this.Hide();

    
            if (mainUser.addBalance(value) == true)
            {
                if (mainUser.blockedCard() == false)
                {
                        mainUser.transferLogs(value);

                }
                else
                {
                    // dont die
                }

                //epic
            }
            else
            {
                //not epic
            }
        }
    }
}
