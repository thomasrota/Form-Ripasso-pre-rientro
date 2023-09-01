using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.CodeDom;

namespace Form_Ripasso_pre_rientro
{
    public class Funzioni
    {
        // Funzione che controlla se il file csv ha la lunghezza fissa
        public bool CheckLughezzaFissa(string path)
        {
            bool check = false;
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                if (line.Contains("##"))
                    check = true;
                sr.Close();
            }
            return check;
        }
        // Funzione che rende il file a lunghezza fissa
        public void CreateLunghezzaFissa(string path, string pathTEMP)
        {
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                using (StreamWriter sw = new StreamWriter(pathTEMP, append: true))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        line += ";";
                        line = line.PadRight(500) + "##";
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
                sr.Close();
            }
            File.Delete(path);
            File.Move(pathTEMP, path);
            File.Delete(pathTEMP);
        }
        // Funzione che controlla l'esistenza di 'mio valore' e dei campi successivi
        public bool CheckMioValore(string path)
        {
            bool check = false;
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                if (line.Contains("Mio valore;"))
                    check = true;
                sr.Close();
            }
            return check;
        }
        // Funzione aggiunta 'mio valore' e 'cancellazione logica'
        public void CreateMyValue(string path, string pathTEMP)
        {
            Random r = new Random();
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                using (StreamWriter sw = new StreamWriter(pathTEMP, append: true))
                {
                    line = sr.ReadLine();
                    string[] dati = line.Split(';');
                    line = "";
                    for (int i = 0; i < dati.Length - 1; i++)
                        line += dati[i] + ";";
                    line += "Mio valore;Cancellazione logica;";
                    line = line.PadRight(500) + "##";
                    sw.WriteLine(line);
                    while ((line = sr.ReadLine()) != null)
                    {
                        dati = line.Split(';');
                        line = "";
                        for (int i = 0; i < dati.Length - 1; i++)
                            line += dati[i] + ";";
                        line += r.Next(10, 21) + ";0;";
                        line = line.PadRight(500) + "##";
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
                sr.Close();
            }
            File.Delete(path);
            File.Move(pathTEMP, path);
            File.Delete(pathTEMP);
        }
        // Funzione che conta il numero di campi
        public int ContaCampi(string path)
        {
            int count;
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                string[] dati = line.Split(';');
                count = dati.Length - 1;
                sr.Close();
            }
            return count;
        }
        public string[] LunghezzaRC(string path, int nCampi)
        {
            string[] mLen = new string[nCampi + 1];
            for (int i = 0; i < mLen.Length; i++)
                mLen[i] = "";
            string line;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    line = "";
                    for (int i = 0; i < dati.Length; i++)
                    {
                        if (dati[i].Length > mLen[i].Length)
                            mLen[i] = dati[i];
                        line += dati[i] + ";";
                    }
                    if (line.Length > mLen[nCampi].Length)
                        mLen[nCampi] = line;
                }
                sr.Close();
            }
            return mLen;
        }
        // Funzione che controlla la dimensione dell'input e se è 'vuoto'
        public bool CheckLunghezzaInput(int nCampi, string[] inputs)
        {
            string line = ""; 
            for (int i = 0; i < nCampi; i++)
            {
                line += inputs[i] + ";";
                /*if (inputs[i].Length == 0)
                   return false;*/
            }
            if (nCampi == 11)
                if (line.Length < 500)
                    return true;
                else return false;
            else
                if (line.Length < 455)
                return true;
            return false;
        }
        // Funzione che aggiunge dei record in coda
        public void AggiungiInCoda(string path, int nCampi, string[] inputs)
        {
            string line = "";
            for (int i = 0; i < nCampi; i++)
                line += inputs[i] + ";";
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine(line.PadRight(500) + "##");
                sw.Close();
            }
        }
        // Ricercare un record per campo chiave a scelta (se esiste, utilizzare il campo che contiene dati univoci);
        public Tuple <string , int> Ricerca(string path, string search)
        {
            Tuple<string, int> pos;
            string line;
            int count = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[0] == search)
                    {
                        sr.Close();
                        pos = new Tuple<string, int>(line, count);
                        return pos;
                    }
                    count++;
                }
                sr.Close();
            }
            return new Tuple<string, int>("", -1);
        }
    }
}
