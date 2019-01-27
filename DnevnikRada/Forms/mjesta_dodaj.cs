using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class mjesta_dodaj : UIController
    {
        DataTable dT_Kalendar = new DataTable();
        public mjesta_dodaj()
        {
            Ucitaj();
            ID = -1;
            Osvjezi();
        }

        public mjesta_dodaj(DataTable _temp)
        {
            Ucitaj();
            tb_naziv_mjesta.Text = _temp.Rows[0]["NazivMjesta"].ToString();
            tb_adresa.Text = _temp.Rows[0]["Adresa"].ToString();
            ID = int.Parse(_temp.Rows[0]["ID"].ToString());
            Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                {"Id_Mjesta", ID }
            };
            dT_Kalendar = new Kalendar().Ucitaj(biblioteka, new List<string> { { "=" } });
            foreach (var r in dT_Kalendar.AsEnumerable())
                dT.Rows.Add(new Object[] { r.Field<Int64>("Sifra"), r.Field<DateTime>("Datum"), r.Field<Boolean>("Sakriveno") });
            Osvjezi();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Dodaj":
                    object[] marks;
                    marks = new object[] { 0, metroDateTime1.Text, false };
                    var rows = dT.Select(string.Format("Datum = '{0}'", metroDateTime1.Text));
                    if (rows.Length == 0)
                        dT.LoadDataRow(marks, true);
                    else
                        MessageBox.Show("Datum već dodan.");
                    Osvjezi();
                    break;
                case "Oduzmi":
                    if (int.Parse(dT.Rows[row]["Sifra"].ToString()) > 1000)
                        new Kalendar(int.Parse(dT.Rows[row]["Sifra"].ToString()), new List<DateTime> { { (DateTime)dT.Rows[row]["Datum"] } }, true);
                    Oduzmi.Enabled = false;
                    dT.Rows.RemoveAt(row);
                    Osvjezi();
                    break;
                case "Potvrdi":
                    if (CheckInput(new Dictionary<string, string> { { "Adresa", tb_adresa.Text }, { "Naziv Mjesta", tb_naziv_mjesta.Text } }))
                        break;
                    var n_temp = dT.AsEnumerable().Where(r => r.Field<int>("Sifra") == 0).Select(r => r.Field<DateTime>("Datum")).ToList();
                    if (!n_temp.Any())
                        new Mjesta(tb_naziv_mjesta.Text, tb_adresa.Text, false);
                    else
                        new Mjesta(ID, tb_naziv_mjesta.Text, tb_adresa.Text, n_temp, false);
                    dT.Clear();
                    Osvjezi();
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        void Ucitaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            dT.Columns.Add("Sifra", typeof(Int32));
            dT.Columns.Add("Datum", typeof(DateTime)).Unique = true;
            dT.Columns.Add("Sakriveno", typeof(Boolean)).DefaultValue = false;
            metroDateTime1.MinDate = DateTime.Now.Date.AddDays(1);
        }

        void Osvjezi()
        {
            kalendarGrid.DataSource = dT;
            kalendarGrid.Columns["Sifra"].Visible = false;
            kalendarGrid.Columns["Sakriveno"].Visible = false;
            Oduzmi.Enabled = false;
        }

        
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        private void kalendarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            Oduzmi.Enabled = true;
        }
    }
}
