
using System;
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
            this.tabPage1fileDataCellButton = new System.Windows.Forms.Button();
            this.tabPage1fileDataCellTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1fileDataCellLabel = new System.Windows.Forms.Label();
            this.tabPage1commesseFileButton = new System.Windows.Forms.Button();
            this.tabPage1commesseFileTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1commesseFileLabel = new System.Windows.Forms.Label();
            this.tabPage1dirImagesButton = new System.Windows.Forms.Button();
            this.tabPage1dirImagesTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1dirImagesLabel = new System.Windows.Forms.Label();
            this.tabPage1excelDistintaButton = new System.Windows.Forms.Button();
            this.tabPage1excelDistintaTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1excelDistintaLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1fileDataCellButton);
            this.tabPage1.Controls.Add(this.tabPage1fileDataCellTextBox);
            this.tabPage1.Controls.Add(this.tabPage1fileDataCellLabel);
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
            // tabPage1fileDataCellButton
            // 
            this.tabPage1fileDataCellButton.Location = new System.Drawing.Point(681, 117);
            this.tabPage1fileDataCellButton.Name = "tabPage1fileDataCellButton";
            this.tabPage1fileDataCellButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1fileDataCellButton.TabIndex = 11;
            this.tabPage1fileDataCellButton.Text = "...";
            this.tabPage1fileDataCellButton.UseVisualStyleBackColor = true;
            this.tabPage1fileDataCellButton.Click += new System.EventHandler(this.tabPage1fileDataCellButton_Click);
            // 
            // tabPage1fileDataCellTextBox
            // 
            this.tabPage1fileDataCellTextBox.Location = new System.Drawing.Point(28, 117);
            this.tabPage1fileDataCellTextBox.Name = "tabPage1fileDataCellTextBox";
            this.tabPage1fileDataCellTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1fileDataCellTextBox.TabIndex = 10;
            // 
            // tabPage1fileDataCellLabel
            // 
            this.tabPage1fileDataCellLabel.AutoSize = true;
            this.tabPage1fileDataCellLabel.Location = new System.Drawing.Point(25, 93);
            this.tabPage1fileDataCellLabel.Name = "tabPage1fileDataCellLabel";
            this.tabPage1fileDataCellLabel.Size = new System.Drawing.Size(270, 17);
            this.tabPage1fileDataCellLabel.TabIndex = 9;
            this.tabPage1fileDataCellLabel.Text = "Percorso di default della Cartella DataCell";
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
            this.tabPage1commesseFileLabel.Size = new System.Drawing.Size(290, 17);
            this.tabPage1commesseFileLabel.TabIndex = 6;
            this.tabPage1commesseFileLabel.Text = "Percorso di default del File di Configurazione";
            // 
            // tabPage1dirImagesButton
            // 
            this.tabPage1dirImagesButton.Location = new System.Drawing.Point(682, 252);
            this.tabPage1dirImagesButton.Name = "tabPage1dirImagesButton";
            this.tabPage1dirImagesButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1dirImagesButton.TabIndex = 5;
            this.tabPage1dirImagesButton.Text = "...";
            this.tabPage1dirImagesButton.UseVisualStyleBackColor = true;
            this.tabPage1dirImagesButton.Click += new System.EventHandler(this.tabPage1dirImagesButton_Click);
            // 
            // tabPage1dirImagesTextBox
            // 
            this.tabPage1dirImagesTextBox.Location = new System.Drawing.Point(29, 252);
            this.tabPage1dirImagesTextBox.Name = "tabPage1dirImagesTextBox";
            this.tabPage1dirImagesTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1dirImagesTextBox.TabIndex = 4;
            // 
            // tabPage1dirImagesLabel
            // 
            this.tabPage1dirImagesLabel.AutoSize = true;
            this.tabPage1dirImagesLabel.Location = new System.Drawing.Point(26, 228);
            this.tabPage1dirImagesLabel.Name = "tabPage1dirImagesLabel";
            this.tabPage1dirImagesLabel.Size = new System.Drawing.Size(306, 17);
            this.tabPage1dirImagesLabel.TabIndex = 3;
            this.tabPage1dirImagesLabel.Text = "Percorso di default della Cartella delle Immagini";
            // 
            // tabPage1excelDistintaButton
            // 
            this.tabPage1excelDistintaButton.Location = new System.Drawing.Point(682, 185);
            this.tabPage1excelDistintaButton.Name = "tabPage1excelDistintaButton";
            this.tabPage1excelDistintaButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1excelDistintaButton.TabIndex = 2;
            this.tabPage1excelDistintaButton.Text = "...";
            this.tabPage1excelDistintaButton.UseVisualStyleBackColor = true;
            this.tabPage1excelDistintaButton.Click += new System.EventHandler(this.tabPage1excelDistintaButton_Click);
            // 
            // tabPage1excelDistintaTextBox
            // 
            this.tabPage1excelDistintaTextBox.Location = new System.Drawing.Point(29, 185);
            this.tabPage1excelDistintaTextBox.Name = "tabPage1excelDistintaTextBox";
            this.tabPage1excelDistintaTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1excelDistintaTextBox.TabIndex = 1;
            // 
            // tabPage1excelDistintaLabel
            // 
            this.tabPage1excelDistintaLabel.AutoSize = true;
            this.tabPage1excelDistintaLabel.Location = new System.Drawing.Point(26, 161);
            this.tabPage1excelDistintaLabel.Name = "tabPage1excelDistintaLabel";
            this.tabPage1excelDistintaLabel.Size = new System.Drawing.Size(310, 17);
            this.tabPage1excelDistintaLabel.TabIndex = 0;
            this.tabPage1excelDistintaLabel.Text = "Percorso di default del File BOLD_Distinta Excel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Config";
            this.openFileDialog1.Filter = "File Excel (*.xlsm)|*.xlsm|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Bold\\Documents\\Bold Software\\Config";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.Description = "Scegli la Directory da cui vuoi prendere le immagini.";
            this.folderBrowserDialog2.SelectedPath = "C:\\";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Scegli la Directory da cui vuoi prendere le immagini.";
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "xlsm";
            this.openFileDialog2.FileName = "AbacoCells";
            this.openFileDialog2.Filter = "File Excel (*.xlsm)|*.xlsm|All files (*.*)|*.*";
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
            this.ResumeLayout(false);

        }

        #endregion
        private Button exitButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button tabPage1excelDistintaButton;
        private TextBox tabPage1excelDistintaTextBox;
        private Label tabPage1excelDistintaLabel;
        private Button tabPage1commesseFileButton;
        private TextBox tabPage1commesseFileTextBox;
        private Label tabPage1commesseFileLabel;
        private Button tabPage1dirImagesButton;
        private TextBox tabPage1dirImagesTextBox;
        private Label tabPage1dirImagesLabel;
        private OpenFileDialog openFileDialog1;
        private Button tabPage1fileDataCellButton;
        private TextBox tabPage1fileDataCellTextBox;
        private Label tabPage1fileDataCellLabel;
        private FolderBrowserDialog folderBrowserDialog2;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog2;
    }
}