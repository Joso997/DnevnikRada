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
        protected DataTable dT = new DataTable();
        protected int ID { get; set; }
        protected int row;
        protected Dictionary<string, string> filter_dic;

        public virtual void Click_Gumb(object sender, EventArgs e)
        {
            if (selectButton(sender))
            {
                Hide();
                UserClosing = true;
                Close();
            }
        }

        

        protected bool CheckInput(Dictionary<string, string> biblioteka)
        {
            string ispis = null;
            foreach (var knjiga in biblioteka)
            {
                if(knjiga.Value == "")
                {
                    ispis += knjiga.Key + (knjiga.Key.Equals(biblioteka.Last().Key) ? "" : " i ");
                }
            }
            if (ispis != null)
                MessageBox.Show(ispis + " ne mogu biti prazni");
            else
                return false;
            return true;
        }
    }
}
