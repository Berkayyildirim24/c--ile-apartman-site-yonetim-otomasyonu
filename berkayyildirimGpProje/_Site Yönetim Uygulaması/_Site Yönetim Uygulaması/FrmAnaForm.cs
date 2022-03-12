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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnDaireler_Click(object sender, EventArgs e)
        {
            FrmBloklar fr = new FrmBloklar();
            fr.Show();
            this.Hide();
            
        }

        private void BtnKayıtİşlemleri_Click(object sender, EventArgs e)
        {

            Kayit k = new Kayit();
            k.Show();
            this.Hide();


        }

      

        private void BtnVeriler_Click(object sender, EventArgs e)
        {
            FrmBorclar borc = new FrmBorclar();
            borc.Show();


        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biz,içinde kendimizin yaşamayacağı hiçbir projeye imza atmadık!.. çünkü; mutluluk herkesin hakkı! bu yüzden kalite çıtasını hep en yüksekte tuttuk... ÇINAR OLİMPİA PARK KONUTLARI'nda inşaat teknolojisi ve her tür inşaat malzemesinden çevre düzenlemesi ve dairelerdeki donanıma varıncaya kadar her şey ultra kalite!.. yemyeşil - masmavi çevreyi sağlık içinde bir yaşam konseptinde planladık...                            İçerisinde Açık ve Kapalı olmak üzere 2 çeşit havuz ve çocuk havuzu, Futbol ve Basketbol sahası, otomobiller için kapalı ve açık otopark mevcuttur.  Emniyetiniz için hem ön hemde arka kapıda güvenlik bulunmaktadır. Sitemiz her hafta temizlik işçileri tarafından temizlenmektedir.                                                                       Bir yaşama alanı sağlayan duvarlarla çevrili... yemyeşil ağaçların, rengârenk çiçeklerin süslediği çevre, dinlenme ve eğlence imkânları sunan kafetaryalarıyla, evinizin yanıbaşında piknik yaşamanızı sağlayacak kameriyeleriyle, yürüyüş ve bisiklet parkurları, tenis, voleybol ve basketbol sahalarıyla, fitness ve saunalarıyla her şey, sağlık içinde bir yaşamın ayrılmaz bileşenleri olarak tasarlandı!...");




                
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            {
               
                Application.Exit();
            }
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {

            FrmGiris v = new FrmGiris();
            v.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Personel p = new Personel();
            p.Show();
            this.Hide();


        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            FrmMesajlar msj = new FrmMesajlar();
            msj.Show();
            this.Hide();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Faturalar fa = new Faturalar();
            fa.Show();
            this.Hide();



        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            l6.Text = DateTime.Now.ToLongDateString();
            l7.Text = DateTime.Now.ToLongTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmGelirGider p = new FrmGelirGider();
            p.Show();
            this.Hide();



        }

        private void button4_Click(object sender, EventArgs e)
        {

            FrmGaleri b = new FrmGaleri();
            b.Show();
            this.Hide();


        }

        private void btngalerii_Click(object sender, EventArgs e)
        {
            FrmGaleri t = new FrmGaleri();
            t.Show();
            this.Hide();

        }

        private void btnyonetici_Click(object sender, EventArgs e)
        {

            FrmYonetici p = new FrmYonetici();
            p.Show();
            this.Hide();

        }

        private void frmgaleri_Click(object sender, EventArgs e)
        {
            FrmGaleri z = new FrmGaleri();
            z.Show();
            
        }
    }
}
