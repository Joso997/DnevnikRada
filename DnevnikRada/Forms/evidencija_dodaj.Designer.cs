namespace DnevnikRada
{
    partial class Evidencija_dodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evidencija_dodaj));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_mjesta = new MetroFramework.Controls.MetroLabel();
            this.lbl_utroseno_vrijeme = new MetroFramework.Controls.MetroLabel();
            this.tb_utroseno_vrijeme = new MetroFramework.Controls.MetroTextBox();
            this.tb_opis_posla = new System.Windows.Forms.RichTextBox();
            this.lbl_opis_posla = new MetroFramework.Controls.MetroLabel();
            this.Potvrdi = new MetroFramework.Controls.MetroButton();
            this.Oduzmi = new MetroFramework.Controls.MetroButton();
            this.Dodaj = new MetroFramework.Controls.MetroButton();
            this.Kolicina = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.OdabirMaterijala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.addUse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.NazivMjesta = new MetroFramework.Controls.MetroComboBox();
            this.materijalGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.materijalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Location = new System.Drawing.Point(800, 480);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(100, 100);
            this.Home.TabIndex = 0;
            this.Home.UseSelectable = true;
            this.Home.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // lbl_naziv_mjesta
            // 
            this.lbl_naziv_mjesta.AutoSize = true;
            this.lbl_naziv_mjesta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_naziv_mjesta.Location = new System.Drawing.Point(72, 36);
            this.lbl_naziv_mjesta.Name = "lbl_naziv_mjesta";
            this.lbl_naziv_mjesta.Size = new System.Drawing.Size(108, 25);
            this.lbl_naziv_mjesta.TabIndex = 1;
            this.lbl_naziv_mjesta.Text = "Naziv Mjesta";
            // 
            // lbl_utroseno_vrijeme
            // 
            this.lbl_utroseno_vrijeme.AutoSize = true;
            this.lbl_utroseno_vrijeme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_utroseno_vrijeme.Location = new System.Drawing.Point(72, 128);
            this.lbl_utroseno_vrijeme.Name = "lbl_utroseno_vrijeme";
            this.lbl_utroseno_vrijeme.Size = new System.Drawing.Size(143, 25);
            this.lbl_utroseno_vrijeme.TabIndex = 2;
            this.lbl_utroseno_vrijeme.Text = "Utrošeno Vrijeme";
            // 
            // tb_utroseno_vrijeme
            // 
            // 
            // 
            // 
            this.tb_utroseno_vrijeme.CustomButton.Image = null;
            this.tb_utroseno_vrijeme.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.tb_utroseno_vrijeme.CustomButton.Name = "";
            this.tb_utroseno_vrijeme.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_utroseno_vrijeme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_utroseno_vrijeme.CustomButton.TabIndex = 1;
            this.tb_utroseno_vrijeme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_utroseno_vrijeme.CustomButton.UseSelectable = true;
            this.tb_utroseno_vrijeme.CustomButton.Visible = false;
            this.tb_utroseno_vrijeme.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_utroseno_vrijeme.Lines = new string[0];
            this.tb_utroseno_vrijeme.Location = new System.Drawing.Point(223, 124);
            this.tb_utroseno_vrijeme.MaxLength = 32767;
            this.tb_utroseno_vrijeme.Name = "tb_utroseno_vrijeme";
            this.tb_utroseno_vrijeme.PasswordChar = '\0';
            this.tb_utroseno_vrijeme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_utroseno_vrijeme.SelectedText = "";
            this.tb_utroseno_vrijeme.SelectionLength = 0;
            this.tb_utroseno_vrijeme.SelectionStart = 0;
            this.tb_utroseno_vrijeme.ShortcutsEnabled = true;
            this.tb_utroseno_vrijeme.Size = new System.Drawing.Size(73, 29);
            this.tb_utroseno_vrijeme.TabIndex = 4;
            this.tb_utroseno_vrijeme.UseSelectable = true;
            this.tb_utroseno_vrijeme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_utroseno_vrijeme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_utroseno_vrijeme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_utroseno_vrijeme_KeyPress);
            // 
            // tb_opis_posla
            // 
            this.tb_opis_posla.Location = new System.Drawing.Point(0, 211);
            this.tb_opis_posla.Name = "tb_opis_posla";
            this.tb_opis_posla.Size = new System.Drawing.Size(495, 362);
            this.tb_opis_posla.TabIndex = 5;
            this.tb_opis_posla.Text = "";
            // 
            // lbl_opis_posla
            // 
            this.lbl_opis_posla.AutoSize = true;
            this.lbl_opis_posla.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_opis_posla.Location = new System.Drawing.Point(205, 183);
            this.lbl_opis_posla.Name = "lbl_opis_posla";
            this.lbl_opis_posla.Size = new System.Drawing.Size(91, 25);
            this.lbl_opis_posla.TabIndex = 6;
            this.lbl_opis_posla.Text = "Opis Posla";
            // 
            // Potvrdi
            // 
            this.Potvrdi.BackColor = System.Drawing.Color.RoyalBlue;
            this.Potvrdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Potvrdi.BackgroundImage")));
            this.Potvrdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Potvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Potvrdi.Location = new System.Drawing.Point(700, 480);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(100, 100);
            this.Potvrdi.TabIndex = 7;
            this.Potvrdi.UseSelectable = true;
            this.Potvrdi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Oduzmi
            // 
            this.Oduzmi.BackColor = System.Drawing.Color.RoyalBlue;
            this.Oduzmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Oduzmi.BackgroundImage")));
            this.Oduzmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Oduzmi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Oduzmi.Enabled = false;
            this.Oduzmi.Location = new System.Drawing.Point(600, 480);
            this.Oduzmi.Name = "Oduzmi";
            this.Oduzmi.Size = new System.Drawing.Size(100, 100);
            this.Oduzmi.TabIndex = 8;
            this.Oduzmi.UseSelectable = true;
            this.Oduzmi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.Dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dodaj.BackgroundImage")));
            this.Dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dodaj.Location = new System.Drawing.Point(500, 480);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(100, 100);
            this.Dodaj.TabIndex = 9;
            this.Dodaj.UseSelectable = true;
            this.Dodaj.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Kolicina
            // 
            // 
            // 
            // 
            this.Kolicina.CustomButton.Image = null;
            this.Kolicina.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.Kolicina.CustomButton.Name = "";
            this.Kolicina.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Kolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Kolicina.CustomButton.TabIndex = 1;
            this.Kolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Kolicina.CustomButton.UseSelectable = true;
            this.Kolicina.CustomButton.Visible = false;
            this.Kolicina.Lines = new string[0];
            this.Kolicina.Location = new System.Drawing.Point(795, 46);
            this.Kolicina.MaxLength = 32767;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.PasswordChar = '\0';
            this.Kolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Kolicina.SelectedText = "";
            this.Kolicina.SelectionLength = 0;
            this.Kolicina.SelectionStart = 0;
            this.Kolicina.ShortcutsEnabled = true;
            this.Kolicina.Size = new System.Drawing.Size(60, 29);
            this.Kolicina.TabIndex = 11;
            this.Kolicina.UseSelectable = true;
            this.Kolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Kolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Kolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(549, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Utrošeni Materijal";
            // 
            // OdabirMaterijala
            // 
            this.OdabirMaterijala.FormattingEnabled = true;
            this.OdabirMaterijala.ItemHeight = 23;
            this.OdabirMaterijala.Location = new System.Drawing.Point(537, 46);
            this.OdabirMaterijala.Name = "OdabirMaterijala";
            this.OdabirMaterijala.Size = new System.Drawing.Size(168, 29);
            this.OdabirMaterijala.TabIndex = 18;
            this.OdabirMaterijala.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(726, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(143, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Utrošena Količina";
            // 
            // addUse
            // 
            this.addUse.FormattingEnabled = true;
            this.addUse.ItemHeight = 23;
            this.addUse.Location = new System.Drawing.Point(740, 46);
            this.addUse.Name = "addUse";
            this.addUse.Size = new System.Drawing.Size(46, 29);
            this.addUse.TabIndex = 23;
            this.addUse.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(12, 315);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 29;
            // 
            // NazivMjesta
            // 
            this.NazivMjesta.FormattingEnabled = true;
            this.NazivMjesta.ItemHeight = 23;
            this.NazivMjesta.Location = new System.Drawing.Point(223, 32);
            this.NazivMjesta.Name = "NazivMjesta";
            this.NazivMjesta.Size = new System.Drawing.Size(220, 29);
            this.NazivMjesta.TabIndex = 30;
            this.NazivMjesta.UseSelectable = true;
            // 
            // materijalGrid
            // 
            this.materijalGrid.AllowUserToAddRows = false;
            this.materijalGrid.AllowUserToDeleteRows = false;
            this.materijalGrid.AllowUserToResizeRows = false;
            this.materijalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materijalGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materijalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.materijalGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materijalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materijalGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.materijalGrid.EnableHeadersVisualStyles = false;
            this.materijalGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materijalGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materijalGrid.Location = new System.Drawing.Point(500, 94);
            this.materijalGrid.Name = "materijalGrid";
            this.materijalGrid.ReadOnly = true;
            this.materijalGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.materijalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.materijalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materijalGrid.Size = new System.Drawing.Size(400, 380);
            this.materijalGrid.TabIndex = 31;
            this.materijalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evidencijaGrid_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(72, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 25);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Datum";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(223, 77);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(220, 29);
            this.metroDateTime1.TabIndex = 33;
            // 
            // Evidencija_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.materijalGrid);
            this.Controls.Add(this.NazivMjesta);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.addUse);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.OdabirMaterijala);
            this.Controls.Add(this.Kolicina);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Oduzmi);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.tb_opis_posla);
            this.Controls.Add(this.tb_utroseno_vrijeme);
            this.Controls.Add(this.lbl_utroseno_vrijeme);
            this.Controls.Add(this.lbl_naziv_mjesta);
            this.Controls.Add(this.Home);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "Evidencija_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evidencija_dodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.materijalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_mjesta;
        private MetroFramework.Controls.MetroLabel lbl_utroseno_vrijeme;
        private MetroFramework.Controls.MetroTextBox tb_utroseno_vrijeme;
        private System.Windows.Forms.RichTextBox tb_opis_posla;
        private MetroFramework.Controls.MetroLabel lbl_opis_posla;
        private MetroFramework.Controls.MetroButton Potvrdi;
        private MetroFramework.Controls.MetroButton Oduzmi;
        private MetroFramework.Controls.MetroButton Dodaj;
        private MetroFramework.Controls.MetroTextBox Kolicina;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox OdabirMaterijala;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox addUse;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox NazivMjesta;
        private MetroFramework.Controls.MetroGrid materijalGrid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}