using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Drzava : IDomenskiObjekat
    {
        public int DrzavaId { get; set; }
        public string NazivDrzave { get; set; }
        public string OznakaDrzave { get; set; }
        public string NazivTabele => "DRZAVA";

        public string InsertKolone => "NAZIVDRZAVE, OZNAKADRZAVE";

        public string PrimarniKljuc => "DRZAVAID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivDrzave}', '{OznakaDrzave}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Drzava d = new Drzava();
            d.DrzavaId = (int)reader["DRZAVAID"];
            d.NazivDrzave = (string)reader["NAZIVDRZAVE"];
            d.OznakaDrzave = (string)reader["OZNAKADRZAVE"];

            return d;
        }

        public override string ToString()
        {
            return $"{NazivDrzave} ({OznakaDrzave})";
        }
    }
}
