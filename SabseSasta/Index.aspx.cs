using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SabseSasta
{
    public partial class Index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Abandon();
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.Cache.SetSlidingExpiration(true);
            Response.Cache.SetNoStore();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //TextBox9.Text = "hello";
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

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
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

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
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

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
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