using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnik_Rada
{
    public partial class skladiste_trazi : Form
    {
        public skladiste_trazi()
        {
            InitializeComponent();
        }

        private void Skladiste_trazi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void MetroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
