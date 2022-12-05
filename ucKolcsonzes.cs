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
    public partial class ucKolcsonzes : UserControl
    {
        public dsVT? dsVT { get; set; }
        //bool MentésFolyamatban;
        public ucKolcsonzes()
        {
            InitializeComponent();
        }

        private void ucFilm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible || dsVT == null) return;
            cbFilm.DataSource = dsVT.dtFilmek;
            cbFilm.DisplayMember = "Cim";

            var userList = dsVT.dtUser;
            userList.DefaultView.RowFilter = "id > 0";
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
     
        }
    
        private void btKölcsönöz_Click(object sender, EventArgs e)
        {
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

            var kivéve = false;
            for (int i = dsVT.dtFU.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dsVT.dtFU.Rows[i];
                if (dr["idFilmek"].ToString() == KiválasztottFilmId.ToString() && dr["idUser"].ToString() == "0")
                {
                    // Törlés a kapcsolótáblából
                    dr.Delete();
                    // Hozzáadás a táblához a user ID-val
                    dsVT.dtFU.AdddtFURow(KiválasztottFilmId, KiválasztottUserId);
                    // Üzenet
                    MessageBox.Show("A(z) " + KiválasztottFilm["Cim"] + " c. filmet sikeresen kikölcsönözte!");
                    // Sikeres kivét
                    kivéve = true;
                }
                //MessageBox.Show(dr["idFilmek"].ToString());
            }
            if(kivéve == false)
            {
                MessageBox.Show("A filmet már valaki kikölcsönözte!");
            }

        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cb);
        }
    }
}
