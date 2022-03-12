using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Site_Yönetim_Uygulaması
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (TxtKullanıcıAdı.Text=="yönetici" && TxtSifre.Text=="1234")


            {

                lbl3.Text = "Hoşgeldiniz";
                lbl3.BackColor = Color.Green;

                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();




            }

            else
            {
                lbl3.Text = "Yanlış Kullanıcı";
                lbl3.BackColor = Color.Red;
            }

        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmGiris gir = new FrmGiris();
            gir.Show();
            this.Hide();
           



        }
    }
}
