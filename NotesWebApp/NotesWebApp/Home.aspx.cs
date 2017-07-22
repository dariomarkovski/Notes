using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotesWebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }else
            {
                Label1.Text = "WELCOME " + Session["username"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("Login.aspx");
        }
    }
}