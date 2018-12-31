using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Interface;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class Home : UIController//, //IFormReq
    {

        public Home()
        {
            InitializeComponent();
            Show();
            selectButton = new SelectButtonDelagate(SelectButton);
        }

        public void SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "EvidencijaTrazi":
                    evidencija_trazi et = new evidencija_trazi();
                    break;
                case "EvidencijaDodaj":
                    evidencija_dodaj ed = new evidencija_dodaj();
                    break;
                case "StanjePoduzeca":
                    StanjePoduzeca sp = new StanjePoduzeca();
                    break;
                case "SkladisteTrazi":
                    skladiste_trazi st = new skladiste_trazi();
                    break;
                case "SkladisteDodaj":
                    Skladiste_dodaj sd = new Skladiste_dodaj();
                    break;
                case "MjestaTrazi":
                    mjesta_trazi mt = new mjesta_trazi();
                    break;
                case "MjestaDodaj":
                    mjesta_dodaj md = new mjesta_dodaj();
                    break;
            }
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
    }
}
