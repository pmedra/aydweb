using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace AplicacionWebAYD
{
    public partial class Principal : System.Web.UI.Page
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            name = (String)(Session["uname"]);
            if (name==null)
            {
                Response.BufferOutput = true;
                Response.Redirect("Default.aspx", false);
            }
            userlabel.Text = name;

            MySqlConnection conn = new MySqlConnection(MyConString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tablename;", conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);


            GridVIew.DataSource = dataTable;
            GridVIew.DataBind();


        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx", false);
        }
    }
}