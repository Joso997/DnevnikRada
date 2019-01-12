using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    public class UIController : Form
    {
        private bool UserClosing { get; set; }
        protected delegate bool SelectButtonDelagate(object sender);
        protected SelectButtonDelagate selectButton;

        protected virtual void Click_Gumb(object sender, EventArgs e)
        {
            Console.WriteLine("sender je: " + (Button)sender);
            if (selectButton(sender))
            {
                Hide();
                UserClosing = true;
                Close();
            }
        }

        protected virtual void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (!UserClosing)
                {
                    DialogResult Result = MessageBox.Show("Dajte Nam PET!", "Error Closing Application", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (Result == DialogResult.Yes)
                        Application.Exit();
                    else
                        e.Cancel = true;
                    Console.WriteLine("Here");
                }
        }
    }
}
