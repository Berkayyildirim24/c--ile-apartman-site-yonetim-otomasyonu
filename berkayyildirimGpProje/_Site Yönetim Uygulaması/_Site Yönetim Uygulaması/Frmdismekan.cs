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
    public partial class Frmdismekan : Form
    {
        public Frmdismekan()
        {
            InitializeComponent();
        }

        private void Frmdismekan_Load(object sender, EventArgs e)
        {
            pbmain.AllowDrop = true;
        }

        private void p1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p8_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void p9_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pbmain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pbmain_DragDrop(object sender, DragEventArgs e)
        {
            pbmain.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            p1.DoDragDrop(p1.Image, DragDropEffects.Copy);
        }

        private void p2_MouseDown(object sender, MouseEventArgs e)
        {
            p2.DoDragDrop(p2.Image, DragDropEffects.Copy);
        }

        private void p3_MouseDown(object sender, MouseEventArgs e)
        {
            p3.DoDragDrop(p3.Image, DragDropEffects.Copy);
        }

        private void p4_MouseDown(object sender, MouseEventArgs e)
        {
            p4.DoDragDrop(p4.Image, DragDropEffects.Copy);
        }

        private void p5_MouseDown(object sender, MouseEventArgs e)
        {
            p5.DoDragDrop(p5.Image, DragDropEffects.Copy);
        }

        private void p6_MouseDown(object sender, MouseEventArgs e)
        {
            p6.DoDragDrop(p6.Image, DragDropEffects.Copy);
        }

        private void p7_MouseDown(object sender, MouseEventArgs e)
        {
            p7.DoDragDrop(p7.Image, DragDropEffects.Copy);
        }

        private void p8_MouseDown(object sender, MouseEventArgs e)
        {
            p8.DoDragDrop(p8.Image, DragDropEffects.Copy);
        }

        private void p9_MouseDown(object sender, MouseEventArgs e)
        {
            p9.DoDragDrop(p9.Image, DragDropEffects.Copy);
        }

        private void btngeriii_Click(object sender, EventArgs e)
        {
            FrmGaleri g = new FrmGaleri();
            g.Show();
            this.Hide();
        }
    }
}
