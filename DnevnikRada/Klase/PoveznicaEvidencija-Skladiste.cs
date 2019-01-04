using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DnevnikRada.Klase
{
    class PoveznicaEvidencija_Skladiste : Baza.DB
    {
        public int Id_evidencija { get; set; }
        public string Naziv_materijala { get; set; }

        public PoveznicaEvidencija_Skladiste()
        {

        }

        public DataTable Ucitaj(int idEvi)
        {
            return Get2("Poveznica", "Id_Evidencija", idEvi);
        }

    }
}
