using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikRada.Klase
{
    class EVTrazi_TEST_ : Baza.DB
    {
        public string Name { get; set; }
        public EVTrazi_TEST_(string ime)
        {
            Name = ime;
        }

        public List<string> Lista()
        {

            return Radil();
        }


    }
}
