using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _Site_Yönetim_Uygulaması
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");






        private void btnhesapla_Click(object sender, EventArgs e)
        {



            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(Cast(Borclar As decimal(15,4))) as toplam FROM      kisibilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())

            {

                lblkasatutar.Text = oku["toplam"].ToString();


            }

            baglanti.Close();

            int personel;
            personel = Convert.ToInt16(t1.Text);
            lblpersonelmaas.Text = (personel * 1500).ToString();



        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm a = new FrmAnaForm();
            a.Show();
            this.Hide();



        }

       
    }
}
