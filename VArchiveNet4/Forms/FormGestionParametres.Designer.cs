using System.Windows.Forms;
using System;

namespace VArchiveNet4.Forms
{
    partial class FormGestionParametres
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
            this.lbVersion = new System.Windows.Forms.Label();
            this.inputArchiveDirectory = new System.Windows.Forms.TextBox();
            this.selectArchiveDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserArchiveDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(7, 4);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(69, 13);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Text = "Version 1.0.0";
            // 
            // inputArchiveDirectory
            // 
            this.inputArchiveDirectory.Location = new System.Drawing.Point(7, 48);
            this.inputArchiveDirectory.Name = "inputArchiveDirectory";
            this.inputArchiveDirectory.Size = new System.Drawing.Size(205, 20);
            this.inputArchiveDirectory.TabIndex = 1;
            // 
            // selectArchiveDirectory
            // 
            this.selectArchiveDirectory.Location = new System.Drawing.Point(216, 48);
            this.selectArchiveDirectory.Name = "selectArchiveDirectory";
            this.selectArchiveDirectory.Size = new System.Drawing.Size(24, 20);
            this.selectArchiveDirectory.TabIndex = 2;
            this.selectArchiveDirectory.Text = "...";
            this.selectArchiveDirectory.UseVisualStyleBackColor = true;
            this.selectArchiveDirectory.Click += new System.EventHandler(this.selectArchiveDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Répertoire des archives";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(222, 363);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(64, 20);
            this.btnAppliquer.TabIndex = 4;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.Appliquer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormGestionParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(293, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectArchiveDirectory);
            this.Controls.Add(this.inputArchiveDirectory);
            this.Controls.Add(this.lbVersion);
            this.Name = "FormGestionParametres";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionParametres";
            this.Load += new System.EventHandler(this.FormGestionParametres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbVersion;
        private TextBox inputArchiveDirectory;
        private Button selectArchiveDirectory;
        private Label label1;
        private FolderBrowserDialog folderBrowserArchiveDirectory;
        private Button btnAppliquer;
        private Button button2;
    }
}