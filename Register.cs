using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Register : Form
   {

      public Register()
      {
         InitializeComponent();
      }

      private void btnSaveRegister_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "INSERT INTO UserInformation(RoleId, Firstname, Lastname, Age, Address, Gender, Email, DateRegistered, Username, Password, ContactNo) VALUES('" + 2 + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + txtAddress.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtContacno.Text +"')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            var login = new Login();
            login.Show();
            Hide();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Close();
      }

      private void Register_Load(object sender, EventArgs e)
      {

      }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//https://app.involve.me/editor/flowers-order-form-d4d8
// 1 column, spacing should be far in each field.