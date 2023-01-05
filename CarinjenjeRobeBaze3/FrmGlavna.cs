using CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarinjenjeRobeBaze3
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void OsveziPanel(UserControl userControl)
        {
            pnlGlavni.Controls.Clear();
            userControl.Parent = pnlGlavni;
            userControl.Dock = DockStyle.Fill;
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCProizvod());
        }

        private void btnStanje_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCStanjaProizvoda());
        }

        private void btnCarinarnice_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCCarinarnica());
        }

        private void btnObracun_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCObracun());
        }

        private void btnSazetaDeklaracija_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCSazetaDeklaracija());
        }

        private void btnSazete_Click(object sender, EventArgs e)
        {
            OsveziPanel(new UCPretragaSazetihDeklaracija());
        }
    }
}
