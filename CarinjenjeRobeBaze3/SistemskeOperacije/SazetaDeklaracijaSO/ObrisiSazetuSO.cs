using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO
{
    public class ObrisiSazetuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            SazetaDeklaracija sd = (SazetaDeklaracija)obj;
            sd.WhereUslov = $"BROJSAZDEKLARACIJE={sd.BrojSazDeklaracije}";

            broker.Obrisi(sd);
        }
    }
}
