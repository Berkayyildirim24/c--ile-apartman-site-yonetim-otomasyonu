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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");

        private void verilerigoster()
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Personeller", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["İS"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }



        private void btngeriii_Click(object sender, EventArgs e)
        {

            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();


        }

        private void Btnverilerigöster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void BtnKaydett_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personeller(Adi,Soyadi,Adres,Telefon,İS) values ('" + t1.Text.ToString() + "','" + t2.Text.ToString() + "','" + t3.Text.ToString() + "','" + t4.Text.ToString() + "','" + t5.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        int id = 0;

        private void BtnSill_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Personeller where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


        }

        private void Btngüncellee_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personeller set Adi='" + t1.Text.ToString() + "',Soyadi='" + t2.Text.ToString() + "',Adres='" + t3.Text.ToString() + "',Telefon='" + t4.Text.ToString() + "',İS='" + t5.Text.ToString() + "'where id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();



        }

        private void Btntemizlee_Click(object sender, EventArgs e)
        {


            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";

            t1.Focus();


        }

        private void BtnAraa_Click(object sender, EventArgs e)
        {


            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Personeller where Adi like '%" + txtara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["İS"].ToString());


                listView1.Items.Add(ekle);


            }

            baglanti.Close();



        }

      

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            t1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            t2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            t3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            t4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            t5.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }
    }
    }
    
    

