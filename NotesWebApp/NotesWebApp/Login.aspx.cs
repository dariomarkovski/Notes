using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotesWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passTextBox.Text;
            string selectQuery = "SELECT * FROM Users WHERE username=@username AND password=@password";
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    errorLabel.Text = "WELCOME TO THE ALALALAL!";
                    errorLabel.Visible = true;
                    reader.Read();
                    Session["username"] = reader.GetValue(1).ToString();
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    errorLabel.Text = "Incorrect username/password";
                    errorLabel.Visible = true;
                }
            }catch(Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}