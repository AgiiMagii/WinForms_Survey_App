using Survey.Forms;
using Survey.Lib;
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

namespace Survey
{
    public partial class Main : Form
    {
        Helper helper = new Helper();
        private string loggedInUser;
        private bool isAdmin;
        public Main()
        {
            InitializeComponent();
        }
        private void btn_toTestMng_Click(object sender, EventArgs e)
        {
            TestManagement testManagement = new TestManagement(this, loggedInUser, isAdmin);
            testManagement.Show();
            testManagement.Location = this.Location;
            testManagement.Size = this.Size;
            this.Hide();
        }
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Survey;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IsAdmin FROM Person WHERE UserName=@UserName AND Password=@Password";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", txt_userName.Text);
                command.Parameters.AddWithValue("@Password", txt_password.Text);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    loggedInUser = txt_userName.Text;
                    isAdmin = Convert.ToBoolean(result);

                    pn_Login.Visible = false;
                    flowLayoutPanel1.Visible = true;

                    if (isAdmin)
                    {
                        btn_toTestMng.Visible = true;
                        btn_MyTests.Visible = true;
                    }
                    else
                    {
                        btn_MyTests.Visible = true;
                    }
                    Text = $"Survey - {loggedInUser}";
                    helper.ClearForm(Controls);
                    btn_logOut.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
        public void LogOut()
        {
            loggedInUser = string.Empty;
            isAdmin = false;
            pn_Login.Visible = true;
            btn_toTestMng.Visible = false;
            btn_MyTests.Visible = false;
            btn_logOut.Visible = false;
            flowLayoutPanel1.Visible = false;
            this.Text = "Survey";
        }
        private void btn_logOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
