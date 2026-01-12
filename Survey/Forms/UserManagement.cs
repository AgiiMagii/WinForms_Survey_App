using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Forms
{
    public partial class UserManagement : Form
    {
        private readonly Main _main;
        private string _loggedInUser;
        private bool _isAdmin;
        public UserManagement(Main main, string loggedInUser, bool isAdmin)
        {
            InitializeComponent();
            _main = main;
            _loggedInUser = loggedInUser;
            _isAdmin = isAdmin;
            Text = $"User Management - {_loggedInUser}";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _main.Location = this.Location;
            _main.Size = this.Size;
            _main.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            _main.LogOut();
            _main.Location = this.Location;
            _main.Size = this.Size;
            _main.Show();
            this.Close();
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_main.Visible)
                Application.Exit();
        }
    }
}
