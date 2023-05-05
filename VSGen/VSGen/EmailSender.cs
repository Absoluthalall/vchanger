using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace VSGen
{
    internal class EmailSender
    {
        internal static void CatchException(Exception ex, string subject)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                DialogResult result = MessageBox.Show(
                "Would you like to send the error to support?",
                "Error occured",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                    SendEmail(ex.ToString(), $"{subject} [{Properties.Settings.Default.Username}]");

            }
            else
            {
                MessageBox.Show(
                "You havent entered your username, so you cannot send the error to support!",
                "Error occured",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }
        private static bool SendEmail(string message, string subject)
        {
            try
            {
                string _email = "vchangersender@gmail.com";
                string _emailTo = "vchangerhelp@inbox.ru";
                string _authCode = Cryptor.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", "IDqYHfyJWRxB52bhcJw7D8ONP2AcYI8bKYTbhj7xsf0=");

                SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com", 587);

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false; ;
                mySmtpClient.EnableSsl = true;

                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential(_email, _authCode);
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress(_email, "VChangerSender");
                MailAddress to = new MailAddress(_emailTo, "VChangerSender");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // add ReplyTo
                MailAddress replyTo = new MailAddress("vchangersender@gmail.com");
                myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = subject;
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = message;
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = false;

                mySmtpClient.Send(myMail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
