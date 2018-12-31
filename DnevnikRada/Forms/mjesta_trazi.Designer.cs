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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.search = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.dataGrid = new MetroFramework.Controls.MetroGrid();
            this.nazivBox = new MetroFramework.Controls.MetroTextBox();
            this.adresaBox = new MetroFramework.Controls.MetroTextBox();
            this.radOdbox = new MetroFramework.Controls.MetroTextBox();
            this.radDoBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishEdit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            // search
            // 
            this.search.Location = new System.Drawing.Point(519, 48);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseSelectable = true;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(176, 104);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(586, 241);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
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
            // finishEdit
            // 
            this.finishEdit.Location = new System.Drawing.Point(460, 440);
            this.finishEdit.Name = "finishEdit";
            this.finishEdit.Size = new System.Drawing.Size(114, 39);
            this.finishEdit.TabIndex = 12;
            this.finishEdit.Text = "edit";
            this.finishEdit.UseSelectable = true;
            this.finishEdit.Click += new System.EventHandler(this.finishEdit_Click);
            // 
            // mjesta_trazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.finishEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radDoBox);
            this.Controls.Add(this.radOdbox);
            this.Controls.Add(this.adresaBox);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btn_home);
            this.Name = "mjesta_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mjesta_trazi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mjesta_trazi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private MetroFramework.Controls.MetroButton search;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroGrid dataGrid;
        private MetroFramework.Controls.MetroTextBox nazivBox;
        private MetroFramework.Controls.MetroTextBox adresaBox;
        private MetroFramework.Controls.MetroTextBox radOdbox;
        private MetroFramework.Controls.MetroTextBox radDoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton finishEdit;
    }
}