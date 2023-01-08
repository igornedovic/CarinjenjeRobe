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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCVozilo : UserControl
    {
        private BindingList<Vozilo> vozila;
        private Vozilo izabranoVozilo;
        public UCVozilo()
        {
            InitializeComponent();

            try
            {
                vozila = new BindingList<Vozilo>(KontrolerStn.Instanca.UcitajVozila());
                dgvVozila.DataSource = vozila;

                PrilagodiTabelu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvVozila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVozila.Columns["NazivTabele"].Visible = false;
            dgvVozila.Columns["InsertKolone"].Visible = false;
            dgvVozila.Columns["PrimarniKljuc"].Visible = false;
            dgvVozila.Columns["SpoljniKljuc"].Visible = false;
            dgvVozila.Columns["UslovSpajanja"].Visible = false;
            dgvVozila.Columns["InsertVrednosti"].Visible = false;
            dgvVozila.Columns["UpdateVrednosti"].Visible = false;
            dgvVozila.Columns["WhereUslov"].Visible = false;
        }

        private void Osvezi()
        {
            txtBrojTablice.Text = null;
            txtNacionalnost.Text = null;
            txtBrojPrikolice.Text = null;
            txtTipVozila.Text = null;

            vozila = new BindingList<Vozilo>(KontrolerStn.Instanca.UcitajVozila());
            dgvVozila.DataSource = vozila;
            btnSacuvaj.Enabled = true;
        }

        private bool ValidacijaUnosa()
        {
            bool uspesno = true;

            if (string.IsNullOrWhiteSpace(txtBrojTablice.Text))
            {
                txtBrojTablice.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtBrojTablice.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtTipVozila.Text))
            {
                txtTipVozila.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtTipVozila.BackColor = Color.White;
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
                izabranoVozilo = new Vozilo();

                var regex = new Regex(@"^[A-Z]{2}\-[0-9]{1,4}\-[A-Z]{2}?$");

                if (!regex.IsMatch(txtBrojTablice.Text))
                {
                    txtBrojTablice.BackColor = Color.Salmon;
                    throw new FormatException();
                }
                else
                {
                    txtBrojTablice.BackColor = Color.White;
                }

                if (txtBrojPrikolice.Text != null && !regex.IsMatch(txtBrojPrikolice.Text))
                {
                    txtBrojPrikolice.BackColor = Color.Salmon;
                    throw new FormatException();
                }
                else
                {
                    txtBrojPrikolice.BackColor = Color.White;
                }

                izabranoVozilo.BrojTablice = txtBrojTablice.Text;
                izabranoVozilo.Nacionalnost = txtNacionalnost.Text;
                izabranoVozilo.BrojPrikolice = txtBrojPrikolice.Text;
                izabranoVozilo.TipVozila = txtTipVozila.Text;

                KontrolerStn.Instanca.SacuvajVozilo(izabranoVozilo);
                Osvezi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvVozila_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranoVozilo = (Vozilo)dgvVozila.SelectedRows[0].DataBoundItem;

                if (izabranoVozilo != null)
                {
                    txtBrojTablice.Text = izabranoVozilo.BrojTablice;
                    txtNacionalnost.Text = izabranoVozilo.Nacionalnost;
                    txtBrojPrikolice.Text = izabranoVozilo.BrojPrikolice;
                    txtTipVozila.Text = izabranoVozilo.TipVozila;

                    btnSacuvaj.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count == 0 || dgvVozila.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati vozilo koje zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var regex = new Regex(@"^[A-Z]{2}\-[0-9]{1,4}\-[A-Z]{2}?$");

                if (!regex.IsMatch(txtBrojTablice.Text))
                {
                    txtBrojTablice.BackColor = Color.Salmon;
                    throw new FormatException();
                }
                else
                {
                    txtBrojTablice.BackColor = Color.White;
                }

                if (txtBrojPrikolice.Text != null && !regex.IsMatch(txtBrojPrikolice.Text))
                {
                    txtBrojPrikolice.BackColor = Color.Salmon;
                    throw new FormatException();
                }
                else
                {
                    txtBrojPrikolice.BackColor = Color.White;
                }

                izabranoVozilo.BrojTablice = txtBrojTablice.Text;
                izabranoVozilo.Nacionalnost = txtNacionalnost.Text;
                izabranoVozilo.BrojPrikolice = txtBrojPrikolice.Text;
                izabranoVozilo.TipVozila = txtTipVozila.Text;

                KontrolerStn.Instanca.IzmeniVozilo(izabranoVozilo);
                Osvezi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvVozila.SelectedRows.Count == 0 || dgvVozila.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati vozilo koje zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiVozilo(izabranoVozilo);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
