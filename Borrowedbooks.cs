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
    public partial class Borrowedbooks : Form
    {
        public Borrowedbooks()
        {
            InitializeComponent();
        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            string dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True";
            SqlConnection connect = new SqlConnection(dbpath);
            connect.Open();

            
            SqlCommand checkBook = new SqlCommand("SELECT qty FROM BookStock WHERE Bookid = @Bookid", connect);
            checkBook.Parameters.AddWithValue("@Bookid", txtbookid.Text);
            object result = checkBook.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show("Book ID not found in stock!");
                connect.Close();
                return;
            }

            int qty = Convert.ToInt32(result);
            if (qty <= 0)
            {
                MessageBox.Show("Sorry, this book is currently out of stock!");
                connect.Close();
                return;
            }

            
            SqlCommand insertBorrow = new SqlCommand(
                "INSERT INTO BorrowedBooks (Userid, Bookid, BorrowDate, DueDate) VALUES (@Userid, @Bookid, @BorrowDate, @DueDate)",
                connect);
            insertBorrow.Parameters.AddWithValue("@Bookid", txtbookid.Text);
            insertBorrow.Parameters.AddWithValue("@Userid", txtuserid.Text);
            insertBorrow.Parameters.AddWithValue("@BorrowDate", txtborrowdate.Text);
            insertBorrow.Parameters.AddWithValue("@DueDate", txtduedate.Text);
            insertBorrow.ExecuteNonQuery();

            
            SqlCommand updateStock = new SqlCommand("UPDATE BookStock SET qty = qty - 1 WHERE BookID = @BookID", connect);
            updateStock.Parameters.AddWithValue("@Bookid", txtbookid.Text);
            updateStock.ExecuteNonQuery();

            MessageBox.Show("Book borrowed successfully!");
            connect.Close();

            
            txtbookid.Clear();
            txtuserid.Clear();
        }
    }
}
