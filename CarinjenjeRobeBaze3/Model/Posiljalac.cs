using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Posiljalac : IDomenskiObjekat
    {
        public int PosiljalacId { get; set; }
        public string NazivPosiljaoca { get; set; }
        public string NazivTabele => "POSILJALAC";

        public string InsertKolone => "";

        public string PrimarniKljuc => "POSILJALACID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => "";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Posiljalac p = new Posiljalac();
            p.PosiljalacId = (int)reader["POSILJALACID"];
            p.NazivPosiljaoca = (string)reader["NAZIVPOSILJAOCA"];

            return p;
        }

        public override string ToString()
        {
            return $"{NazivPosiljaoca}";
        }
    }
}
