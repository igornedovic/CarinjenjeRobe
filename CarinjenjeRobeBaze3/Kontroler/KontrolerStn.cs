﻿using CarinjenjeRobeBaze3.Model;
using CarinjenjeRobeBaze3.SistemskeOperacije;
using CarinjenjeRobeBaze3.SistemskeOperacije.CarinarnicaSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.CarinikSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.ObracunSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.ProizvodSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.SkladisteSO;
using CarinjenjeRobeBaze3.SistemskeOperacije.StanjeSO;
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
    }
}
