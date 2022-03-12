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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmGiris q = new FrmGiris();
            q.Show();
            this.Hide();


        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Biz,içinde kendimizin yaşamayacağı hiçbir projeye imza atmadık!.. çünkü; mutluluk herkesin hakkı! bu yüzden kalite çıtasını hep en yüksekte tuttuk... ÇINAR OLİMPİA PARK KONUTLARI'nda inşaat teknolojisi ve her tür inşaat malzemesinden çevre düzenlemesi ve dairelerdeki donanıma varıncaya kadar her şey ultra kalite!.. yemyeşil - masmavi çevreyi sağlık içinde bir yaşam konseptinde planladık...                            İçerisinde Açık ve Kapalı olmak üzere 2 çeşit havuz ve çocuk havuzu, Futbol ve Basketbol sahası, otomobiller için kapalı ve açık otopark mevcuttur.  Emniyetiniz için hem ön hemde arka kapıda güvenlik bulunmaktadır. Sitemiz her hafta temizlik işçileri tarafından temizlenmektedir.                                                                           Bir yaşama alanı sağlayan duvarlarla çevrili... yemyeşil ağaçların, rengârenk çiçeklerin süslediği çevre, dinlenme ve eğlence imkânları sunan kafetaryalarıyla, evinizin yanıbaşında piknik yaşamanızı sağlayacak kameriyeleriyle, yürüyüş ve bisiklet parkurları, tenis, voleybol ve basketbol sahalarıyla, fitness ve saunalarıyla her şey, sağlık içinde bir yaşamın ayrılmaz bileşenleri olarak tasarlandı!...");



        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            {

                Application.Exit();
            }

        }

        private void BtnVeriler_Click(object sender, EventArgs e)
        {
            borc r = new borc();
            r.Show();
            



        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            KullanıcıMesaj km = new KullanıcıMesaj();
            km.Show();
            this.Hide();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGaleri g = new FrmGaleri();
            g.Show();
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmode d = new frmode();
            d.Show();
            this.Hide();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l6.Text = DateTime.Now.ToLongDateString();
            l7.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
