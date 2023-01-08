using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.SistemskeOperacije;
using CarinjenjeRobeBaze3.SistemskeOperacije.CarinarnicaSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.CarinaSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.JCISO;
using CarinjenjeRobeBaze3.SistemskeOperacije.ObracunSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.PrimalacSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.RadnikSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.SazetaDeklaracijaSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.SkladisteSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.StanjeSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.VoziloSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.VrstaProizvodaSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarinjenjeRobeBaze3.Kontroler
{
    public class KontrolerStn
    {
        private static KontrolerStn instanca;

        private KontrolerStn() { }

        public static KontrolerStn Instanca
        {
            get
            {
                if (instanca == null) instanca = new KontrolerStn();
                return instanca;
            }
        }

        #region VrstaProizvoda
        public List<VrstaProizvoda> UcitajVrsteProizvoda()
        {
            OpstaSO oso = new UcitajVrsteProizvodaSO();
            oso.Izvrsi();
            return ((UcitajVrsteProizvodaSO)oso).Rezultat;
        }

        #endregion

        #region Proizvod
        public List<Proizvod> UcitajProizvode()
        {
            OpstaSO oso = new UcitajProizvodeSO();
            oso.Izvrsi();
            return ((UcitajProizvodeSO)oso).Rezultat;
        }

        public void SacuvajProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new SacuvajProizvodSO();
            oso.Izvrsi(proizvod);
        }

        public void IzmeniProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new IzmeniProizvodSO();
            oso.Izvrsi(proizvod);
        }

        public void ObrisiProizvod(Proizvod proizvod)
        {
            OpstaSO oso = new ObrisiProizvodSO();
            oso.Izvrsi(proizvod);
        }

        #endregion

        #region Skladiste

        public List<Skladiste> UcitajSkladista()
        {
            OpstaSO oso = new UcitajSkladistaSO();
            oso.Izvrsi();
            return ((UcitajSkladistaSO)oso).Rezultat;
        }

        #endregion

        #region Stanje

        public List<Stanje> UcitajStanja()
        {
            OpstaSO oso = new UcitajStanjaSO();
            oso.Izvrsi();
            return ((UcitajStanjaSO)oso).Rezultat;
        }

        public void SacuvajStanje(Stanje stanje)
        {
            OpstaSO oso = new SacuvajStanjeSO();
            oso.Izvrsi(stanje);
        }

        public void IzmeniStanje(Stanje stanje)
        {
            OpstaSO oso = new IzmeniStanjeSO();
            oso.Izvrsi(stanje);
        }

        public void ObrisiStanje(Stanje stanje)
        {
            OpstaSO oso = new ObrisiStanjeSO();
            oso.Izvrsi(stanje);
        }

        #endregion

        #region Carinarnica
        public List<Carinarnica> UcitajCarinarnice()
        {
            OpstaSO oso = new UcitajCarinarniceSO();
            oso.Izvrsi();
            return ((UcitajCarinarniceSO)oso).Rezultat;
        }

        public void SacuvajCarinarnicu(Carinarnica carinarnica)
        {
            OpstaSO oso = new SacuvajCarinarnicuSO();
            oso.Izvrsi(carinarnica);
        }

        public void IzmeniCarinarnicu(Carinarnica carinarnica)
        {
            OpstaSO oso = new IzmeniCarinarnicuSO();
            oso.Izvrsi(carinarnica);
        }

        public void ObrisiCarinarnicu(Carinarnica carinarnica)
        {
            OpstaSO oso = new ObrisiCarinarnicuSO();
            oso.Izvrsi(carinarnica);
        }

        #endregion

        #region Carinik

        public List<Carinik> UcitajCarinike()
        {
            OpstaSO oso = new UcitajCarinikeSO();
            oso.Izvrsi();
            return ((UcitajCarinikeSO)oso).Rezultat;
        }

        public void SacuvajCarinika(Carinik carinik)
        {
            OpstaSO oso = new SacuvajCarinikaSO();
            oso.Izvrsi(carinik);
        }

        public void IzmeniCarinika(Carinik carinik)
        {
            OpstaSO oso = new IzmeniCarinikaSO();
            oso.Izvrsi(carinik);
        }

        public void ObrisiCarinika(Carinik carinik)
        {
            OpstaSO oso = new ObrisiCarinikaSO();
            oso.Izvrsi(carinik);
        }

        #endregion

        #region CarinskaTarifa
        public List<Carina> UcitajCarinskeTarife()
        {
            OpstaSO oso = new UcitajCarinskeTarifeSO();
            oso.Izvrsi();
            return ((UcitajCarinskeTarifeSO)oso).Rezultat;
        }

        #endregion

        #region Radnik
        public List<Radnik> UcitajRadnike()
        {
            OpstaSO oso = new UcitajRadnikeSO();
            oso.Izvrsi();
            return ((UcitajRadnikeSO)oso).Rezultat;
        }

        #endregion

        #region Primalac
        public List<Primalac> UcitajPrimaoce()
        {
            OpstaSO oso = new UcitajPrimaoceSO();
            oso.Izvrsi();
            return ((UcitajPrimaoceSO)oso).Rezultat;
        }

        #endregion

        #region Vozilo
        public List<Vozilo> UcitajVozila()
        {
            OpstaSO oso = new UcitajVozilaSO();
            oso.Izvrsi();
            return ((UcitajVozilaSO)oso).Rezultat;
        }

        public void SacuvajVozilo(Vozilo vozilo)
        {
            OpstaSO oso = new SacuvajVoziloSO();
            oso.Izvrsi(vozilo);
        }

        public void IzmeniVozilo(Vozilo vozilo)
        {
            OpstaSO oso = new IzmeniVoziloSO();
            oso.Izvrsi(vozilo);
        }
        public void ObrisiVozilo(Vozilo vozilo)
        {
            OpstaSO oso = new ObrisiVoziloSO();
            oso.Izvrsi(vozilo);
        }

        #endregion

        #region Obracun

        public List<Obracun> UcitajObracune()
        {
            OpstaSO oso = new UcitajObracuneSO();
            oso.Izvrsi();
            return ((UcitajObracuneSO)oso).Rezultat;
        }

        public void SacuvajObracun(Obracun obracun)
        {
            OpstaSO oso = new SacuvajObracunSO();
            oso.Izvrsi(obracun);
        }

        public void IzmeniObracun(Obracun obracun)
        {
            OpstaSO oso = new IzmeniObracunSO();
            oso.Izvrsi(obracun);
        }

        public void ObrisiObracun(Obracun obracun)
        {
            OpstaSO oso = new ObrisiObracunSO();
            oso.Izvrsi(obracun);
        }
        #endregion

        #region SazetaDeklaracija

        public List<SazetaDeklaracija> UcitajSazete(SazetaDeklaracija sazeta)
        {
            OpstaSO oso = new UcitajSazeteSO();
            oso.Izvrsi(sazeta);
            return ((UcitajSazeteSO)oso).Rezultat;
        }

        public List<StavkaSazDeklaracije> UcitajStavke(SazetaDeklaracija sazeta)
        {
            OpstaSO oso = new UcitajStavkeSO();
            oso.Izvrsi(sazeta);
            return ((UcitajStavkeSO)oso).Rezultat;
        }

        public void SacuvajSazetu(SazetaDeklaracija sazeta)
        {
            OpstaSO oso = new SacuvajSazetuSO();
            oso.Izvrsi(sazeta);
        }

        public void IzmeniSazetu(SazetaDeklaracija sazeta)
        {
            OpstaSO oso = new IzmeniSazetuSO();
            oso.Izvrsi(sazeta);
        }

        public void ObrisiSazetu(SazetaDeklaracija sazeta)
        {
            OpstaSO oso = new ObrisiSazetuSO();
            oso.Izvrsi(sazeta);
        }

        #endregion

        #region JCI
        public List<JCI> UcitajJCI(Primalac p = null)
        {
            OpstaSO oso = new UcitajJCISO();
            oso.Izvrsi(p);
            return ((UcitajJCISO)oso).Rezultat;
        }

        public void SacuvajJCI(JCI jci)
        {
            OpstaSO oso = new SacuvajJCISO();
            oso.Izvrsi(jci);
        }

        public void IzmeniJCI(JCI jci)
        {
            OpstaSO oso = new IzmeniJCISO();
            oso.Izvrsi(jci);
        }

        public void ObrisiJCI(JCI jci)
        {
            OpstaSO oso = new ObrisiJCISO();
            oso.Izvrsi(jci);
        }

        #endregion
    }
}
