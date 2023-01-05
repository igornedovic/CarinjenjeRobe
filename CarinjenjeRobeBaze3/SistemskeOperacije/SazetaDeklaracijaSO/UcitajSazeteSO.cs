using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO
{
    public class UcitajSazeteSO : OpstaSO
    {
        public List<SazetaDeklaracija> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Rezultat = broker.VratiSve((SazetaDeklaracija)obj).OfType<SazetaDeklaracija>().ToList();
        }
    }
}
