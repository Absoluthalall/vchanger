using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Scripts;

namespace VSGen.Scripts
{
    internal class GenerateThread
    {
        string _pathToSave1;
        string _pathToSave2;
        string _pathToSave3;

        internal GenerateThread()
        {
            _pathToSave1 = SearchForFile("main.bundle.js", Properties.Settings.Default.Path.Replace("VampireSurvivors.exe", ""), out bool exists);
            if (!exists)
                throw new Exception("No main.bundle.js found!");
            _pathToSave2 = SearchForFile("characterData_Moonspell.json", Properties.Settings.Default.Path.Replace("VampireSurvivors.exe", ""), out exists);
            _pathToSave3 = SearchForFile("characterData_Foscari.json",  Properties.Settings.Default.Path.Replace("VampireSurvivors.exe", ""), out exists);
        }

        public static string SearchForFile(string fileName, string startFolder, out bool flag)
        {
            string[] files = Directory.GetFiles(startFolder, fileName, SearchOption.AllDirectories);
            if (files.Length == 0)
            {
                flag = false;
                return string.Empty;
            }
            flag = true;
            return files[0];
        }

        internal void CallGenerate()
        {
            try
            {
                if (_pathToSave1 == string.Empty)
                    throw new Exception("No file main.bundle.js");
                Script.Generate(_pathToSave1, _pathToSave1);
                if (UserConfig.HasDLC1)
                    Script.GenerateDLC(_pathToSave2, _pathToSave2);
                if (UserConfig.HasDLC2)
                    Script.GenerateDLC2(_pathToSave3, _pathToSave3);
                if (UserConfig.HasBackup && Properties.Settings.Default.EditCoins)
                    Script.EditCoins(7777777);
                MessageBox.Show(
                    "Successfully generated!",
                    "Generation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                EmailSender.CatchException(ex, ex.Message);
            }
        }
    }
}
