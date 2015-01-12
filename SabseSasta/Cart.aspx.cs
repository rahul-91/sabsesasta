using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SabseSasta
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = validation.CartDetails();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null)
            {
                Response.Redirect("Index.aspx?username=" + Request.QueryString["username"]);

            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null)
            {
                Response.Redirect("Shipping.aspx?username=" + Request.QueryString["username"]);

            }
            else
            {
                Response.Redirect("Shipping.aspx");
            }
        }
    }
}