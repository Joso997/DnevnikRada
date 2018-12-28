using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Forms;

namespace DnevnikRada
{
    public partial class skladiste_trazi : Form
    {
        int index;
        Klase.Skladiste skladiste = new Klase.Skladiste();
        public skladiste_trazi()
        {          
            InitializeComponent();
            skladisteGrid.DataSource = skladiste.Ucitaj();
        }
        ~skladiste_trazi()
        {
            Console.WriteLine("Form Destructor");
        }
        private void Skladiste_trazi_FormClosed(object sender, FormClosedEventArgs e) //event koji omogucuje da se aplikacija..  
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void skladiste_trazi_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("BAZA JE OTVORENA! YEY");
        }

        private void KlickMe_Click(object sender, EventArgs e)
        {
            string lol = string.Format(search.Text);
            skladisteGrid.DataSource = skladiste.Ucitaj(lol);
        }

        private void skladiste_trazi_FormClosing(object sender, FormClosingEventArgs e)
        {
            skladiste.UgasiBazu();
            Dispose();
        }

        private void skladisteGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = skladisteGrid.Rows[e.RowIndex];
                if (row.Cells["NazivMaterijala"].Value == null)
                {
                    nazivBox.Text = null;
                }
                else
                {
                    nazivBox.Text = row.Cells["NazivMaterijala"].Value.ToString();

                }
                if (row.Cells["Prodavac"].Value == null)
                {
                    prodavacBox.Text = null;
                }
                else
                {
                    prodavacBox.Text = row.Cells["Prodavac"].Value.ToString();
                }
                if (row.Cells["Kolicina"].Value == null)
                {
                    kolicinaBox.Text = null;
                }
                else
                {
                    kolicinaBox.Text = row.Cells["Kolicina"].Value.ToString();
                }

                if (row.Cells["MjernaJedinica"].Value == null)
                {
                    mjBox.Text = null;
                }
                else
                {
                    mjBox.Text = row.Cells["MjernaJedinica"].Value.ToString();
                }
                string index2= row.Cells["Id"].Value.ToString();
                index = Int32.Parse(index2);

                MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void finishEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                skladiste.Edit(nazivBox.Text, prodavacBox.Text, mjBox.Text,Int32.Parse( kolicinaBox.Text), index);
                skladisteGrid.DataSource =skladiste.Ucitaj();
            }
        }
    }
}
