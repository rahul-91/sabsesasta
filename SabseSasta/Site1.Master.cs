using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Web.Security;
namespace SabseSasta
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null)
            {
                Label11.Text = Request.QueryString["username"].ToString();
                LinkButton2.Visible = false;
                LinkButton1.Visible = false;
                Label12.Visible = false;
                Label11.Visible = true;
                LinkButton4.Visible = true;
            }

            Session.Abandon();
            Session.Abandon();
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.Cache.SetSlidingExpiration(true);
            Response.Cache.SetNoStore();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
          
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            ModalPopupExtender1.Show();
            ModalPopupExtender2.Hide();
            ModalPopupExtender3.Hide();
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            //ModalPopupExtender1.Hide();         
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox5.Text = "";
            ModalPopupExtender2.Show();
            ModalPopupExtender1.Hide();
                ModalPopupExtender3.Hide();
           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox4.Text = "";
            TextBox5.Text = "";
            ModalPopupExtender2.Hide();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox6.Text = "";
            TextBox7.Text = "";
            ModalPopupExtender3.Hide();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            ModalPopupExtender3.Show();
            ModalPopupExtender1.Hide();
            ModalPopupExtender2.Hide();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (!validation.check(TextBox4.Text, TextBox5.Text))
            {
                Label11.Text = TextBox4.Text;
                LinkButton2.Visible = false;
                LinkButton1.Visible = false;
                Label12.Visible = false;
                Label11.Visible = true;
                Response.Redirect("Index.aspx?username=" + TextBox4.Text);
            }
            else
            {
                TextBox4.Text = "";
                TextBox5.Text = "";
                Page.ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('Email Id & password doesnot match!!!');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!validation.check(TextBox1.Text))
            {
                validation.insert(TextBox1.Text, TextBox2.Text);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                // ModalPopupExtender1.Dispose();
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                Page.ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('Email Id already in use!!!');", true);
                // ModalPopupExtender1.Dispose();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null)
            {
                Response.Redirect("Cart.aspx?username=" + Request.QueryString["username"]);

            }
            else
            {
                Response.Redirect("Cart.aspx");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Label11.Text = "";
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton4.Visible = false;
            Response.Redirect("Index.aspx");
            validation.cart_delete();
        }
    }
}