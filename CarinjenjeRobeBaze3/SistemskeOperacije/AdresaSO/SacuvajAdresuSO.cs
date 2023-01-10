using CarinjenjeRobeBaze3.DBB;
using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.AdresaSO
{
    public class SacuvajAdresuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Adresa a = (Adresa)obj;

            broker.Sacuvaj(a);
        }
    }
}
