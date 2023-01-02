using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.SistemskeOperacije;
using CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO;
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

        public List<Proizvod> UcitajProizvode()
        {
            OpstaSO oso = new UcitajProizvodeSO();
            oso.Izvrsi();
            return ((UcitajProizvodeSO)oso).Rezultat;
        }

        public List<VrstaProizvoda> UcitajVrsteProizvoda()
        {
            OpstaSO oso = new UcitajVrsteProizvodaSO();
            oso.Izvrsi();
            return ((UcitajVrsteProizvodaSO)oso).Rezultat;
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
    }
}
