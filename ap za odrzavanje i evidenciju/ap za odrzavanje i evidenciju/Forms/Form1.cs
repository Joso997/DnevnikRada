﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnik_Rada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            evidencija_trazi evidencija_trazi = new evidencija_trazi();
            this.Hide();
            evidencija_trazi.Show();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            evidencija_dodaj evidencija_dodaj = new evidencija_dodaj();
            this.Hide();
            evidencija_dodaj.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            skladiste_trazi skladiste_trazi = new skladiste_trazi();
            this.Hide();
            skladiste_trazi.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Skladiste_dodaj skladiste_dodaj = new Skladiste_dodaj();
            this.Hide();
            skladiste_dodaj.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            mjesta_trazi mjesta_trazi = new mjesta_trazi();
            this.Hide();
            mjesta_trazi.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            mjesta_dodaj mjesta_dodaj = new mjesta_dodaj();
            this.Hide();
            mjesta_dodaj.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            stanje_poduzeca_2 stanje_poduzeca_2 = new stanje_poduzeca_2();
            this.Hide();
            stanje_poduzeca_2.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
