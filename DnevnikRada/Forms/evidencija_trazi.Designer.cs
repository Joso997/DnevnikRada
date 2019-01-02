namespace DnevnikRada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.opisPosla = new System.Windows.Forms.RichTextBox();
            this.lbl_opis_posla = new MetroFramework.Controls.MetroLabel();
            this.evidencijaGrid = new MetroFramework.Controls.MetroGrid();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.textTrazi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materijalBox = new MetroFramework.Controls.MetroTextBox();
            this.cijenaBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kolicinaBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaGrid)).BeginInit();
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
            this.opisPosla.Location = new System.Drawing.Point(21, 294);
            this.opisPosla.Name = "opisPosla";
            this.opisPosla.Size = new System.Drawing.Size(530, 262);
            this.opisPosla.TabIndex = 1;
            this.opisPosla.Text = "";
            // 
            // lbl_opis_posla
            // 
            this.lbl_opis_posla.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_opis_posla.Location = new System.Drawing.Point(21, 262);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.evidencijaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.evidencijaGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.evidencijaGrid.EnableHeadersVisualStyles = false;
            this.evidencijaGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.evidencijaGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.evidencijaGrid.Location = new System.Drawing.Point(21, 83);
            this.evidencijaGrid.Name = "evidencijaGrid";
            this.evidencijaGrid.ReadOnly = true;
            this.evidencijaGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.evidencijaGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.evidencijaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evidencijaGrid.Size = new System.Drawing.Size(760, 176);
            this.evidencijaGrid.TabIndex = 3;
            // 
            // Trazi
            // 
            this.Trazi.Location = new System.Drawing.Point(432, 32);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(150, 23);
            this.Trazi.TabIndex = 4;
            this.Trazi.Text = "Search";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // textTrazi
            // 
            // 
            // 
            // 
            this.textTrazi.CustomButton.Image = null;
            this.textTrazi.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.textTrazi.CustomButton.Name = "";
            this.textTrazi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textTrazi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textTrazi.CustomButton.TabIndex = 1;
            this.textTrazi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textTrazi.CustomButton.UseSelectable = true;
            this.textTrazi.CustomButton.Visible = false;
            this.textTrazi.Lines = new string[0];
            this.textTrazi.Location = new System.Drawing.Point(243, 32);
            this.textTrazi.MaxLength = 32767;
            this.textTrazi.Name = "textTrazi";
            this.textTrazi.PasswordChar = '\0';
            this.textTrazi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textTrazi.SelectedText = "";
            this.textTrazi.SelectionLength = 0;
            this.textTrazi.SelectionStart = 0;
            this.textTrazi.ShortcutsEnabled = true;
            this.textTrazi.Size = new System.Drawing.Size(177, 23);
            this.textTrazi.TabIndex = 5;
            this.textTrazi.UseSelectable = true;
            this.textTrazi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textTrazi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(580, 294);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Materijal";
            // 
            // materijalBox
            // 
            // 
            // 
            // 
            this.materijalBox.CustomButton.Image = null;
            this.materijalBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.materijalBox.CustomButton.Name = "";
            this.materijalBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.materijalBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.materijalBox.CustomButton.TabIndex = 1;
            this.materijalBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.materijalBox.CustomButton.UseSelectable = true;
            this.materijalBox.CustomButton.Visible = false;
            this.materijalBox.Lines = new string[0];
            this.materijalBox.Location = new System.Drawing.Point(580, 316);
            this.materijalBox.MaxLength = 32767;
            this.materijalBox.Name = "materijalBox";
            this.materijalBox.PasswordChar = '\0';
            this.materijalBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materijalBox.SelectedText = "";
            this.materijalBox.SelectionLength = 0;
            this.materijalBox.SelectionStart = 0;
            this.materijalBox.ShortcutsEnabled = true;
            this.materijalBox.Size = new System.Drawing.Size(130, 23);
            this.materijalBox.TabIndex = 7;
            this.materijalBox.UseSelectable = true;
            this.materijalBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.materijalBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cijenaBox
            // 
            // 
            // 
            // 
            this.cijenaBox.CustomButton.Image = null;
            this.cijenaBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.cijenaBox.CustomButton.Name = "";
            this.cijenaBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cijenaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cijenaBox.CustomButton.TabIndex = 1;
            this.cijenaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cijenaBox.CustomButton.UseSelectable = true;
            this.cijenaBox.CustomButton.Visible = false;
            this.cijenaBox.Lines = new string[0];
            this.cijenaBox.Location = new System.Drawing.Point(580, 379);
            this.cijenaBox.MaxLength = 32767;
            this.cijenaBox.Name = "cijenaBox";
            this.cijenaBox.PasswordChar = '\0';
            this.cijenaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cijenaBox.SelectedText = "";
            this.cijenaBox.SelectionLength = 0;
            this.cijenaBox.SelectionStart = 0;
            this.cijenaBox.ShortcutsEnabled = true;
            this.cijenaBox.Size = new System.Drawing.Size(130, 23);
            this.cijenaBox.TabIndex = 9;
            this.cijenaBox.UseSelectable = true;
            this.cijenaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cijenaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(580, 357);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Cijena";
            // 
            // kolicinaBox
            // 
            // 
            // 
            // 
            this.kolicinaBox.CustomButton.Image = null;
            this.kolicinaBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.kolicinaBox.CustomButton.Name = "";
            this.kolicinaBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kolicinaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kolicinaBox.CustomButton.TabIndex = 1;
            this.kolicinaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kolicinaBox.CustomButton.UseSelectable = true;
            this.kolicinaBox.CustomButton.Visible = false;
            this.kolicinaBox.Lines = new string[0];
            this.kolicinaBox.Location = new System.Drawing.Point(580, 447);
            this.kolicinaBox.MaxLength = 32767;
            this.kolicinaBox.Name = "kolicinaBox";
            this.kolicinaBox.PasswordChar = '\0';
            this.kolicinaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kolicinaBox.SelectedText = "";
            this.kolicinaBox.SelectionLength = 0;
            this.kolicinaBox.SelectionStart = 0;
            this.kolicinaBox.ShortcutsEnabled = true;
            this.kolicinaBox.Size = new System.Drawing.Size(130, 23);
            this.kolicinaBox.TabIndex = 11;
            this.kolicinaBox.UseSelectable = true;
            this.kolicinaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kolicinaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(580, 425);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Kolicina";
            // 
            // evidencija_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.kolicinaBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cijenaBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.materijalBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textTrazi);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.evidencijaGrid);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.opisPosla);
            this.Controls.Add(this.Home);
            this.Name = "evidencija_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evidencija_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaGrid)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox materijalBox;
        private MetroFramework.Controls.MetroTextBox cijenaBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox kolicinaBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}