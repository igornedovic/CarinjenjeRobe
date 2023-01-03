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

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCStanjaProizvoda : UserControl
    {
        private BindingList<Stanje> stanjaProizvoda;
        private BindingList<Proizvod> proizvodi;
        private BindingList<Skladiste> skladista;
        private Stanje izabranoStanje;
        private int staraSifraProizvoda;
        public UCStanjaProizvoda()
        {
            InitializeComponent();

            try
            {
                stanjaProizvoda = new BindingList<Stanje>(KontrolerStn.Instanca.UcitajStanja());
                dgvStanja.DataSource = stanjaProizvoda;

                PrilagodiTabelu();

                proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
                cbProizvod.DataSource = proizvodi;
                cbProizvod.SelectedItem = null;

                skladista = new BindingList<Skladiste>(KontrolerStn.Instanca.UcitajSkladista());
                cbSkladiste.DataSource = skladista;
                cbSkladiste.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvStanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStanja.Columns["NazivTabele"].Visible = false;
            dgvStanja.Columns["InsertKolone"].Visible = false;
            dgvStanja.Columns["PrimarniKljuc"].Visible = false;
            dgvStanja.Columns["SpoljniKljuc"].Visible = false;
            dgvStanja.Columns["UslovSpajanja"].Visible = false;
            dgvStanja.Columns["InsertVrednosti"].Visible = false;
            dgvStanja.Columns["UpdateVrednosti"].Visible = false;
            dgvStanja.Columns["WhereUslov"].Visible = false;
            dgvStanja.Columns["OriginalnaSifraProizvoda"].Visible = false;
        }

        private void Osvezi()
        {
            cbProizvod.SelectedItem = null;
            txtNaziv.Text = "";
            cbSkladiste.SelectedItem = null;
            txtBruto.Text = "";
            txtNeto.Text = "";

            stanjaProizvoda = new BindingList<Stanje>(KontrolerStn.Instanca.UcitajStanja());
            dgvStanja.DataSource = stanjaProizvoda;

            btnSacuvaj.Enabled = true;
        }

        private void dgvStanja_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranoStanje = (Stanje)dgvStanja.SelectedRows[0].DataBoundItem;

                if (izabranoStanje != null)
                {
                    cbProizvod.SelectedItem = proizvodi.Where(p => p.SifraProizvoda == izabranoStanje.SifraProizvoda).FirstOrDefault();

                    staraSifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;

                    txtNaziv.Text = izabranoStanje.NazivProizvoda;

                    cbSkladiste.SelectedItem = skladista.Where(s => s.SkladisteId == izabranoStanje.SkladisteId).FirstOrDefault();

                    txtBruto.Text = izabranoStanje.BrutoMasa.ToString();

                    txtNeto.Text = izabranoStanje.NetoMasa.ToString();

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

            if (cbProizvod.SelectedItem == null)
            {
                cbProizvod.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbProizvod.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtNaziv.BackColor = Color.White;
            }

            if (cbSkladiste.SelectedItem == null)
            {
                cbSkladiste.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbSkladiste.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtBruto.Text))
            {
                txtBruto.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtBruto.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtNeto.Text))
            {
                txtNeto.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtNeto.BackColor = Color.White;
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
                izabranoStanje = new Stanje();
                izabranoStanje.SifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;
                izabranoStanje.NazivProizvoda = txtNaziv.Text;
                izabranoStanje.SkladisteId = ((Skladiste)cbSkladiste.SelectedItem).SkladisteId;
                izabranoStanje.BrutoMasa = double.Parse(txtBruto.Text);
                izabranoStanje.NetoMasa = double.Parse(txtNeto.Text);

                KontrolerStn.Instanca.SacuvajStanje(izabranoStanje);
                Osvezi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvStanja.SelectedRows.Count == 0 || dgvStanja.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati stanje koje zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabranoStanje.SifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;
                izabranoStanje.NazivProizvoda = txtNaziv.Text;
                izabranoStanje.SkladisteId = ((Skladiste)cbSkladiste.SelectedItem).SkladisteId;
                izabranoStanje.BrutoMasa = double.Parse(txtBruto.Text);
                izabranoStanje.NetoMasa = double.Parse(txtNeto.Text);

                KontrolerStn.Instanca.IzmeniStanje(izabranoStanje);
                Osvezi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u dozvoljenom formatu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OracleException oracleEx)
            {
                MessageBox.Show(oracleEx.Message , "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStanja.SelectedRows.Count == 0 || dgvStanja.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati stanje koje zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiStanje(izabranoStanje);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
