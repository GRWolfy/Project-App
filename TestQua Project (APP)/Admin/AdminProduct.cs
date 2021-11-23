using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminProduct : Form
   {
      string imageLocation = "";
      public static int productid;
      public static int userid;
      public static int orderid;
      private string status;

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
         setButtonVisibiity(false);
         ViewTransactions();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "INSERT INTO Products(ProductName, ProductDescrip, ProductPrice, ProductImage, Quantity, TImeStored) VALUES('" + txtProductName.Text + "', '" + txtProductDescription.Text + "', '" + txtPrice.Text + "', @img, '" + txtQuantity.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt") + "' )";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            updateStatus();
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
            clearFields();
            setButtonVisibiity(false);
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
               setButtonVisibiity(false);
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
         Function.gen = "SELECT productname as [NAME], productdescrip as [DESCRIPTION], 'P' + convert(varchar, cast(productprice AS MONEY), 1) as [PRICE], quantity as [QUANTITY], Status as [STATUS],  productid, productimage, productprice from Products";
         Function.fill(Function.gen, datagridViewProduct);
         datagridViewProduct.Columns["productid"].Visible = false;
         datagridViewProduct.Columns["productimage"].Visible = false;
         datagridViewProduct.Columns["productprice"].Visible = false;
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

         if (status == "STOCK LOW")
         {
            var gen = MessageBox.Show("Do you want to request to restock this product?", "Stock low", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE Products SET status = '" + "NEED RESTOCK" + "' WHERE productid = '" + txtProductId.Text + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Successfuly requested a restock");
            }
         }
         else
         {
            tabcontrolAdminProducts.SelectedIndex = 0;
         }

         setButtonVisibiity(true);
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

      private void setButtonVisibiity(bool value)
      {
         btnSave.Enabled = value ? false : true;
         btnDelete.Enabled = value;
         btnUpdate.Enabled = value;
         btnBrowse.Enabled = value ? false : true;
         btnUpdatePic.Enabled = value ? false : true;
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
   }
}


/*
   Hide productid
   Hide productimage
   Fix price display
   Fix rows and columns

   -orderid, userid, productid, quantity, totalprice, status
 */

