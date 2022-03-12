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
    public partial class CBlokDaireler : Form
    {
        public CBlokDaireler()
        {
            InitializeComponent();
        }



        private void renkler()
        {
            CD1.BackColor = Color.Gray;
            CD2.BackColor = Color.Gray;
            CD3.BackColor = Color.Gray;
            CD4.BackColor = Color.Gray;
            CD5.BackColor = Color.Gray;
            CD6.BackColor = Color.Gray;
            CD7.BackColor = Color.Gray;
            CD8.BackColor = Color.Gray;


        }



        private void CD1_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Kemal Sunal";
            Cdl2.Text = "05537909654";
            Cdl3.Text = "1";
            Cdl4.Text = "Kemal@gmail.com";


        }

        private void CBlokDaireler_Load(object sender, EventArgs e)
        {
            renkler();
        }

        private void CD2_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Barış Manço";
            Cdl2.Text = "05531712365";
            Cdl3.Text = "2";
            Cdl4.Text = "Barış@gmail.com";


        }

        private void CD3_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Cem Yılmaz";
            Cdl2.Text = "05531777365";
            Cdl3.Text = "3";
            Cdl4.Text = "Cem@gmail.com";


        }

        private void CD4_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Acun Ilıcalı";
            Cdl2.Text = "05531898989";
            Cdl3.Text = "4";
            Cdl4.Text = "Acun@gmail.com";


        }

        private void CD5_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Beyazıt Öztürk";
            Cdl2.Text = "05555555555";
            Cdl3.Text = "5";
            Cdl4.Text = "Beyazıt@gmail.com";


        }

        private void CD6_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Emel Sayın";
            Cdl2.Text = "05533333333";
            Cdl3.Text = "6";
            Cdl4.Text = "Emel@gmail.com";



        }

        private void CD7_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Ajda Pekkan";
            Cdl2.Text = "05531744444";
            Cdl3.Text = "7";
            Cdl4.Text = "Ajda Pekkan@gmail.com";


        }

        private void CD8_Click(object sender, EventArgs e)
        {

            renkler();
            CD1.BackColor = Color.CadetBlue;
            Cdl1.Text = "Eser Yenerler";
            Cdl2.Text = "05538888365";
            Cdl3.Text = "8";
            Cdl4.Text = "Eser@gmail.com";


        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmBloklar c = new FrmBloklar();
            c.Show();
            this.Hide();


        }
    }
}
