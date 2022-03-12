namespace _Site_Yönetim_Uygulaması
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(212, 194);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(168, 20);
            this.TxtSifre.TabIndex = 14;
            // 
            // TxtKullanıcıAdı
            // 
            this.TxtKullanıcıAdı.Location = new System.Drawing.Point(212, 150);
            this.TxtKullanıcıAdı.Name = "TxtKullanıcıAdı";
            this.TxtKullanıcıAdı.Size = new System.Drawing.Size(168, 20);
            this.TxtKullanıcıAdı.TabIndex = 13;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn1.Location = new System.Drawing.Point(212, 260);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(168, 44);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "GİRİŞ YAP";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l3.Location = new System.Drawing.Point(95, 45);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(343, 29);
            this.l3.TabIndex = 11;
            this.l3.Text = "SİTE YÖNETİM UYGULAMASI";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.White;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2.Location = new System.Drawing.Point(53, 194);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(128, 25);
            this.l2.TabIndex = 10;
            this.l2.Text = "             Şifre: ";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l1.Location = new System.Drawing.Point(51, 150);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(130, 25);
            this.l1.TabIndex = 9;
            this.l1.Text = "Kullanıcı Adı: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(209, 347);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 25);
            this.lbl3.TabIndex = 15;
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Cyan;
            this.btngeri.Location = new System.Drawing.Point(0, 0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(89, 32);
            this.btngeri.TabIndex = 16;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 381);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanıcıAdı);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullanıcıAdı;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btngeri;
    }
}

