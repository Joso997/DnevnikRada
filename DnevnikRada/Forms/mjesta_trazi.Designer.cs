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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.mjestoGrid = new MetroFramework.Controls.MetroGrid();
            this.Edit = new MetroFramework.Controls.MetroButton();
            this.Filters = new MetroFramework.Controls.MetroComboBox();
            this.kalendarGrid = new MetroFramework.Controls.MetroGrid();
            this.Dodaj = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.Trazi.Location = new System.Drawing.Point(581, 85);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(139, 29);
            this.Trazi.TabIndex = 1;
            this.Trazi.Text = "Traži";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // searchText
            // 
            // 
            // 
            // 
            this.searchText.CustomButton.Image = null;
            this.searchText.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.searchText.CustomButton.Name = "";
            this.searchText.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchText.CustomButton.TabIndex = 1;
            this.searchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchText.CustomButton.UseSelectable = true;
            this.searchText.CustomButton.Visible = false;
            this.searchText.Lines = new string[0];
            this.searchText.Location = new System.Drawing.Point(160, 85);
            this.searchText.MaxLength = 32767;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.ShortcutsEnabled = true;
            this.searchText.Size = new System.Drawing.Size(159, 29);
            this.searchText.TabIndex = 2;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mjestoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.mjestoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mjestoGrid.DefaultCellStyle = dataGridViewCellStyle20;
            this.mjestoGrid.EnableHeadersVisualStyles = false;
            this.mjestoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mjestoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mjestoGrid.Location = new System.Drawing.Point(216, 156);
            this.mjestoGrid.Name = "mjestoGrid";
            this.mjestoGrid.ReadOnly = true;
            this.mjestoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mjestoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.mjestoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mjestoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mjestoGrid.Size = new System.Drawing.Size(250, 241);
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
            this.Edit.Visible = false;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.kalendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kalendarGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.kalendarGrid.EnableHeadersVisualStyles = false;
            this.kalendarGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kalendarGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kalendarGrid.Location = new System.Drawing.Point(507, 206);
            this.kalendarGrid.Name = "kalendarGrid";
            this.kalendarGrid.ReadOnly = true;
            this.kalendarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kalendarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.kalendarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kalendarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kalendarGrid.Size = new System.Drawing.Size(150, 191);
            this.kalendarGrid.TabIndex = 18;
            this.kalendarGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kalendarGrid_CellClick);
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.Dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dodaj.BackgroundImage")));
            this.Dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dodaj.Location = new System.Drawing.Point(700, 480);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(100, 100);
            this.Dodaj.TabIndex = 35;
            this.Dodaj.UseSelectable = true;
            this.Dodaj.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Checked = false;
            this.metroDateTime1.Location = new System.Drawing.Point(482, 171);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 34;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(325, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 23);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Filtrirati po: ";
            // 
            // Mjesta_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.kalendarGrid);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.mjestoGrid);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.Home);
            this.MaximumSize = new System.Drawing.Size(916, 619);
            this.MinimumSize = new System.Drawing.Size(916, 619);
            this.Name = "Mjesta_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mjestoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalendarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroButton Trazi;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroGrid mjestoGrid;
        private MetroFramework.Controls.MetroButton Edit;
        private MetroFramework.Controls.MetroComboBox Filters;
        private MetroFramework.Controls.MetroGrid kalendarGrid;
        private MetroFramework.Controls.MetroButton Dodaj;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}