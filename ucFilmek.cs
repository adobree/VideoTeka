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
  public partial class ucFilmek : UserControl
  {

    public dsVT? dsVT { get; set; }
    bool MentésFolyamatban;
    private dsVT.dtFilmekRow? ÚjSor;
    public ucFilmek()
    {
      InitializeComponent();
    }

    private void ucFilmek_VisibleChanged(object sender, EventArgs e)
    {
      if (!Visible || dsVT == null) return;
      cbFilmek.DataSource = dsVT.dtFilmek;
      cbFilmek.DisplayMember = "Cim";
      cbFilmek.SelectedIndex = 0;
    }

        private void cbFilmek_SelectedIndexChanged(object sender, EventArgs e)
        {
      if (MentésFolyamatban) return;
      tbCim.Text = ((cbFilmek.SelectedItem as DataRowView)?.Row
        as dsVT.dtFilmekRow)?.Cim;
      if (MentésFolyamatban) return;
      tbEv.Text = ((cbFilmek.SelectedItem as DataRowView)?.Row
        as dsVT.dtFilmekRow)?.MegjEV.ToString();
    }

        private void btMent_Click(object sender, EventArgs e)
        {
      if (tbCim.Text.Length == 0) return;
      var rekord = (cbFilmek.SelectedItem as DataRowView)?.Row
        as dsVT.dtFilmekRow;
      if (rekord == null) return;
      MentésFolyamatban = true;
      rekord.Cim = tbCim.Text;
      rekord.MegjEV = Int32.Parse(tbEv.Text);
      MentésFolyamatban = false;
      btUj.Enabled = true;
    }

        private void btUj_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      var sor = (cbFilmek.Items[cbFilmek.Items.Count - 1] as
        DataRowView)?.Row as dsVT.dtFilmekRow;
      short sorszám;
      if (sor == null)
        sorszám = 1;
      else
        sorszám = (short)(sor.id + 1);
      ÚjSor = dsVT.dtFilmek.AdddtFilmekRow(sorszám, "Újcím", 0000);
      cbFilmek.SelectedIndex = cbFilmek.Items.Count - 1;
      btUj.Enabled = false;
    }

        private void btMegse_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      if (ÚjSor != null)
        dsVT.dtFilmek.RemovedtFilmekRow(ÚjSor);
      btUj.Enabled = true;

    }

        private void btTorles_Click(object sender, EventArgs e)
        {
      if (dsVT == null) return;
      var TöröltSor = (cbFilmek.SelectedItem as DataRowView)?.Row as dsVT.dtFilmekRow;
      if (TöröltSor == null) return;
      dsVT.dtFilmek.RemovedtFilmekRow(TöröltSor);
      cbFilmek_SelectedIndexChanged(cbFilmek, new EventArgs());
      btUj.Enabled = true;
    }
    }
}
