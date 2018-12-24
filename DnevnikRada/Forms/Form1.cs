using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_evidencija_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: evidencija_trazi
        {
            evidencija_trazi evidencija_trazi = new evidencija_trazi();
            this.Hide();
            evidencija_trazi.Show();

        }

        private void btn_evidencija_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: evidencija_dodaj
        {
            evidencija_dodaj evidencija_dodaj = new evidencija_dodaj();
            this.Hide();
            evidencija_dodaj.Show();
        }

        private void btn_skladiste_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: skladiste_trazi
        {
            skladiste_trazi skladiste_trazi = new skladiste_trazi();
            this.Hide();
            skladiste_trazi.Show();
        }

        private void btn_skladiste_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: skladiste_dodaj
        {
            Skladiste_dodaj skladiste_dodaj = new Skladiste_dodaj();
            this.Hide();
            skladiste_dodaj.Show();
        }

        private void btn_mjesta_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: mjesta_trazi
        {
            mjesta_trazi mjesta_trazi = new mjesta_trazi();
            this.Hide();
            mjesta_trazi.Show();
        }

        private void btn_mjesta_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: mjesta_dodaj
        {
            mjesta_dodaj mjesta_dodaj = new mjesta_dodaj();
            this.Hide();
            mjesta_dodaj.Show();
        }

        private void btn_stanje_poduzeca_Click(object sender, EventArgs e) //kliknem button, otvora formu: stanje_poduzeca
        {
            stanje_poduzeca_2 stanje_poduzeca_2 = new stanje_poduzeca_2();
            this.Hide();
            stanje_poduzeca_2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                            //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                            //..sto se aplikacija u potpunosti zatvori

        {
            Application.Exit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
