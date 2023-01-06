using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinaSO
{
    public class UcitajCarinskeTarifeSO : OpstaSO
    {
        public List<Carina> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Rezultat = broker.VratiSve(new Carina()).OfType<Carina>().ToList();
        }
    }
}
