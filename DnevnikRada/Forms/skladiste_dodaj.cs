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
    public partial class Skladiste_dodaj : Form
    {
        
        public Skladiste_dodaj()
        {
            InitializeComponent();
            
        }

        private void Skladiste_dodaj_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                      //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                      //..sto se aplikacija u potpunosti zatvori

        {

            //Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Home Home = new Home();
            Hide();
            Home.Show();
            Close();
        }

        private void btn_potvrdi_Click(object sender, EventArgs e)
        {
            int kol;
            string lol = tb_kolicina.Text.ToString();
            kol = Int32.Parse(lol);
            Skladiste skladiste = new Skladiste(tb_naziv_materijala.Text, tb_proizvodac.Text, tb_mjerna_jedinica.Text, kol);
            
        }

        private void Skladiste_dodaj_Load(object sender, EventArgs e)
        {

        }
    }
}
