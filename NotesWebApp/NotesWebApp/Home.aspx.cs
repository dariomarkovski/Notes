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
            NoteService.NoteServiceSoapClient noteServiceClient = new NoteService.NoteServiceSoapClient();
            DataSet ds = noteServiceClient.FillData(Session["username"].ToString());
            gvNotes.DataSource = ds.Tables["Notes"];
            gvNotes.DataBind();
            ViewState["ds"] = ds;
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
                titleBox.Visible = bodyBox.Visible = btnDelete.Visible = btnUpdate.Visible = btnUnselect.Visible = true;
                newNoteBtn.Visible = cancelBtn.Visible = addBtn.Visible = false;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvNotes.SelectedIndex != -1)
            {
                string id = gvNotes.DataKeys[gvNotes.SelectedIndex].Values["NoteId"].ToString();
                NoteService.NoteServiceSoapClient noteServiceClient = new NoteService.NoteServiceSoapClient();
                if (noteServiceClient.DeleteNote(id.Trim()))
                {
                    filGridView();
                    gvNotes.SelectedIndex = -1;
                    unselected();
                }
            }
        }

        private void unselected()
        {
            titleBox.Text = bodyBox.Text = "";
            titleBox.Visible = bodyBox.Visible = btnDelete.Visible = btnUpdate.Visible = btnUnselect.Visible = cancelBtn.Visible = addBtn.Visible = false;
            newNoteBtn.Visible = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvNotes.SelectedIndex != -1)
            {
                string title = titleBox.Text;
                string text = bodyBox.Text;
                string id = gvNotes.DataKeys[gvNotes.SelectedIndex].Values["NoteId"].ToString();
                NoteService.NoteServiceSoapClient noteServiceClient = new NoteService.NoteServiceSoapClient();
                if (noteServiceClient.UpdateNote(title.Trim(), text.Trim(), id.Trim()))
                {
                    filGridView();
                }
            }
           
        }

        protected void btnUnselect_Click(object sender, EventArgs e)
        {
            gvNotes.SelectedIndex = -1;
            unselected();
        }

        protected void newNoteBtn_Click(object sender, EventArgs e)
        {
            bodyBox.Visible = titleBox.Visible = cancelBtn.Visible = addBtn.Visible = true;
            newNoteBtn.Visible = false;
        }

        protected void cancelBtn_Click(object sender, EventArgs e)
        {
            unselected();
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Trim() != "" && bodyBox.Text.Trim() != "")
            {
                NoteService.NoteServiceSoapClient noteServiceClient = new NoteService.NoteServiceSoapClient();
                if (noteServiceClient.InsertNote(Session["username"].ToString(), titleBox.Text.Trim(), bodyBox.Text.Trim()))
                {
                    filGridView();
                    gvNotes.SelectedIndex = -1;
                    unselected();
                }
            }
        }

        protected void configButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Config.aspx");
        }
    }
}