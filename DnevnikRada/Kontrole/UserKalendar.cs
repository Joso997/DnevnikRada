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
        Kalendar kalendar = new Kalendar();
        List<DateTime> _tempDate = new List<DateTime>();
        //List<MetroFramework.Controls.MetroLabel> lista = new List<MetroFramework.Controls.MetroLabel>();
        public UserKalendar()
        {
            InitializeComponent();
            Osvjezi();   
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            kalendar.PromjeniDatum(1);
            Osvjezi();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            kalendar.PromjeniDatum(-1);
            Osvjezi();
        }

        void Osvjezi()
        {
            int top = 40;
            int left = 5 + kalendar.GetDayInWeek()*42;
            Mjesec_Godina.Text = kalendar.Mjesec_Godina(" ", false);
            int razmak = kalendar.GetDayInWeek();
            Mjesta mjesta = new Mjesta();
            DataTable dT = new DataTable();
            dT = mjesta.Ucitaj();
            for (int i = 1; i <= kalendar.GetNumOfDays(); i++)
            {
                MetroFramework.Controls.MetroLabel label = new MetroFramework.Controls.MetroLabel
                {
                    Location = new Point(left, top),
                    Margin = new Padding(5, 10, 7, 0),
                    Name = "day" + i.ToString(),
                    Size = new Size(30, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = i.ToString(),
                    Visible = true
                };
                if (CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.Year == kalendar.Mjesec_Godina(" ", false) && i == DateTime.Today.Day)
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
            GetEvents(kalendar.Mjesec_Godina("-"));
            //this.Controls.AddRange(lista.ToArray());
        }

        private void OcistiKalendar()
        {
            for (int i = 1; i <= kalendar.GetNumOfDays(); i++)
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
            DataTable dT_datum = kalendar.Ucitaj("Datum", _datum);
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
                    Text = list.ToShortDateString(),
                    TileTextFontSize = MetroFramework.MetroTileTextSize.Small,
                    Visible = true
                };
                metroEvents.Controls.Add(tile);
                //tile.Dock = DockStyle.Fill;
                tile.BringToFront();
                top += tile.Height + tile.Margin.Top;
            }
        }
    }
}
