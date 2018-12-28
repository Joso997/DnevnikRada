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
    public partial class potrosnja_materijala_kroz_vrijeme_2 : Form
    {
        public potrosnja_materijala_kroz_vrijeme_2()
        {
            InitializeComponent();
        }

        private void potrosnja_materijala_kroz_vrijeme_2_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                                          //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                                          //..sto se aplikacija u potpunosti zatvori
        {
            //Application.Exit();
        }

        private void btn_stanje_poduzeca_Click(object sender, EventArgs e) //kliknem button, otvora formu: stanje_poduzeca_2
        {
            stanje_poduzeca_2 stanje_poduzeca_2 = new stanje_poduzeca_2();
            Hide();
            stanje_poduzeca_2.Show();
            Close();
        }

        private void btn_potrosnja_materijala_kroz_vrijeme_Click(object sender, EventArgs e) //kliknem button, otvara formu: potrosnja_materijala_kroz_vrijeme_2
        {
            potrosnja_materijala_kroz_vrijeme_2 potrosnja_materijala_kroz_vrijeme_2 = new potrosnja_materijala_kroz_vrijeme_2();
            Hide();
            potrosnja_materijala_kroz_vrijeme_2.Show();
            Close();
        }

        private void btn_broj_odrzavanja_kroz_vrijeme_Click(object sender, EventArgs e) //kliknem button, otvora formu: broj_odrzavanja_kroz_vrijeme_2
        {
            broj_odrzavanja_kroz_vrijeme_2 broj_odrzavanja_kroz_vrijeme_2 = new broj_odrzavanja_kroz_vrijeme_2();
            Hide();
            broj_odrzavanja_kroz_vrijeme_2.Show();
            Close();
        }

        private void btn_odstupanje_od_normale_Click(object sender, EventArgs e) //kliknem button, otvora formu: odstupanje_od_normale_2
        {
            odstupanje_od_normale_2 odstupanje_od_normale_2 = new odstupanje_od_normale_2();
            Hide();
            odstupanje_od_normale_2.Show();
            Close();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Home Home = new Home();
            Hide();
            Home.Show();
            Close();
        }
    }
}
