using HRM.Application.Contracts.Infrastructure;
using HRM.Application.DTOs.Models;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Threading.Tasks;
using System.Net;

namespace HRM.Infrastructure.Senders
{
    public class SendGridEmailSender : IGridEmailSender
    {
        private readonly SendGridEmailSetting _emailSettings;
        public SendGridEmailSender(IOptions<SendGridEmailSetting> emailSetting)
        {
            _emailSettings = emailSetting.Value;
        }

        public async Task<bool> SendEmailAsync(Email email)
        {
            var client = new SendGridClient(_emailSettings.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };

            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
            var response = await client.SendEmailAsync(message);
            return response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted;
        }
    }
}
