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

namespace DnevnikRada.Forms
{
    public partial class Stanje_Poduzeca : UIController
    {
        public Stanje_Poduzeca()
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
                case "St":
                    Statistika statistika = new Statistika();
                    statistika.MdiParent = this;
                    break;
                case "Oon":
                    Oon odstupanje_od_normale = new Oon();
                    odstupanje_od_normale.MdiParent = this;
                    break;
                case "Bokv":
                    Bokv broj_odrzavanja_kroz_vrijeme = new Bokv();
                    broj_odrzavanja_kroz_vrijeme.MdiParent = this;
                    break;
                case "Pmkv":
                    Pmkv potrosnja_materijala_kroz_vrijeme = new Pmkv();
                    potrosnja_materijala_kroz_vrijeme.MdiParent = this;
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
    }
}
