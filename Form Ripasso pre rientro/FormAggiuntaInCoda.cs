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
    public partial class FormAggiuntaInCoda : Form
    {
        public string path, pathTEMP;
        Funzioni f;
        Random r;
        string[] inputs;
        public FormAggiuntaInCoda()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
            r = new Random();
        }
        private void buttonAggiunta_Click(object sender, EventArgs e)
        {
            int campi = f.ContaCampi(path);
            inputs = new string[campi];
            inputs[0] = textBoxAddMunicipio.Text;
            inputs[1] = textBoxAddZoneUrbane.Text;
            inputs[2] = textBoxAddRione.Text;
            inputs[3] = textBoxAddQuartiere.Text;
            inputs[4] = textBoxAddSubUrbio.Text;
            inputs[5] = textBoxAddZoneAgro.Text;
            inputs[6] = textBoxAddBorgate.Text;
            inputs[7] = textBoxAddExMunicipi.Text;
            inputs[8] = textBoxAddEtichetta.Text;
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
            if (!f.CheckInptChar(campi, inputs))
            {
                MessageBox.Show("Alcuni input contengono caratteri non validi ('\\', ';', '#')", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            f.AggiungiInCoda(path, campi, inputs);
        }
    }
}
