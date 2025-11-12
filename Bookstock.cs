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
    public partial class Bookstock : Form
    {
        public Bookstock()
        {
            InitializeComponent();
        }

        private void btnaddbooks_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getqty = new SqlCommand("select * from Bookstock where Bookid='"+txtid.Text+"' ",connect);
            SqlDataReader dr = getqty.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                SqlCommand updatestock = new SqlCommand("update Bookstock set qty= "+txtqty.Text+ "  where Bookid='"+txtid.Text+"' ", connect);
                updatestock.ExecuteNonQuery();
                MessageBox.Show(txtid.Text + " Book is updated...");
            }
            else
            {
                MessageBox.Show("Book not available...");
            }

            connect.Close();
        }
    }
}
