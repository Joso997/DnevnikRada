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
    public partial class evidencija_trazi : UIController
    {
        Evidencija evidencija = new Evidencija();
        Dictionary<string, string> filter_dic;
        private int row;
        public evidencija_trazi()
        {
            InitializeComponent();
            evidencijaGrid.DataSource = evidencija.Ucitaj();
            evidencijaGrid.Columns["id"].Visible = false;
            evidencijaGrid.Columns["opisposla"].Visible = false;
            selectButton = SelectButton;
            Show();
            SetFilter();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    string trazi = Search.Text;
                    Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                        {filter_dic[Filters.Text], "%"+Search.Text+"%" }
                    };
                    evidencijaGrid.DataSource = evidencija.Ucitaj(biblioteka, new List<string> { { "like" } });
                    break;
                case "Sakri":
                    DataTable dT = new DataTable();
                    dT = evidencija.Ucitaj(Int32.Parse(evidencijaGrid.Rows[row].Cells["Id"].Value.ToString()));
                    new Evidencija(dT.Rows[0].ItemArray[1].ToString(), (DateTime)dT.Rows[0].ItemArray[2], dT.Rows[0].ItemArray[3].ToString(), int.Parse(dT.Rows[0].ItemArray[4].ToString()), new List<string>(), new List<int>(), true);
                    Osvjezi();
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        private void SetFilter()
        {
            filter_dic = new Dictionary<string, string>
            {
                {"Naziv Mjesta", "NazivMjesta" },
                {"Opis Posla", "OpisPosla" },
                {"Datum", "Datum" },
                {"Utroseno Vrijeme", "UtrosenoVrijeme" }
            };
            Filters.Items.AddRange(filter_dic.Keys.ToArray());
            Filters.Text = filter_dic.Keys.First();
        }

        void Osvjezi() {
            evidencijaGrid.DataSource = evidencija.Ucitaj();
            materijalGrid.DataSource = null;
            Sakri.Enabled = false;
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }
        private void evidencijaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                {"Id_Evidencija", Int32.Parse(evidencijaGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString()) }
            };
            materijalGrid.DataSource = evidencija.Poveznica.Ucitaj(biblioteka, new List<string> { { "=" } });
            opisPosla.Text = evidencijaGrid.Rows[e.RowIndex].Cells["OpisPosla"].Value.ToString();
            materijalGrid.Columns[0].Visible = false;
            materijalGrid.Columns["Id_Evidencija"].Visible = false;
            row = e.RowIndex;
            Sakri.Enabled = true;
        }
    }
}
