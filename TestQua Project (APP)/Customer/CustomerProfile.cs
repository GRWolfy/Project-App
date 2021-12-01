using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerProfile : Form
   {
      string imageLocation = "";

      public CustomerProfile()
      {
         InitializeComponent();
      }

      private void fieldUpdate(bool status)
      {
         txtFirstname.Enabled = status;
         txtLastname.Enabled = status;
         txtAddress.Enabled = status;
         txtAge.Enabled = status;
         txtContacno.Enabled = status;
         txtEmail.Enabled = status;
         txtConfirmPassword.Enabled = status;
         txtPassword.Enabled = status;
         cmbGender.Enabled = status;
         btnBrowsePicture.Visible = status;
         btnSave.Visible = status;
         btnUpdate.Visible = status ? false : true;
      }

      private void getFields()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE UserId = '" + txtUserid.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               txtFirstname.Text = Function.reader["Firstname"].ToString();
               txtLastname.Text = Function.reader["Lastname"].ToString();
               txtAddress.Text = Function.reader["Address"].ToString();
               txtAge.Text = Function.reader["Age"].ToString();
               txtContacno.Text = Function.reader["Contactno"].ToString();
               txtEmail.Text = Function.reader["Email"].ToString();
               txtUsername.Text = Function.reader["Username"].ToString();
               txtPassword.Text = Function.reader["password"].ToString();
               txtConfirmPassword.Text = Function.reader["password"].ToString();
               cmbGender.Text = Function.reader["Gender"].ToString();
               byte[] img = (byte[])(Function.reader["profilepicture"]);

               if (img == null)
               {
                  pbProfilePicture.Image = null;
               }
               else
               {
                  MemoryStream ms = new MemoryStream(img);
                  pbProfilePicture.Image = Image.FromStream(ms);
                  pbProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
               }
            }

            Connection.con.Close();
            fieldUpdate(false);
         }

         catch (Exception ex)
         {
            //MessageBox.Show(ex.Message);
         }
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }

      private void CustomerDashboard_Load(object sender, EventArgs e)
      {
         btnProfile.FlatStyle = FlatStyle.Standard;
         txtUserid.Text = Login.userid.ToString();
         getFields();
         fieldUpdate(false);
      }

      private void btnLogout_Click_1(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         fieldUpdate(true);
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE Userinformation SET Firstname = '" + txtFirstname.Text + "', Lastname = '" + txtLastname.Text + "', Age = '" + txtAge.Text + "', Address = '" + txtAddress.Text + "', Gender = '" + cmbGender.Text + "', email = '" + txtEmail.Text + "', password = '" + txtPassword.Text + "', contactno = '" + txtContacno.Text + "' WHERE Userid = '" + txtUserid.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Profile Saved");
            Connection.con.Close();
            fieldUpdate(false);
            getFields();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var customerhome = new CustomerHome();
         customerhome.Show();
         Hide();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void btnOrder_Click(object sender, EventArgs e)
      {
         var customerorder = new CustomerOrder();
         customerorder.Show();
         Close();
      }

      private void btnBrowsePicture_Click_1(object sender, EventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               imageLocation = dlg.FileName.ToString();
               pbProfilePicture.ImageLocation = imageLocation;
            }

            pbProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "UPDATE UserInformation SET ProfilePicture = @img WHERE userid = '" + txtUserid.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         if (txtPassword.TextLength < 6)
         {
            lblPassword.Text = "Password must be at least 6 characters.";
         }
         else
         {
            lblPassword.Text = "";
         }
      }

      private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
      {
         if (txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            lblPassword.Text = "Matched";
         }
         else
         {
            lblPassword.Text = "Check password";
         }
      }

      private void txtEmail_TextChanged(object sender, EventArgs e)
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
         }
         else
         {
            lblEmail.Text = "Invalid Email";
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
               lblContactNo.Text = "OK";
            }
            else
            {
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

      private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
         }
      }
   }
}
