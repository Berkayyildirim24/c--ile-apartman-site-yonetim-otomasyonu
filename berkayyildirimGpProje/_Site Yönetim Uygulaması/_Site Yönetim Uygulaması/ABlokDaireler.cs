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
    public partial class ABlokDaireler : Form
    {
        public ABlokDaireler()
        {
            InitializeComponent();
        }


        private void renkler()
        {
            AD1.BackColor = Color.Gray;
            AD2.BackColor = Color.Gray;
            AD3.BackColor = Color.Gray;
            AD4.BackColor = Color.Gray;
            AD5.BackColor = Color.Gray;
            AD6.BackColor = Color.Gray;
            AD7.BackColor = Color.Gray;
            AD8.BackColor = Color.Gray;


        }



        private void AD1_Click(object sender, EventArgs e)
        {
            renkler();
            AD1.BackColor = Color.CadetBlue;
            AD1l.Text = "Berkay Yıldırım";
            AD2l.Text = "05531098247";
            AD3l.Text = "1";
            AD4l.Text = "Berkay@gmail.com";


        }

        private void ABlokDaireler_Load(object sender, EventArgs e)
        {
            renkler();
        }

        private void AD2_Click(object sender, EventArgs e)
        {
            renkler();
            AD2.BackColor = Color.CadetBlue;
            AD1l.Text = "Burak Can Sınmaz";
            AD2l.Text = "05531099999";
            AD3l.Text = "2";
            AD4l.Text = "Burak@gmail.com";


        }

        private void AD3_Click(object sender, EventArgs e)
        {
            renkler();
            AD3.BackColor = Color.CadetBlue;
            AD1l.Text = "Muhammet Hakan Dilek";
            AD2l.Text = "05531098789";
            AD3l.Text = "3";
            AD4l.Text = "Hakan@gmail.com";



        }

        private void AD4_Click(object sender, EventArgs e)
        {
            renkler();
            AD4.BackColor = Color.CadetBlue;
            AD1l.Text = "Abdulsamet Eryiğit";
            AD2l.Text = "05531012345";
            AD3l.Text = "4";
            AD4l.Text = "Samet@gmail.com";


        }

        private void AD5_Click(object sender, EventArgs e)
        {

            renkler();
            AD5.BackColor = Color.CadetBlue;
            AD1l.Text = "Murat Gedikoğlu";
            AD2l.Text = "05531075632";
            AD3l.Text = "5";
            AD4l.Text = "Murat@gmail.com";



        }

        private void AD6_Click(object sender, EventArgs e)
        {
            renkler();
            AD6.BackColor = Color.CadetBlue;
            AD1l.Text = "Ufuk Dal";
            AD2l.Text = "05545642332";
            AD3l.Text = "6";
            AD4l.Text = "Ufuk@gmail.com";


        }

        private void AD7_Click(object sender, EventArgs e)
        {
            renkler();
            AD7.BackColor = Color.CadetBlue;
            AD1l.Text = "Recep Yanar";
            AD2l.Text = "05531087955";
            AD3l.Text = "7";
            AD4l.Text = "Recep@gmail.com";


        }

        private void AD8_Click(object sender, EventArgs e)
        {
            renkler();
            AD8.BackColor = Color.CadetBlue;
            AD1l.Text = "Hüseyin Yeşilkaya";
            AD2l.Text = "05531852369";
            AD3l.Text = "8";
            AD4l.Text = "Hüseyin@gmail.com";



        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmBloklar a = new FrmBloklar();
            a.Show();
            this.Hide();



        }
    }
}
