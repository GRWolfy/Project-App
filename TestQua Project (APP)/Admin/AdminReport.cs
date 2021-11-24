using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminReport : Form
   {
      public AdminReport()
      {
         InitializeComponent();
      }

      private void AdminReport_Load(object sender, EventArgs e)
      {
         btnReports.FlatStyle = FlatStyle.Standard;
         viewOrdersDb();
         viewDelivered();
         viewReturn();
         setTotalSales();
      }

      private void setTotalSales()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT convert(varchar, cast(SUM(TotalPrice) AS MONEY), 1) AS [TOTAL] FROM OrdersDb ";
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
            lblTotalSales.Text = "P0";
         }
      }

      private void viewOrdersDb()
      {
         Connection.DB();
         Function.gen = "SELECT orderid AS [ORDER ID], userid, productid, quantitybought, 'P' + convert(varchar, cast(totalprice AS MONEY), 1) AS [TOTAL PRICE], status as [STATUS], timeoftransaction AS [TIME OF TRANSACTION] FROM OrdersDB";
         Function.fill(Function.gen, dataGridView1);
         dataGridView1.Columns["userid"].Visible = false;
         dataGridView1.Columns["productid"].Visible = false;
         dataGridView1.Columns["quantitybought"].Visible = false;
      }

      private void viewReturn()
      {
         Connection.DB();
         Function.gen = "SELECT orderid AS [ORDER ID], userid, productid, quantitybought, 'P' + convert(varchar, cast(totalprice AS MONEY), 1) AS [TOTAL PRICE], status as [STATUS], timeoftransaction AS [TIME OF TRANSACTION] FROM OrdersDB WHERE Status = '" + "Return" + "' ";
         Function.fill(Function.gen, datagridViewReturn);
         datagridViewReturn.Columns["userid"].Visible = false;
         datagridViewReturn.Columns["productid"].Visible = false;
         datagridViewReturn.Columns["quantitybought"].Visible = false;
      }

      private void viewDelivered()
      {
         Connection.DB();
         Function.gen = "SELECT orderid AS [ORDER ID], userid, productid, quantitybought, 'P' + convert(varchar, cast(totalprice AS MONEY), 1) AS [TOTAL PRICE], status as [STATUS], timeoftransaction AS [TIME OF TRANSACTION] FROM OrdersDB WHERE Status = '" + "Order Received" + "' ";
         Function.fill(Function.gen, datagridViewDelivered);
         datagridViewDelivered.Columns["userid"].Visible = false;
         datagridViewDelivered.Columns["productid"].Visible = false;
         datagridViewDelivered.Columns["quantitybought"].Visible = false;
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var home = new AdminHome();
         home.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var account = new AdminAccounts();
         account.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var product = new AdminProduct();
         product.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var logout = new Homepage();
         logout.Show();
         Close();
      }

      private void tabPage2_Click(object sender, EventArgs e)
      {

      }
   }
}
/*
   Hide userid
   Hide productid
   Hide Quantitybought
   Fix Price
   total sales labe add P
 */