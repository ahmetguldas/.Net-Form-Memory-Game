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
        public int KartAdet => satirAdet * sutunAdet;
        public Form1()
        {
            InitializeComponent();
            KartlariDiz();
        }

        private void KartlariDiz()
        {
            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);

            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.BackColor = Color.Red;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }
    }
}
