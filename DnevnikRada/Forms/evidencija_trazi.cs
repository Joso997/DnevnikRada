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
    public partial class evidencija_trazi : UIController
    {
        Evidencija evidencija = new Evidencija();
        public evidencija_trazi()
        {
            InitializeComponent();
            evidencijaGrid.DataSource = evidencija.Ucitaj();
            evidencijaGrid.Columns["id"].Visible = false;
            selectButton = SelectButton;
            Show();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    string trazi = textTrazi.Text;
                    evidencijaGrid.DataSource = evidencija.Ucitaj("NazivMjesta", trazi);

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
        Poveznica poveznica = new Poveznica();
        private void evidencijaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            materijalGrid.DataSource = poveznica.Ucitaj(Int32.Parse(evidencijaGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
            opisPosla.Text = evidencijaGrid.Rows[e.RowIndex].Cells["OpisPosla"].Value.ToString();

            materijalGrid.Columns[0].Visible = false;
            materijalGrid.Columns["Id_Evidencija"].Visible = false;
        }
    }
}
