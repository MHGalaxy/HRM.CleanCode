using HRM.Application.DTOs.HRM.LeaveType;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public UpdateLeaveTypeDTO UpdateLeaveTypeDTO { get; set; }
    }
}
