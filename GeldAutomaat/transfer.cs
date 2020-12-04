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
    public partial class transfer : Form
    {
        mainUser mainUser = new mainUser();

        public transfer()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            var Home = new userDashboard();
            Home.Show();
            this.Hide();
        }




        private void voerin_Click(object sender, EventArgs e)
        {
            var Voerin = new Invoer2();
            Voerin.Show(); ;
        }

        //all the stuffs


        private void roundButton2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton2.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);


                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton1.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);

                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }


        private void roundButton3_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton3.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);

                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton6.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);

                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }


        private void roundButton5_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton5.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);

                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(roundButton7.Text);

            if (mainUser.checkMoney() == 0)
            {
                foutmeldinglbl.Visible = true;
            }
            else
            {
                if (mainUser.blockedCard() == false)
                {

                    //dont do
                }
                else
                {
                    if (value >= 500)
                    {
                        fout.Visible = true;
                    }
                    else
                    {
                        mainUser.transferMoney(value);
                        mainUser.transferLogs(value);

                        var popup = new PinPopout();
                        popup.Show();

                        InitializeComponent();
                    }
                }

            }
        }
    }
}
