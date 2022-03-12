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
    public partial class BBlokDaireler : Form
    {
        public BBlokDaireler()
        {
            InitializeComponent();
        }


        private void renkler()
        {
            BD1.BackColor = Color.Gray;
            BD2.BackColor = Color.Gray;
            BD3.BackColor = Color.Gray;
            BD4.BackColor = Color.Gray;
            BD5.BackColor = Color.Gray;
            BD6.BackColor = Color.Gray;
            BD7.BackColor = Color.Gray;
            BD8.BackColor = Color.Gray;


        }


        private void BD1_Click(object sender, EventArgs e)
        {

            renkler();
            BD1.BackColor = Color.CadetBlue;
            Bdl1.Text = "Mecnun Çınar";
            Bdl2.Text = "05531789654";
            Bdl3.Text = "1";
            Bdl4.Text = "Mecnun@gmail.com";



        }

        private void BBlokDaireler_Load(object sender, EventArgs e)
        {
            renkler();
        }

        private void BD2_Click(object sender, EventArgs e)
        {

            renkler();
            BD2.BackColor = Color.CadetBlue;
            Bdl1.Text = "Erdal Bakkal";
            Bdl2.Text = "05322158754";
            Bdl3.Text = "2";
            Bdl4.Text = "Erdal@gmail.com";



        }

        private void BD3_Click(object sender, EventArgs e)
        {

            renkler();
            BD3.BackColor = Color.CadetBlue;
            Bdl1.Text = "İsmail Abi";
            Bdl2.Text = "05356458917";
            Bdl3.Text = "3";
            Bdl4.Text = "İsmail@gmail.com";

        }

        private void BD4_Click(object sender, EventArgs e)
        {

            renkler();
            BD4.BackColor = Color.CadetBlue;
            Bdl1.Text = "Leyla Yılmaz";
            Bdl2.Text = "05356989654";
            Bdl3.Text = "4";
            Bdl4.Text = "Leyla@gmail.com";


        }

        private void BD5_Click(object sender, EventArgs e)
        {

            renkler();
            BD5.BackColor = Color.CadetBlue;
            Bdl1.Text = "Yavuz Hırsız";
            Bdl2.Text = "05456982545";
            Bdl3.Text = "5";
            Bdl4.Text = "Yavuz@gmail.com";


        }

        private void BD6_Click(object sender, EventArgs e)
        {

            renkler();
            BD6.BackColor = Color.CadetBlue;
            Bdl1.Text = "Hüsnü Çoban";
            Bdl2.Text = "05357239010";
            Bdl3.Text = "6";
            Bdl4.Text = "Hüsnü@gmail.com";


        }

        private void BD7_Click(object sender, EventArgs e)
        {


            renkler();
            BD7.BackColor = Color.CadetBlue;
            Bdl1.Text = "Mesut Güneri";
            Bdl2.Text = "05531701234";
            Bdl3.Text = "7";
            Bdl4.Text = "Mesut@gmail.com";

        }

        private void BD8_Click(object sender, EventArgs e)
        {


            renkler();
            BD8.BackColor = Color.CadetBlue;
            Bdl1.Text = "Murat Ateş";
            Bdl2.Text = "05598745654";
            Bdl3.Text = "8";
            Bdl4.Text = "Murat@gmail.com";


        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmBloklar b = new FrmBloklar();
            b.Show();
            this.Hide();

        }
    }
}
