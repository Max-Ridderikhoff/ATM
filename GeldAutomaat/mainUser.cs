using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Data;

namespace GeldAutomaat
{
    class mainUser
    {
        Database connection = new Database();
        //ROLES:
        //1 = user;
        //2 = admin;

        public int getUserId(string email)
        {
            string query = "SELECT id FROM user WHERE email = @email";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@email", email);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    int id;
                    int.TryParse(rdr["id"].ToString(), out id);
                    return id;
                }
                rdr.Close();
                cmd.ExecuteNonQuery();


                connection.CloseConnection();

                Console.WriteLine("GOT USERID");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

        public bool blockedCard()
        {
            string query = "SELECT * FROM user WHERE id = @id";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@id", globalClasses.globalUserId);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr["blocked"].ToString() == "0")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return true;
        }

        public int checkMoney()
        {
            string query = "SELECT saldo from user WHERE id = @id";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@id", globalClasses.globalUserId);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    int balance;
                    int.TryParse(rdr["balance"].ToString(), out balance);
                    return balance;
                }
                rdr.Close();

                cmd.ExecuteNonQuery();
                connection.CloseConnection();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }

       

        public void transferLogs(int value)
        {
            string query = "INSERT INTO transfers (money, user_id, time) VALUES (@money, @user_id, @time)";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                DateTime time = DateTime.Now;              
                string format = "yyyy-MM-dd HH:mm:ss";    


                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@money", value);
                cmd.Parameters.AddWithValue("@user_id", globalClasses.globalUserId);
                cmd.Parameters.AddWithValue("@time", time.ToString(format));
 
   

                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                Console.WriteLine("Successfully added " + value + " to the bank account");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void transfers(DataGridView dataGridTransacties)
        {
            dataGridTransacties.Rows.Clear();
            string query = "SELECT * FROM transactie WHERE user_id = @user_id ORDER BY id DESC LIMIT 3";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@user_id", globalClasses.globalUserId);

                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    dataGridTransacties.Rows.Add(rdr["id"], rdr["money"], rdr["date"]);
                }
                rdr.Close();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public int transferMoney(int value)
        {
            string query = "UPDATE user SET saldo = saldo - @value WHERE id = @id";
            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@id", globalClasses.globalUserId);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    int balance;
                    int.TryParse(rdr["balance"].ToString(), out balance);
                    return balance;
                }
                rdr.Close();

                cmd.ExecuteNonQuery();
                connection.CloseConnection();
           
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
            return 0;
        }

        public bool addBalance(int value)
        {
            string query = "UPDATE user SET saldo = saldo + @value WHERE id = @id";

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@id", globalClasses.globalUserId);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();

                Console.WriteLine("Successfully added " + value + " to the bank account");

                return true;
            }

            catch (Exception ex)
            {
                Console.Write(ex);

                return false;
            }
        }

       /* public void makeBalance(int user_id)
        {
            string query = "INSERT INTO balance (user_id, balance) VALUES (@user_id, @balance)";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@balance", 0);

                cmd.ExecuteNonQuery();
                connection.CloseConnection();
                Console.WriteLine("Inserted row!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }*/
        public void register(string account_number, string pin,string email)
        {
            string query = "INSERT INTO user (email, account_number, pin,  role) VALUES(@email, @account_number, @pin,  @role)";
            int role = 1;

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@account_number", account_number);
                cmd.Parameters.AddWithValue("@pin", pin);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();

                connection.CloseConnection();

                Console.WriteLine("Inserted row!");

                getUserId(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public int showSaldo(int id)
        {

            string query = "SELECT * from user WHERE user_id = @id";
            int saldo;

            try
            {
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@id", id);


                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    int.TryParse(rdr["saldo"].ToString(), out saldo);
                    return saldo;
                }
                rdr.Close();
                cmd.ExecuteNonQuery();

                connection.CloseConnection();
                Console.WriteLine("Success, got the users balance");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return 0;
        }


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

        public int loginUser(string account_number, string pin)
        {
            string query = "SELECT * FROM user WHERE account_number= @account_number";

            try
            {
                connection.CloseConnection();
                connection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                cmd.Parameters.AddWithValue("@account_number", account_number);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    var role = rdr["role"];
                    var pinDB = rdr["pin"];

                    if (pinDB.ToString() == hashPin(pin))
                    {
                        globalClasses.globalUserId = Convert.ToInt32(rdr["id"]);
                        connection.CloseConnection();
                        return Convert.ToInt32(role);
                    }
                    else
                    {
                        connection.CloseConnection();
                        return 999;
                    }
                }
                rdr.Close();
                connection.CloseConnection();
                return 999;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 999;
            }
        }

        public void Logout()
        {
            Application.Restart();
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
   /* public DataTable transfers()
    {
        DataTable Nigger = null;


        string query = "SELECT * FROM transfers WHERE user_id = @user_id ORDER BY id DESC LIMIT 3 ";

        try
        {
            connection.CloseConnection();
            connection.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query, connection.connection);

            cmd.Parameters.AddWithValue("user_id", globalClasses.globalUserId);


            MySqlDataReader rdr = cmd.ExecuteReader();

            Nigger.Load(cmd.ExecuteReader());
            /*while (rdr.Read())
            {

               dataGridTransacties.Rows.Add(rdr["id"], rdr["money"], rdr["time"]);

            }
            rdr.Close();


            cmd.ExecuteNonQuery();
            connection.CloseConnection();

            Console.WriteLine("Success");

            return Nigger;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return Nigger;
    }*/
}









