
namespace TestQua_Project__APP_
{
    partial class Splashscreen
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(313, 573);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(100, 23);
         this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.progressBar1.TabIndex = 1;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(-39, -25);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(1065, 588);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 85;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
         this.label1.Location = new System.Drawing.Point(37, 105);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(461, 54);
         this.label1.TabIndex = 86;
         this.label1.Text = "Bloom and Puff Shop";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Plum;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.button1.Location = new System.Drawing.Point(49, 291);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(239, 60);
         this.button1.TabIndex = 88;
         this.button1.Text = "Start Browsing";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
         this.label2.Location = new System.Drawing.Point(49, 166);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(434, 62);
         this.label2.TabIndex = 89;
         this.label2.Text = "Special Occasions, holidays or just\r\na nice treat to your backyard";
         // 
         // Splashscreen
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(986, 538);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.progressBar1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Splashscreen";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Splashscreen";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
      private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label2;
   }
}