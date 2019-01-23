using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DnevnikRada.Interface;

namespace DnevnikRada.Klase
{
    class Evidencija : Baza.DB, IUseDatabase
    {
        public string Naziv_Mjesta { get; }
        public DateTime Datum { get; }
        public double Cijena { get; }
        public string Opis_Posla { get; }
        public int Utroseno_Vrijeme { get; }
        public Poveznica Poveznica { get; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        //materijal i kolicina prebacena u poveznicu jer nije potrebno ovdje
        public Evidencija(string _nazivMjesta, DateTime _datum, string  _opisPosla, int _utrosenoVrijeme, double _cijena, List<string> _naziv_Materijala, List<int> _kolicina)
        {
            Poveznica = new Poveznica();
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum;
            Cijena = _cijena;
            Opis_Posla = _opisPosla;
            Utroseno_Vrijeme = _utrosenoVrijeme;
            Poveznica.Naziv_materijala = _naziv_Materijala;
            Poveznica.Kolicina = _kolicina;
            Dodaj();
        }
        public Evidencija()
        {
            Poveznica = new Poveznica();
        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMjesta", Naziv_Mjesta },
                {"Datum", Datum.ToString("yyyy-MM-dd HH:mm:ss") },
                {"OpisPosla", Opis_Posla },
                {"UtrosenoVrijeme", Utroseno_Vrijeme },
                {"Id_Mjesta", new Mjesta().Ucitaj("NazivMjesta", Naziv_Mjesta).Rows[0]["ID"] }
            };
            Poveznica.Id_evidencija = Set("Evidencija", dictionary_stupci, false);
            new Poveznica(Poveznica.Id_evidencija, Poveznica.Naziv_materijala, Poveznica.Kolicina);
        }

        public DataTable Ucitaj()
        {
            return Get("Evidencija");
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Evidencija", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(int trazi)
        {
            return Get("Evidencija", trazi);
        }

        public DataTable Ucitaj(int id, bool jeStrani)
        {
            return null;
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Evidencija", biblioteka, _operator);
        }


    }
}
