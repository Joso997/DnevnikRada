using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;

namespace DnevnikRada.Klase
{
    class Mjesta : IUseDatabase
    {
        
        public string Naziv_mjesta { get; private set; }
        public string Adresa { get; private set; }

        public Mjesta(string _naziv_mjesta, string _adresa)
        {
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Dodaj();
        }

        public Mjesta()
        {

        }

        public void Dodaj()
        {
            Baza.DB baza = new Baza.DB();
            string insert = string.Format("insert into Mjesta (NazivMjesta,Adresa) values ('{0}','{1}')", this.Naziv_mjesta,this.Adresa);
            baza.Query(insert);
        }

        public DataTable Trazi(string trazi)
        {
            string command = string.Format("select * from Mjesta " +
                "WHERE NazivMjesta like '%{0}%' or " +
                "Adresa like '%{0}%'", trazi);
            Baza.DB baza = new Baza.DB();
            return baza.LoadDataBase(command);
        }
    }
}
