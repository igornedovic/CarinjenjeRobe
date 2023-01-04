using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.ObracunSO
{
    public class ObrisiObracunSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Obracun o = (Obracun)obj;
            o.WhereUslov = $"BROJOBRACUNA={o.BrojObracuna}";

            broker.Obrisi(o);
        }
    }
}
