using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DnevnikRada.Interface;

namespace DnevnikRada.Klase
{
    class Poveznica : Baza.DB, IUseDatabase
    {
        public object Id_evidencija { get; set; }
        public Dictionary<string, int> Informacije { get; set; }

        public Poveznica()
        {

        }
        public Poveznica(object _id_evidencija, Dictionary<string, int> _informacije)
        {
            Id_evidencija = _id_evidencija;
            Informacije = _informacije;
            Dodaj();
        }

        private void Dodaj()
        {
            foreach (KeyValuePair<string,int> info in Informacije)
            {
                Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
                {
                    {"Id_evidencija", Id_evidencija },
                    {"NazivMaterijala", info.Key },
                    {"Kolicina", info.Value },
                    {"Id_Materijala", new Skladiste().Ucitaj(new Dictionary<string, object>{{ "NazivMaterijala", info.Key } }, new List<string> {{"="}}).Rows[0]["ID"] }
                };
                Set("Poveznica", dictionary_stupci, false);
                Update(info.Key, info.Value);
            }
                   
        }

        public DataTable Ucitaj()
        {
            return Get("Poveznica");
        }

        public DataTable Ucitaj(int _id)
        {
            return Get("Poveznica", new Dictionary<string, object> { { "ID", _id } }, new List<string> { { "=" } });
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Poveznica", biblioteka, _operator);
        }

    }
}
