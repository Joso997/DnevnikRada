using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;

namespace DnevnikRada.Klase
{
    class Mjesta : Baza.DB 
    {
        
        public string Naziv_mjesta { get; private set; }
        public string Adresa { get; private set; }

        //vrijeme rada od do sta to tocno mora bit u bazi tj koji tip podatka

        public Mjesta(string _naziv_mjesta, string _adresa)
        {
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Dodaj();
        }

        public Mjesta()
        {

        }

        public void Dodaj()
        {
            string insert = string.Format("insert into Mjesta (NazivMjesta,Adresa) values ('{0}','{1}')", this.Naziv_mjesta,this.Adresa);
            Query(insert);
        }

        public DataTable Get()
        {
            string command = string.Format("select * from Mjesta");
            return LoadDataBase(command);
        }

        public DataTable Get(string trazi)
        {
            string command = string.Format("select * from Mjesta " +
                "WHERE NazivMjesta like '%{0}%' or " +
                "Adresa like '%{0}%'", trazi);
            return LoadDataBase(command);
        }

        public DataTable Get(int id)
        {
            string command = string.Format("select * from Mjesta " +
                "WHERE ID = '{0}'", id);
            return LoadDataBase(command);
        }

        public void Edit(string naziv, string adresa, int id)
        {
            string update = string.Format("update Mjesta " +
                "set NazivMjesta = '{0}' , Adresa='{1}'" +
                "where Id={2}", naziv, adresa, id);
            //fali jos od do vrijeme rada
            Query(update);
        }
    }
}
