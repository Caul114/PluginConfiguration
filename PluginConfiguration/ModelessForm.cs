using Autodesk.Revit.UI;
using Newtonsoft.Json;
using PluginConfiguration.ControlForms;
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

        // Instanza della classe 
        internal static ModelessForm thisModForm = null;

        // Instanzia la classe della Personalizzazione
        private EditControl editControl;

        // Percorso del singolo file excel da importare di default
        private string _pathFileTxt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BOLD Software\DataQuery\ConfigPath.json";

        // Valore del Path del file Configuration
        private string _pathConfig = "";

        // Valore del nuovo path di Configurazione
        private string _newPathConfig = "";

        // Valore del path DATACELL sulla cartella CLOUD
        private string _pathDataCell = "";

        // Valore del nuovo path di Configurazione
        private string _newPathDataCell = "";

        // Valore della sheet del file excel di Configurazione
        private string _sheet = "DataCell";

        // Valore del path della BOLD_Distinta
        private string _pathBOLD_Distinta = "";

        // Valore del nuovo path di BOLD_Distinta
        private string _newPathBOLD_Distinta = "";

        // Valore del path delle IMAGES
        private string _pathImages = "";

        // Valore del nuovo path di Images
        private string _newPathImages = "";

        // Variabile che indica il nome del Codice Tipologia
        private string _typologieCode = string.Empty;

        // Variabile che indica il nome del Codice Cellula
        private string _cellCode = string.Empty;

        // Variabile che indica il nome del Codice Posizionale
        private string _positionalCode = string.Empty;

        // Imposta i valori delle raw e delle column dell'Excel Config 
        private int _rawCommessa = 2;
        private int _colValue = 0;
        #endregion


        #region Class public property
        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PathFileTxt
        {
            get { return _pathFileTxt; }
        }

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

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string TypologieCode
        {
            get { return _typologieCode; }
        }

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string CellCode
        {
            get { return _cellCode; }
        }

        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public string PositionalCode
        {
            get { return _positionalCode; }
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

            // Riempie l'istanza di questa classe con la Form
            thisModForm = this;

            // Definisce il percorso di default del TextBox commesse CONFIG.xlsx
            tabPage1commesseFileTextBox.Text = GetPathConfig();

            // Definisce il percorso di default della cartella DATACELL sul CLOUD     
            string sheet = _sheet;
            GetDataFromExcel(sheet, GetPathConfig());
            tabPage1fileDataCellTextBox.Text = _pathDataCell;

            // Definisce il percorso di default del TextBox BOLD_Distinta
            tabPage1excelDistintaTextBox.Text = _pathBOLD_Distinta;

            // Definisce il percorso di default del TextBox IMAGES
            tabPage1dirImagesTextBox.Text = _pathImages;

            // Inizializza i codici nel caso in cui siano già memorizzati
            GetCodes();

            // Imposta le ComboBoxes con tutti i parametri disponibili
            ConfigureTheCodes();

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
        ///   Metodo che restituisce il path del file Excel di CONFIGURAZIONE
        /// </summary>
        /// 
        private string GetPathConfig()
        {
            _pathConfig = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BOLD Software\Config\Config.xlsx";
            return _pathConfig;
        }

        /// <summary>
        ///   Metodo che restituisce il path del file Excel delle DISTINTE
        /// </summary>
        /// 
        private string GetPathBOLD_Distinta()
        {
            _pathBOLD_Distinta = _pathDataCell + @"\DataSheets.xlsm";
            return _pathBOLD_Distinta;
        }

        /// <summary>
        ///   Metodo che restituisce il path della cartella delle IMMAGINI
        /// </summary>
        /// 
        private string GetPathImages()
        {
            _pathImages = _pathDataCell + @"\Images";
            return _pathImages;
        }


        /// <summary>
        ///   Pulsante per la modifica del Path relativo a CONFIG DATACELL
        /// </summary>
        /// 
        private void tabPage1commesseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Ottiene il nuovo Path del File di configurazione
                    _newPathConfig = openFileDialog1.FileName;

                    if (!_newPathConfig.Contains("BOLD Software\\Config\\Config.xlsx"))
                    {
                        MessageBox.Show("Non hai scelto il file corretto.\n" +
                            "Inserisci nuovamente il nome del file, ricordandoti che abbia questo percorso: \"...BOLD Software\\Config\\Config.xlsx\"");
                    }
                    else
                    {
                        // Modifica il path del file config di default
                        _pathConfig = _newPathConfig;
                        // Lo salva nel suo TextBox
                        tabPage1commesseFileTextBox.Text = _pathConfig;

                        // Modifica il file ConfigPath.json
                        Json fileJson = new Json();
                        //string pathReplaced = _pathConfig.Replace(Environment.GetFolderPath(
                        //    Environment.SpecialFolder.MyDocuments), "");
                        fileJson.UpdateJson(1, 0, "ConfigPath", _pathConfig);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo alla cartella DATACELL e degli altri valori relativi
        /// </summary>
        /// 
        private void tabPage1fileDataCellButton_Click(object sender, EventArgs e)
        {
            // Mostra il FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Imposta il percorso della cartella DataCell
                _newPathDataCell = folderBrowserDialog1.SelectedPath;

                if (!_newPathDataCell.Contains("\\DataQuery") || _newPathDataCell.Contains("\\Images"))
                {
                    MessageBox.Show("Non hai scelto il file corretto.\n" +
                        "Clicca nuovamente il pulsante di configurazione e cerca il percorso corretto della cartella DataQuery.");
                }
                else
                {
                    _pathDataCell = _newPathDataCell;
                    tabPage1fileDataCellTextBox.Text = _pathDataCell;
                    // Invoca i metodi per la modifica dei percorsi del BOLD_Distinta e delle Images
                    _newPathBOLD_Distinta = GetPathBOLD_Distinta();
                    _pathBOLD_Distinta = _newPathBOLD_Distinta;
                    tabPage1excelDistintaTextBox.Text = _pathBOLD_Distinta;
                    _newPathImages = GetPathImages();
                    _pathImages = _newPathImages;
                    tabPage1dirImagesTextBox.Text = _pathImages;
                    // Modifica il path DataCell (e quelli relativi) presente nel file Excel di Configurazione
                    _rawCommessa = 2;
                    _colValue = 3;
                    ExportExcelAndChangeValue(_pathConfig, _rawCommessa, _colValue);
                    // Modifica il file ConfigPath.json
                    Json fileJson = new Json();
                    //string pathDataCellReplaced = _pathDataCell.Replace(Environment.GetFolderPath(
                    //        Environment.SpecialFolder.UserProfile), "");
                    fileJson.UpdateJson(2, 1, "DataCellPath", _pathDataCell);
                    //string pathBOLD_DistintaReplaced = _pathBOLD_Distinta.Replace(Environment.GetFolderPath(
                    //        Environment.SpecialFolder.UserProfile), "");
                    fileJson.UpdateJson(3, 2, "AbacoCellPath", _pathBOLD_Distinta);
                    //string pathImagesReplaced = _pathImages.Replace(Environment.GetFolderPath(
                    //        Environment.SpecialFolder.UserProfile), "");
                    fileJson.UpdateJson(4, 3, "ImagesPath", _pathImages);
                }
            }
        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo DATASHEETS DATAQUERY
        /// </summary>
        /// 
        private void tabPage1excelDistintaButton_Click(object sender, EventArgs e)
        {
            // Mostra il FolderBrowserDialog.
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Invoca i metodi per la modifica dei percorsi del BOLD_Distinta e delle Images
                _newPathBOLD_Distinta = openFileDialog2.FileName;
                if (!_newPathBOLD_Distinta.Contains("\\DataQuery\\DataSheets.xlsm"))
                {
                    MessageBox.Show("Non hai scelto il file corretto.\n" +
                        "Clicca nuovamente il pulsante di configurazione, " +
                        "ricordandoti che il file abbia questo percorso: \"...DataQuery\\DataSheets.xlsm\"");
                }
                else
                {
                    _pathBOLD_Distinta = _newPathBOLD_Distinta;
                    tabPage1excelDistintaTextBox.Text = _pathBOLD_Distinta;
                    // Modifica il path DataCell presente nel file Excel di Configurazione
                    _rawCommessa = 2;
                    _colValue = 3;
                    ExportExcelAndChangeValue(_pathConfig, _rawCommessa, _colValue);

                    // Modifica il file ConfigPath.json
                    Json fileJson = new Json();
                    //string pathBOLD_DistintaReplaced = _pathBOLD_Distinta.Replace(Environment.GetFolderPath(
                    //        Environment.SpecialFolder.UserProfile), "");
                    fileJson.UpdateJson(3, 2, "AbacoCellPath", _pathBOLD_Distinta);
                }
            }
        }

        /// <summary>
        ///   Pulsante per la modifica del Path relativo IMAGES DATACELL
        /// </summary>
        /// 
        private void tabPage1dirImagesButton_Click(object sender, EventArgs e)
        {
            // Mostra il FolderBrowserDialog.
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Invoca il metodo per la modifica del percorso delle Images
                _newPathImages = folderBrowserDialog2.SelectedPath;
                if (!_newPathImages.Contains("\\DataQuery\\Images"))
                {
                    MessageBox.Show("Non hai scelto il file corretto.\n" +
                        "Clicca nuovamente il pulsante di configurazione " +
                        "e cerca il percorso corretto della cartella \"...DataQuery\\Images.");
                }
                else
                {
                    _pathImages = _newPathImages;
                    tabPage1dirImagesTextBox.Text = _pathImages;
                    // Modifica il path Images presente nel file Excel di Configurazione
                    _rawCommessa = 2;
                    _colValue = 3;
                    ExportExcelAndChangeValue(_pathConfig, _rawCommessa, _colValue);

                    // Modifica il file ConfigPath.json
                    Json fileJson = new Json();
                    //string pathImagesReplaced = _pathImages.Replace(Environment.GetFolderPath(
                    //        Environment.SpecialFolder.UserProfile), "");
                    fileJson.UpdateJson(4, 3, "ImagesPath", _pathImages);
                }
            }
        }

        #region Parameters
        /// <summary>
        ///   Chiama il pannello che inizializza i Codici di Tipologia, Cellula e Posizionale, se presenti
        /// </summary>
        /// 
        public void GetCodes()
        {
            if (File.Exists(_pathFileTxt))
            {
                // Legge il .json dal file
                string jsonText = File.ReadAllText(_pathFileTxt);
                if (jsonText != string.Empty)
                {
                    var traduction = JsonConvert.DeserializeObject<IList<Data>>(jsonText);
                    Data singleItem1 = traduction.FirstOrDefault(x => x.Id == 5);
                    if (singleItem1 != null && singleItem1.Value != string.Empty)
                    {
                        _typologieCode = singleItem1.Value;
                    }
                    Data singleItem2 = traduction.FirstOrDefault(x => x.Id == 6);
                    if (singleItem2 != null && singleItem2.Value != string.Empty)
                    {
                        _cellCode = singleItem2.Value;
                    }
                    Data singleItem3 = traduction.FirstOrDefault(x => x.Id == 7);
                    if (singleItem3 != null && singleItem3.Value != string.Empty)
                    {
                        _positionalCode = singleItem3.Value;
                    }
                }
            }
        }

        /// <summary>
        ///   Riempie le comboBoxes dei Codici di Tipologia, Cellula e Posizionale
        /// </summary>
        /// 
        public void ConfigureTheCodes()
        {
            MakeRequest(RequestId.SetCode);
        }

        /// <summary>
        ///   Riempie le ComboBoxes
        /// </summary>
        /// 
        public void FillTheComboBoxes(List<string> stringList)
        {
            foreach (string item in stringList)
            {
                typologieCodeComboBox.Items.Add(item);
                cellCodeComboBox.Items.Add(item);
                positionalCodeComboBox.Items.Add(item);
            }

            // Verifica che il valore contenuto nei codici sia uno dei parametri
            foreach (string param in stringList)
            {
                if (_typologieCode == param)
                {
                    typologieCodeComboBox.Text = _typologieCode;
                }
                if (_cellCode == param)
                {
                    cellCodeComboBox.Text = _cellCode;
                }
                if (_positionalCode == param)
                {
                    positionalCodeComboBox.Text = _positionalCode;
                }
            }
        }

        /// <summary>
        ///   Save - salva le modifiche fatte ai codici dei Parametri
        /// </summary>
        /// 
        private void saveButton_Click(object sender, EventArgs e)
        {
            _typologieCode = typologieCodeComboBox.SelectedItem as string;
            _cellCode = cellCodeComboBox.SelectedItem as string;
            _positionalCode = positionalCodeComboBox.SelectedItem as string;

            // Salva i cambiamenti nel File di configurazione
            SavesCodesInJson();
        }

        /// <summary>
        ///   Salva i nuovi codici nel file .json di Configurazione
        /// </summary>
        /// 
        private void SavesCodesInJson()
        {
            if (File.Exists(_pathFileTxt))
            {
                // Scrive i codici in un file esterno Json di Configurazione
                Json fileJson = new Json();
                fileJson.UpdateJson(5, 4, "TypologieCode", _typologieCode);
                fileJson.UpdateJson(6, 5, "CellCode", _cellCode);
                fileJson.UpdateJson(7, 6, "PositionalCode", _positionalCode);

                // Ottiene il _pathconfig del foglio Excel
                string jsonText = File.ReadAllText(ModelessForm.thisModForm.PathFileTxt);
                IList<Data> traduction = JsonConvert.DeserializeObject<IList<Data>>(jsonText);
                Data singleItem = traduction.FirstOrDefault(x => x.Id == 1);
                string pathExcelConfig = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + singleItem.Value;

                // Esporta le modifiche su foglio Excel, del pathDataCell, di DataSheets.xlsm e di Images
                KillExcel();
                _colValue = 6;
                ExportExcelAndChangeValue(pathExcelConfig, _rawCommessa, _colValue);

                // Avvisa che il salvataggio è andato a buon fine
                MessageBox.Show("Hai salvato correttamente i nuovi codici.");
            }
        }
        #endregion

        #region EXCEL
        /// <summary>
        ///   Metodo che Importa il foglio Excel per ottenere i dati contenuti in alcune sue celle
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
            int rawCommessa = _rawCommessa;
            _colValue = 3;
            int colDataCell = _colValue;
            int colAbacoCells = _colValue + 1;
            int colImages = _colValue + 2;

            // Imposta il path della Distinta
            SetPathContent(values, max_row, max_col, rawCommessa, colDataCell, colAbacoCells, colImages);

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
        private void SetPathContent(object[,] values, int max_row, int max_col, int recordRaw, int dataCellCol, int bold_distintaCol, int imagesCol)
        {
            // Copia i valori nella griglia.
            for (int row = 2; row <= max_row; row++)
            {
                for (int col = 1; col <= max_col; col++)
                {
                    if(row == recordRaw && col == dataCellCol)
                    {
                        _pathDataCell = (string)values[row, col];
                    } 
                    else if (row == recordRaw && col == bold_distintaCol)
                    {
                        _pathBOLD_Distinta = (string)values[row, col];
                    }
                    else if (row == recordRaw && col == imagesCol)
                    {
                        _pathImages = (string)values[row, col];
                    }
                }
            }
        }

        /// <summary>
        ///   Metodo che Esporta in Excel i cambiamenti effettuati in alcune sue celle
        /// </summary>
        /// 
        public void ExportExcelAndChangeValue(string pathExcel, int raw, int col)
        {

            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Non puoi creare un documento Excel." +
                    "\nIl tuo PC potrebbe non essere abilitato per il salvataggio di un file Excel.");
                return;
            }

            Excel.Workbooks workbooks = excelApp.Workbooks;
            Excel.Workbook workbook = workbooks.Open(
                  pathExcel,
                  Type.Missing, //updatelinks
                  false,        //readonly
                  Type.Missing, //format
                  Type.Missing, //Password
                  Type.Missing, //writeResPass
                  true,         //ignoreReadOnly
                  Type.Missing, //origin
                  Type.Missing, //delimiter
                  true,         //editable
                  Type.Missing, //Notify
                  Type.Missing, //converter
                  Type.Missing, //AddToMru
                  Type.Missing, //Local
                  Type.Missing); //corruptLoad);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            // Recupera l'intervallo utilizzato.
            Excel.Range used_range = worksheet.UsedRange;

            // Ottiene il numero massimo di righe e colonne.
            int max_row = used_range.Rows.Count;
            int max_col = used_range.Columns.Count;

            // Ottiene i valori del foglio.
            object[,] values = (object[,])used_range.Value2;

            // Imposta il numero della riga e della colonna che si vuole ottenere
            int rawCommessa = raw;
            int colDataCell = col;

            //used_range.Cells[rawCommessa, colDataCell] = _newPathDataCell;

            // Imposta il path della Distinta
            SetCellContent(worksheet, max_row, max_col, rawCommessa, colDataCell);

            worksheet.Columns.EntireColumn.AutoFit();

            // Crea un file Excel temporaneo e lo salva al posto di quello originale
            string tmpName = Path.GetTempFileName();
            //string tmpName = @"C:\Users\Bold\Documents\Bold Software\Config\temp.xlsx";
            File.Delete(tmpName);

            if (pathExcel != "")
            {
                try
                {
                    workbook.SaveAs(tmpName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore di esportazione!\n" + ex.Message);
                }
            }
            workbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
            File.Delete(pathExcel);
            File.Move(tmpName, pathExcel);           

            // Chiude tutti i processi Excel ancora attivi
            KillExcel();

            // Forza un Garbage collector immediato
            GC.Collect();
        }


        /// <summary>
        ///   Metodo che imposta il contenuto della cella specifica
        /// </summary>
        /// 
        private void SetCellContent(Excel.Worksheet worksheet, int max_row, int max_col, int recordRaw, int recordCol)
        {
            // Copia i valori nella griglia.
            for (int row = 2; row <= max_row; row++)
            {
                for (int col = 1; col <= max_col; col++)
                {
                    if (row == recordRaw && col == recordCol && recordCol == 3)
                    {
                        worksheet.Cells[row, col] = _pathDataCell;
                    }
                    else if (row == recordRaw && col == (recordCol + 1) && (recordCol + 1) == 4)
                    {
                        worksheet.Cells[row, col] = _pathBOLD_Distinta;
                    }
                    else if (row == recordRaw && col == (recordCol + 2) && (recordCol + 2) == 5)
                    {
                        worksheet.Cells[row, col] = _pathImages;
                    }
                    else if (row == recordRaw && col == recordCol  && recordCol == 6)
                    {
                        worksheet.Cells[row, col] = _typologieCode;
                    }
                    else if (row == recordRaw && col == (recordCol + 1) && (recordCol + 1) == 7)
                    {
                        worksheet.Cells[row, col] = _cellCode;
                    }
                    else if (row == recordRaw && col == (recordCol + 2) && (recordCol + 2) == 8)
                    {
                        worksheet.Cells[row, col] = _positionalCode;
                    }
                }
            }
        }

        /// <summary>
        ///   Metodo che chiude tutti i processi Excel attivi
        /// </summary>
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
        #endregion

        #region Customization
        /// <summary>
        ///   Personalizza - Pulsante che consente la modifica dei campi ReadOnly
        /// </summary>
        /// 
        private void customizationButton_Click(object sender, EventArgs e)
        {
            editControl = new EditControl();
            editControl.Show();
            this.DozeOff();
            this.SendToBack();
            editControl.TopMost = true;
        }

        /// <summary>
        ///  Metodo che rende modificabili i campi ReadOnly
        /// </summary>
        /// 
        public void CustomizationOn()
        {
            tabPage1commesseFileTextBox.BackColor = SystemColors.ButtonFace;
            tabPage1commesseFileButton.BackColor = Color.Transparent;
            tabPage1commesseFileButton.Enabled = true;
            typologieCodeComboBox.BackColor = SystemColors.Window;
            typologieCodeComboBox.Enabled = true;
            cellCodeComboBox.BackColor = SystemColors.Window;
            cellCodeComboBox.Enabled = true;
            positionalCodeComboBox.BackColor = SystemColors.Window;
            positionalCodeComboBox.Enabled = true;
            saveButton.BackColor = SystemColors.GradientInactiveCaption;
            saveButton.Enabled = true;
        }

        /// <summary>
        ///  Metodo di Chiusura della finestra di dialogo
        /// </summary>
        /// 
        public void CloseEditControl()
        {
            this.WakeUp();
            this.BringToFront();
            editControl.Close();
        }

        #endregion

        /// <summary>
        ///   Exit - chiude la finestra di dialogo
        /// </summary>
        /// 
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }  // class
}
