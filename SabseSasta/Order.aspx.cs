using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AjaxControlToolkit;

namespace SabseSasta
{
    public partial class Order : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
             DataSet ds = validation.ProductDetails(Request.QueryString["itemid"]);
            Image2.ImageUrl = ds.Tables[0].Rows[0][5].ToString();
            Image3.ImageUrl = ds.Tables[0].Rows[0][4].ToString();
            if (Convert.ToDouble(ds.Tables[0].Rows[0][3].ToString()) > 0)
            {
                Label14.Text = "Available" + ds.Tables[0].Rows[0][3].ToString();
                Label14.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label14.Text = "Not Available";
                Label14.ForeColor = System.Drawing.Color.Red;
                Button9.Enabled = false;

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            DataSet ds = validation.ProductDetails(Request.QueryString["itemid"]);
            double total = Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString());
            validation.cart_insert(ds, TextBox9.Text,total);
            if (Request.QueryString["username"] != null)
            {
                Response.Redirect("Cart.aspx?username=" + Request.QueryString["username"]);

            }
            else
            {
                Response.Redirect("Cart.aspx?itemid=" + Request.QueryString["itemid"]);
            }
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

  
    }
}