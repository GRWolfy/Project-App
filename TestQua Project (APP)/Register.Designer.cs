
namespace TestQua_Project__APP_
{
   partial class Register
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
         this.pictureBox6 = new System.Windows.Forms.PictureBox();
         this.pictureBox11 = new System.Windows.Forms.PictureBox();
         this.pictureBox21 = new System.Windows.Forms.PictureBox();
         this.cmbGender = new System.Windows.Forms.ComboBox();
         this.label10 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtAge = new System.Windows.Forms.TextBox();
         this.txtFirstname = new System.Windows.Forms.TextBox();
         this.txtLastname = new System.Windows.Forms.TextBox();
         this.txtAddress = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtConfirmPassword = new System.Windows.Forms.TextBox();
         this.btnBack = new System.Windows.Forms.Button();
         this.btnSaveRegister = new System.Windows.Forms.Button();
         this.label9 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtContacno = new System.Windows.Forms.TextBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.lblUsername = new System.Windows.Forms.Label();
         this.lblPassword = new System.Windows.Forms.Label();
         this.lblEmail = new System.Windows.Forms.Label();
         this.lblContactNo = new System.Windows.Forms.Label();
         this.lblPasswordnum = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox6
         // 
         this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
         this.pictureBox6.Location = new System.Drawing.Point(36, 530);
         this.pictureBox6.Name = "pictureBox6";
         this.pictureBox6.Size = new System.Drawing.Size(47, 52);
         this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox6.TabIndex = 39;
         this.pictureBox6.TabStop = false;
         // 
         // pictureBox11
         // 
         this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
         this.pictureBox11.Location = new System.Drawing.Point(985, 463);
         this.pictureBox11.Name = "pictureBox11";
         this.pictureBox11.Size = new System.Drawing.Size(47, 52);
         this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox11.TabIndex = 44;
         this.pictureBox11.TabStop = false;
         // 
         // pictureBox21
         // 
         this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
         this.pictureBox21.Location = new System.Drawing.Point(1009, 269);
         this.pictureBox21.Name = "pictureBox21";
         this.pictureBox21.Size = new System.Drawing.Size(47, 52);
         this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox21.TabIndex = 55;
         this.pictureBox21.TabStop = false;
         // 
         // cmbGender
         // 
         this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.cmbGender.FormattingEnabled = true;
         this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
         this.cmbGender.Location = new System.Drawing.Point(213, 305);
         this.cmbGender.Name = "cmbGender";
         this.cmbGender.Size = new System.Drawing.Size(121, 33);
         this.cmbGender.TabIndex = 81;
         this.cmbGender.SelectedValueChanged += new System.EventHandler(this.cmbGender_SelectedValueChanged);
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label10.ForeColor = System.Drawing.Color.Black;
         this.label10.Location = new System.Drawing.Point(68, 361);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(133, 29);
         this.label10.TabIndex = 80;
         this.label10.Text = "Contact no.";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label1.ForeColor = System.Drawing.Color.Black;
         this.label1.Location = new System.Drawing.Point(68, 99);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(126, 29);
         this.label1.TabIndex = 62;
         this.label1.Text = "First name";
         // 
         // txtAge
         // 
         this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtAge.Location = new System.Drawing.Point(213, 250);
         this.txtAge.Name = "txtAge";
         this.txtAge.Size = new System.Drawing.Size(58, 30);
         this.txtAge.TabIndex = 71;
         this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
         // 
         // txtFirstname
         // 
         this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtFirstname.Location = new System.Drawing.Point(213, 95);
         this.txtFirstname.Name = "txtFirstname";
         this.txtFirstname.Size = new System.Drawing.Size(232, 30);
         this.txtFirstname.TabIndex = 68;
         this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
         // 
         // txtLastname
         // 
         this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtLastname.Location = new System.Drawing.Point(213, 144);
         this.txtLastname.Name = "txtLastname";
         this.txtLastname.Size = new System.Drawing.Size(232, 30);
         this.txtLastname.TabIndex = 69;
         this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
         // 
         // txtAddress
         // 
         this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtAddress.Location = new System.Drawing.Point(213, 198);
         this.txtAddress.Name = "txtAddress";
         this.txtAddress.Size = new System.Drawing.Size(232, 30);
         this.txtAddress.TabIndex = 70;
         this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
         // 
         // txtPassword
         // 
         this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtPassword.Location = new System.Drawing.Point(684, 209);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(125, 30);
         this.txtPassword.TabIndex = 63;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
         // 
         // txtConfirmPassword
         // 
         this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtConfirmPassword.Location = new System.Drawing.Point(684, 278);
         this.txtConfirmPassword.Name = "txtConfirmPassword";
         this.txtConfirmPassword.Size = new System.Drawing.Size(125, 30);
         this.txtConfirmPassword.TabIndex = 67;
         this.txtConfirmPassword.UseSystemPasswordChar = true;
         this.txtConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyUp);
         // 
         // btnBack
         // 
         this.btnBack.BackColor = System.Drawing.Color.Plum;
         this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.btnBack.ForeColor = System.Drawing.Color.Black;
         this.btnBack.Location = new System.Drawing.Point(12, 35);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(93, 34);
         this.btnBack.TabIndex = 83;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = false;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
         // 
         // btnSaveRegister
         // 
         this.btnSaveRegister.BackColor = System.Drawing.Color.Plum;
         this.btnSaveRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnSaveRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.btnSaveRegister.Location = new System.Drawing.Point(755, 419);
         this.btnSaveRegister.Name = "btnSaveRegister";
         this.btnSaveRegister.Size = new System.Drawing.Size(145, 40);
         this.btnSaveRegister.TabIndex = 82;
         this.btnSaveRegister.Text = "Register";
         this.btnSaveRegister.UseVisualStyleBackColor = false;
         this.btnSaveRegister.Click += new System.EventHandler(this.btnSaveRegister_Click_1);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label9.ForeColor = System.Drawing.Color.Black;
         this.label9.Location = new System.Drawing.Point(68, 148);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(123, 29);
         this.label9.TabIndex = 79;
         this.label9.Text = "Last name";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label8.ForeColor = System.Drawing.Color.Black;
         this.label8.Location = new System.Drawing.Point(68, 313);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(94, 29);
         this.label8.TabIndex = 78;
         this.label8.Text = "Gender";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label7.ForeColor = System.Drawing.Color.Black;
         this.label7.Location = new System.Drawing.Point(68, 250);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(56, 29);
         this.label7.TabIndex = 77;
         this.label7.Text = "Age";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label6.ForeColor = System.Drawing.Color.Black;
         this.label6.Location = new System.Drawing.Point(68, 202);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(102, 29);
         this.label6.TabIndex = 76;
         this.label6.Text = "Address";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label5.ForeColor = System.Drawing.Color.Black;
         this.label5.Location = new System.Drawing.Point(68, 415);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(74, 29);
         this.label5.TabIndex = 75;
         this.label5.Text = "Email";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(534, 148);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(124, 29);
         this.label4.TabIndex = 74;
         this.label4.Text = "Username";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(504, 211);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(181, 29);
         this.label3.TabIndex = 73;
         this.label3.Text = "Enter password";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(468, 278);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(208, 29);
         this.label2.TabIndex = 72;
         this.label2.Text = "Confirm password";
         // 
         // txtContacno
         // 
         this.txtContacno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtContacno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtContacno.Location = new System.Drawing.Point(213, 357);
         this.txtContacno.Name = "txtContacno";
         this.txtContacno.Size = new System.Drawing.Size(232, 30);
         this.txtContacno.TabIndex = 66;
         this.txtContacno.TextChanged += new System.EventHandler(this.txtContacno_TextChanged);
         // 
         // txtEmail
         // 
         this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtEmail.Location = new System.Drawing.Point(213, 415);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(232, 30);
         this.txtEmail.TabIndex = 65;
         this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
         // 
         // txtUsername
         // 
         this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.txtUsername.Location = new System.Drawing.Point(684, 147);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(125, 30);
         this.txtUsername.TabIndex = 64;
         this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
         // 
         // lblUsername
         // 
         this.lblUsername.AutoSize = true;
         this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
         this.lblUsername.Location = new System.Drawing.Point(815, 159);
         this.lblUsername.Name = "lblUsername";
         this.lblUsername.Size = new System.Drawing.Size(20, 17);
         this.lblUsername.TabIndex = 84;
         this.lblUsername.Text = "...";
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
         this.lblPassword.Location = new System.Drawing.Point(815, 220);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(20, 17);
         this.lblPassword.TabIndex = 85;
         this.lblPassword.Text = "...";
         // 
         // lblEmail
         // 
         this.lblEmail.AutoSize = true;
         this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
         this.lblEmail.Location = new System.Drawing.Point(451, 425);
         this.lblEmail.Name = "lblEmail";
         this.lblEmail.Size = new System.Drawing.Size(20, 17);
         this.lblEmail.TabIndex = 86;
         this.lblEmail.Text = "...";
         // 
         // lblContactNo
         // 
         this.lblContactNo.AutoSize = true;
         this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
         this.lblContactNo.Location = new System.Drawing.Point(451, 373);
         this.lblContactNo.Name = "lblContactNo";
         this.lblContactNo.Size = new System.Drawing.Size(20, 17);
         this.lblContactNo.TabIndex = 87;
         this.lblContactNo.Text = "...";
         // 
         // lblPasswordnum
         // 
         this.lblPasswordnum.AutoSize = true;
         this.lblPasswordnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
         this.lblPasswordnum.ForeColor = System.Drawing.Color.Red;
         this.lblPasswordnum.Location = new System.Drawing.Point(691, 242);
         this.lblPasswordnum.Name = "lblPasswordnum";
         this.lblPasswordnum.Size = new System.Drawing.Size(0, 17);
         this.lblPasswordnum.TabIndex = 88;
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.ClientSize = new System.Drawing.Size(986, 538);
         this.Controls.Add(this.lblPasswordnum);
         this.Controls.Add(this.lblContactNo);
         this.Controls.Add(this.lblEmail);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.lblUsername);
         this.Controls.Add(this.cmbGender);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtAge);
         this.Controls.Add(this.txtFirstname);
         this.Controls.Add(this.txtLastname);
         this.Controls.Add(this.txtAddress);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtConfirmPassword);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.btnSaveRegister);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtContacno);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.pictureBox21);
         this.Controls.Add(this.pictureBox11);
         this.Controls.Add(this.pictureBox6);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Register";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Register                                                                         " +
    "     ";
         this.Load += new System.EventHandler(this.Register_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.PictureBox pictureBox6;
      private System.Windows.Forms.PictureBox pictureBox11;
      private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveRegister;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContacno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.Label lblUsername;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.Label lblEmail;
      private System.Windows.Forms.Label lblContactNo;
      private System.Windows.Forms.Label lblPasswordnum;
   }
}