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
    public partial class mjesta_trazi : UIController
    {
        int index;
        Mjesta mjesto = new Mjesta();
        public mjesta_trazi()
        {
            InitializeComponent();
            mjestoGrid.DataSource = mjesto.Get();
            selectButton = SelectButton;
            Show();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    string lol = string.Format(searchText.Text);
                    mjestoGrid.DataSource = mjesto.Get(lol);
                    break;
                case "Edit":
                    mjesto.Edit(nazivBox.Text, adresaBox.Text, index);
                    mjestoGrid.DataSource = mjesto.Get();
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
            dT = mjesto.Get(Int32.Parse(mjestoGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            nazivBox.Text = dT.Rows[0].ItemArray[1].ToString();
            adresaBox.Text = dT.Rows[0].ItemArray[2].ToString();
            radOdbox.Text = dT.Rows[0].ItemArray[3].ToString();
            radDoBox.Text = dT.Rows[0].ItemArray[4].ToString();
            index = Int32.Parse(dT.Rows[0].ItemArray[0].ToString());
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
