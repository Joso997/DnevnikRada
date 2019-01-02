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
            this.Oon = new MetroFramework.Controls.MetroButton();
            this.Bokv = new MetroFramework.Controls.MetroButton();
            this.Pmkv = new MetroFramework.Controls.MetroButton();
            this.St = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Oon
            // 
            this.Oon.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Oon.Location = new System.Drawing.Point(-2, 360);
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
            this.Bokv.Location = new System.Drawing.Point(-2, 240);
            this.Bokv.Name = "Bokv";
            this.Bokv.Size = new System.Drawing.Size(230, 100);
            this.Bokv.TabIndex = 15;
            this.Bokv.Text = "Broj Održavanja Kroz Vrijeme";
            this.Bokv.UseSelectable = true;
            this.Bokv.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Pmkv
            // 
            this.Pmkv.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Pmkv.Location = new System.Drawing.Point(-2, 119);
            this.Pmkv.Name = "Pmkv";
            this.Pmkv.Size = new System.Drawing.Size(230, 100);
            this.Pmkv.TabIndex = 14;
            this.Pmkv.Text = "Potrošnja Materijala Kroz Vrijeme";
            this.Pmkv.UseSelectable = true;
            this.Pmkv.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // St
            // 
            this.St.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.St.Location = new System.Drawing.Point(-2, -1);
            this.St.Name = "St";
            this.St.Size = new System.Drawing.Size(230, 100);
            this.St.TabIndex = 13;
            this.St.Text = "Stanje Poduzeća";
            this.St.UseSelectable = true;
            this.St.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Stanje_Poduzeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Oon);
            this.Controls.Add(this.Bokv);
            this.Controls.Add(this.Pmkv);
            this.Controls.Add(this.St);
            this.IsMdiContainer = true;
            this.Name = "Stanje_Poduzeca";
            this.Text = "StanjePoduzecaBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Oon;
        private MetroFramework.Controls.MetroButton Bokv;
        private MetroFramework.Controls.MetroButton Pmkv;
        private MetroFramework.Controls.MetroButton St;
    }
}