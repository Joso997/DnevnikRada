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

namespace DnevnikRada
{
    public partial class Evidencija_dodaj : UIController
    {
        private bool UserClosing { get; set; }
        public Evidencija_dodaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            Fill();
        }
        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Potvrdi":
                    List<string> materijal_list = new List<string>();
                    List<int> kolicina_list = new List<int>();
                    materijal_list.Add(metroComboBox1.Text);
                    kolicina_list.Add(int.Parse(metroTextBox1.Text));
                    Evidencija evidencija = new Evidencija(metroComboBox9.Text, DateTime.Now, tb_opis_posla.Text, int.Parse(tb_utroseno_vrijeme.Text), 10f, materijal_list, kolicina_list);
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }
        protected override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        void Fill()
        {
            Skladiste skladiste = new Skladiste();
            DataTable dT_skladiste = new DataTable();
            dT_skladiste = skladiste.Ucitaj("NazivMaterijala", "");
            var _temp = dT_skladiste.AsEnumerable().Select(r => r.Field<string>("NazivMaterijala")).ToArray();
            metroComboBox1.Items.AddRange(_temp);
            metroComboBox2.Items.AddRange(_temp);
            metroComboBox3.Items.AddRange(_temp);
            metroComboBox4.Items.AddRange(_temp);
            Mjesta mjesta = new Mjesta();
            DataTable dT_mjesta = new DataTable();
            dT_mjesta = mjesta.Ucitaj("Naziv_AdresaMjesta", "");
            metroComboBox9.Items.AddRange(dT_mjesta.AsEnumerable().Select(r => r.Field<string>("Naziv_AdresaMjesta")).ToArray());
            metroComboBox5.Items.Add("+");
            metroComboBox6.Items.Add("+");
            metroComboBox7.Items.Add("+");
            metroComboBox8.Items.Add("+");
            metroComboBox5.Items.Add("-");
            metroComboBox6.Items.Add("-");
            metroComboBox7.Items.Add("-");
            metroComboBox8.Items.Add("-");


        }
    }
}
