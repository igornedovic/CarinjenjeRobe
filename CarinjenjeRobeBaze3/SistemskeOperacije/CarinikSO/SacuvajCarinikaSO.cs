using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO
{
    public class SacuvajCarinikaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Carinik c = (Carinik)obj;

            broker.Sacuvaj(c);
        }
    }
}
