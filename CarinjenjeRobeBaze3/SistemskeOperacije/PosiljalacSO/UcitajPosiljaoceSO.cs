using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.PosiljalacSO
{
    public class UcitajPosiljaoceSO : OpstaSO
    {
        public List<Posiljalac> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {

            Rezultat = broker.VratiSve(new Posiljalac()).OfType<Posiljalac>().ToList();
        }
    }
}
