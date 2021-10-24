using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewCart : Form
   {
      private double price = 0;
      private int productid  = 0;
      private int setMax = 0;
      private int previousQuantity = 0;
      private int newQuantity = 0;
      public ViewCart()
      {
         InitializeComponent();
      }

      private void ViewCart_Load(object sender, EventArgs e)
      {
         viewCart();
         setTotalPrice();
         fieldControl(false);
      }

      private void setNumericUpandDown()
      {
         numericUpDown_Quantity.Minimum = 1;
         numericUpDown_Quantity.Maximum = setMax;
      }

      private void viewCart()
      {
         Connection.DB();
         Function.gen = "SELECT * from CartDb INNER JOIN ProductInformation ON CartDB.productid = ProductInformation.productid  WHERE userid = '"+ Login.userid +"' ";
         Function.fill(Function.gen, datagridViewCart);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         var customercheckout = new CustomerCheckout();
         customercheckout.Show();
         Close();
      }

      private void datagridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         txtName.Text = datagridViewCart.Rows[e.RowIndex].Cells["productname"].Value.ToString();
         price =  Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["productprice"].Value);
         double quantity =  Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["quantity"].Value);
         txtTotalPrice.Text = (quantity * price).ToString();
         productid = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["productid"].Value);
         numericUpDown_Quantity.Value = Convert.ToDecimal(quantity);
         previousQuantity = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["quantity"].Value);
         setMax = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["quantity1"].Value);
         byte[] img = (byte[])(datagridViewCart.Rows[e.RowIndex].Cells["productimage"].Value);

         if (img == null)
         {
            pictureBox.Image = null;
         }
         else
         {
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
         }

         setNumericUpandDown();
         fieldControl(true);
      }

      private void numericUpDown_Quantity_ValueChanged(object sender, EventArgs e)
      {
         txtTotalPrice.Text = (Convert.ToDouble(numericUpDown_Quantity.Value) * price).ToString();
         newQuantity = Convert.ToInt32(numericUpDown_Quantity.Value);
      }

      private void clearFields()
      {
         pictureBox.Dispose();
         txtName.Clear();
         txtTotalPrice.Clear();
      }

      private void fieldControl(bool enable)
      {
         btnDelete.Enabled = enable;
         btnUpdate.Enabled = enable;
         txtTotalPrice.Enabled = enable;
         numericUpDown_Quantity.Enabled = enable;
         btnCheckout.Enabled = enable ? false : true;

      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Remove to cart?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM CartDB WHERE UserId = '" + productid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               clearFields();
               fieldControl(false);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void setTotalPrice() 
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT SUM(ProductInformation.ProductPrice * CartDb.Quantity) as TOTAL FROM productinformation INNER JOIN CartDb ON cartdb.productid = ProductInformation.ProductId WHERE CartDb.UserId = '"+ Login.userid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotal.Text = Function.reader["TOTAL"].ToString();
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         int ProductQuantity = 0;

         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM ProductInformation WHERE productid = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               ProductQuantity = Convert.ToInt32(Function.reader["Quantity"]);

               if (newQuantity < previousQuantity)
               {
                  Connection.DB();
                  Function.gen = "UPDATE CartDb SET Quantity = '" + newQuantity + "' WHERE productid = '" + productid + "' AND userid = '" + Login.userid + "'; UPDATE ProductInformation SET Quantity = '" + (ProductQuantity + (previousQuantity - newQuantity)) + "' WHERE productid = '" + productid + "'; ";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
               }
               else if (newQuantity > previousQuantity)
               {
                  Connection.DB();
                  Function.gen = "UPDATE CartDb SET Quantity = '" + newQuantity + "' WHERE productid = '" + productid + "' AND userid = '" + Login.userid + "'; UPDATE ProductInformation SET Quantity = '" + (ProductQuantity - (newQuantity - previousQuantity)) + "' WHERE productid = '" + productid + "'; ";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
               }
            }

            MessageBox.Show("Cart Updated");
            Connection.con.Close();
            viewCart();
            setTotalPrice();
            clearFields();
            fieldControl(false);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
