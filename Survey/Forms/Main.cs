using Survey.Forms;
using Survey.Lib;
using Survey.Views;
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
        Factory factory = new Factory();
        Helper helper = new Helper();
        private string loggedInUser;
        private bool isAdmin;
        public Main()
        {
            InitializeComponent();
        }
        private void btn_toTestMng_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Pieeja liegta. Nepietiekamas tiesības.");
                return;
            }
            TestManagement testManagement = new TestManagement(this, loggedInUser, isAdmin);
            testManagement.Show();
            testManagement.Location = this.Location;
            testManagement.Size = this.Size;
            this.Hide();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text.Trim();
            string password = txt_password.Text;
            Person person = factory.Login(username, password);
            if (person == null)
            {
                MessageBox.Show("Nepareizs lietotājvārds vai parole.");
                return;
            }
            loggedInUser = person.Username;
            isAdmin = person.IsAdmin;
            factory.UpdateLastLogin(person);
            pn_Login.Visible = false;
            flowLayoutPanel1.Visible = true;
            btn_MyTests.Visible = true;
            if (isAdmin)
            {
                btn_toTestMng.Visible = true;
                btn_ToUsers.Visible = true;
            }
            else
            {
                btn_toTestMng.Visible = false;
                btn_ToUsers.Visible = false;
            }
            Text = $"Survey - {loggedInUser}";
            helper.ClearForm(Controls);
            btn_logOut.Visible = true;


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

        private void LoadComboGroup()
        {
            cb_GroupName.DataSource = factory.GetGroupNames();
            cb_GroupName.DisplayMember = "GroupName1";
            cb_GroupName.ValueMember = "GroupName1";
            cb_GroupName.SelectedIndex = 0;
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            LoadComboGroup();
            
            
            pn_Login.Visible = false;
            pnl_Register.Visible = true;
        }

        private void lbl_LogIn_Click(object sender, EventArgs e)
        {
            pnl_Register.Visible = false;
            pn_Login.Visible = true;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string confirmPassword = txt_confirmPass.Text;
            PersonReg personReg = new PersonReg
            {
                Name = txt_Name.Text.Trim(),
                Surname = txt_Surname.Text.Trim(),
                GroupName = cb_GroupName.SelectedValue.ToString(),
                Username = txt_userN.Text.Trim(),
                Email = txt_email.Text.Trim(),
                Password = txt_NewPassword.Text.Trim()
            };
            if (personReg.Password != confirmPassword)
            {
                MessageBox.Show("Paroles nesakrīt!");
                return;
            }
            bool registrationResult = factory.RegisterPerson(personReg);
            if (registrationResult)
            {
                MessageBox.Show("Reģistrācija veiksmīga!");
                pnl_Register.Visible = false;
                pn_Login.Visible = true;
            }
            else
            {
                MessageBox.Show("Reģistrācija neizdevās! Iespējams, ka lietotājvārds vai e-pasts jau eksistē.");
            }

        }

        private void lbl_forgotPass_Click(object sender, EventArgs e)
        {
            pnl_ForgotPass.Visible = true;
            pn_Login.Visible = false;

        }

        private void btn_ToUsers_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Pieeja liegta. Nepietiekamas tiesības.");
                return;
            }
            UserManagement userManagement = new UserManagement(this, loggedInUser, isAdmin);
            userManagement.Show();
            userManagement.Location = this.Location;
            userManagement.Size = this.Size;
            this.Hide();

        }

        private void btn_ConfirmPass_Click(object sender, EventArgs e)
        {
            string email = txt_resetMail.Text.Trim();
            string confirmPassword = txt_confirmReset.Text;
            if (string.IsNullOrWhiteSpace(txt_resetMail.Text))
            {
                MessageBox.Show("Lūdzu, ievadiet e-pasta adresi.");
                return;
            }
            string newPassword = txt_resetPass.Text.Trim();
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Paroles nesakrīt!");
                return;
            }
            bool resetResult = factory.UpdatePassword(email, newPassword);
            if (resetResult)
            {
                MessageBox.Show("Parole veiksmīgi atjaunota!");
                pnl_ForgotPass.Visible = false;
                pn_Login.Visible = true;
            }
            else
            {
                MessageBox.Show("Paroles atjaunošana neizdevās. Lūdzu, mēģiniet vēlreiz.");
            }
        }
    }
}
