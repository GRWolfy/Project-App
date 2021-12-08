using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewOrders : Form
   {
      private string Status = CustomerOrder.Status;
      private int MAX_COUNT = CustomerOrder.ProductIDs.Count;
      private int newQuantity;
      private int newSold;
      private int productid;

      public ViewOrders()
      {
         InitializeComponent();
      }

      private void ViewOrders_Load(object sender, EventArgs e)
      {
         //setList();
         setOrderInfo();
         txtStatus.Text = Status;
         setButtonVisibility();
      }

      private void setButtonVisibility()
      {
         if (CustomerOrder.Status == "SHIPPED OUT")
         {
            btnOrderReceived.Visible = true;
            btnReturn.Visible = true;
         }
         else
         {
            btnOrderReceived.Visible = false;
            btnReturn.Visible = false;
         }
      }

      private void setOrderInfo()
      {
         try
         {
            for (int i = 0; i < MAX_COUNT; i++)
            {
               Connection.DB();
               Function.gen = "SELECT productid, productname, productdescrip, productprice, productimage, quantity, timestored FROM Products WHERE productid = '" + CustomerOrder.ProductIDs[i] + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.reader = Function.command.ExecuteReader();

               if (Function.reader.HasRows)
               {
                  Function.reader.Read();
                  dataGridViewOrder.Rows.Add(dataGridViewOrder.Rows.Count - 1 + 1, Function.reader["ProductName"].ToString(), CustomerOrder.QuantityBought[i], "P" + (Convert.ToDouble(Function.reader["productprice"]) * Convert.ToDouble(CustomerOrder.QuantityBought[i])).ToString() + ".00");
               }
            }

            dataGridViewOrder.Rows.Add(" ", "Delivery Fee", "", "P80.00");
            dataGridViewOrder.Rows.Add(" ", " ", " ", "P" + CustomerOrder.TotalPrice.ToString() + ".00");
            dataGridViewOrder.AllowUserToAddRows = false;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var customerorder = new CustomerOrder();
         customerorder.Show();
         Close();
      }

      private void btnOrderReceived_Click(object sender, EventArgs e)
      {
         updateStatus("RECEIVED");
      }

      private void btnReturn_Click(object sender, EventArgs e)
      {
         //returnProduct();
         updateStatus("RETURN");
      }

      private void returnProduct()
      {
         for (int i = 0; i < MAX_COUNT; i++)
         {
            newQuantity = Convert.ToInt32(CustomerOrder.QuantityBought[i]) + Convert.ToInt32(CustomerOrder.ProductQuantity[i]);
            newSold = Convert.ToInt32(CustomerOrder.ProductSold[i]) - Convert.ToInt32(CustomerOrder.QuantityBought[i]);
            productid = Convert.ToInt32(CustomerOrder.ProductIDs[i]);

            Connection.DB();
            Function.gen = "UPDATE Products SET Quantity =  '" + newQuantity + "', Sold = '" + newSold + "' WHERE productid = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();
         }
      }
       
      private void updateStatus(string status)
      {
         try
         {
            var gen = MessageBox.Show("Are you sure you want to update the status of this order?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE OrdersDb SET status = '" + status + "' WHERE OrderId = '" + CustomerOrder.OrderId + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
