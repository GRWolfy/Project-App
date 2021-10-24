
namespace TestQua_Project__APP_.Admin
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
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.btnProduct = new System.Windows.Forms.Button();
         this.datagridViewProduct = new System.Windows.Forms.DataGridView();
         this.datagridViewcart = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.lblTotalPrice = new System.Windows.Forms.Label();
         this.txtSearchProduct = new System.Windows.Forms.TextBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewcart)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 165);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 493);
         this.flowLayoutPanel1.TabIndex = 1;
         // 
         // btnProduct
         // 
         this.btnProduct.Location = new System.Drawing.Point(35, 0);
         this.btnProduct.Name = "btnProduct";
         this.btnProduct.Size = new System.Drawing.Size(75, 23);
         this.btnProduct.TabIndex = 3;
         this.btnProduct.Text = "add product";
         this.btnProduct.UseVisualStyleBackColor = true;
         this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
         // 
         // datagridViewProduct
         // 
         this.datagridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewProduct.Location = new System.Drawing.Point(12, 46);
         this.datagridViewProduct.Name = "datagridViewProduct";
         this.datagridViewProduct.Size = new System.Drawing.Size(158, 376);
         this.datagridViewProduct.TabIndex = 0;
         // 
         // datagridViewcart
         // 
         this.datagridViewcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewcart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
         this.datagridViewcart.Location = new System.Drawing.Point(198, 12);
         this.datagridViewcart.Name = "datagridViewcart";
         this.datagridViewcart.Size = new System.Drawing.Size(361, 147);
         this.datagridViewcart.TabIndex = 4;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "#";
         this.Column1.Name = "Column1";
         // 
         // Column4
         // 
         this.Column4.HeaderText = "ProductID";
         this.Column4.Name = "Column4";
         this.Column4.Visible = false;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Name";
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Price";
         this.Column3.Name = "Column3";
         // 
         // lblTotalPrice
         // 
         this.lblTotalPrice.AutoSize = true;
         this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalPrice.Location = new System.Drawing.Point(27, 455);
         this.lblTotalPrice.Name = "lblTotalPrice";
         this.lblTotalPrice.Size = new System.Drawing.Size(126, 46);
         this.lblTotalPrice.TabIndex = 5;
         this.lblTotalPrice.Text = "label1";
         // 
         // txtSearchProduct
         // 
         this.txtSearchProduct.Location = new System.Drawing.Point(35, 504);
         this.txtSearchProduct.Name = "txtSearchProduct";
         this.txtSearchProduct.Size = new System.Drawing.Size(100, 20);
         this.txtSearchProduct.TabIndex = 6;
         this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(584, 13);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(480, 135);
         this.dataGridView1.TabIndex = 7;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.txtSearchProduct);
         this.Controls.Add(this.lblTotalPrice);
         this.Controls.Add(this.datagridViewcart);
         this.Controls.Add(this.btnProduct);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.datagridViewProduct);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewProduct";
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewcart)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.Button btnProduct;
      private System.Windows.Forms.DataGridView datagridViewProduct;
      private System.Windows.Forms.DataGridView datagridViewcart;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.Label lblTotalPrice;
      private System.Windows.Forms.TextBox txtSearchProduct;
      private System.Windows.Forms.DataGridView dataGridView1;
   }
}