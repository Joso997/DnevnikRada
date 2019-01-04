using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DnevnikRada.Klase
{
    class EVTrazi_TEST_ : Baza.DB
    {
        public string Name { get; set; }
        public EVTrazi_TEST_(string ime)
        {
            Name = ime;
        }

        public DataTable Test(string nazivKomp, string nazivTablice)
        {
            return Get2(nazivKomp,nazivTablice);
        }


    }
}
