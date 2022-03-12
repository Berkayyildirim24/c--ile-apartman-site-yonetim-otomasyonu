namespace _Site_Yönetim_Uygulaması
{
    partial class FrmGelirGider
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
            this.l1 = new System.Windows.Forms.Label();
            this.lblkasatutar = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.lblpersonelmaas = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l1.Location = new System.Drawing.Point(27, 82);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(134, 24);
            this.l1.TabIndex = 0;
            this.l1.Text = "Alınacak Tutar:";
            // 
            // lblkasatutar
            // 
            this.lblkasatutar.AutoSize = true;
            this.lblkasatutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasatutar.Location = new System.Drawing.Point(189, 82);
            this.lblkasatutar.Name = "lblkasatutar";
            this.lblkasatutar.Size = new System.Drawing.Size(30, 24);
            this.lblkasatutar.TabIndex = 1;
            this.lblkasatutar.Text = "00";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l3.Location = new System.Drawing.Point(27, 162);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(140, 24);
            this.l3.TabIndex = 2;
            this.l3.Text = "Personel Maaş:";
            // 
            // lblpersonelmaas
            // 
            this.lblpersonelmaas.AutoSize = true;
            this.lblpersonelmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelmaas.Location = new System.Drawing.Point(189, 162);
            this.lblpersonelmaas.Name = "lblpersonelmaas";
            this.lblpersonelmaas.Size = new System.Drawing.Size(30, 24);
            this.lblpersonelmaas.TabIndex = 3;
            this.lblpersonelmaas.Text = "00";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(297, 72);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(157, 20);
            this.t1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(293, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel Sayısı:";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Cyan;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(89, 32);
            this.btngeri.TabIndex = 17;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.White;
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.Calculator_icon;
            this.btnhesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhesapla.Location = new System.Drawing.Point(297, 149);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(139, 50);
            this.btnhesapla.TabIndex = 8;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(557, 258);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.lblpersonelmaas);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.lblkasatutar);
            this.Controls.Add(this.l1);
            this.Name = "FrmGelirGider";
            this.Text = "FrmGelirGider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label lblkasatutar;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label lblpersonelmaas;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngeri;
    }
}