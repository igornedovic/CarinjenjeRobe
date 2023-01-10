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
        }
    }
}
