using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        line = line.PadRight(256) + "##";
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
    }
}
