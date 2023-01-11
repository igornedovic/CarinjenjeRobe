using CarinjenjeRobeBaze3.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.DBB
{
    public class GenerickiBroker : IGenerickiBroker<IDomenskiObjekat>
    {
        private OracleConnection connection;
        private OracleTransaction transaction;
        private OracleCommand cmd;

        public GenerickiBroker()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["student"].ConnectionString;
            connection = new OracleConnection(connectionString);
        }
        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void ZatvoriKonekciju()
        {
            if (connection != null)
            {
                if (cmd != null)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }

                    cmd.Dispose();
                }

                connection.Close();
                connection.Dispose();
            }
        }

        public void ZapocniTransakciju()
        {
            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void PotvrdiTransakciju()
        {
            transaction.Commit();
        }

        public void PonistiTransakciju()
        {
            transaction.Rollback();
        }

        public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat obj)
        {
            List<IDomenskiObjekat> rezultat = new List<IDomenskiObjekat>();
            cmd = connection.CreateCommand();
            var query = new StringBuilder($"SELECT * FROM {obj.NazivTabele}");

            if (obj.WhereUslov != null)
            {
                query.Append($" WHERE {obj.WhereUslov}");
            }

            if (obj is SazetaDeklaracija sd && sd.Particionisanje != null)
            {
                query.Append($" {sd.Particionisanje}");
            }

            cmd.CommandText = query.ToString();

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat objekat = obj.ProcitajZapis(reader, join: false);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public List<IDomenskiObjekat> VratiSaSpajanjem(params IDomenskiObjekat[] obj)
        {
            List<IDomenskiObjekat> rezultat = new List<IDomenskiObjekat>();
            cmd = connection.CreateCommand();

            var query = new StringBuilder($"SELECT * FROM {obj[0].NazivTabele} t1");

            if (obj.Length >= 2)
            {
                query.Append($" JOIN {obj[1].NazivTabele} t2 ON ({obj[0].UslovSpajanja})");

                if (obj[0].WhereUslov != null)
                {
                    query.Append($" WHERE {obj[0].WhereUslov}");
                }

                if (obj[1].WhereUslov != null)
                {
                    query.Append($" WHERE {obj[1].WhereUslov}");
                }
            } 
            
            if (obj.Length >= 3)
            {
                query.Append($" JOIN {obj[2].NazivTabele} t3 ON ({obj[1].UslovSpajanja})");
            }

            cmd.CommandText = query.ToString();

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat objekat = obj[0].ProcitajZapis(reader, join: true);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public int SacuvajIVratiId(IDomenskiObjekat obj)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {obj.NazivTabele} ({obj.InsertKolone}) VALUES ({obj.InsertVrednosti}) RETURNING BROJSAZDEKLARACIJE INTO :id_param";
            OracleParameter parameter = new OracleParameter("id_param", OracleDbType.Int32);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);
            cmd.Parameters["id_param"].DbType = DbType.Int32;
            cmd.ExecuteNonQuery();
            return (int)parameter.Value;
        }

        public void Sacuvaj(IDomenskiObjekat obj)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {obj.NazivTabele} ({obj.InsertKolone}) VALUES ({obj.InsertVrednosti})";
            cmd.ExecuteNonQuery();
        }

        public void Izmeni(IDomenskiObjekat obj)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {obj.NazivTabele} SET {obj.UpdateVrednosti} WHERE {obj.WhereUslov}";
            cmd.ExecuteNonQuery();
        }

        public void Obrisi(IDomenskiObjekat obj)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {obj.NazivTabele} WHERE {obj.WhereUslov}";
            cmd.ExecuteNonQuery();
        }

        #region Primalac
        public List<Primalac> VratiPrimaoce(Primalac primalac)
        {
            List<Primalac> rezultat = new List<Primalac>();
            cmd = connection.CreateCommand();
            cmd.CommandText = $@"SELECT p.PRIMALACID, p.NAZIVPRIMAOCA, p.PIB.get_poreski_id_broj() ""PIB"", p.MESTOID, P.ADRESAID FROM {primalac.NazivTabele} p";
            OracleParameter parameter = new OracleParameter();
            parameter.OracleDbType = OracleDbType.Object;
            parameter.Direction = ParameterDirection.ReturnValue;
            parameter.UdtTypeName = "PIB";
            cmd.Parameters.Add(parameter);

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Primalac p = new Primalac();
                    p.PrimalacId = (int)reader["PRIMALACID"];
                    p.NazivPrimaoca = (string)reader["NAZIVPRIMAOCA"];
                    p.PIB = new PIBObjekat
                    {
                        PIB = (string)reader["PIB"]
                    };
                    p.MestoId = (int)reader["MESTOID"];
                    p.AdresaId = (int)reader["ADRESAID"];

                    rezultat.Add(p);
                }
            }

            return rezultat;
        }
        #endregion

        #region Adresa
        public List<Adresa> VratiAdrese(Adresa adresa)
        {
            List<Adresa> rezultat = new List<Adresa>();
            cmd = connection.CreateCommand();
            cmd.CommandText = $@"SELECT a.MESTOID, a.ADRESAID, a.ULICABROJ.get_naziv_ulice() ""NAZIVULICE"", a.ULICABROJ.get_broj() ""BROJ"" FROM {adresa.NazivTabele} a";
            OracleParameter parameter = new OracleParameter();
            parameter.OracleDbType = OracleDbType.Object;
            parameter.Direction = ParameterDirection.ReturnValue;
            parameter.UdtTypeName = "ULICABROJ";
            cmd.Parameters.Add(parameter);

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Adresa a = new Adresa();
                    a.MestoId = (int)reader["MESTOID"];
                    a.AdresaId = (int)reader["ADRESAID"];
                    a.UlicaBroj = new UlicaBroj
                    {
                        NazivUlice = (string)reader["NAZIVULICE"],
                        Broj = (string)reader["BROJ"]
                    };

                    rezultat.Add(a);
                }
            }

            return rezultat;
        }

        #endregion
    }
}
