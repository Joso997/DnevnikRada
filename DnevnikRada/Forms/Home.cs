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

namespace DnevnikRada
{
    public partial class Home : Form, IFormReq
    {
        private bool UserClosing { get; set; }
        public Home()
        {
            InitializeComponent();
            Show();
        }

        public void Click_Gumb(object sender, EventArgs e)
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
            Unload();
        }

        public void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (!UserClosing)
                    Application.Exit();
        }

        public void Unload()
        {
            Hide();
            UserClosing = true;
            Close();
        }
    }
}
