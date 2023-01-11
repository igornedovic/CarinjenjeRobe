using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.Pogled.Forme;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCPretragaJCI : UserControl
    {
        private BindingList<JCI> listaJCI;
        private JCI izabranaJCI;

        private BindingList<Primalac> primaoci;
        private BindingList<JCI> listaJCIPoKriterijumu;

        public UCPretragaJCI()
        {
            InitializeComponent();

            try
            {
                listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                dgvJCI.DataSource = listaJCI;
                dgvJCIDetalji.DataSource = listaJCI;

                PrilagodiTabele();

                primaoci = new BindingList<Primalac>(KontrolerStn.Instanca.UcitajPrimaoce());
                cbPrimalac.DataSource = primaoci;
                cbPrimalac.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabele()
        {
            dgvJCI.Columns["NazivTabele"].Visible = false;
            dgvJCI.Columns["InsertKolone"].Visible = false;
            dgvJCI.Columns["PrimarniKljuc"].Visible = false;
            dgvJCI.Columns["SpoljniKljuc"].Visible = false;
            dgvJCI.Columns["UslovSpajanja"].Visible = false;
            dgvJCI.Columns["InsertVrednosti"].Visible = false;
            dgvJCI.Columns["UpdateVrednosti"].Visible = false;
            dgvJCI.Columns["WhereUslov"].Visible = false;
            dgvJCI.Columns["BrojSazDeklaracije"].Visible = false;
            dgvJCI.Columns["PosiljalacId"].Visible = false;
            dgvJCI.Columns["Primalac"].Visible = false;
            dgvJCI.Columns["SifraRadnika"].Visible = false;
            dgvJCI.Columns["DrzavaOtpremeId"].Visible = false;
            dgvJCI.Columns["DrzavaPoreklaId"].Visible = false;
            dgvJCI.Columns["MestoId"].Visible = false;
            dgvJCI.Columns["BrojTablice"].Visible = false;
            dgvJCI.Columns["SifraCarinarnice"].Visible = false;
            dgvJCI.Columns["UslovId"].Visible = false;
            dgvJCI.Columns["SkladisteId"].Visible = false;
            dgvJCI.Columns["DatumJCI"].DefaultCellStyle.Format = "dd-MM-yyyy";

            dgvJCIDetalji.Columns["NazivTabele"].Visible = false;
            dgvJCIDetalji.Columns["InsertKolone"].Visible = false;
            dgvJCIDetalji.Columns["PrimarniKljuc"].Visible = false;
            dgvJCIDetalji.Columns["SpoljniKljuc"].Visible = false;
            dgvJCIDetalji.Columns["UslovSpajanja"].Visible = false;
            dgvJCIDetalji.Columns["InsertVrednosti"].Visible = false;
            dgvJCIDetalji.Columns["UpdateVrednosti"].Visible = false;
            dgvJCIDetalji.Columns["WhereUslov"].Visible = false;
            dgvJCIDetalji.Columns["DatumJCI"].Visible = false;
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbPrimalac.SelectedItem == null)
            {
                cbPrimalac.BackColor = Color.Salmon;
                return;
            }

            Primalac primalacKriterijum = ((Primalac)cbPrimalac.SelectedItem);

            listaJCIPoKriterijumu = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI(primalacKriterijum));

            dgvJCI.DataSource = null;
            dgvJCIDetalji.DataSource = null;

            if (listaJCIPoKriterijumu.Count > 0)
            {
                dgvJCI.DataSource = listaJCIPoKriterijumu;
                dgvJCIDetalji.DataSource = listaJCIPoKriterijumu;

                PrilagodiTabele();
            }
            else
            {
                MessageBox.Show("Ne postoje JCI po zadatom kriterijumu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            cbPrimalac.SelectedItem = null;
            dgvJCI.DataSource = null;
            dgvJCIDetalji.DataSource = null;
            dgvJCI.DataSource = listaJCI;
            dgvJCIDetalji.DataSource = listaJCI;

            PrilagodiTabele();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmJCI frmJCI = new FrmJCI();

            if (frmJCI.ShowDialog() == DialogResult.OK)
            {
                frmJCI.Dispose();
                listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                dgvJCI.DataSource = listaJCI;
                dgvJCIDetalji.DataSource = listaJCI;
            }
        }

        private void dgvJCI_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranaJCI = (JCI)dgvJCI.SelectedRows[0].DataBoundItem;

            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvJCI.SelectedRows.Count == 0 || dgvJCI.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati JCI koju zelite da izmenite iz prve tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FrmJCI frmJCI = new FrmJCI("UPDATE", izabranaJCI);

                if (frmJCI.ShowDialog() == DialogResult.OK)
                {
                    frmJCI.Dispose();
                    listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                    dgvJCI.DataSource = listaJCI;
                    dgvJCIDetalji.DataSource = listaJCI;
                }
            }
            catch (OracleException oracleEx)
            {

                MessageBox.Show(oracleEx.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvJCI.SelectedRows.Count == 0 || dgvJCI.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati JCI koju zelite da obrisete iz prve tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiJCI(izabranaJCI);
                listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                dgvJCI.DataSource = listaJCI;
                dgvJCIDetalji.DataSource = listaJCI;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
