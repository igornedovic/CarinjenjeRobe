using CarinjenjeRobeBaze3.Kontroler;
using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.Pogled.Forme;
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

namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    public partial class UCPretragaSazetihDeklaracija : UserControl
    {
        private BindingList<SazetaDeklaracija> sazete;
        private SazetaDeklaracija sdZaParticionisanje = new SazetaDeklaracija();
        private SazetaDeklaracija izabranaSazeta;
        public UCPretragaSazetihDeklaracija()
        {
            InitializeComponent();

        }

        private void PrilagodiTabelu()
        {
            dgvSazete.Columns["NazivTabele"].Visible = false;
            dgvSazete.Columns["InsertKolone"].Visible = false;
            dgvSazete.Columns["PrimarniKljuc"].Visible = false;
            dgvSazete.Columns["SpoljniKljuc"].Visible = false;
            dgvSazete.Columns["UslovSpajanja"].Visible = false;
            dgvSazete.Columns["InsertVrednosti"].Visible = false;
            dgvSazete.Columns["UpdateVrednosti"].Visible = false;
            dgvSazete.Columns["WhereUslov"].Visible = false;
            dgvSazete.Columns["Particionisanje"].Visible = false;
            dgvSazete.Columns["OriginalanUkupanBrojKoleta"].Visible = false;

            dgvSazete.Columns["DatumSmestaja"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvSazete.Columns["RokPodnosenja"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (!rbSve.Checked && !rb2020.Checked && !rb2021.Checked && !rb2022.Checked && !rb2023.Checked)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            if (rb2020.Checked)
            {
                sdZaParticionisanje.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2020.Text})";
            } else if (rb2021.Checked)
            {
                sdZaParticionisanje.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2021.Text})";
            } else if (rb2022.Checked)
            {
                sdZaParticionisanje.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2022.Text})";
            } else if (rb2023.Checked)
            {
                sdZaParticionisanje.Particionisanje = $"PARTITION (SAZETEDEKLARACIJE_{rb2023.Text})";
            }


            try
            {
                sazete = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(sdZaParticionisanje));
                dgvSazete.DataSource = sazete;

                PrilagodiTabelu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmSazetaDeklaracija frmSazeta = new FrmSazetaDeklaracija();

            if (frmSazeta.ShowDialog() == DialogResult.OK)
            {
                frmSazeta.Dispose();
                sazete = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(sdZaParticionisanje));
                dgvSazete.DataSource = sazete;

                PrilagodiTabelu();
            }
        }

        private void dgvSazete_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                izabranaSazeta = (SazetaDeklaracija)dgvSazete.SelectedRows[0].DataBoundItem;

            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvSazete.SelectedRows.Count == 0 || dgvSazete.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati sazetu deklaraciju koju zelite da izmenite iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                izabranaSazeta.StavkeSazDeklaracije = KontrolerStn.Instanca.UcitajStavke(izabranaSazeta);
                
                foreach (var item in izabranaSazeta.StavkeSazDeklaracije)
                {
                    izabranaSazeta.OriginalneStavkeSazDeklaracije.Add(new StavkaSazDeklaracije
                    {
                        BrojSazDeklaracije = item.BrojSazDeklaracije,
                        RbStavke = item.RbStavke,
                        BrojPrevozneIsprave = item.BrojPrevozneIsprave,
                        BrojKoleta = item.BrojKoleta,
                        Napomena = item.Napomena,
                        SifraProizvoda = item.SifraProizvoda,
                        SifraJM = item.SifraJM
                    });
                }

                FrmSazetaDeklaracija frmSazeta = new FrmSazetaDeklaracija("UPDATE", izabranaSazeta);

                if (frmSazeta.ShowDialog() == DialogResult.OK)
                {
                    frmSazeta.Dispose();
                    sazete = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(sdZaParticionisanje));
                    dgvSazete.DataSource = sazete;
                }
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSazete.SelectedRows.Count == 0 || dgvSazete.SelectedRows.Count > 1)
            {
                MessageBox.Show("Morate izabrati sazetu deklaraciju koju zelite da obrisete iz tabele!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KontrolerStn.Instanca.ObrisiSazetu(izabranaSazeta);
                sazete = new BindingList<SazetaDeklaracija>(KontrolerStn.Instanca.UcitajSazete(sdZaParticionisanje));
                dgvSazete.DataSource = sazete;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
