using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MultiFileReplacer
{
    public class Config
    {
        private string path;

        public Config(string path)
        {
            files = new Dictionary<string,bool>();
            this.path = path;

            try
            {
                string[] text = File.ReadAllLines(path);

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j].StartsWith("#")) continue;
                    if (text[j].StartsWith("Search=")) this.search = text[j].Split('=')[1].Trim();
                    if (text[j].StartsWith("Replace=")) this.replace = text[j].Split('=')[1].Trim();
                    if (text[j].StartsWith("UseMachine=")) this.useMachine = text[j].Split('=')[1].Trim() == "1" ? true : false;
                    if (text[j].StartsWith("Update=")) this.update = text[j].Split('=')[1].Trim() == "1" ? true : false;

                    if (text[j].StartsWith("File_")) this.files.Add(text[j].Split('=')[1].Split('|')[0].Trim(), (text[j].Split('=')[1].Split('|')[1].Trim()=="1" ? true:false));
                }
            }
            catch (FileNotFoundException)
            {
                this.search = "";
                this.replace = "";
                this.useMachine = true;

            }
        }

        private string search = "";
        public string Search { get { return search; } set { search = value; } }

        private string replace = "";
        public string Replace { get { return replace; } set { replace = value; } }

        private bool useMachine = true;
        public bool UseMachine { get { return useMachine; } set { useMachine = value; } }

        private bool update = true;
        public bool Update { get { return update; } set { update = value; } }

        private Dictionary<string,bool> files;
        /// <summary>
        /// Path, replace name
        /// </summary>
        public Dictionary<string,bool> Files { get { return files; } set { files = value; } }

        /// <summary>
        /// Saves Config to File
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            List<string> data = new List<string>();

            data.Add("# Config File for MFR");
            data.Add("Search=" + this.search);
            data.Add("Replace=" + this.replace);
            data.Add("UseMachine=" + (this.useMachine ? "1" : "0"));

            int i = 0;
            foreach (KeyValuePair<string,bool> item in this.files)
            {
                data.Add("File_" + i + "=" + item.Key + "|" + (item.Value ? "1" : "0"));
                i++;
            }

            File.WriteAllLines(this.path, data.ToArray());
            return true;
        }
    }
}
