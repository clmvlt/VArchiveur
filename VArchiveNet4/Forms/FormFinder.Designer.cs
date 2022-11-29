using System.Windows.Forms;
using System;

namespace VArchiveNet4.Forms
{
    partial class FormFinder
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
            this.btnRechercher = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbRepUnique = new System.Windows.Forms.CheckBox();
            this.inputSearch = new System.Windows.Forms.ComboBox();
            this.cbxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbSearchedItems = new System.Windows.Forms.ListBox();
            this.lblRechercheEnCours = new System.Windows.Forms.Label();
            this.lblLignes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(453, 2);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(87, 26);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbRepUnique);
            this.splitContainer1.Panel1.Controls.Add(this.inputSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cbxIgnoreCase);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnnuler);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRechercher);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1MinSize = 170;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(547, 643);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbRepUnique
            // 
            this.cbRepUnique.AutoSize = true;
            this.cbRepUnique.Location = new System.Drawing.Point(9, 39);
            this.cbRepUnique.Name = "cbRepUnique";
            this.cbRepUnique.Size = new System.Drawing.Size(212, 19);
            this.cbRepUnique.TabIndex = 5;
            this.cbRepUnique.Text = "Afficher uniquement les répertoires";
            this.cbRepUnique.UseVisualStyleBackColor = true;
            // 
            // inputSearch
            // 
            this.inputSearch.FormattingEnabled = true;
            this.inputSearch.Items.AddRange(new object[] {
            "*",
            "*.*",
            "*.exe",
            "*.rar"});
            this.inputSearch.Location = new System.Drawing.Point(9, 3);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(266, 23);
            this.inputSearch.TabIndex = 1;
            this.inputSearch.Text = "*";
            // 
            // cbxIgnoreCase
            // 
            this.cbxIgnoreCase.AutoSize = true;
            this.cbxIgnoreCase.Location = new System.Drawing.Point(281, 5);
            this.cbxIgnoreCase.Name = "cbxIgnoreCase";
            this.cbxIgnoreCase.Size = new System.Drawing.Size(153, 19);
            this.cbxIgnoreCase.TabIndex = 2;
            this.cbxIgnoreCase.Text = "Sensible aux majuscules";
            this.cbxIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(453, 32);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(87, 26);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 170);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbSearchedItems);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblRechercheEnCours);
            this.splitContainer2.Panel2.Controls.Add(this.lblLignes);
            this.splitContainer2.Size = new System.Drawing.Size(547, 469);
            this.splitContainer2.SplitterDistance = 440;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbSearchedItems
            // 
            this.lbSearchedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSearchedItems.FormattingEnabled = true;
            this.lbSearchedItems.ItemHeight = 15;
            this.lbSearchedItems.Location = new System.Drawing.Point(0, 0);
            this.lbSearchedItems.Name = "lbSearchedItems";
            this.lbSearchedItems.Size = new System.Drawing.Size(547, 440);
            this.lbSearchedItems.TabIndex = 6;
            this.lbSearchedItems.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSearchedItems_DrawItem);
            this.lbSearchedItems.SelectedIndexChanged += new System.EventHandler(this.lbSearchedItems_SelectedIndexChanged);
            this.lbSearchedItems.DoubleClick += new System.EventHandler(this.lbSearchedItems_DoubleClick);
            // 
            // lblRechercheEnCours
            // 
            this.lblRechercheEnCours.Location = new System.Drawing.Point(355, 1);
            this.lblRechercheEnCours.Name = "lblRechercheEnCours";
            this.lblRechercheEnCours.Size = new System.Drawing.Size(188, 23);
            this.lblRechercheEnCours.TabIndex = 1;
            this.lblRechercheEnCours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRechercheEnCours.Visible = false;
            // 
            // lblLignes
            // 
            this.lblLignes.AutoSize = true;
            this.lblLignes.Location = new System.Drawing.Point(5, 5);
            this.lblLignes.Name = "lblLignes";
            this.lblLignes.Size = new System.Drawing.Size(96, 15);
            this.lblLignes.TabIndex = 0;
            this.lblLignes.Text = "Lignes : Archive :";
            this.lblLignes.Click += new System.EventHandler(this.lblLignes_Click);
            // 
            // FormFinder
            // 
            this.AcceptButton = this.btnRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(15, 15);
            this.AutoSize = true;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(557, 653);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MinimumSize = new System.Drawing.Size(573, 692);
            this.Name = "FormFinder";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VArchiver - Finder";
            this.Load += new System.EventHandler(this.FormFinder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnRechercher;
        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private Button btnAnnuler;
        private CheckBox cbxIgnoreCase;
        private SplitContainer splitContainer2;
        private Label lblLignes;
        private ComboBox inputSearch;
        private Label lblRechercheEnCours;
        private CheckBox cbRepUnique;
        private ListBox lbSearchedItems;
    }
}