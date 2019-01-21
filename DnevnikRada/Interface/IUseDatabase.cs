using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikRada.Interface
{
    interface IUseDatabase
    {
        DataTable Ucitaj();
        DataTable Ucitaj(string naziv_stupca, string trazi);
        DataTable Ucitaj(int trazi);
        DataTable Ucitaj(int trazi, bool jeStrani);
    }
}
