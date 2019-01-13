﻿namespace DnevnikRada.Kontrole
{
    partial class UserKalendar
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
            this.PON = new MetroFramework.Controls.MetroLabel();
            this.template = new MetroFramework.Controls.MetroLabel();
            this.UTO = new MetroFramework.Controls.MetroLabel();
            this.SRI = new MetroFramework.Controls.MetroLabel();
            this.ČET = new MetroFramework.Controls.MetroLabel();
            this.PET = new MetroFramework.Controls.MetroLabel();
            this.SUB = new MetroFramework.Controls.MetroLabel();
            this.NED = new MetroFramework.Controls.MetroLabel();
            this.Mjesec_Godina = new MetroFramework.Controls.MetroLabel();
            this.Previous = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PON
            // 
            this.PON.Location = new System.Drawing.Point(0, 0);
            this.PON.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.PON.Name = "PON";
            this.PON.Size = new System.Drawing.Size(40, 30);
            this.PON.TabIndex = 2;
            this.PON.Text = "PON";
            this.PON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // template
            // 
            this.template.BackColor = System.Drawing.SystemColors.ControlDark;
            this.template.Location = new System.Drawing.Point(5, 40);
            this.template.Margin = new System.Windows.Forms.Padding(5, 10, 7, 0);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(30, 30);
            this.template.TabIndex = 3;
            this.template.Text = "1";
            this.template.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.template.UseCustomBackColor = true;
            this.template.Visible = false;
            // 
            // UTO
            // 
            this.UTO.Location = new System.Drawing.Point(42, 0);
            this.UTO.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.UTO.Name = "UTO";
            this.UTO.Size = new System.Drawing.Size(40, 30);
            this.UTO.TabIndex = 4;
            this.UTO.Text = "UTO";
            this.UTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SRI
            // 
            this.SRI.Location = new System.Drawing.Point(84, 0);
            this.SRI.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.SRI.Name = "SRI";
            this.SRI.Size = new System.Drawing.Size(40, 30);
            this.SRI.TabIndex = 5;
            this.SRI.Text = "SRI";
            this.SRI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ČET
            // 
            this.ČET.Location = new System.Drawing.Point(126, 0);
            this.ČET.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.ČET.Name = "ČET";
            this.ČET.Size = new System.Drawing.Size(40, 30);
            this.ČET.TabIndex = 6;
            this.ČET.Text = "ČET";
            this.ČET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PET
            // 
            this.PET.Location = new System.Drawing.Point(168, 0);
            this.PET.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.PET.Name = "PET";
            this.PET.Size = new System.Drawing.Size(40, 30);
            this.PET.TabIndex = 7;
            this.PET.Text = "PET";
            this.PET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SUB
            // 
            this.SUB.Location = new System.Drawing.Point(210, 0);
            this.SUB.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(40, 30);
            this.SUB.TabIndex = 8;
            this.SUB.Text = "SUB";
            this.SUB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NED
            // 
            this.NED.Location = new System.Drawing.Point(252, 0);
            this.NED.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.NED.Name = "NED";
            this.NED.Size = new System.Drawing.Size(40, 30);
            this.NED.TabIndex = 9;
            this.NED.Text = "NED";
            this.NED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mjesec_Godina
            // 
            this.Mjesec_Godina.Location = new System.Drawing.Point(0, 240);
            this.Mjesec_Godina.Margin = new System.Windows.Forms.Padding(5, 10, 7, 0);
            this.Mjesec_Godina.Name = "Mjesec_Godina";
            this.Mjesec_Godina.Size = new System.Drawing.Size(208, 30);
            this.Mjesec_Godina.TabIndex = 20;
            this.Mjesec_Godina.Text = "1";
            this.Mjesec_Godina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Previous
            // 
            this.Previous.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Previous.Location = new System.Drawing.Point(210, 240);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(40, 30);
            this.Previous.TabIndex = 21;
            this.Previous.Text = "<";
            this.Previous.UseSelectable = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Next.Location = new System.Drawing.Point(251, 240);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(40, 30);
            this.Next.TabIndex = 22;
            this.Next.Text = ">";
            this.Next.UseSelectable = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // UserKalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.template);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Mjesec_Godina);
            this.Controls.Add(this.NED);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.PET);
            this.Controls.Add(this.ČET);
            this.Controls.Add(this.SRI);
            this.Controls.Add(this.UTO);
            this.Controls.Add(this.PON);
            this.Name = "UserKalendar";
            this.Size = new System.Drawing.Size(291, 270);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel PON;
        private MetroFramework.Controls.MetroLabel template;
        private MetroFramework.Controls.MetroLabel UTO;
        private MetroFramework.Controls.MetroLabel SRI;
        private MetroFramework.Controls.MetroLabel ČET;
        private MetroFramework.Controls.MetroLabel PET;
        private MetroFramework.Controls.MetroLabel SUB;
        private MetroFramework.Controls.MetroLabel NED;
        private MetroFramework.Controls.MetroLabel Mjesec_Godina;
        private MetroFramework.Controls.MetroButton Previous;
        private MetroFramework.Controls.MetroButton Next;
    }
}