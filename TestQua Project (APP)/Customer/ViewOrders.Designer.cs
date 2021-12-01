
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.button1 = new System.Windows.Forms.Button();
         this.btnReturn = new System.Windows.Forms.Button();
         this.btnOrderReceived = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtStatus = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridViewOrder
         // 
         this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridViewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle4;
         this.dataGridViewOrder.Location = new System.Drawing.Point(70, 95);
         this.dataGridViewOrder.Name = "dataGridViewOrder";
         this.dataGridViewOrder.RowHeadersVisible = false;
         this.dataGridViewOrder.RowHeadersWidth = 50;
         this.dataGridViewOrder.RowTemplate.Height = 30;
         this.dataGridViewOrder.Size = new System.Drawing.Size(552, 317);
         this.dataGridViewOrder.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "No.";
         this.Column1.Name = "Column1";
         this.Column1.Width = 65;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Product Name";
         this.Column2.Name = "Column2";
         this.Column2.Width = 156;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Quantity";
         this.Column3.Name = "Column3";
         this.Column3.Width = 103;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Total";
         this.Column4.Name = "Column4";
         this.Column4.Width = 76;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Plum;
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
         this.button1.Location = new System.Drawing.Point(41, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(99, 47);
         this.button1.TabIndex = 1;
         this.button1.Text = "Back";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnReturn
         // 
         this.btnReturn.BackColor = System.Drawing.Color.Plum;
         this.btnReturn.FlatAppearance.BorderSize = 0;
         this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
         this.btnReturn.Location = new System.Drawing.Point(429, 445);
         this.btnReturn.Name = "btnReturn";
         this.btnReturn.Size = new System.Drawing.Size(99, 47);
         this.btnReturn.TabIndex = 2;
         this.btnReturn.Tag = "Return";
         this.btnReturn.Text = "Return";
         this.btnReturn.UseVisualStyleBackColor = false;
         this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
         // 
         // btnOrderReceived
         // 
         this.btnOrderReceived.BackColor = System.Drawing.Color.Plum;
         this.btnOrderReceived.FlatAppearance.BorderSize = 0;
         this.btnOrderReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnOrderReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
         this.btnOrderReceived.Location = new System.Drawing.Point(175, 445);
         this.btnOrderReceived.Name = "btnOrderReceived";
         this.btnOrderReceived.Size = new System.Drawing.Size(99, 47);
         this.btnOrderReceived.TabIndex = 3;
         this.btnOrderReceived.Tag = "Received";
         this.btnOrderReceived.Text = "Received";
         this.btnOrderReceived.UseVisualStyleBackColor = false;
         this.btnOrderReceived.Click += new System.EventHandler(this.btnOrderReceived_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Black;
         this.label1.Location = new System.Drawing.Point(244, 51);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(183, 31);
         this.label1.TabIndex = 4;
         this.label1.Text = "Order Status: ";
         // 
         // txtStatus
         // 
         this.txtStatus.AutoSize = true;
         this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtStatus.ForeColor = System.Drawing.Color.Black;
         this.txtStatus.Location = new System.Drawing.Point(423, 51);
         this.txtStatus.Name = "txtStatus";
         this.txtStatus.Size = new System.Drawing.Size(68, 31);
         this.txtStatus.TabIndex = 5;
         this.txtStatus.Text = "Test";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(80, 464);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(0, 13);
         this.label2.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(81, 504);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(0, 13);
         this.label3.TabIndex = 7;
         // 
         // ViewOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.ClientSize = new System.Drawing.Size(712, 558);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtStatus);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnOrderReceived);
         this.Controls.Add(this.btnReturn);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dataGridViewOrder);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewOrders";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewOrders";
         this.Load += new System.EventHandler(this.ViewOrders_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridViewOrder;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.Button btnReturn;
      private System.Windows.Forms.Button btnOrderReceived;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label txtStatus;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}