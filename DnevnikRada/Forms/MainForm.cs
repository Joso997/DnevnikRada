using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Everyone eveywhere in the app should know me as Form1.Form1Instance

            //Make sure I am kept hidden
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            InitializeComponent();

            //Open a managed form - the one the user sees..
            var Home = new Home();
        }
    }
}
