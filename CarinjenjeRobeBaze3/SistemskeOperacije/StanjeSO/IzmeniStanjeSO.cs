using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.StanjeSO
{
    public class IzmeniStanjeSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Stanje s = (Stanje)obj;
            s.UpdateVrednosti = $"SIFRAPROIZVODA={s.SifraProizvoda}, SKLADISTEID={s.SkladisteId}, NAZIVPROIZVODA='{s.NazivProizvoda}', BRUTOMASA={s.BrutoMasa}, NETOMASA={s.NetoMasa}";
            s.WhereUslov = $"SIFRAPROIZVODA={s.OriginalnaSifraProizvoda} AND SKLADISTEID={s.SkladisteId}";

            broker.Izmeni(s);
        }
    }
}
