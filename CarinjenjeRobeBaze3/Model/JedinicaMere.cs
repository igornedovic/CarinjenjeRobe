using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class JedinicaMere : IDomenskiObjekat
    {
        public int SifraJM { get; set; }
        public string NazivJM { get; set; }
        public string NazivTabele => "JEDINICAMERE";

        public string InsertKolone => "SIFRAJM, NAZIVJM";

        public string PrimarniKljuc => "SIFRAJM";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{SifraJM}, '{NazivJM}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            JedinicaMere jm = new JedinicaMere();
            jm.SifraJM = (int)reader["SIFRAJM"];
            jm.NazivJM = (string)reader["NAZIVJM"];

            return jm;
        }

        public override string ToString()
        {
            return $"{NazivJM}";
        }
    }
}
