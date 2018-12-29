using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada
{
    public partial class mjesta_trazi : Form
    {
        int index;
        Klase.Mjesta mjesto = new Klase.Mjesta();
        public mjesta_trazi()
        {
            InitializeComponent();
            Baza.DB baza = new Baza.DB();
            dataGrid.DataSource = baza.LoadDataBase("select * from Mjesta");
            Show();
        }

        private void mjesta_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
                                                                                   //..NE nastavi izvrsavati u pozadini nakon.. 
                                                                                   //..sto se aplikacija u potpunosti zatvori

        {
            //Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e) //kliknem home button, vraca na pocetnu formu
        {
            Home Home = new Home();
            Hide();
            Home.Show();
            Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string lol = string.Format(searchText.Text);

            Klase.Mjesta skladiste = new Klase.Mjesta();
            dataGrid.DataSource = skladiste.Trazi(lol);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];
                if (row.Cells["NazivMjesta"].Value == null)
                {
                    nazivBox.Text = null;
                }
                else
                {
                    nazivBox.Text = row.Cells["NazivMjesta"].Value.ToString();
                }
                ////////////
                if (row.Cells["Adresa"].Value == null)
                {
                    adresaBox.Text = null;
                }
                else
                {
                    adresaBox.Text = row.Cells["Adresa"].Value.ToString();
                }
                ////////////
                if (row.Cells["VrijemeRadaOD"].Value == null)
                {
                    radOdbox.Text = null;
                }
                else
                {
                    radOdbox.Text = row.Cells["VrijemeRadaOD"].Value.ToString();
                }
                ////////////
                if (row.Cells["VrijemeRadaDO"].Value == null)
                {
                    radDoBox.Text = null;
                }
                else
                {
                    radDoBox.Text = row.Cells["VrijemeRadaDO"].Value.ToString();
                }
                string index2 = row.Cells["Id"].Value.ToString();
                index = Int32.Parse(index2);
            }
            
        }

        private void finishEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                mjesto.Edit(nazivBox.Text, adresaBox.Text, index);
                dataGrid.DataSource = mjesto.Ucitaj();
            }
        }
    }
}
