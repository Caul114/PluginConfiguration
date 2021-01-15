
using System.Drawing;
using System.Windows.Forms;

namespace PluginConfiguration
{
    partial class ModelessForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1commesseFileButton = new System.Windows.Forms.Button();
            this.tabPage1commesseFileTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1commesseFileLabel = new System.Windows.Forms.Label();
            this.tabPage1dirImagesButton = new System.Windows.Forms.Button();
            this.tabPage1dirImagesTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1dirImagesLabel = new System.Windows.Forms.Label();
            this.tabPage1excelDistintaButton = new System.Windows.Forms.Button();
            this.tabPage1excelDistintaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1excelDistintaLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage2commesseFileButton = new System.Windows.Forms.Button();
            this.tabPage2commesseFileTextbox = new System.Windows.Forms.TextBox();
            this.tabPage2commesseFileLabel = new System.Windows.Forms.Label();
            this.tabPage2utilitiesButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage2utilitiesLabel = new System.Windows.Forms.Label();
            this.tabPage2modifyFileButton = new System.Windows.Forms.Button();
            this.tabPage2modifyFileTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2modifyFileLabel = new System.Windows.Forms.Label();
            this.tabPage2imagesDirButton = new System.Windows.Forms.Button();
            this.tabPage2imagesDirTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2imagesDirLabel = new System.Windows.Forms.Label();
            this.tabPage2familyDirButton = new System.Windows.Forms.Button();
            this.tabPage2familyDirTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2familyDirLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(683, 473);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1commesseFileButton);
            this.tabPage1.Controls.Add(this.tabPage1commesseFileTextBox);
            this.tabPage1.Controls.Add(this.tabPage1commesseFileLabel);
            this.tabPage1.Controls.Add(this.tabPage1dirImagesButton);
            this.tabPage1.Controls.Add(this.tabPage1dirImagesTextBox);
            this.tabPage1.Controls.Add(this.tabPage1dirImagesLabel);
            this.tabPage1.Controls.Add(this.tabPage1excelDistintaButton);
            this.tabPage1.Controls.Add(this.tabPage1excelDistintaTextBox);
            this.tabPage1.Controls.Add(this.tabPage1excelDistintaLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataCell";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage1commesseFileButton
            // 
            this.tabPage1commesseFileButton.Location = new System.Drawing.Point(681, 50);
            this.tabPage1commesseFileButton.Name = "tabPage1commesseFileButton";
            this.tabPage1commesseFileButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1commesseFileButton.TabIndex = 8;
            this.tabPage1commesseFileButton.Text = "...";
            this.tabPage1commesseFileButton.UseVisualStyleBackColor = true;
            this.tabPage1commesseFileButton.Click += new System.EventHandler(this.tabPage1commesseFileButton_Click);
            // 
            // tabPage1commesseFileTextBox
            // 
            this.tabPage1commesseFileTextBox.Location = new System.Drawing.Point(28, 50);
            this.tabPage1commesseFileTextBox.Name = "tabPage1commesseFileTextBox";
            this.tabPage1commesseFileTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1commesseFileTextBox.TabIndex = 7;
            // 
            // tabPage1commesseFileLabel
            // 
            this.tabPage1commesseFileLabel.AutoSize = true;
            this.tabPage1commesseFileLabel.Location = new System.Drawing.Point(25, 26);
            this.tabPage1commesseFileLabel.Name = "tabPage1commesseFileLabel";
            this.tabPage1commesseFileLabel.Size = new System.Drawing.Size(261, 17);
            this.tabPage1commesseFileLabel.TabIndex = 6;
            this.tabPage1commesseFileLabel.Text = "Percorso di default per il File Commesse";
            // 
            // tabPage1dirImagesButton
            // 
            this.tabPage1dirImagesButton.Location = new System.Drawing.Point(681, 181);
            this.tabPage1dirImagesButton.Name = "tabPage1dirImagesButton";
            this.tabPage1dirImagesButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1dirImagesButton.TabIndex = 5;
            this.tabPage1dirImagesButton.Text = "...";
            this.tabPage1dirImagesButton.UseVisualStyleBackColor = true;
            this.tabPage1dirImagesButton.Click += new System.EventHandler(this.tabPage1dirImagesButton_Click);
            // 
            // tabPage1dirImagesTextBox
            // 
            this.tabPage1dirImagesTextBox.Location = new System.Drawing.Point(28, 181);
            this.tabPage1dirImagesTextBox.Name = "tabPage1dirImagesTextBox";
            this.tabPage1dirImagesTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1dirImagesTextBox.TabIndex = 4;
            // 
            // tabPage1dirImagesLabel
            // 
            this.tabPage1dirImagesLabel.AutoSize = true;
            this.tabPage1dirImagesLabel.Location = new System.Drawing.Point(25, 157);
            this.tabPage1dirImagesLabel.Name = "tabPage1dirImagesLabel";
            this.tabPage1dirImagesLabel.Size = new System.Drawing.Size(278, 17);
            this.tabPage1dirImagesLabel.TabIndex = 3;
            this.tabPage1dirImagesLabel.Text = "Percorso di default per la Cartella Immagini";
            // 
            // tabPage1excelDistintaButton
            // 
            this.tabPage1excelDistintaButton.Location = new System.Drawing.Point(681, 115);
            this.tabPage1excelDistintaButton.Name = "tabPage1excelDistintaButton";
            this.tabPage1excelDistintaButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1excelDistintaButton.TabIndex = 2;
            this.tabPage1excelDistintaButton.Text = "...";
            this.tabPage1excelDistintaButton.UseVisualStyleBackColor = true;
            this.tabPage1excelDistintaButton.Click += new System.EventHandler(this.tabPage1excelDistintaButton_Click);
            // 
            // tabPage1excelDistintaTextBox
            // 
            this.tabPage1excelDistintaTextBox.Location = new System.Drawing.Point(28, 115);
            this.tabPage1excelDistintaTextBox.Name = "tabPage1excelDistintaTextBox";
            this.tabPage1excelDistintaTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1excelDistintaTextBox.TabIndex = 1;
            // 
            // tabPage1excelDistintaLabel
            // 
            this.tabPage1excelDistintaLabel.AutoSize = true;
            this.tabPage1excelDistintaLabel.Location = new System.Drawing.Point(25, 91);
            this.tabPage1excelDistintaLabel.Name = "tabPage1excelDistintaLabel";
            this.tabPage1excelDistintaLabel.Size = new System.Drawing.Size(276, 17);
            this.tabPage1excelDistintaLabel.TabIndex = 0;
            this.tabPage1excelDistintaLabel.Text = "Percorso di default per il File Distinta Excel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabPage2commesseFileButton);
            this.tabPage2.Controls.Add(this.tabPage2commesseFileTextbox);
            this.tabPage2.Controls.Add(this.tabPage2commesseFileLabel);
            this.tabPage2.Controls.Add(this.tabPage2utilitiesButton);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.tabPage2utilitiesLabel);
            this.tabPage2.Controls.Add(this.tabPage2modifyFileButton);
            this.tabPage2.Controls.Add(this.tabPage2modifyFileTextBox);
            this.tabPage2.Controls.Add(this.tabPage2modifyFileLabel);
            this.tabPage2.Controls.Add(this.tabPage2imagesDirButton);
            this.tabPage2.Controls.Add(this.tabPage2imagesDirTextBox);
            this.tabPage2.Controls.Add(this.tabPage2imagesDirLabel);
            this.tabPage2.Controls.Add(this.tabPage2familyDirButton);
            this.tabPage2.Controls.Add(this.tabPage2familyDirTextBox);
            this.tabPage2.Controls.Add(this.tabPage2familyDirLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetImages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage2commesseFileButton
            // 
            this.tabPage2commesseFileButton.Location = new System.Drawing.Point(681, 51);
            this.tabPage2commesseFileButton.Name = "tabPage2commesseFileButton";
            this.tabPage2commesseFileButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage2commesseFileButton.TabIndex = 23;
            this.tabPage2commesseFileButton.Text = "...";
            this.tabPage2commesseFileButton.UseVisualStyleBackColor = true;
            this.tabPage2commesseFileButton.Click += new System.EventHandler(this.tabPage2commesseFileButton_Click);
            // 
            // tabPage2commesseFileTextbox
            // 
            this.tabPage2commesseFileTextbox.Location = new System.Drawing.Point(28, 51);
            this.tabPage2commesseFileTextbox.Name = "tabPage2commesseFileTextbox";
            this.tabPage2commesseFileTextbox.Size = new System.Drawing.Size(647, 22);
            this.tabPage2commesseFileTextbox.TabIndex = 22;
            // 
            // tabPage2commesseFileLabel
            // 
            this.tabPage2commesseFileLabel.AutoSize = true;
            this.tabPage2commesseFileLabel.Location = new System.Drawing.Point(25, 27);
            this.tabPage2commesseFileLabel.Name = "tabPage2commesseFileLabel";
            this.tabPage2commesseFileLabel.Size = new System.Drawing.Size(261, 17);
            this.tabPage2commesseFileLabel.TabIndex = 21;
            this.tabPage2commesseFileLabel.Text = "Percorso di default per il File Commesse";
            // 
            // tabPage2utilitiesButton
            // 
            this.tabPage2utilitiesButton.Location = new System.Drawing.Point(681, 329);
            this.tabPage2utilitiesButton.Name = "tabPage2utilitiesButton";
            this.tabPage2utilitiesButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage2utilitiesButton.TabIndex = 20;
            this.tabPage2utilitiesButton.Text = "...";
            this.tabPage2utilitiesButton.UseVisualStyleBackColor = true;
            this.tabPage2utilitiesButton.Click += new System.EventHandler(this.tabPage2utilitiesButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(647, 22);
            this.textBox4.TabIndex = 19;
            // 
            // tabPage2utilitiesLabel
            // 
            this.tabPage2utilitiesLabel.AutoSize = true;
            this.tabPage2utilitiesLabel.Location = new System.Drawing.Point(25, 305);
            this.tabPage2utilitiesLabel.Name = "tabPage2utilitiesLabel";
            this.tabPage2utilitiesLabel.Size = new System.Drawing.Size(384, 17);
            this.tabPage2utilitiesLabel.TabIndex = 18;
            this.tabPage2utilitiesLabel.Text = "Percorso di default per la Cartella dei File utili al programma";
            // 
            // tabPage2modifyFileButton
            // 
            this.tabPage2modifyFileButton.Location = new System.Drawing.Point(681, 258);
            this.tabPage2modifyFileButton.Name = "tabPage2modifyFileButton";
            this.tabPage2modifyFileButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage2modifyFileButton.TabIndex = 17;
            this.tabPage2modifyFileButton.Text = "...";
            this.tabPage2modifyFileButton.UseVisualStyleBackColor = true;
            this.tabPage2modifyFileButton.Click += new System.EventHandler(this.tabPage2modifyFileButton_Click);
            // 
            // tabPage2modifyFileTextBox
            // 
            this.tabPage2modifyFileTextBox.Location = new System.Drawing.Point(28, 258);
            this.tabPage2modifyFileTextBox.Name = "tabPage2modifyFileTextBox";
            this.tabPage2modifyFileTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage2modifyFileTextBox.TabIndex = 16;
            // 
            // tabPage2modifyFileLabel
            // 
            this.tabPage2modifyFileLabel.AutoSize = true;
            this.tabPage2modifyFileLabel.Location = new System.Drawing.Point(25, 234);
            this.tabPage2modifyFileLabel.Name = "tabPage2modifyFileLabel";
            this.tabPage2modifyFileLabel.Size = new System.Drawing.Size(273, 17);
            this.tabPage2modifyFileLabel.TabIndex = 15;
            this.tabPage2modifyFileLabel.Text = "Percorso di default per i File .rfa modificati";
            // 
            // tabPage2imagesDirButton
            // 
            this.tabPage2imagesDirButton.Location = new System.Drawing.Point(681, 188);
            this.tabPage2imagesDirButton.Name = "tabPage2imagesDirButton";
            this.tabPage2imagesDirButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage2imagesDirButton.TabIndex = 14;
            this.tabPage2imagesDirButton.Text = "...";
            this.tabPage2imagesDirButton.UseVisualStyleBackColor = true;
            this.tabPage2imagesDirButton.Click += new System.EventHandler(this.tabPage2imagesDirButton_Click);
            // 
            // tabPage2imagesDirTextBox
            // 
            this.tabPage2imagesDirTextBox.Location = new System.Drawing.Point(28, 188);
            this.tabPage2imagesDirTextBox.Name = "tabPage2imagesDirTextBox";
            this.tabPage2imagesDirTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage2imagesDirTextBox.TabIndex = 13;
            // 
            // tabPage2imagesDirLabel
            // 
            this.tabPage2imagesDirLabel.AutoSize = true;
            this.tabPage2imagesDirLabel.Location = new System.Drawing.Point(25, 164);
            this.tabPage2imagesDirLabel.Name = "tabPage2imagesDirLabel";
            this.tabPage2imagesDirLabel.Size = new System.Drawing.Size(398, 17);
            this.tabPage2imagesDirLabel.TabIndex = 12;
            this.tabPage2imagesDirLabel.Text = "Percorso di default per la Cartella delle Immagini delle famiglie";
            // 
            // tabPage2familyDirButton
            // 
            this.tabPage2familyDirButton.Location = new System.Drawing.Point(681, 117);
            this.tabPage2familyDirButton.Name = "tabPage2familyDirButton";
            this.tabPage2familyDirButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage2familyDirButton.TabIndex = 11;
            this.tabPage2familyDirButton.Text = "...";
            this.tabPage2familyDirButton.UseVisualStyleBackColor = true;
            this.tabPage2familyDirButton.Click += new System.EventHandler(this.tabPage2familyDirButton_Click);
            // 
            // tabPage2familyDirTextBox
            // 
            this.tabPage2familyDirTextBox.Location = new System.Drawing.Point(28, 117);
            this.tabPage2familyDirTextBox.Name = "tabPage2familyDirTextBox";
            this.tabPage2familyDirTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage2familyDirTextBox.TabIndex = 10;
            // 
            // tabPage2familyDirLabel
            // 
            this.tabPage2familyDirLabel.AutoSize = true;
            this.tabPage2familyDirLabel.Location = new System.Drawing.Point(25, 93);
            this.tabPage2familyDirLabel.Name = "tabPage2familyDirLabel";
            this.tabPage2familyDirLabel.Size = new System.Drawing.Size(293, 17);
            this.tabPage2familyDirLabel.TabIndex = 9;
            this.tabPage2familyDirLabel.Text = "Percorso di default per la Cartella dei File .rfa";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // ModelessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 522);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exitButton);
            this.MaximizeBox = false;
            this.Name = "ModelessForm";
            this.Text = "BOLD Configuration";
            this.Load += new System.EventHandler(this.ModelessForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button exitButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button tabPage1excelDistintaButton;
        private TextBox tabPage1excelDistintaTextBox;
        private Label tabPage1excelDistintaLabel;
        private TabPage tabPage2;
        private Button tabPage1commesseFileButton;
        private TextBox tabPage1commesseFileTextBox;
        private Label tabPage1commesseFileLabel;
        private Button tabPage1dirImagesButton;
        private TextBox tabPage1dirImagesTextBox;
        private Label tabPage1dirImagesLabel;
        private Button tabPage2commesseFileButton;
        private TextBox tabPage2commesseFileTextbox;
        private Label tabPage2commesseFileLabel;
        private Button tabPage2utilitiesButton;
        private TextBox textBox4;
        private Label tabPage2utilitiesLabel;
        private Button tabPage2modifyFileButton;
        private TextBox tabPage2modifyFileTextBox;
        private Label tabPage2modifyFileLabel;
        private Button tabPage2imagesDirButton;
        private TextBox tabPage2imagesDirTextBox;
        private Label tabPage2imagesDirLabel;
        private Button tabPage2familyDirButton;
        private TextBox tabPage2familyDirTextBox;
        private Label tabPage2familyDirLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}