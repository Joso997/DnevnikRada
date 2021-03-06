﻿using DnevnikRada.Klase;

namespace DnevnikRada
{
    partial class Home : UIController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.EvidencijaTrazi = new MetroFramework.Controls.MetroButton();
            this.EvidencijaDodaj = new MetroFramework.Controls.MetroButton();
            this.SkladisteTrazi = new MetroFramework.Controls.MetroButton();
            this.SkladisteDodaj = new MetroFramework.Controls.MetroButton();
            this.MjestaTrazi = new MetroFramework.Controls.MetroButton();
            this.MjestaDodaj = new MetroFramework.Controls.MetroButton();
            this.StanjePoduzeca = new MetroFramework.Controls.MetroButton();
            this.lbl_evidencija = new System.Windows.Forms.Label();
            this.lbl_skladiste = new System.Windows.Forms.Label();
            this.lbl_stanje_poduzeca = new System.Windows.Forms.Label();
            this.lbl_mjesta = new System.Windows.Forms.Label();
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti = new MetroFramework.Controls.MetroPanel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dT)).BeginInit();
            this.SuspendLayout();
            // 
            // EvidencijaTrazi
            // 
            this.EvidencijaTrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.EvidencijaTrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EvidencijaTrazi.BackgroundImage")));
            this.EvidencijaTrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EvidencijaTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EvidencijaTrazi.Location = new System.Drawing.Point(0, 40);
            this.EvidencijaTrazi.Name = "EvidencijaTrazi";
            this.EvidencijaTrazi.Size = new System.Drawing.Size(150, 250);
            this.EvidencijaTrazi.TabIndex = 0;
            this.EvidencijaTrazi.UseSelectable = true;
            this.EvidencijaTrazi.Click += new System.EventHandler(this.Click_Gumb);
            this.EvidencijaTrazi.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.EvidencijaTrazi.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // EvidencijaDodaj
            // 
            this.EvidencijaDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.EvidencijaDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EvidencijaDodaj.BackgroundImage")));
            this.EvidencijaDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EvidencijaDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EvidencijaDodaj.Location = new System.Drawing.Point(150, 40);
            this.EvidencijaDodaj.Name = "EvidencijaDodaj";
            this.EvidencijaDodaj.Size = new System.Drawing.Size(150, 250);
            this.EvidencijaDodaj.TabIndex = 0;
            this.EvidencijaDodaj.UseSelectable = true;
            this.EvidencijaDodaj.Click += new System.EventHandler(this.Click_Gumb);
            this.EvidencijaDodaj.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.EvidencijaDodaj.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // SkladisteTrazi
            // 
            this.SkladisteTrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.SkladisteTrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkladisteTrazi.BackgroundImage")));
            this.SkladisteTrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SkladisteTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkladisteTrazi.Location = new System.Drawing.Point(0, 330);
            this.SkladisteTrazi.Name = "SkladisteTrazi";
            this.SkladisteTrazi.Size = new System.Drawing.Size(150, 250);
            this.SkladisteTrazi.TabIndex = 0;
            this.SkladisteTrazi.UseSelectable = true;
            this.SkladisteTrazi.Click += new System.EventHandler(this.Click_Gumb);
            this.SkladisteTrazi.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.SkladisteTrazi.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // SkladisteDodaj
            // 
            this.SkladisteDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.SkladisteDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkladisteDodaj.BackgroundImage")));
            this.SkladisteDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SkladisteDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkladisteDodaj.Location = new System.Drawing.Point(150, 330);
            this.SkladisteDodaj.Name = "SkladisteDodaj";
            this.SkladisteDodaj.Size = new System.Drawing.Size(150, 250);
            this.SkladisteDodaj.TabIndex = 0;
            this.SkladisteDodaj.UseSelectable = true;
            this.SkladisteDodaj.Click += new System.EventHandler(this.Click_Gumb);
            this.SkladisteDodaj.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.SkladisteDodaj.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // MjestaTrazi
            // 
            this.MjestaTrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.MjestaTrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MjestaTrazi.BackgroundImage")));
            this.MjestaTrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MjestaTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MjestaTrazi.Location = new System.Drawing.Point(300, 330);
            this.MjestaTrazi.Name = "MjestaTrazi";
            this.MjestaTrazi.Size = new System.Drawing.Size(150, 250);
            this.MjestaTrazi.TabIndex = 0;
            this.MjestaTrazi.UseSelectable = true;
            this.MjestaTrazi.Click += new System.EventHandler(this.Click_Gumb);
            this.MjestaTrazi.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.MjestaTrazi.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // MjestaDodaj
            // 
            this.MjestaDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.MjestaDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MjestaDodaj.BackgroundImage")));
            this.MjestaDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MjestaDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MjestaDodaj.Location = new System.Drawing.Point(450, 330);
            this.MjestaDodaj.Name = "MjestaDodaj";
            this.MjestaDodaj.Size = new System.Drawing.Size(150, 250);
            this.MjestaDodaj.TabIndex = 0;
            this.MjestaDodaj.UseSelectable = true;
            this.MjestaDodaj.Click += new System.EventHandler(this.Click_Gumb);
            this.MjestaDodaj.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.MjestaDodaj.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // StanjePoduzeca
            // 
            this.StanjePoduzeca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StanjePoduzeca.BackColor = System.Drawing.Color.RoyalBlue;
            this.StanjePoduzeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StanjePoduzeca.BackgroundImage")));
            this.StanjePoduzeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StanjePoduzeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StanjePoduzeca.Location = new System.Drawing.Point(300, 40);
            this.StanjePoduzeca.Name = "StanjePoduzeca";
            this.StanjePoduzeca.Size = new System.Drawing.Size(300, 250);
            this.StanjePoduzeca.TabIndex = 0;
            this.StanjePoduzeca.UseSelectable = true;
            this.StanjePoduzeca.Click += new System.EventHandler(this.Click_Gumb);
            this.StanjePoduzeca.MouseEnter += new System.EventHandler(this.MouseEnter_Mouse);
            this.StanjePoduzeca.MouseLeave += new System.EventHandler(this.MouseLeave_Mouse);
            // 
            // lbl_evidencija
            // 
            this.lbl_evidencija.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_evidencija.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_evidencija.ForeColor = System.Drawing.Color.Black;
            this.lbl_evidencija.Location = new System.Drawing.Point(0, 0);
            this.lbl_evidencija.Name = "lbl_evidencija";
            this.lbl_evidencija.Size = new System.Drawing.Size(300, 40);
            this.lbl_evidencija.TabIndex = 3;
            this.lbl_evidencija.Text = "Evidencija";
            this.lbl_evidencija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_skladiste
            // 
            this.lbl_skladiste.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_skladiste.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_skladiste.ForeColor = System.Drawing.Color.Black;
            this.lbl_skladiste.Location = new System.Drawing.Point(0, 290);
            this.lbl_skladiste.Name = "lbl_skladiste";
            this.lbl_skladiste.Size = new System.Drawing.Size(300, 40);
            this.lbl_skladiste.TabIndex = 4;
            this.lbl_skladiste.Text = "Skladište";
            this.lbl_skladiste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stanje_poduzeca
            // 
            this.lbl_stanje_poduzeca.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_stanje_poduzeca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_stanje_poduzeca.ForeColor = System.Drawing.Color.Black;
            this.lbl_stanje_poduzeca.Location = new System.Drawing.Point(300, 0);
            this.lbl_stanje_poduzeca.Name = "lbl_stanje_poduzeca";
            this.lbl_stanje_poduzeca.Size = new System.Drawing.Size(300, 40);
            this.lbl_stanje_poduzeca.TabIndex = 6;
            this.lbl_stanje_poduzeca.Text = "Stanje Poduzeća";
            this.lbl_stanje_poduzeca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mjesta
            // 
            this.lbl_mjesta.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_mjesta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mjesta.ForeColor = System.Drawing.Color.Black;
            this.lbl_mjesta.Location = new System.Drawing.Point(300, 290);
            this.lbl_mjesta.Name = "lbl_mjesta";
            this.lbl_mjesta.Size = new System.Drawing.Size(300, 40);
            this.lbl_mjesta.TabIndex = 7;
            this.lbl_mjesta.Text = "Mjesta";
            this.lbl_mjesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_zadaci_aktivnog_tjedna_i_obavijesti
            // 
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.AutoSize = true;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarBarColor = true;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarSize = 10;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Location = new System.Drawing.Point(600, 0);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Name = "panel_zadaci_aktivnog_tjedna_i_obavijesti";
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Size = new System.Drawing.Size(0, 0);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.TabIndex = 5;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarBarColor = true;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarHighlightOnWheel = false;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarSize = 10;
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.BackColor = System.Drawing.Color.White;
            this.metroUserControl1.Location = new System.Drawing.Point(606, 0);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(291, 580);
            this.metroUserControl1.TabIndex = 8;
            this.metroUserControl1.UseSelectable = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.lbl_mjesta);
            this.Controls.Add(this.lbl_stanje_poduzeca);
            this.Controls.Add(this.panel_zadaci_aktivnog_tjedna_i_obavijesti);
            this.Controls.Add(this.lbl_skladiste);
            this.Controls.Add(this.lbl_evidencija);
            this.Controls.Add(this.MjestaDodaj);
            this.Controls.Add(this.SkladisteDodaj);
            this.Controls.Add(this.MjestaTrazi);
            this.Controls.Add(this.SkladisteTrazi);
            this.Controls.Add(this.StanjePoduzeca);
            this.Controls.Add(this.EvidencijaDodaj);
            this.Controls.Add(this.EvidencijaTrazi);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "/";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton EvidencijaTrazi;
        private MetroFramework.Controls.MetroButton EvidencijaDodaj;
        private MetroFramework.Controls.MetroButton SkladisteTrazi;
        private MetroFramework.Controls.MetroButton SkladisteDodaj;
        private MetroFramework.Controls.MetroButton MjestaTrazi;
        private MetroFramework.Controls.MetroButton MjestaDodaj;
        private MetroFramework.Controls.MetroButton StanjePoduzeca;
        private System.Windows.Forms.Label lbl_evidencija;
        private System.Windows.Forms.Label lbl_skladiste;
        private System.Windows.Forms.Label lbl_stanje_poduzeca;
        private System.Windows.Forms.Label lbl_mjesta;
        private MetroFramework.Controls.MetroPanel panel_zadaci_aktivnog_tjedna_i_obavijesti;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
    }
}

