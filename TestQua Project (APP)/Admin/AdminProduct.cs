using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminProduct : Form
   {
      private bool[] isValid = new bool[5];
      string imageLocation = "";
      public static int productid;
      public static int userid;
      public static int orderid;
      private string status;
      private bool checker = false;

      public AdminProduct()
      {
         InitializeComponent();
      }

      private void btnBrowse_Click(object sender, EventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               imageLocation = dlg.FileName.ToString();
               pictureboxProductPic.ImageLocation = imageLocation;
               isValid[4] = true;
            }
            else
            {
               isValid[4] = false;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdatePic_Click(object sender, EventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               imageLocation = dlg.FileName.ToString();
               pictureboxProductPic.ImageLocation = imageLocation;
            }

            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "UPDATE Products SET productimage = @img WHERE productid = '" + txtProductId.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            clearFields();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void AdminProduct_Load(object sender, EventArgs e)
      {
         ViewProducts();
         btnProducts.FlatStyle = FlatStyle.Standard;
         setButtonVisibility(false);
         ViewTransactions();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            for (int i = 0; i < isValid.Length; i++)
            {
               if (isValid[i] == false)
               {
                  MessageBox.Show("Please review your inputs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  checker = false;
                  break;
               }
               else if (isValid[i] == true && i == isValid.Length - 1)
               {
                  checker = true;
               }
            }

            if (checker)
            {
               byte[] img = null;
               FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
               BinaryReader br = new BinaryReader(fs);
               img = br.ReadBytes((int)fs.Length);

               Connection.DB();
               Function.gen = "INSERT INTO Products(ProductName, ProductDescrip, ProductPrice, ProductImage, Quantity, Sold, TImeStored) VALUES('" + txtProductName.Text + "', '" + txtProductDescription.Text + "', '" + txtPrice.Text + "', @img, '" + txtQuantity.Text + "', '"+ 0 +"', '" + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt") + "' )";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.Parameters.Add(new SqlParameter("@img", img));
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();
               updateStatus();
            }

            var adminprod = new AdminProduct();
            adminprod.Show();
            adminprod.tabcontrolAdminProducts.SelectedIndex = 0;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE Products SET productname = '" + txtProductName.Text + "', productdescrip = '" + txtProductDescription.Text + "', productprice = '" + txtPrice.Text + "', quantity = '" + txtQuantity.Text + "' WHERE productid = '" + txtProductId.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            ViewProducts();
            setButtonVisibility(false);
            var adminprod = new AdminProduct();
            adminprod.Show();
            adminprod.tabcontrolAdminProducts.SelectedIndex = 0;
            updateStatus();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM Products WHERE ProductId = '" + txtProductId.Text + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               clearFields();
               setButtonVisibility(false);
               var adminprod = new AdminProduct();
               adminprod.Show();
               adminprod.tabcontrolAdminProducts.SelectedIndex = 0;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void ViewProducts()
      {
         Connection.DB();
         Function.gen = "SELECT productname as [NAME], productdescrip as [DESCRIPTION], 'P' + convert(varchar, cast(productprice AS MONEY), 1) as [PRICE], quantity as [QUANTITY], sold as [SOLD], Status as [STATUS],  productid, productimage, productprice from Products where productname like '" + txtSearch.Text + "%' ";
         Function.fill(Function.gen, datagridViewProduct);
         datagridViewProduct.Columns["productid"].Visible = false;
         datagridViewProduct.Columns["productimage"].Visible = false;
         datagridViewProduct.Columns["productprice"].Visible = false;
         datagridViewProduct.Columns["DESCRIPTION"].Visible = false;
      }

      private void datagridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         status = datagridViewProduct.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
         txtProductId.Text = datagridViewProduct.Rows[e.RowIndex].Cells["productid"].Value.ToString();
         txtProductName.Text = datagridViewProduct.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
         txtProductDescription.Text = datagridViewProduct.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();
         txtPrice.Text = datagridViewProduct.Rows[e.RowIndex].Cells["productprice"].Value.ToString();
         txtQuantity.Text = datagridViewProduct.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString();
         byte[] img = (byte[])(datagridViewProduct.Rows[e.RowIndex].Cells["productimage"].Value);

         if (img == null)
         {
            pictureboxProductPic.Image = null;
         }
         else
         {
            MemoryStream ms = new MemoryStream(img);
            pictureboxProductPic.Image = Image.FromStream(ms);
         }

         if (status == "STOCK LOW" && status != "REQUESTING")
         {
            var gen = MessageBox.Show("Do you want to request to restock this product?", "Stock low", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE Products SET status = '" + "REQUESTING" + "' WHERE productid = '" + txtProductId.Text + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Successfuly requested a restock");
            }
            else
            {
               tabcontrolAdminProducts.SelectedIndex = 0;
            }
         }
         else
         {
            tabcontrolAdminProducts.SelectedIndex = 0;
         }

         setButtonVisibility(true);
         updateStatus();
      }

      private void updateStatus()
      {
         var adminhome = new AdminHome();
         adminhome.updateProductStatus();
         ViewProducts();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var adminhome = new AdminHome();
         adminhome.Show();
         Close();
      }

      private void setButtonVisibility(bool value)
      {
         btnSave.Visible = value ? false : true;
         btnDelete.Visible = value;
         btnUpdate.Visible = value;
         btnBrowse.Visible = value ? false : true;
         btnUpdatePic.Visible = value;
         txtQuantity.Enabled = value ? false : true;
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var adminaccounts = new AdminAccounts();
         adminaccounts.Show();
         Close();
      }

      private void btnReports_Click(object sender, EventArgs e)
      {
         var report = new AdminReport();
         report.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void clearFields()
      {
         txtProductId.Clear();
         txtProductName.Clear();
         txtProductDescription.Clear();
         txtPrice.Clear();
         txtQuantity.Clear();
         pictureboxProductPic.Dispose();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         Close();
      }

      public void ViewTransactions()
      {
         Connection.DB();
         Function.gen = "SELECT transactions.orderid, transactions.userid, transactions.productid, transactions.totalprice, (UserInformation.FirstName + ' ' +  UserInformation.LastName) AS [SUPPLIER NAME], Products.ProductName AS [PRODUCT NAME], Transactions.Quantity AS [QUANTITY], 'P' + convert(varchar, cast(Transactions.TotalPrice AS MONEY), 1) as [TOTAL PRICE], Transactions.Status AS [STATUS] FROM Transactions INNER JOIN Products ON Products.ProductId = Transactions.ProductId INNER JOIN UserInformation ON UserInformation.UserId = Transactions.UserId";
         Function.fill(Function.gen, datagridViewTransactions);
         datagridViewTransactions.Columns["OrderId"].Visible = false;
         datagridViewTransactions.Columns["UserId"].Visible = false;
         datagridViewTransactions.Columns["ProductId"].Visible = false;
         datagridViewTransactions.Columns["TotalPrice"].Visible = false;
      }

      private void datagridViewTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         productid = Convert.ToInt32(datagridViewTransactions.Rows[e.RowIndex].Cells["ProductId"].Value);
         userid = Convert.ToInt32(datagridViewTransactions.Rows[e.RowIndex].Cells["userid"].Value);
         orderid = Convert.ToInt32(datagridViewTransactions.Rows[e.RowIndex].Cells["orderid"].Value);
         status = datagridViewTransactions.Rows[e.RowIndex].Cells["status"].Value.ToString();

         if (status == "PENDING")
         {
            var verifytransaction = new VerifyTransaction();
            verifytransaction.Show();
            Close();
         }
      }

      private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtProductName.Text != null)
         {
            isValid[0] = true;
         }
         else
         {
            isValid[0] = false;
         }
      }

      private void txtProductDescription_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtProductDescription.Text != null)
         {
            isValid[1] = true;
         }
         else
         {
            isValid[1] = false;
         }
      }

      private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if ((!Char.IsDigit(ch) && ch != 8 && ch != 46) || txtQuantity.Text == null)
         {
            e.Handled = true;
            isValid[3] = false;
         }
         else
         {
            isValid[3] = true;
         }
      }

      private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if ((!Char.IsDigit(ch) && ch != 8 && ch != 46) || txtQuantity.Text == null)
         {
            e.Handled = true;
            isValid[2] = false;
         }
         else
         {
            isValid[2] = true;
         }
      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         ViewProducts();
      }
   }
}


/*
   Hide productid
   Hide productimage
   Fix price display
   Fix rows and columns

   -orderid, userid, productid, quantity, totalprice, status
 */

