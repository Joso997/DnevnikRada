using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DnevnikRada
{
    public partial class ucModule3 : UserControl
    {
        Baza.DB baza = new Baza.DB();
        public ucModule3()
        {
            InitializeComponent();
            ChartLoad();
        }

        public void ChartLoad()
        {
            int i = 0;
            string SveEvidencije = "select DISTINCT  date(Datum) from Evidencija";
            SQLiteDataReader data = baza.GraphReaders(SveEvidencije);
            //Chart.Series[0].BorderWidth = 5;
            Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            while (data.Read())
            {
                DateTime date = data.GetDateTime(0);
                string brojZaOdređeniDatum = string.Format("select count (ID) from Evidencija where date(datum)=" + '"' + "{0}" + '"',data.GetString(0));
                
                MessageBox.Show(Convert.ToString(brojZaOdređeniDatum+"    "+ i));
                SQLiteDataReader count = baza.GraphReaders(brojZaOdređeniDatum);
                while (count.Read())
                {
                    i = Convert.ToInt32( count.GetValue(0));
                }
                Chart.Series[0].Points.AddXY(data.GetDateTime(0), i);
            }
            
        }
    }
}
