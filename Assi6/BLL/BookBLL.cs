using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using App;
using System.Data;

namespace BLL
{
    public class BookBLL
    {
        BookDAL bookDALobj = new BookDAL();
        public bool BookInsertBLL(Book bookX)
        {
            return bookDALobj.BookInsertDAL(bookX);
        }
        public bool BookUpdateBLL(Book bookX)
        {
            return bookDALobj.BookUpdateDAL(bookX);
        }
        public bool BookDeleteBLL(Book bookX)
        {
            return bookDALobj.BookDeleteDAL(bookX);
        }
       
        public DataTable BookReadBLL(Book bookX)
        {
            return bookDALobj.BookAllDAL(bookX);
        }
    }
}
