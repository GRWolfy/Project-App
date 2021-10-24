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

namespace TestQua_Project__APP_.Guest
{
   public partial class GuestViewProduct : Form
   {
      private PictureBox pic = new PictureBox();
      private Label price;
      private Label name;

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
         }

         flowlayoutViewProducts.AutoScroll = true;
         Connection.con.Close();
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
