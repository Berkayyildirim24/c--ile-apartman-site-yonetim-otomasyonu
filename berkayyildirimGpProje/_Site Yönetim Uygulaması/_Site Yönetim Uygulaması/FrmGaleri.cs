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
    public partial class FrmGaleri : Form
    {
        public FrmGaleri()
        {
            InitializeComponent();
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmKullanici a = new FrmKullanici();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmOdalar o = new FrmOdalar();
            o.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Frmmutfak f = new Frmmutfak();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmdismekan m = new Frmdismekan();
            m.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLavabo l = new FrmLavabo();
            l.Show();
            this.Hide();
        }
    }
}
