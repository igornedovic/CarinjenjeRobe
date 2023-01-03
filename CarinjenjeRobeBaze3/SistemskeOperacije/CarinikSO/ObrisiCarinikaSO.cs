using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO
{
    public class ObrisiCarinikaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Carinik c = (Carinik)obj;
            c.WhereUslov = $"CARINIKID={c.CarinikId}";

            broker.Obrisi(c);
        }
    }
}
