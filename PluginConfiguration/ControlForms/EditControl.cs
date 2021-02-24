using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginConfiguration.ControlForms
{
    public partial class EditControl : Form
    {
        // Istanza del Controllo Editcontrol
        public static EditControl thisForm;

        // Istanza della From principale
        private ModelessForm _modelessForm;
        public EditControl()
        {
            InitializeComponent();

            // Inizializza l'istanza
            thisForm = this;
        }

        /// <summary>
        ///  Metodo che ACCETTA di rendere modificabili i campi ReadOnly
        /// </summary>
        /// 
        private void okButton_Click(object sender, EventArgs e)
        {
            // Metodo di rende moficabili i campi selezionati
            _modelessForm = App.thisApp.RetriveForm();
            _modelessForm.CustomizationOn();

            // Metodo di chiusura di questa Form
            _modelessForm.CloseEditControl();
        }

        /// <summary>
        ///  Metodo che NEGA di rendere modificabili i campi ReadOnly
        /// </summary>
        /// 
        private void noButton_Click(object sender, EventArgs e)
        {
            // Metodo di chiusura di questa Form
            _modelessForm = App.thisApp.RetriveForm();
            _modelessForm.CloseEditControl();
        }
    }
}
