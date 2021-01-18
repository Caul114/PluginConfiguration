using Autodesk.Revit.UI;
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

        #region Private data members

        // Valore del Path del file Configuration
        private string _pathConfig = "";

        // Valore del path DATACELL sulla cartella CLOUD
        private string _pathDataCell = "";

        // Valore del path della BOLD_Distinta
        private string _pathBOLD_Distinta = "";

        // Valore del path delle IMAGES
        private string _pathImages = "";
        #endregion


        #region Class public property

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PathConfig
        {
            get { return _pathConfig; }
        }

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PathDataCell
        {
            get { return _pathDataCell; }
        }

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PathBOLD_Distinta
        {
            get { return _pathBOLD_Distinta; }
        }

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PathImages
        {
            get { return _pathImages; }
        }

        #endregion

        /// <summary>
        ///   Costruttore della finestra di dialogo
        /// </summary>
        /// 
        public ModelessForm(ExternalEvent exEvent, RequestHandler handler)
        {
            InitializeComponent();
            m_Handler = handler;
            m_ExEvent = exEvent;

            // Definisce il percorso di default del TextBox COMMESSE
            tabPage1commesseFileTextBox.Text = GetPathConfig();

            // Definisce il percorso di default della cartella DATACELL sul COLUD
            string sheet = "Foglio1";
            GetDataFromExcel(sheet, GetPathConfig());

            // Definisce il percorso di default del TextBox BOLD_Distinta
            tabPage1excelDistintaTextBox.Text = GetPathBOLD_Distinta();

            // Definisce il percorso di default del TextBox IMAGES
            tabPage1dirImagesTextBox.Text = GetPathImages();
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

        /// <summary>
        ///   Metodo che restituisce il path di CONFIGURAZIONE
        /// </summary>
        /// 
        private string GetPathConfig()
        {
            _pathConfig = @"C:\Users\Bold\Documents\Bold Software\Config\Config.xlsm";
            return _pathConfig;
        }

        /// <summary>
        ///   Metodo che restituisce il path di CONFIGURAZIONE
        /// </summary>
        /// 
        private string GetPathBOLD_Distinta()
        {
            _pathBOLD_Distinta = _pathDataCell + @"\AbacoCells.xlsm";
            return _pathBOLD_Distinta;
        }

        /// <summary>
        ///   Metodo che restituisce il path di CONFIGURAZIONE
        /// </summary>
        /// 
        private string GetPathImages()
        {
            _pathImages = _pathDataCell + @"\Images";
            return _pathImages;
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
        ///   Metodo che Importa il foglio Excel per ottenre i dati contenuti in alcune sue celle
        /// </summary>
        ///         
        public void GetDataFromExcel(string selectedItem, string path)
        {
            // Ottiene l'oggetto dell'applicazione Excel.
            Excel.Application excel_app = new Excel.Application();

            // Apre il fogio Excel
            Excel.Workbook workbook = excel_app.Workbooks.Open(path);

            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Worksheets.Item[selectedItem];

            // Recupera l'intervallo utilizzato.
            Excel.Range used_range = sheet.UsedRange;

            // Ottiene il numero massimo di righe e colonne.
            int max_row = used_range.Rows.Count;
            int max_col = used_range.Columns.Count;

            // Ottiene i valori del foglio.
            object[,] values = (object[,])used_range.Value2;

            //// Ottiene i titoli delle colonne.
            //SetGridColumns(dataGridView1, values, max_col);

            // Imposta il numero della riga e della colonna che si vuole ottenere
            int rawCommessa = 2;
            int colDataCell = 3;

            // Imposta il path della Distinta
            SetGridContents(values, max_row, max_col, rawCommessa, colDataCell);

            // Chiude la cartella di lavoro senza salvare le modifiche.
            workbook.Close(false, Type.Missing, Type.Missing);

            // Chiude il file Excel.
            excel_app.Quit();

            // Chiude tutti i processi Excel ancora attivi
            KillExcel();

            // Forza il Garbage Collector a ripulire
            GC.Collect();
        }

        /// <summary>
        ///   Metodo che imposta il contenuto della griglia
        /// </summary>
        /// 
        private void SetGridContents(object[,] values, int max_row, int max_col, int recordRaw, int recordCol)
        {
            // Copia i valori nella griglia.
            for (int row = 2; row <= max_row; row++)
            {
                for (int col = 1; col <= max_col; col++)
                {
                    if(row == recordRaw && col == recordCol)
                    {
                        _pathDataCell = (string)values[row, col];
                    }
                }
            }
        }

        /// <summary>
        ///   Metodo che chiude tutti i processi Excel attivi
        /// 
        static void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");

            // Fai un check per Killare tutti i processi Excel
            foreach (Process ExcelProcess in AllProcesses)
            {
                //if (myHashtable.ContainsKey(ExcelProcess.Id) == true)
                ExcelProcess.Kill();
            }
            AllProcesses = null;
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
