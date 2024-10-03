using HRM.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRM.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDTO>
    {
        public int Id { get; set; }

    }
}
