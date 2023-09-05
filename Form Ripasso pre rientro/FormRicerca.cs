using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ripasso_pre_rientro
{
    public partial class FormRicerca : Form
    {
        public string path, pathTEMP;
        public ListViewItem record;
        Funzioni f;
        public FormRicerca()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
        }
        private void FormRicerca_Load(object sender, EventArgs e)
        {
            panelSearchResult.Visible = false;
        }
        private void buttonRicerca_Click(object sender, EventArgs e)
        {
            Tuple<string, int> searchResult = f.Ricerca(path, textBoxSearchMunicipio.Text, false);
            if (textBoxSearchMunicipio.Text == "")
                MessageBox.Show("Inserire un valore da cercare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (searchResult.Item2 == -1)
                    MessageBox.Show("Il record cercato non è stato trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    
                    string[] arr = new string[2];
                    listViewResult.View = View.Details;
                    listViewResult.GridLines = true;
                    listViewResult.FullRowSelect = true;
                    listViewResult.Columns.Add("Record", 250);
                    listViewResult.Columns.Add("Posizione", 70);
                    for (int i = 0; i <= 1; i++)
                    {
                        arr[0] = $"{searchResult.Item1}";
                        arr[1] = $"{searchResult.Item2}";
                        record = new ListViewItem(arr);                       
                    }
                    listViewResult.Items.Add(record);
                    panelSearchResult.Visible = true;
                }
            }
        }
    }
}
