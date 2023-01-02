using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Stanje : IDomenskiObjekat
    {
        public int SifraProizvoda { get; set; }
        public int SkladisteId { get; set; }
        public string NazivProizvoda { get; set; }
        public double BrutoMasa { get; set; }
        public double NetoMasa { get; set; }

        public int OriginalnaSifraProizvoda { get; private set; }
        public string NazivTabele => "STANJE";

        public string InsertKolone => "SIFRAPROIZVODA, SKLADISTEID, NAZIVPROIZVODA, BRUTOMASA, NETOMASA";

        public string PrimarniKljuc => "SIFRAPROIZVODA, SKLADISTEID";

        public string SpoljniKljuc => "SIFRAPROIZVODA, SKLADISTEID";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{SifraProizvoda}, {SkladisteId}, '{NazivProizvoda}', {BrutoMasa}, {NetoMasa}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Stanje st = new Stanje();
            st.SifraProizvoda = (int)reader["SIFRAPROIZVODA"];
            st.OriginalnaSifraProizvoda = st.SifraProizvoda;
            st.SkladisteId = (int)reader["SKLADISTEID"];
            st.NazivProizvoda = (string)reader["NAZIVPROIZVODA"];
            st.BrutoMasa = (double)reader["BRUTOMASA"];
            st.NetoMasa = (double)reader["NETOMASA"];
            return st;
        }
    }
}
