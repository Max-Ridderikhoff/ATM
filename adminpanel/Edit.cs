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
    public partial class Edit : Form
    {
        AdminActions AdminActions = new AdminActions();
        public Edit()
        {
            InitializeComponent();
            AdminActions.fillWithUsers(dataGridUsers);
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string rowID = dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                AdminActions.deleteUser(rowID, dataGridUsers);
            }
            else if (e.ColumnIndex == 5)
            {
                System.Windows.Forms.DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];
                AdminActions.updateUser(row, dataGridUsers);

            }
            else if (e.ColumnIndex == 6)
            {
                string rowID = dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                string blocked = dataGridUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                

                AdminActions.blockCard(rowID, blocked, dataGridUsers);
                AdminActions.fillWithUsers(dataGridUsers);

            }
            else if (e.ColumnIndex == 7)
            {
                string id = dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                string adminIndex = dataGridUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
                AdminActions.makeAdmin(id, adminIndex, dataGridUsers);
                AdminActions.fillWithUsers(dataGridUsers);

            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            AdminActions.returnUser(dataGridUsers, search);
        }

        private void dataGridUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridUsers.Columns["block"].Index
                && e.Value != null)
            {
                switch (e.Value)
                {
                    case 0:
                        e.CellStyle.SelectionForeColor = Color.Lime;
                        e.CellStyle.ForeColor = Color.Lime;
                        break;
                    case 1:
                        e.CellStyle.SelectionForeColor = Color.Crimson;
                        e.CellStyle.ForeColor = Color.Crimson;
                        break;

                }
            }
            if (e.ColumnIndex == dataGridUsers.Columns["admin"].Index
                && e.Value != null)
            {
                switch (e.Value)
                {
                    case 1:
                        e.CellStyle.SelectionForeColor = Color.Crimson;
                        e.CellStyle.ForeColor = Color.Crimson;
                        break;
                    case 2:
                        e.CellStyle.SelectionForeColor = Color.Lime;
                        e.CellStyle.ForeColor = Color.Lime;
                        break;

                }
            }
        }

        private void countryRoadsTakeMeHome_Click(object sender, EventArgs e)
        {
            var countryRoadsTakeMeHome = new adminDashboard();
            countryRoadsTakeMeHome.Show();
            this.Hide();
        }

    }
}
