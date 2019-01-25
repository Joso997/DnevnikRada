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
        DataTable dT = new DataTable();
        public mjesta_dodaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            dT.Columns.Add("Datumi", typeof(DateTime)).Unique = true;
            metroDateTime1.MinDate = DateTime.Now.Date.AddDays(1);
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Dodaj":
                    object[] marks;
                    marks = new object[] { metroDateTime1.Text };
                    var rows = dT.Select(string.Format("Datumi = '{0}'", metroDateTime1.Text));
                    if (rows.Length == 0)
                        dT.LoadDataRow(marks, true);
                    else
                        MessageBox.Show("Datum već dodan.");
                    kalendarGrid.DataSource = dT;
                    break;
                case "Potvrdi":
                    if (CheckInput(new Dictionary<string, string> { { "Adresa", tb_adresa.Text }, { "Naziv Mjesta", tb_naziv_mjesta.Text } }))
                        break;
                    var n_temp = dT.AsEnumerable().Select(r => r.Field<DateTime>(0)).ToList();
                    if (!n_temp.Any())
                        new Mjesta(tb_naziv_mjesta.Text, tb_adresa.Text);
                    else
                        new Mjesta(tb_naziv_mjesta.Text, tb_adresa.Text, n_temp);               
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
        public override void Click_Gumb(object sender, EventArgs e)
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
