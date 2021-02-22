
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelessForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typologieCodeComboBox = new System.Windows.Forms.ComboBox();
            this.cellCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.positionalCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Location = new System.Drawing.Point(683, 578);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 560);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
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
            this.tabPage1.Size = new System.Drawing.Size(742, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataCell";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "(Modifica queste Configurazioni solo se sei sicuro di impostarle correttamente)";
            // 
            // tabPage1fileDataCellButton
            // 
            this.tabPage1fileDataCellButton.Location = new System.Drawing.Point(681, 152);
            this.tabPage1fileDataCellButton.Name = "tabPage1fileDataCellButton";
            this.tabPage1fileDataCellButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1fileDataCellButton.TabIndex = 11;
            this.tabPage1fileDataCellButton.Text = "...";
            this.tabPage1fileDataCellButton.UseVisualStyleBackColor = true;
            this.tabPage1fileDataCellButton.Click += new System.EventHandler(this.tabPage1fileDataCellButton_Click);
            // 
            // tabPage1fileDataCellTextBox
            // 
            this.tabPage1fileDataCellTextBox.Location = new System.Drawing.Point(28, 152);
            this.tabPage1fileDataCellTextBox.Name = "tabPage1fileDataCellTextBox";
            this.tabPage1fileDataCellTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1fileDataCellTextBox.TabIndex = 10;
            // 
            // tabPage1fileDataCellLabel
            // 
            this.tabPage1fileDataCellLabel.AutoSize = true;
            this.tabPage1fileDataCellLabel.Location = new System.Drawing.Point(25, 128);
            this.tabPage1fileDataCellLabel.Name = "tabPage1fileDataCellLabel";
            this.tabPage1fileDataCellLabel.Size = new System.Drawing.Size(270, 17);
            this.tabPage1fileDataCellLabel.TabIndex = 9;
            this.tabPage1fileDataCellLabel.Text = "Percorso di default della Cartella DataCell";
            // 
            // tabPage1commesseFileButton
            // 
            this.tabPage1commesseFileButton.Location = new System.Drawing.Point(681, 85);
            this.tabPage1commesseFileButton.Name = "tabPage1commesseFileButton";
            this.tabPage1commesseFileButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1commesseFileButton.TabIndex = 8;
            this.tabPage1commesseFileButton.Text = "...";
            this.tabPage1commesseFileButton.UseVisualStyleBackColor = true;
            this.tabPage1commesseFileButton.Click += new System.EventHandler(this.tabPage1commesseFileButton_Click);
            // 
            // tabPage1commesseFileTextBox
            // 
            this.tabPage1commesseFileTextBox.Location = new System.Drawing.Point(28, 85);
            this.tabPage1commesseFileTextBox.Name = "tabPage1commesseFileTextBox";
            this.tabPage1commesseFileTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1commesseFileTextBox.TabIndex = 7;
            // 
            // tabPage1commesseFileLabel
            // 
            this.tabPage1commesseFileLabel.AutoSize = true;
            this.tabPage1commesseFileLabel.Location = new System.Drawing.Point(25, 61);
            this.tabPage1commesseFileLabel.Name = "tabPage1commesseFileLabel";
            this.tabPage1commesseFileLabel.Size = new System.Drawing.Size(290, 17);
            this.tabPage1commesseFileLabel.TabIndex = 6;
            this.tabPage1commesseFileLabel.Text = "Percorso di default del File di Configurazione";
            // 
            // tabPage1dirImagesButton
            // 
            this.tabPage1dirImagesButton.Location = new System.Drawing.Point(682, 287);
            this.tabPage1dirImagesButton.Name = "tabPage1dirImagesButton";
            this.tabPage1dirImagesButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1dirImagesButton.TabIndex = 5;
            this.tabPage1dirImagesButton.Text = "...";
            this.tabPage1dirImagesButton.UseVisualStyleBackColor = true;
            this.tabPage1dirImagesButton.Click += new System.EventHandler(this.tabPage1dirImagesButton_Click);
            // 
            // tabPage1dirImagesTextBox
            // 
            this.tabPage1dirImagesTextBox.Location = new System.Drawing.Point(29, 287);
            this.tabPage1dirImagesTextBox.Name = "tabPage1dirImagesTextBox";
            this.tabPage1dirImagesTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1dirImagesTextBox.TabIndex = 4;
            // 
            // tabPage1dirImagesLabel
            // 
            this.tabPage1dirImagesLabel.AutoSize = true;
            this.tabPage1dirImagesLabel.Location = new System.Drawing.Point(26, 263);
            this.tabPage1dirImagesLabel.Name = "tabPage1dirImagesLabel";
            this.tabPage1dirImagesLabel.Size = new System.Drawing.Size(306, 17);
            this.tabPage1dirImagesLabel.TabIndex = 3;
            this.tabPage1dirImagesLabel.Text = "Percorso di default della Cartella delle Immagini";
            // 
            // tabPage1excelDistintaButton
            // 
            this.tabPage1excelDistintaButton.Location = new System.Drawing.Point(682, 220);
            this.tabPage1excelDistintaButton.Name = "tabPage1excelDistintaButton";
            this.tabPage1excelDistintaButton.Size = new System.Drawing.Size(30, 23);
            this.tabPage1excelDistintaButton.TabIndex = 2;
            this.tabPage1excelDistintaButton.Text = "...";
            this.tabPage1excelDistintaButton.UseVisualStyleBackColor = true;
            this.tabPage1excelDistintaButton.Click += new System.EventHandler(this.tabPage1excelDistintaButton_Click);
            // 
            // tabPage1excelDistintaTextBox
            // 
            this.tabPage1excelDistintaTextBox.Location = new System.Drawing.Point(29, 220);
            this.tabPage1excelDistintaTextBox.Name = "tabPage1excelDistintaTextBox";
            this.tabPage1excelDistintaTextBox.Size = new System.Drawing.Size(647, 22);
            this.tabPage1excelDistintaTextBox.TabIndex = 1;
            // 
            // tabPage1excelDistintaLabel
            // 
            this.tabPage1excelDistintaLabel.AutoSize = true;
            this.tabPage1excelDistintaLabel.Location = new System.Drawing.Point(26, 196);
            this.tabPage1excelDistintaLabel.Name = "tabPage1excelDistintaLabel";
            this.tabPage1excelDistintaLabel.Size = new System.Drawing.Size(287, 17);
            this.tabPage1excelDistintaLabel.TabIndex = 0;
            this.tabPage1excelDistintaLabel.Text = "Percorso di default del File AbacoCells Excel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Config.xlsx";
            this.openFileDialog1.Filter = "File Excel (*.xlsx)|*.xlsx";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Bold\\Documents\\BOLD Software\\Config";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.Description = "Scegli la Directory da cui vuoi prendere le immagini.";
            this.folderBrowserDialog2.SelectedPath = "C:\\Users\\Bold";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Scegli la Directory da cui vuoi prendere le immagini.";
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\Bold";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "xlsm";
            this.openFileDialog2.FileName = "AbacoCells.xlsm";
            this.openFileDialog2.Filter = "File Excel (*.xlsm)|*.xlsm";
            this.openFileDialog2.InitialDirectory = "C:\\Users\\Bold";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.positionalCodeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cellCodeComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typologieCodeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 171);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametri da importare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codice Tipologia:";
            // 
            // typologieCodeComboBox
            // 
            this.typologieCodeComboBox.FormattingEnabled = true;
            this.typologieCodeComboBox.Location = new System.Drawing.Point(217, 40);
            this.typologieCodeComboBox.Name = "typologieCodeComboBox";
            this.typologieCodeComboBox.Size = new System.Drawing.Size(333, 24);
            this.typologieCodeComboBox.TabIndex = 1;
            this.typologieCodeComboBox.Text = "<- Scegli il parametro ->";
            // 
            // cellCodeComboBox
            // 
            this.cellCodeComboBox.FormattingEnabled = true;
            this.cellCodeComboBox.Location = new System.Drawing.Point(217, 84);
            this.cellCodeComboBox.Name = "cellCodeComboBox";
            this.cellCodeComboBox.Size = new System.Drawing.Size(333, 24);
            this.cellCodeComboBox.TabIndex = 3;
            this.cellCodeComboBox.Text = "<- Scegli il parametro ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice Cellula:";
            // 
            // positionalCodeComboBox
            // 
            this.positionalCodeComboBox.FormattingEnabled = true;
            this.positionalCodeComboBox.Location = new System.Drawing.Point(217, 127);
            this.positionalCodeComboBox.Name = "positionalCodeComboBox";
            this.positionalCodeComboBox.Size = new System.Drawing.Size(333, 24);
            this.positionalCodeComboBox.TabIndex = 5;
            this.positionalCodeComboBox.Text = "<- Scegli il parametro ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codice Posizionale:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(590, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 37);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Salva";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ModelessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelessForm";
            this.Text = "BOLD Configuration";
            this.Load += new System.EventHandler(this.ModelessForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Label label1;
        private GroupBox groupBox1;
        private Button saveButton;
        private ComboBox positionalCodeComboBox;
        private Label label4;
        private ComboBox cellCodeComboBox;
        private Label label3;
        private ComboBox typologieCodeComboBox;
        private Label label2;
    }
}