using HRM.Domain.Entities.HRM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Persistance.HRM
{
    public interface ILeaveRequestRepository : IBaseRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task ChangeApprovedStatus(LeaveRequest leaveRequest, bool? status);
    }
}
