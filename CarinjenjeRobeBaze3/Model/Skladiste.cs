using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Skladiste : IDomenskiObjekat
    {
        public int SkladisteId { get; set; }
        public string NazivSkladista { get; set; }
        public string NazivTabele => "SKLADISTE";

        public string InsertKolone => "NAZIVSKLADISTA";

        public string PrimarniKljuc => "SKLADISTEID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivSkladista}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Skladiste s = new Skladiste();
            s.SkladisteId = (int)reader["SKLADISTEID"];
            s.NazivSkladista = (string)reader["NAZIVSKLADISTA"];
            return s;
        }

        public override string ToString()
        {
            return $"{SkladisteId} - {NazivSkladista}";
        }
    }
}
