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
    public partial class UCAdresaIPrimalac : UserControl
    {
        private BindingList<Adresa> adrese;
        private BindingList<Mesto> mesta;

        private Adresa izabranaAdresa = new Adresa();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
