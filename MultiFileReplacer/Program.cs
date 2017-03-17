using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiFileReplacer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[]args)
        {
            if (args != null && args.Length == 1 || args.Length == 2)
            {
                if (args[0] == "-a")
                {
                    Console.WriteLine("Starting auto replace");
                    string configFile = "";
                    if (args[1].StartsWith("--config"))
                    {
                        configFile = args[1].Split('=')[1].Trim();
                    }
                    else
                    {
                        configFile = Application.StartupPath + "\\" + "config.ini";
                    }
                    Config c = new Config(configFile);
                    foreach (KeyValuePair<string,bool> file in c.Files)
                    {
                        Worker.searchReplace(file.Key, c.Search, c.UseMachine ? Environment.MachineName : c.Replace, file.Value);
                        Console.WriteLine("Replaced in " + file.Key);
                    }
                    Console.WriteLine("Done");
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
