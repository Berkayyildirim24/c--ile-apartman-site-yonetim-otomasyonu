namespace _Site_Yönetim_Uygulaması
{
    partial class Faturalar
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
            this.btngeri = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2.Location = new System.Drawing.Point(84, 120);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(99, 29);
            this.l2.TabIndex = 18;
            this.l2.Text = "Elektrik:";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(214, 120);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(220, 20);
            this.t2.TabIndex = 21;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(214, 170);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(220, 20);
            this.t3.TabIndex = 22;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(214, 225);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(220, 20);
            this.t4.TabIndex = 23;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l3.Location = new System.Drawing.Point(84, 170);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(48, 29);
            this.l3.TabIndex = 24;
            this.l3.Text = "Su:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l4.Location = new System.Drawing.Point(84, 225);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(78, 29);
            this.l4.TabIndex = 25;
            this.l4.Text = "Diğer:";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(214, 72);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(220, 20);
            this.t1.TabIndex = 29;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l1.Location = new System.Drawing.Point(84, 72);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(50, 29);
            this.l1.TabIndex = 28;
            this.l1.Text = "AY:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(89, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 131);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aylar";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Elektrik";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Su";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Diger";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b1.Image = global::_Site_Yönetim_Uygulaması.Properties.Resources.Save2;
            this.b1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b1.Location = new System.Drawing.Point(274, 271);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(103, 38);
            this.b1.TabIndex = 26;
            this.b1.Text = " KAYDET";
            this.b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(644, 469);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.btngeri);
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.Faturalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}