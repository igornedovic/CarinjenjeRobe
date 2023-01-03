using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinarnicaSO
{
    public class ObrisiCarinarnicuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Carinarnica c = (Carinarnica)obj;
            c.WhereUslov = $"SIFRACARINARNICE={c.SifraCarinarnice}";

            broker.Obrisi(c);
        }
    }
}
