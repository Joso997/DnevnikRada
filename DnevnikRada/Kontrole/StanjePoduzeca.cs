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
    public partial class ucModule1 : UserControl
    {
        Baza.DB statistika = new Baza.DB();
        public ucModule1()
        {
            InitializeComponent();
            
            brojEvidencija.Text = Convert.ToString(statistika.Evidencija_C_S(true));
            VrijednostMaterijala.Text = Convert.ToString(statistika.CijenaMaterijala());
            RadniSati.Text = Convert.ToString(statistika.Evidencija_C_S(false));
        }
    }
}
