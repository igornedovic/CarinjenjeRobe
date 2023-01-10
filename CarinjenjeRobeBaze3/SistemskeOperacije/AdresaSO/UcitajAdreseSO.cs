using CarinjenjeRobeBaze3.DBB;
using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.AdresaSO
{
    public class UcitajAdreseSO : OpstaSO
    {
        public List<Adresa> Rezultat { get; private set; }
        protected override void IzvrsiUpit(IDomenskiObjekat obj = null)
        {
            Rezultat = ((GenerickiBroker)broker).VratiAdrese(new Adresa());
        }
    }
}
