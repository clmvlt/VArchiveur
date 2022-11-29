using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VArchiveNet4.Objects;
using VArchiveNet4.Forms;
using System.Diagnostics;

namespace VArchiveNet4.Methods_et_Procedures
{
    public static class Extensions
    {
        // Convertir recherche vers une expression générqiue ex : '*.exe'
        private static string WildCardToRegular(this String value)
        {
            return "^" + Regex.Escape(value).Replace("\\?", ".").Replace("\\*", ".*") + "$";
        }

        public static bool WildCardMatch(this String value, string pattern, bool ignoreCase = true)
        {
            if (ignoreCase)
                return Regex.IsMatch(value, WildCardToRegular(pattern), RegexOptions.IgnoreCase);

            return Regex.IsMatch(value, WildCardToRegular(pattern));
        }
        public static bool IsFileExist(this string nomFichier)
        {
            if (File.Exists(Form1.currentArchiveRep + @"\" + nomFichier)) return true;

            MessageBox.Show($"\"{nomFichier}\" inexistant.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public static void lvArchivesRefresh()
        {
            Form1.sLvArchives.Items.Clear();
            string[] archiveFilesList;
            if (!Directory.Exists(GestionParametres.ArchivesDirectory))
            {
                MessageBox.Show("Répertoire des archives inconnu.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            archiveFilesList = Directory.GetFiles(GestionParametres.ArchivesDirectory, "*.cd", SearchOption.TopDirectoryOnly);
            foreach (string archiveFileName in archiveFilesList)
            {
                FileInfo archiveInfo = new FileInfo(archiveFileName);
                if (archiveInfo == null) continue;
                Form1.sLvArchives.Items.Add(new ListViewItem(new string[] { archiveInfo.Name, archiveInfo.CreationTime.ToString(), archiveInfo.Length.ToString() }));
            }
        }

        public static void lvArchivesRefresh(string rep)
        {
            Form1.sLvArchives.Items.Clear();
            string[] archiveFilesList;
            if (!Directory.Exists(rep))
            {
                MessageBox.Show("Répertoire des archives inconnu.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            archiveFilesList = Directory.GetFiles(rep, "*.cd", SearchOption.TopDirectoryOnly);
            foreach (string archiveFileName in archiveFilesList)
            {
                FileInfo archiveInfo = new FileInfo(archiveFileName);
                if (archiveInfo == null) continue;
                Form1.sLvArchives.Items.Add(new ListViewItem(new string[] { archiveInfo.Name, archiveInfo.CreationTime.ToString(), archiveInfo.Length.ToString() }));
            }
        }

        public static bool CréerVirtualRep(this TreeView tree, string rep, bool isDir)
        {
            rep = rep.Replace(char.Parse("\\"), '/');
            string[] args = rep.Split('/');
            if (args.Length == 0) return false;
            string vRepS = string.Empty;

            for (int i = 0; i<args.Length; i++)
            {
                vRepS += args[i] + "/";
                if (tree.Nodes.Find(vRepS, true).Length == 0)
                {
                    string nom = vRepS.Substring(0, vRepS.Length - args[i].Length - 1);
                    if (nom.Length > 0)
                    {
                        tree.Nodes.Find(nom, true)[0].Nodes.Add(vRepS, args[i], 0, 0);
                    } else
                    {
                        tree.Nodes.Add(args[i] + "/", args[i], 0, 0);
                    }
                }
            }
            tree.Nodes.Find(rep + "/", true)[0].SelectedImageIndex = isDir ? 0 : 1;
            tree.Nodes.Find(rep + "/", true)[0].ImageIndex = isDir ? 0 : 1;
            return true;
        }

        public static void AddSpecificRep(this TreeView tv, string nomArchive, string archivesRep, Ligne ligne = null)
        {
            if (tv.Nodes.Find(nomArchive, false).Length > 0) return;
            try
            {
                tv.Nodes.Clear();
                if (!nomArchive.EndsWith(".cd")) nomArchive += ".cd";
                Dictionary<string, string> archiveProperties = new Dictionary<string, string>();
                StreamReader sr = new StreamReader(archivesRep + @"\" + nomArchive, Encoding.UTF8);
                var ligneLu = sr.ReadLine();
                string positionArbre = string.Empty;
                string currentRep = string.Empty;
                // Lecture de l'archive
                while (ligneLu != null)
                {
                    // Récupération de la position de lecture du fichier (par rapport aux balises)
                    if (ligneLu.StartsWith('<'.ToString()))
                    {
                        positionArbre = ligneLu;
                        ligneLu = sr.ReadLine();
                        if (ligneLu == null) return;
                    }

                    // Si la lecture se fait en dessous de la balise <head>
                    if (positionArbre.StartsWith("<head>"))
                    {
                        // Lecture des propriétés de l'archive
                        string[] args = ligneLu.Split('=');
                        if (args.Length > 1 && args[1] != "")
                        {
                            archiveProperties.Add(args[0], args[1]);
                        }
                    }
                    // Si la lecture se fait en dessous de la balise <tree>
                    else if (positionArbre.StartsWith("<tree>"))
                    {
                        // Si lecture de repertoire
                        if (ligneLu.StartsWith(@"\"))
                        {
                            currentRep = archiveProperties["Name"] + ligneLu;
                        }
                        // Lecture autre qu'un répertoire
                        else
                        {

                            string[] args = ligneLu.Split('\t');

                            string name = args[0];
                            string size = args[1];
                            string date = args[2];
                            string attribues = args[3];
                            bool isFile = true;
                            if (attribues[0] == 'd') isFile = false;
                            Form1.sTvVirtualRep.CréerVirtualRep(currentRep + name, !isFile);
                        }
                    }
                    ligneLu = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static Ligne GetLigne(this ListBox lb, string rep)
        {
            foreach (Ligne ligne in lb.Items)
            {
                if (ligne.GetType() != typeof(Ligne)) continue;

                if (ligne.FileRep + ligne.FileName == rep)
                    return ligne;
            }
            return null;
        }
    }
}