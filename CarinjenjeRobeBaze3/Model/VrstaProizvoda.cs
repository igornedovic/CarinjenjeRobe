using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class VrstaProizvoda : IDomenskiObjekat
    {
        public int VrstaProizvodaId { get; set; }
        public string NazivVrsteProizvoda { get; set; }
        public PDV PDV { get; set; }
        public string NazivTabele => "VRSTAPROIZVODA";

        public string InsertKolone => "NAZIVVRSTEPROIZVODA, PDVID";

        public string PrimarniKljuc => "VRSTAPROIZVODAID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivVrsteProizvoda}', {PDV.PDVId}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader)
        {
            VrstaProizvoda vp = new VrstaProizvoda();
            vp.VrstaProizvodaId = (int)reader["VRSTAPROIZVODAID"];
            vp.NazivVrsteProizvoda = (string)reader["NAZIVVRSTEPROIZVODA"];
            vp.PDV = new PDV
            {
                PDVId = (int)reader["PDVID"],
                StopaPDV = (int)reader["STOPAPDV"]
            };

            return vp;
        }

        public override string ToString()
        {
            return $"{NazivVrsteProizvoda}";
        }
    }
}
