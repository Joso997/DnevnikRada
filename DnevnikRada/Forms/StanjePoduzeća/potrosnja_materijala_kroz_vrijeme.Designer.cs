namespace DnevnikRada
{
    partial class Pmkv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pmkv));
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.Oon = new MetroFramework.Controls.MetroButton();
            this.Bokv = new MetroFramework.Controls.MetroButton();
            this.btn_potrosnja_materijala_kroz_vrijeme = new MetroFramework.Controls.MetroButton();
            this.Sp = new MetroFramework.Controls.MetroButton();
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
            this.btn_home.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Oon
            // 
            this.Oon.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Oon.Location = new System.Drawing.Point(1, 362);
            this.Oon.Name = "Oon";
            this.Oon.Size = new System.Drawing.Size(230, 100);
            this.Oon.TabIndex = 16;
            this.Oon.Text = "Odstupanje Od Normale";
            this.Oon.UseSelectable = true;
            this.Oon.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Bokv
            // 
            this.Bokv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Bokv.Location = new System.Drawing.Point(1, 242);
            this.Bokv.Name = "Bokv";
            this.Bokv.Size = new System.Drawing.Size(230, 100);
            this.Bokv.TabIndex = 15;
            this.Bokv.Text = "Broj Održavanja Kroz Vrijeme";
            this.Bokv.UseSelectable = true;
            this.Bokv.Click += new System.EventHandler(this.Click_Gumb);
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
            // 
            // Sp
            // 
            this.Sp.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Sp.Location = new System.Drawing.Point(1, 1);
            this.Sp.Name = "Sp";
            this.Sp.Size = new System.Drawing.Size(230, 100);
            this.Sp.TabIndex = 13;
            this.Sp.Text = "Stanje Poduzeća";
            this.Sp.UseSelectable = true;
            this.Sp.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Pmkv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Oon);
            this.Controls.Add(this.Bokv);
            this.Controls.Add(this.btn_potrosnja_materijala_kroz_vrijeme);
            this.Controls.Add(this.Sp);
            this.Controls.Add(this.btn_home);
            this.Name = "Pmkv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "potrosnja_materijala_kroz_vrijeme_2";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroButton Oon;
        private MetroFramework.Controls.MetroButton Bokv;
        private MetroFramework.Controls.MetroButton btn_potrosnja_materijala_kroz_vrijeme;
        private MetroFramework.Controls.MetroButton Sp;
    }
}