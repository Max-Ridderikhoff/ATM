using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminpanel
{
    class AdminActions
    {
        Database connection = new Database();



        public void Logout()
        {
            Application.Restart();
        }

        //Adds a user to the application
        public void AddUser(string email, string account_number, string pin, int role, string fullname)
        {
            string query = "INSERT INTO user (email, account_number, pin, role, fullname) VALUES (@email, @account_number, @pin, @role, @fullname)";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@email", account_number);
                cmd.Parameters.AddWithValue("@account_number", email);
                cmd.Parameters.AddWithValue("@pin", pin);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@fullname", fullname);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                }


                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                Console.WriteLine("Success");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Fills the DataGridView with users
        public void fillWithUsers(DataGridView dataGridUsers)
        {
            dataGridUsers.Rows.Clear();
            string query = "SELECT * FROM user";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    dataGridUsers.Rows.Add(rdr["id"], rdr["fullname"], rdr["email"], rdr["account_number"], "Verwijderen", "Pas aan", rdr["blocked"], rdr["role"]);
                   
        
                }
                rdr.Close();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void makeAdmin(string rowid, string adminIndex, DataGridView dataGridUsers)
        {
            int id = Convert.ToInt32(rowid);
            int adminIndexer = Convert.ToInt32(adminIndex);
            dataGridUsers.Rows.Clear();

            string query = "UPDATE user SET role = @role where id = @id";

            try
            {
                connection.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection.connection);

                if(adminIndexer == 1)
                {
                    cmd.Parameters.AddWithValue("@role", 2);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@role", 1);
                }
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                Console.Write("Success");

                
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
            
        }

        public void blockCard(string id, string blocked, DataGridView dataGridUsers)
        {
            int blocker = Convert.ToInt32(blocked);
            int user_id = Convert.ToInt32(id);

            dataGridUsers.Rows.Clear();
            string query = "UPDATE user SET blocked = @blocked WHERE id = @id";

            try
            {
                connection.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection.connection);

                if(blocker == 0)
                {
                    cmd.Parameters.AddWithValue("@blocked", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@blocked", 0);
                }
                cmd.Parameters.AddWithValue("@id", user_id);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Success");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void returnUser(DataGridView dataGridUsers, string search)
        {
            dataGridUsers.Rows.Clear();
            string query = "SELECT * FROM user WHERE fullname LIKE '%" + search + "%' OR email LIKE '%" + search + "%' OR account_number LIKE '%" + search + "%'";

           try
            {
                connection.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                //cmd.Parameters.AddWithValue("@search", search);

                MySqlDataReader rdr = cmd.ExecuteReader();
           
                while (rdr.Read())
                {
                    dataGridUsers.Rows.Add(rdr["id"], rdr["fullname"], rdr["email"], rdr["account_number"], "Verwijderen", "Pas aan", rdr["blocked"], rdr["role"]);
                }
                
                connection.CloseConnection();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        //Runs through the database to check for an existing user
        public bool UserExistsCheck(string email)
        {
            string query = "SELECT email FROM user WHERE email= @email";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@email", email);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    connection.CloseConnection();
                    return false;
                }
                else
                {
                    connection.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        //Function removes user, using rowID as a value for the user_id
        public void deleteUser(string id, DataGridView table)
        {
            string query = "DELETE FROM user WHERE id = @id";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                connection.CloseConnection();

                table.Rows.Clear();
                this.fillWithUsers(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void updateUser(System.Windows.Forms.DataGridViewRow row, DataGridView datagridUsers)
        {
            string query = "UPDATE user SET email = @email WHERE id = @id";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@email", row.Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();

                connection.CloseConnection();

                datagridUsers.Rows.Clear();
                this.fillWithUsers(datagridUsers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public string hashPin(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
