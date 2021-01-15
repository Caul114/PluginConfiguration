﻿using Autodesk.Revit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace PluginConfiguration
{
    /// <summary>
    /// La classe della nostra finestra di dialogo non modale.
    /// </summary>
    /// <remarks>
    /// Oltre ad altri metodi, ha un metodo per ogni pulsante di comando. 
    /// In ognuno di questi metodi non viene fatto nient'altro che il sollevamento
    /// di un evento esterno con una richiesta specifica impostata nel gestore delle richieste.
    /// </remarks>
    /// 
    public partial class ModelessForm : Form
    {
        // In questo esempio, la finestra di dialogo possiede il gestore e gli oggetti evento, 
        // ma non è un requisito. Potrebbero anche essere proprietà statiche dell'applicazione.

        private RequestHandler m_Handler;
        private ExternalEvent m_ExEvent;

        private string _path = "";

        /// <summary>
        ///   Costruttore della finestra di dialogo
        /// </summary>
        /// 
        public ModelessForm(ExternalEvent exEvent, RequestHandler handler)
        {
            InitializeComponent();
            m_Handler = handler;
            m_ExEvent = exEvent;

            // Definisce i percorsi di default dei TextBox
            tabPage1commesseFileTextBox.Text = this.GetPathCommesse();
        }

        /// <summary>
        /// Modulo gestore eventi chiuso
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // possediamo sia l'evento che il gestore
            // dovremmo eliminarlo prima di chiudere la finestra

            m_ExEvent.Dispose();
            m_ExEvent = null;
            m_Handler = null;

            // non dimenticare di chiamare la classe base
            base.OnFormClosed(e);
        }

        /// <summary>
        ///   Attivatore / disattivatore del controllo
        /// </summary>
        ///
        private void EnableCommands(bool status)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = status;
            }
            if (!status)
            {
                this.exitButton.Enabled = true;
            }
        }

        /// <summary>
        ///   Un metodo di supporto privato per effettuare una richiesta 
        ///   e allo stesso tempo mettere la finestra di dialogo in sospensione.
        /// </summary>
        /// <remarks>
        ///   Ci si aspetta che il processo che esegue la richiesta 
        ///   (l'helper Idling in questo caso particolare) 
        ///   riattivi anche la finestra di dialogo dopo aver terminato l'esecuzione.
        /// </remarks>
        ///
        private void MakeRequest(RequestId request)
        {
            App.thisApp.DontShowFormTop();
            m_Handler.Request.Make(request);
            m_ExEvent.Raise();
            DozeOff();
        }


        /// <summary>
        ///   DozeOff -> disabilita tutti i controlli (tranne il pulsante Esci)
        /// </summary>
        /// 
        private void DozeOff()
        {
            EnableCommands(false);
        }

        /// <summary>
        ///   WakeUp -> abilita tutti i controlli
        /// </summary>
        /// 
        public void WakeUp()
        {
            EnableCommands(true);
        }

        /// <summary>
        ///   Metodo di interazione con la finestra di dialogo
        /// </summary>
        /// 
        private void ModelessForm_Load(object sender, EventArgs e)
        {
        }

        private string GetPathCommesse()
        {
            _path = @"C:\Users\Bold\Documents\Bold Software\Configuration\Plugin_Configuration.txt";
            return _path;
        }
        /// <summary>
        ///   Pulsante per la modifica del Path relativo COMMESSE DATACELL
        /// </summary>
        /// 
        private void tabPage1commesseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    tabPage1commesseFileTextBox.Text = path;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo ABACOCELL DATACELL
        /// </summary>
        /// 
        private void tabPage1excelDistintaButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo IMAGES DATACELL
        /// </summary>
        /// 
        private void tabPage1dirImagesButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo COMMESSE GETIMAGES
        /// </summary>
        /// 
        private void tabPage2commesseFileButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo FAMILIES GETIMAGES
        /// </summary>
        /// 
        private void tabPage2familyDirButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo IMAGES GETIMAGES
        /// </summary>
        /// 
        private void tabPage2imagesDirButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo MODIFIED FILE GETIMAGES
        /// </summary>
        /// 
        private void tabPage2modifyFileButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo UTILITIES GETIMAGES
        /// </summary>
        /// 
        private void tabPage2utilitiesButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   Exit - chiude la finestra di dialogo
        /// </summary>
        /// 
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }  // class
}
