using System;
using System.Drawing;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Data;
using VSGen.Scripts;

namespace VSGen
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
            if (UserConfig.Subscription <= 1)
            {
                pictureBoxPugnala.Image = Properties.Resources.black_Sprite_Pugnala;
                pictureBoxPugnala.Enabled = false;
                pictureBoxGiovanna.Image = Properties.Resources.black_Sprite_Giovanna;
                pictureBoxGiovanna.Enabled = false;
                pictureBoxPoppea.Image = Properties.Resources.black_Sprite_Poppea;
                pictureBoxPoppea.Enabled = false;
                pictureBoxConcetta.Image = Properties.Resources.black_Sprite_Concetta;
                pictureBoxConcetta.Enabled = false;
                pictureBoxMortaccio.Image = Properties.Resources.black_Sprite_Pugnala;
                pictureBoxMortaccio.Enabled = false;
                pictureBoxYatta.Image = Properties.Resources.black_Sprite_Cavallo;
                pictureBoxYatta.Enabled = false;
                pictureBoxRamba.Image = Properties.Resources.black_Sprite_Ramba;
                pictureBoxRamba.Enabled = false;
                pictureBoxOSOle.Image = Properties.Resources.black_Sprite_O_Sole;
                pictureBoxOSOle.Enabled = false;
                pictureBoxAmbrojoe.Image = Properties.Resources.black_Sprite_Ambrojoe;
                pictureBoxAmbrojoe.Enabled = false;
                pictureBoxGallo.Image = Properties.Resources.black_Sprite_Gallo;
                pictureBoxGallo.Enabled = false;
                pictureBoxDivano.Image = Properties.Resources.black_Sprite_Divano;
                pictureBoxDivano.Enabled = false;
                pictureBoxAssunta.Image = Properties.Resources.black_Sprite_Zi_Assunta;
                pictureBoxAssunta.Enabled = false;
                pictureBoxQueen.Image = Properties.Resources.black_Sprite_Sigma;
                pictureBoxQueen.Enabled = false;
            }
            if (UserConfig.Subscription == 0)
            {
                pictureBoxImelda.Image = Properties.Resources.black_Sprite_Imelda;
                pictureBoxImelda.Enabled = false;
                pictureBoxPasqualina.Image = Properties.Resources.black_Sprite_Pasqualina;
                pictureBoxPasqualina.Enabled = false;
                pictureBoxGennaro.Image = Properties.Resources.black_Sprite_Gennaro;
                pictureBoxGennaro.Enabled = false;
                pictureBoxArca.Image = Properties.Resources.black_Sprite_Arca;
                pictureBoxArca.Enabled = false;
                pictureBoxPorta.Image = Properties.Resources.black_Sprite_Porta;
                pictureBoxPorta.Enabled = false;
                pictureBoxLama.Image = Properties.Resources.black_Sprite_Lama;
                pictureBoxLama.Enabled = false;
                pictureBoxPoe.Image = Properties.Resources.black_Sprite_Poe;
                pictureBoxPoe.Enabled = false;
                pictureBoxSuor.Image = Properties.Resources.black_Sprite_Clerici;
                pictureBoxSuor.Enabled = false;
                pictureBoxDommario.Image = Properties.Resources.black_Sprite_Dommario;
                pictureBoxDommario.Enabled = false;
                pictureBoxKrochi.Image = Properties.Resources.black_Sprite_Krochi_2;
                pictureBoxKrochi.Enabled = false;
                pictureBoxChristine.Image = Properties.Resources.black_Sprite_Christine;
                pictureBoxChristine.Enabled = false;
            }
        }

        private void pictureBoxAntonio_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Antonio;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Antonio;
            mainForm.SetTogglers();
        }

        private void pictureBoxAntonio_MouseLeave(object sender, EventArgs e) =>
            labelAntonio.ForeColor = Color.Gainsboro;

        private void pictureBoxAntonio_MouseEnter(object sender, EventArgs e) =>
            labelAntonio.ForeColor = Color.Goldenrod;

        private void pictureBoxImelda_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Imelda;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Imelda;
            mainForm.SetTogglers();
        }

        private void pictureBoxImelda_MouseEnter(object sender, EventArgs e) =>
            labelImelda.ForeColor = Color.Goldenrod;

        private void pictureBoxImelda_MouseLeave(object sender, EventArgs e) =>
            labelImelda.ForeColor = Color.Gainsboro;

        private void pictureBoxPasqualina_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Pasqualina;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Pasqualina;
            mainForm.SetTogglers();
        }

        private void pictureBoxPasqualina_MouseEnter(object sender, EventArgs e) =>
            labelPasqualina.ForeColor = Color.Goldenrod;

        private void pictureBoxPasqualina_MouseLeave(object sender, EventArgs e) =>
            labelPasqualina.ForeColor = Color.Gainsboro;

        private void pictureBoxGennaro_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Gennaro;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Gennaro;
            mainForm.SetTogglers();
        }

        private void pictureBoxGennaro_MouseEnter(object sender, EventArgs e) =>
            labelGennaro.ForeColor = Color.Goldenrod;

        private void pictureBoxGennaro_MouseLeave(object sender, EventArgs e) =>
            labelGennaro.ForeColor = Color.Gainsboro;

        private void pictureBoxArca_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Arca;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Arca;
            mainForm.SetTogglers();
        }

        private void pictureBoxArca_MouseEnter(object sender, EventArgs e) =>
            labelArca.ForeColor = Color.Goldenrod;

        private void pictureBoxArca_MouseLeave(object sender, EventArgs e) =>
            labelArca.ForeColor = Color.Gainsboro;

        private void pictureBoxPorta_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Porta;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Porta;
            mainForm.SetTogglers();
        }

        private void pictureBoxPorta_MouseEnter(object sender, EventArgs e)
        {
            labelPorta.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxPorta_MouseLeave(object sender, EventArgs e)
        {
            labelPorta.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxLama_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Lama;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Lama;
            mainForm.SetTogglers();
        }

        private void pictureBoxLama_MouseEnter(object sender, EventArgs e)
        {
            labelLama.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxLama_MouseLeave(object sender, EventArgs e)
        {
            labelLama.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxPoe_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Poe;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Poe;
            mainForm.SetTogglers();
        }

        private void pictureBoxPoe_MouseEnter(object sender, EventArgs e)
        {
            labelPoe.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxPoe_MouseLeave(object sender, EventArgs e)
        {
            labelPoe.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxSuor_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Clerici;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Clerici;
            mainForm.SetTogglers();
        }

        private void pictureBoxSuor_MouseEnter(object sender, EventArgs e)
        {
            labelSuor.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxSuor_MouseLeave(object sender, EventArgs e)
        {
            labelSuor.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxDommario_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Dommario;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Dommario;
            mainForm.SetTogglers();
        }

        private void pictureBoxDommario_MouseEnter(object sender, EventArgs e)
        {
            labelDommario.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxDommario_MouseLeave(object sender, EventArgs e)
        {
            labelDommario.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxKrochi_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Krochi;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Krochi_2;
            mainForm.SetTogglers();
        }

        private void pictureBoxKrochi_MouseEnter(object sender, EventArgs e)
        {
            labelKrochi.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxKrochi_MouseLeave(object sender, EventArgs e)
        {
            labelKrochi.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxChristine_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Christine;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Christine;
            mainForm.SetTogglers();
        }

        private void pictureBoxChristine_MouseEnter(object sender, EventArgs e)
        {
            labelChristine.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxChristine_MouseLeave(object sender, EventArgs e)
        {
            labelChristine.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxPugnala_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Pugnala;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Pugnala;
            mainForm.SetTogglers();
        }

        private void pictureBoxPugnala_MouseEnter(object sender, EventArgs e)
        {
            labelPugnala.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxPugnala_MouseLeave(object sender, EventArgs e)
        {
            labelPugnala.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGiovanna_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Giovanna;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Giovanna;
            mainForm.SetTogglers();
        }

        private void pictureBoxGiovanna_MouseEnter(object sender, EventArgs e)
        {
            labelGiovanna.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGiovanna_MouseLeave(object sender, EventArgs e)
        {
            labelGiovanna.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxPoppea_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Poppea;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Poppea;
            mainForm.SetTogglers();
        }

        private void pictureBoxPoppea_MouseEnter(object sender, EventArgs e)
        {
            labelPoppea.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxPoppea_MouseLeave(object sender, EventArgs e)
        {
            labelPoppea.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxConcetta_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Concetta;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Concetta;
            mainForm.SetTogglers();
        }

        private void pictureBoxConcetta_MouseEnter(object sender, EventArgs e)
        {
            labelConcetta.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxConcetta_MouseLeave(object sender, EventArgs e)
        {
            labelConcetta.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxMortaccio_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Mortaccio;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Mortaccio;
            mainForm.SetTogglers();
        }

        private void pictureBoxMortaccio_MouseEnter(object sender, EventArgs e)
        {
            labelMortaccio.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxMortaccio_MouseLeave(object sender, EventArgs e)
        {
            labelMortaccio.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxYatta_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Cavallo;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Cavallo;
            mainForm.SetTogglers();
        }

        private void pictureBoxYatta_MouseEnter(object sender, EventArgs e)
        {
            labelYatta.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxYatta_MouseLeave(object sender, EventArgs e)
        {
            labelYatta.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxRamba_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Ramba;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Ramba;
            mainForm.SetTogglers();
        }

        private void pictureBoxRamba_MouseEnter(object sender, EventArgs e)
        {
            labelRamba.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxRamba_MouseLeave(object sender, EventArgs e)
        {
            labelRamba.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxOSOle_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.OSole;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_O_Sole;
            mainForm.SetTogglers();
        }

        private void pictureBoxOSOle_MouseEnter(object sender, EventArgs e)
        {
            labelOSole.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxOSOle_MouseLeave(object sender, EventArgs e)
        {
            labelOSole.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxAmbrojoe_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Ambrojoe;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Ambrojoe;
            mainForm.SetTogglers();
        }

        private void pictureBoxAmbrojoe_MouseEnter(object sender, EventArgs e)
        {
            labelAmbrojoe.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxAmbrojoe_MouseLeave(object sender, EventArgs e)
        {
            labelAmbrojoe.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxGallo_MouseEnter(object sender, EventArgs e)
        {
            labelGallo.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxGallo_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Gallo;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Gallo;
            mainForm.SetTogglers();
        }

        private void pictureBoxGallo_MouseLeave(object sender, EventArgs e)
        {
            labelGallo.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxDivano_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Divano;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Divano;
            mainForm.SetTogglers();
        }

        private void pictureBoxDivano_MouseEnter(object sender, EventArgs e)
        {
            labelDivano.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxDivano_MouseLeave(object sender, EventArgs e)
        {
            labelDivano.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxAssunta_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.ZiAssunta;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Zi_Assunta;
            mainForm.SetTogglers();
        }

        private void pictureBoxAssunta_MouseEnter(object sender, EventArgs e)
        {
            labelAssunta.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxAssunta_MouseLeave(object sender, EventArgs e)
        {
            labelAssunta.ForeColor = Color.Gainsboro;
        }

        private void pictureBoxQueen_Click(object sender, EventArgs e)
        {
            if (Script.currentHeroIndex < 0 && Script.currentDLCHeroIndex < 0 && Script.currentDLC2HeroIndex < 0) mainForm.EnableTogglers();
            Script.currentHeroIndex = (int)Hero.HeroList.Sigma;
            Script.currentDLCHeroIndex = -1;
            Script.currentDLC2HeroIndex = -1;
            mainForm.pictureBoxAvatar.Image = Properties.Resources.Animated_Sigma;
            mainForm.SetTogglers();
        }

        private void pictureBoxQueen_MouseEnter(object sender, EventArgs e)
        {
            labelQueen.ForeColor = Color.Goldenrod;
        }

        private void pictureBoxQueen_MouseLeave(object sender, EventArgs e)
        {
            labelQueen.ForeColor = Color.Gainsboro;
        }
    }
}
