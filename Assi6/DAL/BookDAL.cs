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
        private int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Book", con);

                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (con!= null)
                {
                    con.Close();
                }
            }
            return count;
        }
        public DataTable BookAllDAL(Book bookX)
        {

            if (GetNumberOfRecords() > 0)
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

 
