using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.SistemskeOperacije;
using CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.SkladisteSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.StanjeSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.VrstaProizvodaSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Kontroler
{
    public class KontrolerStn
    {
        private static KontrolerStn instanca;

        private KontrolerStn() { }

        public static KontrolerStn Instanca
        {
            get
            {
                if (instanca == null) instanca = new KontrolerStn();
                return instanca;
            }
        }

        #region VrstaProizvoda
        public List<VrstaProizvoda> UcitajVrsteProizvoda()
        {
            OpstaSO oso = new UcitajVrsteProizvodaSO();
            oso.Izvrsi();
            return ((UcitajVrsteProizvodaSO)oso).Rezultat;
        }

        #endregion

        public List<Proizvod> UcitajProizvode()
        {
            OpstaSO oso = new UcitajProizvodeSO();
            oso.Izvrsi();
            return ((UcitajProizvodeSO)oso).Rezultat;
        }

        public void SacuvajProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new SacuvajProizvodSO();
            oso.Izvrsi(proizvod);
        }

        public void IzmeniProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new IzmeniProizvodSO();
            oso.Izvrsi(proizvod);
        }

        public void ObrisiProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new ObrisiProizvodSO();
            oso.Izvrsi(proizvod);
        }

        #region Skladiste

        public List<Skladiste> UcitajSkladista()
        {
            OpstaSO oso = new UcitajSkladistaSO();
            oso.Izvrsi();
            return ((UcitajSkladistaSO)oso).Rezultat;
        }

        #endregion

        #region Stanje

        public List<Stanje> UcitajStanja()
        {
            OpstaSO oso = new UcitajStanjaSO();
            oso.Izvrsi();
            return ((UcitajStanjaSO)oso).Rezultat;
        }

        public void SacuvajStanje(Stanje stanje)
        {
            OpstaSO oso = new SacuvajStanjeSO();
            oso.Izvrsi(stanje);
        }

        public void IzmeniStanje(Stanje stanje)
        {
            OpstaSO oso = new IzmeniStanjeSO();
            oso.Izvrsi(stanje);
        }

        public void ObrisiStanje(Stanje stanje)
        {
            OpstaSO oso = new ObrisiStanjeSO();
            oso.Izvrsi(stanje);
        }

        #endregion
    }
}
