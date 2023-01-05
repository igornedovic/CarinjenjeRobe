using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO
{
    public class SacuvajSazetuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            SazetaDeklaracija sd = (SazetaDeklaracija)obj;

            int brojSazDeklaracije = broker.SacuvajIVratiId(sd);

            foreach (StavkaSazDeklaracije stavka in sd.StavkeSazDeklaracije)
            {
                stavka.BrojSazDeklaracije = brojSazDeklaracije;
                broker.Sacuvaj(stavka);
            }
        }
    }
}
