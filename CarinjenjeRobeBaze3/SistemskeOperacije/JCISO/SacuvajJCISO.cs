using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.JCISO
{
    public class SacuvajJCISO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            JCI jci = (JCI)obj;

            Random proizvoljniBroj = new Random();
            jci.BrojJCI = proizvoljniBroj.Next(999);

            broker.Sacuvaj(jci);
        }
    }
}
