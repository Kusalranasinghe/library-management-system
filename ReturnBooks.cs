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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string dbpath = "Data Source=DESKTOP-DMFTP74\\SQLEXPRESS;Initial Catalog=lms3;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(dbpath))
            {
                connect.Open();

                
                SqlCommand checkBorrow = new SqlCommand(
                    "SELECT * FROM BorrowedBooks WHERE BookID = @BookID AND UserID = @UserID",
                    connect
                );
                checkBorrow.Parameters.AddWithValue("@BookID", txtBookID.Text);
                checkBorrow.Parameters.AddWithValue("@UserID", txtUserID.Text);

                SqlDataReader dr = checkBorrow.ExecuteReader();

                if (dr.Read())
                {
                    int borrowID = Convert.ToInt32(dr["BorrowID"]);
                    dr.Close();

                 
                    SqlCommand insertReturn = new SqlCommand(
                        "INSERT INTO ReturnedBooks (BorrowID, BookID, UserID, ReturnDate) VALUES (@BorrowID, @BookID, @UserID, @ReturnDate)",
                        connect
                    );
                    insertReturn.Parameters.AddWithValue("@BorrowID", borrowID);
                    insertReturn.Parameters.AddWithValue("@BookID", txtBookID.Text);
                    insertReturn.Parameters.AddWithValue("@UserID", txtUserID.Text);
                    insertReturn.Parameters.AddWithValue("@ReturnDate", dateTimePickerReturn.Value);

                    insertReturn.ExecuteNonQuery();

                 
                    SqlCommand updateStock = new SqlCommand(
                        "UPDATE Bookstock SET qty = qty + 1 WHERE Bookid = @Bookid",
                        connect
                    );
                    updateStock.Parameters.AddWithValue("@Bookid", txtBookID.Text);
                    updateStock.ExecuteNonQuery();

                  
                    SqlCommand deleteBorrow = new SqlCommand(
                        "DELETE FROM BorrowedBooks WHERE BorrowID = @BorrowID",
                        connect
                    );
                    deleteBorrow.Parameters.AddWithValue("@BorrowID", borrowID);
                    deleteBorrow.ExecuteNonQuery();

                    MessageBox.Show("Book Returned Successfully! Stock Updated.");
                }
                else
                {
                    MessageBox.Show("No matching borrowed record found for this User and Book.");
                    dr.Close();
                }

                connect.Close();
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
