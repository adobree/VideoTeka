using System.Data;
using System.Drawing.Drawing2D;

namespace VT
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            //Letrehoz();
            //Lement();
            Betolt();  
        }

        private void Lement()
        {
      dsVT.WriteXml("VT.xml",XmlWriteMode.IgnoreSchema);
        }

        private void Letrehoz()
        {
            dsVT.dtFilmek.AdddtFilmekRow(1, "Godzilla", 1990);
            dsVT.dtFilmek.AdddtFilmekRow(2, "Micsoda No", 1992);
            dsVT.dtFilmek.AdddtFilmekRow(3, "Haz a tonal", 1993);
            dsVT.dtFilmek.AdddtFilmekRow(4, "Erin Brockovich - Zûrös természet", 1990);
            dsVT.dtFilmek.AdddtFilmekRow(5, "Batman", 1995);
            dsVT.dtUser.AdddtUserRow(1, "Kovacs Adam", "ado.kovacs@gmail.com");
            dsVT.dtUser.AdddtUserRow(2, "Nagy Gabor", "anagybogar@gmail.com");
            dsVT.dtUser.AdddtUserRow(3, "Komives-Kaldi Csilla", "komivescs@gmail.com");
            dsVT.dtUser.AdddtUserRow(4, "RAKTAR", "raktar@raktar.com");
            dsVT.dtFU.AdddtFURow(1, 1);
            dsVT.dtFU.AdddtFURow(2, 3);
        }

        private void Betolt()
        {
            dsVT.ReadXml("VT.xml",
              XmlReadMode.InferSchema);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void filmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
      dgv.Visible = true;
      dgv.Dock = DockStyle.Fill;
      dgv.DataSource = dsVT.dtFilmek;
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
      dgv.Visible = true;
      dgv.Dock = DockStyle.Fill;
      dgv.DataSource = dsVT.dtUser;
    }

        private void raktárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Visible = true;
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = dsVT.dtUser;
        }
    }
}