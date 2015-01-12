using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace SabseSasta
{
    public class validation
    {
        public static bool check(string email)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from logindetails where email = '" + email + "'", conn);
            DataSet ds = new DataSet();
            conn.Open();
            oda.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void insert(string email, string pass)
        {
            //MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["msqlConnection"].ConnectionString);
            //conn.Open();
            //MySqlDataAdapter mda = new MySqlDataAdapter();
            //MySqlCommand cmd = new MySqlCommand("Insert into logindetails values('"+email+"','"+pass+"')",conn);
            //mda.InsertCommand = cmd;
            ////cmd.ExecuteNonQuery();
            //conn.Close();

            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into logindetails values('" + email + "','" + pass + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //public static void cart_insert(DataSet ds, int unit)
        //{
            
        //    OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
        //    conn.Open();
        //    int totalprice = unit * Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
        //    OleDbCommand cmd = new OleDbCommand("Insert into Cart values('" + ds.Tables[0].Rows[0][0].ToString() + "','" + ds.Tables[0].Rows[0][1].ToString() + "','" + ds.Tables[0].Rows[0][2].ToString() + "',"+ unit +","+totalprice+")", conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}

        public static void cart_insert(DataSet ds, string unit , double total)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
           conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into cart2 values('"+ds.Tables[0].Rows[0][0].ToString()+"','"+ds.Tables[0].Rows[0][1].ToString()+"','"+ds.Tables[0].Rows[0][2].ToString()+"',"+unit+","+total+")",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void cart_delete()
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete * from cart2", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void cart_update( double up ,string itemid)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update items set Availability="+up+" where itemid='"+itemid+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static bool check(string email, string pass)
        {
            //MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString);
            //MySqlDataAdapter oda = new MySqlDataAdapter("Select * from logindetails where email = '" + email + "' AND pass = '" + pass + "'", conn);
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from logindetails where email = '" + email + "' AND pass = '" + pass + "'", conn);
            DataSet ds = new DataSet();
            conn.Open();
            oda.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DataSet ProductDetails(string itemid)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from items where itemid = '" + itemid + "'", conn);
            DataSet ds = new DataSet();
            conn.Open();
            oda.Fill(ds);
            conn.Close();
            return ds;
        }

        public static DataSet CartDetails()
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["accessConnection"].ConnectionString);
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from cart2", conn);
            DataSet ds = new DataSet();
            conn.Open();
            oda.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}