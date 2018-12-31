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

            DialogResult Result = MessageBox.Show("An error has occurred in the program during closing the " +
                "application. The program can't close because d3dx7_46.dll is missing from your computer. " +
                "Try reinstalling windows to fix this problem. Please contact sandi for more information. " +
                "Error code: 0x80068c01. Do you really want to restart your computer now ?", 
                "Error Closing Application", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void Unload()
        {
            Hide();
            UserClosing = true;
            Close();
        }

        private void EvidencijaTrazi_MouseEnter(object sender, EventArgs e) //od tu pa jos 13 odjeljaka isto
                                                                            //pokazivac iznad buttona, button se poveca i mjenja boju
        {
            EvidencijaTrazi.BackColor = Color.MidnightBlue;
            EvidencijaTrazi.Size = new Size(155, 255);
        }

        private void EvidencijaTrazi_MouseLeave(object sender, EventArgs e)
        {
            EvidencijaTrazi.BackColor = Color.RoyalBlue;
            EvidencijaTrazi.Size = new Size(150, 250);
        }

        private void EvidencijaDodaj_MouseEnter(object sender, EventArgs e)
        {
            EvidencijaDodaj.BackColor = Color.MidnightBlue;
            EvidencijaDodaj.Size = new Size(155, 255);
        }

        private void EvidencijaDodaj_MouseLeave(object sender, EventArgs e)
        {
            EvidencijaDodaj.BackColor = Color.RoyalBlue;
            EvidencijaDodaj.Size = new Size(150, 250);
        }

        private void StanjePoduzeca_MouseEnter(object sender, EventArgs e)
        {
            StanjePoduzeca.BackColor = Color.MidnightBlue;
            StanjePoduzeca.Size = new Size(305, 255);
        }

        private void StanjePoduzeca_MouseLeave(object sender, EventArgs e)
        {
            StanjePoduzeca.BackColor = Color.RoyalBlue;
            StanjePoduzeca.Size = new Size(300, 250);
        }

        private void SkladisteTrazi_MouseEnter(object sender, EventArgs e)
        {
            SkladisteTrazi.BackColor = Color.MidnightBlue;
            SkladisteTrazi.Size = new Size(155, 255);
        }

        private void SkladisteTrazi_MouseLeave(object sender, EventArgs e)
        {
            SkladisteTrazi.BackColor = Color.RoyalBlue;
            SkladisteTrazi.Size = new Size(150, 250);
        }

        private void SkladisteDodaj_MouseEnter(object sender, EventArgs e)
        {
            SkladisteDodaj.BackColor = Color.MidnightBlue;
            SkladisteDodaj.Size = new Size(155, 255);
        }

        private void SkladisteDodaj_MouseLeave(object sender, EventArgs e)
        {
            SkladisteDodaj.BackColor = Color.RoyalBlue;
            SkladisteDodaj.Size = new Size(150, 250);
        }

        private void MjestaTrazi_MouseEnter(object sender, EventArgs e)
        {
            MjestaTrazi.BackColor = Color.MidnightBlue;
            MjestaTrazi.Size = new Size(155, 255);
        }

        private void MjestaTrazi_MouseLeave(object sender, EventArgs e)
        {
            MjestaTrazi.BackColor = Color.RoyalBlue;
            MjestaTrazi.Size = new Size(150, 250);
        }

        private void MjestaDodaj_MouseEnter(object sender, EventArgs e)
        {
            MjestaDodaj.BackColor = Color.MidnightBlue;
            MjestaDodaj.Size = new Size(155, 255);
        }

        private void MjestaDodaj_MouseLeave(object sender, EventArgs e)
        {
            MjestaDodaj.BackColor = Color.RoyalBlue;
            MjestaDodaj.Size = new Size(150, 250);
        }

       
    }
}
