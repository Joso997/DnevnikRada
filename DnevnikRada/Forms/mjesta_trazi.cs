﻿using System;
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
    public partial class Mjesta_trazi : UIController
    {
        Mjesta mjesto = new Mjesta();
        public Mjesta_trazi()
        {
            InitializeComponent();
            mjestoGrid.DataSource = mjesto.Ucitaj();
            selectButton = SelectButton;
            mjestoGrid.Columns["id"].Visible = false;
            Show();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    string trazi = string.Format(searchText.Text);
                    mjestoGrid.DataSource = mjesto.Ucitaj("NazivMjesta", trazi);
                    break;
                case "Edit":
                    if (nazivBox.Text == "" || adresaBox.Text == "")
                    {
                        MessageBox.Show("Adresa i Naziv mjesta ne mogu biti prazni");
                        break;
                    }
                    Mjesta _mjesto = new Mjesta(nazivBox.Text, adresaBox.Text, metroDateTime1.Checked ? metroDateTime1.Value : DateTime.MinValue, metroDateTime2.Checked ? metroDateTime2.Value : DateTime.MinValue);
                    mjestoGrid.DataSource = mjesto.Ucitaj();
                    Edit.Enabled = false;
                    break;
                case "Home":
                    Home Home = new Home();
                    return true;
            }
            return false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dT = new DataTable();
            dT = mjesto.Ucitaj(Int32.Parse(mjestoGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            nazivBox.Text = dT.Rows[0].ItemArray[1].ToString();
            adresaBox.Text = dT.Rows[0].ItemArray[2].ToString();
            metroDateTime1.Value = dT.Rows[0].ItemArray[3].Equals(DBNull.Value) ? DateTime.Today : (DateTime)dT.Rows[0].ItemArray[3];
            metroDateTime2.Value = dT.Rows[0].ItemArray[4].Equals(DBNull.Value) ? DateTime.Today : (DateTime)dT.Rows[0].ItemArray[4];
            Edit.Enabled = true;
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
