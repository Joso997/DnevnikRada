﻿using System;
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
    public partial class skladiste_trazi : Form
    {
        Baza.DB baza;
        public skladiste_trazi()
        {
            InitializeComponent();
            baza = new Baza.DB();
            skladisteGrid.DataSource = baza.LoadDataBase("select * from Skladiste");
        }

        private void Skladiste_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                      //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                      //..sto se aplikacija u potpunosti zatvori

        {
            baza.connection.Close();
            Application.Exit();
        }


        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu

        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void skladiste_trazi_Load(object sender, EventArgs e)
        {

        }

        private void KlickMe_Click(object sender, EventArgs e)
        {
            string lol = string.Format(search.Text);

            Klase.Skladiste skladiste = new Klase.Skladiste();
            skladisteGrid.DataSource = skladiste.Trazi(lol);
        }
    }
}
