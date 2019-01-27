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
    public partial class PotrosnjaMaterijalaKrozVrijeme : UserControl
    {
        
        public PotrosnjaMaterijalaKrozVrijeme()
        {
            
            InitializeComponent();
            ChartLoad();
        }
        private void ChartLoad()
        {
            Chart.Series.Clear();
            Baza.DB baza = new Baza.DB();
            string createSeries = "select NazivMaterijala from skladiste";
            SQLiteDataReader nazivi = baza.GraphReaders(createSeries);
            DateTime trenutno = DateTime.Now;
            DateTime now = new DateTime(trenutno.Year, trenutno.Month, trenutno.Day);
            int i = 0;
            Chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            while (nazivi.Read())
            {
                int  c=0;
                Chart.Series.Add(nazivi.GetString(0));
                string allData = string.Format ("select kolicina, date(datum),nazivmaterijala from Evidencija join Poveznica on Evidencija.ID=Poveznica.Id_Evidencija and Poveznica.NazivMaterijala="+'"'+"{0}"+'"'+" order by datum", nazivi.GetString(0));
                SQLiteDataReader data = baza.GraphReaders(allData);
                Chart.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                Chart.Series[i].BorderWidth = 5;
                while (data.Read())
                {
                    c = c + data.GetInt32(0);
                    Chart.Series[i].Points.AddXY(data.GetDateTime(1), c);
                }
                Chart.Series[i].Points.AddXY(now, c);
                i++;
            }
        }
    }
}
