using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class StavkaSazDeklaracije : IDomenskiObjekat
    {
        public int BrojSazDeklaracije { get; set; }
        public int RbStavke { get; set; }
        public double BrojPrevozneIsprave { get; set; }
        public int BrojKoleta { get; set; }
        public string Napomena { get; set; }
        public int SifraProizvoda { get; set; }
        public int SifraJM { get; set; }
        public string NazivTabele => "STAVKASAZDEKLARACIJE";

        public string InsertKolone => "BROJSAZDEKLARACIJE, RBSTAVKE, BROJPREVOZNEISPRAVE, BROJKOLETA, NAPOMENA, SIFRAPROIZVODA, SIFRAJM";

        public string PrimarniKljuc => "BROJSAZDEKLARACIJE, RBSTAVKE";

        public string SpoljniKljuc => "SIFRAPROIZVODA, SIFRAJM";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{BrojSazDeklaracije}, {RbStavke}, {BrojPrevozneIsprave}, {BrojKoleta}, '{Napomena}', {SifraProizvoda}, {SifraJM}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            StavkaSazDeklaracije ssd = new StavkaSazDeklaracije();
            ssd.BrojSazDeklaracije = (int)reader["BROJSAZDEKLARACIJE"];
            ssd.RbStavke = (int)reader["RBSTAVKE"];
            ssd.BrojPrevozneIsprave = (double)reader["BROJPREVOZNEISPRAVE"];
            ssd.BrojKoleta = (int)reader["BROJKOLETA"];
            ssd.Napomena = (string)reader["NAPOMENA"];
            ssd.SifraProizvoda = (int)reader["SIFRAPROIZVODA"];
            ssd.SifraJM = (int)reader["SIFRAJM"];

            return ssd;
        }
    }
}
