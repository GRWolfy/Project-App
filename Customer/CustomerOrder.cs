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
   public partial class CustomerOrder : Form
   {
      public CustomerOrder()
      {
         InitializeComponent();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var cproduct = new CustomerProduct();
         cproduct.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var caccount = new CustomerProfile();
         caccount.Show();
         Close();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var chome = new CustomerHome();
         chome.Show();
         Close();
      }
   }
}
