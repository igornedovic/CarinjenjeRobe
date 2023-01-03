using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO
{
    public class IzmeniCarinikaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Carinik c = (Carinik)obj;
            c.UpdateVrednosti = $"IMEPREZIME='{c.ImePrezime}', SIFRACARINARNICE={c.SifraCarinarnice}";
            c.WhereUslov = $"CARINIKID={c.CarinikId}";

            broker.Izmeni(c);
        }
    }
}
