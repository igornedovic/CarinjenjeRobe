using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Uslov : IDomenskiObjekat
    {
        public int UslovId { get; set; }
        public string Komentar { get; set; }
        public string NazivTabele => "USLOVIISPORUKE";

        public string InsertKolone => "";

        public string PrimarniKljuc => "USLOVID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => "";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Uslov u = new Uslov();
            u.UslovId = (int)reader["USLOVID"];
            u.Komentar = (string)reader["KOMENTAR"];

            return u;
        }

        public override string ToString()
        {
            return $"{Komentar}";
        }
    }
}
