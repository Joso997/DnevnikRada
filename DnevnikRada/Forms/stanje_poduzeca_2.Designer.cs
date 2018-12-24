namespace DnevnikRada
{
    partial class stanje_poduzeca_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stanje_poduzeca_2));
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.lbl_randi_sati = new MetroFramework.Controls.MetroLabel();
            this.lbl_ukupna_vrijednost_materijala = new MetroFramework.Controls.MetroLabel();
            this.lbl_broj_evidencija = new MetroFramework.Controls.MetroLabel();
            this.lbl_postotak_mjesecnog_zauzeca = new MetroFramework.Controls.MetroLabel();
            this.tb_radni_sati = new MetroFramework.Controls.MetroTextBox();
            this.tb_ukupna_vrijednost_materijala = new MetroFramework.Controls.MetroTextBox();
            this.tb_broj_evidencija = new MetroFramework.Controls.MetroTextBox();
            this.tb_postotak_mjesecnog_zauzeca = new MetroFramework.Controls.MetroTextBox();
            this.btn_odstupanje_od_normale = new MetroFramework.Controls.MetroButton();
            this.btn_broj_odrzavanja_kroz_vrijeme = new MetroFramework.Controls.MetroButton();
            this.btn_potrosnja_materijala_kroz_vrijeme = new MetroFramework.Controls.MetroButton();
            this.btn_stanje_poduzeca = new MetroFramework.Controls.MetroButton();
            this.lbl_radni_sati = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.Location = new System.Drawing.Point(800, 480);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(100, 100);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseSelectable = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_randi_sati
            // 
            this.lbl_randi_sati.Location = new System.Drawing.Point(0, 0);
            this.lbl_randi_sati.Name = "lbl_randi_sati";
            this.lbl_randi_sati.Size = new System.Drawing.Size(100, 23);
            this.lbl_randi_sati.TabIndex = 13;
            // 
            // lbl_ukupna_vrijednost_materijala
            // 
            this.lbl_ukupna_vrijednost_materijala.AutoSize = true;
            this.lbl_ukupna_vrijednost_materijala.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_ukupna_vrijednost_materijala.Location = new System.Drawing.Point(238, 233);
            this.lbl_ukupna_vrijednost_materijala.Name = "lbl_ukupna_vrijednost_materijala";
            this.lbl_ukupna_vrijednost_materijala.Size = new System.Drawing.Size(230, 25);
            this.lbl_ukupna_vrijednost_materijala.TabIndex = 2;
            this.lbl_ukupna_vrijednost_materijala.Text = "Ukupna Vrijednost Materijala";
            // 
            // lbl_broj_evidencija
            // 
            this.lbl_broj_evidencija.AutoSize = true;
            this.lbl_broj_evidencija.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_broj_evidencija.Location = new System.Drawing.Point(237, 280);
            this.lbl_broj_evidencija.Name = "lbl_broj_evidencija";
            this.lbl_broj_evidencija.Size = new System.Drawing.Size(122, 25);
            this.lbl_broj_evidencija.TabIndex = 3;
            this.lbl_broj_evidencija.Text = "Broj Evidencija";
            // 
            // lbl_postotak_mjesecnog_zauzeca
            // 
            this.lbl_postotak_mjesecnog_zauzeca.AutoSize = true;
            this.lbl_postotak_mjesecnog_zauzeca.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_postotak_mjesecnog_zauzeca.Location = new System.Drawing.Point(237, 327);
            this.lbl_postotak_mjesecnog_zauzeca.Name = "lbl_postotak_mjesecnog_zauzeca";
            this.lbl_postotak_mjesecnog_zauzeca.Size = new System.Drawing.Size(230, 25);
            this.lbl_postotak_mjesecnog_zauzeca.TabIndex = 4;
            this.lbl_postotak_mjesecnog_zauzeca.Text = "Postotak Mjesečnog Zauzeća";
            // 
            // tb_radni_sati
            // 
            // 
            // 
            // 
            this.tb_radni_sati.CustomButton.Image = null;
            this.tb_radni_sati.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tb_radni_sati.CustomButton.Name = "";
            this.tb_radni_sati.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_radni_sati.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_radni_sati.CustomButton.TabIndex = 1;
            this.tb_radni_sati.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_radni_sati.CustomButton.UseSelectable = true;
            this.tb_radni_sati.CustomButton.Visible = false;
            this.tb_radni_sati.Lines = new string[0];
            this.tb_radni_sati.Location = new System.Drawing.Point(671, 186);
            this.tb_radni_sati.MaxLength = 32767;
            this.tb_radni_sati.Name = "tb_radni_sati";
            this.tb_radni_sati.PasswordChar = '\0';
            this.tb_radni_sati.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_radni_sati.SelectedText = "";
            this.tb_radni_sati.SelectionLength = 0;
            this.tb_radni_sati.SelectionStart = 0;
            this.tb_radni_sati.ShortcutsEnabled = true;
            this.tb_radni_sati.Size = new System.Drawing.Size(100, 25);
            this.tb_radni_sati.TabIndex = 5;
            this.tb_radni_sati.UseSelectable = true;
            this.tb_radni_sati.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_radni_sati.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_ukupna_vrijednost_materijala
            // 
            // 
            // 
            // 
            this.tb_ukupna_vrijednost_materijala.CustomButton.Image = null;
            this.tb_ukupna_vrijednost_materijala.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tb_ukupna_vrijednost_materijala.CustomButton.Name = "";
            this.tb_ukupna_vrijednost_materijala.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_ukupna_vrijednost_materijala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ukupna_vrijednost_materijala.CustomButton.TabIndex = 1;
            this.tb_ukupna_vrijednost_materijala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ukupna_vrijednost_materijala.CustomButton.UseSelectable = true;
            this.tb_ukupna_vrijednost_materijala.CustomButton.Visible = false;
            this.tb_ukupna_vrijednost_materijala.Lines = new string[0];
            this.tb_ukupna_vrijednost_materijala.Location = new System.Drawing.Point(671, 233);
            this.tb_ukupna_vrijednost_materijala.MaxLength = 32767;
            this.tb_ukupna_vrijednost_materijala.Name = "tb_ukupna_vrijednost_materijala";
            this.tb_ukupna_vrijednost_materijala.PasswordChar = '\0';
            this.tb_ukupna_vrijednost_materijala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ukupna_vrijednost_materijala.SelectedText = "";
            this.tb_ukupna_vrijednost_materijala.SelectionLength = 0;
            this.tb_ukupna_vrijednost_materijala.SelectionStart = 0;
            this.tb_ukupna_vrijednost_materijala.ShortcutsEnabled = true;
            this.tb_ukupna_vrijednost_materijala.Size = new System.Drawing.Size(100, 25);
            this.tb_ukupna_vrijednost_materijala.TabIndex = 6;
            this.tb_ukupna_vrijednost_materijala.UseSelectable = true;
            this.tb_ukupna_vrijednost_materijala.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ukupna_vrijednost_materijala.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_broj_evidencija
            // 
            // 
            // 
            // 
            this.tb_broj_evidencija.CustomButton.Image = null;
            this.tb_broj_evidencija.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tb_broj_evidencija.CustomButton.Name = "";
            this.tb_broj_evidencija.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_broj_evidencija.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_broj_evidencija.CustomButton.TabIndex = 1;
            this.tb_broj_evidencija.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_broj_evidencija.CustomButton.UseSelectable = true;
            this.tb_broj_evidencija.CustomButton.Visible = false;
            this.tb_broj_evidencija.Lines = new string[0];
            this.tb_broj_evidencija.Location = new System.Drawing.Point(671, 280);
            this.tb_broj_evidencija.MaxLength = 32767;
            this.tb_broj_evidencija.Name = "tb_broj_evidencija";
            this.tb_broj_evidencija.PasswordChar = '\0';
            this.tb_broj_evidencija.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_broj_evidencija.SelectedText = "";
            this.tb_broj_evidencija.SelectionLength = 0;
            this.tb_broj_evidencija.SelectionStart = 0;
            this.tb_broj_evidencija.ShortcutsEnabled = true;
            this.tb_broj_evidencija.Size = new System.Drawing.Size(100, 25);
            this.tb_broj_evidencija.TabIndex = 7;
            this.tb_broj_evidencija.UseSelectable = true;
            this.tb_broj_evidencija.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_broj_evidencija.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_postotak_mjesecnog_zauzeca
            // 
            // 
            // 
            // 
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Image = null;
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Name = "";
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.TabIndex = 1;
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.UseSelectable = true;
            this.tb_postotak_mjesecnog_zauzeca.CustomButton.Visible = false;
            this.tb_postotak_mjesecnog_zauzeca.Lines = new string[0];
            this.tb_postotak_mjesecnog_zauzeca.Location = new System.Drawing.Point(671, 327);
            this.tb_postotak_mjesecnog_zauzeca.MaxLength = 32767;
            this.tb_postotak_mjesecnog_zauzeca.Name = "tb_postotak_mjesecnog_zauzeca";
            this.tb_postotak_mjesecnog_zauzeca.PasswordChar = '\0';
            this.tb_postotak_mjesecnog_zauzeca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_postotak_mjesecnog_zauzeca.SelectedText = "";
            this.tb_postotak_mjesecnog_zauzeca.SelectionLength = 0;
            this.tb_postotak_mjesecnog_zauzeca.SelectionStart = 0;
            this.tb_postotak_mjesecnog_zauzeca.ShortcutsEnabled = true;
            this.tb_postotak_mjesecnog_zauzeca.Size = new System.Drawing.Size(100, 25);
            this.tb_postotak_mjesecnog_zauzeca.TabIndex = 8;
            this.tb_postotak_mjesecnog_zauzeca.UseSelectable = true;
            this.tb_postotak_mjesecnog_zauzeca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_postotak_mjesecnog_zauzeca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_odstupanje_od_normale
            // 
            this.btn_odstupanje_od_normale.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_odstupanje_od_normale.Location = new System.Drawing.Point(1, 362);
            this.btn_odstupanje_od_normale.Name = "btn_odstupanje_od_normale";
            this.btn_odstupanje_od_normale.Size = new System.Drawing.Size(230, 100);
            this.btn_odstupanje_od_normale.TabIndex = 12;
            this.btn_odstupanje_od_normale.Text = "Odstupanje Od Normale";
            this.btn_odstupanje_od_normale.UseSelectable = true;
            this.btn_odstupanje_od_normale.Click += new System.EventHandler(this.btn_odstupanje_od_normale_Click);
            // 
            // btn_broj_odrzavanja_kroz_vrijeme
            // 
            this.btn_broj_odrzavanja_kroz_vrijeme.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_broj_odrzavanja_kroz_vrijeme.Location = new System.Drawing.Point(1, 242);
            this.btn_broj_odrzavanja_kroz_vrijeme.Name = "btn_broj_odrzavanja_kroz_vrijeme";
            this.btn_broj_odrzavanja_kroz_vrijeme.Size = new System.Drawing.Size(230, 100);
            this.btn_broj_odrzavanja_kroz_vrijeme.TabIndex = 11;
            this.btn_broj_odrzavanja_kroz_vrijeme.Text = "Broj Održavanja Kroz Vrijeme";
            this.btn_broj_odrzavanja_kroz_vrijeme.UseSelectable = true;
            this.btn_broj_odrzavanja_kroz_vrijeme.Click += new System.EventHandler(this.btn_broj_odrzavanja_kroz_vrijeme_Click);
            // 
            // btn_potrosnja_materijala_kroz_vrijeme
            // 
            this.btn_potrosnja_materijala_kroz_vrijeme.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_potrosnja_materijala_kroz_vrijeme.Location = new System.Drawing.Point(1, 121);
            this.btn_potrosnja_materijala_kroz_vrijeme.Name = "btn_potrosnja_materijala_kroz_vrijeme";
            this.btn_potrosnja_materijala_kroz_vrijeme.Size = new System.Drawing.Size(230, 100);
            this.btn_potrosnja_materijala_kroz_vrijeme.TabIndex = 10;
            this.btn_potrosnja_materijala_kroz_vrijeme.Text = "Potrošnja Materijala Kroz Vrijeme";
            this.btn_potrosnja_materijala_kroz_vrijeme.UseSelectable = true;
            this.btn_potrosnja_materijala_kroz_vrijeme.Click += new System.EventHandler(this.btn_potrosnja_materijala_kroz_vrijeme_Click);
            // 
            // btn_stanje_poduzeca
            // 
            this.btn_stanje_poduzeca.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_stanje_poduzeca.Location = new System.Drawing.Point(1, 1);
            this.btn_stanje_poduzeca.Name = "btn_stanje_poduzeca";
            this.btn_stanje_poduzeca.Size = new System.Drawing.Size(230, 100);
            this.btn_stanje_poduzeca.TabIndex = 9;
            this.btn_stanje_poduzeca.Text = "Stanje Poduzeća";
            this.btn_stanje_poduzeca.UseSelectable = true;
            this.btn_stanje_poduzeca.Click += new System.EventHandler(this.btn_stanje_poduzeca_Click);
            // 
            // lbl_radni_sati
            // 
            this.lbl_radni_sati.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_radni_sati.Location = new System.Drawing.Point(237, 186);
            this.lbl_radni_sati.Name = "lbl_radni_sati";
            this.lbl_radni_sati.Size = new System.Drawing.Size(230, 25);
            this.lbl_radni_sati.TabIndex = 14;
            this.lbl_radni_sati.Text = "Radni Sati";
            // 
            // stanje_poduzeca_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.lbl_radni_sati);
            this.Controls.Add(this.btn_odstupanje_od_normale);
            this.Controls.Add(this.btn_broj_odrzavanja_kroz_vrijeme);
            this.Controls.Add(this.btn_potrosnja_materijala_kroz_vrijeme);
            this.Controls.Add(this.btn_stanje_poduzeca);
            this.Controls.Add(this.tb_postotak_mjesecnog_zauzeca);
            this.Controls.Add(this.tb_broj_evidencija);
            this.Controls.Add(this.tb_ukupna_vrijednost_materijala);
            this.Controls.Add(this.tb_radni_sati);
            this.Controls.Add(this.lbl_postotak_mjesecnog_zauzeca);
            this.Controls.Add(this.lbl_broj_evidencija);
            this.Controls.Add(this.lbl_ukupna_vrijednost_materijala);
            this.Controls.Add(this.lbl_randi_sati);
            this.Controls.Add(this.btn_home);
            this.Name = "stanje_poduzeca_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stanje_poduzeca_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stanje_poduzeca_2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroLabel lbl_randi_sati;
        private MetroFramework.Controls.MetroLabel lbl_ukupna_vrijednost_materijala;
        private MetroFramework.Controls.MetroLabel lbl_broj_evidencija;
        private MetroFramework.Controls.MetroLabel lbl_postotak_mjesecnog_zauzeca;
        private MetroFramework.Controls.MetroTextBox tb_radni_sati;
        private MetroFramework.Controls.MetroTextBox tb_ukupna_vrijednost_materijala;
        private MetroFramework.Controls.MetroTextBox tb_broj_evidencija;
        private MetroFramework.Controls.MetroTextBox tb_postotak_mjesecnog_zauzeca;
        private MetroFramework.Controls.MetroButton btn_odstupanje_od_normale;
        private MetroFramework.Controls.MetroButton btn_broj_odrzavanja_kroz_vrijeme;
        private MetroFramework.Controls.MetroButton btn_potrosnja_materijala_kroz_vrijeme;
        private MetroFramework.Controls.MetroButton btn_stanje_poduzeca;
        private MetroFramework.Controls.MetroLabel lbl_radni_sati;
    }
}