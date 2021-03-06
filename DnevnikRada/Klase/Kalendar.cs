﻿using DnevnikRada.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikRada.Klase
{
    class Kalendar : Baza.DB, IUseDatabase
    {
        public object Id_mjesta { get; set; }
        public List<DateTime> Datumi { get; set; }
        public DateTime Datum { get; private set; }
        public bool Hide { get; private set; }
        public int Sifra { get; private set; }

        public Kalendar(int _sifra, List<DateTime> _datumi, bool _hide)
        {
            Sifra = _sifra;
            Id_mjesta = 0;
            Datumi = _datumi;
            Hide = _hide;
            Dodaj();
        }

        public Kalendar(object _id_mjesta, List<DateTime> _datumi, bool _hide)
        {
            Sifra = -1;
            Id_mjesta = _id_mjesta;
            Datumi = _datumi;
            Hide = _hide;
            Dodaj();
        }

        public Kalendar()
        {
            Id_mjesta = -1;
            Datum = DateTime.Now;
        }

        private void Dodaj()
        {
            foreach (var datum in Datumi)
            {
                Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
                {
                    {"Id_Mjesta", Id_mjesta },
                    {"Datum", datum.ToString("yyyy-MM-dd HH:mm:ss") },
                    {"Sakriveno", Hide }
                };
                if(Sifra != -1)
                {
                    dictionary_stupci.Add("Sifra", Sifra);
                    Set("Kalendar", "Sifra", dictionary_stupci, true);
                }  
                else
                    Set("Kalendar", dictionary_stupci, false);
            }

        }

        public DataTable Ucitaj()
        {
            return Get("Kalendar");
        }

        public DataTable Ucitaj(int _id)
        {
            return Get("Kalendar", new Dictionary<string, object> { { "ID", _id } }, new List<string> { { "=" } });
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Kalendar", biblioteka, _operator);
        }

        public string Godina_Mjesec(string conWith)
        {
           return Datum.Year + conWith + Datum.Month.ToString().PadLeft(2, '0');
        }

        public void PromjeniDatum(int _mjesec)
        {  
            if (_mjesec == 1 && Datum.Month == 12)
                Datum = new DateTime(Datum.Year+1, 1, Datum.Day);
            else if(_mjesec == -1 && Datum.Month == 1)
                Datum = new DateTime(Datum.Year-1, 12, Datum.Day);
            else
                Datum = new DateTime(Datum.Year, Datum.Month+_mjesec, Datum.Day);
        }
        public int GetNumOfDays()
        {
            return Convert.ToInt32(DateTime.DaysInMonth(Datum.Year, Datum.Month));
        }
        public int GetDayInWeek()
        {
            return Convert.ToInt32(new DateTime(Datum.Year, Datum.Month, 1).DayOfWeek)-1 != -1? Convert.ToInt32(new DateTime(Datum.Year, Datum.Month, 1).DayOfWeek) - 1: 6;
        }

    }
}
