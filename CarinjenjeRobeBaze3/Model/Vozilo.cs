using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Vozilo : IDomenskiObjekat
    {
        public string BrojTablice { get; set; }
        public string Nacionalnost { get; set; }
        public string BrojPrikolice { get; set; }
        public string TipVozila { get; set; }

        public string NazivTabele => "VOZILO";

        public string InsertKolone => "BROJTABLICE, NACIONALNOST, BROJPRIKOLICE, TIPVOZILA";

        public string PrimarniKljuc => "BROJTABLICE";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{BrojTablice}', '{Nacionalnost}', '{BrojPrikolice}', '{TipVozila}'";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Vozilo v = new Vozilo();
            v.BrojTablice = (string)reader["BROJTABLICE"];
            v.Nacionalnost = (reader["NACIONALNOST"] == DBNull.Value) ? null : (string)reader["NACIONALNOST"];
            v.BrojPrikolice = (reader["BROJPRIKOLICE"] == DBNull.Value) ? null : (string)reader["BROJPRIKOLICE"];
            v.TipVozila = (string)reader["TIPVOZILA"];

            return v;
        }

        public override string ToString()
        {
            return $"{TipVozila} - {BrojTablice}";
        }
    }
}
