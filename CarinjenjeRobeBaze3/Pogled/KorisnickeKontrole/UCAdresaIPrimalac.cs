using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
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
    public partial class UCAdresaIPrimalac : UserControl
    {
        private BindingList<Adresa> adrese;
        private BindingList<Mesto> mesta;
        private Adresa izabranaAdresa = new Adresa();

        private BindingList<Primalac> primaoci;
        private BindingList<Adresa> adresePrimalaca;
        private Primalac izabraniPrimalac = new Primalac();
        public UCAdresaIPrimalac()
        {
            InitializeComponent();

            try
            {
                adrese = new BindingList<Adresa>(KontrolerStn.Instanca.UcitajAdrese());
                dgvAdrese.DataSource = adrese;

                PrilagodiTabeluAdresa();

                mesta = new BindingList<Mesto>(KontrolerStn.Instanca.UcitajMesta());
                cbMesto.DataSource = mesta;
                cbMesto.SelectedItem = null;


                primaoci = new BindingList<Primalac>(KontrolerStn.Instanca.UcitajPrimaoce());
                dgvPrimaoci.DataSource = primaoci;

                PrilagodiTabeluPrimalac();

                adresePrimalaca = new BindingList<Adresa>(adrese);
                cbAdresaPrimaoca.DataSource = adresePrimalaca;
                cbAdresaPrimaoca.SelectedItem = null;
                txtMestoPrimaoca.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabeluAdresa()
        {
            dgvAdrese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdrese.Columns["NazivTabele"].Visible = false;
            dgvAdrese.Columns["InsertKolone"].Visible = false;
            dgvAdrese.Columns["PrimarniKljuc"].Visible = false;
            dgvAdrese.Columns["SpoljniKljuc"].Visible = false;
            dgvAdrese.Columns["UslovSpajanja"].Visible = false;
            dgvAdrese.Columns["InsertVrednosti"].Visible = false;
            dgvAdrese.Columns["UpdateVrednosti"].Visible = false;
            dgvAdrese.Columns["WhereUslov"].Visible = false;
            dgvAdrese.Columns["OriginalnoMestoId"].Visible = false;
        }

        private void OsveziAdresu()
        {
            cbMesto.SelectedItem = null;
            txtUlica.Text = "";
            txtBroj.Text = "";
            adrese = new BindingList<Adresa>(KontrolerStn.Instanca.UcitajAdrese());
            dgvAdrese.DataSource = adrese;
            btnSacuvajAdresu.Enabled = true;
        }

        private bool ValidacijaUnosaAdrese()
        {
            bool uspesno = true;

            if (cbMesto.SelectedItem == null)
            {
                cbMesto.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbMesto.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtUlica.Text))
            {
                txtUlica.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtUlica.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtBroj.Text))
            {
                txtBroj.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtBroj.BackColor = Color.White;
            }

            return uspesno;
        }

        private void btnSacuvajAdresu_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosaAdrese())
            {
                return;
            }

            try
            {
                izabranaAdresa.MestoId = ((Mesto)cbMesto.SelectedItem).MestoId;
                izabranaAdresa.UlicaBroj = new UlicaBroj
                {
                    NazivUlice = txtUlica.Text,
                    Broj = txtBroj.Text
                };

                KontrolerStn.Instanca.SacuvajAdresu(izabranaAdresa);
                OsveziAdresu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdrese_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranaAdresa = (Adresa)dgvAdrese.SelectedRows[0].DataBoundItem;
                izabranaAdresa.OriginalnoMestoId = izabranaAdresa.MestoId;

                if (izabranaAdresa != null)
                {
                    cbMesto.SelectedItem = mesta.Where(m => m.MestoId == izabranaAdresa.MestoId).FirstOrDefault();
                    txtUlica.Text = izabranaAdresa.UlicaBroj.NazivUlice;
                    txtBroj.Text = izabranaAdresa.UlicaBroj.Broj;
                    btnSacuvajAdresu.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeniAdresu_Click(object sender, EventArgs e)
        {
            if (dgvAdrese.SelectedRows.Count == 0 || dgvAdrese.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati adresu koju zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabranaAdresa.MestoId = ((Mesto)cbMesto.SelectedItem).MestoId; ;
                izabranaAdresa.UlicaBroj = new UlicaBroj
                {
                    NazivUlice = txtUlica.Text,
                    Broj = txtBroj.Text
                };

                KontrolerStn.Instanca.IzmeniAdresu(izabranaAdresa);
                OsveziAdresu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiAdresu_Click(object sender, EventArgs e)
        {
            if (dgvAdrese.SelectedRows.Count == 0 || dgvAdrese.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati adresu koju zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiAdresu(izabranaAdresa);
                OsveziAdresu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabeluPrimalac()
        {
            dgvPrimaoci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrimaoci.Columns["NazivTabele"].Visible = false;
            dgvPrimaoci.Columns["InsertKolone"].Visible = false;
            dgvPrimaoci.Columns["PrimarniKljuc"].Visible = false;
            dgvPrimaoci.Columns["SpoljniKljuc"].Visible = false;
            dgvPrimaoci.Columns["UslovSpajanja"].Visible = false;
            dgvPrimaoci.Columns["InsertVrednosti"].Visible = false;
            dgvPrimaoci.Columns["UpdateVrednosti"].Visible = false;
            dgvPrimaoci.Columns["WhereUslov"].Visible = false;
            dgvPrimaoci.Columns["OriginalanPrimalacId"].Visible = false;
        }

        private void OsveziPrimaoca()
        {
            txtNazivPrimaoca.Text = "";
            txtPIB.Text = "";
            cbAdresaPrimaoca.SelectedItem = null;
            txtMestoPrimaoca.Text = "";
            primaoci = new BindingList<Primalac>(KontrolerStn.Instanca.UcitajPrimaoce());
            dgvPrimaoci.DataSource = primaoci;
            btnSacuvajPrimaoca.Enabled = true;
        }

        private bool ValidacijaUnosaPrimaoca()
        {
            bool uspesno = true;

            if (cbAdresaPrimaoca.SelectedItem == null)
            {
                cbAdresaPrimaoca.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbAdresaPrimaoca.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtMestoPrimaoca.Text))
            {
                txtMestoPrimaoca.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtMestoPrimaoca.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtNazivPrimaoca.Text))
            {
                txtNazivPrimaoca.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtNazivPrimaoca.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtPIB.Text))
            {
                txtPIB.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtPIB.BackColor = Color.White;
            }

            return uspesno;
        }

        private void cbAdresaPrimaoca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mesta != null && cbAdresaPrimaoca.SelectedItem != null)
            {
                txtMestoPrimaoca.Text = mesta.Where(m => m.MestoId == ((Adresa)cbAdresaPrimaoca.SelectedItem).MestoId).FirstOrDefault().NazivMesta;
            }
        }

        private void btnSacuvajPrimaoca_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosaPrimaoca())
            {
                return;
            }

            try
            {
                var regex = new Regex(@"^[0-9]{9}?$");

                if (!regex.IsMatch(txtPIB.Text))
                {
                    throw new FormatException();
                }

                izabraniPrimalac.NazivPrimaoca = txtNazivPrimaoca.Text;
                izabraniPrimalac.PIB = new PIBObjekat
                {
                    PIB = txtPIB.Text
                };
                izabraniPrimalac.AdresaId = ((Adresa)cbAdresaPrimaoca.SelectedItem).AdresaId;
                izabraniPrimalac.MestoId = ((Adresa)cbAdresaPrimaoca.SelectedItem).MestoId;

                KontrolerStn.Instanca.SacuvajPrimaoca(izabraniPrimalac);
                OsveziPrimaoca();
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

        private void dgvPrimalac_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabraniPrimalac = (Primalac)dgvPrimaoci.SelectedRows[0].DataBoundItem;
                izabraniPrimalac.OriginalanPrimalacId = izabraniPrimalac.PrimalacId;

                if (izabraniPrimalac != null)
                {
                    txtNazivPrimaoca.Text = izabraniPrimalac.NazivPrimaoca;
                    txtPIB.Text = izabraniPrimalac.PIB.PIB;
                    cbAdresaPrimaoca.SelectedItem = adrese.Where(a => a.AdresaId == izabraniPrimalac.AdresaId && a.MestoId == izabraniPrimalac.MestoId).FirstOrDefault();
                    btnSacuvajAdresu.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeniPrimaoca_Click(object sender, EventArgs e)
        {
            if (dgvPrimaoci.SelectedRows.Count == 0 || dgvPrimaoci.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati primaoca kojeg zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var regex = new Regex(@"^[0-9]{9}?$");

                if (!regex.IsMatch(txtPIB.Text))
                {
                    throw new FormatException();
                }

                izabraniPrimalac.NazivPrimaoca = txtNazivPrimaoca.Text;
                izabraniPrimalac.PIB = new PIBObjekat
                {
                    PIB = txtPIB.Text
                };
                izabraniPrimalac.AdresaId = ((Adresa)cbAdresaPrimaoca.SelectedItem).AdresaId;
                izabraniPrimalac.MestoId = ((Adresa)cbAdresaPrimaoca.SelectedItem).MestoId;

                KontrolerStn.Instanca.IzmeniPrimaoca(izabraniPrimalac);
                OsveziPrimaoca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiPrimaoca_Click(object sender, EventArgs e)
        {
            if (dgvPrimaoci.SelectedRows.Count == 0 || dgvPrimaoci.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati primaoca kojeg zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiPrimaoca(izabraniPrimalac);
                OsveziPrimaoca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
