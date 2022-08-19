using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace selectColor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
       
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            var selItems = from ListItem li in ListBox1.Items
                           where li.Selected == true
                           select li.Text;
            foreach(var item in selItems)
            {
                Response.Write(item.ToString() + "<br/>");
            }


        }
    }

    }
