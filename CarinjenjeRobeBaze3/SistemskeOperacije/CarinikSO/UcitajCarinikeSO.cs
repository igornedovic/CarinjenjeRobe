using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO
{
    public class UcitajCarinikeSO : OpstaSO
    {
        public List<Carinik> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Rezultat = broker.VratiSve(new Carinik()).OfType<Carinik>().ToList();
        }
    }
}
