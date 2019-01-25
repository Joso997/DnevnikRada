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
    public partial class ucModule2 : UserControl
    {
        
        public ucModule2()
        {
            
            InitializeComponent();
            ChartLoad();
        }
        public void ChartLoad()
        {
            Chart.Series.Clear();
            Baza.DB baza = new Baza.DB();
            string createSeries = "select NazivMaterijala from skladiste";
            SQLiteDataReader nazivi = baza.GraphReaders(createSeries);
            DateTime date = new DateTime(2018, 12, 01);
            
            int datum = Convert.ToInt32( DateTime.Now.Day.ToString());
            int year = Convert.ToInt32(DateTime.Now.Year.ToString());
            int mjesec = Convert.ToInt32(DateTime.Now.Month.ToString());
            DateTime now = new DateTime(year, mjesec, datum);
            var date2 = date;
            int i = 0;
            Chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            while (nazivi.Read())
            {
                int  c=0;
                Chart.Series.Add(nazivi.GetString(0));
                string allData = string.Format ("select kolicina, date(datum),nazivmaterijala from Evidencija join Poveznica on Evidencija.ID=Poveznica.Id_Evidencija and Poveznica.NazivMaterijala="+'"'+"{0}"+'"', nazivi.GetString(0));
                //MessageBox.Show(allData);
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
                #region nebitno
                /*
                data.Read();
                while (date2 <= now)
                {
                    
                    if (DateTime.Compare(data.GetDateTime(1),date2)==0)
                    {
                        c = data.GetInt32(0) + c;
                        Chart.Series[i].Points.AddY(c);
                        while (data.Read())
                        {
                            if (DateTime.Compare(data.GetDateTime(1), date2) != 0)
                            {
                                continue;
                            }
                            

                        }
                    }
                    date2=date2.AddDays(1);
                }
                */
                #endregion
            }
        }
    }
}
