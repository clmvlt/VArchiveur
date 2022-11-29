using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VArchiveNet4.Methods_et_Procedures;
using VArchiveNet4.Objects;

namespace VArchiveNet4.Forms
{
    public partial class FormFinder : Form
    { 
        private Dictionary<string, string> archiveProperties;
        private List<string> archivesFilesNames;
        public static ListBox sLbSearchedItems;
        public FormFinder(List<string> archivesFileNames)
        {
            InitializeComponent();
            archiveProperties = new Dictionary<string, string>();
            this.archivesFilesNames = archivesFileNames;

            lbSearchedItems.DrawMode = DrawMode.OwnerDrawFixed;
            sLbSearchedItems = lbSearchedItems;
        }

        public FormFinder(List<string> archivesFileNames, ListBox lbLast)
        {
            InitializeComponent();
            archiveProperties = new Dictionary<string, string>();
            this.archivesFilesNames = archivesFileNames;

            lbSearchedItems.DrawMode = DrawMode.OwnerDrawFixed;
            lbSearchedItems.Items.Clear();
            lbSearchedItems.Items.AddRange(lbLast.Items);
            sLbSearchedItems = lbSearchedItems;
        }

        // Lancement de la recherche
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lblRechercheEnCours.Visible = true;
            lbSearchedItems.Items.Clear();
            Form1.sTvVirtualRep.Nodes.Clear();
            lblLignes.Text = $"Lignes : 0 Archive : " + string.Join(", ", archivesFilesNames);
            string search = inputSearch.Text;
            string positionArbre = string.Empty;
            string currentRep = string.Empty;
            int compteurLignes = 0;
            bool searchIgnoreCase = !cbxIgnoreCase.Checked;
            int nbLine = 0;
            string repArchive = Form1.currentArchiveRep + @"\";
            Form1.formLoading.Show();
            foreach (string archiveFileName in archivesFilesNames)
            {
                archiveProperties.Clear();
                lblRechercheEnCours.Text = "Lecture : " + archiveFileName;
                // Regarde si l'archive est existante
                if (!archiveFileName.IsFileExist())
                {
                    MessageBox.Show($"{archiveFileName} inexistante", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                try
                {
                    nbLine = new StreamReader(repArchive + archiveFileName).ReadToEnd().Count();
                    StreamReader sr = new StreamReader(repArchive + archiveFileName, Encoding.UTF8);
                    var ligne = sr.ReadLine();
                    // Lecture de l'archive
                    while (ligne != null)
                    {
                        // Récupération de la position de lecture du fichier (par rapport aux balises)
                        if (ligne.StartsWith('<'.ToString()))
                        {
                            positionArbre = ligne;
                            ligne = sr.ReadLine();
                            if (ligne == null) return;
                        }

                        // Si la lecture se fait en dessous de la balise <head>
                        if (positionArbre.StartsWith("<head>"))
                        {
                            // Lecture des propriétés de l'archive
                            string[] args = ligne.Split('=');
                            if (args.Length > 1 && args[1] != "")
                            {
                                archiveProperties.Add(args[0], args[1]);
                            }
                        }
                        // Si la lecture se fait en dessous de la balise <tree>
                        else if (positionArbre.StartsWith("<tree>"))
                        {
                            // Si lecture de repertoire
                            if (ligne.StartsWith(@"\"))
                            {
                                currentRep = archiveProperties["Name"] + ligne;
                            }
                            // Lecture autre qu'un répertoire
                            else
                            {
                                string[] args = ligne.Split('\t');

                                string name = args[0];
                                string size = args[1];
                                string date = args[2];
                                string attribues = args[3];
                                bool isFile = true;
                                // Si la recherche correspond à la ligne
                                if (name.WildCardMatch(search, searchIgnoreCase))
                                {
                                    if (attribues[0] == 'd') isFile = false;

                                    Font font = new Font(lbSearchedItems.Font.FontFamily, lbSearchedItems.Font.Size, FontStyle.Bold);
                                    Ligne currentLine = new Ligne(currentRep, name, isFile, uint.Parse(size), date, attribues, archiveFileName);

                                    //Form1.sTvVirtualRep.CréerVirtualRep(currentRep + name, !isFile);


                                    if (currentLine.IsFile)
                                    {
                                        if (!cbRepUnique.Checked) lbSearchedItems.Items.Add(currentLine);
                                    }
                                    else
                                    {
                                        lbSearchedItems.Items.Add(currentLine);
                                    }
                                    
                                    compteurLignes++;
                                    lblLignes.Text = $"Lignes : {compteurLignes} " + string.Join(", ", archivesFilesNames);
                                }
                            }
                        }
                        ligne = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            lblRechercheEnCours.Visible = false;
            Form1.formLoading.Hide();
        }

        // Si bouton annuler appuyer alors ça ferme la fenêtre
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFinder_Load(object sender, EventArgs e)
        {
            lblLignes.Text = "Lignes : " + (lbSearchedItems == null ? 0 : lbSearchedItems.Items.Count) + " Archive(s) : " + string.Join(", ", archivesFilesNames);
        }

        private void lbSearchedItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Ligne sel = ((Ligne)lbSearchedItems.SelectedItem);
                if (sel == null) return;
                Form1.sTvVirtualRep.AddSpecificRep(sel.ArchiveName, Form1.currentArchiveRep);
                string rep = sel.FileRep.Replace(char.Parse("\\"), '/') + sel.FileName;
                if (!rep.EndsWith("/")) rep += "/";
                Form1.sTvVirtualRep.SelectedNode = Form1.sTvVirtualRep.Nodes.Find(rep, true)[0];
                Form1.sLvArchives.Show();
                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbSearchedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSearchedItems_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isFile = ((Ligne)((ListBox)sender).Items[e.Index]).IsFile;
            Font font = new Font(e.Font, isFile ? FontStyle.Regular : FontStyle.Bold);
            e.Graphics.DrawString(lbSearchedItems.Items[e.Index].ToString(), font, new SolidBrush(lbSearchedItems.ForeColor), e.Bounds);
            e.DrawFocusRectangle();
        }

        private void lblLignes_Click(object sender, EventArgs e)
        {

        }
    }
}
