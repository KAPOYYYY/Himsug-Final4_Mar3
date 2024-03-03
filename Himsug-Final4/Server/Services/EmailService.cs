using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using Himsug_Final4.Shared.Models;

namespace Himsug_Final4.Server.Services
{
    public class EmailService : IEmailservice
    {
        private readonly IConfiguration _config;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration config, ILogger<EmailService> logger)
        {
            _config = config;
            _logger = logger;

        }

        public void SendEmail(Shared.Models.EmailDto request)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(request.From));
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = "Test Email";
                email.Body = new TextPart()
                {
                    Text = "Tested Email, maybe"
                };

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate(_config.GetSection("EmailUserName").Value, _config.GetSection("EmailPassword").Value);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
                _logger.LogInformation("Email Sent!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send");
                throw new ApplicationException("Failed to Send", ex);
            }
        }

        //public void SendEmail(Model.EmailDto request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
