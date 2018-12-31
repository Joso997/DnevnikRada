namespace DnevnikRada
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
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.skladisteGrid = new MetroFramework.Controls.MetroGrid();
            this.KlickMe = new MetroFramework.Controls.MetroButton();
            this.search = new MetroFramework.Controls.MetroTextBox();
            this.prodavacBox = new MetroFramework.Controls.MetroTextBox();
            this.nazivBox = new MetroFramework.Controls.MetroTextBox();
            this.kolicinaBox = new MetroFramework.Controls.MetroTextBox();
            this.mjBox = new MetroFramework.Controls.MetroTextBox();
            this.nazivLabel = new MetroFramework.Controls.MetroLabel();
            this.prodavacLabel = new MetroFramework.Controls.MetroLabel();
            this.mjLabel = new MetroFramework.Controls.MetroLabel();
            this.kolicinaLabel = new MetroFramework.Controls.MetroLabel();
            this.finishEdit = new MetroFramework.Controls.MetroButton();
            this.editLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteGrid)).BeginInit();
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(-1, -1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(225, 175);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Skladište";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(505, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(173, 173);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[] {
        "Search"};
            this.metroTextBox1.Location = new System.Drawing.Point(221, -1);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(679, 175);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "Search";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.skladisteGrid.Location = new System.Drawing.Point(12, 180);
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
            this.skladisteGrid.Size = new System.Drawing.Size(814, 200);
            this.skladisteGrid.TabIndex = 3;
            this.skladisteGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skladisteGrid_CellClick);
            // 
            // KlickMe
            // 
            this.KlickMe.Location = new System.Drawing.Point(678, 81);
            this.KlickMe.Name = "KlickMe";
            this.KlickMe.Size = new System.Drawing.Size(148, 23);
            this.KlickMe.TabIndex = 4;
            this.KlickMe.Text = "Click me and find out";
            this.KlickMe.UseSelectable = true;
            this.KlickMe.Click += new System.EventHandler(this.KlickMe_Click);
            // 
            // search
            // 
            // 
            // 
            // 
            this.search.CustomButton.Image = null;
            this.search.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.search.CustomButton.Name = "";
            this.search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search.CustomButton.TabIndex = 1;
            this.search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search.CustomButton.UseSelectable = true;
            this.search.CustomButton.Visible = false;
            this.search.Lines = new string[] {
        "search me baby"};
            this.search.Location = new System.Drawing.Point(422, 80);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.ShortcutsEnabled = true;
            this.search.Size = new System.Drawing.Size(199, 23);
            this.search.TabIndex = 5;
            this.search.Text = "search me baby";
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
            this.prodavacBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.prodavacBox.CustomButton.Name = "";
            this.prodavacBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prodavacBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prodavacBox.CustomButton.TabIndex = 1;
            this.prodavacBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prodavacBox.CustomButton.UseSelectable = true;
            this.prodavacBox.CustomButton.Visible = false;
            this.prodavacBox.Lines = new string[0];
            this.prodavacBox.Location = new System.Drawing.Point(144, 461);
            this.prodavacBox.MaxLength = 32767;
            this.prodavacBox.Name = "prodavacBox";
            this.prodavacBox.PasswordChar = '\0';
            this.prodavacBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prodavacBox.SelectedText = "";
            this.prodavacBox.SelectionLength = 0;
            this.prodavacBox.SelectionStart = 0;
            this.prodavacBox.ShortcutsEnabled = true;
            this.prodavacBox.Size = new System.Drawing.Size(199, 23);
            this.prodavacBox.TabIndex = 6;
            this.prodavacBox.UseSelectable = true;
            this.prodavacBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prodavacBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nazivBox
            // 
            // 
            // 
            // 
            this.nazivBox.CustomButton.Image = null;
            this.nazivBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.nazivBox.CustomButton.Name = "";
            this.nazivBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nazivBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nazivBox.CustomButton.TabIndex = 1;
            this.nazivBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nazivBox.CustomButton.UseSelectable = true;
            this.nazivBox.CustomButton.Visible = false;
            this.nazivBox.Lines = new string[0];
            this.nazivBox.Location = new System.Drawing.Point(144, 432);
            this.nazivBox.MaxLength = 32767;
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.PasswordChar = '\0';
            this.nazivBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nazivBox.SelectedText = "";
            this.nazivBox.SelectionLength = 0;
            this.nazivBox.SelectionStart = 0;
            this.nazivBox.ShortcutsEnabled = true;
            this.nazivBox.Size = new System.Drawing.Size(199, 23);
            this.nazivBox.TabIndex = 7;
            this.nazivBox.UseSelectable = true;
            this.nazivBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nazivBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kolicinaBox
            // 
            // 
            // 
            // 
            this.kolicinaBox.CustomButton.Image = null;
            this.kolicinaBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.kolicinaBox.CustomButton.Name = "";
            this.kolicinaBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kolicinaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kolicinaBox.CustomButton.TabIndex = 1;
            this.kolicinaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kolicinaBox.CustomButton.UseSelectable = true;
            this.kolicinaBox.CustomButton.Visible = false;
            this.kolicinaBox.Lines = new string[0];
            this.kolicinaBox.Location = new System.Drawing.Point(144, 519);
            this.kolicinaBox.MaxLength = 32767;
            this.kolicinaBox.Name = "kolicinaBox";
            this.kolicinaBox.PasswordChar = '\0';
            this.kolicinaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kolicinaBox.SelectedText = "";
            this.kolicinaBox.SelectionLength = 0;
            this.kolicinaBox.SelectionStart = 0;
            this.kolicinaBox.ShortcutsEnabled = true;
            this.kolicinaBox.Size = new System.Drawing.Size(199, 23);
            this.kolicinaBox.TabIndex = 8;
            this.kolicinaBox.UseSelectable = true;
            this.kolicinaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kolicinaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mjBox
            // 
            // 
            // 
            // 
            this.mjBox.CustomButton.Image = null;
            this.mjBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.mjBox.CustomButton.Name = "";
            this.mjBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mjBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mjBox.CustomButton.TabIndex = 1;
            this.mjBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mjBox.CustomButton.UseSelectable = true;
            this.mjBox.CustomButton.Visible = false;
            this.mjBox.Lines = new string[0];
            this.mjBox.Location = new System.Drawing.Point(144, 490);
            this.mjBox.MaxLength = 32767;
            this.mjBox.Name = "mjBox";
            this.mjBox.PasswordChar = '\0';
            this.mjBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mjBox.SelectedText = "";
            this.mjBox.SelectionLength = 0;
            this.mjBox.SelectionStart = 0;
            this.mjBox.ShortcutsEnabled = true;
            this.mjBox.Size = new System.Drawing.Size(199, 23);
            this.mjBox.TabIndex = 9;
            this.mjBox.UseSelectable = true;
            this.mjBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mjBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(11, 432);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(41, 19);
            this.nazivLabel.TabIndex = 10;
            this.nazivLabel.Text = "Naziv";
            // 
            // prodavacLabel
            // 
            this.prodavacLabel.AutoSize = true;
            this.prodavacLabel.Location = new System.Drawing.Point(11, 465);
            this.prodavacLabel.Name = "prodavacLabel";
            this.prodavacLabel.Size = new System.Drawing.Size(64, 19);
            this.prodavacLabel.TabIndex = 11;
            this.prodavacLabel.Text = "Prodavac";
            // 
            // mjLabel
            // 
            this.mjLabel.AutoSize = true;
            this.mjLabel.Location = new System.Drawing.Point(11, 494);
            this.mjLabel.Name = "mjLabel";
            this.mjLabel.Size = new System.Drawing.Size(100, 19);
            this.mjLabel.TabIndex = 12;
            this.mjLabel.Text = "Mjerna Jedinica";
            // 
            // kolicinaLabel
            // 
            this.kolicinaLabel.AutoSize = true;
            this.kolicinaLabel.Location = new System.Drawing.Point(11, 523);
            this.kolicinaLabel.Name = "kolicinaLabel";
            this.kolicinaLabel.Size = new System.Drawing.Size(53, 19);
            this.kolicinaLabel.TabIndex = 13;
            this.kolicinaLabel.Text = "Kolicina";
            // 
            // finishEdit
            // 
            this.finishEdit.Location = new System.Drawing.Point(394, 465);
            this.finishEdit.Name = "finishEdit";
            this.finishEdit.Size = new System.Drawing.Size(148, 42);
            this.finishEdit.TabIndex = 14;
            this.finishEdit.Text = "Edit";
            this.finishEdit.UseSelectable = true;
            this.finishEdit.Click += new System.EventHandler(this.finishEdit_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(83, 395);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(31, 19);
            this.editLabel.TabIndex = 15;
            this.editLabel.Text = "Edit";
            // 
            // skladiste_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.finishEdit);
            this.Controls.Add(this.kolicinaLabel);
            this.Controls.Add(this.mjLabel);
            this.Controls.Add(this.prodavacLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.mjBox);
            this.Controls.Add(this.kolicinaBox);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.prodavacBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.KlickMe);
            this.Controls.Add(this.skladisteGrid);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_home);
            this.Name = "skladiste_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skladiste_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.skladiste_trazi_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Skladiste_trazi_FormClosed);
            this.Load += new System.EventHandler(this.skladiste_trazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladisteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroGrid skladisteGrid;
        private MetroFramework.Controls.MetroButton KlickMe;
        private MetroFramework.Controls.MetroTextBox search;
        private MetroFramework.Controls.MetroTextBox prodavacBox;
        private MetroFramework.Controls.MetroTextBox nazivBox;
        private MetroFramework.Controls.MetroTextBox kolicinaBox;
        private MetroFramework.Controls.MetroTextBox mjBox;
        private MetroFramework.Controls.MetroLabel nazivLabel;
        private MetroFramework.Controls.MetroLabel prodavacLabel;
        private MetroFramework.Controls.MetroLabel mjLabel;
        private MetroFramework.Controls.MetroLabel kolicinaLabel;
        private MetroFramework.Controls.MetroButton finishEdit;
        private MetroFramework.Controls.MetroLabel editLabel;
    }
}