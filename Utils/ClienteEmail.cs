using System;
using System.Net;
using System.Net.Mail;

namespace Utils
{
    public class ClienteEmail
    {
        public static void sendEmail(Email email)
        {
            String servidor = "smtp.gmail.com";
            int porta = 587;
            String login = "tesche.seguros@gmail.com";
            String senha = "e54inHMvS8xY9hR";
            MailMessage mailMessage = new MailMessage(
                    login,
                    email.destinatario,
                    email.assunto,
                    email.corpo);
            NetworkCredential networkCredential = new NetworkCredential(login, senha);
            SmtpClient smtpClient = new SmtpClient(servidor, porta);
            mailMessage.IsBodyHtml = true;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredential;
            smtpClient.Send(mailMessage);
        }
    }
}
