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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void yönetici_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa ana = new FrmAnaSayfa();
            ana.Show();
            this.Hide();

        }

        private void kullanıcı_Click(object sender, EventArgs e)
        {
            Frmgrs c = new Frmgrs();
            c.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            {

                Application.Exit();
            }


        }
    }
}
