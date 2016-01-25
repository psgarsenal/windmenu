﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini; // Load and save ini files

namespace windmenu
{
    static class Program
    {
        static public string[] colors;
        static public string[] aliases;
        static public IniFile ini;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string iniPath = Application.UserAppDataPath;
            ini = new IniFile(iniPath + "\\\\windmenu.ini");
            colors = ini.IniReadValue("Colors", "list").Split(';');
            aliases = ini.IniReadValue("Aliases", "list").Split(';');
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}