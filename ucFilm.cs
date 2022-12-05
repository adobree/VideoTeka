using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (cbFilm.DataSource == null) return;
            //cbFilm.DataSourc
        }

        private void btKölcsönöz_Click(object sender, EventArgs e)
        {
            
        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cb);
        }
    }
}
