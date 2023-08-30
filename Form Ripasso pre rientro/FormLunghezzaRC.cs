using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Ripasso_pre_rientro
{
    public partial class FormLunghezzaRC : Form
    {
        public string path, pathTEMP;
        Funzioni f;
        public FormLunghezzaRC()
        {
            InitializeComponent();
            path = @"rota.csv";
            pathTEMP = @"rotaTEMP.csv";
            f = new Funzioni();
            VisualizzaLunghezzaRC(path);
        }
        public void VisualizzaLunghezzaRC(string path)
        {
            string[] colonne = { "Lunghezza massima dei campi per record", "Caratteri" };
            listViewLunghezzaRC.View = View.Details;
            listViewLunghezzaRC.GridLines = true;
            listViewLunghezzaRC.FullRowSelect = true;
            listViewLunghezzaRC.Columns.Add(colonne[0], 250);
            listViewLunghezzaRC.Columns.Add(colonne[1], 70);
            int nCampi = f.ContaCampi(path);
            string[] maxLenght = f.LunghezzaRC(path, nCampi);
            string[] arr = new string[2];
            ListViewItem itm;
            for (int i = 0; i < nCampi; i++)
            {
                arr[0] = $"{maxLenght[i]}";
                arr[1] = $"{maxLenght[i].Length}";
                itm = new ListViewItem(arr);
                listViewLunghezzaRC.Items.Add(itm);
            }
        }
    }
}
