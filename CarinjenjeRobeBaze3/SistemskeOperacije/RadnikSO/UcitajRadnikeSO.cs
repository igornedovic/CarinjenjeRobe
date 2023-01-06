using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.RadnikSO
{
    public class UcitajRadnikeSO : OpstaSO
    {
        public List<Radnik> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Rezultat = broker.VratiSve(new Radnik()).OfType<Radnik>().ToList();
        }
    }
}
