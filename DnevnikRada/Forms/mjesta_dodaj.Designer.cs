namespace DnevnikRada
{
    partial class Mjesta_dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mjesta_dodaj));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.lbl_naziv_mjesta = new MetroFramework.Controls.MetroLabel();
            this.lbl_vrijeme_rada = new MetroFramework.Controls.MetroLabel();
            this.tb_naziv_mjesta = new MetroFramework.Controls.MetroTextBox();
            this.Potvrdi = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_adresa = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.kalendarGrid = new MetroFramework.Controls.MetroGrid();
            this.Dodaj = new MetroFramework.Controls.MetroButton();
            this.Oduzmi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalendarGrid)).BeginInit();
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
            this.lbl_naziv_mjesta.Location = new System.Drawing.Point(328, 52);
            this.lbl_naziv_mjesta.Name = "lbl_naziv_mjesta";
            this.lbl_naziv_mjesta.Size = new System.Drawing.Size(108, 25);
            this.lbl_naziv_mjesta.TabIndex = 1;
            this.lbl_naziv_mjesta.Text = "Naziv Mjesta";
            // 
            // lbl_vrijeme_rada
            // 
            this.lbl_vrijeme_rada.AutoSize = true;
            this.lbl_vrijeme_rada.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_vrijeme_rada.Location = new System.Drawing.Point(220, 130);
            this.lbl_vrijeme_rada.Name = "lbl_vrijeme_rada";
            this.lbl_vrijeme_rada.Size = new System.Drawing.Size(216, 25);
            this.lbl_vrijeme_rada.TabIndex = 3;
            this.lbl_vrijeme_rada.Text = "Vrijeme Rada (Opcionalno)";
            // 
            // tb_naziv_mjesta
            // 
            // 
            // 
            // 
            this.tb_naziv_mjesta.CustomButton.Image = null;
            this.tb_naziv_mjesta.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.tb_naziv_mjesta.CustomButton.Name = "";
            this.tb_naziv_mjesta.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_naziv_mjesta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_naziv_mjesta.CustomButton.TabIndex = 1;
            this.tb_naziv_mjesta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_naziv_mjesta.CustomButton.UseSelectable = true;
            this.tb_naziv_mjesta.CustomButton.Visible = false;
            this.tb_naziv_mjesta.Lines = new string[0];
            this.tb_naziv_mjesta.Location = new System.Drawing.Point(442, 48);
            this.tb_naziv_mjesta.MaxLength = 32767;
            this.tb_naziv_mjesta.Name = "tb_naziv_mjesta";
            this.tb_naziv_mjesta.PasswordChar = '\0';
            this.tb_naziv_mjesta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_naziv_mjesta.SelectedText = "";
            this.tb_naziv_mjesta.SelectionLength = 0;
            this.tb_naziv_mjesta.SelectionStart = 0;
            this.tb_naziv_mjesta.ShortcutsEnabled = true;
            this.tb_naziv_mjesta.Size = new System.Drawing.Size(241, 29);
            this.tb_naziv_mjesta.TabIndex = 1;
            this.tb_naziv_mjesta.UseSelectable = true;
            this.tb_naziv_mjesta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_naziv_mjesta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Potvrdi
            // 
            this.Potvrdi.BackColor = System.Drawing.Color.RoyalBlue;
            this.Potvrdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Potvrdi.BackgroundImage")));
            this.Potvrdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Potvrdi.Location = new System.Drawing.Point(700, 480);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(100, 100);
            this.Potvrdi.TabIndex = 10;
            this.Potvrdi.UseSelectable = true;
            this.Potvrdi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(318, 91);
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
            this.tb_adresa.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.tb_adresa.CustomButton.Name = "";
            this.tb_adresa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tb_adresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_adresa.CustomButton.TabIndex = 1;
            this.tb_adresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_adresa.CustomButton.UseSelectable = true;
            this.tb_adresa.CustomButton.Visible = false;
            this.tb_adresa.Lines = new string[0];
            this.tb_adresa.Location = new System.Drawing.Point(442, 87);
            this.tb_adresa.MaxLength = 32767;
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.PasswordChar = '\0';
            this.tb_adresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_adresa.SelectedText = "";
            this.tb_adresa.SelectionLength = 0;
            this.tb_adresa.SelectionStart = 0;
            this.tb_adresa.ShortcutsEnabled = true;
            this.tb_adresa.Size = new System.Drawing.Size(241, 29);
            this.tb_adresa.TabIndex = 2;
            this.tb_adresa.UseSelectable = true;
            this.tb_adresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_adresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(442, 126);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(240, 29);
            this.metroDateTime1.TabIndex = 14;
            // 
            // kalendarGrid
            // 
            this.kalendarGrid.AllowUserToAddRows = false;
            this.kalendarGrid.AllowUserToDeleteRows = false;
            this.kalendarGrid.AllowUserToResizeRows = false;
            this.kalendarGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kalendarGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kalendarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.kalendarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kalendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kalendarGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.kalendarGrid.EnableHeadersVisualStyles = false;
            this.kalendarGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kalendarGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kalendarGrid.Location = new System.Drawing.Point(442, 165);
            this.kalendarGrid.Name = "kalendarGrid";
            this.kalendarGrid.ReadOnly = true;
            this.kalendarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.kalendarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kalendarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kalendarGrid.Size = new System.Drawing.Size(240, 268);
            this.kalendarGrid.TabIndex = 32;
            this.kalendarGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KalendarGrid_CellClick);
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.Dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dodaj.BackgroundImage")));
            this.Dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dodaj.Location = new System.Drawing.Point(600, 480);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(100, 100);
            this.Dodaj.TabIndex = 33;
            this.Dodaj.UseSelectable = true;
            this.Dodaj.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Oduzmi
            // 
            this.Oduzmi.BackColor = System.Drawing.Color.RoyalBlue;
            this.Oduzmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Oduzmi.BackgroundImage")));
            this.Oduzmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Oduzmi.Enabled = false;
            this.Oduzmi.Location = new System.Drawing.Point(500, 480);
            this.Oduzmi.Name = "Oduzmi";
            this.Oduzmi.Size = new System.Drawing.Size(100, 100);
            this.Oduzmi.TabIndex = 39;
            this.Oduzmi.UseSelectable = true;
            this.Oduzmi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // mjesta_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Oduzmi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.kalendarGrid);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.tb_naziv_mjesta);
            this.Controls.Add(this.lbl_vrijeme_rada);
            this.Controls.Add(this.lbl_naziv_mjesta);
            this.Controls.Add(this.Home);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "mjesta_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_dodaj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalendarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroLabel lbl_naziv_mjesta;
        private MetroFramework.Controls.MetroLabel lbl_vrijeme_rada;
        private MetroFramework.Controls.MetroTextBox tb_naziv_mjesta;
        private MetroFramework.Controls.MetroButton Potvrdi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_adresa;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroGrid kalendarGrid;
        private MetroFramework.Controls.MetroButton Dodaj;
        private MetroFramework.Controls.MetroButton Oduzmi;
    }
}