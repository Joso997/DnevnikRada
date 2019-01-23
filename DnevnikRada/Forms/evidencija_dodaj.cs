﻿using System;
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
using MetroFramework.Controls;

namespace DnevnikRada
{
    public partial class Evidencija_dodaj : UIController
    {
        DataTable dT = new DataTable();
        public Evidencija_dodaj()
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            Fill();
            dT.Columns.Add("NazivMaterijala").Unique = true;
            dT.Columns.Add("Kolicina", typeof(Int32));
        }

        public Evidencija_dodaj(List<object> tag)
        {
            InitializeComponent();
            Show();
            selectButton = SelectButton;
            Fill();
            metroDateTime1.Value = (DateTime)tag[0];
            NazivMjesta.Text = (string)tag[1];
            dT.Columns.Add("NazivMaterijala").Unique = true;
            dT.Columns.Add("Kolicina", typeof(Int32));
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Dodaj":
                    if(CheckInput(new Dictionary<string, string> { { Kolicina.Name, Kolicina.Text },{ OdabirMaterijala.Name, OdabirMaterijala.Text },{ addUse.Name, addUse.Text } }))
                        break;
                    object[] marks;
                    if (addUse.Text == "-")
                    {
                        marks = new object[] { OdabirMaterijala.Text, int.Parse(Kolicina.Text) * -1 };
                        MessageBox.Show("tu sam");
                    }
                    else
                    {
                        marks = new object[] { OdabirMaterijala.Text, int.Parse(Kolicina.Text)  };
                    }
                        
                    var rows = dT.Select(string.Format("NazivMaterijala = '{0}'", OdabirMaterijala.Text));
                    if(rows.Length == 0)
                        dT.LoadDataRow(marks, true);
                    else 

                        rows[0]["Kolicina"] = int.Parse(Kolicina.Text);
                    
                        
                    materijalGrid.DataSource = dT;
                    break;
                case "Potvrdi":
                    if(CheckInput(new Dictionary<string, string> { { tb_opis_posla.Name, tb_opis_posla.Text }, {tb_utroseno_vrijeme.Name, tb_utroseno_vrijeme.Text } }))
                        break;
                    List<string> materijal_list = new List<string>();
                    List<int> kolicina_list = new List<int>();
                    var n_temp = dT.AsEnumerable().Select(r => r.Field<string>(0)).ToArray();
                    materijal_list.AddRange(n_temp);
                    var _temp = dT.AsEnumerable().Select(r => r.Field<Int32>(1)).ToArray();
                    kolicina_list.AddRange(_temp);
                    Evidencija evidencija = new Evidencija(NazivMjesta.Text, metroDateTime1.Value, tb_opis_posla.Text, int.Parse(tb_utroseno_vrijeme.Text), 10f, materijal_list, kolicina_list);
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

        void Fill()
        {
            Skladiste skladiste = new Skladiste();
            DataTable dT_skladiste = new DataTable();
            dT_skladiste = skladiste.Ucitaj("NazivMaterijala", null);
            var _temp = dT_skladiste.AsEnumerable().Select(r => r.Field<string>("NazivMaterijala")).ToArray();
            OdabirMaterijala.Items.AddRange(_temp);
            Mjesta mjesta = new Mjesta();
            DataTable dT_mjesta = new DataTable();
            dT_mjesta = mjesta.Ucitaj("NazivMjesta", null);
            NazivMjesta.Items.AddRange(dT_mjesta.AsEnumerable().Select(r => r.Field<string>("NazivMjesta")).ToArray());
            addUse.Items.Add("+");;
            addUse.Items.Add("-");
        }

        private void evidencijaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OdabirMaterijala.Text = materijalGrid.Rows[e.RowIndex].Cells["NazivMaterijala"].Value.ToString();
            Kolicina.Text = materijalGrid.Rows[e.RowIndex].Cells["Kolicina"].Value.ToString();
        }

        private void tb_utroseno_vrijeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
