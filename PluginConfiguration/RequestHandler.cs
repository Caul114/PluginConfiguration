//
// (C) Copyright 2003-2017 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE. AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PluginConfiguration
{
    /// <summary>
    ///   Una classe con metodi per eseguire le richieste effettuate dall'utente della finestra di dialogo.
    /// </summary>
    /// 
    public class RequestHandler : IExternalEventHandler  // Un'istanza di una classe che implementa questa interfaccia verrà registrata prima con Revit e ogni volta che viene generato l'evento esterno corrispondente, verrà richiamato il metodo Execute di questa interfaccia.
    {
        #region Private data members
        // Il valore dell'ultima richiesta effettuata dal modulo non modale
        private Request m_request = new Request();

        // Un instanza della finestra di dialogo
        private ModelessForm _modelessForm;

        // Il nome del Codice Tipologia
        private string _typologieCode = string.Empty;

        //// Il valore del Codice Tipologia
        //private string _valueTypologieCode = string.Empty;

        // Il nome del Codice Cellula
        private string _cellCode = string.Empty;

        //// Il valore del Codice Cellula
        //private string _valueCellCode = string.Empty;

        // Il nome del Codice Posizionale
        private string _positionalCode = string.Empty;

        //// Il valore del Codice Posizionale
        //private string _valuePositionalCode = string.Empty;

        // Variabile che raccoglie tutti i parametri dell'elemento
        private List<string> _allParameters;
        #endregion

        #region Class public property
        /// <summary>
        /// Proprietà pubblica per accedere al valore della richiesta corrente
        /// </summary>
        public Request Request
        {
            get { return m_request; }
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

        #region Class public method
        /// <summary>
        /// Costruttore di default di RequestHandler
        /// </summary>
        public RequestHandler()
        {
            // Costruisce i membri dei dati per le proprietà
            _allParameters = new List<string>();
        }
        #endregion

        /// <summary>
        ///   Un metodo per identificare questo gestore di eventi esterno
        /// </summary>
        public String GetName()
        {
            return "R2014 External Event Sample";
        }

        /// <summary>
        ///   Il metodo principale del gestore di eventi.
        /// </summary>
        /// <remarks>
        ///   Viene chiamato da Revit dopo che è stato generato l'evento esterno corrispondente 
        ///   (dal modulo non modale) e Revit ha raggiunto il momento in cui potrebbe 
        ///   chiamare il gestore dell'evento (cioè questo oggetto)
        /// </remarks>
        /// 
        public void Execute(UIApplication uiapp)
        {
            try
            {
                switch (Request.Take())
                {
                    case RequestId.None:
                        {
                            return;  // no request at this time -> we can leave immediately
                        }
                    case RequestId.SetCode:
                        {
                            // Cattura tutti i parametri di un Curtain Panel
                            _allParameters = GetAllParameters(uiapp);
                            // Riempie le ComboBoxes del CodexDefinition
                            _modelessForm = App.thisApp.RetriveForm();
                            _modelessForm.FillTheComboBoxes(_allParameters);
                            break;
                        }
                    case RequestId.ChangeCode:
                        {
                            break;
                        }
                    default:
                        {
                            // Una sorta di avviso qui dovrebbe informarci di una richiesta imprevista
                            break;
                        }
                }
            }
            finally
            {
                App.thisApp.WakeFormUp();
                App.thisApp.ShowFormTop();
            }

            return;
        }

        /// <summary>
        ///   La subroutine che cattura TUTTI I PARAMETRI di un elemento casuale
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="uiapp">L'oggetto Applicazione di Revit</param>m>
        /// 
        private List<string> GetAllParameters(UIApplication uiapp)
        {
            List<string> parameters = new List<string>();
            // Chiamo la vista attiva e seleziono gli elementi che mi servono
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            // Metodo per catturare i Curtain Panels del Document
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ElementCategoryFilter categoryFilter = new ElementCategoryFilter(BuiltInCategory.OST_CurtainWallPanels);
            collector.WherePasses(categoryFilter);

            // Cattura il primo elemento della collezione
            Element ele = collector.FirstOrDefault(p =>
                p.get_Parameter(BuiltInParameter.HOST_VOLUME_COMPUTED) != null &&
                p.get_Parameter(BuiltInParameter.HOST_VOLUME_COMPUTED).Definition.Name == "Volume");
            parameters = GetAllParameterValues(doc, ele);
            return parameters;
        }

        /// <summary>
        /// Restituisce tutti i valori dei parametri
        /// </summary>
        private List<string> GetAllParameterValues(Document doc, Element e)
        {
            ArrayList allParams = new ArrayList();

            // (1) Cattura tutti i parametri scelti tramite un METODO
            IList<Parameter> psM = e.GetOrderedParameters();

            foreach (Parameter p in psM)
            {
                // AsValueString visualizza il valore così come lo vede l'utente. 
                // In alcuni casi, il valore del database sottostante 
                // restituito da AsInteger, AsDouble, ecc., potrebbe essere più rilevante.
                allParams.Add(string.Format("{0}", p.Definition.Name));
            }

            // (2) Ottiene il ParameterSet tramite la PROPRIETA' dell'elemento
            ParameterSet psP = e.Parameters;

            foreach (Parameter p in psP)
            {
                allParams.Add(string.Format("{0}", p.Definition.Name));
            }

            // (3) Ottiene il ParameterSet tramite la FAMIGLIA dell'elemento
            ElementType eleType = doc.GetElement(e.GetTypeId()) as ElementType;
            if (eleType != null)
            {
                ParameterSet psF = eleType.Parameters;

                foreach (Parameter p in psF)
                {
                    allParams.Add(string.Format("{0}", p.Definition.Name));
                }
            }

            // Dichiara una List<string> temporanea e la riempio 
            List<string> temp = new List<string>();
            foreach (var item in allParams)
            {
                temp.Add((string)item);
            }
            // Crea un IOrderedEnumerable per ordinare la List<string>
            var ordered = temp.OrderBy(x => x).Distinct();
            // Dichiara e riempie una nuova ArrayList per il risultato finale
            List<string> stringsResult = new List<string>();
            foreach (var item in ordered)
            {
                stringsResult.Add(item);
            }

            return stringsResult;
        }

    }  // class

}  // namespace

