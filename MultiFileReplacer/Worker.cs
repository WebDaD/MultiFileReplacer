using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MultiFileReplacer
{
    public static class Worker
    {
        public static Encoding enc = Encoding.GetEncoding(1252);

        public static string searchReplace(string file, string search, string replace, bool replaceFileName, ProgressBar pb = null)
        {
            if (File.Exists(file))
            {
                File.Copy(file, file + ".original", true);

                string[] text = File.ReadAllLines(file, enc);
                if (pb != null)
                {
                    pb.Minimum = 0;
                    pb.Maximum = text.Length;
                    pb.Value = 0;
                }


                for (int j = 0; j < text.Length; j++)
                {
                    text[j] = text[j].Replace(search, replace);
                    if (pb != null) pb.PerformStep();
                }


                if (replaceFileName)
                {
                    string filename = Path.GetFileName(file).Replace(search, replace);
                    string path = Path.GetDirectoryName(file);
                    File.Delete(file);
                    file = Path.Combine(path, filename);
                }
                File.WriteAllLines(file, text, enc);
            }
            else
            {
                MessageBox.Show("Datei " + file + " existiert nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return file;
        }
    }
}
