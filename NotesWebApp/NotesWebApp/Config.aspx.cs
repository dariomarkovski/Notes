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
    public partial class Config : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                usernameLabel.Text = Session["username"].ToString();
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("Login.aspx");
        }

        protected void configButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            if (checkCurrPw(currPwTb.Text))
            {
                currPwError.Text = "";
                if (matchingNewPw(newPwTb.Text, confirmNewPwTb.Text)) 
                {
                    newPwMatchError.Text = "";
                    if (changePw(newPwTb.Text))
                    {
                        pwChangeLabel.Text = "Password changed succesfully!";
                        currPwTb.Text = "";
                        newPwTb.Text = "";
                        confirmNewPwTb.Text = "";
                    }
                    else
                    {
                        pwChangeLabel.Text = "Password wasn't changed!";
                    }
                }
                else
                {
                    newPwMatchError.Text = "New password doesn't match!";
                }
            }
            else
            {
                currPwError.Text = "This is not your current password!";
            }
        }

        protected bool checkCurrPw(string guess)
        {
            string username = Session["username"].ToString();
            string password = "";
            string selectQuery = "SELECT * FROM Users WHERE username=@username";
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    password = reader["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                // username not found
                return false;
            }
            finally
            {
                con.Close();
            }

            if (guess.Trim().Equals(password.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool matchingNewPw(string newPw, string confirmedPw)
        {
            if (newPw.Trim().Equals(confirmedPw.Trim()))
                return true;
            else
                return false;
        }

        protected bool changePw(string newPassword)
        {
            string username = Session["username"].ToString();
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string updateQuery = "UPDATE Users SET password=@password WHERE username=@username";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@username", username);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

    }
}