
namespace TestQua_Project__APP_.Admin
{
   partial class AdminProduct
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProduct));
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.datagridViewProduct = new System.Windows.Forms.DataGridView();
         this.txtSearch = new System.Windows.Forms.TextBox();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnHome = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label4 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label7 = new System.Windows.Forms.Label();
         this.txtProductId = new System.Windows.Forms.TextBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.btnUpdatePic = new System.Windows.Forms.Button();
         this.pictureboxProductPic = new System.Windows.Forms.PictureBox();
         this.label6 = new System.Windows.Forms.Label();
         this.txtPrice = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtProductDescription = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtProductName = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtQuantity = new System.Windows.Forms.TextBox();
         this.tabcontrolAdminProducts = new System.Windows.Forms.TabControl();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.tabPage4 = new System.Windows.Forms.TabPage();
         this.btnLogout = new System.Windows.Forms.Button();
         this.btnProducts = new System.Windows.Forms.Button();
         this.btnReports = new System.Windows.Forms.Button();
         this.btnAccounts = new System.Windows.Forms.Button();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).BeginInit();
         this.panel1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).BeginInit();
         this.tabcontrolAdminProducts.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.datagridViewProduct);
         this.tabPage2.Controls.Add(this.txtSearch);
         this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(891, 493);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "View Products";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // datagridViewProduct
         // 
         this.datagridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewProduct.Location = new System.Drawing.Point(0, 42);
         this.datagridViewProduct.Name = "datagridViewProduct";
         this.datagridViewProduct.Size = new System.Drawing.Size(891, 453);
         this.datagridViewProduct.TabIndex = 66;
         this.datagridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewProduct_CellContentClick);
         // 
         // txtSearch
         // 
         this.txtSearch.Location = new System.Drawing.Point(223, 7);
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Size = new System.Drawing.Size(100, 29);
         this.txtSearch.TabIndex = 65;
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(763, 420);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(89, 31);
         this.btnDelete.TabIndex = 62;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(668, 419);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(89, 31);
         this.btnUpdate.TabIndex = 61;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(569, 419);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(89, 31);
         this.btnSave.TabIndex = 60;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnHome
         // 
         this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnHome.FlatAppearance.BorderSize = 0;
         this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnHome.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
         this.btnHome.ForeColor = System.Drawing.Color.White;
         this.btnHome.Location = new System.Drawing.Point(11, 135);
         this.btnHome.Name = "btnHome";
         this.btnHome.Size = new System.Drawing.Size(167, 64);
         this.btnHome.TabIndex = 47;
         this.btnHome.Text = "Home";
         this.btnHome.UseVisualStyleBackColor = false;
         this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Location = new System.Drawing.Point(-1, -1);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1089, 73);
         this.panel1.TabIndex = 41;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(224)))));
         this.label4.Location = new System.Drawing.Point(56, 47);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(212, 18);
         this.label4.TabIndex = 9;
         this.label4.Text = "A Group of TEAM POWER";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(224)))));
         this.label2.Location = new System.Drawing.Point(50, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(251, 51);
         this.label2.TabIndex = 0;
         this.label2.Text = "Bloom and Puff";
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.Color.LightGray;
         this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.tabPage1.Controls.Add(this.label7);
         this.tabPage1.Controls.Add(this.txtProductId);
         this.tabPage1.Controls.Add(this.btnBrowse);
         this.tabPage1.Controls.Add(this.btnUpdatePic);
         this.tabPage1.Controls.Add(this.pictureboxProductPic);
         this.tabPage1.Controls.Add(this.label6);
         this.tabPage1.Controls.Add(this.txtPrice);
         this.tabPage1.Controls.Add(this.label3);
         this.tabPage1.Controls.Add(this.txtProductDescription);
         this.tabPage1.Controls.Add(this.label1);
         this.tabPage1.Controls.Add(this.txtProductName);
         this.tabPage1.Controls.Add(this.btnDelete);
         this.tabPage1.Controls.Add(this.btnUpdate);
         this.tabPage1.Controls.Add(this.btnSave);
         this.tabPage1.Controls.Add(this.label5);
         this.tabPage1.Controls.Add(this.txtQuantity);
         this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(891, 493);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Manage Product";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(432, 72);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(97, 24);
         this.label7.TabIndex = 73;
         this.label7.Text = "Product ID";
         this.label7.Visible = false;
         // 
         // txtProductId
         // 
         this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProductId.Location = new System.Drawing.Point(606, 70);
         this.txtProductId.Name = "txtProductId";
         this.txtProductId.Size = new System.Drawing.Size(125, 26);
         this.txtProductId.TabIndex = 72;
         this.txtProductId.Visible = false;
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(150, 379);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(89, 31);
         this.btnBrowse.TabIndex = 71;
         this.btnBrowse.Text = "Browse";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // btnUpdatePic
         // 
         this.btnUpdatePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUpdatePic.Location = new System.Drawing.Point(262, 379);
         this.btnUpdatePic.Name = "btnUpdatePic";
         this.btnUpdatePic.Size = new System.Drawing.Size(89, 31);
         this.btnUpdatePic.TabIndex = 70;
         this.btnUpdatePic.Text = "Update Pic";
         this.btnUpdatePic.UseVisualStyleBackColor = true;
         this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
         // 
         // pictureboxProductPic
         // 
         this.pictureboxProductPic.Location = new System.Drawing.Point(71, 80);
         this.pictureboxProductPic.Name = "pictureboxProductPic";
         this.pictureboxProductPic.Size = new System.Drawing.Size(280, 281);
         this.pictureboxProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureboxProductPic.TabIndex = 69;
         this.pictureboxProductPic.TabStop = false;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(432, 230);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(53, 24);
         this.label6.TabIndex = 68;
         this.label6.Text = "Price";
         // 
         // txtPrice
         // 
         this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrice.Location = new System.Drawing.Point(606, 228);
         this.txtPrice.Name = "txtPrice";
         this.txtPrice.Size = new System.Drawing.Size(125, 26);
         this.txtPrice.TabIndex = 67;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(432, 120);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(131, 24);
         this.label3.TabIndex = 66;
         this.label3.Text = "Product Name";
         // 
         // txtProductDescription
         // 
         this.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProductDescription.Location = new System.Drawing.Point(606, 174);
         this.txtProductDescription.Name = "txtProductDescription";
         this.txtProductDescription.Size = new System.Drawing.Size(125, 26);
         this.txtProductDescription.TabIndex = 65;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(432, 176);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(104, 24);
         this.label1.TabIndex = 64;
         this.label1.Text = "Description";
         // 
         // txtProductName
         // 
         this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProductName.Location = new System.Drawing.Point(606, 118);
         this.txtProductName.Name = "txtProductName";
         this.txtProductName.Size = new System.Drawing.Size(125, 26);
         this.txtProductName.TabIndex = 63;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(432, 282);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(78, 24);
         this.label5.TabIndex = 40;
         this.label5.Text = "Quantity";
         // 
         // txtQuantity
         // 
         this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtQuantity.Location = new System.Drawing.Point(606, 280);
         this.txtQuantity.Name = "txtQuantity";
         this.txtQuantity.Size = new System.Drawing.Size(125, 26);
         this.txtQuantity.TabIndex = 34;
         // 
         // tabcontrolAdminProducts
         // 
         this.tabcontrolAdminProducts.Controls.Add(this.tabPage1);
         this.tabcontrolAdminProducts.Controls.Add(this.tabPage2);
         this.tabcontrolAdminProducts.Controls.Add(this.tabPage3);
         this.tabcontrolAdminProducts.Controls.Add(this.tabPage4);
         this.tabcontrolAdminProducts.Location = new System.Drawing.Point(175, 135);
         this.tabcontrolAdminProducts.Name = "tabcontrolAdminProducts";
         this.tabcontrolAdminProducts.SelectedIndex = 0;
         this.tabcontrolAdminProducts.Size = new System.Drawing.Size(899, 519);
         this.tabcontrolAdminProducts.TabIndex = 46;
         // 
         // tabPage3
         // 
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(891, 493);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Add Supply";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // tabPage4
         // 
         this.tabPage4.Location = new System.Drawing.Point(4, 22);
         this.tabPage4.Name = "tabPage4";
         this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage4.Size = new System.Drawing.Size(891, 493);
         this.tabPage4.TabIndex = 3;
         this.tabPage4.Text = "View Supply";
         this.tabPage4.UseVisualStyleBackColor = true;
         // 
         // btnLogout
         // 
         this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnLogout.FlatAppearance.BorderSize = 0;
         this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLogout.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
         this.btnLogout.ForeColor = System.Drawing.Color.White;
         this.btnLogout.Location = new System.Drawing.Point(2, 472);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(167, 64);
         this.btnLogout.TabIndex = 45;
         this.btnLogout.Text = "Logout";
         this.btnLogout.UseVisualStyleBackColor = false;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // btnProducts
         // 
         this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnProducts.FlatAppearance.BorderSize = 0;
         this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnProducts.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
         this.btnProducts.ForeColor = System.Drawing.Color.White;
         this.btnProducts.Location = new System.Drawing.Point(2, 307);
         this.btnProducts.Name = "btnProducts";
         this.btnProducts.Size = new System.Drawing.Size(167, 64);
         this.btnProducts.TabIndex = 43;
         this.btnProducts.Text = "Products";
         this.btnProducts.UseVisualStyleBackColor = false;
         this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
         // 
         // btnReports
         // 
         this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnReports.FlatAppearance.BorderSize = 0;
         this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnReports.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
         this.btnReports.ForeColor = System.Drawing.Color.White;
         this.btnReports.Location = new System.Drawing.Point(2, 391);
         this.btnReports.Name = "btnReports";
         this.btnReports.Size = new System.Drawing.Size(167, 64);
         this.btnReports.TabIndex = 44;
         this.btnReports.Text = "Reports";
         this.btnReports.UseVisualStyleBackColor = false;
         this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
         // 
         // btnAccounts
         // 
         this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.btnAccounts.FlatAppearance.BorderSize = 0;
         this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAccounts.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
         this.btnAccounts.ForeColor = System.Drawing.Color.White;
         this.btnAccounts.Location = new System.Drawing.Point(2, 219);
         this.btnAccounts.Name = "btnAccounts";
         this.btnAccounts.Size = new System.Drawing.Size(167, 64);
         this.btnAccounts.TabIndex = 42;
         this.btnAccounts.Text = "Accounts";
         this.btnAccounts.UseVisualStyleBackColor = false;
         this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
         // 
         // AdminProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.btnHome);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.tabcontrolAdminProducts);
         this.Controls.Add(this.btnLogout);
         this.Controls.Add(this.btnProducts);
         this.Controls.Add(this.btnReports);
         this.Controls.Add(this.btnAccounts);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "AdminProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AdminProduct";
         this.Load += new System.EventHandler(this.AdminProduct_Load);
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).EndInit();
         this.tabcontrolAdminProducts.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnHome;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtQuantity;
      private System.Windows.Forms.TabControl tabcontrolAdminProducts;
      private System.Windows.Forms.Button btnLogout;
      private System.Windows.Forms.Button btnProducts;
      private System.Windows.Forms.Button btnReports;
      private System.Windows.Forms.Button btnAccounts;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox txtPrice;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtProductDescription;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtProductName;
      private System.Windows.Forms.PictureBox pictureboxProductPic;
      private System.Windows.Forms.Button btnUpdatePic;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.TextBox txtProductId;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtSearch;
      private System.Windows.Forms.DataGridView datagridViewProduct;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.TabPage tabPage4;
   }
}