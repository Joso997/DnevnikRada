﻿namespace DnevnikRada
{
    partial class skladiste_trazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skladiste_trazi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.skladisteGrid = new MetroFramework.Controls.MetroGrid();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.search = new MetroFramework.Controls.MetroTextBox();
            this.prodavacBox = new MetroFramework.Controls.MetroTextBox();
            this.nazivBox = new MetroFramework.Controls.MetroTextBox();
            this.kolicinaBox = new MetroFramework.Controls.MetroTextBox();
            this.mjBox = new MetroFramework.Controls.MetroTextBox();
            this.nazivLabel = new MetroFramework.Controls.MetroLabel();
            this.prodavacLabel = new MetroFramework.Controls.MetroLabel();
            this.mjLabel = new MetroFramework.Controls.MetroLabel();
            this.kolicinaLabel = new MetroFramework.Controls.MetroLabel();
            this.Edit = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteGrid)).BeginInit();
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
            // skladisteGrid
            // 
            this.skladisteGrid.AllowUserToAddRows = false;
            this.skladisteGrid.AllowUserToDeleteRows = false;
            this.skladisteGrid.AllowUserToResizeRows = false;
            this.skladisteGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skladisteGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skladisteGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skladisteGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skladisteGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.skladisteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skladisteGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.skladisteGrid.EnableHeadersVisualStyles = false;
            this.skladisteGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skladisteGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skladisteGrid.Location = new System.Drawing.Point(175, 170);
            this.skladisteGrid.MultiSelect = false;
            this.skladisteGrid.Name = "skladisteGrid";
            this.skladisteGrid.ReadOnly = true;
            this.skladisteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skladisteGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.skladisteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skladisteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skladisteGrid.Size = new System.Drawing.Size(550, 200);
            this.skladisteGrid.TabIndex = 3;
            this.skladisteGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.skladisteGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skladisteGrid_CellContentClick);
            // 
            // Trazi
            // 
            this.Trazi.BackColor = System.Drawing.Color.Aqua;
            this.Trazi.Location = new System.Drawing.Point(625, 100);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(100, 50);
            this.Trazi.TabIndex = 4;
            this.Trazi.Text = "Traži";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // search
            // 
            // 
            // 
            // 
            this.search.CustomButton.Image = null;
            this.search.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.search.CustomButton.Name = "";
            this.search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search.CustomButton.TabIndex = 1;
            this.search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search.CustomButton.UseSelectable = true;
            this.search.CustomButton.Visible = false;
            this.search.Lines = new string[0];
            this.search.Location = new System.Drawing.Point(290, 115);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.ShortcutsEnabled = true;
            this.search.Size = new System.Drawing.Size(320, 23);
            this.search.TabIndex = 5;
            this.search.UseSelectable = true;
            this.search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // prodavacBox
            // 
            // 
            // 
            // 
            this.prodavacBox.CustomButton.Image = null;
            this.prodavacBox.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.prodavacBox.CustomButton.Name = "";
            this.prodavacBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prodavacBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prodavacBox.CustomButton.TabIndex = 1;
            this.prodavacBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prodavacBox.CustomButton.UseSelectable = true;
            this.prodavacBox.CustomButton.Visible = false;
            this.prodavacBox.Lines = new string[0];
            this.prodavacBox.Location = new System.Drawing.Point(290, 419);
            this.prodavacBox.MaxLength = 32767;
            this.prodavacBox.Name = "prodavacBox";
            this.prodavacBox.PasswordChar = '\0';
            this.prodavacBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prodavacBox.SelectedText = "";
            this.prodavacBox.SelectionLength = 0;
            this.prodavacBox.SelectionStart = 0;
            this.prodavacBox.ShortcutsEnabled = true;
            this.prodavacBox.Size = new System.Drawing.Size(320, 23);
            this.prodavacBox.TabIndex = 6;
            this.prodavacBox.UseSelectable = true;
            this.prodavacBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prodavacBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.prodavacBox.Click += new System.EventHandler(this.prodavacBox_Click);
            // 
            // nazivBox
            // 
            // 
            // 
            // 
            this.nazivBox.CustomButton.Image = null;
            this.nazivBox.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.nazivBox.CustomButton.Name = "";
            this.nazivBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nazivBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nazivBox.CustomButton.TabIndex = 1;
            this.nazivBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nazivBox.CustomButton.UseSelectable = true;
            this.nazivBox.CustomButton.Visible = false;
            this.nazivBox.Lines = new string[0];
            this.nazivBox.Location = new System.Drawing.Point(290, 390);
            this.nazivBox.MaxLength = 32767;
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.PasswordChar = '\0';
            this.nazivBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nazivBox.SelectedText = "";
            this.nazivBox.SelectionLength = 0;
            this.nazivBox.SelectionStart = 0;
            this.nazivBox.ShortcutsEnabled = true;
            this.nazivBox.Size = new System.Drawing.Size(320, 23);
            this.nazivBox.TabIndex = 7;
            this.nazivBox.UseSelectable = true;
            this.nazivBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nazivBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nazivBox.Click += new System.EventHandler(this.nazivBox_Click);
            // 
            // kolicinaBox
            // 
            // 
            // 
            // 
            this.kolicinaBox.CustomButton.Image = null;
            this.kolicinaBox.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.kolicinaBox.CustomButton.Name = "";
            this.kolicinaBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kolicinaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kolicinaBox.CustomButton.TabIndex = 1;
            this.kolicinaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kolicinaBox.CustomButton.UseSelectable = true;
            this.kolicinaBox.CustomButton.Visible = false;
            this.kolicinaBox.Lines = new string[0];
            this.kolicinaBox.Location = new System.Drawing.Point(290, 477);
            this.kolicinaBox.MaxLength = 32767;
            this.kolicinaBox.Name = "kolicinaBox";
            this.kolicinaBox.PasswordChar = '\0';
            this.kolicinaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kolicinaBox.SelectedText = "";
            this.kolicinaBox.SelectionLength = 0;
            this.kolicinaBox.SelectionStart = 0;
            this.kolicinaBox.ShortcutsEnabled = true;
            this.kolicinaBox.Size = new System.Drawing.Size(320, 23);
            this.kolicinaBox.TabIndex = 8;
            this.kolicinaBox.UseSelectable = true;
            this.kolicinaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kolicinaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.kolicinaBox.Click += new System.EventHandler(this.kolicinaBox_Click);
            // 
            // mjBox
            // 
            // 
            // 
            // 
            this.mjBox.CustomButton.Image = null;
            this.mjBox.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.mjBox.CustomButton.Name = "";
            this.mjBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mjBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mjBox.CustomButton.TabIndex = 1;
            this.mjBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mjBox.CustomButton.UseSelectable = true;
            this.mjBox.CustomButton.Visible = false;
            this.mjBox.Lines = new string[0];
            this.mjBox.Location = new System.Drawing.Point(290, 448);
            this.mjBox.MaxLength = 32767;
            this.mjBox.Name = "mjBox";
            this.mjBox.PasswordChar = '\0';
            this.mjBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mjBox.SelectedText = "";
            this.mjBox.SelectionLength = 0;
            this.mjBox.SelectionStart = 0;
            this.mjBox.ShortcutsEnabled = true;
            this.mjBox.Size = new System.Drawing.Size(320, 23);
            this.mjBox.TabIndex = 9;
            this.mjBox.UseSelectable = true;
            this.mjBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mjBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mjBox.Click += new System.EventHandler(this.mjBox_Click);
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(175, 394);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(41, 19);
            this.nazivLabel.TabIndex = 10;
            this.nazivLabel.Text = "Naziv";
            this.nazivLabel.Click += new System.EventHandler(this.nazivLabel_Click);
            // 
            // prodavacLabel
            // 
            this.prodavacLabel.AutoSize = true;
            this.prodavacLabel.Location = new System.Drawing.Point(175, 423);
            this.prodavacLabel.Name = "prodavacLabel";
            this.prodavacLabel.Size = new System.Drawing.Size(64, 19);
            this.prodavacLabel.TabIndex = 11;
            this.prodavacLabel.Text = "Prodavac";
            this.prodavacLabel.Click += new System.EventHandler(this.prodavacLabel_Click);
            // 
            // mjLabel
            // 
            this.mjLabel.AutoSize = true;
            this.mjLabel.Location = new System.Drawing.Point(175, 452);
            this.mjLabel.Name = "mjLabel";
            this.mjLabel.Size = new System.Drawing.Size(100, 19);
            this.mjLabel.TabIndex = 12;
            this.mjLabel.Text = "Mjerna Jedinica";
            this.mjLabel.Click += new System.EventHandler(this.mjLabel_Click);
            // 
            // kolicinaLabel
            // 
            this.kolicinaLabel.AutoSize = true;
            this.kolicinaLabel.Location = new System.Drawing.Point(175, 481);
            this.kolicinaLabel.Name = "kolicinaLabel";
            this.kolicinaLabel.Size = new System.Drawing.Size(53, 19);
            this.kolicinaLabel.TabIndex = 13;
            this.kolicinaLabel.Text = "Kolicina";
            this.kolicinaLabel.Click += new System.EventHandler(this.kolicinaLabel_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Aqua;
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(625, 419);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 50);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "Uredi";
            this.Edit.UseSelectable = true;
            this.Edit.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(333, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pretraživanje Skladišta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // skladiste_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.kolicinaLabel);
            this.Controls.Add(this.mjLabel);
            this.Controls.Add(this.prodavacLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.mjBox);
            this.Controls.Add(this.kolicinaBox);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.prodavacBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.skladisteGrid);
            this.Controls.Add(this.Home);
            this.Name = "skladiste_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skladiste_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            this.Load += new System.EventHandler(this.skladiste_trazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladisteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroGrid skladisteGrid;
        private MetroFramework.Controls.MetroButton Trazi;
        private MetroFramework.Controls.MetroTextBox search;
        private MetroFramework.Controls.MetroTextBox prodavacBox;
        private MetroFramework.Controls.MetroTextBox nazivBox;
        private MetroFramework.Controls.MetroTextBox kolicinaBox;
        private MetroFramework.Controls.MetroTextBox mjBox;
        private MetroFramework.Controls.MetroLabel nazivLabel;
        private MetroFramework.Controls.MetroLabel prodavacLabel;
        private MetroFramework.Controls.MetroLabel mjLabel;
        private MetroFramework.Controls.MetroLabel kolicinaLabel;
        private MetroFramework.Controls.MetroButton Edit;
        private System.Windows.Forms.Label label1;
    }
}