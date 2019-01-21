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
using DnevnikRada.Kontrole;

namespace DnevnikRada
{
    public partial class Home : UIController
    {

        public Home()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            UserKalendar userKalendar = new UserKalendar(this);
            metroUserControl1.Controls.Add(userKalendar);
            userKalendar.Dock = DockStyle.Fill;
            userKalendar.BringToFront();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "EvidencijaTrazi":
                    new evidencija_trazi();
                    break;
                case "EvidencijaDodaj":
                    new Evidencija_dodaj();
                    break;
                case "StanjePoduzeca":
                    new Stanje_Poduzeca();
                    break;
                case "SkladisteTrazi":
                    new skladiste_trazi();
                    break;
                case "SkladisteDodaj":
                    new Skladiste_dodaj();
                    break;
                case "MjestaTrazi":
                    new Mjesta_trazi();
                    break;
                case "MjestaDodaj":
                    new mjesta_dodaj();
                    break;
                case "obavijest_gumb":
                    new Evidencija_dodaj((List<object>)button.Tag);
                    break;
            }
            return true;
        }

        private void MouseEnter_Mouse(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.MidnightBlue;
            if(button.Name == "StanjePoduzeca")
                StanjePoduzeca.Size = new Size(302, 252);
            else
                button.Size = new Size(152, 252);
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

        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }
    }
}
