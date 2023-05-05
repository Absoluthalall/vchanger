using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSGen.Scripts;
using VSGen.Data;
using VSGen.Config;

namespace VSGen
{
    public partial class DLC1Form : Form
    {
        Form1 mainForm;
        public DLC1Form(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            if (UserConfig.Subscription <= 2)
            {
                pictureBoxMMenya.Image = Properties.Resources.black_Sprite_Megalo_Menya;
                pictureBoxMMenya.Enabled = false;
                pictureBoxMSyuuto.Image = Properties.Resources.black_Sprite_Megalo_Syuuto;
                pictureBoxMSyuuto.Enabled = false;
                pictureBoxGavet.Image = Properties.Resources.black_Sprite_Gav_Et_Oni;
                pictureBoxGavet.Enabled = false;
            }
            if (UserConfig.Subscription <= 1)
            {
                pictureBoxSyuuto.Image = Properties.Resources.black_Sprite_Syuuto;
                pictureBoxSyuuto.Enabled = false;
                pictureBoxBabi.Image = Properties.Resources.black_Sprite_Babi_Onna;
                pictureBoxBabi.Enabled = false;
                pictureBoxMccoy.Image = Properties.Resources.black_Sprite_McCoy_Oni;
                pictureBoxMccoy.Enabled = false;
            }
            if (UserConfig.Subscription == 0)
            {
                pictureBoxMiang.Image = Properties.Resources.black_Sprite_Miang;
                pictureBoxMiang.Enabled = false;
                pictureBoxMenya.Image = Properties.Resources.black_Sprite_Menya;
                pictureBoxMenya.Enabled = false;
            }
        }

        private void pictureBoxMiang_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.MIANG;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Miang;
            mainForm.SetTogglers();
        }

        private void pictureBoxMiang_MouseEnter(object sender, EventArgs e)
        {
            labelMiang.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMiang_MouseLeave(object sender, EventArgs e)
        {
            labelMiang.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMenya_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.MENYA;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Menya;
            mainForm.SetTogglers();
        }

        private void pictureBoxMenya_MouseEnter(object sender, EventArgs e)
        {
            labelMenya.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMenya_MouseLeave(object sender, EventArgs e)
        {
            labelMenya.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxSyuuto_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.SYUUTO;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Syuuto;
            mainForm.SetTogglers();
        }

        private void pictureBoxSyuuto_MouseEnter(object sender, EventArgs e)
        {
            labelSyuuto.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxSyuuto_MouseLeave(object sender, EventArgs e)
        {
            labelSyuuto.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxBabi_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.ONNA;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Babi_Onna;
            mainForm.SetTogglers();
        }

        private void pictureBoxBabi_MouseEnter(object sender, EventArgs e)
        {
            labelBabi.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxBabi_MouseLeave(object sender, EventArgs e)
        {
            labelBabi.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMccoy_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.MCCOY;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_McCoy_Oni;
            mainForm.SetTogglers();
        }

        private void pictureBoxMccoy_MouseEnter(object sender, EventArgs e)
        {
            labelMccoy.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMccoy_MouseLeave(object sender, EventArgs e)
        {
            labelMccoy.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMMenya_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.MEGAMENYA;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Megalo_Menya;
            mainForm.SetTogglers();
        }

        private void pictureBoxMMenya_MouseEnter(object sender, EventArgs e)
        {
            labelMMenya.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMMenya_MouseLeave(object sender, EventArgs e)
        {
            labelMMenya.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMSyuuto_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.MEGASYUUTO;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Megalo_Syuuto;
            mainForm.SetTogglers();
        }

        private void pictureBoxMSyuuto_MouseEnter(object sender, EventArgs e)
        {
            labelMSyuuto.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMSyuuto_MouseLeave(object sender, EventArgs e)
        {
            labelMSyuuto.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGavet_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLCHeroIndex = (int)DLCHero.HeroList.TONY;
            Script.currentHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Gav_Et_Oni;
            mainForm.SetTogglers();
        }

        private void pictureBoxGavet_MouseEnter(object sender, EventArgs e)
        {
            labelGavet.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGavet_MouseLeave(object sender, EventArgs e)
        {
            labelGavet.ForeColor = Color.Gainsboro;
        }
    }
}
