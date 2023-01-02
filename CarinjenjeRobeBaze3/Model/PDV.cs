using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class PDV : IDomenskiObjekat
    {
        public int PDVId { get; set; }
        public int StopaPDV { get; set; }
        public string NazivTabele => "PDV";

        public string InsertKolone => "STOPAPDV";

        public string PrimarniKljuc => "PDVID";

        public string InsertVrednosti => $"'{StopaPDV}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            PDV pdv = new PDV();
            pdv.PDVId = (int)reader["PDVID"];
            pdv.StopaPDV = (int)reader["StopaPDV"];
            return pdv;
        }

        public override string ToString()
        {
            return $"{StopaPDV}";
        }
    }
}
