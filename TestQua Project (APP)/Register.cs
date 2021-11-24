using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Register : Form
   {
      private bool[] isValid = new bool[9];
      private bool checker = false;

      public Register()
      {
         InitializeComponent();
      }

      private void Register_Load(object sender, EventArgs e)
      {

      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void btnSaveRegister_Click_1(object sender, EventArgs e)
      {
         try
         {
            for (int i = 0; i < isValid.Length; i++)
            {
               if (isValid[i] == false)
               {
                  MessageBox.Show("Please review your inputs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  checker = false;
                  break;
               }
               else if (isValid[i] == true && i == isValid.Length - 1)
               {
                  checker = true;
               }
            }

            if (checker)
            {
               Connection.DB();
               Function.gen = "INSERT INTO UserInformation(RoleId, Firstname, Lastname, Age, Address, Gender, Email, DateRegistered, Username, Password, ContactNo) VALUES('" + 2 + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + txtAddress.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtContacno.Text + "')";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();
               var login = new Login();
               login.Show();
               Hide();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnBack_Click_1(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Close();
      }

      //Age inputs only integerrs
      private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
            isValid[3] = false;
         }
         else
         {
            isValid[3] = true;
         }
      }

      public bool IsValidEmail(string email)
      {
         try
         {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
         }
         catch
         {
            return false;
         }
      }



      private void txtUsername_KeyUp(object sender, KeyEventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE username = '" + txtUsername.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               lblUsername.Text = "Username already exist";
               isValid[7] = false;
            }
            else
            {
               lblUsername.Text = "Username available";
               isValid[7] = true;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txtPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if (txtPassword.TextLength < 6)
         {
            lblPasswordnum.Text = "Password must be at least 6 characters.";
         }
         else
         {
            lblPasswordnum.Text = "";
         }
      }

      private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if (txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            lblPassword.Text = "Matched";
            isValid[8] = true;
         }
         else
         {
            lblPassword.Text = "Check password";
            isValid[8] = false;
         }
      }

      private void txtEmail_KeyUp(object sender, KeyEventArgs e)
      {
         bool check = false;
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE email = '" + txtEmail.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               check = false;
            }
            else
            {
               check = true;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

         if (IsValidEmail(txtEmail.Text) && check)
         {
            lblEmail.Text = "OK";
            isValid[6] = true;
         }
         else
         {
            lblEmail.Text = "Invalid Email";
            isValid[6] = false;
         }
      }

      private void cmbGender_SelectedValueChanged(object sender, EventArgs e)
      {
         isValid[4] = true;
      }

      private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtFirstname.Text == null)
         {
            isValid[0] = false;
         }
         else
         {
            isValid[0] = true;
         }
      }

      private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtLastname.Text == null)
         {
            isValid[1] = false;
         }
         else
         {
            isValid[1] = true;
         }
      }

      private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (txtAddress.Text == null)
         {
            isValid[2] = false;
         }
         else
         {
            isValid[2] = true;
         }
      }

      private void txtContacno_TextChanged(object sender, EventArgs e)
      {
         bool check = false;

         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE username = '" + txtUsername.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               check = false;
            }
            else
            {
               check = true;
            }

            if (isPHoneNumber(txtContacno.Text))
            {
               isValid[5] = true;
               lblContactNo.Text = "OK";
            }
            else
            {
               isValid[5] = false;
               lblContactNo.Text = "Invalid number";
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private bool isPHoneNumber(string number)
      {
         return isDigit(number) && number.Length == 11;
      }

      private bool isDigit(string number)
      {
         foreach (char n in number)
         {
            if (n < '0' || n > '9')
            {
               return false;
            }
         }

         return true;
      }
   }
}