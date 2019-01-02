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
    public partial class Statistika : UIController
    {
        public Statistika()
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
                case "Oon":
                    Oon odstupanje_od_normale = new Oon();
                    break;
                case "Bokv":
                    Bokv broj_odrzavanja_kroz_vrijeme = new Bokv();
                    break;
                case "Pmkv":
                    Pmkv potrosnja_materijala_kroz_vrijeme = new Pmkv();
                    break;
                case "Home":
                    Home Home = new Home();
                    break;
            }
            return true;
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
