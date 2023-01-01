using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.SistemskeOperacije;
using CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO;
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
    }
}
