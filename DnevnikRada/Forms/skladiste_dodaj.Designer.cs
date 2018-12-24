namespace DnevnikRada
{
    partial class Skladiste_dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skladiste_dodaj));
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_materijala = new MetroFramework.Controls.MetroLabel();
            this.lbl_proizvodac = new MetroFramework.Controls.MetroLabel();
            this.lbl_mjerna_jedinica = new MetroFramework.Controls.MetroLabel();
            this.tb_naziv_materijala = new MetroFramework.Controls.MetroTextBox();
            this.tb_proizvodac = new MetroFramework.Controls.MetroTextBox();
            this.tb_mjerna_jedinica = new MetroFramework.Controls.MetroTextBox();
            this.btn_potvrdi = new MetroFramework.Controls.MetroButton();
            this.lbl_kolicina = new MetroFramework.Controls.MetroLabel();
            this.tb_kolicina = new MetroFramework.Controls.MetroTextBox();
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
            // lbl_naziv_materijala
            // 
            this.lbl_naziv_materijala.AutoSize = true;
            this.lbl_naziv_materijala.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_naziv_materijala.Location = new System.Drawing.Point(236, 128);
            this.lbl_naziv_materijala.Name = "lbl_naziv_materijala";
            this.lbl_naziv_materijala.Size = new System.Drawing.Size(133, 25);
            this.lbl_naziv_materijala.TabIndex = 2;
            this.lbl_naziv_materijala.Text = "Naziv Materijala";
            // 
            // lbl_proizvodac
            // 
            this.lbl_proizvodac.AutoSize = true;
            this.lbl_proizvodac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_proizvodac.Location = new System.Drawing.Point(236, 170);
            this.lbl_proizvodac.Name = "lbl_proizvodac";
            this.lbl_proizvodac.Size = new System.Drawing.Size(95, 25);
            this.lbl_proizvodac.TabIndex = 3;
            this.lbl_proizvodac.Text = "Proizvođač";
            // 
            // lbl_mjerna_jedinica
            // 
            this.lbl_mjerna_jedinica.AutoSize = true;
            this.lbl_mjerna_jedinica.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mjerna_jedinica.Location = new System.Drawing.Point(236, 213);
            this.lbl_mjerna_jedinica.Name = "lbl_mjerna_jedinica";
            this.lbl_mjerna_jedinica.Size = new System.Drawing.Size(130, 25);
            this.lbl_mjerna_jedinica.TabIndex = 4;
            this.lbl_mjerna_jedinica.Text = "Mjerna Jedinica";
            // 
            // tb_naziv_materijala
            // 
            // 
            // 
            // 
            this.tb_naziv_materijala.CustomButton.Image = null;
            this.tb_naziv_materijala.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_naziv_materijala.CustomButton.Name = "";
            this.tb_naziv_materijala.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_naziv_materijala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_naziv_materijala.CustomButton.TabIndex = 1;
            this.tb_naziv_materijala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_naziv_materijala.CustomButton.UseSelectable = true;
            this.tb_naziv_materijala.CustomButton.Visible = false;
            this.tb_naziv_materijala.Lines = new string[0];
            this.tb_naziv_materijala.Location = new System.Drawing.Point(445, 130);
            this.tb_naziv_materijala.MaxLength = 32767;
            this.tb_naziv_materijala.Name = "tb_naziv_materijala";
            this.tb_naziv_materijala.PasswordChar = '\0';
            this.tb_naziv_materijala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_naziv_materijala.SelectedText = "";
            this.tb_naziv_materijala.SelectionLength = 0;
            this.tb_naziv_materijala.SelectionStart = 0;
            this.tb_naziv_materijala.ShortcutsEnabled = true;
            this.tb_naziv_materijala.Size = new System.Drawing.Size(200, 23);
            this.tb_naziv_materijala.TabIndex = 5;
            this.tb_naziv_materijala.UseSelectable = true;
            this.tb_naziv_materijala.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_naziv_materijala.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_proizvodac
            // 
            // 
            // 
            // 
            this.tb_proizvodac.CustomButton.Image = null;
            this.tb_proizvodac.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_proizvodac.CustomButton.Name = "";
            this.tb_proizvodac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_proizvodac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_proizvodac.CustomButton.TabIndex = 1;
            this.tb_proizvodac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_proizvodac.CustomButton.UseSelectable = true;
            this.tb_proizvodac.CustomButton.Visible = false;
            this.tb_proizvodac.Lines = new string[0];
            this.tb_proizvodac.Location = new System.Drawing.Point(445, 172);
            this.tb_proizvodac.MaxLength = 32767;
            this.tb_proizvodac.Name = "tb_proizvodac";
            this.tb_proizvodac.PasswordChar = '\0';
            this.tb_proizvodac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_proizvodac.SelectedText = "";
            this.tb_proizvodac.SelectionLength = 0;
            this.tb_proizvodac.SelectionStart = 0;
            this.tb_proizvodac.ShortcutsEnabled = true;
            this.tb_proizvodac.Size = new System.Drawing.Size(200, 23);
            this.tb_proizvodac.TabIndex = 6;
            this.tb_proizvodac.UseSelectable = true;
            this.tb_proizvodac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_proizvodac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_mjerna_jedinica
            // 
            // 
            // 
            // 
            this.tb_mjerna_jedinica.CustomButton.Image = null;
            this.tb_mjerna_jedinica.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_mjerna_jedinica.CustomButton.Name = "";
            this.tb_mjerna_jedinica.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_mjerna_jedinica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_mjerna_jedinica.CustomButton.TabIndex = 1;
            this.tb_mjerna_jedinica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mjerna_jedinica.CustomButton.UseSelectable = true;
            this.tb_mjerna_jedinica.CustomButton.Visible = false;
            this.tb_mjerna_jedinica.Lines = new string[0];
            this.tb_mjerna_jedinica.Location = new System.Drawing.Point(445, 215);
            this.tb_mjerna_jedinica.MaxLength = 32767;
            this.tb_mjerna_jedinica.Name = "tb_mjerna_jedinica";
            this.tb_mjerna_jedinica.PasswordChar = '\0';
            this.tb_mjerna_jedinica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mjerna_jedinica.SelectedText = "";
            this.tb_mjerna_jedinica.SelectionLength = 0;
            this.tb_mjerna_jedinica.SelectionStart = 0;
            this.tb_mjerna_jedinica.ShortcutsEnabled = true;
            this.tb_mjerna_jedinica.Size = new System.Drawing.Size(200, 23);
            this.tb_mjerna_jedinica.TabIndex = 7;
            this.tb_mjerna_jedinica.UseSelectable = true;
            this.tb_mjerna_jedinica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_mjerna_jedinica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.Location = new System.Drawing.Point(545, 310);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(100, 100);
            this.btn_potvrdi.TabIndex = 8;
            this.btn_potvrdi.Text = "Potvrdi";
            this.btn_potvrdi.UseSelectable = true;
            this.btn_potvrdi.Click += new System.EventHandler(this.btn_potvrdi_Click);
            // 
            // lbl_kolicina
            // 
            this.lbl_kolicina.AutoSize = true;
            this.lbl_kolicina.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_kolicina.Location = new System.Drawing.Point(236, 257);
            this.lbl_kolicina.Name = "lbl_kolicina";
            this.lbl_kolicina.Size = new System.Drawing.Size(70, 25);
            this.lbl_kolicina.TabIndex = 9;
            this.lbl_kolicina.Text = "Kolicina";
            // 
            // tb_kolicina
            // 
            // 
            // 
            // 
            this.tb_kolicina.CustomButton.Image = null;
            this.tb_kolicina.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_kolicina.CustomButton.Name = "";
            this.tb_kolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_kolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_kolicina.CustomButton.TabIndex = 1;
            this.tb_kolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_kolicina.CustomButton.UseSelectable = true;
            this.tb_kolicina.CustomButton.Visible = false;
            this.tb_kolicina.Lines = new string[0];
            this.tb_kolicina.Location = new System.Drawing.Point(445, 257);
            this.tb_kolicina.MaxLength = 32767;
            this.tb_kolicina.Name = "tb_kolicina";
            this.tb_kolicina.PasswordChar = '\0';
            this.tb_kolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_kolicina.SelectedText = "";
            this.tb_kolicina.SelectionLength = 0;
            this.tb_kolicina.SelectionStart = 0;
            this.tb_kolicina.ShortcutsEnabled = true;
            this.tb_kolicina.Size = new System.Drawing.Size(200, 23);
            this.tb_kolicina.TabIndex = 10;
            this.tb_kolicina.UseSelectable = true;
            this.tb_kolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_kolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Skladiste_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.tb_kolicina);
            this.Controls.Add(this.lbl_kolicina);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.tb_mjerna_jedinica);
            this.Controls.Add(this.tb_proizvodac);
            this.Controls.Add(this.tb_naziv_materijala);
            this.Controls.Add(this.lbl_mjerna_jedinica);
            this.Controls.Add(this.lbl_proizvodac);
            this.Controls.Add(this.lbl_naziv_materijala);
            this.Controls.Add(this.btn_home);
            this.Name = "Skladiste_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skladiste_dodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Skladiste_dodaj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_materijala;
        private MetroFramework.Controls.MetroLabel lbl_proizvodac;
        private MetroFramework.Controls.MetroLabel lbl_mjerna_jedinica;
        private MetroFramework.Controls.MetroTextBox tb_naziv_materijala;
        private MetroFramework.Controls.MetroTextBox tb_proizvodac;
        private MetroFramework.Controls.MetroTextBox tb_mjerna_jedinica;
        private MetroFramework.Controls.MetroButton btn_potvrdi;
        private MetroFramework.Controls.MetroLabel lbl_kolicina;
        private MetroFramework.Controls.MetroTextBox tb_kolicina;
    }
}