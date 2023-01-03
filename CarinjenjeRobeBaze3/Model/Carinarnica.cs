using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Carinarnica : IDomenskiObjekat
    {
        public int SifraCarinarnice { get; set; }
        public string NazivCarinarnice { get; set; }
        public string TekuciRacun { get; set; }

        public string NazivTabele => "CARINARNICA";

        public string InsertKolone => "NAZIVCARINARNICE, TEKUCIRACUN";

        public string PrimarniKljuc => "SIFRACARINARNICE";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivCarinarnice}', '{TekuciRacun}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Carinarnica c = new Carinarnica();
            c.SifraCarinarnice = (int)reader["SIFRACARINARNICE"];
            c.NazivCarinarnice = (string)reader["NAZIVCARINARNICE"];
            c.TekuciRacun = (string)reader["TEKUCIRACUN"];
            return c;
        }

        public override string ToString()
        {
            return $"{SifraCarinarnice} - {NazivCarinarnice}";
        }
    }
}
