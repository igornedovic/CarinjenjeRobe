using CarinjenjeRobeBaze3.DBB;
using CarinjenjeRobeBaze3.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected IGenerickiBroker<IDomenskiObjekat> broker = new GenerickiBroker();

        public void Izvrsi(IDomenskiObjekat obj = null)
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.ZapocniTransakciju();
                IzvrsiUpit(obj);
                broker.PotvrdiTransakciju();
            }
            catch (OracleException ex)
            {
                broker.PonistiTransakciju();
                throw ex;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        protected abstract void IzvrsiUpit(IDomenskiObjekat obj = null);
    }
}
