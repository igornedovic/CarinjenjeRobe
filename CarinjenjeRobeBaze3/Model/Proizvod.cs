using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Proizvod : IDomenskiObjekat
    {
        public int SifraProizvoda { get; set; }
        public string NazivProizvoda { get; set; }
        public VrstaProizvoda VrstaProizvoda { get; set; }
        public string NazivTabele => "PROIZVOD";
        public string InsertKolone => "NAZIVPROIZVODA";
        public string PrimarniKljuc => "SIFRAPROIZVODA";
        public string SpoljniKljuc => "VRSTAPROIZVODAID";
        public string InsertVrednosti => $"'{NazivProizvoda}'";
        public string UslovSpajanja { get; set; }
        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader)
        {
            Proizvod p = new Proizvod();
            p.SifraProizvoda = (int)reader["SIFRAPROIZVODA"];
            p.NazivProizvoda = (string)reader["NAZIVPROIZVODA"];
            p.VrstaProizvoda = new VrstaProizvoda
            {
                VrstaProizvodaId = (int)reader["VRSTAPROIZVODAID"],
                NazivVrsteProizvoda = (string)reader["NAZIVVRSTEPROIZVODA"]
            };

            return p;
        }
    }
}
