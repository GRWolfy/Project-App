﻿using System;
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

namespace TestQua_Project__APP_.Supplier
{
   public partial class SupplierProduct : Form
   {
      string imageLocation = "";

      public SupplierProduct()
      {
         InitializeComponent();
      }

      private void SupplierProduct_Load(object sender, EventArgs e)
      {
         ViewProducts();
      }

      private void btnSave_Click_1(object sender, EventArgs e) //FIX THIS AREA (Supplier to transactions)
      {
         try
         {
            /*When Save clicked -> Transactions for confirmation of restocking
               -orderid, userid, productid, quantity, totalprice, status
            */
            double totalprice = (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text)) + 80.00;

            Connection.DB();
            Function.gen = "INSERT INTO Transactions(userid, productid, quantity, totalprice, status) VALUES('"+ Login.userid + "', '"+ txtProductId.Text +"', '"+ txtQuantity.Text +"', '"+ totalprice +"', '"+ "PENDING" +"') ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
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

      private void ViewProducts()//Fix this area
      {
         //productid, productname, productdescrip, productprice, productimage, quantity, status, timestored
         Connection.DB();
         Function.gen = "SELECT productid, productname as [NAME], productdescrip as [DESCRIPTION], productprice as [PRICE], productimage, quantity as [QUANTITY], status as [STATUS], timestored as [TIME STORED] from Products WHERE Status = '"+ "NEED RESTOCK" +"' ";
         Function.fill(Function.gen, datagridViewProduct);
         datagridViewProduct.Columns["productimage"].Visible = false;
         datagridViewProduct.Columns["productid"].Visible = false;
      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {

      }

      private void datagridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         txtProductId.Text = datagridViewProduct.Rows[e.RowIndex].Cells["productid"].Value.ToString();
         txtProductName.Text = datagridViewProduct.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
         txtProductDescription.Text = datagridViewProduct.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();
         txtPrice.Text = datagridViewProduct.Rows[e.RowIndex].Cells["PRICE"].Value.ToString();
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

         tabControl1.SelectedIndex = 0;
      }
   }
}

/*
   Suppier to admin
     -SUpplier tig restock ra siya sa low stock sa admin

 */


 /*
   TransactionsDB
      -Status: 
         PENDING
         DELIVERED
         RETURN
  */