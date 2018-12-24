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
            skladisteGrid.DataSource = baza.LoadDataBase("select * from Skladiste");
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
