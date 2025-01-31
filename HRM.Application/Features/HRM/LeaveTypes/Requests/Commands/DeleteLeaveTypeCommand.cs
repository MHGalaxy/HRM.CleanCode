using MediatR;

namespace HRM.Application.Features.HRM.LeaveTypes.Requests.Commands
{
    public class DeleteLeaveTypeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
