using EsiniBulGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        List<PictureBox> acilanlar;
        readonly ZorlukSeviye _zorlukSeviye;

        public int KartAdet => satirAdet * sutunAdet;
        public Form1(ZorlukSeviye zorlukSeviye)
        {
            _zorlukSeviye = zorlukSeviye;
            SeviyeAyarla();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            ImageHavuzunuDoldur();
            KartlariDiz();
        }

        private void SeviyeAyarla()
        {
            switch (_zorlukSeviye)
            {
                case ZorlukSeviye.Kolay:
                    satirAdet = sutunAdet = 4;
                    break;
                case ZorlukSeviye.Orta:
                    satirAdet = sutunAdet = 6;
                    break;
                case ZorlukSeviye.Zor:
                    satirAdet = sutunAdet = 8;
                    break;
                default:
                    throw new Exception("Olmayan bir seviye secimi yapildi.");
                    break;
            }
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
                pb.Tag = i;
                pb.Click += Pb_Click;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Resources.block;
                pb.BackColor = Color.Gainsboro;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (acilanlar.Count == 1 && pb == acilanlar[0])
            {
                return;
            }

            if (acilanlar.Count == 2)
            {
                AcikKartlariKapat();
            }
            acilanlar.Add(pb);
            int index = (int)pb.Tag;
            int resimNo = resimler[index];
            pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + resimNo);
            pb.Refresh();

            if (acilanlar.Count == 2 && AcilanlarAyniysa())
            {
                Thread.Sleep(500);
                AcikKartlariGizle();
            }


        }

        private bool AcilanlarAyniysa()
        {
            int index1 = (int)acilanlar[0].Tag;
            int index2 = (int)acilanlar[1].Tag;
            return resimler[index1] == resimler[index2];

        }

        private void AcikKartlariGizle()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                pictureBox.Hide();
            }
            acilanlar.Clear();
        }

        private void AcikKartlariKapat()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                pictureBox.Image = Resources.block;
            }
            acilanlar.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
