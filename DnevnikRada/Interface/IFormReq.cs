using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada.Interface
{
    interface IFormReq
    {
        void Unload();
        void This_FormClosing(object sender, FormClosingEventArgs e);
        void Click_Gumb(object sender, EventArgs e);
    }
}
