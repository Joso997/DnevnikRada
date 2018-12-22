using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;

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

        public void Dodaj()
        {
            Console.WriteLine(Naziv_mjesta);
            Console.WriteLine(Adresa);
        }

        public void Trazi()
        {

        }
    }
}
