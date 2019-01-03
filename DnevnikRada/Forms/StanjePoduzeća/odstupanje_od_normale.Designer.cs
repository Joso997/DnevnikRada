namespace DnevnikRada
{
    partial class Oon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oon));
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.btn_odstupanje_od_normale = new MetroFramework.Controls.MetroButton();
            this.btn_broj_odrzavanja_kroz_vrijeme = new MetroFramework.Controls.MetroButton();
            this.btn_potrosnja_materijala_kroz_vrijeme = new MetroFramework.Controls.MetroButton();
            this.btn_stanje_poduzeca = new MetroFramework.Controls.MetroButton();
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
            // btn_odstupanje_od_normale
            // 
            this.btn_odstupanje_od_normale.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_odstupanje_od_normale.Location = new System.Drawing.Point(1, 362);
            this.btn_odstupanje_od_normale.Name = "btn_odstupanje_od_normale";
            this.btn_odstupanje_od_normale.Size = new System.Drawing.Size(230, 100);
            this.btn_odstupanje_od_normale.TabIndex = 16;
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
            this.btn_broj_odrzavanja_kroz_vrijeme.TabIndex = 15;
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
            this.btn_potrosnja_materijala_kroz_vrijeme.TabIndex = 14;
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
            this.btn_stanje_poduzeca.TabIndex = 13;
            this.btn_stanje_poduzeca.Text = "Stanje Poduzeća";
            this.btn_stanje_poduzeca.UseSelectable = true;
            this.btn_stanje_poduzeca.Click += new System.EventHandler(this.btn_stanje_poduzeca_Click);
            // 
            // Oon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.btn_odstupanje_od_normale);
            this.Controls.Add(this.btn_broj_odrzavanja_kroz_vrijeme);
            this.Controls.Add(this.btn_potrosnja_materijala_kroz_vrijeme);
            this.Controls.Add(this.btn_stanje_poduzeca);
            this.Controls.Add(this.btn_home);
            this.Name = "Oon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "odstupanje_od_normale_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.odstupanje_od_normale_2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroButton btn_odstupanje_od_normale;
        private MetroFramework.Controls.MetroButton btn_broj_odrzavanja_kroz_vrijeme;
        private MetroFramework.Controls.MetroButton btn_potrosnja_materijala_kroz_vrijeme;
        private MetroFramework.Controls.MetroButton btn_stanje_poduzeca;
    }
}