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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection(@"Data Source=BERKAY\SQLEXPRESS;Initial Catalog=Siteyönetim;Integrated Security=True");

        private void Verilerigoster()
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aylar"].ToString();
                ekle.SubItems.Add(oku["Elektrik"].ToString());
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Diger"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();

        }


        private void b1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Aylar,Elektrik,Su,Diger) values ('" + t1.Text.ToString() + "','" + t2.Text.ToString() + "','" + t3.Text.ToString() + "','" + t4.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Verilerigoster();


            MessageBox.Show("Başarıyla Kaydedildi!");

        }

        private void Faturalar_Load(object sender, EventArgs e)
        {


            Verilerigoster();


        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();



        }

     

      

       
    }

        }
    
