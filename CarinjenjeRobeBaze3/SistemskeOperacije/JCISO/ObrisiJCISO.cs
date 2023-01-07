using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.JCISO
{
    public class ObrisiJCISO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            JCI jci = (JCI)obj;
            jci.WhereUslov = $"BROJJCI={jci.BrojJCI}";

            broker.Obrisi(jci);
        }
    }
}
