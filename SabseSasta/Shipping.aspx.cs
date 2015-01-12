using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace SabseSasta
{
    public partial class Shipping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null)
            {
                TextBox9.Text = Request.QueryString["username"].ToString();
            }

            DataSet ds = validation.CartDetails();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            object sumobj = ds.Tables[0].Compute("Sum(Total)", "");
            Label16.Text += sumobj.ToString();


        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //Response.Write("hello");
            string email = TextBox9.Text + " " + TextBox10.Text + " " + TextBox11.Text + Label16.Text;
            DataSet ds = validation.CartDetails();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                DataSet ds1 = validation.ProductDetails(ds.Tables[0].Rows[i][0].ToString());
                double avail = Convert.ToDouble(ds1.Tables[0].Rows[0][3].ToString());
                double unit = Convert.ToDouble(ds.Tables[0].Rows[i][3].ToString());
                double update = avail - unit;
                validation.cart_update(update, ds.Tables[0].Rows[i][0].ToString());
            }
            validation.cart_delete();

         //   SendMail.response(TextBox9.Text, email);

            
            Response.Redirect("Index.aspx");
            

            
            //OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            
            //OleDbCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "Delete * from cart2";
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            Response.Redirect("Index.aspx");
            //SendMail.response(email, TextBox9.Text);
        }
    }
}