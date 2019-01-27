using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada
{
    public partial class Stanje : UserControl
    {
        Baza.DB statistika = new Baza.DB();
        public Stanje()
        {
            InitializeComponent();
            Ucitaj();
        }
        private void Ucitaj()
        {
            brojEvidencija.Text = Convert.ToString(statistika.Evidencija_C_S(true));
            VrijednostMaterijala.Text = Convert.ToString(statistika.CijenaMaterijala());
            RadniSati.Text = Convert.ToString(statistika.Evidencija_C_S(false));
            postotakZauzeca.Text = Convert.ToString(Math.Round((statistika.Postotak()), 2) + "%");
        }
    }
}
