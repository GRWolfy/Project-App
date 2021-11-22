using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminHome : Form
   {
      public AdminHome()
      {
         InitializeComponent();
      }

      private void AdminHome_Load(object sender, EventArgs e)
      {
         btnHome.FlatStyle = FlatStyle.Standard;
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var adminaccounts = new AdminAccounts();
         adminaccounts.Show();
         Hide();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         Close();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {

      }

      private void btnReport_Click(object sender, EventArgs e)
      {
         var adminreport = new AdminReport();
         adminreport.Show();
         Close();
      }

      public void updateProductStatus()
      {
         int productid;

         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM Products";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.Read())
            {
               productid = Convert.ToInt32(Function.reader["ProductId"]);   

               if (Convert.ToInt32(Function.reader["quantity"]) <= 20  && Function.reader["STATUS"].ToString() != "NEED RESTOCK")
               {
                  Connection.DB();
                  Function.gen = "UPDATE Products SET Status = '" + "STOCK LOW" + "' WHERE ProductId = '" + productid + "' ";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  Connection.con.Close();
               }
            }
         }

         catch (Exception ex)
         { 
         
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {

      }

      private void btnReports_Click(object sender, EventArgs e)
      {
         var adminreports = new AdminReport();
         adminreports.Show();
         Close();
      }
   }
}
