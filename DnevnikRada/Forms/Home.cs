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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        ~Home()
        {
            MessageBox.Show("BAZA JE OTVORENA! YEY");
        }

        private void btn_evidencija_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: evidencija_trazi
        {
            evidencija_trazi evidencija_trazi = new evidencija_trazi();
            Hide();
            evidencija_trazi.Show();
            Close();

        }

        private void btn_evidencija_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: evidencija_dodaj
        {
            evidencija_dodaj evidencija_dodaj = new evidencija_dodaj();
            Hide();
            evidencija_dodaj.Show();
            Close();
        }

        private void btn_skladiste_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: skladiste_trazi
        {
            skladiste_trazi skladiste_trazi = new skladiste_trazi();
            Hide();
            skladiste_trazi.Show();
            Close();
        }

        private void btn_skladiste_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: skladiste_dodaj
        {
            Skladiste_dodaj skladiste_dodaj = new Skladiste_dodaj();
            Hide();
            skladiste_dodaj.Show();
            Close();
        }

        private void btn_mjesta_trazi_Click(object sender, EventArgs e) //kliknem button, otvora formu: mjesta_trazi
        {
            mjesta_trazi mjesta_trazi = new mjesta_trazi();
            Hide();
            mjesta_trazi.Show();
            Close();
        }

        private void btn_mjesta_dodaj_Click(object sender, EventArgs e) //kliknem button, otvora formu: mjesta_dodaj
        {
            mjesta_dodaj mjesta_dodaj = new mjesta_dodaj();
            Hide();
            mjesta_dodaj.Show();
            Close();
        }

        private void btn_stanje_poduzeca_Click(object sender, EventArgs e) //kliknem button, otvora formu: stanje_poduzeca
        {
            stanje_poduzeca_2 stanje_poduzeca_2 = new stanje_poduzeca_2();
            Hide();
            stanje_poduzeca_2.Show();
            Close();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                            //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                            //..sto se aplikacija u potpunosti zatvori

        {
            //MainForm.MainFormInstance.Close();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
    }
}
