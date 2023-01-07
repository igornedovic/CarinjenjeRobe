using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class JCI : IDomenskiObjekat
    {
        public int BrojJCI { get; set; }
        public DateTime? DatumJCI { get; set; }
        public int BrojSazDeklaracije { get; set; }
        public int PosiljalacId { get; set; }
        public int PrimalacId { get; set; }
        public int SifraRadnika { get; set; }
        public int DrzavaOtpremeId { get; set; }
        public int DrzavaPoreklaId { get; set; }
        public int MestoId { get; set; }
        public string BrojTablice { get; set; }
        public int SifraCarinarnice { get; set; }
        public int UslovId { get; set; }
        public int SkladisteId { get; set; }
        public string NazivTabele => "JCI_VIEW";

        public string InsertKolone => "BROJJCI, DATUMJCI, BROJSAZDEKLARACIJE, POSILJALACID, PRIMALACID, SIFRARADNIKA, DRZAVAOTPREMEID, DRZAVAPOREKLAID, MESTOID, BROJTABLICE, SIFRACARINARNICE, USLOVID, SKLADISTEID";

        public string PrimarniKljuc => "BROJJCI";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{BrojJCI}, TO_DATE('{DatumJCI.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), {BrojSazDeklaracije}, {PosiljalacId}, {PrimalacId}, {SifraRadnika}, {DrzavaOtpremeId}, {DrzavaPoreklaId}, {MestoId}, '{BrojTablice}', {SifraCarinarnice}, {UslovId}, {SkladisteId}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            JCI jci = new JCI();
            jci.BrojJCI = (int)reader["BROJJCI"];
            jci.DatumJCI = (reader["DATUMJCI"] == DBNull.Value) ? null : (DateTime?)reader["DATUMJCI"];
            jci.BrojSazDeklaracije = (int)reader["BROJSAZDEKLARACIJE"];
            jci.PosiljalacId = (int)reader["POSILJALACID"];
            jci.PrimalacId = (int)reader["PRIMALACID"];
            jci.SifraRadnika = (int)reader["SIFRARADNIKA"];
            jci.DrzavaOtpremeId = (int)reader["DRZAVAOTPREMEID"];
            jci.DrzavaPoreklaId = (int)reader["DRZAVAPOREKLAID"];
            jci.MestoId = (int)reader["MESTOID"];
            jci.BrojTablice = (string)reader["BROJTABLICE"];
            jci.SifraCarinarnice = (int)reader["SIFRACARINARNICE"];
            jci.UslovId = (int)reader["USLOVID"];
            jci.SkladisteId = (int)reader["SKLADISTEID"];

            return jci;
        }

        public override string ToString()
        {
            return $"{BrojJCI} - {DatumJCI}";
        }
    }
}
