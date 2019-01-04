using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace DnevnikRada.Baza
{
    class DB
    {
        protected SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataAdapter db;
        private DataSet ds;
        private DataTable table = new DataTable();

        //OTVARA KONEKCIJU PREMA BAZI
        public DB()
        {
            connection = new SQLiteConnection("Data Source = DB.db");
            connection.Open();
            if (connection.State == ConnectionState.Open)
                MessageBox.Show("BAZA JE OTVORENA! YEY");
            else
                MessageBox.Show("Error 404 NIGGA NOT FOUND");
        }

        //kod za izvođenje pod bazoom BILO KOJI al mora bit sql
        private void Query(string sqlCode)
        {
            command = connection.CreateCommand();
            command.CommandText = sqlCode;
            MessageBox.Show(sqlCode);
            command.ExecuteNonQuery(); 
        } 

        //loudanje baze u formsima tj u tablici i vraca tu tablicu za grid view
        private DataTable LoadDataBase(string load)
        {
            command = connection.CreateCommand();
            db = new SQLiteDataAdapter(load, connection);
            ds = new DataSet();
            db.Fill(ds);
            table = ds.Tables[0]; 
            return table;
        }

        public List<string> Radil(string komponenta,  string tablica)
        {
            
            string query = string.Format( "select {0} from {1}", komponenta, tablica);
            List<string> test = new List<string>();
            command = new SQLiteCommand(query, connection);
            

            SQLiteDataReader reader=command.ExecuteReader();
            test.Add("null");
            while (reader.Read())
            {
                string name = reader.GetString(0);
                
                test.Add(name);
                MessageBox.Show(name);
            }

            return test;
        }

        protected void Set(string naziv_tablice, Dictionary<string, object> stupci_vrijednost)
        {
            string prviStupac = stupci_vrijednost.First().Key;
            List<string> stupci = SetStupciVrij(stupci_vrijednost);
            string insert = string.Format("insert into {3}"+
                "({0}) values({1})" +
            " ON CONFLICT({4}) do update set {2} ",
             stupci[0], stupci[1], stupci[2], naziv_tablice, prviStupac);
            Query(insert);
        }

        protected DataTable Get(string naziv_tablice)
        {
            string command = string.Format("select * from {0}", naziv_tablice);
            return LoadDataBase(command);
        }

        protected DataTable Get(string naziv_tablice, string naziv_stupca, string trazi)
        {
            string command = string.Format("select * from {0} " +
                "WHERE {1} like '%{2}%'", naziv_tablice, naziv_stupca, trazi);
            return LoadDataBase(command);
        }

        protected DataTable Get(string naziv_tablice, int id)
        {
            string command = string.Format("select * from {0} " +
                "WHERE ID = '{1}'", naziv_tablice, id);
            return LoadDataBase(command);
        }

        protected DataTable Get2(string nazivTablice, string nazivKomponente, int id)
        {
            string command = string.Format("select * from {0} " +
                "where {1}='{2}'", nazivTablice, nazivKomponente, id);
            MessageBox.Show(command);
            return LoadDataBase(command);
        }
        
        protected DataTable Get2(string nazivKomponente, string nazivTablice)
        {
            string command = string.Format("select {0} from {1}", nazivKomponente, nazivTablice);
            return LoadDataBase(command);
        }

        private List<string> SetStupciVrij(Dictionary<string, object> stupci)
        {
            List<string> _temp = new List<string>();
            string stupac = null;
            string value = null;
            string stupciValue = null;
            foreach (KeyValuePair<string, object> str in stupci)
            {
                stupac += str.Key + (str.Key.Equals(stupci.Last().Key) ? "" : ",");
                value += "'" + str.Value + "'" + (str.Key.Equals(stupci.Last().Key) ? "" : ",");
                stupciValue += str.Key + "=" + "'" + str.Value + "'" + (str.Key.Equals(stupci.Last().Key) ? "" : ",");
            }
            _temp.Add(stupac);
            _temp.Add(value);
            _temp.Add(stupciValue);
            return _temp;
        }
    }
}
