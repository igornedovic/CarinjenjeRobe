using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.AdresaSO
{
    public class IzmeniAdresuSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Adresa a = (Adresa)obj;
            a.UpdateVrednosti = $"MESTOID={a.MestoId}, ULICABROJ=ULICA_BROJ('{a.UlicaBroj.NazivUlice}', '{a.UlicaBroj.Broj}')";
            a.WhereUslov = $"MESTOID={a.OriginalnoMestoId} AND ADRESAID={a.AdresaId}";

            broker.Izmeni(a);
        }
    }
}
