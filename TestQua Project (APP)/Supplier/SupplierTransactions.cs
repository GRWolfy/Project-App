using System;
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
         ViewTransactions();
      }

      private void ViewTransactions()
      {
         Connection.DB();
         Function.gen = "SELECT * FROM Transactions";
         Function.fill(Function.gen, datagridViewTransactions);
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

      private void btnProduct_Click(object sender, EventArgs e)
      {
         var prod = new SupplierProduct();
         prod.Show();
         Close();
      }
   }
}
