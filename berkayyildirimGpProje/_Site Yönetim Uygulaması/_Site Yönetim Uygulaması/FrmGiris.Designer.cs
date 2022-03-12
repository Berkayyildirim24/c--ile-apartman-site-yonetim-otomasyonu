namespace _Site_Yönetim_Uygulaması
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.yönetici = new System.Windows.Forms.Button();
            this.kullanıcı = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yönetici
            // 
            this.yönetici.BackColor = System.Drawing.Color.LightSalmon;
            this.yönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yönetici.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.download3;
            this.yönetici.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yönetici.Location = new System.Drawing.Point(76, 207);
            this.yönetici.Name = "yönetici";
            this.yönetici.Size = new System.Drawing.Size(270, 94);
            this.yönetici.TabIndex = 0;
            this.yönetici.Text = "YÖNETİCİ";
            this.yönetici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yönetici.UseVisualStyleBackColor = false;
            this.yönetici.Click += new System.EventHandler(this.yönetici_Click);
            // 
            // kullanıcı
            // 
            this.kullanıcı.BackColor = System.Drawing.Color.LightSalmon;
            this.kullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.download4;
            this.kullanıcı.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kullanıcı.Location = new System.Drawing.Point(391, 207);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(272, 94);
            this.kullanıcı.TabIndex = 1;
            this.kullanıcı.Text = "KULLANICI";
            this.kullanıcı.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanıcı.UseVisualStyleBackColor = false;
            this.kullanıcı.Click += new System.EventHandler(this.kullanıcı_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİTE YÖNETİM UYGULAMASINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(243, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "HOŞGELDİNİZ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.Cancel1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(306, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcı);
            this.Controls.Add(this.yönetici);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yönetici;
        private System.Windows.Forms.Button kullanıcı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}