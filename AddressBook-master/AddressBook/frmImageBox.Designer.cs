﻿namespace AddressBook
{
    partial class frmImageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageBox));
            this.ptbContact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContact)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbContact
            // 
            this.ptbContact.Location = new System.Drawing.Point(3, 2);
            this.ptbContact.Name = "ptbContact";
            this.ptbContact.Size = new System.Drawing.Size(794, 446);
            this.ptbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbContact.TabIndex = 0;
            this.ptbContact.TabStop = false;
            // 
            // ContactImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbContact);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactImage";
            ((System.ComponentModel.ISupportInitialize)(this.ptbContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbContact;
    }
}