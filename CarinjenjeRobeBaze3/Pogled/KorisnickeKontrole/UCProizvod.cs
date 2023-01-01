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
        public UCProizvod()
        {
            InitializeComponent();


            try
            {
                proizvodi = new BindingList<Proizvod>(KontrolerStn.Instanca.UcitajProizvode());
                dgvProizvodi.DataSource = proizvodi;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
