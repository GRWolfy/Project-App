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

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminAccounts : Form
   {
      public AdminAccounts()
      {
         InitializeComponent();
      }

      private void dataviewAccounts() 
      {
         Connection.DB();
         Function.gen = "SELECT * FROM UserInformation";
         Function.fill(Function.gen, viewAccounts);
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
            txtUserid.Text = viewAccounts[0, e.RowIndex].Value.ToString();
            txtRoleId.Text = viewAccounts[1, e.RowIndex].Value.ToString();
            txtFirstname.Text = viewAccounts[2, e.RowIndex].Value.ToString();
            txtLastname.Text = viewAccounts[3, e.RowIndex].Value.ToString();
            txtAge.Text = viewAccounts[4, e.RowIndex].Value.ToString();
            txtAddress.Text = viewAccounts[5, e.RowIndex].Value.ToString();
            cmbGender.Text = viewAccounts[6, e.RowIndex].Value.ToString(); 
            txtEmail.Text = viewAccounts[7, e.RowIndex].Value.ToString();
            txtUsername.Text = viewAccounts[9, e.RowIndex].Value.ToString();
            txtPassword.Text = viewAccounts[10, e.RowIndex].Value.ToString();
            txtContacno.Text = viewAccounts[11, e.RowIndex].Value.ToString();

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
         btnUpdate.Enabled = status;
         btnDelete.Enabled = status;

         if (status == false)
            btnSave.Enabled = true;
         else
            btnSave.Enabled = false;
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

         try
         {
            Connection.DB();
            Function.gen = "INSERT INTO UserInformation(RoleId, Firstname, Lastname, Age, Address, Gender, Email, DateRegistered, Username, Password, ContactNo) VALUES('" + roleid + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + txtAddress.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtContacno.Text + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();

            dataviewAccounts();
            resetFields();
            updateButtons(false);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE Userinformation SET Firstname = '" + txtFirstname.Text + "', Lastname = '" + txtLastname.Text + "', Age = '" + txtAge.Text + "', Address = '" + txtAddress.Text + "', Gender = '" + cmbGender.Text + "', email = '" + txtEmail.Text + "', password = '" + txtPassword.Text + "', contactno = '"+ txtContacno.Text +"' WHERE Userid = '"+ txtUserid.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            updateButtons(false);
            resetFields();
            dataviewAccounts();
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
               resetFields();
               dataviewAccounts();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void resetFields()
      {
         txtRoleId.Clear();
         txtUserid.Clear();
         txtFirstname.Clear();
         txtLastname.Clear();
         txtAddress.Clear();
         txtAge.Clear();
         txtContacno.Clear();
         txtEmail.Clear();
         txtUsername.Clear();
         txtPassword.Clear();
         txtConfirmPassword.Clear();

      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         try
         {
            Function.gen = "SELECT * FROM UserInformation WHERE UserId LIKE '" + txtSearch.Text + "%' OR FirstName LIKE '" + txtSearch.Text + "%' OR LastName LIKE '" + txtSearch.Text + "%' OR Username LIKE '" + txtSearch.Text + "%' OR Email LIKE '" + txtSearch.Text + "%' OR RoleId LIKE '" + txtSearch.Text + "%' ";
            Function.fill(Function.gen, viewAccounts);
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
   }
}
