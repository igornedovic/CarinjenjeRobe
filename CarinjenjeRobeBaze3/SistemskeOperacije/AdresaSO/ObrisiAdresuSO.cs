using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.AdresaSO
{
    public class ObrisiAdresuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Adresa a = (Adresa)obj;
            a.WhereUslov = $"MESTOID={a.MestoId} AND ADRESAID={a.AdresaId}";

            broker.Obrisi(a);
        }
    }
}
