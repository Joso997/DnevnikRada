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
    public partial class Mjesta_trazi : UIController
    {
        Mjesta mjesto = new Mjesta();
        DataTable dT = new DataTable();
        Dictionary<string, string> filter_dic;
        public Mjesta_trazi()
        {
            InitializeComponent();
            mjestoGrid.DataSource = mjesto.Ucitaj();
            selectButton = SelectButton;
            mjestoGrid.Columns["id"].Visible = false;
            dT.Columns.Add("Datum", typeof(DateTime)).Unique = true;
            Show();
            SetFilter();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Dodaj":
                    object[] marks;
                    marks = new object[] { metroDateTime1.Text };
                    var rows = dT.Select(string.Format("Datum = '{0}'", metroDateTime1.Text));
                    if (rows.Length == 0)
                        dT.LoadDataRow(marks, true);
                    else
                        MessageBox.Show("Datum već dodan.");
                    kalendarGrid.DataSource = dT;
                    break;
                case "Trazi":
                    string trazi = string.Format(searchText.Text);
                    mjestoGrid.DataSource = mjesto.Ucitaj(filter_dic[Filters.Text], trazi);
                    break;
                case "Edit":
                    kalendarGrid.DataSource = mjesto.Kalendar.Ucitaj();
                    Edit.Enabled = false;
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kalendarGrid.DataSource = mjesto.Kalendar.Ucitaj(Int32.Parse(mjestoGrid.Rows[e.RowIndex].Cells["id"].Value.ToString()), true);
            kalendarGrid.Columns[0].Visible = false;
            kalendarGrid.Columns[1].Visible = false;
        }

        private void SetFilter()
        {
            filter_dic = new Dictionary<string, string>
            {
                {"Naziv Mjesta", "NazivMjesta" },
                {"Adresa", "Adresa" }
            };
            Filters.Items.AddRange(filter_dic.Keys.ToArray());
            Filters.Text = filter_dic.Keys.First();
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }
        protected override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        private void kalendarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dT_kalendar = new DataTable();
            dT_kalendar = mjesto.Kalendar.Ucitaj(Int32.Parse(kalendarGrid.Rows[e.RowIndex].Cells["id"].Value.ToString()));
            metroDateTime1.Value = (DateTime)dT_kalendar.Rows[0].ItemArray[2];
            Edit.Enabled = true;
            
        }
    }
}
