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
    public partial class dashboard2 : Form
    {
        public dashboard2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (Bookid) from Bookinfo",connect);
            int count=Convert.ToInt32 (getcount.ExecuteScalar());
            lblbookcount.Text = count.ToString();

            connect.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (Bookid) from Bookinfo where Classi='Borrow'", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblborrowcount.Text = count.ToString();

            connect.Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            ff1.ShowDialog();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookstock stock = new Bookstock();
            stock.ShowDialog();
            
        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowedbooks book = new Borrowedbooks();
            book.ShowDialog();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks book = new ReturnBooks();   
            book.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (Bookid) from Bookinfo where Classi='Reference'", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblReferencecount.Text = count.ToString();

            connect.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            string dbpath;
            dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True ";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();
            SqlCommand getcount = new SqlCommand("select count (Userid) from Users ", connect);
            int count = Convert.ToInt32(getcount.ExecuteScalar());
            lblmembers.Text = count.ToString();
        }
    }
}
