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
    public partial class FrmBloklar : Form
    {
        public FrmBloklar()
        {
            InitializeComponent();
        }

        private void BtnABlok_Click(object sender, EventArgs e)
        {
            ABlokDaireler a = new ABlokDaireler();
            a.Show();
            this.Hide();
        }

        private void BtnBBlok_Click(object sender, EventArgs e)
        {

            BBlokDaireler b = new BBlokDaireler();
            b.Show();
            this.Hide();


        }

        private void BtnCBlok_Click(object sender, EventArgs e)
        {

            CBlokDaireler c = new CBlokDaireler();
            c.Show();
            this.Hide();


        }

        private void BtnDBlok_Click(object sender, EventArgs e)
        {

            DBlokDaireler d = new DBlokDaireler();
            d.Show();
            this.Hide();


        }

        private void btngerii_Click(object sender, EventArgs e)
        {

            FrmAnaForm g = new FrmAnaForm();
            g.Show();
            this.Hide();


        }
    }
}
