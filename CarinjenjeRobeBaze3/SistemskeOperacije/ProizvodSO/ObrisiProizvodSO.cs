using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO
{
    public class ObrisiProizvodSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Proizvod p = (Proizvod)obj;
            p.WhereUslov = $"SIFRAPROIZVODA={p.SifraProizvoda}";

            broker.Obrisi(p);
        }
    }
}
