using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRCINVENTORYUPDATED
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox3.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Proceed to next part of your application
                // Open the Register form and close the Login form
                Warehouse warehouse = new Warehouse();
                warehouse.Show();
                this.Hide(); // Optionally hide the login form
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Users WHERE Username = @Username AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true; // User exists
                }
                return false; // User does not exist
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
