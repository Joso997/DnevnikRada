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
    public partial class skladiste_trazi : Form
    {
        Baza_Testing.DB baza;
        public skladiste_trazi()
        {
            InitializeComponent();
            baza = new Baza_Testing.DB();
            skladisteGrid.DataSource = baza.LoadDataBase("select * from Skladiste");
        }

        private void Skladiste_trazi_FormClosed(object sender, FormClosedEventArgs e)
        {
            baza.connection.Close();
            Application.Exit();
        }

        private void Reload()
        {
            string lol;
            skladisteGrid.DataSource = baza.LoadDataBase(lol=string.Format(
                "select * from Skladiste " +
                "WHERE NazivMaterijala like '%{0}%' or " +
                "Prodavac like '%{0}%'", search.Text));
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void startSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
