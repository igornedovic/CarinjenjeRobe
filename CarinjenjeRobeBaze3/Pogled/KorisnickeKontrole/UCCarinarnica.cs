using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.Pogled.Forme;
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
    public partial class UCCarinarnica : UserControl
    {
        private FrmCarinik frmCarinik;

        private BindingList<Carinarnica> carinarnice;
        private Carinarnica izabranaCarinarnica;
        public UCCarinarnica()
        {
            InitializeComponent();

            try
            {
                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                dgvCarinarnice.DataSource = carinarnice;

                PrilagodiTabelu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvCarinarnice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarinarnice.Columns["NazivTabele"].Visible = false;
            dgvCarinarnice.Columns["InsertKolone"].Visible = false;
            dgvCarinarnice.Columns["PrimarniKljuc"].Visible = false;
            dgvCarinarnice.Columns["SpoljniKljuc"].Visible = false;
            dgvCarinarnice.Columns["UslovSpajanja"].Visible = false;
            dgvCarinarnice.Columns["InsertVrednosti"].Visible = false;
            dgvCarinarnice.Columns["UpdateVrednosti"].Visible = false;
            dgvCarinarnice.Columns["WhereUslov"].Visible = false;
        }

        private void Osvezi()
        {
            txtNaziv.Text = "";
            txtTekuci.Text = "";
            carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
            dgvCarinarnice.DataSource = carinarnice;
            btnSacuvaj.Enabled = true;
        }

        private void btnCarinici_Click(object sender, EventArgs e)
        {
            frmCarinik = new FrmCarinik();

            if (frmCarinik.ShowDialog() == DialogResult.OK)
            {
                frmCarinik.Dispose();
            }
        }

        private void dgvCarinarnice_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranaCarinarnica = (Carinarnica)dgvCarinarnice.SelectedRows[0].DataBoundItem;

                if (izabranaCarinarnica != null)
                {
                    txtNaziv.Text = izabranaCarinarnica.NazivCarinarnice;
                    txtTekuci.Text = izabranaCarinarnica.TekuciRacun;

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

            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtNaziv.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtTekuci.Text))
            {
                txtTekuci.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtTekuci.BackColor = Color.White;
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
                var regex = new Regex(@"^[0-9]{3}\-[0-9]{6}\-[0-9]{2}?$");

                if (!regex.IsMatch(txtTekuci.Text))
                {
                    throw new FormatException();
                }

                izabranaCarinarnica = new Carinarnica();
                izabranaCarinarnica.NazivCarinarnice = txtNaziv.Text;
                izabranaCarinarnica.TekuciRacun = txtTekuci.Text;

                KontrolerStn.Instanca.SacuvajCarinarnicu(izabranaCarinarnica);
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
            if (dgvCarinarnice.SelectedRows.Count == 0 || dgvCarinarnice.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati carinarnicu koju zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var regex = new Regex(@"^[0-9]{3}\-[0-9]{6}\-[0-9]{2}?$");

                if (!regex.IsMatch(txtTekuci.Text))
                {
                    throw new FormatException();
                }

                izabranaCarinarnica.NazivCarinarnice = txtNaziv.Text;
                izabranaCarinarnica.TekuciRacun = txtTekuci.Text;


                KontrolerStn.Instanca.IzmeniCarinarnicu(izabranaCarinarnica);
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvCarinarnice.SelectedRows.Count == 0 || dgvCarinarnice.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati carinarnicu koju zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiCarinarnicu(izabranaCarinarnica);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
