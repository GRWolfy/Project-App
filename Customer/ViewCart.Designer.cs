
namespace TestQua_Project__APP_.Customer
{
   partial class ViewCart
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
         this.datagridViewCart = new System.Windows.Forms.DataGridView();
         this.btnBack = new System.Windows.Forms.Button();
         this.btnCheckout = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.lblProductName = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtTotalPrice = new System.Windows.Forms.TextBox();
         this.asd = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.label4 = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridViewCart
         // 
         this.datagridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewCart.Location = new System.Drawing.Point(58, 84);
         this.datagridViewCart.Name = "datagridViewCart";
         this.datagridViewCart.Size = new System.Drawing.Size(634, 361);
         this.datagridViewCart.TabIndex = 0;
         this.datagridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewCart_CellContentClick);
         // 
         // btnBack
         // 
         this.btnBack.Location = new System.Drawing.Point(46, 33);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(75, 23);
         this.btnBack.TabIndex = 1;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnCheckout
         // 
         this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCheckout.Location = new System.Drawing.Point(390, 567);
         this.btnCheckout.Name = "btnCheckout";
         this.btnCheckout.Size = new System.Drawing.Size(215, 49);
         this.btnCheckout.TabIndex = 2;
         this.btnCheckout.Text = "Checkout";
         this.btnCheckout.UseVisualStyleBackColor = true;
         this.btnCheckout.Click += new System.EventHandler(this.button2_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDelete.Location = new System.Drawing.Point(519, 481);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(136, 47);
         this.btnDelete.TabIndex = 3;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUpdate.Location = new System.Drawing.Point(324, 481);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(136, 47);
         this.btnUpdate.TabIndex = 4;
         this.btnUpdate.Text = "Update";
         this.btnUpdate.UseVisualStyleBackColor = true;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // lblProductName
         // 
         this.lblProductName.AutoSize = true;
         this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblProductName.Location = new System.Drawing.Point(784, 332);
         this.lblProductName.Name = "lblProductName";
         this.lblProductName.Size = new System.Drawing.Size(92, 36);
         this.lblProductName.TabIndex = 5;
         this.lblProductName.Text = "Name";
         // 
         // txtName
         // 
         this.txtName.Enabled = false;
         this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtName.Location = new System.Drawing.Point(790, 384);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(229, 41);
         this.txtName.TabIndex = 6;
         // 
         // txtTotalPrice
         // 
         this.txtTotalPrice.Enabled = false;
         this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTotalPrice.Location = new System.Drawing.Point(790, 601);
         this.txtTotalPrice.Name = "txtTotalPrice";
         this.txtTotalPrice.Size = new System.Drawing.Size(229, 41);
         this.txtTotalPrice.TabIndex = 8;
         // 
         // asd
         // 
         this.asd.AutoSize = true;
         this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.asd.Location = new System.Drawing.Point(784, 560);
         this.asd.Name = "asd";
         this.asd.Size = new System.Drawing.Size(83, 36);
         this.asd.TabIndex = 7;
         this.asd.Text = "Price";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(784, 454);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(125, 36);
         this.label3.TabIndex = 9;
         this.label3.Text = "Quantity";
         // 
         // numericUpDown_Quantity
         // 
         this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.numericUpDown_Quantity.Location = new System.Drawing.Point(790, 503);
         this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
         this.numericUpDown_Quantity.Size = new System.Drawing.Size(249, 41);
         this.numericUpDown_Quantity.TabIndex = 11;
         this.numericUpDown_Quantity.ValueChanged += new System.EventHandler(this.numericUpDown_Quantity_ValueChanged);
         // 
         // pictureBox
         // 
         this.pictureBox.Location = new System.Drawing.Point(750, 33);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(297, 278);
         this.pictureBox.TabIndex = 12;
         this.pictureBox.TabStop = false;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(14, 573);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(89, 36);
         this.label4.TabIndex = 13;
         this.label4.Text = "Total:";
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(98, 573);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(115, 36);
         this.lblTotal.TabIndex = 14;
         this.lblTotal.Text = "number";
         // 
         // ViewCart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.numericUpDown_Quantity);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtTotalPrice);
         this.Controls.Add(this.asd);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.lblProductName);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCheckout);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.datagridViewCart);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewCart";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewCart";
         this.Load += new System.EventHandler(this.ViewCart_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridViewCart;
      private System.Windows.Forms.Button btnBack;
      private System.Windows.Forms.Button btnCheckout;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Label lblProductName;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.TextBox txtTotalPrice;
      private System.Windows.Forms.Label asd;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblTotal;
   }
}