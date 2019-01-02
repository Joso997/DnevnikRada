namespace DnevnikRada
{
    partial class mjesta_trazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mjesta_trazi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Home = new MetroFramework.Controls.MetroButton();
            this.Trazi = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.mjestoGrid = new MetroFramework.Controls.MetroGrid();
            this.nazivBox = new MetroFramework.Controls.MetroTextBox();
            this.adresaBox = new MetroFramework.Controls.MetroTextBox();
            this.radOdbox = new MetroFramework.Controls.MetroTextBox();
            this.radDoBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mjestoGrid)).BeginInit();
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
            this.Trazi.Location = new System.Drawing.Point(519, 48);
            this.Trazi.Name = "Trazi";
            this.Trazi.Size = new System.Drawing.Size(180, 23);
            this.Trazi.TabIndex = 1;
            this.Trazi.Text = "Search";
            this.Trazi.UseSelectable = true;
            this.Trazi.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // searchText
            // 
            // 
            // 
            // 
            this.searchText.CustomButton.Image = null;
            this.searchText.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.searchText.CustomButton.Name = "";
            this.searchText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchText.CustomButton.TabIndex = 1;
            this.searchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchText.CustomButton.UseSelectable = true;
            this.searchText.CustomButton.Visible = false;
            this.searchText.Lines = new string[] {
        "WuuwuWUWUWUwuwuWU"};
            this.searchText.Location = new System.Drawing.Point(230, 48);
            this.searchText.MaxLength = 32767;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.ShortcutsEnabled = true;
            this.searchText.Size = new System.Drawing.Size(214, 23);
            this.searchText.TabIndex = 2;
            this.searchText.Text = "WuuwuWUWUWUwuwuWU";
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
            this.mjestoGrid.Location = new System.Drawing.Point(176, 104);
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
            this.mjestoGrid.Size = new System.Drawing.Size(586, 241);
            this.mjestoGrid.TabIndex = 3;
            this.mjestoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // nazivBox
            // 
            // 
            // 
            // 
            this.nazivBox.CustomButton.Image = null;
            this.nazivBox.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.nazivBox.CustomButton.Name = "";
            this.nazivBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nazivBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nazivBox.CustomButton.TabIndex = 1;
            this.nazivBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nazivBox.CustomButton.UseSelectable = true;
            this.nazivBox.CustomButton.Visible = false;
            this.nazivBox.Lines = new string[0];
            this.nazivBox.Location = new System.Drawing.Point(176, 388);
            this.nazivBox.MaxLength = 32767;
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.PasswordChar = '\0';
            this.nazivBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nazivBox.SelectedText = "";
            this.nazivBox.SelectionLength = 0;
            this.nazivBox.SelectionStart = 0;
            this.nazivBox.ShortcutsEnabled = true;
            this.nazivBox.Size = new System.Drawing.Size(214, 23);
            this.nazivBox.TabIndex = 4;
            this.nazivBox.UseSelectable = true;
            this.nazivBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nazivBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adresaBox
            // 
            // 
            // 
            // 
            this.adresaBox.CustomButton.Image = null;
            this.adresaBox.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.adresaBox.CustomButton.Name = "";
            this.adresaBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adresaBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adresaBox.CustomButton.TabIndex = 1;
            this.adresaBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adresaBox.CustomButton.UseSelectable = true;
            this.adresaBox.CustomButton.Visible = false;
            this.adresaBox.Lines = new string[0];
            this.adresaBox.Location = new System.Drawing.Point(176, 430);
            this.adresaBox.MaxLength = 32767;
            this.adresaBox.Name = "adresaBox";
            this.adresaBox.PasswordChar = '\0';
            this.adresaBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adresaBox.SelectedText = "";
            this.adresaBox.SelectionLength = 0;
            this.adresaBox.SelectionStart = 0;
            this.adresaBox.ShortcutsEnabled = true;
            this.adresaBox.Size = new System.Drawing.Size(214, 23);
            this.adresaBox.TabIndex = 5;
            this.adresaBox.UseSelectable = true;
            this.adresaBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adresaBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radOdbox
            // 
            // 
            // 
            // 
            this.radOdbox.CustomButton.Image = null;
            this.radOdbox.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.radOdbox.CustomButton.Name = "";
            this.radOdbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.radOdbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.radOdbox.CustomButton.TabIndex = 1;
            this.radOdbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radOdbox.CustomButton.UseSelectable = true;
            this.radOdbox.CustomButton.Visible = false;
            this.radOdbox.Lines = new string[0];
            this.radOdbox.Location = new System.Drawing.Point(176, 470);
            this.radOdbox.MaxLength = 32767;
            this.radOdbox.Name = "radOdbox";
            this.radOdbox.PasswordChar = '\0';
            this.radOdbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.radOdbox.SelectedText = "";
            this.radOdbox.SelectionLength = 0;
            this.radOdbox.SelectionStart = 0;
            this.radOdbox.ShortcutsEnabled = true;
            this.radOdbox.Size = new System.Drawing.Size(214, 23);
            this.radOdbox.TabIndex = 6;
            this.radOdbox.UseSelectable = true;
            this.radOdbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.radOdbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radDoBox
            // 
            // 
            // 
            // 
            this.radDoBox.CustomButton.Image = null;
            this.radDoBox.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.radDoBox.CustomButton.Name = "";
            this.radDoBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.radDoBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.radDoBox.CustomButton.TabIndex = 1;
            this.radDoBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radDoBox.CustomButton.UseSelectable = true;
            this.radDoBox.CustomButton.Visible = false;
            this.radDoBox.Lines = new string[0];
            this.radDoBox.Location = new System.Drawing.Point(176, 513);
            this.radDoBox.MaxLength = 32767;
            this.radDoBox.Name = "radDoBox";
            this.radDoBox.PasswordChar = '\0';
            this.radDoBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.radDoBox.SelectedText = "";
            this.radDoBox.SelectionLength = 0;
            this.radDoBox.SelectionStart = 0;
            this.radDoBox.ShortcutsEnabled = true;
            this.radDoBox.Size = new System.Drawing.Size(214, 23);
            this.radDoBox.TabIndex = 7;
            this.radDoBox.UseSelectable = true;
            this.radDoBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.radDoBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vrijeme rada od ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vrijeme rada do";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(460, 440);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(114, 39);
            this.Edit.TabIndex = 12;
            this.Edit.Text = "edit";
            this.Edit.UseSelectable = true;
            this.Edit.Click += new System.EventHandler(this.Click_Gumb);
            // 
            // mjesta_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radDoBox);
            this.Controls.Add(this.radOdbox);
            this.Controls.Add(this.adresaBox);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.mjestoGrid);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.Trazi);
            this.Controls.Add(this.Home);
            this.Name = "mjesta_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_trazi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.This_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mjestoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Home;
        private MetroFramework.Controls.MetroButton Trazi;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroGrid mjestoGrid;
        private MetroFramework.Controls.MetroTextBox nazivBox;
        private MetroFramework.Controls.MetroTextBox adresaBox;
        private MetroFramework.Controls.MetroTextBox radOdbox;
        private MetroFramework.Controls.MetroTextBox radDoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton Edit;
    }
}