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
    public partial class Pmkv : Form
    {
        private bool UserClosing { get; set; }
        public Pmkv()
        {
            InitializeComponent();
            Show();
        }

        private void btn_stanje_poduzeca_Click(object sender, EventArgs e) //kliknem button, otvora formu: stanje_poduzeca_2
        {
            StanjePoduzeca stanje_poduzeca_2 = new StanjePoduzeca();
            Unload();
        }

        private void btn_potrosnja_materijala_kroz_vrijeme_Click(object sender, EventArgs e) //kliknem button, otvara formu: potrosnja_materijala_kroz_vrijeme_2
        {
            Pmkv potrosnja_materijala_kroz_vrijeme_2 = new Pmkv();
            Unload();
        }

        private void btn_broj_odrzavanja_kroz_vrijeme_Click(object sender, EventArgs e) //kliknem button, otvora formu: broj_odrzavanja_kroz_vrijeme_2
        {
            Bokv broj_odrzavanja_kroz_vrijeme_2 = new Bokv();
            Unload();
        }

        private void btn_odstupanje_od_normale_Click(object sender, EventArgs e) //kliknem button, otvora formu: odstupanje_od_normale_2
        {
            Oon odstupanje_od_normale_2 = new Oon();
            Unload();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Home Home = new Home();
            Unload();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (!UserClosing)
                    Application.Exit();
        }

        private void Unload()
        {
            Hide();
            UserClosing = true;
            Close();
        }
    }
}
