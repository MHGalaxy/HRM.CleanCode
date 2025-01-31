using HRM.Application.DTOs.HRM.LeaveRequest;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDTO>
    {
        public int Id { get; set; }

    }
}
