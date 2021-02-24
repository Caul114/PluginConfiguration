
namespace PluginConfiguration.ControlForms
{
    partial class EditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.PaleGreen;
            this.noButton.Location = new System.Drawing.Point(215, 93);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(116, 56);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LightSalmon;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.okButton.Location = new System.Drawing.Point(46, 93);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(116, 56);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Sì";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sei sicuro di voler procedere con le modifiche?";
            // 
            // EditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 274);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditControl";
            this.Text = "Pannello di Controllo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
    }
}