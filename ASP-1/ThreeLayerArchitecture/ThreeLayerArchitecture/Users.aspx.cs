using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace ThreeLayerArchitecture
{
    public partial class Users : System.Web.UI.Page;
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 objBll = new Class1();
            //for insert crowd
            objBll.InsertNewUser(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            //Response.Redirect("Users.aspx");
            //for select record and bind to gridview
            GridView1.DataSource = objBll.SelectUser();
            GridView1.DataBind();
        }

    }
}