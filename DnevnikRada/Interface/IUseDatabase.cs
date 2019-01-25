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
        DataTable Ucitaj(int _id);
        DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator);
    }
}
