using HRM.Domain.DTOs.LeaveType;
using MediatR;

namespace HRM.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public UpdateLeaveTypeDTO UpdateLeaveTypeDTO { get; set; }
    }
}
