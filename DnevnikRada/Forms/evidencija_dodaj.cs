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
    public partial class evidencija_dodaj : UIController
    {
        private bool UserClosing { get; set; }
        public evidencija_dodaj()
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
                    Evidencija evidencija = new Evidencija(tb_naziv_mjesta.Text, DateTime.Now, "", int.Parse(tb_utroseno_vrijeme.Text), 10f);
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

        private void evidencija_dodaj_Load(object sender, EventArgs e)
        {

        }

        void Fill()
        {
            EVTrazi_TEST_ moj3 = new EVTrazi_TEST_(null);
            List<string> moj2 = new List<string>();
            
            moj2 = moj3.Radil();
            int f = 0;
            foreach (var s in moj2)
            {
                metroComboBox1.Items.Add(moj2[f]);
                metroComboBox2.Items.Add(moj2[f]);
                metroComboBox3.Items.Add(moj2[f]);
                metroComboBox4.Items.Add(moj2[f]);
                f++;
            }
        }
    }
}
