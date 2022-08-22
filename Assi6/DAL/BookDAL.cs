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
        string cs = "Data Source=del1-lhp-n82179;Initial Catalog = BOOKDB; Integrated Security = True";
        SqlCommand cmd = new SqlCommand();

        public bool BookInsertDAL(Book bookX)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("Book_SP", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", con);
                cmd.Parameters.AddWithValue("@BookName", con);
                cmd.Parameters.AddWithValue("@Author", con);
                cmd.Parameters.AddWithValue("@Publisher", con);
                cmd.Parameters.AddWithValue("@Price", con);
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
                cmd = new SqlCommand("UpdateBook", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", con);
                cmd.Parameters.AddWithValue("@BookName", con);
                cmd.Parameters.AddWithValue("@Author", con);
                cmd.Parameters.AddWithValue("@Publisher", con);
                cmd.Parameters.AddWithValue("@Price", con);
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
                cmd.Parameters.AddWithValue("@BookId", con);
                cmd.Parameters.AddWithValue("@BookName", con);
                cmd.Parameters.AddWithValue("@Author", con);
                cmd.Parameters.AddWithValue("@Publisher", con);
                cmd.Parameters.AddWithValue("@Price", con);
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

        public DataSet BookAllDAL(Book bookX)
        {

            con = new SqlConnection(cs);
            cmd = new SqlCommand("BOOKAllRecords_SP", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();

            return ds;





        }
    }
}

 
