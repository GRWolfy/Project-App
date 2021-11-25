using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminHome : Form
   {
      private double totalsales;
      private double totalexpenses;

      public AdminHome()
      {
         InitializeComponent();
      }

      private void AdminHome_Load(object sender, EventArgs e)
      {
         btnHome.FlatStyle = FlatStyle.Standard;
         setTotalSales();
         setTotalExpenses();
         setTotalProfit();
         updateProductStatus();
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

               if (Convert.ToInt32(Function.reader["quantity"]) <= 20 && Function.reader["STATUS"].ToString() != "REQUESTING")
               {
                  Connection.DB();
                  Function.gen = "UPDATE Products SET Status = '" + "STOCK LOW" + "' WHERE ProductId = '" + productid + "' ";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  Connection.con.Close();
               }
               else if (Function.reader["STATUS"].ToString() != "REQUESTING")
               {
                  Connection.DB();
                  Function.gen = "UPDATE Products SET Status = '" + "" + "' WHERE ProductId = '" + productid + "' ";
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

      private void setTotalExpenses()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT convert(varchar, cast(SUM(TotalPrice) AS MONEY), 1) AS [TOTAL] FROM OrdersDb WHERE Status = 'RECEIVED' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotalSales.Text = "₱" + Function.reader["TOTAL"].ToString();
               totalexpenses = Convert.ToDouble(Function.reader["TOTAL"]);
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotalSales.Text = "₱0";
         }
      }

      private void setTotalSales()
      {
         try
         {
            Connection.DB();
            Function.gen = "select convert(varchar, cast(SUM(TotalPrice) AS MONEY), 1) as TOTAL from Transactions where status = 'RECEIVED' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotalExpenses.Text = "₱" + Function.reader["TOTAL"].ToString();
               totalsales = Convert.ToDouble(Function.reader["TOTAL"]);
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotalExpenses.Text = "₱0";
         }
      }

      private void setTotalProfit()
      {
         decimal totalprofit = Convert.ToDecimal(totalsales - totalexpenses);
         string money = String.Format("{0:N}", totalprofit);
         lblTotalProfit.Text = "₱" + money;
      }

      private void label6_Click(object sender, EventArgs e)
      {

      }
   }
}
