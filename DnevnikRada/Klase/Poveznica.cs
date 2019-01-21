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
        public List<string> Naziv_materijala { get; set; }
        public List<int> Kolicina { get; set; }

        public Poveznica()
        {

        }
        public Poveznica(object _id_evidencija, List<string> _naziv_Materijala, List<int> _kolicina)
        {
            Id_evidencija = _id_evidencija;
            Naziv_materijala = _naziv_Materijala;
            Kolicina = _kolicina;
            Dodaj();
        }

        private void Dodaj()
        {
            foreach (var pair in Naziv_materijala.Zip(Kolicina, (naziv, kolicina) => (Naziv: naziv, Kol: kolicina)))
            {
                Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
                {
                    {"Id_evidencija", Id_evidencija },
                    {"NazivMaterijala", pair.Naziv },
                    {"Kolicina", pair.Kol }
                };
                Set("Poveznica", dictionary_stupci, false);
            }
                   
        }

        public DataTable Ucitaj()
        {
            return Get("Poveznica");
        }

        public DataTable Ucitaj(int id)
        {
            return Get("Poveznica", "Id_Evidencija", id);
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return null;
        }

        public DataTable Ucitaj(int id, bool jeStrani)
        {
            return null;
        }

    }
}
