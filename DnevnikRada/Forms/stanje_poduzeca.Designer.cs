namespace DnevnikRada.Forms
{
    partial class Stanje_Poduzeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stanje_Poduzeca));
            this.btnStanjePoduzeca = new MetroFramework.Controls.MetroButton();
            this.btnPotrosnjaMaterijalaKrozVrijeme = new MetroFramework.Controls.MetroButton();
            this.btnBrojOdrzavanjaKrozVrijeme = new MetroFramework.Controls.MetroButton();
            this.btnOdstupanjeOdNormale = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnStanjePoduzeca
            // 
            this.btnStanjePoduzeca.Location = new System.Drawing.Point(632, 26);
            this.btnStanjePoduzeca.Name = "btnStanjePoduzeca";
            this.btnStanjePoduzeca.Size = new System.Drawing.Size(266, 100);
            this.btnStanjePoduzeca.TabIndex = 18;
            this.btnStanjePoduzeca.Text = "Stanje Poduzeća";
            this.btnStanjePoduzeca.UseSelectable = true;
            this.btnStanjePoduzeca.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // btnPotrosnjaMaterijalaKrozVrijeme
            // 
            this.btnPotrosnjaMaterijalaKrozVrijeme.Location = new System.Drawing.Point(632, 135);
            this.btnPotrosnjaMaterijalaKrozVrijeme.Name = "btnPotrosnjaMaterijalaKrozVrijeme";
            this.btnPotrosnjaMaterijalaKrozVrijeme.Size = new System.Drawing.Size(266, 100);
            this.btnPotrosnjaMaterijalaKrozVrijeme.TabIndex = 19;
            this.btnPotrosnjaMaterijalaKrozVrijeme.Text = "Potrošnja Materijala Kroz Vrijeme";
            this.btnPotrosnjaMaterijalaKrozVrijeme.UseSelectable = true;
            this.btnPotrosnjaMaterijalaKrozVrijeme.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // btnBrojOdrzavanjaKrozVrijeme
            // 
            this.btnBrojOdrzavanjaKrozVrijeme.Location = new System.Drawing.Point(632, 244);
            this.btnBrojOdrzavanjaKrozVrijeme.Name = "btnBrojOdrzavanjaKrozVrijeme";
            this.btnBrojOdrzavanjaKrozVrijeme.Size = new System.Drawing.Size(266, 100);
            this.btnBrojOdrzavanjaKrozVrijeme.TabIndex = 20;
            this.btnBrojOdrzavanjaKrozVrijeme.Text = "Broj Održavanja Kroz Vrijeme";
            this.btnBrojOdrzavanjaKrozVrijeme.UseSelectable = true;
            this.btnBrojOdrzavanjaKrozVrijeme.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // btnOdstupanjeOdNormale
            // 
            this.btnOdstupanjeOdNormale.Location = new System.Drawing.Point(632, 353);
            this.btnOdstupanjeOdNormale.Name = "btnOdstupanjeOdNormale";
            this.btnOdstupanjeOdNormale.Size = new System.Drawing.Size(266, 100);
            this.btnOdstupanjeOdNormale.TabIndex = 21;
            this.btnOdstupanjeOdNormale.Text = "Odstupanje Od Normale";
            this.btnOdstupanjeOdNormale.UseSelectable = true;
            this.btnOdstupanjeOdNormale.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(620, 578);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Home.Location = new System.Drawing.Point(800, 480);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(100, 100);
            this.Home.TabIndex = 24;
            this.Home.UseSelectable = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Stanje_Poduzeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnOdstupanjeOdNormale);
            this.Controls.Add(this.btnBrojOdrzavanjaKrozVrijeme);
            this.Controls.Add(this.btnPotrosnjaMaterijalaKrozVrijeme);
            this.Controls.Add(this.btnStanjePoduzeca);
            this.IsMdiContainer = true;
            this.Name = "Stanje_Poduzeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StanjePoduzecaBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStanjePoduzeca;
        private MetroFramework.Controls.MetroButton btnPotrosnjaMaterijalaKrozVrijeme;
        private MetroFramework.Controls.MetroButton btnBrojOdrzavanjaKrozVrijeme;
        private MetroFramework.Controls.MetroButton btnOdstupanjeOdNormale;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Home;
    }
}