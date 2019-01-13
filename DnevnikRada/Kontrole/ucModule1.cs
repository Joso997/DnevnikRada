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
    public partial class ucModule1 : UserControl
    {
        private static ucModule1 _instance;
        public static ucModule1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule1();
                return _instance;
            }
        }

        public ucModule1()
        {
            InitializeComponent();
        }
    }
}
