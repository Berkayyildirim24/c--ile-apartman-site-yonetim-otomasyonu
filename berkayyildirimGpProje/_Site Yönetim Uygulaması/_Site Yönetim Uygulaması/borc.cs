using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _Site_Yönetim_Uygulaması
{
    public partial class borc : Form
    {
        public borc()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");
        private void verilerigoster()
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from kisibilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());


                listView1.Items.Add(ekle);


            }

            baglanti.Close();

        }

        
        



            private void borc_Load(object sender, EventArgs e)
        {
                verilerigoster();
            }
    }
}
