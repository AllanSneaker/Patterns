using System.Net;
using System.Net.Mail;

namespace Facade
{
    public class EmailCreator : IEmailFluentInterface
    {
        private readonly MailMessage _mailMessage;

        private EmailCreator(string fromAddress)
        {
            _mailMessage = new MailMessage
            {
                Sender = new MailAddress(fromAddress)
            };
        }

        public static IEmailFluentInterface CreateEmailFrom(string fromAddress)
        {
            return new EmailCreator(fromAddress);
        }

        public IEmailFluentInterface BCC(params string[] bccAddresses)
        {
            foreach (var bccAddress in bccAddresses)
            {
                _mailMessage.To.Add(new MailAddress(bccAddress));
            }
            return this;
        }

        public IEmailFluentInterface CC(params string[] ccAddresses)
        {
            foreach (var ccAddress in ccAddresses)
            {
                _mailMessage.To.Add(new MailAddress(ccAddress));
            }
            return this;
        }

        public IEmailFluentInterface From(string fromAddress)
        {
            return this;
        }

        public IEmailFluentInterface To(params string[] toAddresses)
        {
            foreach (var toAddress in toAddresses)
            {
                _mailMessage.To.Add(new MailAddress(toAddress));
            }
            return this;
        }

        public IEmailFluentInterface WithBody(string body)
        {
            _mailMessage.Body = body;
            return this;
        }

        public IEmailFluentInterface WithSubject(string subject)
        {
            _mailMessage.Subject = subject;
            return this;
        }

        public void Send()
        {
            SmtpClient smtpClient = new SmtpClient("smtpserver")
            {
                Credentials = CredentialCache.DefaultNetworkCredentials,
                Timeout = 100
            };
            smtpClient.Send(_mailMessage);

        }
    }
}
