using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerProduct : Form
   {
      private PictureBox pic = new PictureBox();
      private Label price;
      private Label name;
      public static int productid = 0;

      public CustomerProduct()
      {
         InitializeComponent();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var customerhome = new CustomerHome();
         customerhome.Show();
         Hide();
      }

      private void btnProfile_Click(object sender, EventArgs e)
      {
         var customerprofile = new CustomerProfile();
         customerprofile.Show();
         Close();
      }

      private void CustomerProduct_Load(object sender, EventArgs e)
      {
         btnProducts.FlatStyle = FlatStyle.Standard;
         ViewProducts();
         viewCountCart();
      }

      private void viewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         var viewproduct = new CustomerProductView();
         viewproduct.Show();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {

      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void ViewProducts()
      {
         flowlayoutViewProducts.Controls.Clear();

         Connection.DB();
         Function.gen = "SELECT * FROM ProductInformation WHERE productname LIKE '" + txtSearchProduct.Text + "%' ";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
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

            MemoryStream ms = new MemoryStream(array);
            Bitmap bitmap = new Bitmap(ms);
            pic.BackgroundImage = bitmap;
            pic.Controls.Add(name);
            pic.Controls.Add(price);
            flowlayoutViewProducts.Controls.Add(pic);

            pic.Click += new EventHandler(OnClick);
         }

         flowlayoutViewProducts.AutoScroll = true;
         Connection.con.Close();
      }

      public void OnClick(object sender, EventArgs e)
      {
         try
         {
            productid = Convert.ToInt32(((PictureBox)sender).Tag);
            var viewproduct = new ViewProduct();
            viewproduct.Show();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }

      private void txtSearchProduct_TextChanged(object sender, EventArgs e)
      {
         ViewProducts();
      }

      private void viewCountCart()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT COUNT(*) AS total FROM CartDb WHERE UserId = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblCountCart.Text = (Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var viewproduct = new ViewProduct();
         viewproduct.Show();
      }

      private void btnViewCart_Click(object sender, EventArgs e)
      {
         var viewcart = new ViewCart();
         viewcart.Show();
         Close();
      }

      private void btnOrder_Click(object sender, EventArgs e)
      {
         var customerorder = new CustomerOrder();
         customerorder.Show();
         Close();
      }
   }
}
