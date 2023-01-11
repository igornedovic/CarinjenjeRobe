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
    public partial class FrmSazetaDeklaracija : Form
    {
        private BindingList<StavkaSazDeklaracije> stavke = new BindingList<StavkaSazDeklaracije>();
        private SazetaDeklaracija izabranaSazeta = new SazetaDeklaracija();

        private BindingList<Vozilo> vozila;
        private BindingList<Mesto> mesta;
        private BindingList<Radnik> radnici;
        private BindingList<Primalac> primaoci;
        private BindingList<Carinarnica> carinarnice;
        private BindingList<Skladiste> skladista;
        private BindingList<Proizvod> proizvodi;
        private BindingList<JedinicaMere> jediniceMere;

        private string mod = null;
        public FrmSazetaDeklaracija(string mod = null, SazetaDeklaracija izabranaSazeta = null)
        {
            InitializeComponent();

            txtDatumSmestaja.Format = DateTimePickerFormat.Custom;
            txtDatumSmestaja.CustomFormat = "dd-MM-yyyy";

            txtRokPodnosenja.Format = DateTimePickerFormat.Custom;
            txtRokPodnosenja.CustomFormat = "dd-MM-yyyy";

            try
            {
                vozila = new BindingList<Vozilo>(KontrolerStn.Instanca.UcitajVozila());
                cbBrojTablice.DataSource = vozila;

                mesta = new BindingList<Mesto>(KontrolerStn.Instanca.UcitajMesta());
                cbMesto.DataSource = mesta;

                radnici = new BindingList<Radnik>(KontrolerStn.Instanca.UcitajRadnike());
                cbRadnik.DataSource = radnici;

                primaoci = new BindingList<Primalac>(KontrolerStn.Instanca.UcitajPrimaoce());
                cbPrimalac.DataSource = primaoci;

                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                cbCarinarnica.DataSource = carinarnice;         

                skladista = new BindingList<Skladiste>(KontrolerStn.Instanca.UcitajSkladista());
                cbSkladiste.DataSource = skladista;       

                proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
                cbProizvod.DataSource = proizvodi;

                jediniceMere = new BindingList<JedinicaMere>(KontrolerStn.Instanca.UcitajJediniceMere());
                cbJedinicaMere.DataSource = jediniceMere;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (mod == null)
            {
                InsertMod();
            }
            else
            {
                this.mod = mod;
                UpdateMod(izabranaSazeta);
            }
        }

        private void InsertMod()
        {
            cbBrojTablice.SelectedItem = null;
            cbMesto.SelectedItem = null;
            cbRadnik.SelectedItem = null;
            cbPrimalac.SelectedItem = null;
            cbCarinarnica.SelectedItem = null;
            cbSkladiste.SelectedItem = null;
            cbProizvod.SelectedItem = null;
            cbJedinicaMere.SelectedItem = null;

            dgvStavke.DataSource = stavke;
            PrilagodiTabeluStavki();
        }

        private void UpdateMod(SazetaDeklaracija izabranaSazeta)
        {
            txtDatumSmestaja.Value = izabranaSazeta.DatumSmestaja.Value;

            txtRokPodnosenja.Value = izabranaSazeta.RokPodnosenja.Value;

            txtOznaka.Text = izabranaSazeta.OznakaObezbedjenja.ToString();

            cbBrojTablice.SelectedItem = vozila.Where(v => v.BrojTablice == izabranaSazeta.BrojTablice).FirstOrDefault();

            cbMesto.SelectedItem = mesta.Where(m => m.MestoId == izabranaSazeta.MestoId).FirstOrDefault();

            cbRadnik.SelectedItem = radnici.Where(r => r.SifraRadnika == izabranaSazeta.SifraRadnika)
                                           .FirstOrDefault();

            cbPrimalac.SelectedItem = primaoci.Where(p => p.PrimalacId == izabranaSazeta.PrimalacId)
                                              .FirstOrDefault();

            cbCarinarnica.SelectedItem = carinarnice.Where(c => c.SifraCarinarnice == izabranaSazeta.SifraCarinarnice).FirstOrDefault();

            cbSkladiste.SelectedItem = skladista.Where(s => s.SkladisteId == izabranaSazeta.SkladisteId).FirstOrDefault();

            txtUkupanBrojKoleta.Text = izabranaSazeta.UkupanBrojKoleta.ToString();

            this.izabranaSazeta.BrojSazDeklaracije = izabranaSazeta.BrojSazDeklaracije;
            this.izabranaSazeta.OriginalanUkupanBrojKoleta = izabranaSazeta.OriginalanUkupanBrojKoleta;
            this.izabranaSazeta.OriginalneStavkeSazDeklaracije = izabranaSazeta.OriginalneStavkeSazDeklaracije;

            cbProizvod.SelectedItem = null;
            cbJedinicaMere.SelectedItem = null;

            BindingList<StavkaSazDeklaracije> stavkeIzabraneSazete = new BindingList<StavkaSazDeklaracije>(izabranaSazeta.StavkeSazDeklaracije);

            this.stavke = stavkeIzabraneSazete;
            dgvStavke.DataSource = stavke;
            PrilagodiTabeluStavki();
        }

        private void PrilagodiTabeluStavki()
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
            dgvStavke.Columns["OriginalanBrojKoleta"].Visible = false;
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
            if (!ValidacijaStavke())
            {
                return;
            }

            try
            {
                StavkaSazDeklaracije stavka = new StavkaSazDeklaracije();
                stavka.RbStavke = stavke.Count + 1;
                stavka.BrojPrevozneIsprave = int.Parse(txtBrojPI.Text);
                stavka.BrojKoleta = int.Parse(txtBrojKoleta.Text);
                stavka.Napomena = txtNapomena.Text;
                stavka.SifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;
                stavka.SifraJM = ((JedinicaMere)cbJedinicaMere.SelectedItem).SifraJM;

                stavke.Add(stavka);
                OsveziUnosZaStavku();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvStavke_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                StavkaSazDeklaracije izabranaStavka = (StavkaSazDeklaracije)dgvStavke.SelectedRows[0].DataBoundItem;

                if (izabranaStavka != null)
                {
                    txtBrojPI.Text = izabranaStavka.BrojPrevozneIsprave.ToString();
                    txtBrojKoleta.Text = izabranaStavka.BrojKoleta.ToString();
                    txtNapomena.Text = izabranaStavka.Napomena;
                    cbProizvod.SelectedItem = proizvodi.Where(p => p.SifraProizvoda == izabranaStavka.SifraProizvoda).FirstOrDefault();
                    cbJedinicaMere.SelectedItem = jediniceMere.Where(jm => jm.SifraJM == izabranaStavka.SifraJM).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0 || dgvStavke.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati jednu stavku koju zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StavkaSazDeklaracije izabranaStavka = (StavkaSazDeklaracije)dgvStavke.SelectedRows[0].DataBoundItem;

            try
            {
                StavkaSazDeklaracije stavka = new StavkaSazDeklaracije();
                stavka.BrojSazDeklaracije = izabranaStavka.BrojSazDeklaracije;
                stavka.RbStavke = izabranaStavka.RbStavke;
                stavka.BrojPrevozneIsprave = int.Parse(txtBrojPI.Text);
                stavka.BrojKoleta = int.Parse(txtBrojKoleta.Text);
                stavka.Napomena = txtNapomena.Text;
                stavka.SifraProizvoda = ((Proizvod)cbProizvod.SelectedItem).SifraProizvoda;
                stavka.SifraJM = ((JedinicaMere)cbJedinicaMere.SelectedItem).SifraJM;

                bool result = stavke.Remove(izabranaStavka);

                if (result)
                {
                    stavke.Add(stavka);
                    OsveziUnosZaStavku();

                    BindingList<StavkaSazDeklaracije> stavkeSortirano = new BindingList<StavkaSazDeklaracije>(stavke.OrderBy(s => s.RbStavke).ToList());
                    stavke = stavkeSortirano;
                }
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
            if (!ValidacijaUnosa())
            {
                return;
            }

            try
            {
                izabranaSazeta.DatumSmestaja = txtDatumSmestaja.Value;
                izabranaSazeta.RokPodnosenja = txtRokPodnosenja.Value;
                izabranaSazeta.OznakaObezbedjenja = int.Parse(txtOznaka.Text);
                izabranaSazeta.BrojTablice = ((Vozilo)cbBrojTablice.SelectedItem).BrojTablice;
                izabranaSazeta.MestoId = ((Mesto)cbMesto.SelectedItem).MestoId;
                izabranaSazeta.SifraRadnika = ((Radnik)cbRadnik.SelectedItem).SifraRadnika;
                izabranaSazeta.PrimalacId = ((Primalac)cbPrimalac.SelectedItem).PrimalacId;
                izabranaSazeta.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;
                izabranaSazeta.SkladisteId = ((Skladiste)cbSkladiste.SelectedItem).SkladisteId;
                izabranaSazeta.UkupanBrojKoleta = int.Parse(txtUkupanBrojKoleta.Text);
                izabranaSazeta.StavkeSazDeklaracije = stavke.ToList();


                if (mod == null)
                {
                    KontrolerStn.Instanca.SacuvajSazetu(izabranaSazeta);
                }
                else
                {
                    KontrolerStn.Instanca.IzmeniSazetu(izabranaSazeta);
                }
                
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Nisu svi podaci uneti u odgovarajucem formatu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


    }
}
