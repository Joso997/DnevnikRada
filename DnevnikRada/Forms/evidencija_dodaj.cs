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
            DataSet ds = new DataSet();
            moj2 = moj3.Radil("NazivMaterijala", "Skladiste");
            int f = 0;
            foreach (var s in moj2)
            {
                metroComboBox1.Items.Add(moj2[f]);
                metroComboBox2.Items.Add(moj2[f]);
                metroComboBox3.Items.Add(moj2[f]);
                metroComboBox4.Items.Add(moj2[f]);
                f++;
                
            }
            /*Mjesta mj = new Mjesta();
            List<string> mj2 = new List<string>();
            mj2 = mj.Radil("NazivMjesta", "Mjesta");
            
            
            f = 0;
            foreach (var c in mj2)
            {
                tb_naziv_mjesta.Items.Add(mj2[f]);
                f++;
            }*/
            metroComboBox5.Items.Add("+");
            metroComboBox6.Items.Add("+");
            metroComboBox7.Items.Add("+");
            metroComboBox8.Items.Add("+");
            metroComboBox5.Items.Add("-");
            metroComboBox6.Items.Add("-");
            metroComboBox7.Items.Add("-");
            metroComboBox8.Items.Add("-");


        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
