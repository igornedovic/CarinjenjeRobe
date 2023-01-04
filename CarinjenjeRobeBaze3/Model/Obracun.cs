using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Obracun : IDomenskiObjekat
    {
        public int BrojObracuna { get; set; }
        public DateTime? DatumObracuna { get; set; }
        public DateTime? DatumObavestenja { get; set; }
        public string Napomena { get; set; }
        public int CarinikId { get; set; }
        public int? SifraCarinarnice { get; set; }
        public int BrojJCI { get; set; }
        public int PrimalacId { get; set; }
        public int CarinskaTarifa { get; set; }
        public string NazivTabele => "OBRACUN";

        public string InsertKolone => "DATUMOBRACUNA, DATUMOBAVESTENJA, NAPOMENA, CARINIKID, SIFRACARINARNICE, BROJJCI, PRIMALACID, CARINSKATARIFA";

        public string PrimarniKljuc => "BROJOBRACUNA";

        public string SpoljniKljuc => "CARINIKID, SIFRACARINARNICE, BROJJCI, PRIMALACID, CARINSKATARIFA";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"TO_DATE('{DatumObracuna.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), TO_DATE('{DatumObavestenja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), '{Napomena}', {CarinikId}, {SifraCarinarnice}, {BrojJCI}, {PrimalacId}, {CarinskaTarifa}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Obracun o = new Obracun();
            o.BrojObracuna = (int)reader["BROJOBRACUNA"];
            o.DatumObracuna = (reader["DATUMOBRACUNA"] == DBNull.Value) ? null : (DateTime?)reader["DATUMOBRACUNA"];
            o.DatumObavestenja = (reader["DATUMOBAVESTENJA"] == DBNull.Value) ? null : (DateTime?)reader["DATUMOBAVESTENJA"];
            o.Napomena = (reader["NAPOMENA"] == DBNull.Value) ? null : (string)reader["NAPOMENA"];
            o.CarinikId = (int)reader["CARINIKID"];
            o.SifraCarinarnice = (int?)reader["SIFRACARINARNICE"];
            o.BrojJCI = (int)reader["BROJJCI"];
            o.PrimalacId = (int)reader["PRIMALACID"];
            o.CarinskaTarifa = (int)reader["CARINSKATARIFA"];

            return o;
        }
    }
}
