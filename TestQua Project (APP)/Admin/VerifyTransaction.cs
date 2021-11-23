using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class VerifyTransaction : Form
   {
      private string imageLocation = "";
      private int Quantity = 0;
      private int SupplyQuantity;
      private string status;

      public VerifyTransaction()
      {
         InitializeComponent();
      }

      private void AddFromSupply_Load(object sender, EventArgs e)
      {
         getFields();
      }

      private void getFields()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM Products WHERE ProductId = '" + AdminProduct.productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblName.Text = Function.reader["productname"].ToString();
               lblDescription.Text = Function.reader["productdescrip"].ToString();
               lblPrice.Text = Function.reader["productprice"].ToString();
               Quantity = Convert.ToInt32(Function.reader["quantity"]);
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

            Connection.DB();
            Function.gen = "SELECT * FROM Transactions WHERE ProductId = '" + AdminProduct.productid + "' AND userid = '"+ AdminProduct.userid +"' AND status = 'PENDING' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               //status = Function.reader["status"].ToString();
               SupplyQuantity = Convert.ToInt32(Function.reader["quantity"]);
               lblQuantity.Text = Function.reader["quantity"].ToString();
            }

            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         adminproduct.tabcontrolAdminProducts.SelectedIndex = 2;
         Close();
      }

      private void btnReceived_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to receive this stock This actions is not reversible.?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE Products SET Quantity = '" + (SupplyQuantity + Quantity) + "' WHERE productid = '" + AdminProduct.productid + "'; UPDATE Transactions SET Status = 'RECEIVED' WHERE orderid = '" + AdminProduct.orderid + "'; UPDATE Products SET status = '' WHERE productid = '" + AdminProduct.productid + "'; ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               MessageBox.Show("Product Restocked.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Function.command.ExecuteNonQuery();

               btnReceived.Enabled = false;
               btnReturn.Enabled = false;

               Close();

               var adminprod = new AdminProduct();
               adminprod.Show();
               adminprod.tabcontrolAdminProducts.SelectedIndex = 2;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnReturn_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to return this stock? This actions is not reversible.?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE Transactions SET Status = 'RETURN' WHERE orderid = '" + AdminProduct.orderid + "'; UPDATE Products SET status = '' WHERE productid = '"+ AdminProduct.productid +"'; ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               MessageBox.Show("Supply returned.", "Returned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Function.command.ExecuteNonQuery();

               btnReceived.Enabled = false;
               btnReturn.Enabled = false;

               Close();

               var adminprod = new AdminProduct();
               adminprod.Show();
               adminprod.tabcontrolAdminProducts.SelectedIndex = 2;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
