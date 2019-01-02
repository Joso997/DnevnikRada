using System;
using System.Data;
using System.Windows.Forms;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class skladiste_trazi : UIController
    {
        int index;
        Skladiste skladiste = new Skladiste();
        public skladiste_trazi()
        {          
            InitializeComponent();
            skladisteGrid.DataSource = skladiste.Get();
            selectButton = SelectButton;
            Show();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    string lol = search.Text;
                    skladisteGrid.DataSource = skladiste.Get(lol);
                    break;
                case "Edit":
                    skladiste.Edit(nazivBox.Text, prodavacBox.Text, mjBox.Text, Int32.Parse(kolicinaBox.Text), index);
                    skladisteGrid.DataSource = skladiste.Get();
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
            dT = skladiste.Get(Int32.Parse(skladisteGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            nazivBox.Text = dT.Rows[0].ItemArray[1].ToString();
            prodavacBox.Text = dT.Rows[0].ItemArray[2].ToString();
            kolicinaBox.Text = dT.Rows[0].ItemArray[3].ToString();
            mjBox.Text = dT.Rows[0].ItemArray[4].ToString();
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
