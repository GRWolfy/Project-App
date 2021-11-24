
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.btnBack = new System.Windows.Forms.Button();
         this.btnCheckout = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.lblProductName = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtTotalPrice = new System.Windows.Forms.TextBox();
         this.asd = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.label4 = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.datagridViewCart = new System.Windows.Forms.DataGridView();
         this.btnPlus = new System.Windows.Forms.Button();
         this.btnMinus = new System.Windows.Forms.Button();
         this.txtQuantity = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).BeginInit();
         this.SuspendLayout();
         // 
         // btnBack
         // 
         this.btnBack.ForeColor = System.Drawing.Color.Black;
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
         this.btnCheckout.ForeColor = System.Drawing.Color.Black;
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
         this.btnDelete.ForeColor = System.Drawing.Color.Black;
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
         this.btnUpdate.ForeColor = System.Drawing.Color.Black;
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
         this.lblProductName.ForeColor = System.Drawing.Color.Black;
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
         this.asd.ForeColor = System.Drawing.Color.Black;
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
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(784, 454);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(125, 36);
         this.label3.TabIndex = 9;
         this.label3.Text = "Quantity";
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
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(432, 33);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(89, 36);
         this.label4.TabIndex = 13;
         this.label4.Text = "Total:";
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.ForeColor = System.Drawing.Color.Black;
         this.lblTotal.Location = new System.Drawing.Point(516, 33);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(115, 36);
         this.lblTotal.TabIndex = 14;
         this.lblTotal.Text = "number";
         // 
         // datagridViewCart
         // 
         this.datagridViewCart.AllowUserToAddRows = false;
         this.datagridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.datagridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.datagridViewCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.datagridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.datagridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.datagridViewCart.DefaultCellStyle = dataGridViewCellStyle2;
         this.datagridViewCart.Location = new System.Drawing.Point(72, 85);
         this.datagridViewCart.Name = "datagridViewCart";
         this.datagridViewCart.RowHeadersVisible = false;
         this.datagridViewCart.RowHeadersWidth = 50;
         this.datagridViewCart.RowTemplate.Height = 30;
         this.datagridViewCart.Size = new System.Drawing.Size(618, 325);
         this.datagridViewCart.TabIndex = 15;
         this.datagridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewCart_CellClick);
         // 
         // btnPlus
         // 
         this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPlus.Location = new System.Drawing.Point(985, 506);
         this.btnPlus.Name = "btnPlus";
         this.btnPlus.Size = new System.Drawing.Size(39, 41);
         this.btnPlus.TabIndex = 97;
         this.btnPlus.Text = "+";
         this.btnPlus.UseVisualStyleBackColor = true;
         this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
         // 
         // btnMinus
         // 
         this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMinus.Location = new System.Drawing.Point(780, 506);
         this.btnMinus.Name = "btnMinus";
         this.btnMinus.Size = new System.Drawing.Size(39, 41);
         this.btnMinus.TabIndex = 96;
         this.btnMinus.Text = "-";
         this.btnMinus.UseVisualStyleBackColor = true;
         this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
         // 
         // txtQuantity
         // 
         this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
         this.txtQuantity.Location = new System.Drawing.Point(825, 506);
         this.txtQuantity.Name = "txtQuantity";
         this.txtQuantity.Size = new System.Drawing.Size(155, 41);
         this.txtQuantity.TabIndex = 95;
         this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
         // 
         // ViewCart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.btnPlus);
         this.Controls.Add(this.btnMinus);
         this.Controls.Add(this.txtQuantity);
         this.Controls.Add(this.datagridViewCart);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtTotalPrice);
         this.Controls.Add(this.asd);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.lblProductName);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCheckout);
         this.Controls.Add(this.btnBack);
         this.ForeColor = System.Drawing.Color.Black;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewCart";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewCart";
         this.Load += new System.EventHandler(this.ViewCart_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnBack;
      private System.Windows.Forms.Button btnCheckout;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Label lblProductName;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.TextBox txtTotalPrice;
      private System.Windows.Forms.Label asd;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.DataGridView datagridViewCart;
      private System.Windows.Forms.Button btnPlus;
      private System.Windows.Forms.Button btnMinus;
      private System.Windows.Forms.TextBox txtQuantity;
   }
}