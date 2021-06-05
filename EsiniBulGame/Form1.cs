using EsiniBulGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulGame
{
    public partial class Form1 : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] resimHavuzu;
        int[] resimler;
        public int KartAdet => satirAdet * sutunAdet;
        public Form1()
        {
            InitializeComponent();
            ImageHavuzunuDoldur();
            KartlariDiz();

        }

        private void ImageHavuzunuDoldur()
        {
            resimHavuzu = Enumerable.Range(1, 50).ToArray();
            Islemler.Karistir(resimHavuzu);
        }

        private void ResimleriDoldur()
        {
            resimler = new int[KartAdet];
            Array.Copy(resimHavuzu, resimler, KartAdet / 2);
            Array.Copy(resimHavuzu, 0, resimler, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(resimler);
        }

        private void KartlariDiz()
        {
            ResimleriDoldur();

            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);

            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + resimler[i]);
                pb.BackColor = Color.Gainsboro;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }
    }
}
