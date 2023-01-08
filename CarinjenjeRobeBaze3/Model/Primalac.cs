using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Primalac : IDomenskiObjekat
    {
        public int PrimalacId { get; set; }
        public string NazivPrimaoca { get; set; }
        public string NazivTabele => "PRIMALAC";

        public string InsertKolone => "NAZIVPRIMAOCA, PIB, MESTOID, ADRESAID";

        public string PrimarniKljuc => "PRIMALACID";

        public string SpoljniKljuc => "MESTOID, ADRESAID";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivPrimaoca}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Primalac p = new Primalac();
            p.PrimalacId = (int)reader["PRIMALACID"];
            p.NazivPrimaoca = (string)reader["NAZIVPRIMAOCA"];

            return p;
        }

        public override string ToString()
        {
            return $"{NazivPrimaoca}";
        }
    }
}
