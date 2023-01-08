using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.JCISO
{
    public class IzmeniJCISO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            JCI jci = (JCI)obj;

            jci.UpdateVrednosti = $"DATUMJCI=TO_DATE('{jci.DatumJCI.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), BROJSAZDEKLARACIJE={jci.BrojSazDeklaracije}, POSILJALACID={jci.PosiljalacId}, PRIMALACID={jci.Primalac.PrimalacId}, SIFRARADNIKA={jci.SifraRadnika}, DRZAVAOTPREMEID={jci.DrzavaOtpremeId}, DRZAVAPOREKLAID={jci.DrzavaPoreklaId}, MESTOID={jci.MestoId}, BROJTABLICE='{jci.BrojTablice}', SIFRACARINARNICE={jci.SifraCarinarnice}, USLOVID={jci.UslovId}, SKLADISTEID={jci.SkladisteId}";

            jci.WhereUslov = $"BROJJCI={jci.BrojJCI}";

            broker.Izmeni(jci);
        }
    }
}
