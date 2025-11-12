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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clearall()
        {
            txtbookid.Clear();
            txtbookname.Clear();
            txtbooktitle.Clear();
            txtbookauthor.Clear();
            txtpages.Clear();
            radbtnborrow.Checked = false;
            radbtnref.Checked = false;
        }
        string classification;
        private void btnregister_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            if (radbtnborrow.Checked == true)
            { 
                classification = "Borrow";
            }

            if (radbtnref.Checked == true)
            {
                classification = "Reference";
            }
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand register = new SqlCommand("insert into Bookinfo values('"+txtbookid.Text+"','"+txtbookname.Text+"','"+txtbooktitle.Text+"','"+txtbookauthor.Text+"',"+txtpages.Text+",'"+classification+"')",connect); 
            register.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Book Register Sucsess.... ");
            

            connect.Open();
            SqlCommand stock = new SqlCommand("insert into Bookstock values('"+txtbookid.Text+"',"+0+")",connect);
            stock.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Book Stock Updated...");
            clearall();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            if (radbtnborrow.Checked == true)
            {
                classification = "Borrow";
            }

            if (radbtnref.Checked == true)
            {
                classification = "Reference";
            }
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand update = new SqlCommand("update Bookinfo set Name='"+txtbookname.Text+"', Title='"+txtbooktitle.Text+"', Author='"+txtbookauthor.Text+"', Pages="+txtpages.Text+", '"+classification+"' where Bookid=+txtbookid+ ",connect);
            update.ExecuteNonQuery();

            connect.Close();
            MessageBox.Show("Book Details updated...");
            clearall();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(txtbookid.Text==null || txtbookid.Text=="")
            {
                MessageBox.Show("Please enter book Id... ");
                txtbookid.Focus();
            }
            else
            {
                string dbpath;
                dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
              
                SqlConnection connect = new SqlConnection(dbpath);
                connect.Open();
                SqlCommand delete = new SqlCommand("delete from Bookinfo where Bookid='"+txtbookid.Text+"' ",connect);
                delete.ExecuteNonQuery();
                connect.Close() ;
                MessageBox.Show("Book Removed...");
            }
        }
    }
}
