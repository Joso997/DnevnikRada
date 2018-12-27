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
    public partial class mjesta_trazi : Form
    {
        public mjesta_trazi()
        {
            InitializeComponent();
            Baza.DB baza = new Baza.DB();
            dataGrid.DataSource = baza.LoadDataBase("select * from Mjesta");
        }

        private void mjesta_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                   //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                   //..sto se aplikacija u potpunosti zatvori

        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string lol = string.Format(searchText.Text);

            Klase.Mjesta skladiste = new Klase.Mjesta();
            dataGrid.DataSource = skladiste.Trazi(lol);
        }
    }
}
