using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace TestQua_Project__APP_.Admin
{
   public partial class AddProduct : Form
   {
      string imageLocation = "";

      public AddProduct()
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
               pictureBox.ImageLocation = imageLocation;
            }
         }
         
         catch(Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
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
            Function.gen = "INSERT INTO ProductInformation(ProductName, ProductDescrip, ProductPrice, ProductImage)VALUES('"+ txtbProductName.Text +"', '"+ txtbProductDescription.Text + "', '" + txtbProductPrice.Text +"', @img)";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnShow_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM ProductInformation WHERE ProductId = '"+ txtbProductId.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               txtbProductName.Text = Function.reader["ProductName"].ToString();
               txtbProductDescription.Text = Function.reader["ProductDescrip"].ToString();
               txtbProductPrice.Text = Function.reader["ProductPrice"].ToString();
               byte[] img = (byte[])(Function.reader[4]);

               if (img == null)
               {
                  pictureBox.Image = null;
               }
               else
               {
                  MemoryStream ms = new MemoryStream(img);
                  pictureBox.Image = Image.FromStream(ms);
               }
            }

            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnViewProduct_Click(object sender, EventArgs e)
      {
         var viewproduct = new ViewProduct();
         viewproduct.Show();
      }

      private void viewDataProduct()
      {
         Connection.DB();
         Function.gen = "SELECT * from ProductInformation";
         Function.fill(Function.gen, dataGridView1);
      }

      private void AddProduct_Load(object sender, EventArgs e)
      {
         viewDataProduct();
         //dataGridView1.RowTemplate.Height = 60;
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         txtbProductId.Text = dataGridView1[0, e.RowIndex].Value.ToString();
         txtbProductName.Text = dataGridView1[1, e.RowIndex].Value.ToString();
         txtbProductDescription.Text = dataGridView1[2, e.RowIndex].Value.ToString();
         txtbProductPrice.Text = dataGridView1[3, e.RowIndex].Value.ToString();
         byte[] img = (byte[])(dataGridView1[4, e.RowIndex].Value);

         if (img == null)
         {
            pictureBox.Image = null;
         }
         else
         {
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE ProductInformation SET productname = '"+ txtbProductName.Text +"', productdescrip = '"+ txtbProductDescription.Text +"', productprice = '"+ txtbProductPrice.Text +"' WHERE productid = '"+ txtbProductId.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            viewDataProduct();
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
               pictureBox.ImageLocation = imageLocation;
            }

            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "UPDATE ProductInformation SET productimage = @img WHERE productid = '" + txtbProductId.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            viewDataProduct();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
