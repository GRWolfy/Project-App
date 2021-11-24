using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Login : Form
   {
      public static int userid = 0;
      public static int roleid = 0;
      public static string firstname = "";
      public static string lastname = "";
      public static string contactnumber = "";
      public static string address = "";

      public Login()
      {
         InitializeComponent();
      }

      private void btnLogin_Click_1(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               roleid = Convert.ToInt32(Function.reader["RoleId"]);

               if (roleid == 1)
               {    //Admin
                  txtUsername.Text = Function.reader["Username"].ToString();
                  txtPassword.Text = Function.reader["Password"].ToString();

                  firstname = Function.reader["Firstname"].ToString();
                  lastname = Function.reader["Lastname"].ToString();
                  userid = Convert.ToInt32(Function.reader["UserId"]);
                  roleid = Convert.ToInt32(Function.reader["RoleId"]);
                  var adminhome = new Admin.AdminHome();
                  adminhome.Show();
                  Hide();
               }
               else if (roleid == 2)
               {  //Customer
                  txtUsername.Text = Function.reader["Username"].ToString();
                  txtPassword.Text = Function.reader["Password"].ToString();

                  firstname = Function.reader["Firstname"].ToString();
                  lastname = Function.reader["Lastname"].ToString();
                  userid = Convert.ToInt32(Function.reader["UserId"]);
                  roleid = Convert.ToInt32(Function.reader["RoleId"]);
                  contactnumber = Function.reader["ContactNo"].ToString();
                  address = Function.reader["address"].ToString();

                  var customerhome = new Customer.CustomerHome();
                  customerhome.Show();
                  Hide();
               }
               else if (roleid == 3)
               { //Supplier
                  txtUsername.Text = Function.reader["Username"].ToString();
                  txtPassword.Text = Function.reader["Password"].ToString();

                  firstname = Function.reader["Firstname"].ToString();
                  lastname = Function.reader["Lastname"].ToString();
                  userid = Convert.ToInt32(Function.reader["UserId"]);
                  roleid = Convert.ToInt32(Function.reader["RoleId"]);
                  var supplierhome = new Supplier.SupplierHome();
                  supplierhome.Show();
                  Close();
               }
            }
            else
            {
               MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void linklblRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }

      private void linklblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var guest = new Guest.GuestHome();
         guest.Show();
         Close();
      }
   }
}
