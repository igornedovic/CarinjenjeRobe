using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO
{
    public class UcitajStavkeSO : OpstaSO
    {
        public List<StavkaSazDeklaracije> Rezultat { get; set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            SazetaDeklaracija izabranaSazeta = (SazetaDeklaracija)obj;
            StavkaSazDeklaracije stavka = new StavkaSazDeklaracije();
            stavka.WhereUslov = $"BROJSAZDEKLARACIJE={izabranaSazeta.BrojSazDeklaracije}";

            Rezultat = broker.VratiSve(stavka).OfType<StavkaSazDeklaracije>().ToList();
        }
    }
}
