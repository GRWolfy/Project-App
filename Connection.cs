using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public class Connection
   {
      public static SqlConnection con;
      private static string dbconnect = "Data Source=WOLF;Initial Catalog=OrnamentalSystem;Integrated Security=True"; //connection string 

      public static void DB()
      {
         try
         {
            con = new SqlConnection(dbconnect);
            con.Open();
         }
         catch (Exception e)
         {
            con.Close();
            MessageBox.Show(e.Message);
         }
      }
   }
}