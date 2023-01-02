using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Model
{
    public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string InsertKolone { get; }
        string PrimarniKljuc { get; }
        string SpoljniKljuc { get; }
        string UslovSpajanja { get; set; }
        string InsertVrednosti { get; }
        string UpdateVrednosti { get; set; }
        string WhereUslov { get; set; }
        IDomenskiObjekat ProcitajZapis(OracleDataReader reader, bool join);
    }
}
