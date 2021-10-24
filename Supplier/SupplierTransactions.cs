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
   public partial class SupplierTransactions : Form
   {
      public SupplierTransactions()
      {
         InitializeComponent();
      }

      private void SupplierTransactions_Load(object sender, EventArgs e)
      {
         btnTransactions.FlatStyle = FlatStyle.Standard;
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var suphome = new SupplierHome();
         suphome.Show();
         Close();
      }

      private void btnProfile_Click(object sender, EventArgs e)
      {
         var profile = new SupplierProfile();
         profile.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var logout = new Homepage();
         logout.Show();
         Close();
      }
   }
}
