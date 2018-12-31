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
            this.btn_home = new MetroFramework.Controls.MetroButton();
            this.opisPosla = new System.Windows.Forms.RichTextBox();
            this.lbl_opis_posla = new MetroFramework.Controls.MetroLabel();
            this.evidencijaInfo = new MetroFramework.Controls.MetroGrid();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materijalBox = new MetroFramework.Controls.MetroTextBox();
            this.cijenaBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kolicinaBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaInfo)).BeginInit();
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
            // evidencijaInfo
            // 
            this.evidencijaInfo.AllowUserToAddRows = false;
            this.evidencijaInfo.AllowUserToDeleteRows = false;
            this.evidencijaInfo.AllowUserToResizeRows = false;
            this.evidencijaInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.evidencijaInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.evidencijaInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.evidencijaInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.evidencijaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.evidencijaInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.evidencijaInfo.EnableHeadersVisualStyles = false;
            this.evidencijaInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.evidencijaInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.evidencijaInfo.Location = new System.Drawing.Point(21, 83);
            this.evidencijaInfo.Name = "evidencijaInfo";
            this.evidencijaInfo.ReadOnly = true;
            this.evidencijaInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evidencijaInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.evidencijaInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.evidencijaInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evidencijaInfo.Size = new System.Drawing.Size(760, 176);
            this.evidencijaInfo.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(432, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseSelectable = true;
            // 
            // searchText
            // 
            // 
            // 
            // 
            this.searchText.CustomButton.Image = null;
            this.searchText.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.searchText.CustomButton.Name = "";
            this.searchText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchText.CustomButton.TabIndex = 1;
            this.searchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchText.CustomButton.UseSelectable = true;
            this.searchText.CustomButton.Visible = false;
            this.searchText.Lines = new string[0];
            this.searchText.Location = new System.Drawing.Point(243, 32);
            this.searchText.MaxLength = 32767;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.ShortcutsEnabled = true;
            this.searchText.Size = new System.Drawing.Size(177, 23);
            this.searchText.TabIndex = 5;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            //this.materijalBox.Click += new System.EventHandler(this.metroTextBox1_Click);
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
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.evidencijaInfo);
            this.Controls.Add(this.lbl_opis_posla);
            this.Controls.Add(this.opisPosla);
            this.Controls.Add(this.btn_home);
            this.Name = "evidencija_trazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evidencija_trazi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.evidencija_trazi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_home;
        private System.Windows.Forms.RichTextBox opisPosla;
        private MetroFramework.Controls.MetroLabel lbl_opis_posla;
        private MetroFramework.Controls.MetroGrid evidencijaInfo;
        private MetroFramework.Controls.MetroButton searchBtn;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox materijalBox;
        private MetroFramework.Controls.MetroTextBox cijenaBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox kolicinaBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}