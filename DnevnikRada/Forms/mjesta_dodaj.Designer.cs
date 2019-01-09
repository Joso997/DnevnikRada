namespace DnevnikRada
{
    partial class mjesta_dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mjesta_dodaj));
            this.Home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_mjesta = new MetroFramework.Controls.MetroLabel();
            this.lbl_vrijeme_rada = new MetroFramework.Controls.MetroLabel();
            this.lbl_od = new MetroFramework.Controls.MetroLabel();
            this.lbl_do = new MetroFramework.Controls.MetroLabel();
            this.tb_naziv_mjesta = new MetroFramework.Controls.MetroTextBox();
            this.tb_od = new MetroFramework.Controls.MetroTextBox();
            this.tb_do = new MetroFramework.Controls.MetroTextBox();
            this.Potvrdi = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_adresa = new MetroFramework.Controls.MetroTextBox();
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
            // lbl_naziv_mjesta
            // 
            this.lbl_naziv_mjesta.AutoSize = true;
            this.lbl_naziv_mjesta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_naziv_mjesta.Location = new System.Drawing.Point(302, 113);
            this.lbl_naziv_mjesta.Name = "lbl_naziv_mjesta";
            this.lbl_naziv_mjesta.Size = new System.Drawing.Size(108, 25);
            this.lbl_naziv_mjesta.TabIndex = 1;
            this.lbl_naziv_mjesta.Text = "Naziv Mjesta";
            // 
            // lbl_vrijeme_rada
            // 
            this.lbl_vrijeme_rada.AutoSize = true;
            this.lbl_vrijeme_rada.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_vrijeme_rada.Location = new System.Drawing.Point(373, 228);
            this.lbl_vrijeme_rada.Name = "lbl_vrijeme_rada";
            this.lbl_vrijeme_rada.Size = new System.Drawing.Size(216, 25);
            this.lbl_vrijeme_rada.TabIndex = 3;
            this.lbl_vrijeme_rada.Text = "Vrijeme Rada (Opcionalno)";
            // 
            // lbl_od
            // 
            this.lbl_od.AutoSize = true;
            this.lbl_od.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_od.Location = new System.Drawing.Point(373, 265);
            this.lbl_od.Name = "lbl_od";
            this.lbl_od.Size = new System.Drawing.Size(36, 25);
            this.lbl_od.TabIndex = 4;
            this.lbl_od.Text = "Od";
            // 
            // lbl_do
            // 
            this.lbl_do.AutoSize = true;
            this.lbl_do.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_do.Location = new System.Drawing.Point(373, 302);
            this.lbl_do.Name = "lbl_do";
            this.lbl_do.Size = new System.Drawing.Size(34, 25);
            this.lbl_do.TabIndex = 5;
            this.lbl_do.Text = "Do";
            // 
            // tb_naziv_mjesta
            // 
            // 
            // 
            // 
            this.tb_naziv_mjesta.CustomButton.Image = null;
            this.tb_naziv_mjesta.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tb_naziv_mjesta.CustomButton.Name = "";
            this.tb_naziv_mjesta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_naziv_mjesta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_naziv_mjesta.CustomButton.TabIndex = 1;
            this.tb_naziv_mjesta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_naziv_mjesta.CustomButton.UseSelectable = true;
            this.tb_naziv_mjesta.CustomButton.Visible = false;
            this.tb_naziv_mjesta.Lines = new string[0];
            this.tb_naziv_mjesta.Location = new System.Drawing.Point(512, 115);
            this.tb_naziv_mjesta.MaxLength = 32767;
            this.tb_naziv_mjesta.Name = "tb_naziv_mjesta";
            this.tb_naziv_mjesta.PasswordChar = '\0';
            this.tb_naziv_mjesta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_naziv_mjesta.SelectedText = "";
            this.tb_naziv_mjesta.SelectionLength = 0;
            this.tb_naziv_mjesta.SelectionStart = 0;
            this.tb_naziv_mjesta.ShortcutsEnabled = true;
            this.tb_naziv_mjesta.Size = new System.Drawing.Size(150, 23);
            this.tb_naziv_mjesta.TabIndex = 6;
            this.tb_naziv_mjesta.UseSelectable = true;
            this.tb_naziv_mjesta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_naziv_mjesta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_od
            // 
            // 
            // 
            // 
            this.tb_od.CustomButton.Image = null;
            this.tb_od.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tb_od.CustomButton.Name = "";
            this.tb_od.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_od.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_od.CustomButton.TabIndex = 1;
            this.tb_od.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_od.CustomButton.UseSelectable = true;
            this.tb_od.CustomButton.Visible = false;
            this.tb_od.Lines = new string[] {
        "trenutno nista neradi"};
            this.tb_od.Location = new System.Drawing.Point(415, 267);
            this.tb_od.MaxLength = 32767;
            this.tb_od.Name = "tb_od";
            this.tb_od.PasswordChar = '\0';
            this.tb_od.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_od.SelectedText = "";
            this.tb_od.SelectionLength = 0;
            this.tb_od.SelectionStart = 0;
            this.tb_od.ShortcutsEnabled = true;
            this.tb_od.Size = new System.Drawing.Size(150, 23);
            this.tb_od.TabIndex = 8;
            this.tb_od.Text = "trenutno nista neradi";
            this.tb_od.UseSelectable = true;
            this.tb_od.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_od.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_do
            // 
            // 
            // 
            // 
            this.tb_do.CustomButton.Image = null;
            this.tb_do.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tb_do.CustomButton.Name = "";
            this.tb_do.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_do.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_do.CustomButton.TabIndex = 1;
            this.tb_do.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_do.CustomButton.UseSelectable = true;
            this.tb_do.CustomButton.Visible = false;
            this.tb_do.Lines = new string[] {
        "trenutno nista neradi"};
            this.tb_do.Location = new System.Drawing.Point(415, 304);
            this.tb_do.MaxLength = 32767;
            this.tb_do.Name = "tb_do";
            this.tb_do.PasswordChar = '\0';
            this.tb_do.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_do.SelectedText = "";
            this.tb_do.SelectionLength = 0;
            this.tb_do.SelectionStart = 0;
            this.tb_do.ShortcutsEnabled = true;
            this.tb_do.Size = new System.Drawing.Size(150, 23);
            this.tb_do.TabIndex = 9;
            this.tb_do.Text = "trenutno nista neradi";
            this.tb_do.UseSelectable = true;
            this.tb_do.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_do.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(463, 350);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(100, 100);
            this.Potvrdi.TabIndex = 10;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseSelectable = true;
            this.Potvrdi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(581, 287);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(243, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "<-- koji tip podatka u bzi ovo mora bit?";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(302, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Adresa Mjesta";
            // 
            // tb_adresa
            // 
            // 
            // 
            // 
            this.tb_adresa.CustomButton.Image = null;
            this.tb_adresa.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tb_adresa.CustomButton.Name = "";
            this.tb_adresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_adresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_adresa.CustomButton.TabIndex = 1;
            this.tb_adresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_adresa.CustomButton.UseSelectable = true;
            this.tb_adresa.CustomButton.Visible = false;
            this.tb_adresa.Lines = new string[0];
            this.tb_adresa.Location = new System.Drawing.Point(512, 155);
            this.tb_adresa.MaxLength = 32767;
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.PasswordChar = '\0';
            this.tb_adresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_adresa.SelectedText = "";
            this.tb_adresa.SelectionLength = 0;
            this.tb_adresa.SelectionStart = 0;
            this.tb_adresa.ShortcutsEnabled = true;
            this.tb_adresa.Size = new System.Drawing.Size(150, 23);
            this.tb_adresa.TabIndex = 13;
            this.tb_adresa.UseSelectable = true;
            this.tb_adresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_adresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mjesta_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.tb_do);
            this.Controls.Add(this.tb_od);
            this.Controls.Add(this.tb_naziv_mjesta);
            this.Controls.Add(this.lbl_do);
            this.Controls.Add(this.lbl_od);
            this.Controls.Add(this.lbl_vrijeme_rada);
            this.Controls.Add(this.lbl_naziv_mjesta);
            this.Controls.Add(this.Home);
            this.Name = "mjesta_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_dodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_mjesta;
        private MetroFramework.Controls.MetroLabel lbl_vrijeme_rada;
        private MetroFramework.Controls.MetroLabel lbl_od;
        private MetroFramework.Controls.MetroLabel lbl_do;
        private MetroFramework.Controls.MetroTextBox tb_naziv_mjesta;
        private MetroFramework.Controls.MetroTextBox tb_od;
        private MetroFramework.Controls.MetroTextBox tb_do;
        private MetroFramework.Controls.MetroButton Potvrdi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_adresa;
    }
}