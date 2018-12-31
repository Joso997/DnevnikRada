namespace DnevnikRada
{
    partial class evidencija_dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evidencija_dodaj));
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_mjesta = new MetroFramework.Controls.MetroLabel();
            this.lbl_utroseno_vrijeme = new MetroFramework.Controls.MetroLabel();
            this.tb_naziv_mjesta = new MetroFramework.Controls.MetroTextBox();
            this.tb_utroseno_vrijeme = new MetroFramework.Controls.MetroTextBox();
            this.rtb_opis_posla = new System.Windows.Forms.RichTextBox();
            this.lbl_opis_posla = new MetroFramework.Controls.MetroLabel();
            this.btn_potvrdi = new MetroFramework.Controls.MetroButton();
            this.btn_trash = new MetroFramework.Controls.MetroButton();
            this.btn_dodaj = new MetroFramework.Controls.MetroButton();
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
            // lbl_naziv_mjesta
            // 
            this.lbl_naziv_mjesta.AutoSize = true;
            this.lbl_naziv_mjesta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_naziv_mjesta.Location = new System.Drawing.Point(12, 90);
            this.lbl_naziv_mjesta.Name = "lbl_naziv_mjesta";
            this.lbl_naziv_mjesta.Size = new System.Drawing.Size(108, 25);
            this.lbl_naziv_mjesta.TabIndex = 1;
            this.lbl_naziv_mjesta.Text = "Naziv Mjesta";
            // 
            // lbl_utroseno_vrijeme
            // 
            this.lbl_utroseno_vrijeme.AutoSize = true;
            this.lbl_utroseno_vrijeme.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_utroseno_vrijeme.Location = new System.Drawing.Point(12, 137);
            this.lbl_utroseno_vrijeme.Name = "lbl_utroseno_vrijeme";
            this.lbl_utroseno_vrijeme.Size = new System.Drawing.Size(143, 25);
            this.lbl_utroseno_vrijeme.TabIndex = 2;
            this.lbl_utroseno_vrijeme.Text = "Utrošeno Vrijeme";
            // 
            // tb_naziv_mjesta
            // 
            // 
            // 
            // 
            this.tb_naziv_mjesta.CustomButton.Image = null;
            this.tb_naziv_mjesta.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_naziv_mjesta.CustomButton.Name = "";
            this.tb_naziv_mjesta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_naziv_mjesta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_naziv_mjesta.CustomButton.TabIndex = 1;
            this.tb_naziv_mjesta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_naziv_mjesta.CustomButton.UseSelectable = true;
            this.tb_naziv_mjesta.CustomButton.Visible = false;
            this.tb_naziv_mjesta.Lines = new string[0];
            this.tb_naziv_mjesta.Location = new System.Drawing.Point(168, 92);
            this.tb_naziv_mjesta.MaxLength = 32767;
            this.tb_naziv_mjesta.Name = "tb_naziv_mjesta";
            this.tb_naziv_mjesta.PasswordChar = '\0';
            this.tb_naziv_mjesta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_naziv_mjesta.SelectedText = "";
            this.tb_naziv_mjesta.SelectionLength = 0;
            this.tb_naziv_mjesta.SelectionStart = 0;
            this.tb_naziv_mjesta.ShortcutsEnabled = true;
            this.tb_naziv_mjesta.Size = new System.Drawing.Size(200, 23);
            this.tb_naziv_mjesta.TabIndex = 3;
            this.tb_naziv_mjesta.UseSelectable = true;
            this.tb_naziv_mjesta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_naziv_mjesta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_utroseno_vrijeme
            // 
            // 
            // 
            // 
            this.tb_utroseno_vrijeme.CustomButton.Image = null;
            this.tb_utroseno_vrijeme.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_utroseno_vrijeme.CustomButton.Name = "";
            this.tb_utroseno_vrijeme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_utroseno_vrijeme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_utroseno_vrijeme.CustomButton.TabIndex = 1;
            this.tb_utroseno_vrijeme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_utroseno_vrijeme.CustomButton.UseSelectable = true;
            this.tb_utroseno_vrijeme.CustomButton.Visible = false;
            this.tb_utroseno_vrijeme.Lines = new string[0];
            this.tb_utroseno_vrijeme.Location = new System.Drawing.Point(168, 139);
            this.tb_utroseno_vrijeme.MaxLength = 32767;
            this.tb_utroseno_vrijeme.Name = "tb_utroseno_vrijeme";
            this.tb_utroseno_vrijeme.PasswordChar = '\0';
            this.tb_utroseno_vrijeme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_utroseno_vrijeme.SelectedText = "";
            this.tb_utroseno_vrijeme.SelectionLength = 0;
            this.tb_utroseno_vrijeme.SelectionStart = 0;
            this.tb_utroseno_vrijeme.ShortcutsEnabled = true;
            this.tb_utroseno_vrijeme.Size = new System.Drawing.Size(200, 23);
            this.tb_utroseno_vrijeme.TabIndex = 4;
            this.tb_utroseno_vrijeme.UseSelectable = true;
            this.tb_utroseno_vrijeme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_utroseno_vrijeme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rtb_opis_posla
            // 
            this.rtb_opis_posla.Location = new System.Drawing.Point(12, 235);
            this.rtb_opis_posla.Name = "rtb_opis_posla";
            this.rtb_opis_posla.Size = new System.Drawing.Size(356, 333);
            this.rtb_opis_posla.TabIndex = 5;
            this.rtb_opis_posla.Text = "";
            // 
            // lbl_opis_posla
            // 
            this.lbl_opis_posla.AutoSize = true;
            this.lbl_opis_posla.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_opis_posla.Location = new System.Drawing.Point(140, 207);
            this.lbl_opis_posla.Name = "lbl_opis_posla";
            this.lbl_opis_posla.Size = new System.Drawing.Size(91, 25);
            this.lbl_opis_posla.TabIndex = 6;
            this.lbl_opis_posla.Text = "Opis Posla";
            // 
            // btn_potvrdi
            // 
            this.btn_potvrdi.Location = new System.Drawing.Point(701, 480);
            this.btn_potvrdi.Name = "btn_potvrdi";
            this.btn_potvrdi.Size = new System.Drawing.Size(100, 100);
            this.btn_potvrdi.TabIndex = 7;
            this.btn_potvrdi.Text = "Potvrdi";
            this.btn_potvrdi.UseSelectable = true;
            // 
            // btn_trash
            // 
            this.btn_trash.Location = new System.Drawing.Point(602, 480);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(100, 100);
            this.btn_trash.TabIndex = 8;
            this.btn_trash.Text = "trash";
            this.btn_trash.UseSelectable = true;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dodaj.BackgroundImage")));
            this.btn_dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dodaj.Location = new System.Drawing.Point(503, 480);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(100, 100);
            this.btn_dodaj.TabIndex = 9;
            this.btn_dodaj.UseSelectable = true;
            // 
            // evidencija_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_trash);
            this.Controls.Add(this.btn_potvrdi);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.rtb_opis_posla);
            this.Controls.Add(this.tb_utroseno_vrijeme);
            this.Controls.Add(this.tb_naziv_mjesta);
            this.Controls.Add(this.lbl_utroseno_vrijeme);
            this.Controls.Add(this.lbl_naziv_mjesta);
            this.Controls.Add(this.btn_home);
            this.Name = "evidencija_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evidencija_dodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.evidencija_dodaj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_mjesta;
        private MetroFramework.Controls.MetroLabel lbl_utroseno_vrijeme;
        private MetroFramework.Controls.MetroTextBox tb_naziv_mjesta;
        private MetroFramework.Controls.MetroTextBox tb_utroseno_vrijeme;
        private System.Windows.Forms.RichTextBox rtb_opis_posla;
        private MetroFramework.Controls.MetroLabel lbl_opis_posla;
        private MetroFramework.Controls.MetroButton btn_potvrdi;
        private MetroFramework.Controls.MetroButton btn_trash;
        private MetroFramework.Controls.MetroButton btn_dodaj;
    }
}