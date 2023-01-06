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
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
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
        }
    }
}
