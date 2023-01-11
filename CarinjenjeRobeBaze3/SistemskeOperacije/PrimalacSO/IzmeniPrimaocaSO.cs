using CarinjenjeRobeBaze3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije.PrimalacSO
{
    public class IzmeniPrimaocaSO : OpstaSO
    {
        protected override void IzvrsiUpit(IDomenskiObjekat obj)
        {
            Primalac p = (Primalac)obj;
            p.UpdateVrednosti = $"NAZIVPRIMAOCA='{p.NazivPrimaoca}', PIB=PIB('{p.PIB.PIB}'), MESTOID={p.MestoId}, ADRESAID={p.AdresaId}";
            p.WhereUslov = $"PRIMALACID={p.OriginalanPrimalacId}";

            broker.Izmeni(p);
        }
    }
}
