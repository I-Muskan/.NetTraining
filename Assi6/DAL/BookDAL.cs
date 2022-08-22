using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class BookDAL
    {
        SqlConnection con;
        string cs = "Data Source=DEL1-LHP-N82179;Initial Catalog = BOOKDB; Integrated Security = True";
        SqlCommand cmd = new SqlCommand();

        public bool BookInsertDAL(Book bookX)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("Book_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId",bookX.BookId);
                cmd.Parameters.AddWithValue("@BookName", bookX.BookName);
                cmd.Parameters.AddWithValue("@Author", bookX.Author);
                cmd.Parameters.AddWithValue("@Publisher",bookX.Publisher);
                cmd.Parameters.AddWithValue("@Price", bookX.Price);
                con.Open();
                int fl = cmd.ExecuteNonQuery();
                con.Close();

                if (fl > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }






            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool BookUpdateDAL(Book bookX)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("UpdatedBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
              
                cmd.Parameters.AddWithValue("@BookId", bookX.BookId);
                cmd.Parameters.AddWithValue("@BookName", bookX.BookName);
                cmd.Parameters.AddWithValue("@Author", bookX.Author);
                cmd.Parameters.AddWithValue("@Publisher", bookX.Publisher);
                cmd.Parameters.AddWithValue("@Price", bookX.Price);
                con.Open();
                int fl = cmd.ExecuteNonQuery();
                con.Close();

                if (fl > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }






            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool BookDeleteDAL(Book bookX)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("DeleteBook", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", bookX.BookId);
                
                con.Open();
                int fl = cmd.ExecuteNonQuery();
                con.Close();

                if (fl > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }






            }
            catch (Exception)
            {
                return false;
            }
        }
        private int GetCountBooks()
        {
            int x = -1;
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Book", con);

                x = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (con!= null)
                {
                    con.Close();
                }
            }
            return x;
        }
        public Object BookAllDAL()
        {

            if (GetCountBooks() > 0)
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("BOOKAllRecords_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable DT = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
                return DT;
            }
            else
            {
                return null;
            }





        }
    }
}

 
