using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminAccounts : Form
   {
      private bool[] isValid = new bool[10];
      private bool checker = false;

      public AdminAccounts()
      {
         InitializeComponent();
      }

      private void dataviewAccounts()
      {
         Connection.DB();
         Function.gen = "SELECT role.rolename as [ROLE NAME], userinformation.userid, userinformation.roleid, userinformation.profilepicture, userinformation.firstname AS [FIRST NAME], userinformation.lastname AS [LAST NAME], userinformation.username AS [USERNAME], userinformation.password AS [PASSWORD], userinformation.age As [AGE], userinformation.contactno AS [CONTACT NO.], userinformation.address AS [ADDRESS], userinformation.gender AS [GENDER], userinformation.email AS [EMAIL], userinformation.dateregistered AS [DATE REGISTERED]  FROM UserInformation INNER JOIN Role ON Role.RoleId = UserInformation.RoleId";
         Function.fill(Function.gen, viewAccounts);
         viewAccounts.Columns["roleid"].Visible = false;
         viewAccounts.Columns["ProfilePicture"].Visible = false;
         viewAccounts.Columns["Userid"].Visible = false;
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         tabcontrolAdminAccounts.Show();
         btnAccounts.FlatStyle = FlatStyle.Standard;
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }

      private void AdminAccounts_Load(object sender, EventArgs e)
      {
         updateButtons(false);
         btnSave.Enabled = true;
         btnAccounts.FlatStyle = FlatStyle.Standard;
         dataviewAccounts();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         Hide();
      }

      private void viewAccounts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         try
         {
            txtUserid.Text = viewAccounts.Rows[e.RowIndex].Cells["userid"].Value.ToString();
            txtRoleId.Text = viewAccounts.Rows[e.RowIndex].Cells["roleid"].Value.ToString();
            txtFirstname.Text = viewAccounts.Rows[e.RowIndex].Cells["FIRST NAME"].Value.ToString();
            txtLastname.Text = viewAccounts.Rows[e.RowIndex].Cells["LAST NAME"].Value.ToString();
            txtAge.Text = viewAccounts.Rows[e.RowIndex].Cells["AGE"].Value.ToString();
            txtAddress.Text = viewAccounts.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString();
            cmbGender.Text = viewAccounts.Rows[e.RowIndex].Cells["GENDER"].Value.ToString();
            txtEmail.Text = viewAccounts.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
            txtUsername.Text = viewAccounts.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString();
            txtPassword.Text = viewAccounts.Rows[e.RowIndex].Cells["PASSWORD"].Value.ToString();
            txtContacno.Text = viewAccounts.Rows[e.RowIndex].Cells["CONTACT NO."].Value.ToString();

            if (txtRoleId.Text.Equals("1"))
            {
               cmbRole.Text = "Admin";
            }
            else if (txtRoleId.Text.Equals("2"))
            {
               cmbRole.Text = "Customer";
            }
            else
            {
               cmbRole.Text = "Supplier";
            }

            updateButtons(true);
            btnSave.Enabled = false;
            tabcontrolAdminAccounts.SelectedIndex = 0;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void updateButtons(bool status)
      {
         btnUpdate.Visible = status;
         btnDelete.Visible = status;
         btnSave.Visible = status ? false : true;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         int roleid = 0;

         if (cmbGender.Text.Equals("Admin"))
         {
            roleid = 1;
         }
         else if (cmbGender.Text.Equals("Customer"))
         {
            roleid = 2;
         }
         else
         {
            roleid = 3;
         }

         for (int i = 0; i < isValid.Length; i++)
         {
            if (isValid[i] == false)
            {
               MessageBox.Show("Please review your inputs" + i.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
               Connection.DB();
               Function.gen = "INSERT INTO UserInformation(RoleId, Firstname, Lastname, Age, Address, Gender, Email, DateRegistered, Username, Password, ContactNo) VALUES('" + roleid + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + txtAddress.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtContacno.Text + "')";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();

               dataviewAccounts();
               updateButtons(false);
               resetFields(0);
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE Userinformation SET Firstname = '" + txtFirstname.Text + "', Lastname = '" + txtLastname.Text + "', Age = '" + txtAge.Text + "', Address = '" + txtAddress.Text + "', Gender = '" + cmbGender.Text + "', email = '" + txtEmail.Text + "', password = '" + txtPassword.Text + "', contactno = '" + txtContacno.Text + "' WHERE Userid = '" + txtUserid.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            updateButtons(false);
            dataviewAccounts();
            resetFields(0);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM UserInformation WHERE UserId = '" + txtUserid.Text + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               updateButtons(false);
               dataviewAccounts();
               resetFields(0);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void resetFields(int index)
      {
         var adminaccount = new AdminAccounts();
         adminaccount.Show();
         adminaccount.tabcontrolAdminAccounts.SelectedIndex = index;
         Close();
      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         try
         {
            Function.gen = "SELECT * FROM UserInformation WHERE UserId LIKE '" + txtSearch.Text + "%' OR FirstName LIKE '" + txtSearch.Text + "%' OR LastName LIKE '" + txtSearch.Text + "%' OR Username LIKE '" + txtSearch.Text + "%' OR Email LIKE '" + txtSearch.Text + "%' OR RoleId LIKE '" + txtSearch.Text + "%' ";
            Function.fill(Function.gen, viewAccounts);
            //dataGridView1.Columns["userid"].Visible = false;
            viewAccounts.Columns["UserId"].Visible = false;
            viewAccounts.Columns["UserId"].Visible = false;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var adminhome = new AdminHome();
         adminhome.Show();
         Close();
      }

      private void btnReports_Click(object sender, EventArgs e)
      {
         var adminreport = new AdminReport();
         adminreport.Show();
         Close();
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

      private void cmbGender_SelectedValueChanged(object sender, EventArgs e)
      {
         isValid[4] = true;
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

      private void cmbRole_SelectedValueChanged(object sender, EventArgs e)
      {
         isValid[9] = true;
      }
   }
}
/*
 DATAGRID 
  -Hide userid
  -Display Role name instead of ID
  -Hide Profile picture
 */