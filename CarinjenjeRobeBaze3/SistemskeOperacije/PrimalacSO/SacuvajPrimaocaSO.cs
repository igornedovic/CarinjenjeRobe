using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.PrimalacSO
{
    public class SacuvajPrimaocaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Primalac p = (Primalac)obj;

            broker.Sacuvaj(p);
        }
    }
}
