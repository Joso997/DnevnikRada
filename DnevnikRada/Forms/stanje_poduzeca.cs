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
            Stanje ucModule1 = new Stanje();
            metroPanel1.Controls.Add(ucModule1);
            ucModule1.Dock = DockStyle.Fill;
            ucModule1.BringToFront();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "btnStanjePoduzeca":
                    Stanje ucModule1 = new Stanje();
                    metroPanel1.Controls.Add(ucModule1);
                    ucModule1.Dock = DockStyle.Fill;
                    ucModule1.BringToFront();
                    break;
                case "btnPotrosnjaMaterijalaKrozVrijeme":
                    PotrosnjaMaterijalaKrozVrijeme ucModule2 = new PotrosnjaMaterijalaKrozVrijeme();
                    metroPanel1.Controls.Add(ucModule2);
                    ucModule2.Dock = DockStyle.Fill;
                    ucModule2.BringToFront();
                    break;
                case "btnBrojOdrzavanjaKrozVrijeme":
                    BrojOdrzavanjaKrozVrijeme ucModule3 = new BrojOdrzavanjaKrozVrijeme();
                    metroPanel1.Controls.Add(ucModule3);
                    ucModule3.Dock = DockStyle.Fill;
                    ucModule3.BringToFront();
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
    }
}
