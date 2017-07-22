using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotesWebApp
{
    public partial class Home : System.Web.UI.Page
    {

        bool somethingChanged = false;
        string oldTitle = "";
        string oldBody = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                usernameLabel.Text = Session["username"].ToString();
                if (!IsPostBack)
                {
                    filGridView();
                }
            }
        }

        private void filGridView()
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string selectQuery = "SELECT * from Notes WHERE username=@username";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(ds, "Notes");
                gvNotes.DataSource = ds.Tables["Notes"];
                gvNotes.DataBind();
                ViewState["ds"] = ds;
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.Visible = true;
            }
            finally
            {
                con.Close();
            }

        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("Login.aspx");
        }

        protected void gvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvNotes.SelectedIndex != -1)
            {
                titleBox.Text = gvNotes.DataKeys[gvNotes.SelectedIndex].Values["Title"].ToString();
                bodyBox.Text = gvNotes.DataKeys[gvNotes.SelectedIndex].Values["Text"].ToString();
                titleBox.Visible = true;
                bodyBox.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnUnselect.Visible = true;
            }
            else
            {
                unselected();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvNotes.SelectedIndex != -1)
            {
                string id = gvNotes.SelectedRow.Cells[0].Text;
                string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                string deleteQuery = "DELETE FROM Notes WHERE NoteId=@id";
                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    filGridView();
                    gvNotes.SelectedIndex = -1;
                    unselected();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void unselected()
        {
            titleBox.Text = "";
            bodyBox.Text = "";
            titleBox.Visible = false;
            bodyBox.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnUnselect.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnUnselect_Click(object sender, EventArgs e)
        {
            gvNotes.SelectedIndex = -1;
            unselected();
        }
    }
}