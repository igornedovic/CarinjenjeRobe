using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.JCISO
{
    public class UcitajJCISO : OpstaSO
    {
        public List<JCI> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            JCI jci = new JCI();
            Primalac p = new Primalac();
            jci.UslovSpajanja = $"t1.PRIMALACID = t2.PRIMALACID";

            if (obj is Primalac primalacKriterijum)
            {
                p.WhereUslov = $"NAZIVPRIMAOCA='{primalacKriterijum.NazivPrimaoca}'";
            }

            Rezultat = broker.VratiSaSpajanjem(jci, p).OfType<JCI>().ToList();
        }
    }
}
