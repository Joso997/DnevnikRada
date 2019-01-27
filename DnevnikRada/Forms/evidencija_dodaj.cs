using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;
using MetroFramework.Controls;

namespace DnevnikRada
{
    public partial class Evidencija_dodaj : UIController
    {
        Baza.DB baza = new Baza.DB();
        public Evidencija_dodaj()
        {
            Ucitaj();
        }

        public Evidencija_dodaj(List<object> tag)
        {
            Ucitaj();
            metroDateTime1.Value = (DateTime)tag[0];
            NazivMjesta.Text = (string)tag[1];
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Dodaj":
                    if(CheckInput(new Dictionary<string, string> { { "Kolicina", Kolicina.Text },{ "Materijal", OdabirMaterijala.Text },{ "Operator(+ ili -)", addUse.Text } }))
                        break;
                    object[] marks;
                    if (addUse.Text == "-")
                    {

                        if (baza.ProvjeraPrijasnjihDatuma(OdabirMaterijala.Text, metroDateTime1.Value, Convert.ToInt32(Kolicina.Text)))
                        {
                            break;
                        }

                        if (baza.ProvjeraNegativnosti(OdabirMaterijala.Text, int.Parse(Kolicina.Text) * -1) == false)
                        {
                            MessageBox.Show("broj -" + Kolicina.Text + " je pre negativan nema dosta u skladistu");
                            break;
                        }
                        marks = new object[] { OdabirMaterijala.Text, int.Parse(Kolicina.Text) * -1 };  
                    }
                    else
                        marks = new object[] { OdabirMaterijala.Text, int.Parse(Kolicina.Text)  }; 
                    var rows = dT.Select(string.Format("NazivMaterijala = '{0}'", OdabirMaterijala.Text));
                    if(rows.Length == 0)
                        dT.LoadDataRow(marks, true);
                    else 
                        rows[0]["Kolicina"] = int.Parse(Kolicina.Text);
                    Osvjezi();
                    break;
                case "Oduzmi":
                    dT.Rows.RemoveAt(row);
                    Osvjezi();
                    break;
                case "Potvrdi":
                    if(CheckInput(new Dictionary<string, string> { { "Opis Posla", tb_opis_posla.Text }, {"Utrošeno Vrijeme", tb_utroseno_vrijeme.Text } }))
                        break;
                    var n_temp = dT.AsEnumerable().Select(r => r.Field<string>(0)).ToList();
                    var _temp = dT.AsEnumerable().Select(r => r.Field<Int32>(1)).ToList();
                    Dictionary<string, int> informacije = n_temp.Zip(_temp, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
                    Evidencija evidencija = new Evidencija(NazivMjesta.Text, metroDateTime1.Value, tb_opis_posla.Text, int.Parse(tb_utroseno_vrijeme.Text), informacije, false);
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
            Fill();
            dT.Columns.Add("NazivMaterijala").Unique = true;
            dT.Columns.Add("Kolicina", typeof(Int32));
            metroDateTime1.MaxDate = DateTime.Now.Date;
        }

        void Osvjezi()
        {
            materijalGrid.DataSource = dT;
            Oduzmi.Enabled = false;
        }

        
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }

        void Fill()
        {
            Dictionary<string, object> biblioteka_skladiste = new Dictionary<string, object>{
                {"NazivMaterijala", "%%" }
            };
            Dictionary<string, object> biblioteka_mjesta = new Dictionary<string, object>{
                {"NazivMjesta", "%%" }
            };
            List<string> _operator = new List<string> {
                {"like"}
            };
            OdabirMaterijala.Items.AddRange(new Skladiste().Ucitaj(biblioteka_skladiste, _operator).AsEnumerable().Select(r => r.Field<string>("NazivMaterijala")).ToArray());
            NazivMjesta.Items.AddRange(new Mjesta().Ucitaj(biblioteka_mjesta, _operator).AsEnumerable().Select(r => r.Field<string>("NazivMjesta")).ToArray());
            addUse.Items.Add("+");
            addUse.Items.Add("-");
        }

        private void evidencijaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OdabirMaterijala.Text = materijalGrid.Rows[e.RowIndex].Cells["NazivMaterijala"].Value.ToString();
            Kolicina.Text = materijalGrid.Rows[e.RowIndex].Cells["Kolicina"].Value.ToString();
            row = e.RowIndex;
            Oduzmi.Enabled = true;
        }

        private void tb_utroseno_vrijeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
