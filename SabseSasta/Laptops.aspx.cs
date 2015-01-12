using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SabseSasta
{
    public partial class Laptops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton mybutton = (ImageButton)sender;
            if (Request.QueryString["username"] != null)
            {
                Response.Redirect("Order.aspx?username=" + Request.QueryString["username"] + "&itemid=" + mybutton.ID);

            }
            else
            {
                Response.Redirect("Order.aspx?itemid=" + mybutton.ID);
            }
        }
    }
}