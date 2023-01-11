using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.PrimalacSO
{
    public class ObrisiPrimaocaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Primalac p = (Primalac)obj;
            p.WhereUslov = $"PRIMALACID={p.PrimalacId}";

            broker.Obrisi(p);
        }
    }
}
