using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VArchiveNet4.Methods_et_Procedures;

namespace VArchiveNet4.Forms
{
    public partial class FormGestionParametres : Form
    {
        public FormGestionParametres()
        {
            InitializeComponent();
        }

        private void selectArchiveDirectory_Click(object sender, EventArgs e)
        {
            var folderBrowser = new CommonOpenFileDialog { IsFolderPicker = true };
            folderBrowser.ShowDialog();
            inputArchiveDirectory.Text = folderBrowser.FileName;
        }

        private void Appliquer_Click(object sender, EventArgs e)
        {
            GestionParametres.ArchivesDirectory = inputArchiveDirectory.Text;
            Extensions.lvArchivesRefresh();
            GestionParametres.SaveSettings();
            btnAppliquer.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = true;
            this.Close();
        }

        private void FormGestionParametres_Load(object sender, EventArgs e)
        {
            inputArchiveDirectory.Text = GestionParametres.ArchivesDirectory;
        }
    }
}
