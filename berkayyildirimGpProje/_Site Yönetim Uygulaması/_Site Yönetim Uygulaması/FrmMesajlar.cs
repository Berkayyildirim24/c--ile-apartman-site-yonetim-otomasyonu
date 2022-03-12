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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");

        private void verilerigoster()
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {

            FrmAnaForm v = new FrmAnaForm();
            v.Show();
            this.Hide();



        }
    }
}

