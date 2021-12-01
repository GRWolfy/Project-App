using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Supplier
{
   public partial class SupplierHome : Form
   {
      public SupplierHome()
      {
         InitializeComponent();
      }

      private void SupplierHome_Load(object sender, EventArgs e)
      {
         btnHome.FlatStyle = FlatStyle.Standard;
         setTotalDeliveries();
         setTotalSales();
         ViewChartTopSales();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Close();
      }

      private void btnProfile_Click(object sender, EventArgs e)
      {
         var supplierprofile = new SupplierProfile();
         supplierprofile.Show();
         Close();
      }

      private void btnTransactions_Click(object sender, EventArgs e)
      {
         var transac = new SupplierTransactions();
         transac.Show();
         Close();
      }

      private void btnProduct_Click(object sender, EventArgs e)
      {
         var supplierproduct = new SupplierProduct();
         supplierproduct.Show();
         Close();
      }

      private void setTotalSales()
      {
         try
         {
            Connection.DB();
            Function.gen = "select convert(varchar, cast(SUM(TotalPrice) AS MONEY), 1) AS [TOTAL] from transactions where userid = '"+ Login.userid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotalSales.Text = "₱" + Function.reader["TOTAL"].ToString();
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotalSales.Text = "₱0";
         }
      }

      private void setTotalDeliveries()
      {
         try
         {
            Connection.DB();
            Function.gen = "select count(*) as [TOTAL] from transactions where userid = '"+ Login.userid +"' and status like 'RECEIVED%' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotalDeliveries.Text = Function.reader["TOTAL"].ToString();
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotalDeliveries.Text = "0";
         }
      }

      private void ViewChartTopSales()
      {
         Connection.DB();
         Function.gen = "select Products.ProductName as [NAME], Transactions.Quantity as [QTY] from transactions inner join products on transactions.ProductId = Products.ProductId where userid = '"+ Login.userid +"' ";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
         {
            chartTopSeller.Series.Add(Function.reader["NAME"].ToString());
            chartTopSeller.Series[Function.reader["NAME"].ToString()].Points.AddXY(Function.reader["NAME"].ToString(), Function.reader["QTY"]);

         }
      }
   }
}
