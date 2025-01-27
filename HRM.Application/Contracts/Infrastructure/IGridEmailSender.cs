using HRM.Application.DTOs.Models;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Infrastructure
{
    public interface IGridEmailSender
    {
        Task<bool> SendEmailAsync(Email email);
    }
}
