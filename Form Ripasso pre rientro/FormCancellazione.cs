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
    public partial class FormCancellazione : Form
    {
        public string path, pathTEMP;
        Funzioni f;
        Random r;
        public Tuple<string, int> searchResult;
        int lRecord;
        public FormCancellazione()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
            r = new Random();
            lRecord = 504;
        }
        private void buttonCancella_Click(object sender, EventArgs e)
        {
            Tuple<string, int> searchResult = f.Ricerca(path, textBoxCancella.Text, false);
            int campi = f.ContaCampi(path);
            if (!f.CheckMioValore(path))
                MessageBox.Show("Aggiungere prima i campi 'Mio valore' e cancellazione logica", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (searchResult.Item2 != -1)
                {
                    f.Cancellazione(path, campi, searchResult.Item1, searchResult.Item2 + 1, lRecord);
                    MessageBox.Show("Record eliminato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Record non trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRecupera_Click(object sender, EventArgs e)
        {
            Tuple<string, int> searchResult = f.Ricerca(path, textBoxRecupera.Text, true);
            int campi = f.ContaCampi(path);
            if (!f.CheckMioValore(path))
                MessageBox.Show("Aggiungere prima i campi 'Mio valore' e cancellazione logica", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (searchResult.Item2 != -1)
                {
                    f.Cancellazione(path, campi, searchResult.Item1, searchResult.Item2 + 1, lRecord);
                    MessageBox.Show("Record recuperato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Record non trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRicompatta_Click(object sender, EventArgs e)
        {
            if (!f.CheckMioValore(path))
                MessageBox.Show("Non è possibile ricompattare il file!\nAggiungere prima i campi 'Mio valore' e cancellazione logica", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                f.Ricompattazione(path, pathTEMP);
                MessageBox.Show("File ricompattato correttamente!");
            }
        }
    }
}
