using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.StanjeSO
{
    public class ObrisiStanjeSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Stanje s = (Stanje)obj;
            s.WhereUslov = $"SIFRAPROIZVODA={s.SifraProizvoda} AND SKLADISTEID={s.SkladisteId}";

            broker.Obrisi(s);
        }
    }
}
