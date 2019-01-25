using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;
using System.Globalization;

namespace DnevnikRada.Kontrole
{
    public partial class UserKalendar : UserControl
    {
        public Home Home { get; set; }
        Mjesta mjesta = new Mjesta();
        List<DateTime> _tempDate = new List<DateTime>();
        public UserKalendar(Home _home)
        {
            Home = _home;
            InitializeComponent();
            Osvjezi();
            GenerirajObavijesti();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            mjesta.Kalendar.PromjeniDatum(1);
            Osvjezi();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            mjesta.Kalendar.PromjeniDatum(-1);
            Osvjezi();
        }

        void Osvjezi()
        {
            int top = 40;
            int left = 5 + mjesta.Kalendar.GetDayInWeek()*42;
            Mjesec_Godina.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mjesta.Kalendar.Datum.Month) + " " + mjesta.Kalendar.Datum.Year;
            int razmak = mjesta.Kalendar.GetDayInWeek();
            
            DataTable dT = new DataTable();
            dT = mjesta.Ucitaj();
            Console.WriteLine();
            foreach (int i in Enumerable.Range(1, mjesta.Kalendar.GetNumOfDays()))
            {
                MetroFramework.Controls.MetroLabel label = new MetroFramework.Controls.MetroLabel
                {
                    Location = new Point(left, top),
                    Margin = new Padding(5, 8, 7, 0),
                    Name = "day" + i.ToString(),
                    Size = new Size(30, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = i.ToString(),
                    Visible = true
                };
                if (mjesta.Kalendar.Datum.Date == DateTime.Now.Date && i == DateTime.Today.Day)
                {
                    label.UseCustomBackColor = true;
                    label.FontWeight = (MetroFramework.MetroLabelWeight)FontStyle.Bold;
                    label.BackColor = Color.Red;
                }
                this.Controls.Add(label);
                left += label.Width + label.Margin.Left+ label.Margin.Right;
                if (razmak == 6)
                {
                    top += label.Height + label.Margin.Top;
                    left = 5;
                    razmak = 0;
                }
                else
                    razmak++;
            }
            GetEvents(mjesta.Kalendar.Mjesec_Godina("-"));
            //this.Controls.AddRange(lista.ToArray());
        }

        private void OcistiKalendar()
        {
            foreach (int i in Enumerable.Range(1, mjesta.Kalendar.GetNumOfDays()))
            {
                this.Controls.RemoveByKey("day" + i.ToString());
            }
            foreach(var list in _tempDate)
            {
                metroEvents.Controls.RemoveByKey(list.ToShortDateString());
            }
        }

        private void GetEvents(string _datum)
        {
            int top = 0;
            int left = 0;
            Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                {"Datum", new DateTime(mjesta.Kalendar.Datum.Year, mjesta.Kalendar.Datum.Month, DateTime.Today.Day).ToString("yyyy-MM-dd HH:mm:ss") },
                {"Datum"+ " ", new DateTime(mjesta.Kalendar.Datum.Year, mjesta.Kalendar.Datum.Month, 1).AddMonths(1).ToString("yyyy-MM-dd HH:mm:ss") }
            };
            List<string> _operator = new List<string> {
                {">"},
                {"<"}
            };
            DataTable dT_datum = mjesta.Kalendar.Ucitaj(biblioteka, _operator);
            _tempDate = dT_datum.AsEnumerable().Select(r => r.Field<DateTime>("Datum")).ToList();
            foreach (var list in _tempDate)
            {
                MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile
                {
                    Location = new Point(left, top),
                    Margin = new Padding(1, 1, 1, 1),
                    Name = list.ToShortDateString(),
                    Size = new Size(285, 32),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = mjesta.Ucitaj(int.Parse(dT_datum.Rows[_tempDate.IndexOf(list)]["Id_Mjesta"].ToString())).Rows[0]["NazivMjesta"] + " " + list.ToShortDateString(),
                    TileTextFontSize = MetroFramework.MetroTileTextSize.Small,
                    Visible = true,
                    Enabled = false
                };
                metroEvents.Controls.Add(tile);
                tile.BringToFront();
                top += tile.Height + tile.Margin.Top;
            }
        }

        private void GenerirajObavijesti()
        {
            Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                {"Datum", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
            };
            List<string> _operator = new List<string> {
                {"<="}
            };
            DataTable dT_query = mjesta.Kalendar.Ucitaj(biblioteka, _operator);
            if(dT_query != null)
            {
                int top = 0;
                int left = 0;
                List<string> _operator_query = new List<string>{
                    {"like"},
                    {"="}
                };
                foreach (int _query in Enumerable.Range(0, dT_query.Rows.Count))
                {
                    DateTime _date = (DateTime)dT_query.Rows[_query]["Datum"];
                    List<object> tag = new List<object>
                    {
                        {_date },
                        {mjesta.Ucitaj(int.Parse(dT_query.Rows[_query]["Id_Mjesta"].ToString())).Rows[0]["NazivMjesta"] }
                    };
                    Dictionary<string, object> biblioteka_query = new Dictionary<string, object>
                    {
                        {"Datum", "%"+_date.ToString("yyyy-MM-dd")+"%" },
                        {"Id_Mjesta", dT_query.Rows[_query]["Id_Mjesta"] }
                    };
                    if(new Evidencija().Ucitaj(biblioteka_query, _operator_query).Rows.Count <= 0){
                        MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile
                        {
                            Location = new Point(left, top),
                            Margin = new Padding(1, 1, 1, 1),
                            Name = "obavijest_gumb",
                            Size = new Size(285, 32),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Text = mjesta.Ucitaj(int.Parse(dT_query.Rows[_query]["Id_Mjesta"].ToString())).Rows[0]["NazivMjesta"] + " " + _date.ToShortDateString(),
                            TileTextFontSize = MetroFramework.MetroTileTextSize.Small,
                            Visible = true,
                            Tag = tag
                        };
                        metroObavijesti.Controls.Add(tile);
                        tile.Click += new System.EventHandler(Home.Click_Gumb);
                        tile.BringToFront();
                        top += tile.Height + tile.Margin.Top;
                    }
                }
            }
        }
    }
}
