using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public class Primalac : IDomenskiObjekat
    {
        public int PrimalacId { get; set; }
        public string NazivPrimaoca { get; set; }
        public PIBObjekat PIB { get; set; }
        public int MestoId { get; set; }
        public int AdresaId { get; set; }
        public string NazivTabele => "PRIMALAC";

        public string InsertKolone => "NAZIVPRIMAOCA, PIB, MESTOID, ADRESAID";

        public string PrimarniKljuc => "PRIMALACID";

        public string SpoljniKljuc => "MESTOID, ADRESAID";

        public string UslovSpajanja { get; set; }

        public string InsertVrednosti => $"'{NazivPrimaoca}', '{PIB.PIB}', {MestoId}, {AdresaId}";

        public string UpdateVrednosti { get; set; }
        public string WhereUslov { get; set; }

        public IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join)
        {
            Primalac p = new Primalac();
            p.NazivPrimaoca = (string)reader["NAZIVPRIMAOCA"];
            p.PIB = new PIBObjekat
            {
                PIB = (reader["PIB"] == DBNull.Value) ? null : (string)reader["PIB"]
            };
            //p.MestoId = (int)reader["MESTOID"];
            //p.AdresaId = (int)reader["ADRESAID"];

            return p;
        }
        public override string ToString()
        {
            return $"{NazivPrimaoca}";
        }
    }


    public class PIBObjekat : IOracleCustomType, INullable
    {
        private bool pibObjekatIsNull;

        [OracleObjectMapping("PIB")]
        public string PIB { get; set; }

        public bool IsNull => pibObjekatIsNull;

        public static PIBObjekat Null
        {
            get
            {
                PIBObjekat p = new PIBObjekat();
                p.pibObjekatIsNull = true;
                return p;
            }
        }

        public void FromCustomObject(OracleConnection con, object udt)
        {
            OracleUdt.SetValue(con, udt, "PIB", PIB);
        }

        public void ToCustomObject(OracleConnection con, object udt)
        {
            PIB = (string)OracleUdt.GetValue(con, udt, "PIB");
        }

        public override string ToString()
        {
           if(!pibObjekatIsNull)
            {
                return $"{PIB}";
            }
           else
            {
                return null;
            }
        }
    }

    [OracleCustomTypeMapping("PIB")]
    public class PIBFactory : IOracleCustomTypeFactory
    {
        public IOracleCustomType CreateObject()
        {
            return new PIBObjekat();
        }
    }

}
