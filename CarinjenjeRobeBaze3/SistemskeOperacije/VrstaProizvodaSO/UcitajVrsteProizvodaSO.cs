using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.VrstaProizvodaSO
{
    public class UcitajVrsteProizvodaSO : OpstaSO
    {
        public List<VrstaProizvoda> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Rezultat = broker.VratiSve(new VrstaProizvoda()).OfType<VrstaProizvoda>().ToList();
        }
    }
}
