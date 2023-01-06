using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class SazetaDeklaracija : IDomenskiObjekat
    {
        public int BrojSazDeklaracije { get; set; }
        public DateTime? DatumSmestaja { get; set; }
        public DateTime? RokPodnosenja { get; set; }
        public int OznakaObezbedjenja { get; set; }
        public int MestoId { get; set; }
        public string BrojTablice { get; set; }
        public int SifraRadnika { get; set; }
        public int PrimalacId { get; set; }
        public int SifraCarinarnice { get; set; }
        public int SkladisteId { get; set; }
        public int? UkupanBrojKoleta { get; set; }
        public int? OriginalanUkupanBrojKoleta { get; set; }
        public List<StavkaSazDeklaracije> StavkeSazDeklaracije { get; set; } = new List<StavkaSazDeklaracije>();
        public List<StavkaSazDeklaracije> OriginalneStavkeSazDeklaracije { get; set; } = new List<StavkaSazDeklaracije>();
        public string NazivTabele => "SAZETADEKLARACIJA";

        public string InsertKolone => "ROKPODNOSENJA, OZNAKAOBEZBEDJENJA, MESTOID, BROJTABLICE, SIFRARADNIKA, PRIMALACID, SIFRACARINARNICE, SKLADISTEID, UKUPANBROJKOLETA, DATUMSMESTAJA";

        public string PrimarniKljuc => "BROJSAZDEKLARACIJE";

        public string SpoljniKljuc => "MESTOID, BROJTABLICE, SIFRARADNIKA, PRIMALACID, SIFRACARINARNICE, SKLADISTEID";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"TO_DATE('{RokPodnosenja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy'), {OznakaObezbedjenja}, {MestoId}, '{BrojTablice}', {SifraRadnika}, {PrimalacId}, {SifraCarinarnice}, {SkladisteId}, {UkupanBrojKoleta}, TO_DATE('{DatumSmestaja.Value.ToString("dd-MM-yyyy")}', 'dd-MM-yyyy')";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public string Particionisanje { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            SazetaDeklaracija sd = new SazetaDeklaracija();
            sd.BrojSazDeklaracije = (int)reader["BROJSAZDEKLARACIJE"];
            sd.DatumSmestaja = (reader["DATUMSMESTAJA"] == DBNull.Value) ? null : (DateTime?)reader["DATUMSMESTAJA"];
            sd.RokPodnosenja = (reader["ROKPODNOSENJA"] == DBNull.Value) ? null : (DateTime?)reader["ROKPODNOSENJA"];
            sd.OznakaObezbedjenja = (int)reader["OZNAKAOBEZBEDJENJA"];
            sd.UkupanBrojKoleta = (reader["UKUPANBROJKOLETA"] == DBNull.Value) ? null : (int?)reader["UKUPANBROJKOLETA"];
            sd.OriginalanUkupanBrojKoleta = sd.UkupanBrojKoleta;
            sd.MestoId = (int)reader["MESTOID"];
            sd.BrojTablice = (string)reader["BROJTABLICE"];
            sd.SifraRadnika = (int)reader["SIFRARADNIKA"];
            sd.PrimalacId = (int)reader["PRIMALACID"];
            sd.SifraCarinarnice = (int)reader["SIFRACARINARNICE"];
            sd.SkladisteId = (int)reader["SKLADISTEID"];

            return sd;
        }
    }
}
