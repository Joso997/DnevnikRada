using System;
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
    public partial class mjesta_dodaj : UIController
    {
        public mjesta_dodaj()
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
                    Console.WriteLine(metroDateTime1.Value);
                    Mjesta mjesta = new Mjesta(tb_naziv_mjesta.Text, tb_adresa.Text, metroDateTime1.Checked?metroDateTime1.Value:DateTime.MinValue, metroDateTime2.Checked ? metroDateTime2.Value:DateTime.MinValue);
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

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (metroDateTime1.Enabled)
            {
                metroDateTime1.Enabled = false;
                metroDateTime2.Enabled = false;
            }
            else
            {
                metroDateTime1.Enabled = true;
                metroDateTime2.Enabled = true;
            }*/

        }
    }
}
