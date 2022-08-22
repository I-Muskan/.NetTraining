using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AddProps;

namespace DAL
{
    class DBcon
    {
        SqlConnection con;
       public DBcon(string cs)
        {
           con = new SqlConnection(cs);

        }
        public bool checkCon(string query)
        {
           con.Open();
           SqlCommand cmd = new SqlCommand(query, con);
           bool check = cmd.ExecuteNonQuery() > 0;
           con.Close();
            return check;

        }
        public DataTable search(string query)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
            return dt;
        }
    }
}
