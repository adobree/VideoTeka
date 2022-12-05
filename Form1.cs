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
      dsVT.dtFilmek.AdddtFilmekRow(4, "Erin Brockovich - Z�r�s term�szet", 1990);
      dsVT.dtFilmek.AdddtFilmekRow(5, "Batman", 1995);
      dsVT.dtUser.AdddtUserRow(1, "Kovacs Adam", "ado.kovacs@gmail.com");
      dsVT.dtUser.AdddtUserRow(2, "Nagy Gabor", "anagybogar@gmail.com");
      dsVT.dtUser.AdddtUserRow(3, "Komives-Kaldi Csilla", "komivescs@gmail.com");
      dsVT.dtFU.AdddtFURow(1, 1);
      dsVT.dtFU.AdddtFURow(2, 3);
    }

        private void Betolt()
    		{
			      try {
				      dsVT.ReadXml("VT.xml",
                    XmlReadMode.InferSchema);
			        } catch (Exception) {
				        Letrehoz();
                Lement();
              }
		      }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e) // KILEP - KESZ
        {
             Close();
        }

        private void filmekToolStripMenuItem_Click(object sender, EventArgs e) // FILMEK
        {
      dgv.Visible = true;
      //dgv.Dock = DockStyle.Fill;
      dgv.DataSource = dsVT.dtFilmek;
    }

        private void felhaszn�l�kToolStripMenuItem_Click(object sender, EventArgs e) // FELHASZNALOK
        {
      dgv.Visible = true;
      //dgv.Dock = DockStyle.Fill;
      dgv.DataSource = dsVT.dtUser;

    }

        private void ment�sToolStripMenuItem_Click(object sender, EventArgs e) // MENTES - KESZ
        {
      Lement();
        }

        private void kIBEToolStripMenuItem_Click(object sender, EventArgs e) // KIBE
        {

        }
    }
}