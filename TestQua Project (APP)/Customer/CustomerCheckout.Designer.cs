﻿
namespace TestQua_Project__APP_.Customer
{
   partial class CustomerCheckout
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
         this.dataGridView = new System.Windows.Forms.DataGridView();
         this.button1 = new System.Windows.Forms.Button();
         this.lblTotalpayment = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblSubtotal = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.lblDeliveryfee = new System.Windows.Forms.Label();
         this.btnPlaceOrder = new System.Windows.Forms.Button();
         this.lblFullName = new System.Windows.Forms.Label();
         this.lblContactnumber = new System.Windows.Forms.Label();
         this.lblAddress = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView
         // 
         this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView.Location = new System.Drawing.Point(74, 70);
         this.dataGridView.Name = "dataGridView";
         this.dataGridView.Size = new System.Drawing.Size(431, 473);
         this.dataGridView.TabIndex = 60;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(44, 12);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 61;
         this.button1.Text = "Back";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // lblTotalpayment
         // 
         this.lblTotalpayment.AutoSize = true;
         this.lblTotalpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalpayment.ForeColor = System.Drawing.Color.White;
         this.lblTotalpayment.Location = new System.Drawing.Point(816, 214);
         this.lblTotalpayment.Name = "lblTotalpayment";
         this.lblTotalpayment.Size = new System.Drawing.Size(115, 36);
         this.lblTotalpayment.TabIndex = 62;
         this.lblTotalpayment.Text = "number";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(573, 214);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(212, 36);
         this.label2.TabIndex = 63;
         this.label2.Text = "Total Payment:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(573, 91);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(245, 36);
         this.label3.TabIndex = 65;
         this.label3.Text = "Product Subtotal:";
         // 
         // lblSubtotal
         // 
         this.lblSubtotal.AutoSize = true;
         this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSubtotal.ForeColor = System.Drawing.Color.White;
         this.lblSubtotal.Location = new System.Drawing.Point(816, 91);
         this.lblSubtotal.Name = "lblSubtotal";
         this.lblSubtotal.Size = new System.Drawing.Size(115, 36);
         this.lblSubtotal.TabIndex = 64;
         this.lblSubtotal.Text = "number";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(573, 148);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(188, 36);
         this.label5.TabIndex = 67;
         this.label5.Text = "Delivery Fee:";
         // 
         // lblDeliveryfee
         // 
         this.lblDeliveryfee.AutoSize = true;
         this.lblDeliveryfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDeliveryfee.ForeColor = System.Drawing.Color.White;
         this.lblDeliveryfee.Location = new System.Drawing.Point(816, 148);
         this.lblDeliveryfee.Name = "lblDeliveryfee";
         this.lblDeliveryfee.Size = new System.Drawing.Size(115, 36);
         this.lblDeliveryfee.TabIndex = 66;
         this.lblDeliveryfee.Text = "number";
         // 
         // btnPlaceOrder
         // 
         this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPlaceOrder.Location = new System.Drawing.Point(802, 563);
         this.btnPlaceOrder.Name = "btnPlaceOrder";
         this.btnPlaceOrder.Size = new System.Drawing.Size(215, 49);
         this.btnPlaceOrder.TabIndex = 15;
         this.btnPlaceOrder.Text = "Place Order";
         this.btnPlaceOrder.UseVisualStyleBackColor = true;
         this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
         // 
         // lblFullName
         // 
         this.lblFullName.AutoSize = true;
         this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFullName.ForeColor = System.Drawing.Color.White;
         this.lblFullName.Location = new System.Drawing.Point(183, 9);
         this.lblFullName.Name = "lblFullName";
         this.lblFullName.Size = new System.Drawing.Size(136, 36);
         this.lblFullName.TabIndex = 68;
         this.lblFullName.Text = "Fullname";
         // 
         // lblContactnumber
         // 
         this.lblContactnumber.AutoSize = true;
         this.lblContactnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblContactnumber.ForeColor = System.Drawing.Color.White;
         this.lblContactnumber.Location = new System.Drawing.Point(375, 9);
         this.lblContactnumber.Name = "lblContactnumber";
         this.lblContactnumber.Size = new System.Drawing.Size(225, 36);
         this.lblContactnumber.TabIndex = 69;
         this.lblContactnumber.Text = "Contact number";
         // 
         // lblAddress
         // 
         this.lblAddress.AutoSize = true;
         this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAddress.ForeColor = System.Drawing.Color.White;
         this.lblAddress.Location = new System.Drawing.Point(641, 12);
         this.lblAddress.Name = "lblAddress";
         this.lblAddress.Size = new System.Drawing.Size(126, 36);
         this.lblAddress.TabIndex = 70;
         this.lblAddress.Text = "Address";
         // 
         // CustomerCheckout
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.lblAddress);
         this.Controls.Add(this.lblContactnumber);
         this.Controls.Add(this.lblFullName);
         this.Controls.Add(this.btnPlaceOrder);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.lblDeliveryfee);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.lblSubtotal);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lblTotalpayment);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dataGridView);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "CustomerCheckout";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "CustomerCheckout";
         this.Load += new System.EventHandler(this.CustomerCheckout_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.DataGridView dataGridView;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label lblTotalpayment;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblSubtotal;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblDeliveryfee;
      private System.Windows.Forms.Button btnPlaceOrder;
      private System.Windows.Forms.Label lblFullName;
      private System.Windows.Forms.Label lblContactnumber;
      private System.Windows.Forms.Label lblAddress;
   }
}