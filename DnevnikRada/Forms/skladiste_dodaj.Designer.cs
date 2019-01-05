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
            this.Home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_materijala = new MetroFramework.Controls.MetroLabel();
            this.lbl_proizvodac = new MetroFramework.Controls.MetroLabel();
            this.lbl_mjerna_jedinica = new MetroFramework.Controls.MetroLabel();
            this.tb_naziv_materijala = new MetroFramework.Controls.MetroTextBox();
            this.tb_proizvodac = new MetroFramework.Controls.MetroTextBox();
            this.tb_mjerna_jedinica = new MetroFramework.Controls.MetroTextBox();
            this.Potvrdi = new MetroFramework.Controls.MetroButton();
            this.lbl_kolicina = new MetroFramework.Controls.MetroLabel();
            this.tb_kolicina = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // lbl_naziv_materijala
            // 
            this.lbl_naziv_materijala.AutoSize = true;
            this.lbl_naziv_materijala.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_naziv_materijala.Location = new System.Drawing.Point(219, 178);
            this.lbl_naziv_materijala.Name = "lbl_naziv_materijala";
            this.lbl_naziv_materijala.Size = new System.Drawing.Size(133, 25);
            this.lbl_naziv_materijala.TabIndex = 2;
            this.lbl_naziv_materijala.Text = "Naziv Materijala";
            // 
            // lbl_proizvodac
            // 
            this.lbl_proizvodac.AutoSize = true;
            this.lbl_proizvodac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_proizvodac.Location = new System.Drawing.Point(219, 220);
            this.lbl_proizvodac.Name = "lbl_proizvodac";
            this.lbl_proizvodac.Size = new System.Drawing.Size(95, 25);
            this.lbl_proizvodac.TabIndex = 3;
            this.lbl_proizvodac.Text = "Proizvođač";
            // 
            // lbl_mjerna_jedinica
            // 
            this.lbl_mjerna_jedinica.AutoSize = true;
            this.lbl_mjerna_jedinica.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_mjerna_jedinica.Location = new System.Drawing.Point(219, 263);
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
            this.tb_naziv_materijala.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.tb_naziv_materijala.CustomButton.Name = "";
            this.tb_naziv_materijala.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_naziv_materijala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_naziv_materijala.CustomButton.TabIndex = 1;
            this.tb_naziv_materijala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_naziv_materijala.CustomButton.UseSelectable = true;
            this.tb_naziv_materijala.CustomButton.Visible = false;
            this.tb_naziv_materijala.Lines = new string[0];
            this.tb_naziv_materijala.Location = new System.Drawing.Point(362, 180);
            this.tb_naziv_materijala.MaxLength = 32767;
            this.tb_naziv_materijala.Name = "tb_naziv_materijala";
            this.tb_naziv_materijala.PasswordChar = '\0';
            this.tb_naziv_materijala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_naziv_materijala.SelectedText = "";
            this.tb_naziv_materijala.SelectionLength = 0;
            this.tb_naziv_materijala.SelectionStart = 0;
            this.tb_naziv_materijala.ShortcutsEnabled = true;
            this.tb_naziv_materijala.Size = new System.Drawing.Size(320, 23);
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
            this.tb_proizvodac.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.tb_proizvodac.CustomButton.Name = "";
            this.tb_proizvodac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_proizvodac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_proizvodac.CustomButton.TabIndex = 1;
            this.tb_proizvodac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_proizvodac.CustomButton.UseSelectable = true;
            this.tb_proizvodac.CustomButton.Visible = false;
            this.tb_proizvodac.Lines = new string[0];
            this.tb_proizvodac.Location = new System.Drawing.Point(362, 222);
            this.tb_proizvodac.MaxLength = 32767;
            this.tb_proizvodac.Name = "tb_proizvodac";
            this.tb_proizvodac.PasswordChar = '\0';
            this.tb_proizvodac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_proizvodac.SelectedText = "";
            this.tb_proizvodac.SelectionLength = 0;
            this.tb_proizvodac.SelectionStart = 0;
            this.tb_proizvodac.ShortcutsEnabled = true;
            this.tb_proizvodac.Size = new System.Drawing.Size(320, 23);
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
            this.tb_mjerna_jedinica.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.tb_mjerna_jedinica.CustomButton.Name = "";
            this.tb_mjerna_jedinica.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_mjerna_jedinica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_mjerna_jedinica.CustomButton.TabIndex = 1;
            this.tb_mjerna_jedinica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mjerna_jedinica.CustomButton.UseSelectable = true;
            this.tb_mjerna_jedinica.CustomButton.Visible = false;
            this.tb_mjerna_jedinica.Lines = new string[0];
            this.tb_mjerna_jedinica.Location = new System.Drawing.Point(362, 265);
            this.tb_mjerna_jedinica.MaxLength = 32767;
            this.tb_mjerna_jedinica.Name = "tb_mjerna_jedinica";
            this.tb_mjerna_jedinica.PasswordChar = '\0';
            this.tb_mjerna_jedinica.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mjerna_jedinica.SelectedText = "";
            this.tb_mjerna_jedinica.SelectionLength = 0;
            this.tb_mjerna_jedinica.SelectionStart = 0;
            this.tb_mjerna_jedinica.ShortcutsEnabled = true;
            this.tb_mjerna_jedinica.Size = new System.Drawing.Size(320, 23);
            this.tb_mjerna_jedinica.TabIndex = 7;
            this.tb_mjerna_jedinica.UseSelectable = true;
            this.tb_mjerna_jedinica.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_mjerna_jedinica.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(581, 350);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(100, 50);
            this.Potvrdi.TabIndex = 8;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseSelectable = true;
            this.Potvrdi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // lbl_kolicina
            // 
            this.lbl_kolicina.AutoSize = true;
            this.lbl_kolicina.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_kolicina.Location = new System.Drawing.Point(219, 305);
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
            this.tb_kolicina.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.tb_kolicina.CustomButton.Name = "";
            this.tb_kolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_kolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_kolicina.CustomButton.TabIndex = 1;
            this.tb_kolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_kolicina.CustomButton.UseSelectable = true;
            this.tb_kolicina.CustomButton.Visible = false;
            this.tb_kolicina.Lines = new string[0];
            this.tb_kolicina.Location = new System.Drawing.Point(362, 307);
            this.tb_kolicina.MaxLength = 32767;
            this.tb_kolicina.Name = "tb_kolicina";
            this.tb_kolicina.PasswordChar = '\0';
            this.tb_kolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_kolicina.SelectedText = "";
            this.tb_kolicina.SelectionLength = 0;
            this.tb_kolicina.SelectionStart = 0;
            this.tb_kolicina.ShortcutsEnabled = true;
            this.tb_kolicina.Size = new System.Drawing.Size(320, 23);
            this.tb_kolicina.TabIndex = 10;
            this.tb_kolicina.UseSelectable = true;
            this.tb_kolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_kolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(407, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dodavanje U Skladište";
            // 
            // Skladiste_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kolicina);
            this.Controls.Add(this.lbl_kolicina);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.tb_mjerna_jedinica);
            this.Controls.Add(this.tb_proizvodac);
            this.Controls.Add(this.tb_naziv_materijala);
            this.Controls.Add(this.lbl_mjerna_jedinica);
            this.Controls.Add(this.lbl_proizvodac);
            this.Controls.Add(this.lbl_naziv_materijala);
            this.Controls.Add(this.Home);
            this.Name = "Skladiste_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skladiste_dodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_materijala;
        private MetroFramework.Controls.MetroLabel lbl_proizvodac;
        private MetroFramework.Controls.MetroLabel lbl_mjerna_jedinica;
        private MetroFramework.Controls.MetroTextBox tb_naziv_materijala;
        private MetroFramework.Controls.MetroTextBox tb_proizvodac;
        private MetroFramework.Controls.MetroTextBox tb_mjerna_jedinica;
        private MetroFramework.Controls.MetroButton Potvrdi;
        private MetroFramework.Controls.MetroLabel lbl_kolicina;
        private MetroFramework.Controls.MetroTextBox tb_kolicina;
        private System.Windows.Forms.Label label1;
    }
}