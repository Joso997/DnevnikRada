namespace DnevnikRada
{
    partial class ucModule1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RadniSati = new System.Windows.Forms.Label();
            this.VrijednostMaterijala = new System.Windows.Forms.Label();
            this.brojEvidencija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radni Sati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ukupna Vrijednost Materijala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj Evidencija";
            // 
            // RadniSati
            // 
            this.RadniSati.AutoSize = true;
            this.RadniSati.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RadniSati.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadniSati.Location = new System.Drawing.Point(274, 99);
            this.RadniSati.Name = "RadniSati";
            this.RadniSati.Size = new System.Drawing.Size(38, 41);
            this.RadniSati.TabIndex = 3;
            this.RadniSati.Text = "0";
            // 
            // VrijednostMaterijala
            // 
            this.VrijednostMaterijala.AutoSize = true;
            this.VrijednostMaterijala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VrijednostMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VrijednostMaterijala.Location = new System.Drawing.Point(274, 257);
            this.VrijednostMaterijala.Name = "VrijednostMaterijala";
            this.VrijednostMaterijala.Size = new System.Drawing.Size(38, 41);
            this.VrijednostMaterijala.TabIndex = 4;
            this.VrijednostMaterijala.Text = "0";
            // 
            // brojEvidencija
            // 
            this.brojEvidencija.AutoSize = true;
            this.brojEvidencija.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brojEvidencija.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojEvidencija.Location = new System.Drawing.Point(274, 422);
            this.brojEvidencija.Name = "brojEvidencija";
            this.brojEvidencija.Size = new System.Drawing.Size(38, 41);
            this.brojEvidencija.TabIndex = 5;
            this.brojEvidencija.Text = "0";
            // 
            // ucModule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brojEvidencija);
            this.Controls.Add(this.VrijednostMaterijala);
            this.Controls.Add(this.RadniSati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucModule1";
            this.Size = new System.Drawing.Size(620, 578);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RadniSati;
        private System.Windows.Forms.Label VrijednostMaterijala;
        private System.Windows.Forms.Label brojEvidencija;
    }
}
