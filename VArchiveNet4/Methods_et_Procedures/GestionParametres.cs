using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VArchiveNet4.Methods_et_Procedures
{
    public static class GestionParametres
    {
        private static string _version;
        private static string _archivesDirectory;

        private static string settingsDirectory = @"Files\settings.app";

        private static StreamReader sr;
        private static StreamWriter sw;

        private static Dictionary<string, string> listeParametres = new Dictionary<string, string>();

        public static void LoadSettings()
        {
            var ligne = string.Empty;
            if (!File.Exists(settingsDirectory)) CreateSettingsFile();
            if (!File.Exists(@".\Archives\Présentation.cd")) CreatePresFile();

            try
            {
                sr = new StreamReader(settingsDirectory);

                ligne = sr.ReadLine();

                while (ligne != null)
                {
                    string[] args = ligne.Split('=');
                    if (args.Length > 1 && args[1] != "")
                    listeParametres.Add(args[0], args[1]);
                    ligne = sr.ReadLine();
                }
                _version = listeParametres["version"];
                _archivesDirectory = listeParametres["archivesDirectory"];

                sr.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreur s'est produite.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveSettings()
        {
            var ligne = string.Empty;
            if (!File.Exists(settingsDirectory)) CreateSettingsFile();

            try
            {
                sw = new StreamWriter(settingsDirectory);

                foreach (var item in listeParametres)
                {
                    sw.WriteLine(item.Key + "=" + item.Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreur s'est produite.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateSettingsFile()
        {
            if (!Directory.Exists("Files")) Directory.CreateDirectory("Files");
            if (!Directory.Exists("Archives")) Directory.CreateDirectory("Archives");
            StreamWriter sw = new StreamWriter(@"Files/settings.app");
            try
            {
                sw.WriteLine("version=1.0.0");
                sw.WriteLine(@"appPath=" + Application.ExecutablePath);
                sw.WriteLine(@"archivesDirectory=Archives");
                sw.Close();
            }
            catch (Exception ex)
            {
                if (sw is object)
                    sw.Close();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreur s'est produite.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreatePresFile()
        {
            StreamWriter swPres = new StreamWriter(@"Archives\Présentation.cd");
            try
            {
                swPres.WriteLine("<head>\n" +
                    "Name=Présentation affichage\n" +
                    "Typ=Fixed\n" +
                    "SubTyp=\n" +
                    "Medium=FOLDER\n" +
                    "Owner=Clément VEILLET - ADMIN\n" +
                    "Description=Une archive de présentation du logiciel ! :-)\n" +
                    "SN=\n" +
                    "Volume=NTFS\n" +
                    "Packed=\n" +
                    "\n" +
                    "<tree>\n" +
                    "\\\n" +
                    "2 ème Dossier	0	25/02/2022 16:42:40	d---\n" +
                    "Fichier présentation de texte.txt	0	25/02/2022 16:42:12	-a--\n" +
                    "Une musique.mp3	0	25/02/2022 16:42:12	-a--\n" +
                    "\\2 ème Dossier\\\n" +
                    "Crédit - Clément VEILLET	0	25/02/2022 16:43:27	-a--\n" +
                    "Un document word.docx	0	25/02/2022 16:42:49	-a--\n");
                swPres.Close();
            }
            catch (Exception ex)
            {
                if (swPres is object)
                    swPres.Close();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreur s'est produite.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string ArchivesDirectory
        {
            get { return _archivesDirectory; }
            set 
            { 
                _archivesDirectory = value;
                listeParametres["archivesDirectory"] = _archivesDirectory;
            }
        }

    }
}
