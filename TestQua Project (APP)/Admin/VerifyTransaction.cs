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
               SupplyQuantity = Convert.ToInt32(Function.reader["quantity"]);
               lblQuantity.Text = Function.reader["quantity"].ToString();
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
         try
         {
            //UPDATE the ProductDB (Transaction Quantity + Product Quantity)
            //UPDATE Transaction status PENDING to DELIVERED or RETURN
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

      private void numericQuantity_ValueChanged(object sender, EventArgs e)
      {

      }
   }
}
