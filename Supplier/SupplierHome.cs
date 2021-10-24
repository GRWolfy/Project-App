using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Supplier
{
   public partial class SupplierHome : Form
   {
      public SupplierHome()
      {
         InitializeComponent();
      }

      private void SupplierHome_Load(object sender, EventArgs e)
      {
         btnHome.FlatStyle = FlatStyle.Standard;
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Close();
      }

      private void btnProfile_Click(object sender, EventArgs e)
      {
         var supplierprofile = new SupplierProfile();
         supplierprofile.Show();
         Close();
      }

      private void btnTransactions_Click(object sender, EventArgs e)
      {
         var transac = new SupplierTransactions();
         transac.Show();
         Close();
      }
   }
}
