using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Carinik : IDomenskiObjekat
    {
        public int CarinikId { get; set; }
        public string ImePrezime { get; set; }
        public int SifraCarinarnice { get; set; }
        public string NazivTabele => "CARINIK";

        public string InsertKolone => "IMEPREZIME, SIFRACARINARNICE";

        public string PrimarniKljuc => "CARINIKID";

        public string SpoljniKljuc => "SIFRACARINARNICE";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{ImePrezime}', {SifraCarinarnice}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Carinik c = new Carinik();
            c.CarinikId = (int)reader["CARINIKID"];
            c.ImePrezime = (string)reader["IMEPREZIME"];
            c.SifraCarinarnice = (int)reader["SIFRACARINARNICE"];
            return c;
        }
    }
}
