using System.Windows.Forms;

namespace VArchiveNet4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvArchives = new System.Windows.Forms.ListView();
            this.chArchivesNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreateArchive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTaille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvVirtualRep = new System.Windows.Forms.TreeView();
            this.imgListVirtRep = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInformations = new System.Windows.Forms.ListBox();
            this.tbrFonctions = new System.Windows.Forms.MenuStrip();
            this.tbbOpenRep = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbFindAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbrFonctions.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvArchives);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(924, 484);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvArchives
            // 
            this.lvArchives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chArchivesNom,
            this.chCreateArchive,
            this.chTaille});
            this.lvArchives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArchives.HideSelection = false;
            this.lvArchives.Location = new System.Drawing.Point(0, 0);
            this.lvArchives.Name = "lvArchives";
            this.lvArchives.Size = new System.Drawing.Size(924, 240);
            this.lvArchives.TabIndex = 0;
            this.lvArchives.UseCompatibleStateImageBehavior = false;
            this.lvArchives.View = System.Windows.Forms.View.Details;
            this.lvArchives.SelectedIndexChanged += new System.EventHandler(this.lvArchives_SelectedIndexChanged);
            this.lvArchives.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvArchives_MouseDoubleClick);
            // 
            // chArchivesNom
            // 
            this.chArchivesNom.Text = "Nom";
            this.chArchivesNom.Width = 518;
            // 
            // chCreateArchive
            // 
            this.chCreateArchive.Text = "Date de création";
            this.chCreateArchive.Width = 135;
            // 
            // chTaille
            // 
            this.chTaille.Text = "Taille";
            this.chTaille.Width = 152;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvVirtualRep);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(924, 241);
            this.splitContainer2.SplitterDistance = 452;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvVirtualRep
            // 
            this.tvVirtualRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvVirtualRep.ImageIndex = 0;
            this.tvVirtualRep.ImageList = this.imgListVirtRep;
            this.tvVirtualRep.Location = new System.Drawing.Point(0, 0);
            this.tvVirtualRep.Name = "tvVirtualRep";
            this.tvVirtualRep.SelectedImageIndex = 0;
            this.tvVirtualRep.ShowRootLines = false;
            this.tvVirtualRep.Size = new System.Drawing.Size(452, 241);
            this.tvVirtualRep.TabIndex = 0;
            this.tvVirtualRep.DoubleClick += new System.EventHandler(this.tvVirtualRep_DoubleClick);
            // 
            // imgListVirtRep
            // 
            this.imgListVirtRep.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListVirtRep.ImageStream")));
            this.imgListVirtRep.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListVirtRep.Images.SetKeyName(0, "folder.png");
            this.imgListVirtRep.Images.SetKeyName(1, "file.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInformations);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // lbInformations
            // 
            this.lbInformations.FormattingEnabled = true;
            this.lbInformations.HorizontalScrollbar = true;
            this.lbInformations.Location = new System.Drawing.Point(6, 18);
            this.lbInformations.Name = "lbInformations";
            this.lbInformations.ScrollAlwaysVisible = true;
            this.lbInformations.Size = new System.Drawing.Size(447, 147);
            this.lbInformations.TabIndex = 0;
            // 
            // tbrFonctions
            // 
            this.tbrFonctions.BackColor = System.Drawing.SystemColors.Menu;
            this.tbrFonctions.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tbrFonctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbOpenRep,
            this.tbbOpenFile,
            this.tbbNewFile,
            this.tbbFind,
            this.tbbFindAll});
            this.tbrFonctions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tbrFonctions.Location = new System.Drawing.Point(0, 24);
            this.tbrFonctions.Name = "tbrFonctions";
            this.tbrFonctions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.tbrFonctions.ShowItemToolTips = true;
            this.tbrFonctions.Size = new System.Drawing.Size(924, 39);
            this.tbrFonctions.TabIndex = 2;
            this.tbrFonctions.Text = "Fonctions";
            // 
            // tbbOpenRep
            // 
            this.tbbOpenRep.AutoSize = false;
            this.tbbOpenRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOpenRep.Image = global::VArchiveNet4.Properties.Resources.dossier_48;
            this.tbbOpenRep.Name = "tbbOpenRep";
            this.tbbOpenRep.Size = new System.Drawing.Size(35, 35);
            this.tbbOpenRep.Text = "tbbOpenRep";
            this.tbbOpenRep.ToolTipText = "Ouvrir un nouveau répertoire d\'archives.";
            this.tbbOpenRep.Click += new System.EventHandler(this.tbbOpenRep_Click);
            // 
            // tbbOpenFile
            // 
            this.tbbOpenFile.AutoSize = false;
            this.tbbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOpenFile.Image = global::VArchiveNet4.Properties.Resources.fichier_48;
            this.tbbOpenFile.Name = "tbbOpenFile";
            this.tbbOpenFile.Size = new System.Drawing.Size(35, 35);
            this.tbbOpenFile.ToolTipText = "Utilitaire de création d\'archive.\r\n";
            this.tbbOpenFile.Click += new System.EventHandler(this.tbbOpenFile_Click);
            // 
            // tbbNewFile
            // 
            this.tbbNewFile.AutoSize = false;
            this.tbbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbNewFile.Image = global::VArchiveNet4.Properties.Resources.ajouter_64;
            this.tbbNewFile.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.tbbNewFile.Name = "tbbNewFile";
            this.tbbNewFile.Size = new System.Drawing.Size(35, 35);
            this.tbbNewFile.ToolTipText = "Ajouter une archive dans liste.";
            this.tbbNewFile.Click += new System.EventHandler(this.tbbNewFile_Click);
            // 
            // tbbFind
            // 
            this.tbbFind.AutoSize = false;
            this.tbbFind.AutoToolTip = true;
            this.tbbFind.BackColor = System.Drawing.SystemColors.Menu;
            this.tbbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbFind.Image = global::VArchiveNet4.Properties.Resources.loupe_48;
            this.tbbFind.Name = "tbbFind";
            this.tbbFind.Size = new System.Drawing.Size(35, 35);
            this.tbbFind.ToolTipText = "Recherche sur une ou plusieurs archive(s)";
            this.tbbFind.Click += new System.EventHandler(this.tbbFind_Click);
            // 
            // tbbFindAll
            // 
            this.tbbFindAll.AutoSize = false;
            this.tbbFindAll.AutoToolTip = true;
            this.tbbFindAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbFindAll.Image = global::VArchiveNet4.Properties.Resources.jumelles_48;
            this.tbbFindAll.Name = "tbbFindAll";
            this.tbbFindAll.Size = new System.Drawing.Size(35, 35);
            this.tbbFindAll.ToolTipText = "Recherche sur toutes les archives\r\n\r\n";
            this.tbbFindAll.Click += new System.EventHandler(this.tbbFindAll_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(924, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // paramètresToolStripMenuItem1
            // 
            this.paramètresToolStripMenuItem1.Name = "paramètresToolStripMenuItem1";
            this.paramètresToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem1.Text = "Paramètres";
            this.paramètresToolStripMenuItem1.Click += new System.EventHandler(this.parametresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(924, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbrFonctions);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VArchiver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tbrFonctions.ResumeLayout(false);
            this.tbrFonctions.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SplitContainer splitContainer1;
        private ListView lvArchives;
        private ColumnHeader chArchivesNom;
        private MenuStrip tbrFonctions;
        private ToolStripMenuItem tbbFind;
        private ToolStripMenuItem tbbFindAll;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem paramètresToolStripMenuItem1;
        private ToolStripMenuItem tbbNewFile;
        private SplitContainer splitContainer2;
        private TreeView tvVirtualRep;
        private GroupBox groupBox1;
        private ListBox lbInformations;
        private ToolStripMenuItem tbbOpenFile;
        private ToolStripMenuItem tbbOpenRep;
        private ColumnHeader chCreateArchive;
        private ColumnHeader chTaille;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private ImageList imgListVirtRep;
    }
}