using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnevnikRada.Klase;

namespace DnevnikRada
{
    public partial class Mjesta_trazi : UIController
    {
        Mjesta mjesto = new Mjesta();
        
        private int row_kalendar;
        public Mjesta_trazi()
        {
            InitializeComponent();
            mjestoGrid.DataSource = mjesto.Ucitaj();
            selectButton = SelectButton;
            mjestoGrid.Columns["id"].Visible = false;
            dT.Columns.Add("Datum", typeof(DateTime)).Unique = true;
            Show();
            SetFilter();
        }

        public bool SelectButton(object sender)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "Trazi":
                    Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                        {filter_dic[Filters.Text], "%"+Search.Text+"%" }
                    };
                    mjestoGrid.DataSource = mjesto.Ucitaj(biblioteka, new List<string> { { "like" } });
                    break;
                case "Edit":
                    new mjesta_dodaj(mjesto.Ucitaj(Int32.Parse(mjestoGrid.Rows[row].Cells["ID"].Value.ToString())));
                    Osvjezi();
                    return true;
                case "Oduzmi":
                    DataTable dT_temp_2 = new DataTable();
                    dT_temp_2 = mjesto.Kalendar.Ucitaj(Int32.Parse(kalendarGrid.Rows[row_kalendar].Cells["ID"].Value.ToString()));
                    new Kalendar(dT_temp_2.Rows[0]["Id_Mjesta"], new List<DateTime> { { (DateTime)dT_temp_2.Rows[0]["Datum"] } }, true);
                    Osvjezi();
                    break;
                case "Sakri":
                    DataTable dT_temp = new DataTable();
                    dT_temp = mjesto.Ucitaj(Int32.Parse(mjestoGrid.Rows[row].Cells["Id"].Value.ToString()));
                    new Mjesta(dT_temp.Rows[0].ItemArray[1].ToString(), dT_temp.Rows[0].ItemArray[2].ToString(), true);
                    Osvjezi();
                    break;
                case "Home":
                    new Home();
                    return true;
            }
            return false;
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dictionary<string, object> biblioteka = new Dictionary<string, object>{
                {"Id_Mjesta", Int32.Parse(mjestoGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString()) }
            };
            dT = mjesto.Kalendar.Ucitaj(biblioteka, new List<string> { { "=" } });
            kalendarGrid.DataSource = dT;
            kalendarGrid.Columns[0].Visible = false;
            kalendarGrid.Columns[1].Visible = false;
            row = e.RowIndex;
            Sakri.Enabled = true;
            Edit.Enabled = true;
        }

        private void SetFilter()
        {
            filter_dic = new Dictionary<string, string>
            {
                {"Naziv Mjesta", "NazivMjesta" },
                {"Adresa", "Adresa" }
            };
            Filters.Items.AddRange(filter_dic.Keys.ToArray());
            Filters.Text = filter_dic.Keys.First();
        }

        void Osvjezi()
        {
            mjestoGrid.DataSource = mjesto.Ucitaj();
            kalendarGrid.DataSource = null;
            Sakri.Enabled = false;
            Edit.Enabled = false;
        }

       
        public override void Click_Gumb(object sender, EventArgs e)
        {
            base.Click_Gumb(sender, e);
        }

        protected override void This_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.This_FormClosing(sender, e);
        }

        private void kalendarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dT_kalendar = new DataTable();
            row_kalendar = e.RowIndex;
            Oduzmi.Enabled = true;
        }
    }
}
