﻿namespace DnevnikRada
{
    partial class evidencija_trazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evidencija_trazi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.opisPosla = new System.Windows.Forms.RichTextBox();
            this.lbl_opis_posla = new MetroFramework.Controls.MetroLabel();
            this.evidencijaGrid = new MetroFramework.Controls.MetroGrid();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.textTrazi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materijalGrid = new MetroFramework.Controls.MetroGrid();
            this.Filters = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalGrid)).BeginInit();
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
            // opisPosla
            // 
            this.opisPosla.Location = new System.Drawing.Point(6, 322);
            this.opisPosla.Name = "opisPosla";
            this.opisPosla.ReadOnly = true;
            this.opisPosla.Size = new System.Drawing.Size(334, 250);
            this.opisPosla.TabIndex = 1;
            this.opisPosla.Text = "";
            // 
            // lbl_opis_posla
            // 
            this.lbl_opis_posla.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_opis_posla.Location = new System.Drawing.Point(125, 295);
            this.lbl_opis_posla.Name = "lbl_opis_posla";
            this.lbl_opis_posla.Size = new System.Drawing.Size(100, 23);
            this.lbl_opis_posla.TabIndex = 2;
            this.lbl_opis_posla.Text = "Opis Posla";
            // 
            // evidencijaGrid
            // 
            this.evidencijaGrid.AllowUserToAddRows = false;
            this.evidencijaGrid.AllowUserToDeleteRows = false;
            this.evidencijaGrid.AllowUserToResizeRows = false;
            this.evidencijaGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.evidencijaGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.evidencijaGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.evidencijaGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.evidencijaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.evidencijaGrid.DefaultCellStyle = dataGridViewCellStyle50;
            this.evidencijaGrid.EnableHeadersVisualStyles = false;
            this.evidencijaGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.evidencijaGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.evidencijaGrid.Location = new System.Drawing.Point(346, 10);
            this.evidencijaGrid.Name = "evidencijaGrid";
            this.evidencijaGrid.ReadOnly = true;
            this.evidencijaGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.evidencijaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.evidencijaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evidencijaGrid.Size = new System.Drawing.Size(445, 250);
            this.evidencijaGrid.TabIndex = 3;
            this.evidencijaGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evidencijaGrid_CellClick);
            // 
            // Trazi
            // 
            this.Trazi.Location = new System.Drawing.Point(236, 210);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(100, 50);
            this.Trazi.TabIndex = 4;
            this.Trazi.Text = "Traži";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // textTrazi
            // 
            // 
            // 
            // 
            this.textTrazi.CustomButton.Image = null;
            this.textTrazi.CustomButton.Location = new System.Drawing.Point(306, 2);
            this.textTrazi.CustomButton.Name = "";
            this.textTrazi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textTrazi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textTrazi.CustomButton.TabIndex = 1;
            this.textTrazi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textTrazi.CustomButton.UseSelectable = true;
            this.textTrazi.CustomButton.Visible = false;
            this.textTrazi.Lines = new string[0];
            this.textTrazi.Location = new System.Drawing.Point(6, 63);
            this.textTrazi.MaxLength = 32767;
            this.textTrazi.Name = "textTrazi";
            this.textTrazi.PasswordChar = '\0';
            this.textTrazi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textTrazi.SelectedText = "";
            this.textTrazi.SelectionLength = 0;
            this.textTrazi.SelectionStart = 0;
            this.textTrazi.ShortcutsEnabled = true;
            this.textTrazi.Size = new System.Drawing.Size(330, 30);
            this.textTrazi.TabIndex = 5;
            this.textTrazi.UseSelectable = true;
            this.textTrazi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textTrazi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(533, 293);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Materijal";
            // 
            // materijalGrid
            // 
            this.materijalGrid.AllowUserToAddRows = false;
            this.materijalGrid.AllowUserToDeleteRows = false;
            this.materijalGrid.AllowUserToResizeRows = false;
            this.materijalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materijalGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materijalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.materijalGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.materijalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materijalGrid.DefaultCellStyle = dataGridViewCellStyle53;
            this.materijalGrid.EnableHeadersVisualStyles = false;
            this.materijalGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materijalGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materijalGrid.Location = new System.Drawing.Point(346, 322);
            this.materijalGrid.Name = "materijalGrid";
            this.materijalGrid.ReadOnly = true;
            this.materijalGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.materijalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.materijalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materijalGrid.Size = new System.Drawing.Size(445, 250);
            this.materijalGrid.TabIndex = 7;
            // 
            // Filters
            // 
            this.Filters.FormattingEnabled = true;
            this.Filters.ItemHeight = 23;
            this.Filters.Location = new System.Drawing.Point(6, 114);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(139, 29);
            this.Filters.TabIndex = 18;
            this.Filters.UseSelectable = true;
            // 
            // evidencija_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.materijalGrid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textTrazi);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.evidencijaGrid);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.opisPosla);
            this.Controls.Add(this.Home);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "evidencija_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evidencija_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private System.Windows.Forms.RichTextBox opisPosla;
        private MetroFramework.Controls.MetroLabel lbl_opis_posla;
        private MetroFramework.Controls.MetroGrid evidencijaGrid;
        private MetroFramework.Controls.MetroButton Trazi;
        private MetroFramework.Controls.MetroTextBox textTrazi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid materijalGrid;
        private MetroFramework.Controls.MetroComboBox Filters;
    }
}