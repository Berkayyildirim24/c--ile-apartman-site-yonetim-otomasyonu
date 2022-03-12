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
    public partial class KullanıcıMesaj : Form
    {
        public KullanıcıMesaj()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");




        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values ('" + textBox1.Text.ToString() + "','" + richTextBox1.Text.ToString() +  "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Mesajınız Gönderildi!");

        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmKullanici q = new FrmKullanici();
            q.Show();
            this.Hide();




        }
    }
}
