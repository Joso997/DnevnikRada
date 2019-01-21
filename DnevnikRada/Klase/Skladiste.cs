﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    class Skladiste : Baza.DB, IUseDatabase
    {
        
        public string Naziv_materijala{ get;}
        public string Proizvodac { get; }
        public string Mjerna_jedinica { get; }
        public int Kolicina { get; }
        public int Cijena { get; }


        // mozda bi trebalo u konstruktor stavit samo ono sto je obavezno? recimo d su 
        public Skladiste(string _naziv_materijala, string _proizvodac, string _mjerna_jedinica, int _kolicina, int _cijena)
        {
            Naziv_materijala = _naziv_materijala;
            Proizvodac = _proizvodac;
            Mjerna_jedinica = _mjerna_jedinica;
            Kolicina = _kolicina;
            Cijena = _cijena;
            Dodaj();
        }

        public Skladiste()
        {

        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMaterijala", Naziv_materijala },
                {"Prodavac", Proizvodac },
                {"MjernaJedinica", Mjerna_jedinica },
                {"Kolicina", Kolicina },
                {"Cijena", Cijena }
            };
            Set("Skladiste", dictionary_stupci, true);
        }

        public DataTable Ucitaj()
        {
            return Get("Skladiste");
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Skladiste", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(int trazi)
        {
            return Get("Skladiste", trazi);
        }

        public DataTable Ucitaj(int trazi, bool jeStrani)
        {
            return Get("Skladiste", trazi);
        }
    }
}
