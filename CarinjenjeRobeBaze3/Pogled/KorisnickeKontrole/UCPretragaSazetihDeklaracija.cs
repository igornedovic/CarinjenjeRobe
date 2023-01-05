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
    public partial class UCPretragaSazetihDeklaracija : UserControl
    {
        private BindingList<SazetaDeklaracija> sazete;
        public UCPretragaSazetihDeklaracija()
        {
            InitializeComponent();

        }

        private void PrilagodiTabelu()
        {
            dgvSazete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSazete.Columns["NazivTabele"].Visible = false;
            dgvSazete.Columns["InsertKolone"].Visible = false;
            dgvSazete.Columns["PrimarniKljuc"].Visible = false;
            dgvSazete.Columns["SpoljniKljuc"].Visible = false;
            dgvSazete.Columns["UslovSpajanja"].Visible = false;
            dgvSazete.Columns["InsertVrednosti"].Visible = false;
            dgvSazete.Columns["UpdateVrednosti"].Visible = false;
            dgvSazete.Columns["WhereUslov"].Visible = false;
            dgvSazete.Columns["Particionisanje"].Visible = false;

            dgvSazete.Columns["DatumSmestaja"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvSazete.Columns["RokPodnosenja"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (!rbSve.Checked && !rb2020.Checked && !rb2021.Checked && !rb2022.Checked)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SazetaDeklaracija sd = new SazetaDeklaracija();

            if (rb2020.Checked)
            {
                sd.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2020.Text})";
            } else if (rb2021.Checked)
            {
                sd.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2021.Text})";
            } else if (rb2022.Checked)
            {
                sd.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2022.Text})";
            }


            try
            {
                sazete = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(sd));
                dgvSazete.DataSource = sazete;

                PrilagodiTabelu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
