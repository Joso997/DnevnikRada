using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Forms;
using DnevnikRada.Interface;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class Home : UIController
    {

        public Home()
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
                case "EvidencijaTrazi":
                    evidencija_trazi et = new evidencija_trazi();
                    break;
                case "EvidencijaDodaj":
                    Evidencija_dodaj ed = new Evidencija_dodaj();
                    break;
                case "StanjePoduzeca":
                    Stanje_Poduzeca sp = new Stanje_Poduzeca();
                    break;
                case "SkladisteTrazi":
                    skladiste_trazi st = new skladiste_trazi();
                    break;
                case "SkladisteDodaj":
                    Skladiste_dodaj sd = new Skladiste_dodaj();
                    break;
                case "MjestaTrazi":
                    Mjesta_trazi mt = new Mjesta_trazi();
                    break;
                case "MjestaDodaj":
                    mjesta_dodaj md = new mjesta_dodaj();
                    break;
            }
            return true;
        }

        private void MouseEnter_Mouse(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.MidnightBlue;
            if(button.Name == "StanjePoduzeca")
                StanjePoduzeca.Size = new Size(305, 255);
            else
                button.Size = new Size(155, 255);
        }

        private void MouseLeave_Mouse(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.RoyalBlue;
            if (button.Name == "StanjePoduzeca")
                StanjePoduzeca.Size = new Size(300, 250);
            else
                button.Size = new Size(150, 250);
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }

        protected override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        private void kalendar_DropDown(object sender, EventArgs e)
        {
            Mjesta mjesta = new Mjesta();
            DataTable dT = mjesta.Ucitaj();
        }
    }
}
