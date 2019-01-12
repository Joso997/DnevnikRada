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

namespace DnevnikRada.Forms
{
    public partial class Stanje_Poduzeca : UIController
    {
        public Stanje_Poduzeca()
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
                case "btnStanjePoduzeca":
                    if (!metroPanel1.Controls.Contains(ucModule1.Instance))
                    {
                        metroPanel1.Controls.Add(ucModule1.Instance);
                        ucModule1.Instance.Dock = DockStyle.Fill;
                        ucModule1.Instance.BringToFront();
                    }
                    else
                        ucModule1.Instance.BringToFront();
                    break;
                case "btnPotrosnjaMaterijalaKrozVrijeme":
                    if (!metroPanel1.Controls.Contains(ucModule2.Instance))
                    {
                        metroPanel1.Controls.Add(ucModule2.Instance);
                        ucModule2.Instance.Dock = DockStyle.Fill;
                        ucModule2.Instance.BringToFront();
                    }
                    else
                        ucModule2.Instance.BringToFront();
                    break;
                case "btnBrojOdrzavanjaKrozVrijeme":
                    if (!metroPanel1.Controls.Contains(ucModule3.Instance))
                    {
                        metroPanel1.Controls.Add(ucModule3.Instance);
                        ucModule3.Instance.Dock = DockStyle.Fill;
                        ucModule3.Instance.BringToFront();
                    }
                    else
                        ucModule3.Instance.BringToFront();
                    break;
                case "btnOdstupanjeOdNormale":
                    if (!metroPanel1.Controls.Contains(ucModule4.Instance))
                    {
                        metroPanel1.Controls.Add(ucModule4.Instance);
                        ucModule4.Instance.Dock = DockStyle.Fill;
                        ucModule4.Instance.BringToFront();
                    }
                    else
                        ucModule4.Instance.BringToFront();
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
