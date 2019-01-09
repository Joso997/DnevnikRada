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
            this.btn_trash = new MetroFramework.Controls.MetroButton();
            this.Dodaj = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox9 = new MetroFramework.Controls.MetroComboBox();
            this.materijalGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.materijalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.lbl_naziv_mjesta.Location = new System.Drawing.Point(12, 90);
            this.lbl_naziv_mjesta.Name = "lbl_naziv_mjesta";
            this.lbl_naziv_mjesta.Size = new System.Drawing.Size(108, 25);
            this.lbl_naziv_mjesta.TabIndex = 1;
            this.lbl_naziv_mjesta.Text = "Naziv Mjesta";
            // 
            // lbl_utroseno_vrijeme
            // 
            this.lbl_utroseno_vrijeme.AutoSize = true;
            this.lbl_utroseno_vrijeme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_utroseno_vrijeme.Location = new System.Drawing.Point(12, 137);
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
            this.tb_utroseno_vrijeme.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_utroseno_vrijeme.CustomButton.Name = "";
            this.tb_utroseno_vrijeme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_utroseno_vrijeme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_utroseno_vrijeme.CustomButton.TabIndex = 1;
            this.tb_utroseno_vrijeme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_utroseno_vrijeme.CustomButton.UseSelectable = true;
            this.tb_utroseno_vrijeme.CustomButton.Visible = false;
            this.tb_utroseno_vrijeme.Lines = new string[0];
            this.tb_utroseno_vrijeme.Location = new System.Drawing.Point(168, 139);
            this.tb_utroseno_vrijeme.MaxLength = 32767;
            this.tb_utroseno_vrijeme.Name = "tb_utroseno_vrijeme";
            this.tb_utroseno_vrijeme.PasswordChar = '\0';
            this.tb_utroseno_vrijeme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_utroseno_vrijeme.SelectedText = "";
            this.tb_utroseno_vrijeme.SelectionLength = 0;
            this.tb_utroseno_vrijeme.SelectionStart = 0;
            this.tb_utroseno_vrijeme.ShortcutsEnabled = true;
            this.tb_utroseno_vrijeme.Size = new System.Drawing.Size(200, 23);
            this.tb_utroseno_vrijeme.TabIndex = 4;
            this.tb_utroseno_vrijeme.UseSelectable = true;
            this.tb_utroseno_vrijeme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_utroseno_vrijeme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_opis_posla
            // 
            this.tb_opis_posla.Location = new System.Drawing.Point(12, 235);
            this.tb_opis_posla.Name = "tb_opis_posla";
            this.tb_opis_posla.Size = new System.Drawing.Size(356, 333);
            this.tb_opis_posla.TabIndex = 5;
            this.tb_opis_posla.Text = resources.GetString("tb_opis_posla.Text");
            // 
            // lbl_opis_posla
            // 
            this.lbl_opis_posla.AutoSize = true;
            this.lbl_opis_posla.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_opis_posla.Location = new System.Drawing.Point(140, 207);
            this.lbl_opis_posla.Name = "lbl_opis_posla";
            this.lbl_opis_posla.Size = new System.Drawing.Size(91, 25);
            this.lbl_opis_posla.TabIndex = 6;
            this.lbl_opis_posla.Text = "Opis Posla";
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(701, 480);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(100, 100);
            this.Potvrdi.TabIndex = 7;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseSelectable = true;
            this.Potvrdi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // btn_trash
            // 
            this.btn_trash.Location = new System.Drawing.Point(602, 480);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(100, 100);
            this.btn_trash.TabIndex = 8;
            this.btn_trash.Text = "trash";
            this.btn_trash.UseSelectable = true;
            // 
            // Dodaj
            // 
            this.Dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dodaj.BackgroundImage")));
            this.Dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dodaj.Location = new System.Drawing.Point(503, 480);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(100, 100);
            this.Dodaj.TabIndex = 9;
            this.Dodaj.UseSelectable = true;
            this.Dodaj.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(819, 92);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(59, 23);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(426, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Utrosen Materijal 1";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(587, 92);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(168, 29);
            this.metroComboBox1.TabIndex = 18;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(754, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Utrosen Kolicina";
            // 
            // metroComboBox5
            // 
            this.metroComboBox5.FormattingEnabled = true;
            this.metroComboBox5.ItemHeight = 23;
            this.metroComboBox5.Location = new System.Drawing.Point(767, 92);
            this.metroComboBox5.Name = "metroComboBox5";
            this.metroComboBox5.Size = new System.Drawing.Size(46, 29);
            this.metroComboBox5.TabIndex = 23;
            this.metroComboBox5.UseSelectable = true;
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
            // metroComboBox9
            // 
            this.metroComboBox9.FormattingEnabled = true;
            this.metroComboBox9.ItemHeight = 23;
            this.metroComboBox9.Location = new System.Drawing.Point(168, 92);
            this.metroComboBox9.Name = "metroComboBox9";
            this.metroComboBox9.Size = new System.Drawing.Size(200, 29);
            this.metroComboBox9.TabIndex = 30;
            this.metroComboBox9.UseSelectable = true;
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
            this.materijalGrid.Location = new System.Drawing.Point(426, 137);
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
            this.materijalGrid.Size = new System.Drawing.Size(462, 325);
            this.materijalGrid.TabIndex = 31;
            this.materijalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evidencijaGrid_CellClick);
            // 
            // Evidencija_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.materijalGrid);
            this.Controls.Add(this.metroComboBox9);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroComboBox5);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.tb_opis_posla);
            this.Controls.Add(this.tb_utroseno_vrijeme);
            this.Controls.Add(this.lbl_utroseno_vrijeme);
            this.Controls.Add(this.lbl_naziv_mjesta);
            this.Controls.Add(this.Home);
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
        private MetroFramework.Controls.MetroButton btn_trash;
        private MetroFramework.Controls.MetroButton Dodaj;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox metroComboBox9;
        private MetroFramework.Controls.MetroGrid materijalGrid;
    }
}