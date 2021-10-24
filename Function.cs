using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   class Function
   {
      public static string gen = "";
      public static SqlConnection con;
      public static SqlCommand command;
      public static SqlDataReader reader;

      public static void fill(string q, DataGridView dgv) // gen(query), datagrid
      {
         try
         {
            Connection.DB();
            DataTable dt = new DataTable();
            SqlDataAdapter data = null;
            SqlCommand command = new SqlCommand(q, Connection.con);
            data = new SqlDataAdapter(command);
            data.Fill(dt);
            dgv.DataSource = dt;
            Connection.con.Close();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
   }
}