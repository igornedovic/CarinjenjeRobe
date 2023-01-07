﻿using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.Pogled.Forme;
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
    public partial class UCPretragaJCI : UserControl
    {
        private BindingList<JCI> listaJCI;
   
        public UCPretragaJCI()
        {
            InitializeComponent();

            try
            {
                listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                dgvJCI.DataSource = listaJCI;
                dgvJCIDetalji.DataSource = listaJCI;

                PrilagodiTabele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrilagodiTabele()
        {
            dgvJCI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJCI.Columns["NazivTabele"].Visible = false;
            dgvJCI.Columns["InsertKolone"].Visible = false;
            dgvJCI.Columns["PrimarniKljuc"].Visible = false;
            dgvJCI.Columns["SpoljniKljuc"].Visible = false;
            dgvJCI.Columns["UslovSpajanja"].Visible = false;
            dgvJCI.Columns["InsertVrednosti"].Visible = false;
            dgvJCI.Columns["UpdateVrednosti"].Visible = false;
            dgvJCI.Columns["WhereUslov"].Visible = false;
            dgvJCI.Columns["BrojSazDeklaracije"].Visible = false;
            dgvJCI.Columns["PosiljalacId"].Visible = false;
            dgvJCI.Columns["PrimalacId"].Visible = false;
            dgvJCI.Columns["SifraRadnika"].Visible = false;
            dgvJCI.Columns["DrzavaOtpremeId"].Visible = false;
            dgvJCI.Columns["DrzavaPoreklaId"].Visible = false;
            dgvJCI.Columns["MestoId"].Visible = false;
            dgvJCI.Columns["BrojTablice"].Visible = false;
            dgvJCI.Columns["SifraCarinarnice"].Visible = false;
            dgvJCI.Columns["UslovId"].Visible = false;
            dgvJCI.Columns["SkladisteId"].Visible = false;
            dgvJCI.Columns["DatumJCI"].DefaultCellStyle.Format = "dd-MM-yyyy";

            dgvJCIDetalji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJCIDetalji.Columns["NazivTabele"].Visible = false;
            dgvJCIDetalji.Columns["InsertKolone"].Visible = false;
            dgvJCIDetalji.Columns["PrimarniKljuc"].Visible = false;
            dgvJCIDetalji.Columns["SpoljniKljuc"].Visible = false;
            dgvJCIDetalji.Columns["UslovSpajanja"].Visible = false;
            dgvJCIDetalji.Columns["InsertVrednosti"].Visible = false;
            dgvJCIDetalji.Columns["UpdateVrednosti"].Visible = false;
            dgvJCIDetalji.Columns["WhereUslov"].Visible = false;
            dgvJCIDetalji.Columns["DatumJCI"].Visible = false;
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmJCI frmJCI = new FrmJCI();

            if (frmJCI.ShowDialog() == DialogResult.OK)
            {
                frmJCI.Dispose();
                listaJCI = new BindingList<JCI>(KontrolerStn.Instanca.UcitajJCI());
                dgvJCI.DataSource = listaJCI;
                dgvJCIDetalji.DataSource = listaJCI;
            }
        }

        private void dgvJCI_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

    }
}
