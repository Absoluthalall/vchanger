using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Data;
using VSGen.Scripts;

namespace VSGen
{
    public partial class DLC2Form : Form
    {
        Form1 mainForm;
        public DLC2Form(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            if (UserConfig.Subscription <= 2)
            {
                pictureBoxGhoul.Image = Properties.Resources.black_Sprite_Rottin_Ghoul;
                pictureBoxGhoul.Enabled = false;
                pictureBoxCtrpcake.Image = Properties.Resources.black_Sprite_Sammy;
                pictureBoxCtrpcake.Enabled = false;
                pictureBoxMGenevieve.Image = Properties.Resources.black_Sprite_Je_Ne_Viv;
                pictureBoxMGenevieve.Enabled = false;
            }
            if (UserConfig.Subscription <= 1)
            {
                pictureBoxKeira.Image = Properties.Resources.black_Sprite_Keitha;
                pictureBoxKeira.Enabled = false;
                pictureBoxLuminaire.Image = Properties.Resources.black_Sprite_Luminaire_C;
                pictureBoxLuminaire.Enabled = false;
                pictureBoxGenevieve.Image = Properties.Resources.black_Sprite_Genevieve;
                pictureBoxGenevieve.Enabled = false;
            }
            if (UserConfig.Subscription == 0)
            {
                pictureBoxEleanor.Image = Properties.Resources.black_Sprite_Eleanor;
                pictureBoxEleanor.Enabled = false;
                pictureBoxVictor.Image = Properties.Resources.black_Sprite_Maruto;
                pictureBoxVictor.Enabled = false;
            }
        }

        private void DLC2Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxEleanor_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.ELEANOR;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Eleanor;
            mainForm.SetTogglers();
        }

        private void pictureBoxEleanor_MouseEnter(object sender, EventArgs e)
        {
            labelEleanor.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxEleanor_MouseLeave(object sender, EventArgs e)
        {
            labelEleanor.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxVictor_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.VICTOR;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Maruto;
            mainForm.SetTogglers();
        }

        private void pictureBoxVictor_MouseEnter(object sender, EventArgs e)
        {
            labelVictor.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxVictor_MouseLeave(object sender, EventArgs e)
        {
            labelVictor.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxKeira_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.KEIRA;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Keitha;
            mainForm.SetTogglers();
        }

        private void pictureBoxKeira_MouseEnter(object sender, EventArgs e)
        {
            labelKeira.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxKeira_MouseLeave(object sender, EventArgs e)
        {
            labelKeira.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxLuminaire_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.LUMINAIRE;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Luminaire;
            mainForm.SetTogglers();
        }

        private void pictureBoxLuminaire_MouseEnter(object sender, EventArgs e)
        {
            labelLuminaire.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxLuminaire_MouseLeave(object sender, EventArgs e)
        {
            labelLuminaire.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGenevieve_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.GENEVIEVE;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Genevieve;
            mainForm.SetTogglers();
        }

        private void pictureBoxGenevieve_MouseEnter(object sender, EventArgs e)
        {
            labelGenevieve.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGenevieve_MouseLeave(object sender, EventArgs e)
        {
            labelGenevieve.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMGenevieve_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.MEGAGENEVIEVE;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Je_Ne_Viv;
            mainForm.SetTogglers();
        }

        private void pictureBoxMGenevieve_MouseEnter(object sender, EventArgs e)
        {
            labelMGenevieve.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMGenevieve_MouseLeave(object sender, EventArgs e)
        {
            labelMGenevieve.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxCtrpcake_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.CTRPCAKE;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Sammy;
            mainForm.SetTogglers();
        }

        private void pictureBoxCtrpcake_MouseEnter(object sender, EventArgs e)
        {
            labelMCtrpcake.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxCtrpcake_MouseLeave(object sender, EventArgs e)
        {
            labelMCtrpcake.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGhoul_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentDLC2HeroIndex = (int)DLC2Hero.HeroList.GHOUL;
            Script.currentHeroIndex = -1;
            Script.currentDLCHeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Rottin_Ghoul;
            mainForm.SetTogglers();
        }

        private void pictureBoxGhoul_MouseEnter(object sender, EventArgs e)
        {
            labelGhoul.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGhoul_MouseLeave(object sender, EventArgs e)
        {
            labelGhoul.ForeColor = Color.Gainsboro;
        }
    }
}
