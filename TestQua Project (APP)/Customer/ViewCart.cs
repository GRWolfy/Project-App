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
      private int productid = 0;
      private int setMax = 0;
      private int previousQuantity = 0;
      private int newQuantity = 0;
      public static double TotalPrice = 0;
      public static string stringTotalPrice;
      public static string stringWithShip;
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

      private void viewCart()
      {
         Connection.DB();
         Function.gen = "SELECT Products.productid, Products.productname AS [PRODUCT NAME],Products.productprice, 'P' + convert(varchar, cast(Products.productprice AS MONEY), 1) AS [PRICE], CartDb.Quantity AS [QUANTITY], Products.Quantity, Products.productimage, 'P' + convert(varchar, cast((Products.ProductPrice * CartDb.Quantity) AS MONEY), 1) AS [SUB TOTAL] FROM CartDb INNER JOIN Products ON CartDB.productid = Products.productid  WHERE Cartdb.userid = '" + Login.userid + "' ";
         Function.fill(Function.gen, datagridViewCart);
         datagridViewCart.Columns["productimage"].Visible = false;
         datagridViewCart.Columns["productid"].Visible = false;
         datagridViewCart.Columns["quantity1"].Visible = false;
         datagridViewCart.Columns["productprice"].Visible = false;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (TotalPrice > 0)
         {
            var customercheckout = new CustomerCheckout();
            customercheckout.Show();
            Close();
         }
         else
         {
            MessageBox.Show("CART EMPTY");
         }

      }

      private void clearFields()
      {
         pictureBox.Dispose();
         txtName.Clear();
         txtTotalPrice.Clear();
         txtQuantity.Clear();
      }

      private void fieldControl(bool enable)
      {
         btnDelete.Enabled = enable;
         btnUpdate.Enabled = enable;
         txtTotalPrice.Enabled = enable;
         txtQuantity.Enabled = enable;
         btnMinus.Enabled = enable;
         btnPlus.Enabled = enable;
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
               Function.gen = "DELETE FROM CartDB WHERE productid = '" + productid + "' AND userid = '" + Login.userid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               clearFields();
               setTotalPrice();
               viewCart();
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
            Function.gen = "SELECT SUM(Products.ProductPrice * CartDb.Quantity) AS total, 'P' + convert(varchar, cast(SUM(Products.ProductPrice * CartDb.Quantity) AS MONEY), 1) AS [TOTAL], 'P' + convert(varchar, cast(SUM((Products.ProductPrice * CartDb.Quantity) + 80) AS MONEY), 1) AS [withShip] FROM Products INNER JOIN CartDb ON cartdb.productid = Products.ProductId WHERE CartDb.UserId = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotal.Text = Function.reader["TOTAL"].ToString();
               TotalPrice = Convert.ToDouble(Function.reader["total"]);
               stringTotalPrice =  Function.reader["TOTAL"].ToString();
               stringWithShip = Function.reader["withShip"].ToString();
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotal.Text = "0";
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {

            Connection.DB();
            Function.gen = "UPDATE CartDb SET Quantity = '" + newQuantity + "' WHERE productid = '" + productid + "' AND userid = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();

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

      private void datagridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         txtName.Text = datagridViewCart.Rows[e.RowIndex].Cells["PRODUCT NAME"].Value.ToString();
         price = Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["productprice"].Value);
         double quantity = Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["QUANTITY"].Value);
         txtTotalPrice.Text = (quantity * price).ToString();
         productid = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["productid"].Value);
         txtQuantity.Text = quantity.ToString();
         previousQuantity = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["QUANTITY"].Value);
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

         fieldControl(true);
      }

      private void btnMinus_Click(object sender, EventArgs e)
      {
         --newQuantity;
         txtQuantity.Text = newQuantity.ToString();
      }

      private void btnPlus_Click(object sender, EventArgs e)
      {
         ++newQuantity;
         txtQuantity.Text = newQuantity.ToString();
      }

      private void txtQuantity_TextChanged(object sender, EventArgs e)
      {
         try
         {
            if (newQuantity < setMax + 1 || newQuantity > 0)
            {
               newQuantity = Convert.ToInt32(txtQuantity.Text);
            }
            else
            {
               MessageBox.Show("Quantity out of range, please redo setting quantity.");
            }
         }

         catch (Exception ex)
         {

         }
      }
   }
}
