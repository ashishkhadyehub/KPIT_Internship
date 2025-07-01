using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.Sessions
{
    public partial class Register : System.Web.UI.Page
    {

        //1.Create UI form with asp.net tags
        //2.Create table in database
        //3.Apply  validations to UI form
        //4.Setup connectionstring in web.config
        //5.Create object of connection class in back end file
        //6.Write ado.net code to insert data into database

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into Users values (@name,@contact,@email,@city)",con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCity.SelectedItem.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            ddlCity.SelectedIndex = 0;

            Response.Write("<script>alert('Registered Successfully..!')</script>");

        }
    }
}