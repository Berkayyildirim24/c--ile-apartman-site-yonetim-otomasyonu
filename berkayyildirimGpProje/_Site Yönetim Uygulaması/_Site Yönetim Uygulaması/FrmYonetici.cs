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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");

        private void verilerigoster()
        {

            l1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Yonetici", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["İban"].ToString());


                l1.Items.Add(ekle);


            }

            baglanti.Close();

        }



            private void btngeriii_Click(object sender, EventArgs e)
        {

            FrmAnaForm y = new FrmAnaForm();
            y.Show();
            this.Hide();


        }

        private void Btnverilerigöster_Click(object sender, EventArgs e)
        {

            verilerigoster();


        }

        private void BtnKaydett_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yonetici(Adi,Soyadi,Mail,Telefon,Tc,İban) values ('" + t1.Text.ToString() + "','" + t2.Text.ToString() + "','" + t3.Text.ToString() + "','" + t4.Text.ToString() + "','" + t5.Text.ToString() + "','" + t6.Text.ToString()  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


        }

        int id = 0;

        private void BtnSill_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Yonetici where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();


        }

        private void Btngüncellee_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Yonetici set Adi='" + t1.Text.ToString() + "',Soyadi='" + t2.Text.ToString() + "',Mail='" + t3.Text.ToString() + "',Telefon='" + t4.Text.ToString() + "',Tc='" + t5.Text.ToString() + "',İban='" + t6.Text.ToString()  + "'where id=" + id + "", baglanti);
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
            t6.Text = "";
            
            t1.Focus();


        }

        private void l1_DoubleClick(object sender, EventArgs e)
        {


            id = int.Parse(l1.SelectedItems[0].SubItems[0].Text);
            t1.Text = l1.SelectedItems[0].SubItems[1].Text;
            t2.Text = l1.SelectedItems[0].SubItems[2].Text;
            t3.Text = l1.SelectedItems[0].SubItems[3].Text;
            t4.Text = l1.SelectedItems[0].SubItems[4].Text;
            t5.Text = l1.SelectedItems[0].SubItems[5].Text;
            t6.Text = l1.SelectedItems[0].SubItems[6].Text;
      


        }

        private void BtnAraa_Click(object sender, EventArgs e)
        {


            l1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Yonetici where Adi like '%" + txtara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["İban"].ToString());

                l1.Items.Add(ekle);


            }

            baglanti.Close();



        }
    }
}
