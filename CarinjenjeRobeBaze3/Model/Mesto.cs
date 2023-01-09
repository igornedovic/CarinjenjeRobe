using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Mesto : IDomenskiObjekat
    {
        public int MestoId { get; set; }
        public string NazivMesta { get; set; }
        public string PostanskiBroj { get; set; }
        public int DrzavaId { get; set; }
        public string NazivTabele => "MESTO";

        public string InsertKolone => "NAZIVMESTA, POSTANSKIBROJ, DRZAVAID";

        public string PrimarniKljuc => "MESTOID";

        public string SpoljniKljuc => "DRZAVAID";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivMesta}', '{PostanskiBroj}', {DrzavaId}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Mesto m = new Mesto();
            m.MestoId = (int)reader["MESTOID"];
            m.NazivMesta = (string)reader["NAZIVMESTA"];
            m.PostanskiBroj = (string)reader["POSTANSKIBROJ"];
            m.DrzavaId = (int)reader["DRZAVAID"];

            return m;
        }

        public override string ToString()
        {
            return $"{NazivMesta}";
        }
    }
}
