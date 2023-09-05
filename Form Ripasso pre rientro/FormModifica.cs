using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ripasso_pre_rientro
{
    public partial class FormModifica : Form
    {
        public string path, pathTEMP;
        Funzioni f;
        Random r;
        public Tuple<string, int> searchResult;
        string[] inputs;
        int lRecord;
        public FormModifica()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
            r = new Random();
            lRecord = 504;
        }
        private void FormModifica_Load(object sender, EventArgs e)
        {
            panelModificaMunicipio.Visible = false;
            panelModificaQuartiere.Visible = false;
            panelModificaZoneUrbane.Visible = false;
            panelModificaZoneAgro.Visible = false;
            panelModificaRione.Visible = false;
            panelModificaSubUrbio.Visible = false;
            panelModificaBorgate.Visible = false;
            panelModificaEtichetta.Visible = false;
            panelModificaExMunicipi.Visible = false;
            buttonMod.Visible = false;
        }

        private void buttonModSearch_Click(object sender, EventArgs e)
        {
            Tuple<string, int> searchResult = f.Ricerca(path, textBoxModSearch.Text, false);
            if (textBoxModSearch.Text == "")
                MessageBox.Show("Inserire un valore da cercare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (searchResult.Item2 == -1)
                    MessageBox.Show("Il record cercato non è stato trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    panelModSearch.Visible = false;
                    buttonModSearch.Visible = false;
                    panelModificaMunicipio.Visible = true;
                    panelModificaQuartiere.Visible = true;
                    panelModificaZoneUrbane.Visible = true;
                    panelModificaZoneAgro.Visible = true;
                    panelModificaRione.Visible = true;
                    panelModificaSubUrbio.Visible = true;
                    panelModificaBorgate.Visible = true;
                    panelModificaEtichetta.Visible = true;
                    panelModificaExMunicipi.Visible = true;
                    buttonMod.Visible = true;
                }
            }
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            Tuple<string, int> searchResult = f.Ricerca(path, textBoxModSearch.Text, false);
            int campi = f.ContaCampi(path);
            inputs = new string[campi];
            inputs[0] = textBoxModMunicipio.Text;
            inputs[1] = textBoxModZoneUrbane.Text;
            inputs[2] = textBoxModRione.Text;
            inputs[3] = textBoxModQuartiere.Text;
            inputs[4] = textBoxModSubUrbio.Text;
            inputs[5] = textBoxModZoneAgro.Text;
            inputs[6] = textBoxModBorgate.Text;
            inputs[7] = textBoxModExMunicipi.Text;
            inputs[8] = textBoxModEtichetta.Text;
            if (f.CheckMioValore(path))
            {
                inputs[9] = r.Next(10, 21).ToString();
                inputs[10] = "0";
            }
            if (!f.CheckLunghezzaInput(campi, inputs))
            {
                if (f.CheckMioValore(path) == true)
                    MessageBox.Show("Alcuni input sono vuoti o troppo lunghi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Alcuni input sono vuoti o troppo lunghi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!f.CheckInptChar(campi, inputs))
            {
                MessageBox.Show("Alcuni input contengono caratteri non validi ('\\', ';', '#')", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                f.Modifica(path, campi, inputs, searchResult.Item2, lRecord);
                MessageBox.Show("Modifica effettutata correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
