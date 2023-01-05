using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.DBB
{
    public interface IGenerickiBroker<T> where T : class
    {
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
        void ZapocniTransakciju();
        void PotvrdiTransakciju();
        void PonistiTransakciju();



        List<T> VratiSve(T obj);
        List<T> VratiSveSaSpajanjem(params T[] obj);
        int SacuvajIVratiId(T obj);
        void Sacuvaj(T obj);
        void Izmeni(T obj);
        void Obrisi(T obj);
    }
}
