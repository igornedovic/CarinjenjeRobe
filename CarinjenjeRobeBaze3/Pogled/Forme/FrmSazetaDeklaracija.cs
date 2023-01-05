using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
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
    public partial class FrmSazetaDeklaracija : Form
    {
        private BindingList<StavkaSazDeklaracije> stavke = new BindingList<StavkaSazDeklaracije>();
        private SazetaDeklaracija izabranaSazeta = new SazetaDeklaracija();

        private BindingList<Carinarnica> carinarnice;
        private BindingList<Skladiste> skladista;
        private BindingList<Proizvod> proizvodi;
        public FrmSazetaDeklaracija()
        {
            InitializeComponent();

            txtDatumSmestaja.Format = DateTimePickerFormat.Custom;
            txtDatumSmestaja.CustomFormat = "dd-MM-yyyy";

            txtRokPodnosenja.Format = DateTimePickerFormat.Custom;
            txtRokPodnosenja.CustomFormat = "dd-MM-yyyy";

            dgvStavke.DataSource = stavke;

            PrilagodiTabelu();

            try
            {
                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                cbCarinarnica.DataSource = carinarnice;
                cbCarinarnica.SelectedItem = null;

                skladista = new BindingList<Skladiste>(KontrolerStn.Instanca.UcitajSkladista());
                cbSkladiste.DataSource = skladista;
                cbSkladiste.SelectedItem = null;

                proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
                cbProizvod.DataSource = proizvodi;
                cbProizvod.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStavke.Columns["BrojSazDeklaracije"].Visible = false;
            dgvStavke.Columns["NazivTabele"].Visible = false;
            dgvStavke.Columns["InsertKolone"].Visible = false;
            dgvStavke.Columns["PrimarniKljuc"].Visible = false;
            dgvStavke.Columns["SpoljniKljuc"].Visible = false;
            dgvStavke.Columns["UslovSpajanja"].Visible = false;
            dgvStavke.Columns["InsertVrednosti"].Visible = false;
            dgvStavke.Columns["UpdateVrednosti"].Visible = false;
            dgvStavke.Columns["WhereUslov"].Visible = false;
        }

        private bool ValidacijaStavke()
        {
            bool uspesno = true;

            if (string.IsNullOrWhiteSpace(txtBrojPI.Text))
            {
                txtBrojPI.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtBrojPI.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtBrojKoleta.Text))
            {
                txtBrojKoleta.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtBrojKoleta.BackColor = Color.White;
            }

            if (cbProizvod.SelectedItem == null)
            {
                cbProizvod.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbProizvod.BackColor = Color.White;
            }

            if (cbJedinicaMere.SelectedItem == null)
            {
                cbJedinicaMere.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbJedinicaMere.BackColor = Color.White;
            }

            return uspesno;
        }
        private void OsveziUnosZaStavku()
        {
            txtBrojPI.Text = "";
            txtBrojKoleta.Text = "";
            txtNapomena.Text = "";
            cbProizvod.SelectedItem = null;
            cbJedinicaMere.SelectedItem = null;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaStavke())
            //{
            //    return;
            //}

            try
            {
                StavkaSazDeklaracije stavka = new StavkaSazDeklaracije();
                stavka.RbStavke = stavke.Count + 1;
                stavka.BrojPrevozneIsprave = double.Parse(txtBrojPI.Text);
                stavka.BrojKoleta = int.Parse(txtBrojKoleta.Text);
                stavka.Napomena = txtNapomena.Text;
                stavka.SifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;
                stavka.SifraJM = 1;

                stavke.Add(stavka);
                OsveziUnosZaStavku();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0 || dgvStavke.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati jednu stavku koju zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StavkaSazDeklaracije izabranaStavka = (StavkaSazDeklaracije)dgvStavke.SelectedRows[0].DataBoundItem;

            bool result = stavke.Remove(izabranaStavka);

            if (result)
            {
                for (int i = 0; i < stavke.Count; i++)
                {
                    stavke[i].RbStavke = i + 1;
                }
            }
        }

        private bool ValidacijaUnosa()
        {
            bool uspesno = true;

            if (string.IsNullOrWhiteSpace(txtOznaka.Text))
            {
                txtOznaka.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtOznaka.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtUkupanBrojKoleta.Text))
            {
                txtUkupanBrojKoleta.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                txtUkupanBrojKoleta.BackColor = Color.White;
            }

            if (cbBrojTablice.SelectedItem == null)
            {
                cbBrojTablice.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbBrojTablice.BackColor = Color.White;
            }

            if (cbMesto.SelectedItem == null)
            {
                cbMesto.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbMesto.BackColor = Color.White;
            }

            if (cbRadnik.SelectedItem == null)
            {
                cbRadnik.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbRadnik.BackColor = Color.White;
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

            if (cbCarinarnica.SelectedItem == null)
            {
                cbCarinarnica.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbCarinarnica.BackColor = Color.White;
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

            if (stavke.Count == 0)
            {
                MessageBox.Show("Morate uneti barem jednu stavku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uspesno = false;
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
                izabranaSazeta.DatumSmestaja = txtDatumSmestaja.Value;
                izabranaSazeta.RokPodnosenja = txtRokPodnosenja.Value;
                izabranaSazeta.OznakaObezbedjenja = int.Parse(txtOznaka.Text);
                izabranaSazeta.BrojTablice = "BG-252-UT";
                izabranaSazeta.MestoId = 1;
                izabranaSazeta.SifraRadnika = 1;
                izabranaSazeta.PrimalacId = 1;
                izabranaSazeta.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;
                izabranaSazeta.SkladisteId = ((Skladiste)cbSkladiste.SelectedItem).SkladisteId;
                izabranaSazeta.UkupanBrojKoleta = int.Parse(txtUkupanBrojKoleta.Text);
                izabranaSazeta.StavkeSazDeklaracije = stavke.ToList();


                KontrolerStn.Instanca.SacuvajSazetu(izabranaSazeta);
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
