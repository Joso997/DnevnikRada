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
        private SQLiteConnection connection;
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
            //za testiranje tjekom rada s aplikacijom
            string workingDirectory = Environment.CurrentDirectory;
            string sqlDBTables = string.Format(Directory.GetParent(workingDirectory).Parent.FullName + @"\Baza\DB.db.sql");
            string sqlDBInsert = string.Format(Directory.GetParent(workingDirectory).Parent.FullName + @"\Baza\DB2.db.sql");
            

            /* // za publishanje
            string sqlDBTables = string.Format(@".\Baza\DB.db.sql");
            string sqlDBInsert = string.Format(@".\Baza\DB2.db.sql");
            */
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
            List<string> stupci = MakeReadyForInsert(stupci_vrijednost);
                string insert = string.Format("insert into {3}" +
                "({0}) values({1})" + (IncludeUpdate ? " ON CONFLICT({4}) do update set {2} " : ""),
             stupci[0], stupci[1], stupci[2], naziv_tablice, prviStupac);
                return Query(insert);
        }

        protected object Set(string naziv_tablice, string constraint, Dictionary<string, object> stupci_vrijednost, bool IncludeUpdate)
        {
            List<string> stupci = MakeReadyForInsert(stupci_vrijednost);
            string insert = string.Format("insert into {3}" +
            "({0}) values({1})" + (IncludeUpdate ? " ON CONFLICT({4}) do update set {2} " : ""),
         stupci[0], stupci[1], stupci[2], naziv_tablice, constraint);
            return Query(insert);
        }

        protected object Update(string nazivMaterijala, int kolicina)
        {
            
            string update = string.Format("update skladiste set kolicina =kolicina+(1*{0}) " +
                "where NazivMaterijala = " + '"' + "{1}" + '"' 
                , kolicina,nazivMaterijala);
            return Query(update);
        }

        protected DataTable Get(string naziv_tablice)
        {
            string command = string.Format("select * from {0} WHERE Sakriveno = 0 OR Sakriveno = 'False'", naziv_tablice);
            return LoadDataBase(command);
        }

        protected DataTable Get(string naziv_tablice, Dictionary<string, object> biblioteka, List<string> operatorUsporedbe)
        {
            string stupci = MakeReadyForQuery(biblioteka, operatorUsporedbe);
            string command = string.Format("select * from {0} " +
                "WHERE {1} AND (Sakriveno = 0 OR Sakriveno = 'False')", naziv_tablice, stupci);
            return LoadDataBase(command);
        }

        private List<string> MakeReadyForInsert(Dictionary<string, object> stupci)
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

        private string MakeReadyForQuery(Dictionary<string, object> stupci, List<string> _operatorUsporedbe)
        {
            string queryOne = null;
            foreach (var pair in stupci.Zip(_operatorUsporedbe, (stupac, operatorUsporedbe) => (Stupac: stupac, OperatorUsporedbe: operatorUsporedbe)))
            {
                queryOne += pair.Stupac.Key + " " + pair.OperatorUsporedbe + " '" + pair.Stupac.Value + "'" + (pair.Stupac.Key.Equals(stupci.Last().Key) ? " " : " AND ");
            }
            return queryOne;
        }

        protected bool ProvjeraNegativnosti(string naziv, int kolicina)
        {
            int read=0;
            string all = string.Format("select Kolicina from Skladiste where NazivMaterijala=" + '"' + "{0}" + '"'
                , naziv);
            command = new SQLiteCommand(all, connection);
            SQLiteDataReader readerKolicina = command.ExecuteReader();
            while (readerKolicina.Read())
            {
                read = readerKolicina.GetInt32(0);
            }
            if ((read + kolicina) < 0)
            {
                MessageBox.Show(Convert.ToString(read + kolicina));
                return false;
            }
            else

                return true;
            
        }

        //////////////////////////////////// statistika
        
        public int Evidencija_C_S(bool TRUE_COUNT_____FALSE_SUM)
        {
            string all="";
            if(TRUE_COUNT_____FALSE_SUM) { all = "select count (ID) from Evidencija"; }
            else if(!TRUE_COUNT_____FALSE_SUM) { all = "SELECT SUM (UtrosenoVrijeme) FROM Evidencija"; }
            int count=0;
            command = new SQLiteCommand(all,connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (!reader.Read().Equals(DBNull.Value))
            {
                while (reader.Read())
                    count = Convert.ToInt32(reader.GetValue(0));
            }
            return count;
            
        }

        public int CijenaMaterijala()
        {
            string potrebno = "select Kolicina, Cijena from Skladiste";
            int cijena=0;
            command = new SQLiteCommand(potrebno, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int kolicina, cijena2;
                if (reader.GetValue(0) == null)
                {
                    kolicina = 0;
                }
                else
                {
                    kolicina = Convert.ToInt32(reader.GetValue(0));
                }
                /////////
                if (Convert.ToString (reader.GetValue(1)) == "")
                {
                    cijena2 = 0;
                }
                else
                {
                    cijena2 = Convert.ToInt32(reader.GetValue(1));
                }
                cijena += kolicina * cijena2;
            }
            return cijena;
        }

        public float Postotak()
        {
            DateTime time = DateTime.Now;
            int mjesec, daniUProslomMjesecu, godina;
            if(time.Month == 1)
            {
                mjesec = 12;
                godina = time.Year -1 ;
                daniUProslomMjesecu = DateTime.DaysInMonth(godina, mjesec);
            }
            else
            {
                mjesec = time.Month - 1;
                godina = time.Year;
                daniUProslomMjesecu = DateTime.DaysInMonth(godina, mjesec);
            }
            
            string all = string.Format("select DISTINCT  date(Datum) from Evidencija  ");

            float count = 0f;
            command = new SQLiteCommand(all, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime novo = reader.GetDateTime(0);
                if(novo.Month == mjesec && novo.Year==godina)
                {
                    count++;
                }
            }
            count = count / daniUProslomMjesecu * 100f;
            return count;
        }

        public SQLiteDataReader GraphReaders(string read)
        {
            
            command = new SQLiteCommand(read, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;

            
        }

    }
}
