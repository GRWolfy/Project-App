﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerCheckout : Form
   {
      private ArrayList ProductIDs = new ArrayList();
      private ArrayList QuantityBought = new ArrayList();

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
         lblTotalpayment.Text = (ViewCart.TotalPrice + 80).ToString() + ".00";
         lblSubtotal.Text = ViewCart.TotalPrice.ToString() + ".00";
         lblDeliveryfee.Text = "80.00";
      }

      private void setViewCart()
      {
         Connection.DB();
         Function.gen = "SELECT * from CartDb INNER JOIN ProductInformation ON CartDB.productid = ProductInformation.productid  WHERE userid = '" + Login.userid + "' ";
         Function.fill(Function.gen, dataGridView);
      }

      private void btnPlaceOrder_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            //Function.gen = "INSERT INTO OrderDb(Userid, ProductId, QuantityBought, TotalPrice, TimeofTransaction) VALUES('" + Login.userid + "', '" + /*ProductId*/ + "', '" + /*QuantityBought*/ + "', '" + Convert.ToInt32(lblTotalpayment.Text) + "', '" + DateTime.Now.ToString() + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            var cart = new ViewCart();
            cart.Show();
            Close();
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
            Function.gen = "SELECT * FROM CartDB WHERE userid = '"+ Login.userid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.HasRows && Function.reader.HasRows) 
            {
               Function.reader.Read();
               ProductIDs.Add(Convert.ToInt32(Function.reader["ProductId"]));
               QuantityBought.Add(Convert.ToInt32(Function.reader["Quantity"]));
            }
         }

         catch (Exception ex)
         {
            //NONE
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         setProductIDs();
         //lblTesting.Text = ProductIDs.Count.ToString();
         string productID = "";
         string quantity = "";

         for (int i = 0; i < ProductIDs.Count; i++)
         {
            if (i == ProductIDs.Count - 1)
            {
               productID += ProductIDs[i].ToString();
               quantity += QuantityBought[i].ToString();

               Connection.DB();
               Function.gen = "INSERT INTO OrdersDb(Userid, ProductId, QuantityBought, TotalPrice, TimeofTransaction) VALUES('" + Login.userid + "', '" + productID +"', '" + quantity +"', '" + (ViewCart.TotalPrice + 80) + "', '" + DateTime.Now.ToString() + "')";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
            }

            productID += ProductIDs[i].ToString() + ",";
            quantity += QuantityBought[i].ToString() + ",";
         }
      }
   }
}