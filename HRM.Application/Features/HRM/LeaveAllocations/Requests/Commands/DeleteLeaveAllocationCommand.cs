using MediatR;

namespace HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
