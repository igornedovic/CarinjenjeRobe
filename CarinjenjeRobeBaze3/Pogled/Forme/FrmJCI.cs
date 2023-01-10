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
    public partial class FrmJCI : Form
    {
        private JCI izabranaJCI = new JCI();

        private BindingList<SazetaDeklaracija> sazeteDeklaracije;
        private BindingList<Radnik> radnici;
        private BindingList<Drzava> drzaveOtpreme;
        private BindingList<Drzava> drzavePorekla;
        private BindingList<Mesto> mesta;
        private BindingList<Carinarnica> carinarnice;
        private BindingList<Skladiste> skladista;

        private string mod = null;
        public FrmJCI(string mod = null, JCI izabranaJCI = null)
        {
            InitializeComponent();

            txtDatumJCI.Format = DateTimePickerFormat.Custom;
            txtDatumJCI.CustomFormat = "dd-MM-yyyy";

            try
            {
                sazeteDeklaracije = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(new SazetaDeklaracija()));
                cbSazeta.DataSource = sazeteDeklaracije;

                radnici = new BindingList<Radnik>(KontrolerStn.Instanca.UcitajRadnike());
                cbRadnik.DataSource = radnici;

                drzaveOtpreme = new BindingList<Drzava>(KontrolerStn.Instanca.UcitajDrzave());
                cbDrzavaOtpreme.DataSource = drzaveOtpreme;

                drzavePorekla = new BindingList<Drzava>(KontrolerStn.Instanca.UcitajDrzave());
                cbDrzavaPorekla.DataSource = drzavePorekla;

                mesta = new BindingList<Mesto>(KontrolerStn.Instanca.UcitajMesta());
                cbMesto.DataSource = mesta;

                carinarnice = new BindingList<Carinarnica>(KontrolerStn.Instanca.UcitajCarinarnice());
                cbCarinarnica.DataSource = carinarnice;

                skladista = new BindingList<Skladiste>(KontrolerStn.Instanca.UcitajSkladista());
                cbSkladiste.DataSource = skladista;

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
                UpdateMod(izabranaJCI);
            }
        }

        private void InsertMod()
        {
            cbSazeta.SelectedItem = null;
            cbRadnik.SelectedItem = null;
            cbDrzavaOtpreme.SelectedItem = null;
            cbDrzavaPorekla.SelectedItem = null;
            cbMesto.SelectedItem = null;
            cbCarinarnica.SelectedItem = null;
            cbSkladiste.SelectedItem = null;

        }

        private void UpdateMod(JCI izabranaJCI)
        {
            txtDatumJCI.Value = izabranaJCI.DatumJCI.Value;

            cbSazeta.SelectedItem = sazeteDeklaracije.Where(sd => sd.BrojSazDeklaracije == izabranaJCI.BrojSazDeklaracije).FirstOrDefault();

            cbRadnik.SelectedItem = radnici.Where(r => r.SifraRadnika == izabranaJCI.SifraRadnika)
                                           .FirstOrDefault();

            cbDrzavaOtpreme.SelectedItem = drzaveOtpreme.Where(d => d.DrzavaId == izabranaJCI.DrzavaOtpremeId).FirstOrDefault();

            cbDrzavaPorekla.SelectedItem = drzavePorekla.Where(d => d.DrzavaId == izabranaJCI.DrzavaPoreklaId).FirstOrDefault();

            cbMesto.SelectedItem = mesta.Where(m => m.MestoId == izabranaJCI.MestoId).FirstOrDefault();

            cbCarinarnica.SelectedItem = carinarnice.Where(c => c.SifraCarinarnice == izabranaJCI.SifraCarinarnice).FirstOrDefault();

            cbSkladiste.SelectedItem = skladista.Where(s => s.SkladisteId == izabranaJCI.SkladisteId).FirstOrDefault();

            this.izabranaJCI.BrojJCI = izabranaJCI.BrojJCI;
        }

        private bool ValidacijaUnosa()
        {
            bool uspesno = true;


            if (cbPosiljalac.SelectedItem == null)
            {
                cbPosiljalac.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbPosiljalac.BackColor = Color.White;
            }

            if (cbDrzavaOtpreme.SelectedItem == null)
            {
                cbDrzavaOtpreme.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbDrzavaOtpreme.BackColor = Color.White;
            }

            if (cbDrzavaPorekla.SelectedItem == null)
            {
                cbDrzavaPorekla.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbDrzavaPorekla.BackColor = Color.White;
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

            if (cbSazeta.SelectedItem == null)
            {
                cbSazeta.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbSazeta.BackColor = Color.White;
            }

            if (cbPosiljalac.SelectedItem == null)
            {
                cbPosiljalac.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbPosiljalac.BackColor = Color.White;
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

            if (cbDrzavaOtpreme.SelectedItem == null)
            {
                cbDrzavaOtpreme.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbDrzavaOtpreme.BackColor = Color.White;
            }

            if (cbDrzavaPorekla.SelectedItem == null)
            {
                cbDrzavaPorekla.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbDrzavaPorekla.BackColor = Color.White;
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

            if (cbUslov.SelectedItem == null)
            {
                cbUslov.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbUslov.BackColor = Color.White;
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
                izabranaJCI.DatumJCI = txtDatumJCI.Value;
                izabranaJCI.BrojSazDeklaracije = ((SazetaDeklaracija)cbSazeta.SelectedItem).BrojSazDeklaracije;
                izabranaJCI.PosiljalacId = 1;
                izabranaJCI.Primalac.PrimalacId = 1;
                izabranaJCI.SifraRadnika = ((Radnik)cbRadnik.SelectedItem).SifraRadnika;
                izabranaJCI.DrzavaOtpremeId = ((Drzava)cbDrzavaOtpreme.SelectedItem).DrzavaId;
                izabranaJCI.DrzavaPoreklaId = ((Drzava)cbDrzavaPorekla.SelectedItem).DrzavaId;
                izabranaJCI.MestoId = ((Mesto)cbMesto.SelectedItem).MestoId;
                izabranaJCI.BrojTablice = "BG-252-UT";
                izabranaJCI.SifraCarinarnice = ((Carinarnica)cbCarinarnica.SelectedItem).SifraCarinarnice;
                izabranaJCI.UslovId = 1;
                izabranaJCI.SkladisteId = ((Skladiste)cbSkladiste.SelectedItem).SkladisteId;


                if (mod == null)
                {
                    KontrolerStn.Instanca.SacuvajJCI(izabranaJCI);
                }
                else
                {
                    KontrolerStn.Instanca.IzmeniJCI(izabranaJCI);
                }

                this.DialogResult = DialogResult.OK;
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
