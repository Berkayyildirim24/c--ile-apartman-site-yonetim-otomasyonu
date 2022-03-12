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
    public partial class Frmgrs : Form
    {
        public Frmgrs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"server=BERKAY\SQLEXPRESS; database=Siteyönetim; Trusted_Connection=true;";
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand Login = new SqlCommand("SP_LoginControl", baglanti);
                Login.CommandType = CommandType.StoredProcedure;
                Login.Parameters.AddWithValue("@username", txtUserName.Text);
                Login.Parameters.AddWithValue("@password", txtPassword.Text);
                Login.Parameters.Add("@deger", SqlDbType.Int).Direction = ParameterDirection.Output;
                Login.ExecuteNonQuery();
                if (Convert.ToInt32(Login.Parameters["@deger"].Value) == -1)
                {
                    MessageBox.Show("Kullanıcıya Ait Şifre Hatalı Girildi..!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(Login.Parameters["@deger"].Value) == 0)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(Login.Parameters["@deger"].Value) == 1)
                {
                    FrmKullanici frm = new FrmKullanici();
                    this.Hide();
                    frm.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmGiris w = new FrmGiris();
            w.Show();
            this.Hide();
        }

        private void Frmgrs_Load(object sender, EventArgs e)
        {

        }
    }
    }

