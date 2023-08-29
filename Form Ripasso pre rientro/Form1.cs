using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ripasso_pre_rientro
{
    public partial class Form1 : Form
    {
        #region Dichiarazioni
        public string path, pathTEMP;
        Funzioni f;
        #endregion
        #region Funzioni evento
        public Form1()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonAggMyValue_Click(object sender, EventArgs e)
        {

        }
        private void buttonContaCampi_Click(object sender, EventArgs e)
        {

        }
        private void buttonLunghezzaRC_Click(object sender, EventArgs e)
        {

        }
        private void buttonAggRecord_Click(object sender, EventArgs e)
        {

        }
        private void buttonVisualizza_Click(object sender, EventArgs e)
        {

        }
        private void buttonRicerca_Click(object sender, EventArgs e)
        {
            OpenFormInput<FormRicerca>();
        }
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            OpenFormInput<FormModifica>();
        }
        private void buttonCancLogica_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Funzioni
        // Funzione per aprire un form in un pannello
        private void OpenFormInput<MyForm>() where MyForm : Form, new()
        {
            Form FormInput;
            FormInput = panelInput.Controls.OfType<MyForm>().FirstOrDefault();
            if (FormInput == null)
            {
                FormInput = new MyForm();
                FormInput.TopLevel = false;
                FormInput.FormBorderStyle = FormBorderStyle.None;
                FormInput.Dock = DockStyle.Fill;
                panelInput.Controls.Add(FormInput);
                panelInput.Tag = FormInput;
                FormInput.Show();
                FormInput.BringToFront();
            }
            else
            {
                FormInput.BringToFront();
            }
        }
        #endregion
    }
}