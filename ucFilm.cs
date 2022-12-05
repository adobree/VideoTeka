using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT
{
    public partial class ucFilm : UserControl
    {
        public dsVT? dsVT { get; set; }
        bool MentésFolyamatban;
        public ucFilm()
        {
            InitializeComponent();
        }

        private void ucFilm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible || dsVT == null) return;
            cbFilm.DataSource = dsVT.dtFilmek;
            cbFilm.DisplayMember = "Cim";

            cbUser.DataSource = dsVT.dtUser;
            cbUser.DisplayMember = "Nev";
            
            cbUser.SelectedIndex = 0;
            cbFilm.SelectedIndex = 0;
        }

        private void btVisszahoz_Click(object sender, EventArgs e)
        {
            if (dsVT == null) return;
            if (cbFilm.DataSource == null) return;
            // Kiválasztott film
            var KiválasztottFilm = (cbFilm.SelectedItem as DataRowView)?.Row
                as dsVT.dtFilmekRow;
            // Kiválasztott user
            var KiválasztottUser = (cbUser.SelectedItem as DataRowView)?.Row
                 as dsVT.dtUserRow;
            // Kiválasztott user id-ja
            var KiválasztottUserId = (from u in dsVT.dtUser
                                     where u.Nev == (cbUser.SelectedItem as DataRowView)?.Row["Nev"] as string
                                     select u.id).FirstOrDefault();
            // Kiválasztott user id-ja
            var KiválasztottFilmId = (from u in dsVT.dtFilmek
                                      where u.Cim == (cbFilm.SelectedItem as DataRowView)?.Row["Cim"] as string
                                      select u.id).FirstOrDefault();
            // MessageBox.Show(KiválasztottFilmId.ToString());
            var törölve = false;
            for (int i = dsVT.dtFU.Rows.Count - 1; i>= 0; i--)
            {
                DataRow dr = dsVT.dtFU.Rows[i];
                if (dr["idUser"].ToString() == KiválasztottUserId.ToString() && dr["idFilmek"].ToString() == KiválasztottFilmId.ToString())
                {
                    // Törlés a kapcsolótáblából
                    dr.Delete();
                    // Üzenet
                    MessageBox.Show("A film visszavételét a raktárba sikeresen rögzítette");
                    // Hozzáadás a kapcsolótáblához RAKTAR id-val
                    dsVT.dtFU.AdddtFURow(KiválasztottFilmId, 0);
                    // Sikeres törlés
                    törölve = true;
                }
                //MessageBox.Show(dr["idFilmek"].ToString());
            }
            // Ha a felhasználó nem kölcsönözte ki azt a könyvet, akkor nem töröltünk a táblából
            if(törölve == false)
            {
                MessageBox.Show(KiválasztottUser["Nev"].ToString() + " felhasználónak nem volt kikölcsönözve a(z) " + KiválasztottFilm["Cim"].ToString() + " c. film");
            };
            dsVT.dtFU.AcceptChanges();
            //cbFilm.DataSourc
            //foreach (DataRow dr in dsVT.dtFU)
            //{
            //    if()
            //}
        }
        private void törlés()
        {
            //if (dsVT == null) return;
            //var TöröltSor = (cbFilm.SelectedItem as DataRowView)?.Row as dsVT.dtFURow;
            //if(TöröltSor == null) return;
            ////dsVT.dtFURow.Removed(TöröltSor);
            //MessageBox.Show("Törlés!");
        }
        private void btKölcsönöz_Click(object sender, EventArgs e)
        {
            törlés();
            //var KiválasztottSorokSzáma = 
            if (dsVT == null) return;
            var KiválasztottFilm = (cbFilm.SelectedItem as DataRowView)?.Row 
                as dsVT.dtFilmekRow;
            var KiválasztottUser = (cbUser.SelectedItem as DataRowView)?.Row
                 as dsVT.dtUserRow;
            var Kölcsönözve = from i in dsVT.dtFU
                              where i.idFilmek.ToString() == KiválasztottFilm["id"]
                              select new
                              {
                                  i.idFilmek
                              };
            MessageBox.Show(Kölcsönözve.ToString());
            var res = from sor in dsVT.dtFU
                      where sor.idFilmek == KiválasztottFilm.id &&
                      sor.idFilmek == KiválasztottUser.id
                      select sor;
            if(res.Count() > 0)
            {
                MessageBox.Show("A film tényleg ki van véve");
                return;
            }
          MessageBox.Show(KiválasztottFilm["Cim"] as string);

        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cb);
        }
    }
}
