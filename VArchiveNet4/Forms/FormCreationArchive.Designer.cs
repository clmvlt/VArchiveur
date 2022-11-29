
namespace VArchiveNet4.Forms
{
    partial class FormCreationArchive
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
            this.inputRep = new System.Windows.Forms.TextBox();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.btnArchiver = new System.Windows.Forms.Button();
            this.openFolderDialog = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputOwner = new System.Windows.Forms.TextBox();
            this.inputDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMedium = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputRep
            // 
            this.inputRep.Location = new System.Drawing.Point(26, 90);
            this.inputRep.Name = "inputRep";
            this.inputRep.Size = new System.Drawing.Size(268, 20);
            this.inputRep.TabIndex = 0;
            // 
            // inputFileName
            // 
            this.inputFileName.Location = new System.Drawing.Point(26, 36);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(141, 20);
            this.inputFileName.TabIndex = 1;
            // 
            // btnArchiver
            // 
            this.btnArchiver.Location = new System.Drawing.Point(677, 267);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(75, 23);
            this.btnArchiver.TabIndex = 2;
            this.btnArchiver.Text = "Archiver";
            this.btnArchiver.UseVisualStyleBackColor = true;
            this.btnArchiver.Click += new System.EventHandler(this.btnArchiver_Click);
            // 
            // openFolderDialog
            // 
            this.openFolderDialog.Location = new System.Drawing.Point(300, 90);
            this.openFolderDialog.Name = "openFolderDialog";
            this.openFolderDialog.Size = new System.Drawing.Size(24, 23);
            this.openFolderDialog.TabIndex = 3;
            this.openFolderDialog.Text = "...";
            this.openFolderDialog.UseVisualStyleBackColor = true;
            this.openFolderDialog.Click += new System.EventHandler(this.openFolderDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "(*) Nom de l\'archive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(*) Répertoire à archiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Propriétaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // inputOwner
            // 
            this.inputOwner.Location = new System.Drawing.Point(26, 145);
            this.inputOwner.Name = "inputOwner";
            this.inputOwner.Size = new System.Drawing.Size(268, 20);
            this.inputOwner.TabIndex = 8;
            // 
            // inputDesc
            // 
            this.inputDesc.Location = new System.Drawing.Point(352, 36);
            this.inputDesc.Name = "inputDesc";
            this.inputDesc.Size = new System.Drawing.Size(400, 129);
            this.inputDesc.TabIndex = 9;
            this.inputDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medium";
            // 
            // cbMedium
            // 
            this.cbMedium.FormattingEnabled = true;
            this.cbMedium.Items.AddRange(new object[] {
            "CD",
            "DVD",
            "BLUERAY",
            "FOLDER"});
            this.cbMedium.Location = new System.Drawing.Point(68, 189);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(121, 21);
            this.cbMedium.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "(*) = Champ obligatoire";
            // 
            // FormCreationArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMedium);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDesc);
            this.Controls.Add(this.inputOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFolderDialog);
            this.Controls.Add(this.btnArchiver);
            this.Controls.Add(this.inputFileName);
            this.Controls.Add(this.inputRep);
            this.Name = "FormCreationArchive";
            this.Text = "VArchiveur - Création D\'Archive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputRep;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.Button btnArchiver;
        private System.Windows.Forms.Button openFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputOwner;
        private System.Windows.Forms.RichTextBox inputDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMedium;
        private System.Windows.Forms.Label label6;
    }
}