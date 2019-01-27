using System;
using System.Data;
using System.Windows.Forms;
using DnevnikRada.Klase;
using System.Collections.Generic;
using System.Linq;

namespace DnevnikRada
{
    public partial class skladiste_trazi : UIController
    {
        Skladiste skladiste = new Skladiste();
        public skladiste_trazi()
        {          
            InitializeComponent();
            skladisteGrid.DataSource = skladiste.Ucitaj();
            selectButton = SelectButton;
            skladisteGrid.Columns["id"].Visible = false;
            Show();
            SetFilter();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                        {filter_dic[Filters.Text], "%"+Search.Text+"%" }
                    };
                    skladisteGrid.DataSource = skladiste.Ucitaj(biblioteka, new List<string> { { "like" } });
                    break;
                case "Edit":
                    if (CheckInput(new Dictionary<string, string> { { kolicinaBox.Name, kolicinaBox.Text }, { nazivBox.Name, nazivBox.Text } }))
                        break;
                    new Skladiste(nazivBox.Text, prodavacBox.Text, mjBox.Text, Int32.Parse(cijenaBox.Text), false);
                    Osvjezi();
                    break;
                case "Sakri":
                    new Skladiste(nazivBox.Text, prodavacBox.Text, mjBox.Text, Int32.Parse(cijenaBox.Text), true);
                    Osvjezi();
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dT = new DataTable();
            dT = skladiste.Ucitaj(Int32.Parse(skladisteGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            nazivBox.Text = dT.Rows[0].ItemArray[1].ToString();
            prodavacBox.Text = dT.Rows[0].ItemArray[2].ToString();
            kolicinaBox.Text = dT.Rows[0].ItemArray[3].ToString();
            mjBox.Text = dT.Rows[0].ItemArray[4].ToString();
            cijenaBox.Text = dT.Rows[0].ItemArray[5].ToString();
            Sakri.Enabled = true;
            Edit.Enabled = true;
        }

        private void SetFilter()
        {
            filter_dic = new Dictionary<string, string>
            {
                {"Naziv Materijala", "NazivMaterijala" },
                {"Prodavac", "Prodavac" },
                {"Mjerna Jedinica", "MjernaJedinica" },
                {"Kolicina", "Kolicina" }
            };
            Filters.Items.AddRange(filter_dic.Keys.ToArray());
            Filters.Text = filter_dic.Keys.First();
        }

        void Osvjezi()
        {
            skladisteGrid.DataSource = skladiste.Ucitaj();
            Sakri.Enabled = false;
            Edit.Enabled = false;
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        private void kolicinaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cijenaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
