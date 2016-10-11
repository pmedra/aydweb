using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAYD
{
    public partial class Default : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        String queryStr;
        String name;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "Select * from Usuario where Nombre=@Usuario and Password=MD5(@Pass) limit 1";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("Usuario", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("Pass", passwordTextBox.Text);
            name = "";
            reader = cmd.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("Nombre"));
            }
            if (reader.HasRows)
            {
                Session["uname"] = name;
                Response.BufferOutput = true;
                Response.Redirect("Principal.aspx", false);

            }
            else
            {
                passwordTextBox.Text = "usuario invalido";
            }

        }
    }
}