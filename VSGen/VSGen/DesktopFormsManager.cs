using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSGen
{
    public partial class Form1 : Form
    {
        public static Form currentForm;
        public static SettingsForm settingsForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn; //Левая панель кнопки

        private void SetDesktopForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private bool ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                if (currentBtn != null && currentBtn.Name == (senderBtn as IconButton).Name)
                    return false;
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34, 0, 0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.Size = new Size(7, currentBtn.Height);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.AutoSize = true;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                return true;
            }
            return false;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 0, 0);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
