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

namespace Librarymngmntsystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";

            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            string query = "SELECT COUNT(*) FROM Users WHERE Userid = @Userid AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@Userid", txtuserid.Text);
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Login successful!", "Welcome");
                this.Hide();
                
                dashboard2 dash = new dashboard2();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserID or Password!", "Login Failed");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration Registration = new UserRegistration();
            Registration.ShowDialog();
        }
    }
}
