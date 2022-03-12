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
    public partial class frmode : Form
    {
        public frmode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBorclar b = new FrmBorclar();
            b.Show();
            

        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmKullanici k = new FrmKullanici();
            k.Show();
            this.Hide();
        }

        private void b2_Click(object sender, EventArgs e)
        {

            w1.Navigate("https://www.garanti.com.tr/tr/bireysel/subesiz/internet_bankaciligi/islemler/islem_saat_ve_limitleri.page#calcContent=UID124efcf");


        }

        private void b5_Click(object sender, EventArgs e)
        {
            w1.Navigate("https://www.ziraatbank.com.tr/tr");
        }

        private void b4_Click(object sender, EventArgs e)
        {

            w1.Navigate("https://subesizbankacilik.vakifbank.com.tr/islemmasrafbilgileri/subesizbankacilik/Islemmasrafbilgileri.aspx");

        }

        private void b3_Click(object sender, EventArgs e)
        {

            w1.Navigate("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

        }
    }
}
