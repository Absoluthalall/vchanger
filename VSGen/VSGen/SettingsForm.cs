using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSGen.Config;

namespace VSGen
{
    public partial class SettingsForm : Form
    {
        Form1 parentForm;
        public SettingsForm(Form1 form)
        {
            parentForm = form;
            InitializeComponent();
            textBoxGamePath.Font = new Font(textBoxGamePath.Font.Name, textBoxGamePath.Font.Size * UserConfig.DPI, textBoxGamePath.Font.Style);
            if (Properties.Settings.Default.Path != null)
                textBoxGamePath.Text = Properties.Settings.Default.Path;
            if (UserConfig.HasBackup && Properties.Settings.Default.EditCoins)
            {
                toggleButtonSetCoins.CheckState = CheckState.Checked;
            }
            else
            {
                toggleButtonSetCoins.CheckState = CheckState.Unchecked;
            }
            if (UserConfig.HasDLC1)
            {
                labelStatus.Text = "Yes";
                labelStatus.ForeColor = Color.LightGreen;
            }
            else
            {
                labelStatus.Text = "No";
                labelStatus.ForeColor = Color.FromArgb(192, 0, 0);
            }
            if (UserConfig.HasDLC2)
            {
                labelStatus2.Text = "Yes";
                labelStatus2.ForeColor = Color.LightGreen;
            }
            else
            {
                labelStatus2.Text = "No";
                labelStatus2.ForeColor = Color.FromArgb(192, 0, 0);
            }
            if (UserConfig.HasBackup)
            {
                label1.Text = "Enabled";
                label1.ForeColor = Color.LightGreen;
            }
            else
            {
                label1.Text = "Disabled";
                label1.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.curSettingsForm = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "Choosing Vampire Survivors.exe ...";
            ofd.InitialDirectory = @"C:\\";
            ofd.ShowDialog();
            if (ofd.FileName.EndsWith("VampireSurvivors.exe"))
            {
                textBoxGamePath.Text = ofd.FileName;
                Properties.Settings.Default.Path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void toggleButtonSetCoins_CheckStateChanged(object sender, EventArgs e)
        {
            if (!UserConfig.HasBackup)
            {
                Thread.Sleep(100);
                toggleButtonSetCoins.CheckState = CheckState.Unchecked;
            }
            else
            {
                Properties.Settings.Default.EditCoins = toggleButtonSetCoins.Checked;
                Properties.Settings.Default.Save();
            }
        }
    }
}
