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
    }
}
