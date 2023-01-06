using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCObracun : UserControl
    {
        private BindingList<Obracun> obracuni;
        private BindingList<Carinik> carinici;
        private BindingList<Carinarnica> carinarnice;
        private BindingList<Carina> carinskeTarife;
        private Obracun izabraniObracun;
        public UCObracun()
        {
            InitializeComponent();

            txtDatumObracuna.Format = DateTimePickerFormat.Custom;
            txtDatumObracuna.CustomFormat = "dd-MM-yyyy";

            txtDatumObavestenja.Format = DateTimePickerFormat.Custom;
            txtDatumObavestenja.CustomFormat = "dd-MM-yyyy";

            try
            {
                obracuni = new BindingList<Obracun>(KontrolerStn.Instanca.UcitajObracune());
                dgvObracuni.DataSource = obracuni;

                PrilagodiTabelu();

                carinici = new BindingList<Carinik>(KontrolerStn.Instanca.UcitajCarinike());
                cbCarinik.DataSource = carinici;
                cbCarinik.SelectedItem = null;

                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                cbCarinarnica.DataSource = carinarnice;
                cbCarinarnica.SelectedItem = null;

                carinskeTarife = new BindingList<Carina>(KontrolerStn.Instanca.UcitajCarinskeTarife());
                cbCarinskaTarifa.DataSource = carinskeTarife;
                cbCarinskaTarifa.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvObracuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObracuni.Columns["NazivTabele"].Visible = false;
            dgvObracuni.Columns["InsertKolone"].Visible = false;
            dgvObracuni.Columns["PrimarniKljuc"].Visible = false;
            dgvObracuni.Columns["SpoljniKljuc"].Visible = false;
            dgvObracuni.Columns["UslovSpajanja"].Visible = false;
            dgvObracuni.Columns["InsertVrednosti"].Visible = false;
            dgvObracuni.Columns["UpdateVrednosti"].Visible = false;
            dgvObracuni.Columns["WhereUslov"].Visible = false;

            dgvObracuni.Columns["DatumObracuna"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvObracuni.Columns["DatumObavestenja"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void Osvezi()
        {
            txtDatumObracuna.Value = DateTime.Now;
            txtDatumObavestenja.Value = DateTime.Now;
            txtNapomena.Text = "";
            cbCarinik.SelectedItem = null;
            cbCarinarnica.SelectedItem = null;
            cbJCI.SelectedItem = null;
            cbPrimalac.SelectedItem = null;
            cbCarinskaTarifa.SelectedItem = null;

            obracuni = new BindingList<Obracun>(KontrolerStn.Instanca.UcitajObracune());
            dgvObracuni.DataSource = obracuni;

            btnSacuvaj.Enabled = true;
        }

        private void dgvObracuni_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabraniObracun = (Obracun)dgvObracuni.SelectedRows[0].DataBoundItem;

                if (izabraniObracun != null)
                {
                    txtDatumObracuna.Value = izabraniObracun.DatumObracuna.Value;

                    txtDatumObavestenja.Value = izabraniObracun.DatumObavestenja.Value;

                    txtNapomena.Text = izabraniObracun.Napomena;

                    cbCarinik.SelectedItem = carinici.Where(c => c.CarinikId == izabraniObracun.CarinikId).FirstOrDefault();

                    cbCarinarnica.SelectedItem = carinarnice.Where(c => c.SifraCarinarnice == izabraniObracun.SifraCarinarnice).FirstOrDefault();

                    cbCarinskaTarifa.SelectedItem = carinskeTarife.Where(ct => ct.CarinskaTarifa == izabraniObracun.CarinskaTarifa).FirstOrDefault();

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

            if (string.IsNullOrWhiteSpace(txtDatumObracuna.Text))
            {
                txtDatumObracuna.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtDatumObracuna.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtDatumObavestenja.Text))
            {
                txtDatumObavestenja.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtDatumObavestenja.BackColor = Color.White;
            }

            if (cbCarinik.SelectedItem == null)
            {
                cbCarinik.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbCarinik.BackColor = Color.White;
            }

            if (cbCarinarnica.SelectedItem == null)
            {
                cbCarinarnica.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbCarinarnica.BackColor = Color.White;
            }

            if (cbJCI.SelectedItem == null)
            {
                cbJCI.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbJCI.BackColor = Color.White;
            }

            if (cbPrimalac.SelectedItem == null)
            {
                cbPrimalac.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbPrimalac.BackColor = Color.White;
            }

            if (cbCarinskaTarifa.SelectedItem == null)
            {
                cbCarinskaTarifa.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbCarinskaTarifa.BackColor = Color.White;
            }

            return uspesno;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaUnosa())
            //{
            //    return;
            //}

            try
            {
                izabraniObracun = new Obracun();
                izabraniObracun.DatumObracuna = txtDatumObracuna.Value;
                izabraniObracun.DatumObavestenja = txtDatumObavestenja.Value;
                izabraniObracun.Napomena = txtNapomena.Text;
                izabraniObracun.CarinikId = ((Carinik)cbCarinik.SelectedItem).CarinikId;
                izabraniObracun.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;
                izabraniObracun.BrojJCI = 1;
                izabraniObracun.PrimalacId = 1;
                izabraniObracun.CarinskaTarifa = ((Carina)cbCarinskaTarifa.SelectedItem).CarinskaTarifa;


                KontrolerStn.Instanca.SacuvajObracun(izabraniObracun);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Osvezi();
            }

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvObracuni.SelectedRows.Count == 0 || dgvObracuni.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati obracun koji zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabraniObracun.DatumObracuna = txtDatumObracuna.Value;
                izabraniObracun.DatumObavestenja = txtDatumObavestenja.Value;
                izabraniObracun.Napomena = txtNapomena.Text;
                izabraniObracun.CarinikId = ((Carinik)cbCarinik.SelectedItem).CarinikId;
                izabraniObracun.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;
                izabraniObracun.BrojJCI = 1;
                izabraniObracun.PrimalacId = 1;
                izabraniObracun.CarinskaTarifa = ((Carina)cbCarinskaTarifa.SelectedItem).CarinskaTarifa;

                KontrolerStn.Instanca.IzmeniObracun(izabraniObracun);
            }
            catch (OracleException oracleEx)
            {
                
                MessageBox.Show(oracleEx.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Osvezi();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvObracuni.SelectedRows.Count == 0 || dgvObracuni.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati obracun koji zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiObracun(izabraniObracun);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Osvezi();
            }
        }

    }
}
