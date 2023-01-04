﻿using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.ObracunSO
{
    public class IzmeniObracunSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Obracun o = (Obracun)obj;

            o.UpdateVrednosti = $"DATUMOBRACUNA=TO_DATE('{o.DatumObracuna.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), DATUMOBAVESTENJA=TO_DATE('{o.DatumObavestenja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), NAPOMENA='{o.Napomena}', CARINIKID={o.CarinikId}, BROJJCI={o.BrojJCI}, PRIMALACID={o.PrimalacId}, CARINSKATARIFA={o.CarinskaTarifa}";

            o.WhereUslov = $"BROJOBRACUNA={o.BrojObracuna}";

            broker.Izmeni(o);
        }
    }
}
