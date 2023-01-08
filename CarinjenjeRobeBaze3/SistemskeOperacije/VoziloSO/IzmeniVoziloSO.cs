using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.VoziloSO
{
    public class IzmeniVoziloSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Vozilo v = (Vozilo)obj;
            v.UpdateVrednosti = $"BROJTABLICE='{v.BrojTablice}', NACIONALNOST='{v.Nacionalnost}', BROJPRIKOLICE='{v.BrojPrikolice}', TIPVOZILA='{v.TipVozila}'";
            v.WhereUslov = $"BROJTABLICE='{v.BrojTablice}'";

            broker.Izmeni(v);
        }
    }
}
