using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Radnik : IDomenskiObjekat
    {
        public int SifraRadnika { get; set; }
        public string ImePrezime { get; set; }
        public string NazivTabele => "RADNIK";

        public string InsertKolone => "SIFRARADNIKA, IMEPREZIME";

        public string PrimarniKljuc => "SIFRARADNIKA";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{SifraRadnika}, '{ImePrezime}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Radnik r = new Radnik();
            r.SifraRadnika = (int)reader["SIFRARADNIKA"];
            r.ImePrezime = (string)reader["IMEPREZIME"];

            return r;
        }

        public override string ToString()
        {
            return $"{SifraRadnika} - {ImePrezime}";
        }
    }
}
