using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Pizza_System
{
    internal class pizzaDB
    {
        //Method to get the MySQL database connection
        public static MySqlConnection GetConnection()
        {
           
            string sql = "datasource=localhost;port=3306;username=root;password=Menusha#@123;database=pizzaDB";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL connection failed!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        //Method to add a customer to the database
        public static void addCustomer(customers std)
        {
           
            string sql = "INSERT INTO customer (FirstName, LastName, Address, Province, City, PostalCode, ContactNumber, Email) VALUES (@FirstName, @LastName, @Address, @Province, @City, @PostalCode, @ContactNumber, @Email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;

           
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = std.Fname;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = std.Lname;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = std.address;
            cmd.Parameters.Add("@Province", MySqlDbType.VarChar).Value = std.province;
            cmd.Parameters.Add("@City", MySqlDbType.VarChar).Value = std.city;
            cmd.Parameters.Add("@PostalCode", MySqlDbType.VarChar).Value = std.Pcode;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = std.CNo;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = std.Email;

            try
            {
               
                cmd.ExecuteNonQuery();
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to add customer!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                con.Close();
            }
        }

        // Method to add a payment to the database
        public static void addPayment(payment std)
        {
            string sql = "INSERT INTO payment (PaymentMethod, CardNo, AmountDue, AmountPaid) VALUES (@PaymentMethod, @CardNo, @AmountDue, @AmountPaid)";
            using (MySqlConnection con = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    
                    cmd.Parameters.Add("@PaymentMethod", MySqlDbType.VarChar).Value = std.PaymentMethod;
                    cmd.Parameters.Add("@CardNo", MySqlDbType.VarChar).Value = std.CardNo;
                    cmd.Parameters.Add("@AmountDue", MySqlDbType.Decimal).Value = std.AmountDue;
                    cmd.Parameters.Add("@AmountPaid", MySqlDbType.Decimal).Value = std.AmountPaid;

                    try
                    {
                       
                        cmd.ExecuteNonQuery();
                       
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Failed to add payment!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}