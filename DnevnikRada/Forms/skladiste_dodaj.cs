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
                    if (CheckInput(new Dictionary<string, string> {{ "Naziv Materijala", tb_naziv_materijala.Text } }))
                        break;
                    Skladiste skladiste = new Skladiste(tb_naziv_materijala.Text, tb_proizvodac.Text, tb_mjerna_jedinica.Text, Convert.ToInt32 (tb_Cijena.Text), false);

                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

       
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
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

        private void tb_Cijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
