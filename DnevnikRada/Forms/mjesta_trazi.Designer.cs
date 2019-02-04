namespace DnevnikRada
{
    partial class Mjesta_trazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mjesta_trazi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.Search = new MetroFramework.Controls.MetroTextBox();
            this.mjestoGrid = new MetroFramework.Controls.MetroGrid();
            this.Edit = new MetroFramework.Controls.MetroButton();
            this.Filters = new MetroFramework.Controls.MetroComboBox();
            this.kalendarGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Sakri = new MetroFramework.Controls.MetroButton();
            this.Oduzmi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoGrid)).BeginInit();
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
            // Trazi
            // 
            this.Trazi.Location = new System.Drawing.Point(595, 85);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(139, 29);
            this.Trazi.TabIndex = 1;
            this.Trazi.Text = "Traži";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Search
            // 
            // 
            // 
            // 
            this.Search.CustomButton.Image = null;
            this.Search.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.Search.CustomButton.Name = "";
            this.Search.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Search.CustomButton.TabIndex = 1;
            this.Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Search.CustomButton.UseSelectable = true;
            this.Search.CustomButton.Visible = false;
            this.Search.Lines = new string[0];
            this.Search.Location = new System.Drawing.Point(162, 85);
            this.Search.MaxLength = 32767;
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Search.SelectedText = "";
            this.Search.SelectionLength = 0;
            this.Search.SelectionStart = 0;
            this.Search.ShortcutsEnabled = true;
            this.Search.Size = new System.Drawing.Size(159, 29);
            this.Search.TabIndex = 2;
            this.Search.UseSelectable = true;
            this.Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mjestoGrid
            // 
            this.mjestoGrid.AllowUserToAddRows = false;
            this.mjestoGrid.AllowUserToDeleteRows = false;
            this.mjestoGrid.AllowUserToResizeRows = false;
            this.mjestoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mjestoGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mjestoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mjestoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mjestoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mjestoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mjestoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mjestoGrid.EnableHeadersVisualStyles = false;
            this.mjestoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mjestoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mjestoGrid.Location = new System.Drawing.Point(162, 156);
            this.mjestoGrid.Name = "mjestoGrid";
            this.mjestoGrid.ReadOnly = true;
            this.mjestoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mjestoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mjestoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mjestoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mjestoGrid.Size = new System.Drawing.Size(304, 241);
            this.mjestoGrid.TabIndex = 3;
            this.mjestoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(600, 480);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 100);
            this.Edit.TabIndex = 12;
            this.Edit.UseSelectable = true;
            this.Edit.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Filters
            // 
            this.Filters.FormattingEnabled = true;
            this.Filters.ItemHeight = 23;
            this.Filters.Location = new System.Drawing.Point(436, 85);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(139, 29);
            this.Filters.TabIndex = 17;
            this.Filters.UseSelectable = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.kalendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kalendarGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.kalendarGrid.EnableHeadersVisualStyles = false;
            this.kalendarGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kalendarGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kalendarGrid.Location = new System.Drawing.Point(507, 156);
            this.kalendarGrid.Name = "kalendarGrid";
            this.kalendarGrid.ReadOnly = true;
            this.kalendarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.kalendarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kalendarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kalendarGrid.Size = new System.Drawing.Size(227, 241);
            this.kalendarGrid.TabIndex = 18;
            this.kalendarGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KalendarGrid_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(329, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 23);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Filtrirati po: ";
            // 
            // Sakri
            // 
            this.Sakri.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sakri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sakri.BackgroundImage")));
            this.Sakri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sakri.Enabled = false;
            this.Sakri.Location = new System.Drawing.Point(700, 480);
            this.Sakri.Name = "Sakri";
            this.Sakri.Size = new System.Drawing.Size(100, 100);
            this.Sakri.TabIndex = 37;
            this.Sakri.UseSelectable = true;
            this.Sakri.Click += new System.EventHandler(this.Click_Gumb);
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
            this.Oduzmi.TabIndex = 38;
            this.Oduzmi.UseSelectable = true;
            this.Oduzmi.Visible = false;
            this.Oduzmi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // Mjesta_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Oduzmi);
            this.Controls.Add(this.Sakri);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.kalendarGrid);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.mjestoGrid);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.Home);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "Mjesta_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalendarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroButton Trazi;
        private MetroFramework.Controls.MetroTextBox Search;
        private MetroFramework.Controls.MetroGrid mjestoGrid;
        private MetroFramework.Controls.MetroButton Edit;
        private MetroFramework.Controls.MetroComboBox Filters;
        private MetroFramework.Controls.MetroGrid kalendarGrid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Sakri;
        private MetroFramework.Controls.MetroButton Oduzmi;
    }
}