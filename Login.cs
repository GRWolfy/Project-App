using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Login : Form
   {
      public static int userid = 0;
      public static int roleid = 0;
      public static string firstname = "";
      public static string lastname = "";

      public Login()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE Username = '"+ txtUsername.Text +"' AND Password = '"+ txtPassword.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if(Function.reader.HasRows){
               Function.reader.Read();
               roleid = Convert.ToInt32(Function.reader["RoleId"]);

               if (roleid == 1){    //Admin
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
               else if(roleid == 2){  //Customer
                  txtUsername.Text = Function.reader["Username"].ToString();
                  txtPassword.Text = Function.reader["Password"].ToString();

                  firstname = Function.reader["Firstname"].ToString();
                  lastname = Function.reader["Lastname"].ToString();
                  userid = Convert.ToInt32(Function.reader["UserId"]);
                  roleid = Convert.ToInt32(Function.reader["RoleId"]);
                  var customerhome = new Customer.CustomerHome();
                  customerhome.Show();
                  Hide();
               }
               else if(roleid == 3){ //Supplier
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
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
