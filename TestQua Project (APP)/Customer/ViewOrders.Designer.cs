﻿
namespace TestQua_Project__APP_.Customer
{
   partial class ViewOrders
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
         this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
         this.button1 = new System.Windows.Forms.Button();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridViewOrder
         // 
         this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
         this.dataGridViewOrder.Location = new System.Drawing.Point(41, 49);
         this.dataGridViewOrder.Name = "dataGridViewOrder";
         this.dataGridViewOrder.Size = new System.Drawing.Size(588, 333);
         this.dataGridViewOrder.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(41, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // Column1
         // 
         this.Column1.HeaderText = "No.";
         this.Column1.Name = "Column1";
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Product Name";
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Quantity";
         this.Column3.Name = "Column3";
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Total";
         this.Column4.Name = "Column4";
         // 
         // ViewOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(712, 558);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dataGridViewOrder);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewOrders";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewOrders";
         this.Load += new System.EventHandler(this.ViewOrders_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridViewOrder;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
   }
}