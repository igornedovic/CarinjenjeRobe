using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Carina : IDomenskiObjekat
    {
        public int CarinskaTarifa { get; set; }
        public int StopaCarine { get; set; }
        public string NazivTabele => "CARINA";

        public string InsertKolone => "CARINSKATARIFA, STOPACARINE";

        public string PrimarniKljuc => "CARINSKATARIFA";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{CarinskaTarifa}, {StopaCarine}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Carina c = new Carina();
            c.CarinskaTarifa = (int)reader["CARINSKATARIFA"];
            c.StopaCarine = (int)reader["STOPACARINE"];

            return c;
        }

        public override string ToString()
        {
            return $"{CarinskaTarifa} - {StopaCarine}%";
        }
    }
}
