using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Adresa : IDomenskiObjekat
    {
        public int MestoId { get; set; }
        public int AdresaId { get; set; }
        public UlicaBroj UlicaBroj { get; set; }
        public int OriginalnoMestoId { get; set; }
        public string NazivTabele => "ADRESA";

        public string InsertKolone => "MESTOID, ULICABROJ";

        public string PrimarniKljuc => "MESTOID, ADRESAID";

        public string SpoljniKljuc => "";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"{MestoId}, ULICA_BROJ('{UlicaBroj.NazivUlice}', '{UlicaBroj.Broj}')";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Adresa a = new Adresa();
            a.MestoId = (int)reader["MESTOID"];
            a.OriginalnoMestoId = a.MestoId;
            a.AdresaId = (int)reader["ADRESAID"];
            a.UlicaBroj = new UlicaBroj
            {
                NazivUlice = (reader["NAZIVULICE"] == DBNull.Value) ? null : (string)reader["NAZIVULICE"],
                Broj = (reader["BROJ"] == DBNull.Value) ? null : (string)reader["BROJ"]
            };

            return a;
        }

        public override string ToString()
        {
            return UlicaBroj.ToString();
        }
    }

    public class UlicaBroj : IOracleCustomType, INullable
    {
        private bool ulicaBrojIsNull;

        [OracleObjectMapping("NAZIV_ULICE")]
        public string NazivUlice { get; set; }
        [OracleObjectMapping("BROJ")]
        public string Broj { get; set; }

        public bool IsNull => ulicaBrojIsNull;

        public static UlicaBroj Null
        {
            get
            {
                UlicaBroj ubo = new UlicaBroj();
                ubo.ulicaBrojIsNull = true;
                return ubo;
            }
        }

        public void FromCustomObject(OracleConnection con, object udt)
        {
            OracleUdt.SetValue(con, udt, "NAZIV_ULICE", NazivUlice);
            OracleUdt.SetValue(con, udt, "BROJ", Broj);
        }

        public void ToCustomObject(OracleConnection con, object udt)
        {
            NazivUlice = (string)OracleUdt.GetValue(con, udt, "NAZIV_ULICE");
            Broj = (string)OracleUdt.GetValue(con, udt, "BROJ");
        }

        public override string ToString()
        {
            if (!ulicaBrojIsNull)
            {
                return $"{NazivUlice} {Broj}";
            }
            else
            {
                return null;
            }
        }
    }

    [OracleCustomTypeMapping("ULICA BROJ")]
    public class UlicaBrojFactory : IOracleCustomTypeFactory
    {
        public IOracleCustomType CreateObject()
        {
            return new UlicaBroj();
        }
    }
}
