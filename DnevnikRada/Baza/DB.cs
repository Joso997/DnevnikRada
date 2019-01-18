using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.IO;

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
            //
            // ako izbaci ovdje error reinstalirat sqlite preko nugeta
            connection = new SQLiteConnection("URI = file:DB.db");
            //
            //
            
            string sqlDBTables = string.Format(@".\Baza\DB.db.sql");
            string sqlDBInsert = string.Format(@".\Baza\DB2.db.sql");
            if (!File.Exists("DB.db"))
            {
                MessageBox.Show("Baza ne postoji");
                MessageBox.Show("Cekaj napravit cu ti je");
                
                connection.Open();

                string createTables = File.ReadAllText(sqlDBTables);
                Query(createTables);
                DialogResult result = MessageBox.Show("Hoces li da ti popunim tablice?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    string insertIntoTables = File.ReadAllText(sqlDBInsert);
                    Query(insertIntoTables);
                    MessageBox.Show("Gotovo");
                }
            }
            else
            {
                //MessageBox.Show("DB EXISTS!!!");
                connection.Open();
            }
            //connection = new SQLiteConnection("URI = file:DB.db");
          
        }

        //kod za izvođenje pod bazoom BILO KOJI al mora bit sql
        private long Query(string sqlCode)
        {
            command = connection.CreateCommand();
            command.CommandText = sqlCode;
            MessageBox.Show(sqlCode);
            command.ExecuteNonQuery();
            return connection.LastInsertRowId;
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

        protected object Set(string naziv_tablice, Dictionary<string, object> stupci_vrijednost, bool IncludeUpdate)
        {
            string prviStupac = stupci_vrijednost.First().Key;
            List<string> stupci = SetStupciVrij(stupci_vrijednost);
                string insert = string.Format("insert into {3}" +
                "({0}) values({1})" + (IncludeUpdate ? " ON CONFLICT({4}) do update set {2} " : ""),
             stupci[0], stupci[1], stupci[2], naziv_tablice, prviStupac);
                return Query(insert);
        }

        protected object Set(string naziv_tablice, string constraint, Dictionary<string, object> stupci_vrijednost, bool IncludeUpdate)
        {
            List<string> stupci = SetStupciVrij(stupci_vrijednost);
            string insert = string.Format("insert into {3}" +
            "({0}) values({1})" + (IncludeUpdate ? " ON CONFLICT({4}) do update set {2} " : ""),
         stupci[0], stupci[1], stupci[2], naziv_tablice, constraint);
            return Query(insert);
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

        protected DataTable Get(string naziv_tablice, string naziv_stupca, int strani_id)
        {
            string command = string.Format("select * from {0} " +
                "WHERE {1} = '{2}'", naziv_tablice, naziv_stupca, strani_id);
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
