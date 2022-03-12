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
    public partial class DBlokDaireler : Form
    {
        public DBlokDaireler()
        {
            InitializeComponent();
        }


        private void renkler()
        {
            DD1.BackColor = Color.Gray;
            DD2.BackColor = Color.Gray;
            DD3.BackColor = Color.Gray;
            DD4.BackColor = Color.Gray;
            DD5.BackColor = Color.Gray;
            DD6.BackColor = Color.Gray;
            DD7.BackColor = Color.Gray;
            DD8.BackColor = Color.Gray;


        }



        private void DBlokDaireler_Load(object sender, EventArgs e)
        {
            renkler();
        }

        private void DD1_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Gökhan Gönül";
            Ddl2.Text = "05537654254";
            Ddl3.Text = "1";
            Ddl4.Text = "Gökhan@gmail.com";


        }

        private void DD2_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Volkan Demirel";
            Ddl2.Text = "05537699954";
            Ddl3.Text = "2";
            Ddl4.Text = "Volkan@gmail.com";


        }

        private void DD3_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Sabri Sarıoğlu";
            Ddl2.Text = "05554443322";
            Ddl3.Text = "3";
            Ddl4.Text = "Sabri@gmail.com";


        }

        private void DD4_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Emre Belezoğlu";
            Ddl2.Text = "05669874565";
            Ddl3.Text = "4";
            Ddl4.Text = "Emre@gmail.com";


        }

        private void DD5_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Caner Erkin";
            Ddl2.Text = "05469874565";
            Ddl3.Text = "5";
            Ddl4.Text = "Caner@gmail.com";


        }

        private void DD6_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Emre Mor";
            Ddl2.Text = "05322147896";
            Ddl3.Text = "6";
            Ddl4.Text = "Emremor@gmail.com";


        }

        private void DD7_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Tuncay Şanlı";
            Ddl2.Text = "05548796543";
            Ddl3.Text = "7";
            Ddl4.Text = "Tuncay@gmail.com";



        }

        private void DD8_Click(object sender, EventArgs e)
        {

            renkler();
            DD1.BackColor = Color.CadetBlue;
            Ddl1.Text = "Tolga Zengin";
            Ddl2.Text = "05789221100";
            Ddl3.Text = "8";
            Ddl4.Text = "Tolga@gmail.com";


        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmBloklar d = new FrmBloklar();
            d.Show();
            this.Hide();


        }
    }
}
