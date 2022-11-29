using System.Collections.Generic;
using VArchiveNet4.Methods_et_Procedures;
using System.Windows.Forms;
using System;
using VArchiveNet4.Forms;
using System.Drawing;
using VArchiveNet4.Objects;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace VArchiveNet4
{
    public partial class Form1 : Form
    {
        FormCreationArchive formCreationArchive;
        FormFinder formFinder = new FormFinder(new List<string>());
        FormGestionParametres formParametres;
        List<string> nomsArchives;

        public static FormLoading formLoading;


        public static ListView sLvArchives;
        public static TreeView sTvVirtualRep;
        public static Form1 instance;
        public static SplitContainer scBottom;
        public static string currentArchiveRep;

        public Form1()
        {
            InitializeComponent();
            GestionParametres.LoadSettings();
            formCreationArchive = new FormCreationArchive();
            formParametres = new FormGestionParametres();
            formLoading = new FormLoading();

            sLvArchives = lvArchives;
            sTvVirtualRep = tvVirtualRep;
            instance = this;
            scBottom = splitContainer2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Extensions.lvArchivesRefresh();
            currentArchiveRep = GestionParametres.ArchivesDirectory;
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCreationArchive.Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void parametresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParametres.ShowDialog();
        }

        private void lvArchives_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbbFind_Click(object sender, EventArgs e)
        {
            if (lvArchives.SelectedItems.Count < 1)
            {
                MessageBox.Show("Archive non selectionnée", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nomsArchives = new List<string>();
            foreach (ListViewItem nomArchive in lvArchives.SelectedItems)
            {
                nomsArchives.Add(nomArchive.SubItems[0].Text);
            }
            formFinder = new Forms.FormFinder(nomsArchives, FormFinder.sLbSearchedItems);
            formFinder.ShowDialog();
            
        }

        private void tbbFindAll_Click(object sender, EventArgs e)
        {
            nomsArchives = new List<string>();
            foreach (ListViewItem nomArchive in lvArchives.Items)
            {
                nomsArchives.Add(nomArchive.SubItems[0].Text);
            }
            formFinder = new Forms.FormFinder(nomsArchives, FormFinder.sLbSearchedItems);
            formFinder.ShowDialog();
        }

        private void lvArchives_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(ListView))
            {
                try
                {
                    foreach (ListViewItem item in ((ListView)sender).SelectedItems)
                    {
                        tvVirtualRep.AddSpecificRep(item.Text, currentArchiveRep);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tvVirtualRep_DoubleClick(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(TreeView)) return;
            TreeNode selected = ((TreeView)sender).SelectedNode;
            Ligne selectedLine = FormFinder.sLbSearchedItems.GetLigne(selected.FullPath);
            if (selectedLine == null) return;

            lbInformations.Items.Clear();
            lbInformations.Items.Add("Création : " + selectedLine.CreationDate);
            lbInformations.Items.Add("Nom du fichier : " + selectedLine.FileName);
            lbInformations.Items.Add("Répertoire : " + selectedLine.FileRep);
            lbInformations.Items.Add("Nom de l'archive : " + selectedLine.ArchiveName);
            lbInformations.Items.Add("Type : " + (selectedLine.IsFile ? "Fichier" : "Dossier"));
            lbInformations.Items.Add("Taille : " + Math.Round(((double)selectedLine.Size / 1000000), 2) + " Mo");
        }

        private void tbbOpenRep_Click(object sender, EventArgs e)
        {
            var folderBrowser = new CommonOpenFileDialog { IsFolderPicker = true };
            folderBrowser.ShowDialog();
            if (!Directory.Exists(folderBrowser.FileName)) return;
            if (folderBrowser.FileName == null) return;
            Extensions.lvArchivesRefresh(folderBrowser.FileName);
            currentArchiveRep = folderBrowser.FileName;
            GestionParametres.ArchivesDirectory = folderBrowser.FileName;
            GestionParametres.SaveSettings();
        }

        private void tbbOpenFile_Click(object sender, EventArgs e)
        {
            formCreationArchive.ShowDialog();
        }

        private void tbbNewFile_Click(object sender, EventArgs e)
        {
            var fileBrowser = new CommonOpenFileDialog { IsFolderPicker = false, ShowHiddenItems = false, Multiselect = true };
            fileBrowser.ShowDialog();
            if (fileBrowser.FileName == null) return;
            foreach (string fileName in fileBrowser.FileNames)
            {
                if (File.Exists(fileName))
                {
                    if (File.Exists(GestionParametres.ArchivesDirectory + "\\" + Path.GetFileName(fileName))) continue;
                    File.Copy(fileName, GestionParametres.ArchivesDirectory + "\\" + Path.GetFileName(fileName), false);
                }
            }
            Extensions.lvArchivesRefresh();
        }
    }
}