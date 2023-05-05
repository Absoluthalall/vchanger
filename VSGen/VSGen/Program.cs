using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VSGen
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //FormLogin form = new FormLogin();
                if (Properties.Settings.Default.Username == string.Empty)
                {
                    string username = Interaction.InputBox("Please enter your username. " +
                        "If an error occurs, the system will send an email on your behalf to support. " +
                        "Thus, you will only need to tell them your username so that they can identify your error. You will not be able to change it!", "Important warning", "");
                    if (username != string.Empty)
                    {
                        Properties.Settings.Default.Username = username;
                        Properties.Settings.Default.Save();
                    }
                }
                //FormLogin form = new FormLogin();
                Form1 form = new Form1();
                form.Show();
                Application.Run();
            }
            catch (Exception ex)
            {
                EmailSender.CatchException(ex, "Error while loading mainform");
            }
        }
    }
}
