using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO
{
    public class UcitajProizvodeSO : OpstaSO
    {
        public List<Proizvod> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Proizvod p = new Proizvod();
            VrstaProizvoda vp = new VrstaProizvoda();
            p.UslovSpajanja = $"t1.{p.SpoljniKljuc} = t2.{vp.PrimarniKljuc}";

            Rezultat = broker.VratiSveSaSpajanjem(p, vp).OfType<Proizvod>().ToList();
        }
    }
}
