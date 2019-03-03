using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPlanFormation
{
    //                                                                  CECI ETAIT UN PREMIER TEST 
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnOpenPDF1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\Image\test1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnOpenPDF2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\Image\test2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnOpenPDF3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\Image\test3.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnOpenPDF4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Home\Documents\Développement\GestPlanFormation\GestPlanFormation\Image\test4.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            FormInscription1 inscription1 = new FormInscription1();
            inscription1.ShowDialog();
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            FormInscription1 inscription2 = new FormInscription1();
            inscription2.ShowDialog();
        }

        private void btnRegister3_Click(object sender, EventArgs e)
        {
            FormInscription1 inscription3 = new FormInscription1();
            inscription3.ShowDialog();
        }

        private void btnRegister4_Click(object sender, EventArgs e)
        {
            FormInscription1 inscription4 = new FormInscription1();
            inscription4.ShowDialog();
        }
    }
}
