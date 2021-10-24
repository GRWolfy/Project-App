using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestQua_Project__APP_.Admin
{
   public partial class ViewProduct : Form
   {
      private PictureBox pic = new PictureBox();
      private Label price;
      private Label name;
      private Label description;
      private Label quantity;
      private double totalprice = 0;
      private int productid = 0;
      private int qty = 0;

      public ViewProduct()
      {
         InitializeComponent();
      }

      private void ViewProduct_Load(object sender, EventArgs e)
      {
         viewDataProduct();
         flowlayoutViewProdcut();
      }

      private void viewDataProduct()
      {
         Connection.DB();
         Function.gen = "SELECT * from ProductInformation";
         Function.fill(Function.gen, datagridViewProduct);
      }

      private void flowlayoutViewProdcut()
      {
         flowLayoutPanel1.Controls.Clear();

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
            pic.Width = 400;
            pic.Height = 300;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Tag = Function.reader["productid"].ToString();

            price = new Label();
            name = new Label();
            description = new Label();

            name.Text = Function.reader["productname"].ToString();
            name.BackColor = Color.FromArgb(46, 134, 222);
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Dock = DockStyle.Right;
            name.Width = 70;
            name.Tag = Function.reader["productname"].ToString();

            price.Text = "P" + Function.reader["productprice"].ToString();
            price.BackColor = Color.FromArgb(46, 134, 222);
            price.Dock = DockStyle.Right;
            price.Width = 70;
            price.Tag = Function.reader["productprice"].ToString();

            MemoryStream ms = new MemoryStream(array);
            Bitmap bitmap = new Bitmap(ms);
            pic.BackgroundImage = bitmap;
            pic.Controls.Add(name);
            pic.Controls.Add(price);
            flowLayoutPanel1.Controls.Add(pic);

            pic.Click += new EventHandler(OnClick);
         }

         flowLayoutPanel1.AutoScroll = true;
         Connection.con.Close();
      }

      public void OnClick(object sender, EventArgs e)
      {
         try
         {
            int productid = Convert.ToInt32(((PictureBox)sender).Tag);

            Connection.DB();
            Function.gen = "SELECT * FROM ProductInformation WHERE productid = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               datagridViewcart.Rows.Add(datagridViewcart.Rows.Count - 1 + 1, Function.reader["productid"].ToString(), Function.reader["productname"].ToString(), double.Parse(Function.reader["productprice"].ToString()).ToString("#, ###.00"));
               totalprice += double.Parse(Function.reader["productprice"].ToString());
               lblTotalPrice.Text = "P" + totalprice.ToString("#, ###.00");
               this.productid = Convert.ToInt32(Function.reader["productid"]);
               qty = Convert.ToInt32(Function.reader["quantity"]);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
         
      }

      public void setCartdb()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM CartDb WHERE productid = '" + productid + "' AND UserId = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows) //TRUE, update product quantity
            {
               Function.gen = "UPDATE CartDb SET Quantity = '"+ (qty + 1) +"' WHERE = productid = '"+ productid +"' AND userid = '"+ Login.userid+"' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
            }
            else //false, insert to cartdb
            {
               Function.gen = "INSERT INTO CartDb(userid, productid, quantity, checker) VALUES()";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
            }

            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnProduct_Click(object sender, EventArgs e)
      {
         var product = new AddProduct();
         product.Show();
      }

      private void txtSearchProduct_TextChanged(object sender, EventArgs e)
      {
         flowlayoutViewProdcut();
      }
   }
}

/* 
 * youtube.com/watch?v=BAxmXu9FJos&t=557s
 * 
 * flowlayout event
 * youtube.com/watch?v=zjsK_4JHinE&t=263s
 * 
 * Search flowlayout
 * youtube.com/watch?v=WenNmob2oCo
 * 
 * 
 * 
 */
