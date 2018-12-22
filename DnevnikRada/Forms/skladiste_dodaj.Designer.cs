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
            this.home = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.naziv_materijala = new MetroFramework.Controls.MetroTextBox();
            this.proizvodac = new MetroFramework.Controls.MetroTextBox();
            this.mjerna_jedinica = new MetroFramework.Controls.MetroTextBox();
            this.potvrdi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.RoyalBlue;
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home.Location = new System.Drawing.Point(800, 480);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(100, 100);
            this.home.TabIndex = 0;
            this.home.UseSelectable = true;
            this.home.Click += new System.EventHandler(this.Home_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(236, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Naziv Materijala";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(236, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Proizvođač";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(236, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Mjerna Jedinica";
            // 
            // naziv_materijala
            // 
            // 
            // 
            // 
            this.naziv_materijala.CustomButton.Image = null;
            this.naziv_materijala.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.naziv_materijala.CustomButton.Name = "";
            this.naziv_materijala.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.naziv_materijala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.naziv_materijala.CustomButton.TabIndex = 1;
            this.naziv_materijala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.naziv_materijala.CustomButton.UseSelectable = true;
            this.naziv_materijala.CustomButton.Visible = false;
            this.naziv_materijala.Lines = new string[] {
        "naziv_materijala"};
            this.naziv_materijala.Location = new System.Drawing.Point(445, 130);
            this.naziv_materijala.MaxLength = 32767;
            this.naziv_materijala.Name = "naziv_materijala";
            this.naziv_materijala.PasswordChar = '\0';
            this.naziv_materijala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.naziv_materijala.SelectedText = "";
            this.naziv_materijala.SelectionLength = 0;
            this.naziv_materijala.SelectionStart = 0;
            this.naziv_materijala.ShortcutsEnabled = true;
            this.naziv_materijala.Size = new System.Drawing.Size(200, 23);
            this.naziv_materijala.TabIndex = 5;
            this.naziv_materijala.Text = "naziv_materijala";
            this.naziv_materijala.UseSelectable = true;
            this.naziv_materijala.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.naziv_materijala.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // proizvodac
            // 
            // 
            // 
            // 
            this.proizvodac.CustomButton.Image = null;
            this.proizvodac.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.proizvodac.CustomButton.Name = "";
            this.proizvodac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.proizvodac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.proizvodac.CustomButton.TabIndex = 1;
            this.proizvodac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.proizvodac.CustomButton.UseSelectable = true;
            this.proizvodac.CustomButton.Visible = false;
            this.proizvodac.Lines = new string[] {
        "metroTextBox2"};
            this.proizvodac.Location = new System.Drawing.Point(445, 172);
            this.proizvodac.MaxLength = 32767;
            this.proizvodac.Name = "proizvodac";
            this.proizvodac.PasswordChar = '\0';
            this.proizvodac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.proizvodac.SelectedText = "";
            this.proizvodac.SelectionLength = 0;
            this.proizvodac.SelectionStart = 0;
            this.proizvodac.ShortcutsEnabled = true;
            this.proizvodac.Size = new System.Drawing.Size(200, 23);
            this.proizvodac.TabIndex = 6;
            this.proizvodac.Text = "metroTextBox2";
            this.proizvodac.UseSelectable = true;
            this.proizvodac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.proizvodac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mjerna_jedinica
            // 
            // 
            // 
            // 
            this.mjerna_jedinica.CustomButton.Image = null;
            this.mjerna_jedinica.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mjerna_jedinica.CustomButton.Name = "";
            this.mjerna_jedinica.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mjerna_jedinica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mjerna_jedinica.CustomButton.TabIndex = 1;
            this.mjerna_jedinica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mjerna_jedinica.CustomButton.UseSelectable = true;
            this.mjerna_jedinica.CustomButton.Visible = false;
            this.mjerna_jedinica.Lines = new string[] {
        "metroTextBox3"};
            this.mjerna_jedinica.Location = new System.Drawing.Point(445, 215);
            this.mjerna_jedinica.MaxLength = 32767;
            this.mjerna_jedinica.Name = "mjerna_jedinica";
            this.mjerna_jedinica.PasswordChar = '\0';
            this.mjerna_jedinica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mjerna_jedinica.SelectedText = "";
            this.mjerna_jedinica.SelectionLength = 0;
            this.mjerna_jedinica.SelectionStart = 0;
            this.mjerna_jedinica.ShortcutsEnabled = true;
            this.mjerna_jedinica.Size = new System.Drawing.Size(200, 23);
            this.mjerna_jedinica.TabIndex = 7;
            this.mjerna_jedinica.Text = "metroTextBox3";
            this.mjerna_jedinica.UseSelectable = true;
            this.mjerna_jedinica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mjerna_jedinica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // potvrdi
            // 
            this.potvrdi.Location = new System.Drawing.Point(545, 258);
            this.potvrdi.Name = "potvrdi";
            this.potvrdi.Size = new System.Drawing.Size(100, 100);
            this.potvrdi.TabIndex = 8;
            this.potvrdi.Text = "Potvrdi";
            this.potvrdi.UseSelectable = true;
            this.potvrdi.Click += new System.EventHandler(this.Potvrdi_Click);
            // 
            // skladiste_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.potvrdi);
            this.Controls.Add(this.mjerna_jedinica);
            this.Controls.Add(this.proizvodac);
            this.Controls.Add(this.naziv_materijala);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.home);
            this.Name = "skladiste_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skladiste_dodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Skladiste_dodaj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton home;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox naziv_materijala;
        private MetroFramework.Controls.MetroTextBox proizvodac;
        private MetroFramework.Controls.MetroTextBox mjerna_jedinica;
        private MetroFramework.Controls.MetroButton potvrdi;
    }
}