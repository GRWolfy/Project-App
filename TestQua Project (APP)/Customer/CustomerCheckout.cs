using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerCheckout : Form
   {
      private ArrayList ProductIDs = new ArrayList();
      private ArrayList QuantityBought = new ArrayList();
      private ArrayList QuantityProduct = new ArrayList();
      private ArrayList Sold = new ArrayList();

      public CustomerCheckout()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var cart = new ViewCart();
         cart.Show();
         Close();
      }

      private void CustomerCheckout_Load(object sender, EventArgs e)
      {
         setUserInformation();
         setPayments();
         setViewCart();
      }

      private void setUserInformation()
      {
         lblFullName.Text = Login.firstname + " " + Login.lastname;
         lblContactnumber.Text = Login.contactnumber;
         lblAddress.Text = Login.address;
      }

      private void setPayments()
      {
         lblTotalpayment.Text = ViewCart.stringWithShip;
         lblSubtotal.Text = ViewCart.stringTotalPrice;
         lblDeliveryfee.Text = "P80.00";
      }

      private void setViewCart()
      {
         Connection.DB();
         Function.gen = "SELECT cartdb.userid, cartdb.productid, Products.productname AS NAME, cartdb.quantity AS QUANTITY, (Products.productprice * cartdb.quantity) AS [total1], 'P' + convert(varchar, cast((Products.productprice * cartdb.quantity) AS MONEY), 1) AS [TOTAL] from CartDb INNER JOIN Products ON CartDB.productid = Products.productid  WHERE userid = '" + Login.userid + "' ";
         Function.fill(Function.gen, dataGridView);
         dataGridView.Columns["userid"].Visible = false;
         dataGridView.Columns["productid"].Visible = false;
         dataGridView.Columns["total1"].Visible = false;
      }

      private void btnPlaceOrder_Click(object sender, EventArgs e)
      {
         try
         {
            setProductIDs();
            string productID = "";
            string quantity = "";

            for (int i = 0; i < ProductIDs.Count; i++)
            {
               int ProductQuantity = Convert.ToInt32(QuantityProduct[i]);
               int CartQuantity = Convert.ToInt32(QuantityBought[i]);
               int newProductQuantity = ProductQuantity - CartQuantity;
               int sold = Convert.ToInt32(Sold[i]) + CartQuantity;

               Connection.DB();
               Function.gen = "UPDATE Products SET quantity = '" + newProductQuantity + "', sold = '"+ sold +"' WHERE productid = '" + ProductIDs[i] + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();

               if (i == ProductIDs.Count - 1)
               {
                  productID += ProductIDs[i].ToString();
                  quantity += QuantityBought[i].ToString();

                  Connection.DB();
                  Function.gen = "INSERT INTO OrdersDb(Userid, ProductId, QuantityBought, TotalPrice, TimeofTransaction, Status) VALUES('" + Login.userid + "', '" + productID + "', '" + quantity + "', '" + (ViewCart.TotalPrice + 80) + "', '" + DateTime.Now.ToString() + "', '" + "SHIPPED OUT" + "')";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  Connection.con.Close();
               }

               productID += ProductIDs[i].ToString() + ",";
               quantity += QuantityBought[i].ToString() + ",";
            }



            clearCart();
            MessageBox.Show("Thank you for your order!");
            var cart = new ViewCart();
            ViewCart.TotalPrice = 0;
            cart.Show();
            Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void clearCart()
      {
         try
         {
            Connection.DB();
            Function.gen = "DELETE FROM CartDB WHERE userid = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void setProductIDs()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT CartDb.Quantity AS [CartQuantity], CartDb.ProductId AS [ProductID], Products.Quantity AS [ProductQuantity], Products.Sold AS [Sold] FROM CartDB INNER JOIN Products ON Products.ProductId = CartDB.ProductId WHERE userid = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.HasRows && Function.reader.HasRows)
            {
               Function.reader.Read();
               ProductIDs.Add(Convert.ToInt32(Function.reader["ProductId"]));
               QuantityBought.Add(Convert.ToInt32(Function.reader["CartQuantity"]));
               QuantityProduct.Add(Convert.ToInt32(Function.reader["ProductQuantity"]));
               Sold.Add(Convert.ToInt32(Function.reader["Sold"]));
            }
         }

         catch (Exception ex)
         {
            //NONE
         }
      }
   }
}

//SET THE STATUS