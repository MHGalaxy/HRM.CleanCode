using HRM.Application.Contracts.Infrastructure;
using HRM.Application.Contracts.Persistance;
using HRM.Application.DTOs.Models;
using HRM.Infrastructure.Senders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendGrid.Helpers.Mail;

namespace HRM.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SmtpEmailSetting>(configuration.GetSection("SmtpEmailSetting"));
            services.Configure<SendGridEmailSetting>(configuration.GetSection("SendGridEmailSetting"));
            services.AddTransient<ISmtpEmailSender, SmtpEmailSender>();
            services.AddTransient<IGridEmailSender, SendGridEmailSender>();

            return services;
        }
    }
}
