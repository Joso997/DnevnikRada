namespace DnevnikRada
{
    partial class Home
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
            this.btn_evidencija_trazi = new MetroFramework.Controls.MetroButton();
            this.btn_evidencija_dodaj = new MetroFramework.Controls.MetroButton();
            this.btn_skladiste_trazi = new MetroFramework.Controls.MetroButton();
            this.btn_skladiste_dodaj = new MetroFramework.Controls.MetroButton();
            this.btn_mjesta_trazi = new MetroFramework.Controls.MetroButton();
            this.btn_mjesta_dodaj = new MetroFramework.Controls.MetroButton();
            this.btn_stanje_poduzeca = new MetroFramework.Controls.MetroButton();
            this.lbl_evidencija = new System.Windows.Forms.Label();
            this.lbl_skladiste = new System.Windows.Forms.Label();
            this.lbl_stanje_poduzeca = new System.Windows.Forms.Label();
            this.lbl_mjesta = new System.Windows.Forms.Label();
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti = new MetroFramework.Controls.MetroPanel();
            this.kalendar = new MetroFramework.Controls.MetroDateTime();
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_evidencija_trazi
            // 
            this.btn_evidencija_trazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_evidencija_trazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_evidencija_trazi.BackgroundImage")));
            this.btn_evidencija_trazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_evidencija_trazi.Location = new System.Drawing.Point(0, 40);
            this.btn_evidencija_trazi.Name = "btn_evidencija_trazi";
            this.btn_evidencija_trazi.Size = new System.Drawing.Size(150, 250);
            this.btn_evidencija_trazi.TabIndex = 0;
            this.btn_evidencija_trazi.UseSelectable = true;
            this.btn_evidencija_trazi.Click += new System.EventHandler(this.btn_evidencija_trazi_Click);
            // 
            // btn_evidencija_dodaj
            // 
            this.btn_evidencija_dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_evidencija_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_evidencija_dodaj.BackgroundImage")));
            this.btn_evidencija_dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_evidencija_dodaj.Location = new System.Drawing.Point(150, 40);
            this.btn_evidencija_dodaj.Name = "btn_evidencija_dodaj";
            this.btn_evidencija_dodaj.Size = new System.Drawing.Size(150, 250);
            this.btn_evidencija_dodaj.TabIndex = 0;
            this.btn_evidencija_dodaj.UseSelectable = true;
            this.btn_evidencija_dodaj.Click += new System.EventHandler(this.btn_evidencija_dodaj_Click);
            // 
            // btn_skladiste_trazi
            // 
            this.btn_skladiste_trazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_skladiste_trazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_skladiste_trazi.BackgroundImage")));
            this.btn_skladiste_trazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_skladiste_trazi.Location = new System.Drawing.Point(0, 330);
            this.btn_skladiste_trazi.Name = "btn_skladiste_trazi";
            this.btn_skladiste_trazi.Size = new System.Drawing.Size(150, 250);
            this.btn_skladiste_trazi.TabIndex = 0;
            this.btn_skladiste_trazi.UseSelectable = true;
            this.btn_skladiste_trazi.Click += new System.EventHandler(this.btn_skladiste_trazi_Click);
            // 
            // btn_skladiste_dodaj
            // 
            this.btn_skladiste_dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_skladiste_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_skladiste_dodaj.BackgroundImage")));
            this.btn_skladiste_dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_skladiste_dodaj.Location = new System.Drawing.Point(150, 330);
            this.btn_skladiste_dodaj.Name = "btn_skladiste_dodaj";
            this.btn_skladiste_dodaj.Size = new System.Drawing.Size(150, 250);
            this.btn_skladiste_dodaj.TabIndex = 0;
            this.btn_skladiste_dodaj.UseSelectable = true;
            this.btn_skladiste_dodaj.Click += new System.EventHandler(this.btn_skladiste_dodaj_Click);
            // 
            // btn_mjesta_trazi
            // 
            this.btn_mjesta_trazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_mjesta_trazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mjesta_trazi.BackgroundImage")));
            this.btn_mjesta_trazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mjesta_trazi.Location = new System.Drawing.Point(300, 330);
            this.btn_mjesta_trazi.Name = "btn_mjesta_trazi";
            this.btn_mjesta_trazi.Size = new System.Drawing.Size(150, 250);
            this.btn_mjesta_trazi.TabIndex = 0;
            this.btn_mjesta_trazi.UseSelectable = true;
            this.btn_mjesta_trazi.Click += new System.EventHandler(this.btn_mjesta_trazi_Click);
            // 
            // btn_mjesta_dodaj
            // 
            this.btn_mjesta_dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_mjesta_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mjesta_dodaj.BackgroundImage")));
            this.btn_mjesta_dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mjesta_dodaj.Location = new System.Drawing.Point(450, 331);
            this.btn_mjesta_dodaj.Name = "btn_mjesta_dodaj";
            this.btn_mjesta_dodaj.Size = new System.Drawing.Size(150, 250);
            this.btn_mjesta_dodaj.TabIndex = 0;
            this.btn_mjesta_dodaj.UseSelectable = true;
            this.btn_mjesta_dodaj.Click += new System.EventHandler(this.btn_mjesta_dodaj_Click);
            // 
            // btn_stanje_poduzeca
            // 
            this.btn_stanje_poduzeca.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_stanje_poduzeca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stanje_poduzeca.BackgroundImage")));
            this.btn_stanje_poduzeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stanje_poduzeca.Location = new System.Drawing.Point(300, 40);
            this.btn_stanje_poduzeca.Name = "btn_stanje_poduzeca";
            this.btn_stanje_poduzeca.Size = new System.Drawing.Size(300, 250);
            this.btn_stanje_poduzeca.TabIndex = 0;
            this.btn_stanje_poduzeca.UseSelectable = true;
            this.btn_stanje_poduzeca.Click += new System.EventHandler(this.btn_stanje_poduzeca_Click);
            // 
            // lbl_evidencija
            // 
            this.lbl_evidencija.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_evidencija.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_evidencija.ForeColor = System.Drawing.Color.Black;
            this.lbl_evidencija.Location = new System.Drawing.Point(-1, 0);
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
            this.lbl_skladiste.Location = new System.Drawing.Point(-1, 290);
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
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_zadaci_aktivnog_tjedna_i_obavijesti.BackgroundImage")));
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Controls.Add(this.kalendar);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarBarColor = true;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.HorizontalScrollbarSize = 10;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Location = new System.Drawing.Point(600, 0);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Name = "panel_zadaci_aktivnog_tjedna_i_obavijesti";
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.Size = new System.Drawing.Size(300, 580);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.TabIndex = 5;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarBarColor = true;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarHighlightOnWheel = false;
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.VerticalScrollbarSize = 10;
            // 
            // kalendar
            // 
            this.kalendar.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.kalendar.Location = new System.Drawing.Point(5, 5);
            this.kalendar.MinimumSize = new System.Drawing.Size(0, 35);
            this.kalendar.Name = "kalendar";
            this.kalendar.Size = new System.Drawing.Size(291, 35);
            this.kalendar.TabIndex = 2;
            this.kalendar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.lbl_mjesta);
            this.Controls.Add(this.lbl_stanje_poduzeca);
            this.Controls.Add(this.panel_zadaci_aktivnog_tjedna_i_obavijesti);
            this.Controls.Add(this.lbl_skladiste);
            this.Controls.Add(this.lbl_evidencija);
            this.Controls.Add(this.btn_mjesta_dodaj);
            this.Controls.Add(this.btn_skladiste_dodaj);
            this.Controls.Add(this.btn_mjesta_trazi);
            this.Controls.Add(this.btn_skladiste_trazi);
            this.Controls.Add(this.btn_stanje_poduzeca);
            this.Controls.Add(this.btn_evidencija_dodaj);
            this.Controls.Add(this.btn_evidencija_trazi);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "/";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_zadaci_aktivnog_tjedna_i_obavijesti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_evidencija_trazi;
        private MetroFramework.Controls.MetroButton btn_evidencija_dodaj;
        private MetroFramework.Controls.MetroButton btn_skladiste_trazi;
        private MetroFramework.Controls.MetroButton btn_skladiste_dodaj;
        private MetroFramework.Controls.MetroButton btn_mjesta_trazi;
        private MetroFramework.Controls.MetroButton btn_mjesta_dodaj;
        private MetroFramework.Controls.MetroButton btn_stanje_poduzeca;
        private System.Windows.Forms.Label lbl_evidencija;
        private System.Windows.Forms.Label lbl_skladiste;
        private System.Windows.Forms.Label lbl_stanje_poduzeca;
        private System.Windows.Forms.Label lbl_mjesta;
        private MetroFramework.Controls.MetroPanel panel_zadaci_aktivnog_tjedna_i_obavijesti;
        private MetroFramework.Controls.MetroDateTime kalendar;
    }
}

