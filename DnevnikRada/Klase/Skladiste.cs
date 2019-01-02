using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    class Skladiste : Baza.DB
    {
        
        public string Naziv_materijala{ get; private set;}
        public string Proizvodac { get; private set; }
        public string Mjerna_jedinica { get; private set; }
        public int Kolicina { get; set; }
        //private Baza.DB baza = new Baza.DB();


        // mozda bi trebalo u konstruktor stavit samo ono sto je obavezno? recimo d su 
        public Skladiste(string _naziv_materijala, string _proizvodac, string _mjerna_jedinica, int _kolicina)
        {
            Naziv_materijala = _naziv_materijala;
            Proizvodac = _proizvodac;
            Mjerna_jedinica = _mjerna_jedinica;
            Kolicina = _kolicina;
            Dodaj();
        }

        public Skladiste()
        {

        }

        private void Dodaj()
        {
            string insert = string.Format("insert into Skladiste (NazivMaterijala,Prodavac,Kolicina,MjernaJedinica) values('{0}','{1}','{2}','{3}')", this.Naziv_materijala,this.Proizvodac,this.Kolicina,this.Mjerna_jedinica);
            Query(insert);
        }

        public DataTable Get()
        {
            string command = string.Format("select * from Skladiste");
            return LoadDataBase(command);
        }

        public DataTable Get(string trazi)
        {
            string command = string.Format("select * from Skladiste " +
                "WHERE NazivMaterijala like '%{0}%' or " +
                "Prodavac like '%{0}%'", trazi);
            return LoadDataBase(command);
        }

        public DataTable Get(int id)
        {
            string command = string.Format("select * from Skladiste " +
                "WHERE ID = '{0}'", id);
            return LoadDataBase(command);
        }

        public void Edit(string naziv,string prodavac, string mjernaJedinica, int kolicina, int id)
        {
            string update = string.Format("update Skladiste " +
                "set NazivMaterijala = '{0}' , Prodavac='{1}', Kolicina='{2}',MjernaJedinica='{3}'" +
                "where Id={4}", naziv, prodavac, kolicina, mjernaJedinica, id);
            Query(update);
        }
    }
}
