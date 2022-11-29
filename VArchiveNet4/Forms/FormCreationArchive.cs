using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VArchiveNet4.Methods_et_Procedures;

namespace VArchiveNet4.Forms
{
    public partial class FormCreationArchive : Form
    {
        public FormCreationArchive()
        {
            InitializeComponent();
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            string archiveRep = inputRep.Text;
            string archiveFileName = inputFileName.Text;

            if (archiveRep == "" || archiveFileName == "")
            {
                MessageBox.Show("(*) Champs obligatoires non renseignés.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(GestionParametres.ArchivesDirectory + "\\" + archiveFileName + ".cd"))
            {
                MessageBox.Show("Non d'archive déjà pris.", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(archiveRep))
            {
                MessageBox.Show("Répertoire inexistant", "VArchiverError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamWriter sw = new StreamWriter(GestionParametres.ArchivesDirectory + "\\" + archiveFileName + ".cd");

            DriveInfo driveInfo = new DriveInfo(archiveRep.Substring(0, 1));
            sw.WriteLine($"<head>\nName={archiveFileName}\nTyp={driveInfo.DriveType}\nSubTyp=\nMedium={cbMedium.Text}\nOwner={inputOwner.Text}\nDescription={inputDesc.Text}\nSN=\nVolume={driveInfo.DriveFormat}" +
                    $"\nPacked=\n\n<tree>");

            string[] topFiles = Directory.GetFiles(archiveRep, "*", SearchOption.TopDirectoryOnly);
            string[] topDirs = Directory.GetFiles(archiveRep, "*", SearchOption.TopDirectoryOnly);
            List<string> listFiles = new List<string>();
            listFiles.AddRange(topFiles);
            listFiles.AddRange(topDirs);
            listFiles.Sort();
            List<string> allDirs = new List<string>();
            allDirs.Add(archiveRep);
            allDirs.AddRange(Directory.GetDirectories(archiveRep, "*", SearchOption.AllDirectories));

            foreach (string dir in allDirs)
            {
                topFiles = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
                topDirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
                listFiles.Clear();
                listFiles.AddRange(topDirs);
                listFiles.AddRange(topFiles);

                string dirRepWrite = dir.Substring(archiveRep.Length) + "\\";
                if (!dirRepWrite.StartsWith("\\")) dirRepWrite = "\\" + dirRepWrite;

                if (dir != "") sw.WriteLine(dirRepWrite);
                if (listFiles.Count == 0) continue;

                foreach (string file in listFiles)
                {
                    if (File.Exists(file))
                    {
                        FileInfo fi = new FileInfo(file);
                        sw.WriteLine(fi.Name + "\t" + fi.Length + "\t" + fi.CreationTime + "\t" + "-a--");
                    }
                    else
                    {
                        DirectoryInfo di = new DirectoryInfo(file);
                        sw.WriteLine(di.Name + "\t" + 0 + "\t" + di.CreationTime + "\t" + "d---");
                    }

                }
            }

            sw.Close();

            Extensions.lvArchivesRefresh();
            this.Close();
        }

        private void openFolderDialog_Click(object sender, EventArgs e)
        {
            var folderBrowser = new CommonOpenFileDialog { IsFolderPicker = true };
            folderBrowser.ShowDialog();
            if (!Directory.Exists(folderBrowser.FileName)) return;
            if (folderBrowser.FileName == null) return;
            inputRep.Text = folderBrowser.FileName;
        }
    }
}
