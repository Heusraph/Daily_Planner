using MimeKit;
using MailKit.Security;

namespace PlannerService
{
    public class EmailService
    {
        public static void SendEmail(string userEmail, string firstname, string lastname)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Daily Plan", "test@example.com"));
            message.To.Add(new MailboxAddress("Profile", "raphaelbautista2@gmail.com"));
            message.Subject = "Email Connection";
            message.Body = new TextPart("plain")
            {
                Text = $"{firstname} {lastname}\n \n" +
                $"Your schedule has been successfully generated."

            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var userName = "e4f62a0478e705";
                var password = "ac387412394eeb";

                client.Connect(smtpHost, smtpPort, SecureSocketOptions.StartTls);
                client.Authenticate(userName, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}