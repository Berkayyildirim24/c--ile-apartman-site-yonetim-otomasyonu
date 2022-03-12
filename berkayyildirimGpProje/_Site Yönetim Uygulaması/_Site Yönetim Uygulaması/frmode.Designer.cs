namespace _Site_Yönetim_Uygulaması
{
    partial class frmode
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
            this.w1 = new System.Windows.Forms.WebBrowser();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.btngeriii = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // w1
            // 
            this.w1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w1.Location = new System.Drawing.Point(0, 0);
            this.w1.MinimumSize = new System.Drawing.Size(20, 20);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(701, 391);
            this.w1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(572, 64);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(97, 35);
            this.b1.TabIndex = 1;
            this.b1.Text = "BORÇLAR";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(439, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(95, 36);
            this.b2.TabIndex = 2;
            this.b2.Text = "GARANTİ";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // btngeriii
            // 
            this.btngeriii.BackColor = System.Drawing.Color.Cyan;
            this.btngeriii.Location = new System.Drawing.Point(12, 12);
            this.btngeriii.Name = "btngeriii";
            this.btngeriii.Size = new System.Drawing.Size(85, 30);
            this.btngeriii.TabIndex = 34;
            this.btngeriii.Text = "GERİ";
            this.btngeriii.UseVisualStyleBackColor = false;
            this.btngeriii.Click += new System.EventHandler(this.btngeriii_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.Location = new System.Drawing.Point(156, 12);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(95, 36);
            this.b4.TabIndex = 35;
            this.b4.Text = "VAKIF";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.b5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.Location = new System.Drawing.Point(294, 12);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(95, 36);
            this.b5.TabIndex = 36;
            this.b5.Text = "ZİRAAT";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.Gmail_icon;
            this.b3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b3.Location = new System.Drawing.Point(572, 15);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(95, 36);
            this.b3.TabIndex = 3;
            this.b3.Text = "MAİL";
            this.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // frmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 391);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.btngeriii);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.w1);
            this.Name = "frmode";
            this.Text = "frmode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser w1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button btngeriii;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
    }
}