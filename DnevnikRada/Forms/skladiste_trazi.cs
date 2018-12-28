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

namespace DnevnikRada
{
    public partial class skladiste_trazi : Form
    {
        Klase.Skladiste skladiste = new Klase.Skladiste();
        public skladiste_trazi()
        {          
            InitializeComponent();
            skladisteGrid.DataSource = skladiste.Ucitaj();
        }
        ~skladiste_trazi()
        {
            Console.WriteLine("Form Destructor");
        }
        private void Skladiste_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void skladiste_trazi_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("BAZA JE OTVORENA! YEY");
        }

        private void KlickMe_Click(object sender, EventArgs e)
        {
            string lol = string.Format(search.Text);
            skladisteGrid.DataSource = skladiste.Ucitaj(lol);
        }

        private void skladiste_trazi_FormClosing(object sender, FormClosingEventArgs e)
        {
            skladiste.UgasiBazu();
            Dispose();
        }
    }
}
