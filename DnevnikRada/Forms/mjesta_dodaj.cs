﻿using System;
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
    public partial class mjesta_dodaj : Form 
    {
        public mjesta_dodaj()
        {
            InitializeComponent();
            Show();
        }

        private void mjesta_dodaj_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
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
            Mjesta mjesta = new Mjesta(tb_naziv_mjesta.Text, tb_adresa.Text);
        }

        private void tb_naziv_mjesta_Click(object sender, EventArgs e)
        {

        }

        private void mjesta_dodaj_Load(object sender, EventArgs e)
        {

        }
    }
}
