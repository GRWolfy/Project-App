using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Guest
{
   public partial class GuestViewProduct : Form
   {
      public static int productid = 0;
      private PictureBox pic = new PictureBox();
      private Label price;
      private Label name;
      private Label quantity;

      public GuestViewProduct()
      {
         InitializeComponent();
      }

      private void GuestViewProduct_Load(object sender, EventArgs e)
      {
         btnProducts.FlatStyle = FlatStyle.Standard;
         ViewProducts();
      }

      private void ViewProducts()
      {
         flowlayoutViewProducts.Controls.Clear();

         Connection.DB();
         Function.gen = "SELECT * FROM Products WHERE productname LIKE '" + txtSearchProduct.Text + "%' ";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
         {
            if (Convert.ToInt32(Function.reader["quantity"]) > 0)
            {
               long len = Function.reader.GetBytes(4, 0, null, 0, 0);
               byte[] array = new byte[Convert.ToInt32(len + 1)];
               Function.reader.GetBytes(4, 0, array, 0, Convert.ToInt32(len));
               pic = new PictureBox();
               pic.Width = 290;
               pic.Height = 300;
               pic.BackgroundImageLayout = ImageLayout.Stretch;
               pic.Tag = Function.reader["productid"].ToString();

               price = new Label();
               name = new Label();
               quantity = new Label();

               name.Text = Function.reader["productname"].ToString();
               name.BackColor = Color.FromArgb(46, 134, 222);
               name.Font = new Font("Arial", 24, FontStyle.Bold);
               name.TextAlign = ContentAlignment.MiddleCenter;
               name.Dock = DockStyle.Bottom;
               name.Height = 40;
               name.Tag = Function.reader["productname"].ToString();

               price.Text = "P" + Function.reader["productprice"].ToString() + ".00";
               price.ForeColor = Color.White;
               price.Font = new Font("Arial", 24, FontStyle.Bold);
               price.BackColor = Color.FromArgb(113, 1, 147);
               price.Dock = DockStyle.Bottom;
               price.Width = 70;
               price.Height = 40;
               price.Tag = Function.reader["productprice"].ToString();

               quantity.Text = Function.reader["Quantity"].ToString() + " qty.";
               quantity.ForeColor = Color.White;
               quantity.Font = new Font("Arial", 24);
               quantity.BackColor = Color.FromArgb(113, 1, 147);
               quantity.Dock = DockStyle.Bottom;
               quantity.Width = 70;
               quantity.Height = 40;

               MemoryStream ms = new MemoryStream(array);
               Bitmap bitmap = new Bitmap(ms);
               pic.BackgroundImage = bitmap;
               pic.Controls.Add(name);
               pic.Controls.Add(price);
               pic.Controls.Add(quantity);
               flowlayoutViewProducts.Controls.Add(pic);

               pic.Click += new EventHandler(OnClick);
            }
         }

         flowlayoutViewProducts.AutoScroll = true;
         Connection.con.Close();
      }

      public void OnClick(object sender, EventArgs e)
      {
         try
         {
            productid = Convert.ToInt32(((PictureBox)sender).Tag);
            var viewproduct = new GuestSelectProduct();
            viewproduct.Show();
            Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var guesthome = new GuestHome();
         guesthome.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void txtSearchProduct_TextChanged(object sender, EventArgs e)
      {
         ViewProducts();
      }
   }
}
