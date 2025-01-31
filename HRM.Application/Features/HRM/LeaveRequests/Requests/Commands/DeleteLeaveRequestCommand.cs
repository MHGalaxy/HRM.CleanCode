using MediatR;

namespace HRM.Application.Features.HRM.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
