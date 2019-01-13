using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikRada.Klase
{
    class Kalendar
    {
        int Godina { get; set; }
        int Mjesec { get; set; }
        DateTime Datum { get; set; }

        public Kalendar()
        {
            Godina = Convert.ToInt32(DateTime.Now.Year);
            Mjesec = Convert.ToInt32(DateTime.Now.Month);
            Mjesec_Godina();
        }

        public string Mjesec_Godina()
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Mjesec) + " " + Godina;
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
