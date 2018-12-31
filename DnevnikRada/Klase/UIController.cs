using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    public partial class UIController : Form
    {
        private bool UserClosing { get; set; }
        protected delegate void SelectButtonDelagate(object sender);
        protected SelectButtonDelagate selectButton;

        public void Click_Gumb(object sender, EventArgs e)
        {
            selectButton(sender);
            Hide();
            UserClosing = true;
            Close();
        }

        protected void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                if (!UserClosing)
                {
                    DialogResult Result = MessageBox.Show("Dajte Nam PET!", "Error Closing Application", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (Result == DialogResult.Yes)
                        Application.Exit();
                    else
                        e.Cancel = true;
                }
        }
    }
}
