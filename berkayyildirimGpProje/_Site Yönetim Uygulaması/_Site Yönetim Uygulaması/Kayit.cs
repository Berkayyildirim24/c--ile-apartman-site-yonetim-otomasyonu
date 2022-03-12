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
    public partial class Kayit : Form
    {
        public Kayit()
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
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Blok"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();



        }





        private void Btnverilerigöster_Click(object sender, EventArgs e)
        {

            verilerigoster();


        }

        private void BtnKaydett_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisibilgi(Ad,Soyad,Blok,Daire,Telefon,Mail,Borclar) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


        }

        int id = 0;


        private void BtnSill_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From kisibilgi where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void Btntemizlee_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();

        }

        private void Btngüncellee_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kisibilgi set Ad='" + textBox1.Text.ToString() + "',Soyad='" + textBox2.Text.ToString() + "',Blok='" + textBox3.Text.ToString() + "',Daire='" + textBox4.Text.ToString() + "',Telefon='" + textBox5.Text.ToString() + "',Mail='" + textBox6.Text.ToString() + "',Borclar='" + textBox7.Text.ToString() + "'where id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        private void BtnAraa_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from kisibilgi where Ad like '%" + txtara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Blok"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();


        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmAnaForm k = new FrmAnaForm();
            k.Show();
            this.Hide();

        }
    }
}
