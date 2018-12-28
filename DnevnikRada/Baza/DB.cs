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
        public SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataAdapter db;
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();

        //OTVARA KONEKCIJU PREMA BAZI
        public DB()
        {
            
            connection = new SQLiteConnection("Data Source = DB.db");

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                //MessageBox.Show("BAZA JE OTVORENA! YEY");
            }else MessageBox.Show("Error 404 NIGGA NOT FOUND");

        }

        //kod za izvođenje pod bazoom BILO KOJI al mora bit sql
        public void Query(string sqlCode)
        {
            command = connection.CreateCommand();
            command.CommandText = sqlCode;
            MessageBox.Show(sqlCode);
            command.ExecuteNonQuery();
            
        }

        //loudanje baze u formsima tj u tablici i vraca tu tablicu za grid view
        public DataTable LoadDataBase(string load)
        {
            command = connection.CreateCommand();
            db = new SQLiteDataAdapter(load, connection);
            ds.Reset();
            db.Fill(ds);
            table = ds.Tables[0]; 
            return table;
        }
    }
}
