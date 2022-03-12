namespace _Site_Yönetim_Uygulaması
{
    partial class FrmMesajlar
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
            this.lblmesajlar = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngeriii = new System.Windows.Forms.Button();
            this.btnkaydettt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmesajlar
            // 
            this.lblmesajlar.AutoSize = true;
            this.lblmesajlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesajlar.Location = new System.Drawing.Point(225, 21);
            this.lblmesajlar.Name = "lblmesajlar";
            this.lblmesajlar.Size = new System.Drawing.Size(157, 31);
            this.lblmesajlar.TabIndex = 4;
            this.lblmesajlar.Text = "MESAJLAR";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(20, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(584, 209);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AdSoyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaj";
            this.columnHeader3.Width = 680;
            // 
            // btngeriii
            // 
            this.btngeriii.BackColor = System.Drawing.Color.Cyan;
            this.btngeriii.Location = new System.Drawing.Point(20, 12);
            this.btngeriii.Name = "btngeriii";
            this.btngeriii.Size = new System.Drawing.Size(85, 26);
            this.btngeriii.TabIndex = 63;
            this.btngeriii.Text = "GERİ";
            this.btngeriii.UseVisualStyleBackColor = false;
            this.btngeriii.Click += new System.EventHandler(this.btngeriii_Click);
            // 
            // btnkaydettt
            // 
            this.btnkaydettt.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.document_view1;
            this.btnkaydettt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydettt.Location = new System.Drawing.Point(500, 14);
            this.btnkaydettt.Name = "btnkaydettt";
            this.btnkaydettt.Size = new System.Drawing.Size(104, 38);
            this.btnkaydettt.TabIndex = 6;
            this.btnkaydettt.Text = "LİSTELE";
            this.btnkaydettt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydettt.UseVisualStyleBackColor = true;
            this.btnkaydettt.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // FrmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(616, 415);
            this.Controls.Add(this.btngeriii);
            this.Controls.Add(this.btnkaydettt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblmesajlar);
            this.Name = "FrmMesajlar";
            this.Text = "FrmMesajlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmesajlar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btngeriii;
        private System.Windows.Forms.Button btnkaydettt;
    }
}