using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;

namespace HRM.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDTO CreateLeaveAllocationDTO { get; set; }
    }
}
