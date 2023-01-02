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

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCProizvod : UserControl
    {
        private BindingList<Proizvod> proizvodi;
        private BindingList<VrstaProizvoda> vrsteProizvoda;
        private Proizvod izabraniProizvod;
        public UCProizvod()
        {
            InitializeComponent();


            try
            {
                proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
                dgvProizvodi.DataSource = proizvodi;

                PrilagodiTabelu();

                vrsteProizvoda = new BindingList<VrstaProizvoda>(KontrolerStn.Instanca.UcitajVrsteProizvoda());
                cbVrsta.DataSource = vrsteProizvoda;
                cbVrsta.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabelu()
        {
            dgvProizvodi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProizvodi.Columns["NazivTabele"].Visible = false;
            dgvProizvodi.Columns["InsertKolone"].Visible = false;
            dgvProizvodi.Columns["PrimarniKljuc"].Visible = false;
            dgvProizvodi.Columns["SpoljniKljuc"].Visible = false;
            dgvProizvodi.Columns["UslovSpajanja"].Visible = false;
            dgvProizvodi.Columns["InsertVrednosti"].Visible = false;
            dgvProizvodi.Columns["UpdateVrednosti"].Visible = false;
            dgvProizvodi.Columns["WhereUslov"].Visible = false;
        }

        private void Osvezi()
        {
            txtNaziv.Text = "";
            cbVrsta.SelectedItem = null;
            proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
            dgvProizvodi.DataSource = proizvodi;
            btnSacuvaj.Enabled = true;
        }

        private void dgvProizvodi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabraniProizvod = (Proizvod)dgvProizvodi.SelectedRows[0].DataBoundItem;

                if (izabraniProizvod != null)
                {
                    txtNaziv.Text = izabraniProizvod.NazivProizvoda;
                    cbVrsta.SelectedItem = vrsteProizvoda.Where(vp => vp.VrstaProizvodaId == izabraniProizvod.VrstaProizvoda.VrstaProizvodaId).FirstOrDefault();

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

            if (cbVrsta.SelectedItem == null)
            {
                cbVrsta.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                cbVrsta.BackColor = Color.White;
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
                izabraniProizvod = new Proizvod();
                izabraniProizvod.NazivProizvoda = txtNaziv.Text;
                izabraniProizvod.VrstaProizvoda = (VrstaProizvoda)cbVrsta.SelectedItem;

                KontrolerStn.Instanca.SacuvajProizvod(izabraniProizvod);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvProizvodi.SelectedRows.Count == 0 || dgvProizvodi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati proizvod koji zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabraniProizvod.NazivProizvoda = txtNaziv.Text;
                izabraniProizvod.VrstaProizvoda = (VrstaProizvoda)cbVrsta.SelectedItem;

                KontrolerStn.Instanca.IzmeniProizvod(izabraniProizvod);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvProizvodi.SelectedRows.Count == 0 || dgvProizvodi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati proizvod koji zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiProizvod(izabraniProizvod);
                Osvezi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
