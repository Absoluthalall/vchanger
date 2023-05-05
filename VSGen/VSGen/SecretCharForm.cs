using System;
using System.Drawing;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Data;
using VSGen.Scripts;

namespace VSGen
{
    public partial class SecretCharForm : Form
    {
        Form1 mainForm;
        public SecretCharForm(Form1 Form)
        {
            mainForm = Form;
            InitializeComponent();
            if (UserConfig.Subscription <= 2)
            {
                pictureBoxGains.Image = Properties.Resources.black_Sprite_Marrabbio;
                pictureBoxGains.Enabled = false;
                pictureBoxGyorunton.Image = Properties.Resources.black_Sprite_Gyorunton;
                pictureBoxGyorunton.Enabled = false;
                pictureBoxRedDeath.Image = Properties.Resources.black_Sprite_Red_Death;
                pictureBoxRedDeath.Enabled = false;
                pictureBoxOni.Image = Properties.Resources.black_Sprite_Scorej_Oni;
                pictureBoxOni.Enabled = false;
            }
            if (UserConfig.Subscription <= 1)
            {
                pictureBoxMinnah.Image = Properties.Resources.black_Sprite_Minnah;
                pictureBoxMinnah.Enabled = false;
                pictureBoxLeda.Image = Properties.Resources.black_Sprite_Leda;
                pictureBoxLeda.Enabled = false;
                pictureBoxCosmo.Image = Properties.Resources.black_Sprite_Cosmo;
                pictureBoxCosmo.Enabled = false;
                pictureBoxPeppino.Image = Properties.Resources.black_Sprite_Peppino;
                pictureBoxPeppino.Enabled = false;
                pictureBoxTrouser.Image = Properties.Resources.black_Sprite_Trouser;
                pictureBoxTrouser.Enabled = false;
            }
            if (UserConfig.Subscription == 0)
            {
                pictureBoxExdash.Image = Properties.Resources.black_Sprite_Exdash;
                pictureBoxExdash.Enabled = false;
                pictureBoxToastie.Image = Properties.Resources.black_Sprite_Toastie;
                pictureBoxToastie.Enabled = false;
                pictureBoxSmith.Image = Properties.Resources.black_Sprite_Smith;
                pictureBoxSmith.Enabled = false;
                pictureBoxBoon.Image = Properties.Resources.black_Sprite_Marrabbio;
                pictureBoxBoon.Enabled = false;
                pictureBoxAvatar.Image = Properties.Resources.black_Sprite_Avatar;
                pictureBoxAvatar.Enabled = false;
            }
        }

        private void SecretCharForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxExdash_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Exdash;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Exdash;
            mainForm.SetTogglers();
        }

        private void pictureBoxExdash_MouseEnter(object sender, EventArgs e)
        {
            labelExdash.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxExdash_MouseLeave(object sender, EventArgs e)
        {
            labelExdash.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxToastie_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Toastie;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Toastie;
            mainForm.SetTogglers();
        }

        private void pictureBoxToastie_MouseEnter(object sender, EventArgs e)
        {
            labelToastie.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxToastie_MouseLeave(object sender, EventArgs e)
        {
            labelToastie.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxSmith_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.SmithIV;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Smith;
            mainForm.SetTogglers();
        }

        private void pictureBoxSmith_MouseEnter(object sender, EventArgs e)
        {
            labelSmith.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxSmith_MouseLeave(object sender, EventArgs e)
        {
            labelSmith.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxBoon_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Marrabbio;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Marrabbio;
            mainForm.SetTogglers();
        }

        private void pictureBoxBoon_MouseEnter(object sender, EventArgs e)
        {
            labelBoon.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxBoon_MouseLeave(object sender, EventArgs e)
        {
            labelBoon.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Avatar;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Avatar;
            mainForm.SetTogglers();
        }

        private void pictureBoxAvatar_MouseEnter(object sender, EventArgs e)
        {
            labelAvatar.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxAvatar_MouseLeave(object sender, EventArgs e)
        {
            labelAvatar.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMinnah_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Minnah;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Minnah;
            mainForm.SetTogglers();
        }

        private void pictureBoxMinnah_MouseEnter(object sender, EventArgs e)
        {
            labelMinnah.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMinnah_MouseLeave(object sender, EventArgs e)
        {
            labelMinnah.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxLeda_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Leda;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Leda;
            mainForm.SetTogglers();
        }

        private void pictureBoxLeda_MouseEnter(object sender, EventArgs e)
        {
            labelLeda.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxLeda_MouseLeave(object sender, EventArgs e)
        {
            labelLeda.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxCosmo_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Cosmo;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Cosmo;
            mainForm.SetTogglers();
        }

        private void pictureBoxCosmo_MouseEnter(object sender, EventArgs e)
        {
            labelCosmo.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxCosmo_MouseLeave(object sender, EventArgs e)
        {
            labelCosmo.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxPeppino_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Peppino;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Sprite_Peppino;
            mainForm.SetTogglers();
        }

        private void pictureBoxPeppino_MouseEnter(object sender, EventArgs e)
        {
            labelPeppino.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxPeppino_MouseLeave(object sender, EventArgs e)
        {
            labelPeppino.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxTrouser_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Trouser;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Trouser;
            mainForm.SetTogglers();
        }

        private void pictureBoxTrouser_MouseEnter(object sender, EventArgs e)
        {
            labelTrouser.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxTrouser_MouseLeave(object sender, EventArgs e)
        {
            labelTrouser.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGains_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Gains;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Gains;
            mainForm.SetTogglers();
        }

        private void pictureBoxGains_MouseEnter(object sender, EventArgs e)
        {
            labelGains.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGains_MouseLeave(object sender, EventArgs e)
        {
            labelGains.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGyorunton_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Gyorunton;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Gyorunton;
            mainForm.SetTogglers();
        }

        private void pictureBoxGyorunton_MouseEnter(object sender, EventArgs e)
        {
            labelGyorunton.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGyorunton_MouseLeave(object sender, EventArgs e)
        {
            labelGyorunton.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxRedDeath_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.RedDeath;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Red_Death;
            mainForm.SetTogglers();
        }

        private void pictureBoxRedDeath_MouseEnter(object sender, EventArgs e)
        {
            labelRedDeath.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxRedDeath_MouseLeave(object sender, EventArgs e)
        {
            labelRedDeath.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxOni_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.ScorejOni;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Scorej_Oni;
            mainForm.SetTogglers();
        }

        private void pictureBoxOni_MouseEnter(object sender, EventArgs e)
        {
            labelOni.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxOni_MouseLeave(object sender, EventArgs e)
        {
            labelOni.ForeColor = Color.Gainsboro;
        }
    }
}
