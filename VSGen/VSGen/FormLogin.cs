using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;
using VSGen.Config;
using VSGen.Scripts;

namespace VSGen
{
    public partial class FormLogin : Form
    {
        Form1 mainForm;
        int loginFails = 0;
        int loginErrors = 0;
        public FormLogin()
        {
            InitializeComponent();
            UserConfig.DPI = button1.Width / 169f;
            textBoxLogin.Text = Properties.Settings.Default.Email;
            textBoxPassword.Text = UserConfig.DecryptPassword();
            textBoxLogin.Font = new System.Drawing.Font(textBoxLogin.Font.Name, textBoxLogin.Font.Size * UserConfig.DPI);
            textBoxPassword.Font = new System.Drawing.Font(textBoxPassword.Font.Name, textBoxPassword.Font.Size * UserConfig.DPI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false;
            try
            {
                status = Script.LoginValid(textBoxLogin.Text, textBoxPassword.Text, out string nickName);
                if (status)
                {
                    Properties.Settings.Default.Email = textBoxLogin.Text;
                    UserConfig.EncryptPassword(textBoxPassword.Text); //Password saves automaticaly
                    UserConfig.Nickname = nickName;
                    UserConfig.Subscription = 3;//subscription;
                    mainForm = new Form1();
                    mainForm.Show();
                    Close();
                }
                else
                {
                    loginFails++;
                    labelError.Text = "Incorrect password/login " + (loginFails >= 2 ? $"x{loginFails}" : "") ;
                    labelError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("error.txt", ex.ToString());
                loginErrors++;
                labelError2.Text = "Error occured during authorization " + (loginErrors >= 2 ? $"x{loginErrors}" : "");
                labelError2.Visible = true;
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainForm == null)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.vampire-changer.site/RegisterForm/");
        }
    }
}
