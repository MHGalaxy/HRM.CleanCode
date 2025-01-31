using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDTO>
    {
        public int Id { get; set; }

    }
}
