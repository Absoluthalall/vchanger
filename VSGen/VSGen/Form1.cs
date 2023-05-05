using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Data;
using VSGen.Scripts;
using static VSGen.Config.UserConfig;

namespace VSGen
{
    public partial class Form1 : Form
    {
        Thread currentThread;
        internal SettingsForm curSettingsForm;

        public Form1()
        {
            InitializeComponent();
            UserConfig.DPI = iconButtonStHeroes.Width / 229f;
            UserConfig.Subscription = 3;
            labelUserData.Text = $@"Username: {(Properties.Settings.Default.Username != string.Empty ? Properties.Settings.Default.Username : "Not set")}
Status: Free
Expires: Never";
            label9.Text = $"version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Script.InitHeroes();
            leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(7, 60);
            panelLeftMenu.Controls.Add(leftBorderBtn);
            backgroundWorkerDlcChecker.DoWork += (obj, ea) => CheckForDLC();
            backgroundWorkerDlcChecker.RunWorkerAsync(); 
        }

        public void SetTogglers()
        {
            if (Script.currentDLCHeroIndex == -1 && Script.currentDLC2HeroIndex == -1)
            {
                toggleButtonHP.Checked = Hero.heroes[Script.currentHeroIndex].Hp;
                toggleButtonMovespeed.Checked = Hero.heroes[Script.currentHeroIndex].Movespeed;
                toggleButtonProjectiles.Checked = Hero.heroes[Script.currentHeroIndex].Area;
                toggleButtonExp.Checked = Hero.heroes[Script.currentHeroIndex].Growth;
                toggleButtonGems.Checked = Hero.heroes[Script.currentHeroIndex].Magnet;
                toggleButtonLuck.Checked = Hero.heroes[Script.currentHeroIndex].Luck;
                toggleButtonRegen.Checked = Hero.heroes[Script.currentHeroIndex].Regen;
                toggleButtonUnlock.Checked = Hero.heroes[Script.currentHeroIndex].Unlocked;
            }
            else if (Script.currentHeroIndex == -1 && Script.currentDLC2HeroIndex == -1)
            {
                toggleButtonHP.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Hp;
                toggleButtonMovespeed.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Movespeed;
                toggleButtonProjectiles.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Area;
                toggleButtonExp.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Growth;
                toggleButtonGems.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Magnet;
                toggleButtonLuck.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Luck;
                toggleButtonRegen.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Regen;
                toggleButtonUnlock.Checked = DLCHero.heroes[Script.currentDLCHeroIndex].Unlocked;
            }
            else if (Script.currentHeroIndex == -1 && Script.currentDLCHeroIndex == -1)
            {
                toggleButtonHP.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Hp;
                toggleButtonMovespeed.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Movespeed;
                toggleButtonProjectiles.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Area;
                toggleButtonExp.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Growth;
                toggleButtonGems.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Magnet;
                toggleButtonLuck.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Luck;
                toggleButtonRegen.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Regen;
                toggleButtonUnlock.Checked = DLC2Hero.heroes[Script.currentDLC2HeroIndex].Unlocked;
            }
        }

        public void EnableTogglers()
        {
            toggleButtonHP.Enabled = Enabled;
            toggleButtonMovespeed.Enabled = Enabled;
            toggleButtonProjectiles.Enabled = Enabled;
            toggleButtonExp.Enabled = Enabled;
            toggleButtonGems.Enabled = Enabled;
            toggleButtonLuck.Enabled = Enabled;
            toggleButtonRegen.Enabled = Enabled;
            toggleButtonChangeAll.Enabled = Enabled;
            toggleButtonUnlock.Enabled = Enabled;
        }

        public void CheckAllTogglers()
        {
            toggleButtonHP.Checked = true;
            toggleButtonExp.Checked = true;
            toggleButtonGems.Checked = true;
            toggleButtonLuck.Checked = true;
            toggleButtonProjectiles.Checked = true;
            toggleButtonRegen.Checked = true;
            toggleButtonMovespeed.Checked = true;
            toggleButtonUnlock.Checked = true;
        }

        private async void CheckForDLC()
        {
            try
            {
                if (Properties.Settings.Default.Path == null)
                {
                    UserConfig.HasDLC1 = false;
                    UserConfig.HasDLC2 = false;
                    UserConfig.HasBackup = false;
                }
                else
                {
                    string sf = Properties.Settings.Default.Path.Replace("VampireSurvivors.exe", "");
                    var fileName = "characterData_Moonspell.json";
                    GenerateThread.SearchForFile(fileName, sf, out bool exists);
                    HasDLC1 = exists;
                    fileName = "characterData_Foscari.json";
                    GenerateThread.SearchForFile(fileName, sf, out exists);
                    HasDLC2 = exists;
                    fileName = "LastRunBackup.sav";
                    GenerateThread.SearchForFile(fileName, sf, out exists);
                    HasBackup = exists;
                }
                if (curSettingsForm != null)
                {
                    if (UserConfig.HasDLC1)
                    {
                        curSettingsForm.labelStatus.Text = "Yes";
                        curSettingsForm.labelStatus.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        curSettingsForm.labelStatus.Text = "No";
                        curSettingsForm.labelStatus.ForeColor = Color.FromArgb(192, 0, 0);
                    }
                    if (UserConfig.HasDLC2)
                    {
                        curSettingsForm.labelStatus2.Text = "Yes";
                        curSettingsForm.labelStatus2.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        curSettingsForm.labelStatus2.Text = "No";
                        curSettingsForm.labelStatus2.ForeColor = Color.FromArgb(192, 0, 0);
                    }
                    if (UserConfig.HasBackup)
                    {
                        curSettingsForm.label1.Text = "Enabled";
                        curSettingsForm.label1.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        curSettingsForm.label1.Text = "Disabled";
                        curSettingsForm.label1.ForeColor = Color.FromArgb(192, 0, 0);
                        if (curSettingsForm.toggleButtonSetCoins.Checked)
                            curSettingsForm.toggleButtonSetCoins.CheckState = CheckState.Unchecked;
                    }
                }
                else if (curSettingsForm != null)
                {
                    curSettingsForm.labelStatus.Text = "No";
                    curSettingsForm.labelStatus.ForeColor = Color.FromArgb(192, 0, 0);
                    curSettingsForm.labelStatus2.Text = "No";
                    curSettingsForm.labelStatus2.ForeColor = Color.FromArgb(192, 0, 0);
                    curSettingsForm.label1.Text = "Disabled";
                    curSettingsForm.label1.ForeColor = Color.FromArgb(192, 0, 0);
                }
                Thread.Sleep(1000);
            }
            catch
            {
                Thread.Sleep(1000);
            }
        }

        private void iconButtonHeroes_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, Color.Goldenrod))
                SetDesktopForm(new Form2(this));
        }

        private void iconButtonSecHeroes_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, Color.Goldenrod))
                SetDesktopForm(new SecretCharForm(this));
        }

        private void iconButtonDLC1_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, Color.Goldenrod))
                SetDesktopForm(new DLC1Form(this));
        }

        private void iconButtonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Goldenrod);
            if (curSettingsForm == null)
            {
                curSettingsForm = new SettingsForm(this);
                curSettingsForm.Show();
            }
        }

        private void iconButtonDLC2_Click(object sender, EventArgs e)
        {
            if (ActivateButton(sender, Color.Goldenrod))
                SetDesktopForm(new DLC2Form(this));
        }

        private void toggleButtonHP_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Hp = toggleButtonHP.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Hp = toggleButtonHP.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Hp = toggleButtonHP.Checked;
        }

        private void toggleButtonMovespeed_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Movespeed = toggleButtonMovespeed.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Movespeed = toggleButtonMovespeed.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Movespeed = toggleButtonMovespeed.Checked;
        }

        private void toggleButtonProjectiles_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Area = toggleButtonProjectiles.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Area = toggleButtonProjectiles.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Area = toggleButtonProjectiles.Checked;
        }

        private void toggleButtonExp_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Growth = toggleButtonExp.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Growth = toggleButtonExp.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Growth = toggleButtonExp.Checked;
        }

        private void toggleButtonGems_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Magnet = toggleButtonGems.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Magnet = toggleButtonGems.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Magnet = toggleButtonGems.Checked;
        }

        private void toggleButtonLuck_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Luck = toggleButtonLuck.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Luck = toggleButtonLuck.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Luck = toggleButtonLuck.Checked;
        }

        private void toggleButtonRegen_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Regen = toggleButtonRegen.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Regen = toggleButtonRegen.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Regen = toggleButtonRegen.Checked;
        }

        private void toggleButtonUnlock_CheckedChanged(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex >= 0)
                Hero.heroes[Script.currentHeroIndex].Unlocked = toggleButtonUnlock.Checked;
            else if (Script.currentDLCHeroIndex >= 0)
                DLCHero.heroes[Script.currentDLCHeroIndex].Unlocked = toggleButtonUnlock.Checked;
            else if (Script.currentDLC2HeroIndex >= 0)
                DLC2Hero.heroes[Script.currentDLC2HeroIndex].Unlocked = toggleButtonUnlock.Checked;
        }

        private void toggleButtonChangeAll_CheckStateChanged(object sender, EventArgs e)
        {
            CheckAllTogglers();
            Thread.Sleep(100);
            toggleButtonChangeAll.CheckState = CheckState.Unchecked;
        }

        private void iconButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.Path == null || Properties.Settings.Default.Path == string.Empty)
                {
                    MessageBox.Show(
                    "FIRST, SELECT PATH TO GAME LAUNCHER IN SETTINGS!",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                    return;
                }
                if (currentThread == null || !currentThread.IsAlive)
                {
                    GenerateThread generateThread = new GenerateThread();
                    currentThread = new Thread(new ThreadStart(generateThread.CallGenerate));
                    currentThread.Start();
                }
                else
                {
                    MessageBox.Show(
                    "PREVIOUS GENERATION IS STILL RUNNING",
                    "INFO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                EmailSender.CatchException(ex, "Error while generating");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserConfig.Heroes = Hero.heroes;
            UserConfig.DLCHeroes = DLCHero.heroes;
            UserConfig.DLC2Heroes = DLC2Hero.heroes;
            Application.Exit();
        }

        private void backgroundWorkerDlcChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorkerDlcChecker.RunWorkerAsync();
        }

        private void toggleButton1_Click(object sender, EventArgs e)
        {
            foreach (var hero in Hero.heroes)
                if (UserConfig.Subscription >= hero.Level)
                    hero.Unlocked = true;
            foreach (var hero in DLCHero.heroes)
                if (UserConfig.Subscription >= hero.Level)
                    hero.Unlocked = true;
            foreach (var hero in DLC2Hero.heroes)
                if (UserConfig.Subscription >= hero.Level)
                    hero.Unlocked = true;
            Thread.Sleep(100);
            toggleButtonUnlockAll.CheckState = CheckState.Unchecked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.buymeacoffee.com/Sacracia");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/sacracia");
        }
    }
}
