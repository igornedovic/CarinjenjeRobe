using CarinjenjeRobeBaze3.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            cmd.CommandText = $"SELECT * FROM {obj.NazivTabele}";

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat objekat = obj.ProcitajZapis(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public List<IDomenskiObjekat> VratiSveSaSpajanjem(params IDomenskiObjekat[] obj)
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
                    IDomenskiObjekat objekat = obj[0].ProcitajZapis(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
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
