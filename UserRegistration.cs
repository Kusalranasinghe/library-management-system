using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Librarymngmntsystem
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btnusersregister_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";

            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand register = new SqlCommand("insert into Users values('"+txtuserid.Text+"', '"+txtusername.Text+"', '"+txtnic.Text+"', '"+txttelephone.Text+"', '"+txtemail.Text+"', '"+txtpassword.Text+"', '"+txtaddress.Text+"')", connect);
            register.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("User Register Sucsess.... ");
        }
    }
}
