using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        string cs = "Data Source = DEL1-LHP-N82179; Initial Catalog = customerdb; Integrated Security = SSPI;";
        protected void Page_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                customerData.DataSource = dt;
                customerData.DataBind();

            }

        }
    }
}