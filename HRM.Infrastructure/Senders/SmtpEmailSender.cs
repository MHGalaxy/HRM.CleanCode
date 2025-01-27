using HRM.Application.Contracts.Infrastructure;
using HRM.Application.DTOs.Models;
using System.Net.Mail;
using System.Net;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace HRM.Infrastructure.Senders
{
    public class SmtpEmailSender : ISmtpEmailSender
    {
        private readonly SmtpEmailSetting _emailSettings;
        public SmtpEmailSender(IOptions<SmtpEmailSetting> emailSetting)
        {
            _emailSettings = emailSetting.Value;
        }

        public async Task<bool> SendEmailAsync(Email email)
        {
            using (var client = new SmtpClient(_emailSettings.Server, _emailSettings.Port))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);
                client.EnableSsl = true;

                var message = new MailMessage(_emailSettings.Username, email.To, email.Subject, email.Body)
                {
                    IsBodyHtml = true
                };

                try
                {
                    await client.SendMailAsync(message);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


    }
}
