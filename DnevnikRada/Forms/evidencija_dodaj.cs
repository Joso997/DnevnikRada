using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class evidencija_dodaj : UIController
    {
        private bool UserClosing { get; set; }
        public evidencija_dodaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
        }
        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Potvrdi":
                    Evidencija evidencija = new Evidencija(tb_naziv_mjesta.Text, DateTime.Now, "", int.Parse(tb_utroseno_vrijeme.Text), "", 10, 10f);
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }
        protected override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }
    }
}
