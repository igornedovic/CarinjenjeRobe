using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
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

namespace CarinjenjeRobeBaze3.Pogled.Forme
{
    public partial class FrmCarinik : Form
    {
        private BindingList<Carinik> carinici;
        private BindingList<Carinarnica> carinarnice;
        private Carinik izabraniCarinik;
        public FrmCarinik()
        {
            InitializeComponent();

            try
            {
                carinici = new BindingList<Carinik>(KontrolerStn.Instanca.UcitajCarinike());
                dgvCarinici.DataSource = carinici;

                PrilagodiTabelu();

                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                cbCarinarnica.DataSource = carinarnice;
                cbCarinarnica.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvCarinici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarinici.Columns["NazivTabele"].Visible = false;
            dgvCarinici.Columns["InsertKolone"].Visible = false;
            dgvCarinici.Columns["PrimarniKljuc"].Visible = false;
            dgvCarinici.Columns["SpoljniKljuc"].Visible = false;
            dgvCarinici.Columns["UslovSpajanja"].Visible = false;
            dgvCarinici.Columns["InsertVrednosti"].Visible = false;
            dgvCarinici.Columns["UpdateVrednosti"].Visible = false;
            dgvCarinici.Columns["WhereUslov"].Visible = false;
        }

        private void Osvezi()
        {
            txtImePrezime.Text = "";
            cbCarinarnica.SelectedItem = null;

            carinici = new BindingList<Carinik>(KontrolerStn.Instanca.UcitajCarinike());
            dgvCarinici.DataSource = carinici;

            btnSacuvaj.Enabled = true;
        }

        private void dgvCarinici_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabraniCarinik = (Carinik)dgvCarinici.SelectedRows[0].DataBoundItem;

                if (izabraniCarinik != null)
                {
                    txtImePrezime.Text = izabraniCarinik.ImePrezime;

                    cbCarinarnica.SelectedItem = carinarnice.Where(c => c.SifraCarinarnice == izabraniCarinik.SifraCarinarnice).FirstOrDefault();

                    btnSacuvaj.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private bool ValidacijaUnosa()
        {
            bool uspesno = true;

            if (cbCarinarnica.SelectedItem == null)
            {
                cbCarinarnica.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbCarinarnica.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtImePrezime.Text))
            {
                txtImePrezime.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtImePrezime.BackColor = Color.White;
            }


            return uspesno;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosa())
            {
                return;
            }

            try
            {
                izabraniCarinik = new Carinik();
                izabraniCarinik.ImePrezime = txtImePrezime.Text;
                izabraniCarinik.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;

                KontrolerStn.Instanca.SacuvajCarinika(izabraniCarinik);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvCarinici.SelectedRows.Count == 0 || dgvCarinici.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati carinika kojeg zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabraniCarinik.ImePrezime = txtImePrezime.Text;
                izabraniCarinik.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;

                KontrolerStn.Instanca.IzmeniCarinika(izabraniCarinik);
                Osvezi();
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
            if (dgvCarinici.SelectedRows.Count == 0 || dgvCarinici.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati carinika kojeg zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiCarinika(izabraniCarinik);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
