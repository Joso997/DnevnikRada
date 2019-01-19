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
                    string trazi = textTrazi.Text;
                    evidencijaGrid.DataSource = evidencija.Ucitaj(filter_dic[Filters.Text], trazi);

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
                {"Utroseno Vrijeme", "UtrosenoVrijeme" }
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
        private void evidencijaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            materijalGrid.DataSource = evidencija.Poveznica.Ucitaj(Int32.Parse(evidencijaGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
            opisPosla.Text = evidencijaGrid.Rows[e.RowIndex].Cells["OpisPosla"].Value.ToString();
            materijalGrid.Columns[0].Visible = false;
            materijalGrid.Columns["Id_Evidencija"].Visible = false;
        }

    }
}
