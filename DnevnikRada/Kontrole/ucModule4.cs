using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnevnikRada
{
    public partial class ucModule4 : UserControl
    {
        private static ucModule4 _instance;
        public static ucModule4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule4();
                return _instance;
            }
        }

        public ucModule4()
        {
            InitializeComponent();
        }
    }
}
