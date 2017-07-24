using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NoteService
{
    /// <summary>
    /// Summary description for NoteService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NoteService : System.Web.Services.WebService
    {

        [WebMethod]
        public bool InsertNote(string username, string title, string text)
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string insertQuery = "INSERT INTO Notes (Username, Title, Text) VALUES (@Username, @Title, @Text)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Text", text);
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

        [WebMethod]
        public bool UpdateNote(String title, String text, String NoteID)
        {
            string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string insertQuery = "UPDATE Notes SET Title=@Title,Text=@Text Where NoteID=@NoteID";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Text", text);
            cmd.Parameters.AddWithValue("@NoteID", NoteID);
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

