using HRM.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Persistance
{
    public interface ILeaveRequestRepository : IBaseRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task ChangeApprovedStatus(LeaveRequest leaveRequest, bool? status);
    }
}
