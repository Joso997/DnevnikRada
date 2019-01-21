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
    public partial class Skladiste_dodaj : UIController
    {
        public Skladiste_dodaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Potvrdi":
                    if(tb_kolicina.Text=="" || tb_naziv_materijala.Text=="")
                    {
                        MessageBox.Show("Kolicina i naziv materijala ne mogu biti prazni");
                        break;
                    }
                    int kol;
                    string lol = tb_kolicina.Text.ToString();
                    kol = Int32.Parse(lol);
                    Skladiste skladiste = new Skladiste(tb_naziv_materijala.Text, tb_proizvodac.Text, tb_mjerna_jedinica.Text, kol, Convert.ToInt32 (tb_Cijena.Text));
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
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_kolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Skladiste_dodaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
