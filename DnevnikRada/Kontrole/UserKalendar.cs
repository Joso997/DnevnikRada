using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;
using System.Globalization;

namespace DnevnikRada.Kontrole
{
    public partial class UserKalendar : UserControl
    {
        Kalendar kalendar = new Kalendar();
        //List<MetroFramework.Controls.MetroLabel> lista = new List<MetroFramework.Controls.MetroLabel>();
        public UserKalendar()
        {
            InitializeComponent();
            Osvjezi();   
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            kalendar.PromjeniDatum(1);
            Osvjezi();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            OcistiKalendar();
            kalendar.PromjeniDatum(-1);
            Osvjezi();
        }

        void Osvjezi()
        {
            int top = 40;
            int left = 5 + kalendar.GetDayInWeek()*42;
            Mjesec_Godina.Text = kalendar.Mjesec_Godina();
            int razmak = kalendar.GetDayInWeek();
            Mjesta mjesta = new Mjesta();
            DataTable dT = new DataTable();
            dT = mjesta.Ucitaj();
            for (int i = 1; i <= kalendar.GetNumOfDays(); i++)
            {
                MetroFramework.Controls.MetroLabel label = new MetroFramework.Controls.MetroLabel();
                label.Location = new Point(left, top);
                label.Margin = new Padding(5, 10, 7, 0);
                label.Name = "day"+i.ToString();
                label.Size = new Size(30, 30);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = i.ToString();
                label.Visible = true;
                if (CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.Year == kalendar.Mjesec_Godina() && i == DateTime.Today.Day)
                {
                    label.UseCustomBackColor = true;
                    label.FontWeight = (MetroFramework.MetroLabelWeight)FontStyle.Bold;
                    label.BackColor = Color.Red;
                }
                this.Controls.Add(label);
                left += label.Width + label.Margin.Left+ label.Margin.Right;
                if (razmak == 6)
                {
                    top += label.Height + label.Margin.Top;
                    left = 5;
                    razmak = 0;
                }
                else
                    razmak++;
                

            }
            //this.Controls.AddRange(lista.ToArray());
        }

        private void OcistiKalendar()
        {
            for (int i = 1; i <= kalendar.GetNumOfDays(); i++)
            {
                this.Controls.RemoveByKey("day" + i.ToString());
            }
        }
    }
}
