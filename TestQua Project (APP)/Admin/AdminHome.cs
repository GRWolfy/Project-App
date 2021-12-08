using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
         ViewChartTopSales();
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
            Function.gen = "SELECT ProductName, Sold FROM Products";
            SqlDataAdapter data = new SqlDataAdapter(Function.gen, Connection.con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            List<string> x = new List<string>();
            List<string> y = new List<string>();

            foreach (DataRow row in dt.Rows) 
            {
               x.Add(row["ProductName"].ToString());
               y.Add(row["Sold"].ToString());
            }

            chartTopSeller.Series[0].IsValueShownAsLabel = true;
            chartTopSeller.Series[0].Points.DataBindXY(x, y);
            chartTopSeller.ChartAreas[0].AxisX.Title = "Product Name";
            chartTopSeller.ChartAreas[0].AxisY.Title = "Sold"; 
            chartTopSeller.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartTopSeller.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            Connection.con.Close();
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

      private void ViewChartTopSales()
      {
         Connection.DB();
         Function.gen = "SELECT * FROM Products";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
         {
            chartTopSeller.Series.Add(Function.reader["ProductName"].ToString());
            chartTopSeller.Series[Function.reader["ProductName"].ToString()].Points.AddXY(Function.reader["ProductName"].ToString(), Function.reader["Sold"]);
            
         }
      }
   }
}
