﻿
namespace TestQua_Project__APP_.Customer
{
   partial class ViewProduct
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
         this.btnClose = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.btnAddtoCart = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.txtDescription = new System.Windows.Forms.RichTextBox();
         this.btnPlus = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.btnMinus = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.txtQuantity = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.lblQuantity = new System.Windows.Forms.Label();
         this.lblPrice = new System.Windows.Forms.Label();
         this.lblName = new System.Windows.Forms.Label();
         this.pictureboxProductPic = new System.Windows.Forms.PictureBox();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).BeginInit();
         this.SuspendLayout();
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.Plum;
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.btnClose.Location = new System.Drawing.Point(12, 12);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(99, 47);
         this.btnClose.TabIndex = 44;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(904, 590);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 46;
         this.button2.Text = "Add to cart";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // btnAddtoCart
         // 
         this.btnAddtoCart.BackColor = System.Drawing.Color.Plum;
         this.btnAddtoCart.FlatAppearance.BorderSize = 0;
         this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.btnAddtoCart.Location = new System.Drawing.Point(58, 454);
         this.btnAddtoCart.Name = "btnAddtoCart";
         this.btnAddtoCart.Size = new System.Drawing.Size(170, 31);
         this.btnAddtoCart.TabIndex = 61;
         this.btnAddtoCart.Text = "Add to cart";
         this.btnAddtoCart.UseVisualStyleBackColor = false;
         this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.panel2.Controls.Add(this.txtDescription);
         this.panel2.Controls.Add(this.btnPlus);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Controls.Add(this.btnMinus);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.txtQuantity);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.label1);
         this.panel2.Controls.Add(this.lblQuantity);
         this.panel2.Controls.Add(this.lblPrice);
         this.panel2.Controls.Add(this.lblName);
         this.panel2.Location = new System.Drawing.Point(309, 26);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(387, 496);
         this.panel2.TabIndex = 62;
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
         this.txtDescription.Location = new System.Drawing.Point(31, 138);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.ReadOnly = true;
         this.txtDescription.Size = new System.Drawing.Size(336, 135);
         this.txtDescription.TabIndex = 98;
         this.txtDescription.Text = "";
         // 
         // btnPlus
         // 
         this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPlus.Location = new System.Drawing.Point(253, 432);
         this.btnPlus.Name = "btnPlus";
         this.btnPlus.Size = new System.Drawing.Size(39, 31);
         this.btnPlus.TabIndex = 97;
         this.btnPlus.Text = "+";
         this.btnPlus.UseVisualStyleBackColor = true;
         this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(25, 357);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(116, 31);
         this.label4.TabIndex = 69;
         this.label4.Text = "Quantiy:";
         // 
         // btnMinus
         // 
         this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMinus.Location = new System.Drawing.Point(103, 432);
         this.btnMinus.Name = "btnMinus";
         this.btnMinus.Size = new System.Drawing.Size(39, 31);
         this.btnMinus.TabIndex = 96;
         this.btnMinus.Text = "-";
         this.btnMinus.UseVisualStyleBackColor = true;
         this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(25, 297);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(84, 31);
         this.label3.TabIndex = 68;
         this.label3.Text = "Price:";
         // 
         // txtQuantity
         // 
         this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtQuantity.Location = new System.Drawing.Point(148, 432);
         this.txtQuantity.Name = "txtQuantity";
         this.txtQuantity.Size = new System.Drawing.Size(100, 32);
         this.txtQuantity.TabIndex = 95;
         this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(24, 104);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(159, 31);
         this.label2.TabIndex = 67;
         this.label2.Text = "Description:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Black;
         this.label1.Location = new System.Drawing.Point(25, 20);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(195, 31);
         this.label1.TabIndex = 66;
         this.label1.Text = "Product Name:";
         // 
         // lblQuantity
         // 
         this.lblQuantity.AutoSize = true;
         this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.lblQuantity.ForeColor = System.Drawing.Color.Black;
         this.lblQuantity.Location = new System.Drawing.Point(147, 360);
         this.lblQuantity.Name = "lblQuantity";
         this.lblQuantity.Size = new System.Drawing.Size(100, 29);
         this.lblQuantity.TabIndex = 65;
         this.lblQuantity.Text = "Quantity";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.lblPrice.ForeColor = System.Drawing.Color.Black;
         this.lblPrice.Location = new System.Drawing.Point(104, 300);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(69, 29);
         this.lblPrice.TabIndex = 64;
         this.lblPrice.Text = "Price";
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
         this.lblName.ForeColor = System.Drawing.Color.Black;
         this.lblName.Location = new System.Drawing.Point(26, 63);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(78, 29);
         this.lblName.TabIndex = 63;
         this.lblName.Text = "Name";
         // 
         // pictureboxProductPic
         // 
         this.pictureboxProductPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxProductPic.Image")));
         this.pictureboxProductPic.Location = new System.Drawing.Point(25, 113);
         this.pictureboxProductPic.Name = "pictureboxProductPic";
         this.pictureboxProductPic.Size = new System.Drawing.Size(264, 299);
         this.pictureboxProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureboxProductPic.TabIndex = 86;
         this.pictureboxProductPic.TabStop = false;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.ClientSize = new System.Drawing.Size(742, 559);
         this.Controls.Add(this.pictureboxProductPic);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.btnAddtoCart);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnClose);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button btnAddtoCart;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label lblQuantity;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureboxProductPic;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnPlus;
      private System.Windows.Forms.Button btnMinus;
      private System.Windows.Forms.TextBox txtQuantity;
      private System.Windows.Forms.RichTextBox txtDescription;
   }
}