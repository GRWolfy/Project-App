using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewProduct : Form
   {
      private int productid = CustomerProduct.productid;
      private int userid = Login.userid;
      private int quantity = 0;
      private int setMax = 0;
      private int setMin = 0;
      private int newQuantity = 0;
      private int previousQuantity = 0;
      private int ProductQuantity = 0;
      private int setQuantity = 0;
      public ViewProduct()
      {
         InitializeComponent();
      }

      private void ViewProduct_Load(object sender, EventArgs e)
      {
         getProducts();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void getProducts()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM Products WHERE ProductId = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblName.Text = Function.reader["productname"].ToString();
               txtDescription.Text = Function.reader["productdescrip"].ToString();
               lblPrice.Text = Function.reader["productprice"].ToString();
               lblQuantity.Text = Function.reader["quantity"].ToString();
               setMax = Convert.ToInt32(Function.reader["quantity"]);
               ProductQuantity = Convert.ToInt32(Function.reader["quantity"]);
               byte[] img = (byte[])(Function.reader[4]);

               if (img == null)
               {
                  pictureboxProductPic.Image = null;
               }
               else
               {
                  MemoryStream ms = new MemoryStream(img);
                  pictureboxProductPic.Image = Image.FromStream(ms);
               }
            }

            pictureboxProductPic.BackgroundImageLayout = ImageLayout.Stretch;
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnAddtoCart_Click(object sender, EventArgs e)
      {
         if (newQuantity > 0)
         {
            try
            { //DAPAT D SA MO MINUS SA PRODUCT INIG ADD TO CART! (OK RA MN KUNO)
               Connection.DB();
               Function.gen = "SELECT * FROM CartDb WHERE productid = '" + productid + "' AND userid = '" + userid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.reader = Function.command.ExecuteReader();

               if (Function.reader.HasRows) //UPDATE
               {
                  Function.reader.Read();
                  quantity = Convert.ToInt32(Function.reader["quantity"]);
                  previousQuantity = quantity;
                  Connection.con.Close();
                  Connection.DB();
                  Function.gen = "UPDATE CartDb SET Quantity = '" + (newQuantity + previousQuantity) + "' WHERE productid = '" + productid + "' AND userid = '" + userid + "' ";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  MessageBox.Show("Cart Updated");
               }
               else
               {
                  Connection.con.Close();
                  Connection.DB();
                  Function.gen = "INSERT INTO CartDb(userid, productid, quantity) VALUES('" + userid + "', '" + productid + "', '" + newQuantity + "' )";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  MessageBox.Show("Added to Cart");
               }


               var viewproduct = new ViewProduct();
               viewproduct.Show();
               Close();
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
         else if (newQuantity > setMax + 1)
         {
            MessageBox.Show("Quantity out of range");
         }
         else
         {
            MessageBox.Show("Please set the quantity first");
         }
      }

      private void btnPlus_Click(object sender, EventArgs e)
      {
         ++newQuantity;
         txtQuantity.Text = newQuantity.ToString();
      }

      private void btnMinus_Click(object sender, EventArgs e)
      {
         --newQuantity;
         txtQuantity.Text = newQuantity.ToString();
      }

      private void txtQuantity_TextChanged(object sender, EventArgs e)
      {
         try
         {
            if (Convert.ToInt32(txtQuantity.Text) < setMax + 1 && Convert.ToInt32(txtQuantity.Text) > setMin)
            {
               newQuantity = Convert.ToInt32(txtQuantity.Text);
            }
            else
            {
               MessageBox.Show("Quantity out of range, please redo setting quantity.");
               newQuantity = 0;
               txtQuantity.Clear();
            }
         }

         catch (Exception ex)
         {

         }
      }
   }
}
