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
    public partial class evidencija_trazi : Form
    {
        Klase.Evidencija evidencija = new Klase.Evidencija();
        private bool UserClosing { get; set; }
        public evidencija_trazi()
        {
            InitializeComponent();
            Show();
            evidencijaInfo.DataSource = evidencija.Ucitaj();
        }

        private void evidencija_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                       //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                       //..sto se aplikacija u potpunosti zatvori

        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Home Form1 = new Home();
            this.Hide();
            Form1.Show();
        }
    }
}
