using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO
{
    public class IzmeniSazetuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            SazetaDeklaracija sd = (SazetaDeklaracija)obj;

            var updateVrednosti = new StringBuilder($"ROKPODNOSENJA=TO_DATE('{sd.RokPodnosenja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), OZNAKAOBEZBEDJENJA={sd.OznakaObezbedjenja}, MESTOID={sd.MestoId}, BROJTABLICE='{sd.BrojTablice}', SIFRARADNIKA={sd.SifraRadnika}, PRIMALACID={sd.PrimalacId}, SIFRACARINARNICE={sd.SifraCarinarnice}, SKLADISTEID={sd.SkladisteId}, DATUMSMESTAJA=TO_DATE('{sd.DatumSmestaja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy')");

            if (sd.UkupanBrojKoleta != sd.OriginalanUkupanBrojKoleta)
            {
                updateVrednosti.Append($", UKUPANBROJKOLETA={sd.UkupanBrojKoleta}");
            }

            sd.UpdateVrednosti = updateVrednosti.ToString();

            sd.WhereUslov = $"BROJSAZDEKLARACIJE={sd.BrojSazDeklaracije}";

            broker.Izmeni(sd);

            foreach (var originalnaStavka in sd.OriginalneStavkeSazDeklaracije)
            {
                if (!sd.StavkeSazDeklaracije.Contains(originalnaStavka))
                {
                    originalnaStavka.WhereUslov = $"BROJSAZDEKLARACIJE={originalnaStavka.BrojSazDeklaracije} AND RBSTAVKE={originalnaStavka.RbStavke}";

                    broker.Obrisi(originalnaStavka);
                }
            }

            foreach (var stavka in sd.StavkeSazDeklaracije)
            {
                if (!sd.OriginalneStavkeSazDeklaracije.Contains(stavka) && !sd.OriginalneStavkeSazDeklaracije.Any(s => s.BrojSazDeklaracije == stavka.BrojSazDeklaracije && s.RbStavke == stavka.RbStavke && stavka.BrojKoleta == stavka.OriginalanBrojKoleta))
                {
                    stavka.BrojSazDeklaracije = sd.BrojSazDeklaracije;

                    broker.Sacuvaj(stavka);
                }
                else
                {
                    stavka.UpdateVrednosti = $"BROJPREVOZNEISPRAVE={stavka.BrojPrevozneIsprave}, BROJKOLETA={stavka.BrojKoleta}, NAPOMENA='{stavka.Napomena}', SIFRAPROIZVODA={stavka.SifraProizvoda}, SIFRAJM={stavka.SifraJM}";

                    stavka.WhereUslov = $"BROJSAZDEKLARACIJE={stavka.BrojSazDeklaracije} AND RBSTAVKE={stavka.RbStavke}";

                    broker.Izmeni(stavka);
                }
            }
        }
    }
}
