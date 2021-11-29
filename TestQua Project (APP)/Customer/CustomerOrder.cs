using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerOrder : Form
   {
      public static ArrayList ProductIDs = new ArrayList();
      public static ArrayList QuantityBought = new ArrayList();
      public static ArrayList ProductSold = new ArrayList();
      public static ArrayList ProductQuantity = new ArrayList();
      public static double TotalPrice = 0;
      public static string Status = "";
      public static int OrderId = 0;

      public CustomerOrder()
      {
         InitializeComponent();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var cproduct = new CustomerProduct();
         cproduct.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var caccount = new CustomerProfile();
         caccount.Show();
         Close();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var chome = new CustomerHome();
         chome.Show();
         Close();
      }

      private void CustomerOrder_Load(object sender, EventArgs e)
      {
         viewOrders();
      }

      public void viewOrders()
      {
         Connection.DB();
         Function.gen = "SELECT orderid AS [ORDER ID], userid, productid, totalprice, quantitybought, 'P' + convert(varchar, cast(TotalPrice AS MONEY), 1) AS [TOTAL PRICE], status AS [STATUS], timeoftransaction AS [TIME OF TRANSACTION] FROM OrdersDB WHERE userid = '" + Login.userid + "' ";
         Function.fill(Function.gen, dataGridView1);
         dataGridView1.Columns["productid"].Visible = false;
         dataGridView1.Columns["QuantityBought"].Visible = false;
         dataGridView1.Columns["userid"].Visible = false;
         dataGridView1.Columns["totalprice"].Visible = false;
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         TotalPrice = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["totalprice"].Value);
         Status = dataGridView1.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
         OrderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ORDER ID"].Value);

         string strProductId = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
         string[] newProductId = strProductId.Split(',');

         string strQuantity = dataGridView1.Rows[e.RowIndex].Cells["QuantityBought"].Value.ToString();
         string[] newStrQuantity = strQuantity.Split(',');

         for (int i = 0; i < newProductId.Length; i++)
         {
            ProductIDs.Add(newProductId[i]);
            QuantityBought.Add(newStrQuantity[i]);
         }

         setList();
         var vieworder = new ViewOrders();
         vieworder.Show();
         Hide();
      }

      private void setList()
      {
         for (int i = 0; i < ProductIDs.Count; i++)
         {
            Connection.DB();
            Function.gen = "SELECT * FROM Products WHERE ProductId = '" + CustomerOrder.ProductIDs[i] + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               ProductQuantity.Add(Convert.ToInt32(Function.reader["Quantity"]));
               ProductSold.Add(Convert.ToInt32(Function.reader["Sold"]));
            }
         }

         Connection.con.Close();
      }
   }
}
