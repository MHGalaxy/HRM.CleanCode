using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDTO CreateLeaveAllocationDTO { get; set; }
    }
}
