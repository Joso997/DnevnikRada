using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    class Evidencija : Baza.DB
    {
        public string Naziv_Mjesta { get; set; }
        public DateTime Datum { get; set; }
        public string Materijal { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public string Opis_Posla { get; set; }
        public int Utroseno_Vrijeme { get; set; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        public Evidencija(string _nazivMjesta, DateTime _datum, string  _opisPosla, int _utrosenoVrijeme, string _materijal, int _kolicina, double _cijena)
        {
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum; ;
            Materijal = _materijal;
            Kolicina = _kolicina;
            Cijena = _cijena;
            Opis_Posla = _opisPosla;
            Utroseno_Vrijeme = _utrosenoVrijeme;
            Dodaj();
        }
        public Evidencija()
        {

        }

        private void Dodaj()
        {
            string insert = string.Format("insert into Evidencija (NazivMjesta,Datum,Materijal,Kolicina,Cijena,OpisPosla,UtrosenoVrijeme) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Naziv_Mjesta, Datum.ToString("yyyy-MM-dd HH:mm:ss"), Materijal, Kolicina, Cijena, Opis_Posla, Utroseno_Vrijeme);
            Query(insert);
        }

        public DataTable Get()
        {
            string command = "select * from Evidencija";
            return this.LoadDataBase(command);
        }

        public DataTable Get(string trazi)
        {
            string command = string.Format("select * from Evidencija " +
                "WHERE NazivMjesta like '%{0}%' or " +
                "Datum like '%{0}%'", trazi);
            return LoadDataBase(command);
        }

        public DataTable Get(int id)
        {
            string command = string.Format("select * from Evidencija " +
                "WHERE ID = '{0}'", id);
            return LoadDataBase(command);
        }

        public void Edit(string naziv, string prodavac, string mjernaJedinica, int kolicina, int id)
        {
            string update = string.Format("update Skladiste " +
                "set NazivMaterijala = '{0}' , Prodavac='{1}', Kolicina='{2}',MjernaJedinica='{3}'" +
                "where Id={4}", naziv, prodavac, kolicina, mjernaJedinica, id);
            Query(update);
        }
    }
}
