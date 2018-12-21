using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dnevnik_Rada.Interface;

namespace Dnevnik_Rada.Klase
{
    class Skladiste : IUseDatabase
    {
        public string Naziv_materijala { get; private set; }
        public string Proizvodac { get; private set; }
        public string Mjerna_jedinica { get; private set; }

        public Skladiste(string _naziv_materijala, string _proizvodac, string _mjerna_jedinica)
        {
            Naziv_materijala = _naziv_materijala;
            Proizvodac = _proizvodac;
            Mjerna_jedinica = _mjerna_jedinica;
            Dodaj();
        }

        public void Dodaj()
        {
            Console.WriteLine(Naziv_materijala);
            Console.WriteLine(Proizvodac);
            Console.WriteLine(Mjerna_jedinica);
        }

        public void Trazi()
        {

        }
    }
}
