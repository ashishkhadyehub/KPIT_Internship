using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.Sessions
{
    public partial class S2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Text = Session["Name"].ToString();
            txtContact.Text = Session["Contact"].ToString();
        }
    }
}