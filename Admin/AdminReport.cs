using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminReport : Form
   {
      public AdminReport()
      {
         InitializeComponent();
      }

      private void AdminReport_Load(object sender, EventArgs e)
      {
         btnReports.FlatStyle = FlatStyle.Standard;
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var home = new AdminHome();
         home.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var account = new AdminAccounts();
         account.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var product = new AdminProduct();
         product.Show();
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
