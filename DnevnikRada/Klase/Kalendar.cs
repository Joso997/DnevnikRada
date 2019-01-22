using DnevnikRada.Interface;
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
        public int Godina { get; private set; }
        public int Mjesec { get; private set; }
        public object Id_mjesta { get; set; }
        public List<DateTime> Datumi { get; set; }

        public Kalendar(object _id_mjesta, List<DateTime> _datumi)
        {
            Id_mjesta = _id_mjesta;
            Datumi = _datumi;
            Dodaj();
        }

        public Kalendar()
        {
            Godina = Convert.ToInt32(DateTime.Now.Year);
            Mjesec = Convert.ToInt32(DateTime.Now.Month);
            Mjesec_Godina(" ", false);
        }

        private void Dodaj()
        {
            foreach (var datum in Datumi)
            {
                Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
                {
                    {"Id_Mjesta", Id_mjesta },
                    {"Datum", datum.ToString("yyyy-MM-dd HH:mm:ss") }
                };
                Set("Kalendar", dictionary_stupci, false);
            }

        }

        public DataTable Ucitaj()
        {
            return Get("Kalendar");
        }

        public DataTable Ucitaj(int id)
        {
            return Get("Kalendar", id);
        }

        public DataTable Ucitaj(int id, bool jeStrani)
        {
            return Get("Kalendar", "Id_Mjesta", id);
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Kalendar", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Kalendar", biblioteka, _operator);
        }

        public string Mjesec_Godina(string conWith, bool reverse)
        {
            if(reverse)
                return Godina + conWith + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Mjesec);
            else
                return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Mjesec) + conWith + Godina;
        }

        public string Mjesec_Godina(string conWith)
        {
           return Godina + conWith + Mjesec.ToString().PadLeft(2, '0');
        }

        public void PromjeniDatum(int _mjesec)
        {  
            if (_mjesec == 1 && Mjesec == 12)
            {
                Godina += 1;
                Mjesec = 1;
            }
            else if(_mjesec == -1 && Mjesec == 1)
            {
                Godina -= 1;
                Mjesec = 12;
            }else    
                Mjesec += _mjesec;
        }
        public int GetNumOfDays()
        {
            return Convert.ToInt32(DateTime.DaysInMonth(Godina, Mjesec));
        }
        public int GetDayInWeek()
        {
            return Convert.ToInt32(new DateTime(Godina, Mjesec, 1).DayOfWeek)-1 != -1? Convert.ToInt32(new DateTime(Godina, Mjesec, 1).DayOfWeek) - 1: 6;
        }

    }
}
