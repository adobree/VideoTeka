using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT
{
    public partial class ucFelhaszn : UserControl
    {
        public dsVT? dsVT { get; set; }
    bool MentésFolyamatban;
    private dsVT.dtUserRow? ÚjSor;
    public ucFelhaszn()
        {
            InitializeComponent();
        }

        private void ucFelhaszn_VisibleChanged(object sender, EventArgs e)
        {
      if (!Visible || dsVT == null) return;
      cbFelhasznalok.DataSource = dsVT.dtUser;
      cbFelhasznalok.DisplayMember = "Nev";
      cbFelhasznalok.SelectedIndex = 0;
    }

        private void cbFelhasznalok_SelectedIndexChanged(object sender, EventArgs e)
        {
      if (MentésFolyamatban) return;
      tbNev.Text = ((cbFelhasznalok.SelectedItem as DataRowView)?.Row
        as dsVT.dtUserRow)?.Nev;
      tbEmail.Text = ((cbFelhasznalok.SelectedItem as DataRowView)?.Row
        as dsVT.dtUserRow)?.Email;
    }

        private void btMent_Click(object sender, EventArgs e)
        {
      var id = ((cbFelhasznalok.SelectedItem as DataRowView)?.Row
        as dsVT.dtUserRow)?.id;
      if (id == 0) {
        MessageBox.Show("Ez a rekord nem modosithato!");
        return;
      }
      var rekord = (cbFelhasznalok.SelectedItem as DataRowView)?.Row
        as dsVT.dtUserRow;
      if (rekord == null) return;
      MentésFolyamatban = true;
      rekord.Nev = tbNev.Text;
      rekord.Email = tbEmail.Text;
      MentésFolyamatban = false;
      btUj.Enabled = true;
    }

        private void btMegse_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      if (ÚjSor != null)
        dsVT.dtUser.RemovedtUserRow(ÚjSor);
      btUj.Enabled = true;
    }

        private void btUj_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      var sor = (cbFelhasznalok.Items[cbFelhasznalok.Items.Count - 1] as
        DataRowView)?.Row as dsVT.dtUserRow;
      short sorszám;
      if (sor == null)
        sorszám = 1;
      else
        sorszám = (short)(sor.id + 1);
      ÚjSor = dsVT.dtUser.AdddtUserRow(sorszám, "Új nev", "Új email");
      cbFelhasznalok.SelectedIndex = cbFelhasznalok.Items.Count - 1;
      btUj.Enabled = false;
    }

        private void btTorol_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      var TöröltSor = (cbFelhasznalok.SelectedItem as DataRowView)?.Row as dsVT.dtUserRow;
      if (TöröltSor == null) return;
      dsVT.dtUser.RemovedtUserRow(TöröltSor);
      cbFelhasznalok_SelectedIndexChanged(cbFelhasznalok, new EventArgs());
      btUj.Enabled = true;
    }
    }
}
