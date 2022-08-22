using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;
using App;
using System.Data;

namespace Web6
{
    public partial class BookForm : System.Web.UI.Page
    {
        BookBLL bookBLLObj = new BookBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int BookId = int.Parse(txtBookId.Text);
            string BookName = txtBookName.Text;
            string Author = txtAuthor.Text;
            string Publisher = txtPublisher.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            Book bookX = new Book(BookId, BookName, Author, Publisher, Price);
            if (bookBLLObj.BookUpdateBLL(bookX))
            {
                Response.Write("Book Updated Successfully");
            }
            else
            {
                Response.Write("Some Error Occured While Updating Book");
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int BookId = int.Parse(txtBookId.Text);
            string BookName = txtBookName.Text;
            string Author = txtAuthor.Text;
            string Publisher = txtPublisher.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            Book bookX = new Book(BookId, BookName, Author, Publisher, Price);
            if (bookBLLObj.BookDeleteBLL(bookX))
            {
                Response.Write("Book deleted Successfully");
            }
            else
            {
                Response.Write("Some Error Occured While deleting Book");
            }

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            int BookId = int.Parse(txtBookId.Text);
            string BookName = txtBookName.Text;
            string Author = txtAuthor.Text;
            string Publisher = txtPublisher.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            Book bookX = new Book(BookId, BookName, Author, Publisher, Price);

            DataTable ds = bookBLLObj.BookReadBLL(bookX);
            foreach (DataRow dr in ds.Rows)
            {
                foreach (var item in dr)
                {

                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

    


        protected void btnInsert_Click(object sender, EventArgs e)
        {

            int BookId = int.Parse(txtBookId.Text);
            string BookName = txtBookName.Text;
            string Author = txtAuthor.Text;
            string Publisher = txtPublisher.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            Book bookX = new Book(BookId, BookName, Author, Publisher, Price);
            if(bookBLLObj.BookInsertBLL(bookX))
             {
                Response.Write("Book Added Successfully");
            }
            else
            {
                Response.Write("Some Error Occured While Adding Book");
            }



        }
    }
}