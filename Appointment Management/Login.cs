using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Appointment_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=G7Wst2024;User ID=G7Wst2024;Password=621id");

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username, userpassword;

            username = usernameTextBox.Text;
            userpassword = passwordTextBox.Text;

            try
            {
                string query = "SELECT * FROM Login WHERE Username = '" + usernameTextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = usernameTextBox.Text;
                    userpassword = passwordTextBox.Text;                    

                    MDIParent menuform = new MDIParent();
                    menuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    usernameTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void pracButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
