using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source = DEL1-LHP-N82179; Initial Catalog = customerdb; Integrated Security = SSPI;");


            



            con.Open();
            string insertString = $"Insert into Customers values('{customerId.Text}','{customerName.Text}','{address.Text}','{phoneNo.Text}','{mailId.Text}')";

            SqlCommand cmd = new SqlCommand(insertString, con);

            cmd.ExecuteNonQuery();
            Response.Redirect("WebForm2.aspx");
            con.Close();

        }

        
    }
}