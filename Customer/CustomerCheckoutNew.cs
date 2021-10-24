using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerDeliveryDateNew : Form
   {
      public CustomerDeliveryDateNew()
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

      }
   }
}
