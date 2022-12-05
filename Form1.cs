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
          try
            {
              dsVT.WriteXml("VT.xml", XmlWriteMode.IgnoreSchema);
              MessageBox.Show("Sikeres ment�s!");
            } catch {
              MessageBox.Show("SIKERTELEN ment�s!");
            }
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
            dsVT.dtUser.AdddtUserRow(0, "RAKTAR", "raktar@raktar.com");
            dsVT.dtFU.AdddtFURow(1, 1);
            dsVT.dtFU.AdddtFURow(2, 3);
        }

        private void Betolt()
        {
            try
            {
                dsVT.ReadXml("VT.xml",
                      XmlReadMode.InferSchema);
            }
            catch (Exception)
            {
                Letrehoz();
                Lement();
            }
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void filmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
      ucFilmek.dsVT = dsVT;

      ucFilmek.Visible = true;
      dgv.Visible = true;
      dgv.DataSource = dsVT.dtFilmek;
    }

        private void felhaszn�l�kToolStripMenuItem_Click(object sender, EventArgs e)
        {
      ucFilmek.Visible = false;
      dgv.Visible = true;
      dgv.DataSource = dsVT.dtUser;

    }

        private void rakt�rToolStripMenuItem_Click(object sender, EventArgs e)
        {

      ucFilmek.Visible = false;
            ucKolcsonzes.Visible = false;
            dgv.Visible = true;

            var filmek = from f in dsVT.dtFilmek
                         join fu in dsVT.dtFU
                          on f.id equals fu.idFilmek
                         where fu.idUser == 0   // Kiv�lasztjuk azt a filmet, ahol az "idUser" 0 (Rakt�r)
                         select new
                         {
                             Filmek = f.Cim,
                             fu.idFilmek
                         };
            dgv.DataSource = filmek.ToList();
        } 

        private void kIBEToolStripMenuItem_Click(object sender, EventArgs e)
        {

      ucFilmek.Visible = false;
            dgv.Visible = false;
            ucKolcsonzes.dsVT = dsVT;
            ucKolcsonzes.Visible = true;
            ucKolcsonzes.Dock = DockStyle.Fill;
        }

        private void ucFilm_Load(object sender, EventArgs e)
        {

        }

    private void ucFelhasznalok_Load(object sender, EventArgs e)
    {

    }

    private void ment�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lement();
        }
    }
}