using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDTO UpdateLeaveAllocationDTO { get; set; }
    }
}
