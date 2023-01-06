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
                connection.Close();
            }
        }

        public void ZapocniTransakciju()
        {
            transaction = connection.BeginTransaction();
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
            OracleCommand cmd = connection.CreateCommand();
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
            OracleCommand cmd = connection.CreateCommand();

            if (obj.Length == 2)
            {
                cmd.CommandText = $"SELECT * FROM {obj[0].NazivTabele} t1 JOIN {obj[1].NazivTabele} t2 ON ({obj[0].UslovSpajanja})";
            }

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
            OracleCommand cmd = connection.CreateCommand();
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
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {obj.NazivTabele} ({obj.InsertKolone}) VALUES ({obj.InsertVrednosti})";
            cmd.ExecuteNonQuery();
        }

        public void Izmeni(IDomenskiObjekat obj)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {obj.NazivTabele} SET {obj.UpdateVrednosti} WHERE {obj.WhereUslov}";
            cmd.ExecuteNonQuery();
        }

        public void Obrisi(IDomenskiObjekat obj)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {obj.NazivTabele} WHERE {obj.WhereUslov}";
            cmd.ExecuteNonQuery();
        }
    }
}
